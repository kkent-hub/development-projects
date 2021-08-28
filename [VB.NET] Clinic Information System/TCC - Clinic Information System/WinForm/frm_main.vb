Public Class frm_main

    Private Sub frm_main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_login.Show()
    End Sub


    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------
        Dashboard1.Dock = DockStyle.Fill
        Dashboard1.Visible = True
        View_Students()
        low_inventory()
        date_inventory()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Register1.Dock = DockStyle.Fill
        Register1.Visible = True

        Medical1.Visible = False
        Dashboard1.Visible = False
        Information1.Visible = False
        Referral1.Visible = False
        Treatment1.Visible = False
        Inventory1.Visible = False
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dashboard1.Dock = DockStyle.Fill
        Dashboard1.Visible = True
        View_Students()

        Medical1.Visible = False
        Register1.Visible = False
        Information1.Visible = False
        Referral1.Visible = False
        Treatment1.Visible = False
        Inventory1.Visible = False
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Referral1.Dock = DockStyle.Fill
        Referral1.Visible = True
        View_ref()

        Medical1.Visible = False
        Register1.Visible = False
        Information1.Visible = False
        Dashboard1.Visible = False
        Treatment1.Visible = False
        Inventory1.Visible = False
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Treatment1.Dock = DockStyle.Fill
        Treatment1.Visible = True
        View_treat()

        Medical1.Visible = False
        Register1.Visible = False
        Information1.Visible = False
        Dashboard1.Visible = False
        Referral1.Visible = False
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Medical1.Dock = DockStyle.Fill
        Medical1.Visible = True
        View_medical()

        Treatment1.Visible = False
        Register1.Visible = False
        Information1.Visible = False
        Dashboard1.Visible = False
        Referral1.Visible = False
        Inventory1.Visible = False
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Inventory1.Dock = DockStyle.Fill
        Inventory1.Visible = True
        Inventory1.t_expired.Text = DateAndTime.Today.AddYears(3).ToString
        View_Inventory()

        Medical1.Visible = False
        Treatment1.Visible = False
        Register1.Visible = False
        Information1.Visible = False
        Dashboard1.Visible = False
        Referral1.Visible = False
    End Sub
End Class
