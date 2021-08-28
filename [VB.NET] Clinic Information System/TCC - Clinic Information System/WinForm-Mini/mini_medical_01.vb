Public Class mini_medical_01

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insert_medical()
        update_select_inventory()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update_medical()
    End Sub

    Private Sub mini_medical_01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categ_inventory()
        low_inventory()
        date_inventory()
    End Sub

    Private Sub t_medical_D_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t_medical_D.SelectedIndexChanged
        display_select_inventory()
    End Sub

End Class