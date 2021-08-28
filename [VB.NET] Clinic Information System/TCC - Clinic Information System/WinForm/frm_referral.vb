Public Class frm_referral

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtValue As Date = DateAndTime.Now
        Dim txtvalue_format As String = Format(txtValue, "MMM d, yyyy")
        Dim myReport As New pr_Referralz
        myReport.SetParameterValue("t_date", txtvalue_format)
        myReport.SetParameterValue("t_name", t_name.Text)
        myReport.SetParameterValue("t_age", t_age.Text)
        myReport.SetParameterValue("t_course_year", t_course_year.Text)
        myReport.SetParameterValue("t_address", t_address.Text)
        myReport.SetParameterValue("t_reason", t_reason.Text)
        myReport.SetParameterValue("t_temp", t_temp.Text)
        myReport.SetParameterValue("t_hr", t_hr.Text)
        myReport.SetParameterValue("t_rr", t_rr.Text)
        myReport.SetParameterValue("t_bp", t_bp.Text)
        myReport.SetParameterValue("t_inter", t_inter.Text)
        Dim std_ref As String = ""
        If r1.Checked = True Then
            std_ref = r1.Text
        End If
        If r2.Checked = True Then
            std_ref = r2.Text
        End If
        If r3.Checked = True Then
            std_ref = r3.Text
        End If
        myReport.SetParameterValue("t_rs", std_ref)
        myReport.SetParameterValue("t_ref", l_ref.Text)
        Print_Referral.CrystalReportViewer1.ReportSource = myReport
        Print_Referral.CrystalReportViewer1.Refresh()
        Print_Referral.Show()
        referral_save()
    End Sub
End Class