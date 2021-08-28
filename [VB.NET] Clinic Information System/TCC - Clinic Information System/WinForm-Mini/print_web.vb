Public Class print_web

    Private Sub print_web_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = DateAndTime.Now.Year.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "1ST Semester" Then
            Process.Start("http://localhost/print/?sheet=" & sheet.Text & "&Semester=1&Year=" & TextBox1.Text)
        ElseIf ComboBox1.Text = "2ND Semester" Then
            Process.Start("http://localhost/print/?sheet=" & sheet.Text & "&Semester=2&Year=" & TextBox1.Text)
        End If

    End Sub
End Class