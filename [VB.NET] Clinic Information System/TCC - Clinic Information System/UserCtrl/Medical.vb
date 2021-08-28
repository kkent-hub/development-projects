Public Class Medical

    Private Sub t_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_search.KeyPress
        View_medical_search()
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            mini_medical_01.l_idx.Text = row.Cells("ID").Value.ToString
            mini_medical_01.t_name.Text = row.Cells("Name").Value.ToString
            mini_medical_01.t_id.Text = row.Cells("ID_LRN").Value.ToString
            mini_medical_01.t_name.Text = row.Cells("Name").Value.ToString
            mini_medical_01.t_cy.Text = row.Cells("Course_Year").Value.ToString
            mini_medical_01.t_comp.Text = row.Cells("Complaints").Value.ToString
            mini_medical_01.t_medical_D.Text = row.Cells("Medicine_Dispensed").Value.ToString
            mini_medical_01.t_num.Text = row.Cells("No").Value.ToString
            mini_medical_01.t_time.Text = row.Cells("Time").Value.ToString
            mini_medical_01.Show()
            mini_medical_01.Button2.Visible = False
            mini_medical_01.Button1.Visible = True
            mini_medical_01.Text = "Treatment | View - Form"
        End If
    End Sub

    Private Sub t_search_Click(sender As Object, e As EventArgs) Handles t_search.Click

    End Sub

    Private Sub t_search_KeyUp(sender As Object, e As KeyEventArgs) Handles t_search.KeyUp
        View_medical_search()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_account.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frm_login.Show()
        frm_main.Close()
    End Sub

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        print_web.Show()
        print_web.sheet.Text = "medical"
    End Sub
End Class
