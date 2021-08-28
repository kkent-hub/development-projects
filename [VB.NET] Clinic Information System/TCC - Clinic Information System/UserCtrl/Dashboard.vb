Imports System.IO
Public Class Dashboard
    Private Sub Dashboard_load(sender As Object, e As EventArgs) Handles Label17.Click
        View_Students()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        line_1.Visible = False
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            frm_main.Information1.l_idx.Text = row.Cells("Std_ID").Value.ToString
            frm_main.Information1.Dock = DockStyle.Fill
            frm_main.Information1.Visible = True
            Display_Information()
            frm_main.Register1.Visible = False
            frm_main.Dashboard1.Visible = False
        End If
    End Sub

    Private Sub l_name_1_Click(sender As Object, e As EventArgs) Handles l_name_1.Click
        If Not id3.Text = "idx" Then
            frm_main.Information1.l_idx.Text = id1.Text
            frm_main.Information1.Dock = DockStyle.Fill
            frm_main.Information1.Visible = True
            Display_Information()
            frm_main.Register1.Visible = False
            frm_main.Dashboard1.Visible = False
        End If
    End Sub

    Private Sub l_name_2_Click(sender As Object, e As EventArgs) Handles l_name_2.Click
        If Not id3.Text = "idx" Then
            frm_main.Information1.l_idx.Text = id2.Text
            frm_main.Information1.Dock = DockStyle.Fill
            frm_main.Information1.Visible = True
            Display_Information()
            frm_main.Register1.Visible = False
            frm_main.Dashboard1.Visible = False
        End If
    End Sub

    Private Sub l_name_3_Click(sender As Object, e As EventArgs) Handles l_name_3.Click
        If Not id3.Text = "idx" Then
            frm_main.Information1.l_idx.Text = id3.Text
            frm_main.Information1.Dock = DockStyle.Fill
            frm_main.Information1.Visible = True
            Display_Information()
            frm_main.Register1.Visible = False
            frm_main.Dashboard1.Visible = False
        End If
    End Sub

    Private Sub t_search_KeyUp(sender As Object, e As KeyEventArgs) Handles t_search.KeyUp
        View_Students_search()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_account.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frm_login.Show()
        frm_main.Close()
    End Sub

    Private Sub t_search_Click(sender As Object, e As EventArgs) Handles t_search.Click

    End Sub
End Class
