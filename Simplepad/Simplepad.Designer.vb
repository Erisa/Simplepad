<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simplepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simplepad))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rtxtNotepad = New System.Windows.Forms.RichTextBox()
        Me.btnOpen1 = New System.Windows.Forms.Button()
        Me.txtWorkingFile = New System.Windows.Forms.TextBox()
        Me.btnSaveFile1 = New System.Windows.Forms.Button()
        Me.btnSaveAs1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FormatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(335, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.ShowShortcutKeys = False
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.ShowShortcutKeys = False
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.WordWrapToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.Checked = True
        Me.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'rtxtNotepad
        '
        Me.rtxtNotepad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtNotepad.Location = New System.Drawing.Point(12, 27)
        Me.rtxtNotepad.MaxLength = 0
        Me.rtxtNotepad.Name = "rtxtNotepad"
        Me.rtxtNotepad.Size = New System.Drawing.Size(314, 196)
        Me.rtxtNotepad.TabIndex = 0
        Me.rtxtNotepad.Text = ""
        '
        'btnOpen1
        '
        Me.btnOpen1.Location = New System.Drawing.Point(12, 263)
        Me.btnOpen1.Name = "btnOpen1"
        Me.btnOpen1.Size = New System.Drawing.Size(100, 28)
        Me.btnOpen1.TabIndex = 1
        Me.btnOpen1.Text = "Open File"
        Me.btnOpen1.UseVisualStyleBackColor = True
        '
        'txtWorkingFile
        '
        Me.txtWorkingFile.Location = New System.Drawing.Point(12, 297)
        Me.txtWorkingFile.Name = "txtWorkingFile"
        Me.txtWorkingFile.ReadOnly = True
        Me.txtWorkingFile.Size = New System.Drawing.Size(309, 20)
        Me.txtWorkingFile.TabIndex = 2
        '
        'btnSaveFile1
        '
        Me.btnSaveFile1.Location = New System.Drawing.Point(118, 263)
        Me.btnSaveFile1.Name = "btnSaveFile1"
        Me.btnSaveFile1.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveFile1.TabIndex = 3
        Me.btnSaveFile1.Text = "Save File"
        Me.btnSaveFile1.UseVisualStyleBackColor = True
        '
        'btnSaveAs1
        '
        Me.btnSaveAs1.Location = New System.Drawing.Point(224, 263)
        Me.btnSaveAs1.Name = "btnSaveAs1"
        Me.btnSaveAs1.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveAs1.TabIndex = 4
        Me.btnSaveAs1.Text = "Save As..."
        Me.btnSaveAs1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(54, 229)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 28)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New File"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Enabled = False
        Me.btnReload.Location = New System.Drawing.Point(169, 229)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(100, 28)
        Me.btnReload.TabIndex = 6
        Me.btnReload.Text = "Reload File"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 327)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.rtxtNotepad)
        Me.Controls.Add(Me.txtWorkingFile)
        Me.Controls.Add(Me.btnSaveAs1)
        Me.Controls.Add(Me.btnSaveFile1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnOpen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Simplepad - Simple Notepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtxtNotepad As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOpen1 As System.Windows.Forms.Button
    Friend WithEvents txtWorkingFile As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveFile1 As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button

End Class
