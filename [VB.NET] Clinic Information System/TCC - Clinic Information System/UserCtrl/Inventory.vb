Public Class Inventory


    Private Sub t_search_KeyUp(sender As Object, e As KeyEventArgs) Handles t_search.KeyUp
        View_Inventory_search()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If t_med.Text = "" Or t_stock.Text = "" Then
            MsgBox("Please Enter the following.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "EMPTY")
        Else
            verify_inventory()
            t_med.Text = ""
            t_stock.Text = ""
            t_expired.Text = DateAndTime.Now.AddYears(3).ToString
            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
        End If
    End Sub
    Dim BACKSPACE As Boolean

    Private Sub t_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles t_stock.KeyDown
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub t_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_stock.KeyPress
        If BACKSPACE = False Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub data_view_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            l_med.Text = row.Cells("Medicine").Value.ToString
            t_med.Text = row.Cells("Medicine").Value.ToString
            t_stock.Text = row.Cells("Stock").Value.ToString
            t_expired.Text = row.Cells("Expiration").Value.ToString
            Button1.Visible = True
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = True
        End If
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        t_med.Text = ""
        t_stock.Text = ""
        t_expired.Text = DateAndTime.Now.AddYears(3).ToString
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If t_med.Text = "" Or t_stock.Text = "" Then
            MsgBox("Please Enter the following.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "EMPTY")
        Else
            update_inventory()
            t_med.Text = ""
            t_stock.Text = ""
            t_expired.Text = DateAndTime.Now.AddYears(3).ToString
            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        remove_inventory()
        t_med.Text = ""
        t_stock.Text = ""
        t_expired.Text = DateAndTime.Now.AddYears(3).ToString
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = False
    End Sub
End Class
