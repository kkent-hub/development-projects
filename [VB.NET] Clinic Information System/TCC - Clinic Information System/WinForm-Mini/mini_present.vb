Public Class mini_present

    Private Sub mini_present_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mini_presentz()
        pre_histry_answers()
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            l_idx.Text = row.Cells("ID").Value.ToString
            l_date.Text = CStr(row.Cells("Date").Value)
            pre_histry_answers()
        End If
    End Sub
End Class