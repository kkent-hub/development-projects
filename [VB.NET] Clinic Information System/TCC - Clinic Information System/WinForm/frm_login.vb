Public Class frm_login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not CheckBox1.Checked = False Then
            t_pass.UseSystemPasswordChar = False
        Else
            t_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Statusxd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If t_pass.Text = "" Or t_user.Text = "" Then
            MsgBox("Please Enter the following..", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "Empty")
        Else
            loginXD()
            t_user.Text = ""
            t_pass.Text = ""
        End If
    End Sub
End Class