Public Class frm_account

    Private Sub frm_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_Accounts()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If t_name.Text = "" Or t_user.Text = "" Or t_pass.Text = "" Then
            MsgBox("Please Enter the following", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "Warning")
        Else
            Create_Accounts()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not CheckBox1.Checked = False Then
            t_pass.UseSystemPasswordChar = False
        Else
            t_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            l_idx.Text = row.Cells("ID").Value.ToString
            t_name.Text = row.Cells("Name").Value.ToString
            t_user.Text = row.Cells("Username").Value.ToString
            t_pass.Text = row.Cells("Password").Value.ToString
            CheckBox1.Checked = True
            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        t_name.Text = ""
        t_user.Text = ""
        t_pass.Text = ""
        CheckBox1.Checked = False
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If t_name.Text = "" Or t_user.Text = "" Or t_pass.Text = "" Then
            MsgBox("Please Enter the following", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "Warning")
        Else
            update_Accounts()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        remove_Accounts()
        t_name.Text = ""
        t_user.Text = ""
        t_pass.Text = ""
        CheckBox1.Checked = False
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
    End Sub
End Class