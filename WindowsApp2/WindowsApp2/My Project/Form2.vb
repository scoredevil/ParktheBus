Public Class Form2
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        Dim filenumber As Integer = FreeFile()
        FileOpen(filenumber, "d:\test.txt", OpenMode.Append)
        PrintLine(filenumber, TextBox1.Text + "-" + TextBox2.Text + "-" + ComboBox1.Text + "-" + ComboBox2.Text)
        MessageBox.Show("Saved Successfully")
        FileClose(filenumber)
        Me.Hide()
        Form1.Show()

    End Sub
End Class