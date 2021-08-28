Imports System.IO
Public Class Register


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'upload_img.FileName = ""
        'upload_img.Filter = "Select Image (*.png,*.jpg,*.jpeg,*.bmp)| *.png; *.jpg; *.jpeg; *.bmp;"
        'upload_img.ShowDialog()
        'url.Text = upload_img.FileName
        'std_img.ImageLocation = url.Text
        Cam.Show()
    End Sub

    Private Sub t_id_LostFocus(sender As Object, e As EventArgs) Handles t_id.LostFocus
        Verify_Std()
    End Sub

    Private Sub Yes_1_OnChange(sender As Object, e As EventArgs) Handles Yes_1.OnChange
        If Yes_1.Checked = True Then
            No_1.Checked = False
        Else
            No_1.Checked = True
        End If
    End Sub

    Private Sub No_1_OnChange(sender As Object, e As EventArgs) Handles No_1.OnChange
        If No_1.Checked = True Then
            Yes_1.Checked = False
        Else
            Yes_1.Checked = True
        End If
    End Sub

    Private Sub Yes_2_OnChange(sender As Object, e As EventArgs) Handles Yes_2.OnChange
        If Yes_2.Checked = True Then
            No_2.Checked = False
        Else
            No_2.Checked = True
        End If
    End Sub

    Private Sub Yes_3_OnChange(sender As Object, e As EventArgs) Handles Yes_3.OnChange
        If Yes_3.Checked = True Then
            No_3.Checked = False
        Else
            No_3.Checked = True
        End If
    End Sub

    Private Sub Yes_4_OnChange(sender As Object, e As EventArgs) Handles Yes_4.OnChange
        If Yes_4.Checked = True Then
            No_4.Checked = False
        Else
            No_4.Checked = True
        End If
    End Sub

    Private Sub Yes_5_OnChange(sender As Object, e As EventArgs) Handles Yes_5.OnChange
        If Yes_5.Checked = True Then
            No_5.Checked = False
        Else
            No_5.Checked = True
        End If
    End Sub

    Private Sub Yes_6_OnChange(sender As Object, e As EventArgs) Handles Yes_6.OnChange
        If Yes_6.Checked = True Then
            No_6.Checked = False
        Else
            No_6.Checked = True
        End If
    End Sub

    Private Sub Yes_7_OnChange(sender As Object, e As EventArgs) Handles Yes_7.OnChange
        If Yes_7.Checked = True Then
            No_7.Checked = False
        Else
            No_7.Checked = True
        End If
    End Sub

    Private Sub Yes_8_OnChange(sender As Object, e As EventArgs) Handles Yes_8.OnChange
        If Yes_8.Checked = True Then
            No_8.Checked = False
        Else
            No_8.Checked = True
        End If
    End Sub

    Private Sub Yes_9_OnChange(sender As Object, e As EventArgs) Handles Yes_9.OnChange
        If Yes_9.Checked = True Then
            No_9.Checked = False
        Else
            No_9.Checked = True
        End If
    End Sub

    Private Sub No_2_OnChange(sender As Object, e As EventArgs) Handles No_2.OnChange
        If No_2.Checked = True Then
            Yes_2.Checked = False
        Else
            Yes_2.Checked = True
        End If
    End Sub

    Private Sub No_3_OnChange(sender As Object, e As EventArgs) Handles No_3.OnChange
        If No_3.Checked = True Then
            Yes_3.Checked = False
        Else
            Yes_3.Checked = True
        End If
    End Sub

    Private Sub No_4_OnChange(sender As Object, e As EventArgs) Handles No_4.OnChange
        If No_4.Checked = True Then
            Yes_4.Checked = False
        Else
            Yes_4.Checked = True
        End If
    End Sub

    Private Sub No_5_OnChange(sender As Object, e As EventArgs) Handles No_5.OnChange
        If No_5.Checked = True Then
            Yes_5.Checked = False
        Else
            Yes_5.Checked = True
        End If
    End Sub

    Private Sub No_6_OnChange(sender As Object, e As EventArgs) Handles No_6.OnChange
        If No_6.Checked = True Then
            Yes_6.Checked = False
        Else
            Yes_6.Checked = True
        End If
    End Sub

    Private Sub No_7_OnChange(sender As Object, e As EventArgs) Handles No_7.OnChange
        If No_7.Checked = True Then
            Yes_7.Checked = False
        Else
            Yes_7.Checked = True
        End If
    End Sub

    Private Sub No_8_OnChange(sender As Object, e As EventArgs) Handles No_8.OnChange
        If No_8.Checked = True Then
            Yes_8.Checked = False
        Else
            Yes_8.Checked = True
        End If
    End Sub

    Private Sub No_9_OnChange(sender As Object, e As EventArgs) Handles No_9.OnChange
        If No_9.Checked = True Then
            Yes_9.Checked = False
        Else
            Yes_9.Checked = True
        End If
    End Sub

    Private Sub t_ot_yes_OnChange(sender As Object, e As EventArgs) Handles t_ot_yes1.OnChange
        If t_ot_yes1.Checked = True Then
            t_ot_no1.Checked = False
            t_if_yes.Enabled = True
        Else
            t_ot_no1.Checked = True
            t_if_yes.Enabled = False
        End If
    End Sub

    Private Sub t_ot_no_OnChange(sender As Object, e As EventArgs) Handles t_ot_no1.OnChange
        If t_ot_no1.Checked = True Then
            t_ot_yes1.Checked = False
            t_if_yes.Enabled = False
        Else
            t_ot_yes1.Checked = True
            t_if_yes.Enabled = True
        End If
    End Sub


    Private Sub t_ot_no2_OnChange(sender As Object, e As EventArgs) Handles t_ot_no2.OnChange
        If t_ot_no2.Checked = True Then
            t_ot_yes2.Checked = False
        Else
            t_ot_yes2.Checked = True
        End If
    End Sub

    Private Sub t_ot_yes2_OnChange(sender As Object, e As EventArgs) Handles t_ot_yes2.OnChange
        If t_ot_yes2.Checked = True Then
            t_ot_no2.Checked = False
        Else
            t_ot_no2.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If t_id.Text = "" Or t_lname.Text = "" Or t_fname.Text = "" Or t_mname.Text = "" Or t_gender.Text = "" Or t_course.Text = "" Or t_bloodtype.Text = "" Or t_civilstatus.Text = "" Or t_contactno.Text = "" Or _
            t_city.Text = "" Or t_province.Text = "" Or t_street.Text = "" Or t_lot.Text = "" Or t_house.Text = "" Or t_em_contact.Text = "" Or t_em_name.Text = "" Or t_em_relationship.Text = "" Or _
            t_bmi.Text = "" Or t_bmi_1.Text = "" Or t_rr.Text = "" Or t_bmi.Text = "" Or t_bmi_1.Text = "" Or t_temp.Text = "" Or t_pr.Text = "" Or t_height.Text = "" Or t_weight.Text = "" Or t_lmp.Text = "" Or t_visual.Text = "" Or _
            t_ot_health_condition.Text = "" Or t_ot_outcome.Text = "" Then
            MsgBox("Please Enter the following", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "Fill up")
        Else
            Try
                Dim dir As String
                dir = Application.StartupPath.ToString & "\Images\" & t_id.Text & ".jpg"
                std_img.Image.Save(dir)
                Student_Info()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub t_birthdate_ValueChanged(sender As Object, e As EventArgs) Handles t_birthdate.ValueChanged
        Dim tar, tempdate As Date
        Dim y, m As Integer
        tar = DateAndTime.Now
        If t_birthdate.Value > tar Then
            MsgBox("Invalid Birth Date. Please try again", CType(vbExclamation + vbOKOnly, MsgBoxStyle), "Wait a Minute!!")
            t_birthdate.Value = tar
        End If
        y = CInt(DateDiff("yyyy", t_birthdate.Value, tar))
        tempdate = DateAdd("yyyy", y, t_birthdate.Value)
        If tempdate > tar Then
            y = y - 1
            tempdate = DateAdd("yyyy", -1, tempdate)
        End If

        m = CInt(DateDiff("m", tempdate, tar))
        tempdate = DateAdd("m", m, tempdate)
        If tempdate > tar Then
            m = m - 1
            tempdate = DateAdd("m", -1, tempdate)
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub t_id_Click(sender As Object, e As EventArgs) Handles t_id.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_main.Dashboard1.Dock = DockStyle.Fill
        frm_main.Dashboard1.Visible = True
        View_Students()

        frm_main.Register1.Visible = False
        frm_main.Information1.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frm_account.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frm_login.Show()
        frm_main.Close()
    End Sub

    Private Sub t_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_gender.SelectedIndexChanged
        If t_gender.Text Like "Male" Then
            Label26.Visible = False
            Yes_9.Visible = False
            No_9.Visible = False
            No_9.Checked = True
            Yes_9.Checked = False
        Else
            Label26.Visible = True
            Yes_9.Visible = True
            No_9.Visible = True
            No_9.Checked = False
            Yes_9.Checked = True
        End If
    End Sub
    Dim BACKSPACE As Boolean
    Private Sub t_contactno_KeyDown(sender As Object, e As KeyEventArgs) Handles t_contactno.KeyDown
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub t_contactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_contactno.KeyPress
        If BACKSPACE = False Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub t_contactno_TextChanged(sender As Object, e As EventArgs) Handles t_contactno.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        prov_display()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'std_img.Image = cap.QueryFrame.ToBitmap()
    End Sub

    Private Sub al_none_OnChange(sender As Object, e As EventArgs) Handles al_none.OnChange
        If al_none.Checked = True Then
            t_alcohol.Text = ""
        End If
    End Sub

    Private Sub t_alcohol_TextChanged(sender As Object, e As EventArgs) Handles t_alcohol.TextChanged
        If t_alcohol.Text = "" Then
            al_none.Checked = True
        Else
            al_none.Checked = False
        End If
    End Sub

    Private Sub t_smoke_OnChange(sender As Object, e As EventArgs) Handles al_smoke.OnChange
        If al_smoke.Checked = True Then
            t_smoking.Text = ""
        End If
    End Sub

    Private Sub t_smoking_TextChanged(sender As Object, e As EventArgs) Handles t_smoking.TextChanged
        If t_smoking.Text = "" Then
            al_smoke.Checked = True
        Else
            al_smoke.Checked = False
        End If
    End Sub

    Private Sub al_contro_OnChange(sender As Object, e As EventArgs) Handles al_contro.OnChange
        If al_contro.Checked = True Then
            t_contraceptive.Text = ""
        End If
    End Sub

    Private Sub t_contraceptive_TextChanged(sender As Object, e As EventArgs) Handles t_contraceptive.TextChanged
        If t_contraceptive.Text = "" Then
            al_contro.Checked = True
        Else
            al_contro.Checked = False
        End If
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        std_img.ImageLocation = "Images\default.jpg"
    End Sub

    Private Sub t_em_contact_KeyDown(sender As Object, e As KeyEventArgs) Handles t_em_contact.KeyDown
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub t_em_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_em_contact.KeyPress
        If BACKSPACE = False Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub t_height_TextChanged(sender As Object, e As EventArgs) Handles t_height.TextChanged
        t_bmi_1.Text = t_height.Text
    End Sub

    Private Sub t_weight_TextChanged(sender As Object, e As EventArgs) Handles t_weight.TextChanged
        t_bmi.Text = t_weight.Text
    End Sub

    Private Sub t_em_contact_TextChanged(sender As Object, e As EventArgs) Handles t_em_contact.TextChanged

    End Sub

    Private Sub t_province_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_province.SelectedIndexChanged
        prov_clicked()
    End Sub

    Private Sub t_city_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_city.SelectedIndexChanged
        city_clicked()
    End Sub
End Class
