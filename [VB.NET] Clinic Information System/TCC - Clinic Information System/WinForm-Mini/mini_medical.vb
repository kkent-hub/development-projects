Public Class mini_medical

    Public Sub color_fontx()
        If l_q1.Text = "Yes" Then
            l_q1.ForeColor = Color.Green
        Else
            l_q1.ForeColor = Color.Red
        End If
        If l_q2.Text = "Yes" Then
            l_q2.ForeColor = Color.Green
        Else
            l_q2.ForeColor = Color.Red
        End If
        If l_q3.Text = "Yes" Then
            l_q3.ForeColor = Color.Green
        Else
            l_q3.ForeColor = Color.Red
        End If
        If l_q4.Text = "Yes" Then
            l_q4.ForeColor = Color.Green
        Else
            l_q4.ForeColor = Color.Red
        End If
        If l_q5.Text = "Yes" Then
            l_q5.ForeColor = Color.Green
        Else
            l_q5.ForeColor = Color.Red
        End If
        If l_q6.Text = "Yes" Then
            l_q6.ForeColor = Color.Green
        Else
            l_q6.ForeColor = Color.Red
        End If
        If l_q7.Text = "Yes" Then
            l_q7.ForeColor = Color.Green
        Else
            l_q7.ForeColor = Color.Red
        End If
        If l_q8.Text = "Yes" Then
            l_q8.ForeColor = Color.Green
        Else
            l_q8.ForeColor = Color.Red
        End If
        If l_q9.Text = "Yes" Then
            l_q9.ForeColor = Color.Green
        Else
            l_q9.ForeColor = Color.Red
        End If
    End Sub

    Private Sub mini_medical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mini_medicalz()
        med_histry_answers()
        color_fontx()
    End Sub

    Private Sub data_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_view.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = data_view.Rows(e.RowIndex)
            l_idx.Text = row.Cells("ID").Value.ToString
            l_date.Text = CStr(row.Cells("Date").Value)
            med_histry_answers()
            color_fontx()
        End If
    End Sub
End Class