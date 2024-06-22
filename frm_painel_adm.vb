Public Class frm_painel_adm
    Private Sub btn_menu_cadastrar_salas_Click(sender As Object, e As EventArgs) Handles btn_menu_cadastrar_salas.Click
        Me.Hide()
        frm_cadastro_salas.ShowDialog()
    End Sub

    Private Sub btn_menu_cadastrar_prof_Click(sender As Object, e As EventArgs) Handles btn_menu_cadastrar_prof.Click
        Me.Hide()
        frm_cadastro_professores.ShowDialog()
    End Sub

    Private Sub btn_menu_reservar_salas_Click(sender As Object, e As EventArgs) Handles btn_menu_reservar_salas.Click
        Me.Hide()
        frm_filtro_reserva.ShowDialog()
    End Sub

    Private Sub frm_painel_adm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then

            Application.Exit()
        End If
    End Sub

    Private Sub frm_painel_adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_mr_Click(sender As Object, e As EventArgs) Handles btn_mr.Click
        Me.Hide()
        frm_minhas_reservas.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_login.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class
