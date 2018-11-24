Public Class Simplepad

    Dim CurrentFile As String
    Dim HidingForm? As Boolean = True
    Dim FileOpen As Boolean


    Private Sub OpenDialog(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFile()
        End If
    End Sub

    Private Sub OpenFile()
        rtxtNotepad.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        CurrentFile = OpenFileDialog1.FileName
        Me.Text = System.IO.Path.GetFileName(CurrentFile) + " - Simplepad"
        Debug.Print("Opened file: " & CurrentFile)
        txtWorkingFile.Text = CurrentFile
        btnReload.Enabled = True
    End Sub

    Private Sub SaveFile(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If CurrentFile = Nothing Then
            SaveAs()
        Else
            My.Computer.FileSystem.WriteAllText(CurrentFile, rtxtNotepad.Text, False)
            Debug.Print("Saved to file: " & CurrentFile)
        End If
    End Sub

    Private Sub btnSaveAs(sender As Object, e As EventArgs)
        SaveAs()
    End Sub

    Private Sub SaveAs()
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentFile = SaveFileDialog1.FileName
            My.Computer.FileSystem.WriteAllText(CurrentFile, rtxtNotepad.Text, False)
            Debug.Print("Saved to file: " & CurrentFile)
            Me.Text = System.IO.Path.GetFileName(CurrentFile) + " - Simplepad"
            txtWorkingFile.Text = CurrentFile
            btnReload.Enabled = True
        End If
    End Sub

    Private Sub NewFile(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        CurrentFile = Nothing
        rtxtNotepad.Text = ""
        txtWorkingFile.Text = CurrentFile
        Me.Text = "Untitled - Simplepad"
        Debug.Print("New file created")
        btnReload.Enabled = False
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked Then
            WordWrapToolStripMenuItem.Checked = False
            rtxtNotepad.WordWrap = False
        Else
            WordWrapToolStripMenuItem.Checked = True
            rtxtNotepad.WordWrap = True
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtxtNotepad.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        If CurrentFile = Nothing Then
            btnReload.Enabled = False
        Else
            rtxtNotepad.Text = My.Computer.FileSystem.ReadAllText(CurrentFile)
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each argument As String In My.Application.CommandLineArgs
            CurrentFile = argument
            OpenFile()
        Next
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click

    End Sub
End Class
