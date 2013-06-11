Imports ExpTreeLib
Imports System.Threading
Imports System.IO

Public Class Form1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SystemImageListManager.SetListViewImageList(lv1, True, False)
        SystemImageListManager.SetListViewImageList(lv1, False, False)

        'In this case, the below is perfectly safe. It is not recommended as
        ' a general solution. Feel free to modify this demo to properly do
        ' cross thread modification of the ListView. 
        Control.CheckForIllegalCrossThreadCalls = False

        cbView.SelectedIndex = 2

        Reset()
    End Sub


    Private TRANSFERFILE As Boolean

    Private BackList As ArrayList
    Private LastSelectedCSI As CShItem
    Private Shared Event1 As New ManualResetEvent(True)
    Dim testTime As New DateTime(1, 1, 1, 0, 0, 0) 'avoid Globalization problem-- an empty timevalue

    Private Sub AfterNodeSelect(ByVal pathName As String, ByVal CSI As CShItem) Handles ExpTree1.ExpTreeNodeSelected
        Dim dirList As New ArrayList()
        Dim fileList As New ArrayList()
        Dim TotalItems As Integer

        LastSelectedCSI = CSI
        If CSI.DisplayName.Equals(CShItem.strMyComputer) Then
            dirList = CSI.GetDirectories 'avoid re-query since only has dirs
        Else
            dirList = CSI.GetDirectories
            fileList = CSI.GetFiles
        End If

        TotalItems = dirList.Count + fileList.Count
        Event1.WaitOne()

        If TotalItems > 0 Then
            Dim item As CShItem
            dirList.Sort()
            fileList.Sort()
            Me.Text = pathName
            Dim combList As New ArrayList(TotalItems)
            combList.AddRange(dirList)
            combList.AddRange(fileList)

            'Build the ListViewItems & add to lv1
            lv1.BeginUpdate()
            lv1.Items.Clear()
            For Each item In combList
                Dim lvi As New ListViewItem(item.DisplayName)
                With lvi
                    If Not item.IsDisk And item.IsFileSystem And Not item.IsFolder Then
                        If item.Length > 1024 Then
                            .SubItems.Add(Format(item.Length / 1024, "#,### KB"))
                        Else
                            .SubItems.Add(Format(item.Length, "##0 Bytes"))
                        End If
                    Else
                        .SubItems.Add("")
                    End If
                    .SubItems.Add(item.TypeName)
                    If item.IsDisk Then
                        .SubItems.Add("")
                    Else
                        If item.LastWriteTime = testTime Then '"#1/1/0001 12:00:00 AM#" is empty
                            .SubItems.Add("")
                        Else
                            .SubItems.Add(item.LastWriteTime)
                        End If
                    End If
                    '.ImageIndex = SystemImageListManager.GetIconIndex(item, False)
                    .Tag = item
                End With
                lv1.Items.Add(lvi)
            Next
            lv1.EndUpdate()
            LoadLV1Images()
        Else
            lv1.Items.Clear()
        End If
    End Sub

    Private Sub lv1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv1.MouseDoubleClick
        Dim lvi As ListViewItem = lv1.GetItemAt(e.X, e.Y)
        If IsNothing(lvi) Then Exit Sub
        If IsNothing(lv1.SelectedItems) OrElse lv1.SelectedItems.Count < 1 Then Exit Sub

        Dim item As CShItem = lv1.SelectedItems(0).Tag
        If item.IsFolder Then
            Event1.WaitOne()

            ExpTree1.ExpandANode(item)
        End If
    End Sub



#Region "IconIndex Loading Thread"
    Private Sub LoadLV1Images()
        Dim ts As New ThreadStart(AddressOf DoLoadLv)
        Dim ot As New Thread(ts)

        ot.SetApartmentState(ApartmentState.STA)

        Event1.Reset()
        ot.Start()
    End Sub

    Private Sub DoLoadLv()
        Dim lvi As ListViewItem
        For Each lvi In lv1.Items
            lvi.ImageIndex = SystemImageListManager.GetIconIndex(lvi.Tag, False)
        Next
        Event1.Set()
    End Sub
