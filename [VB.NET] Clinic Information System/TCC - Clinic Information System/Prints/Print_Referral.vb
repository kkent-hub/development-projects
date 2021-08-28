Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class Print_Referral
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String

    Private cox As New MySqlConnection("SERVER=localhost;PORT=3306;USERID=root;PASSWORD=;DATABASE=tcc_clinic;")

    Private Sub Print_Referral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim MysqlAdapter As New MySqlDataAdapter
        Dim DataSetz As New DataSet

        query = "SELECT ID, `Date`, ID_LRN, Name, Course_Year, Complaints, Intervention, Signature, Remarks FROM treatment"

        Try
            cox.Open()
            cmd = New MySqlCommand(query, cox)
            MysqlAdapter.SelectCommand = cmd
            MysqlAdapter.Fill(DataSetz)
            'Dim objRpt As New 'CrystalReport1
            'objRpt.SetDataSource(DataSetz)
            'CrystalReportViewer1.ReportSource = objRpt
            'CrystalReportViewer1.Refresh()
            cmd.Dispose()
            MysqlAdapter.Dispose()
            DataSetz.Dispose()
            cox.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cox.Close()
        End Try

    End Sub
End Class