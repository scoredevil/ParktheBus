Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filenumber As Integer = FreeFile()
        Dim tempA As String = ""
        Dim tempS As String
        FileOpen(filenumber, "d:\test.txt", OpenMode.Input)
        Do Until EOF(filenumber)
            tempS = LineInput(filenumber)
            tempA += tempS + vbCrLf
        Loop
        FileClose(filenumber)
        TextBox1.Text = tempS
    End Sub
End Class