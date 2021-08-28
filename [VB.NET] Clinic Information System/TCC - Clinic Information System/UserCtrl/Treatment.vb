Imports MySql.Data.MySqlClient
Public Class Treatment
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String

    Public Sub ConnectDB()
        conn = New MySqlConnection
        conn.ConnectionString = "SERVER=localhost;PORT=3306;USERID=root;PASSWORD=;DATABASE=tcc_clinic;"
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            mini_treatment.l_idx.Text = row.Cells("ID").Value.ToString
            mini_treatment.t_id.Text = row.Cells("ID_LRN").Value.ToString
            mini_treatment.t_name.Text = row.Cells("Name").Value.ToString
            mini_treatment.t_cy.Text = row.Cells("Course_Year").Value.ToString
            mini_treatment.t_comp.Text = row.Cells("Complaints").Value.ToString
            mini_treatment.t_inter.Text = row.Cells("Intervention").Value.ToString
            mini_treatment.t_remarks.Text = row.Cells("Remarks").Value.ToString
            mini_treatment.Show()
            mini_treatment.Button2.Visible = False
            mini_treatment.Button1.Visible = True
            mini_treatment.Text = "Treatment | View - Form"
        End If
    End Sub

    Private Sub t_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_search.KeyPress
        View_treat_search()
    End Sub

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        print_web.Show()
        print_web.sheet.Text = "treatment"



        'Dim MysqlAdapter As New MySqlDataAdapter
        'Dim MysqlReader As MySqlDataReader
        'Try
        '    conn.Open()
        '    query = "Select * from treatment"
        '    cmd = New MySqlCommand(query, conn)
        '    MysqlAdapter.SelectCommand = cmd
        '    MysqlAdapter.Fill()
        '    'MysqlReader = cmd.ExecuteReader
        '    'MysqlReader.Read()
        '    conn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Wait a minute!!")
        'Finally
        '    conn.Dispose()
        '    conn.Close()
        'End Try

        'Try
        '    ConnectDB()





        '    Dim objRpt As New pr_Treatmentz
        '    Print_Referral.CrystalReportViewer1.ReportSource = objRpt
        '    Print_Referral.CrystalReportViewer1.Refresh()
        '    Print_Referral.Show()
        'Catch ex As MySqlException
        '    MsgBox(ex.Message)
        'Finally
        '    conn.Close()
        'End Try


    End Sub

    Private Sub t_search_Click(sender As Object, e As EventArgs) Handles t_search.Click

    End Sub

    Private Sub t_search_KeyUp(sender As Object, e As KeyEventArgs) Handles t_search.KeyUp
        View_treat_search()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frm_login.Show()
        frm_main.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_account.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub
End Class
