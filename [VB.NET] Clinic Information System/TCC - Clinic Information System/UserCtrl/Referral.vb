Public Class Referral

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            Report_Referral.l_idx.Text = row.Cells("ID").Value.ToString
            Report_Referral.l_name.Text = row.Cells("Name").Value.ToString
            Report_Referral.l_age.Text = row.Cells("Age").Value.ToString
            Report_Referral.l_cy.Text = row.Cells("Course_Year").Value.ToString
            Report_Referral.l_reason.Text = row.Cells("Reason").Value.ToString
            Report_Referral.l_ref.Text = row.Cells("Referral_By").Value.ToString
            Report_Referral.l_date.Text = CStr(row.Cells("Date").Value)
            Report_Referral.Show()
            ref_viewx()
        End If
    End Sub

    Private Sub t_search_Click(sender As Object, e As EventArgs) Handles t_search.Click

    End Sub

    Private Sub t_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_search.KeyPress
        View_ref_search()
    End Sub

    Private Sub t_search_KeyUp(sender As Object, e As KeyEventArgs) Handles t_search.KeyUp
        View_ref_search()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_account.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frm_login.Show()
        frm_main.Close()
    End Sub
End Class
