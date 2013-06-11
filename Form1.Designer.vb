<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.lv2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbView = New System.Windows.Forms.ComboBox()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.ExpTree1 = New ExpTreeLib.ExpTree()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.panelFile = New System.Windows.Forms.Panel()
        Me.panelDirectory = New System.Windows.Forms.Panel()
        Me.btnDirectoryName = New System.Windows.Forms.Button()
        Me.txtDirectoryName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.panelFile.SuspendLayout()
        Me.panelDirectory.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lv2)
        Me.TabPage2.Controls.Add(Me.panelFile)
        Me.TabPage2.Controls.Add(Me.panelDirectory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(978, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Source Files"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(415, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 75)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(415, 198)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 75)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "X"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(415, 117)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(75, 75)
        Me.btnAddAll.TabIndex = 8
        Me.btnAddAll.Text = ">>"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'lv2
        '
        Me.lv2.AllowDrop = True
        Me.lv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lv2.GridLines = True
        Me.lv2.Location = New System.Drawing.Point(510, 13)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(461, 450)
        Me.lv2.TabIndex = 4
        Me.lv2.UseCompatibleStateImageBehavior = False
        Me.lv2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Filename"
        Me.ColumnHeader1.Width = 421
        '
        'cbView
        '
        Me.cbView.FormattingEnabled = True
        Me.cbView.Items.AddRange(New Object() {"Large Icons", "Small Icons", "List", "Details", "Tile"})
        Me.cbView.Location = New System.Drawing.Point(209, 6)
        Me.cbView.Name = "cbView"
        Me.cbView.Size = New System.Drawing.Size(200, 24)
        Me.cbView.TabIndex = 2
        '
        'lv1
        '
        Me.lv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lv1.Location = New System.Drawing.Point(209, 36)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(200, 417)
        Me.lv1.TabIndex = 1
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'ExpTree1
        '
        Me.ExpTree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExpTree1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExpTree1.Location = New System.Drawing.Point(3, 6)
        Me.ExpTree1.Name = "ExpTree1"
        Me.ExpTree1.ShowRootLines = False
        Me.ExpTree1.Size = New System.Drawing.Size(200, 447)
        Me.ExpTree1.StartUpDirectory = ExpTreeLib.ExpTree.StartDir.Desktop
        Me.ExpTree1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(978, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transfer Method"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "What do you want to transfer?"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(53, 130)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Tag = "1"
        Me.Button2.Text = "Directory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 82)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Tag = "0"
        Me.Button1.Text = "File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(986, 502)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(978, 473)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Log"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(852, 524)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'panelFile
        '
        Me.panelFile.Controls.Add(Me.ExpTree1)
        Me.panelFile.Controls.Add(Me.lv1)
        Me.panelFile.Controls.Add(Me.btnAdd)
        Me.panelFile.Controls.Add(Me.cbView)
        Me.panelFile.Controls.Add(Me.btnRemove)
        Me.panelFile.Controls.Add(Me.btnAddAll)
        Me.panelFile.Location = New System.Drawing.Point(7, 7)
        Me.panelFile.Name = "panelFile"
        Me.panelFile.Size = New System.Drawing.Size(497, 456)
        Me.panelFile.TabIndex = 10
        '
        'panelDirectory
        '
        Me.panelDirectory.Controls.Add(Me.Label2)
        Me.panelDirectory.Controls.Add(Me.txtDirectoryName)
        Me.panelDirectory.Controls.Add(Me.btnDirectoryName)
        Me.panelDirectory.Location = New System.Drawing.Point(7, 7)
        Me.panelDirectory.Name = "panelDirectory"
        Me.panelDirectory.Size = New System.Drawing.Size(497, 456)
        Me.panelDirectory.TabIndex = 11
        '
        'btnDirectoryName
        '
        Me.btnDirectoryName.Location = New System.Drawing.Point(430, 87)
        Me.btnDirectoryName.Name = "btnDirectoryName"
        Me.btnDirectoryName.Size = New System.Drawing.Size(27, 23)
        Me.btnDirectoryName.TabIndex = 0
        Me.btnDirectoryName.Text = "..."
        Me.btnDirectoryName.UseVisualStyleBackColor = True
        '
        'txtDirectoryName
        '
        Me.txtDirectoryName.Location = New System.Drawing.Point(26, 87)
        Me.txtDirectoryName.Name = "txtDirectoryName"
        Me.txtDirectoryName.Size = New System.Drawing.Size(398, 22)
        Me.txtDirectoryName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select directory"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(978, 473)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Destination Directory"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destination Directory"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(398, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Example (without quotes): ""C:\Temp"" "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 10)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(962, 457)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(414, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 40)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Transfer Now"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 576)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "File Transfer"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.panelFile.ResumeLayout(False)
        Me.panelDirectory.ResumeLayout(False)
        Me.panelDirectory.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lv2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbView As System.Windows.Forms.ComboBox
    Friend WithEvents lv1 As System.Windows.Forms.ListView
    Friend WithEvents ExpTree1 As ExpTreeLib.ExpTree
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents panelFile As System.Windows.Forms.Panel
    Friend WithEvents panelDirectory As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDirectoryName As System.Windows.Forms.TextBox
    Friend WithEvents btnDirectoryName As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
