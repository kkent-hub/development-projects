Public Class mini_other
    Public Sub color_fontx()
        If q2.Text = "Yes" Then
            q2.ForeColor = Color.Lime
        Else
            q2.ForeColor = Color.Red
        End If
        If q4.Text = "Yes" Then
            q4.ForeColor = Color.Lime
        Else
            q4.ForeColor = Color.Red
        End If
    End Sub
    Private Sub mini_other_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mini_otherz()
        other_histry_answers()
        color_fontx()
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            l_idx.Text = row.Cells("ID").Value.ToString
            l_date.Text = CStr(row.Cells("Date").Value)
            other_histry_answers()
        End If
    End Sub
End Class