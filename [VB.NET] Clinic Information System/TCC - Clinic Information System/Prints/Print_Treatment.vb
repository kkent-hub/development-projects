Imports MySql.Data.MySqlClient
Public Class Print_Treatment

    Private Sub Print_Treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim rsp As New CrystalReport1
            'CrystalReportViewer1.ReportSource = rsp
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class