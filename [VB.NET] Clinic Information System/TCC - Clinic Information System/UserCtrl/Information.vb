Imports System.IO
Public Class Information

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

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        If btn_01.Text = "Edit" Then
            l_name_1.Visible = False
            t_lname.Visible = True
            t_fname.Visible = True
            t_mname.Visible = True
            t_course.Visible = True
            t_year.Visible = True
            t_gender.Visible = True
            t_blood_type.Visible = True
            t_civil_status.Visible = True
            t_contact_no.Visible = True
            t_street.Visible = True
            t_brgy.Visible = True
            t_lot.Visible = True
            t_home.Visible = True
            t_home_add.Visible = True
            t_pre_add.Visible = True
            t_birthdate.Visible = True
            t_religion.Visible = True
            t_em_name.Visible = True
            t_em_relationship.Visible = True
            t_em_contact.Visible = True
            btn_01.Text = "Save"
            btn_02.Text = "Cancel"
        Else
            std_update_info()
            Display_Information()
            l_name_1.Visible = True
            t_lname.Visible = False
            t_fname.Visible = False
            t_mname.Visible = False
            t_course.Visible = False
            t_year.Visible = False
            t_gender.Visible = False
            t_blood_type.Visible = False
            t_civil_status.Visible = False
            t_contact_no.Visible = False
            t_street.Visible = False
            t_brgy.Visible = False
            t_lot.Visible = False
            t_home.Visible = False
            t_home_add.Visible = False
            t_pre_add.Visible = False
            t_birthdate.Visible = False
            t_religion.Visible = False
            t_em_name.Visible = False
            t_em_relationship.Visible = False
            t_em_contact.Visible = False
            btn_01.Text = "Edit"
            btn_02.Text = "Remove"
        End If

    End Sub

    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        If btn_02.Text = "Remove" Then
            MsgBox("Student Information has been Removed!", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Success")
            removed_std()
            frm_main.Dashboard1.Dock = DockStyle.Fill
            frm_main.Dashboard1.Visible = True
            View_Students()

            frm_main.Medical1.Visible = False
            frm_main.Register1.Visible = False
            frm_main.Information1.Visible = False
            frm_main.Referral1.Visible = False
            frm_main.Treatment1.Visible = False
        Else
            l_name_1.Visible = True
            t_lname.Visible = False
            t_fname.Visible = False
            t_mname.Visible = False
            t_course.Visible = False
            t_year.Visible = False
            t_gender.Visible = False
            t_blood_type.Visible = False
            t_civil_status.Visible = False
            t_contact_no.Visible = False
            t_street.Visible = False
            t_brgy.Visible = False
            t_lot.Visible = False
            t_home.Visible = False
            t_home_add.Visible = False
            t_pre_add.Visible = False
            t_birthdate.Visible = False
            t_religion.Visible = False
            t_em_name.Visible = False
            t_em_relationship.Visible = False
            t_em_contact.Visible = False
            btn_01.Text = "Edit"
            btn_02.Text = "Remove"
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Cam.Show()
        Cam.Text = "Update | Photo"
        'Try
        '    upload_img.FileName = ""
        '    upload_img.Filter = "Select Image (*.png,*.jpg,*.jpeg,*.bmp)| *.png; *.jpg; *.jpeg; *.bmp;"
        '    upload_img.ShowDialog()
        '    url.Text = upload_img.FileName
        '    std_img.ImageLocation = url.Text
        '    Dim dir As String
        '    dir = Application.StartupPath.ToString & "\Images\" & l_idx.Text & ".jpg"
        '    FileCopy(url.Text, dir)
        '    MsgBox("Student Picture : Update Success!", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Upload Completed")
        'Catch ex As Exception
        '    Dim dir As String
        '    dir = Application.StartupPath.ToString & "\Images\" & l_idx.Text & ".jpg"
        '    If File.Exists(dir) Then
        '        frm_main.Information1.std_img.ImageLocation = dir
        '    End If
        'End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        info_other_medical_info()
        info_present_history()
        info_medical_history()
        MsgBox("New Medical Information Added!", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Information")
        info_Clear_reg()
        Display_Information()
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

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        mini_medical.Show()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        mini_present.Show()
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        mini_other.Show()
    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
        frm_referral.Show()
        frm_referral.t_name.Text = l_name_1.Text
        Dim tar, tempdate As Date
        Dim y, m, d As Integer
        tar = DateAndTime.Now
        If t_birthdate.Value > tar Then
            MsgBox("Invalid Date. Please try again", CType(vbExclamation + vbOKOnly, MsgBoxStyle), "Wait a Minute!!")
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

        d = CInt(DateDiff("d", tempdate, tar))
        frm_referral.t_age.Text = CStr(y)

        frm_referral.t_course_year.Text = t_course.Text & " - " & t_year.Text
        frm_referral.t_address.Text = t_home_add.Text
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        mini_treatment.Show()
        mini_treatment.t_id.Text = l_idx.Text
        mini_treatment.t_name.Text = l_name_1.Text
        mini_treatment.t_cy.Text = t_course.Text & " - " & t_year.Text
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        mini_medical_01.Show()
        mini_medical_01.t_id.Text = l_idx.Text
        mini_medical_01.t_name.Text = l_name_1.Text
        mini_medical_01.t_cy.Text = t_course.Text & " - " & t_year.Text
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frm_account.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frm_login.Show()
        frm_main.Close()
    End Sub

    Private Sub t_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_year.SelectedIndexChanged

    End Sub

    Private Sub t_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_course.SelectedIndexChanged

    End Sub

    Private Sub l_course_Click(sender As Object, e As EventArgs) Handles l_course.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub t_contact_no_KeyDown(sender As Object, e As KeyEventArgs) Handles t_contact_no.KeyDown
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub t_contact_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_contact_no.KeyPress
        If BACKSPACE = False Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