#End Region

    Private Sub cbView_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbView.SelectedIndexChanged
        Select Case cbView.SelectedIndex
            Case 1 : lv1.View = View.SmallIcon
            Case 2 : lv1.View = View.List
            Case 3 : lv1.View = View.Details
            Case 4 : lv1.View = View.Tile
            Case Else : lv1.View = View.LargeIcon
        End Select
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs)
        For Each i As ListViewItem In lv1.SelectedItems
            Dim c As CShItem = DirectCast(i.Tag, CShItem)
            If Not c.IsFolder Then
                If IO.File.Exists(c.Path) Then lv2.Items.Add(New ListViewItem(c.Path))
            End If
        Next
    End Sub

    Private Sub btnAddAll_Click(sender As System.Object, e As System.EventArgs)
        For Each i As ListViewItem In lv1.Items
            Dim c As CShItem = DirectCast(i.Tag, CShItem)
            If Not c.IsFolder Then
                If IO.File.Exists(c.Path) Then lv2.Items.Add(New ListViewItem(c.Path))
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs)
        For Each lvi As ListViewItem In lv2.SelectedItems
            lv2.Items.Remove(lvi)
        Next
    End Sub

    Private Sub lv1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lv1.ItemDrag
        With lv1
            If .SelectedItems.Count > 0 Then
                Dim toDrag As New ArrayList()
                Dim lvItem As ListViewItem
                Dim strD(.SelectedItems.Count - 1) As String
                Dim i As Integer
                For Each lvItem In .SelectedItems
                    toDrag.Add(lvItem.Tag)
                    strD(i) = CType(lvItem.Tag, CShItem).Path
                    i += 1
                Next

                'NOTE: FileDrop allowing auto conversion will generate
                ' a Shell IDList Array on demand... but in some cases, the
                ' resultant PIDLs can be different from what we want, so
                ' do our own.
                Dim Dobj As New DataObject()
                Dim ms As MemoryStream
                ms = CProcDataObject.MakeShellIDArray(toDrag)
                With Dobj
                    If Not ms Is Nothing Then
                        .SetData("Shell IDList Array", True, ms)
                    End If
                    .SetData("FileDrop", True, strD)
                    .SetData(toDrag)
                End With

                Dim dEff As DragDropEffects
                If e.Button = Windows.Forms.MouseButtons.Right Then
                    dEff = DragDropEffects.Copy Or DragDropEffects.Move Or DragDropEffects.Link
                Else
                    dEff = DragDropEffects.Copy Or DragDropEffects.Move
                End If

                Dim res As DragDropEffects = .DoDragDrop(Dobj, dEff)
            End If
        End With
    End Sub

    Private Sub lv2_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lv2.DragDrop
        Dim fList() As String = e.Data.GetData("FileDrop", True)

        Dim S As String
        For Each S In fList
            If File.Exists(S) Then lv2.Items.Add(New ListViewItem(S))
        Next

        e.Effect = DragDropEffects.None
    End Sub

    Private Sub lv2_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lv2.DragEnter
        If e.Data.GetDataPresent("FileDrop", True) And _
           ((e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    
    Private Sub Button_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click
        TRANSFERFILE = Not CBool(DirectCast(sender, Button).Tag.ToString)

        If TRANSFERFILE Then
            TabPage2.Text = "Source Files"
        Else
            TabPage2.Text = "Source Directory"
        End If

        panelFile.Visible = TRANSFERFILE
        panelDirectory.Visible = Not TRANSFERFILE

        TabPage1.Enabled = False
        GoToNextTab(1)
    End Sub

    Private Sub GoToNextTab(ByVal nextTabIndex As Integer)

        Select Case nextTabIndex
            Case 1
                TabControl1.SelectedIndex = 1
            Case 2
                TabControl1.SelectedIndex = 2
            Case Else
                TabControl1.SelectedIndex += 1
        End Select

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabPage1.Enabled = True Then TabControl1.SelectedIndex = 0
    End Sub
    
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Reset()
    End Sub

    Private Sub btnDirectoryName_Click(sender As System.Object, e As System.EventArgs) Handles btnDirectoryName.Click
        Dim fbd As New FolderBrowserDialog
        fbd.ShowDialog()

        If Directory.Exists(fbd.SelectedPath) Then
            txtDirectoryName.Text = fbd.SelectedPath
            lv2.Items.Clear()

            AddFilename(New DirectoryInfo(fbd.SelectedPath))
        End If
    End Sub

    Private Sub AddFilename(ByVal di As DirectoryInfo)
        'list all files
        Dim fileList() As FileInfo = di.GetFiles()
        For Each fi As FileInfo In fileList
            lv2.Items.Add(fi.FullName)
        Next

        'recursive directories
        Dim dirList() As DirectoryInfo = di.GetDirectories()
        If dirList.Length > 0 Then
            For Each dir As DirectoryInfo In dirList
                AddFilename(dir)
            Next
        End If
    End Sub

    Private Sub Reset()
        lv2.Items.Clear()

        TabPage1.Enabled = True
        TabControl1.SelectedIndex = 0
    End Sub
End Class