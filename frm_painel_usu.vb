Public Class frm_painel_usu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_filtro_reserva.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        frm_minhas_reservas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub frm_painel_usu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class