Public Class frm_login

    Private Sub txt_user_LostFocus(sender As Object, e As EventArgs) Handles txt_user.LostFocus
        If txt_user.Text = "" Then
            txt_user.Text = "USUARIO"
            txt_user.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txt_user_GotFocus(sender As Object, e As EventArgs) Handles txt_user.GotFocus
        If txt_user.Text = "USUARIO" Then
            txt_user.Text = ""
            txt_user.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_senha_login_GotFocus(sender As Object, e As EventArgs) Handles txt_senha_login.GotFocus
        If txt_senha_login.Text = "SENHA" Then
            txt_senha_login.Text = ""
            txt_senha_login.PasswordChar = "*"
            txt_senha_login.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_senha_login_LostFocus(sender As Object, e As EventArgs) Handles txt_senha_login.LostFocus
        If txt_senha_login.Text = "" Then
            txt_senha_login.Text = "SENHA"
            txt_senha_login.ForeColor = Color.DarkGray
            txt_senha_login.PasswordChar = ""
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        Me.Show()
        txt_user.Select() ' Focar no campo "Usuario" ao carregar o formulário
    End Sub

    Private Sub bnt_login_Click(sender As Object, e As EventArgs) Handles bnt_login.Click
        log_usuario = txt_user.Text
        log_senha = txt_senha_login.Text

        Try
            If log_usuario = "USUARIO" Or log_senha = "SENHA" Or log_usuario = "" Or log_senha = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            ElseIf log_usuario = "admin" AndAlso log_senha = "admin" Then
                Me.Hide()
                frm_painel_adm.ShowDialog()
            Else

                SQL = "SELECT status FROM tb_cadastro_professores WHERE login = '" & log_usuario & "'"
                rs = db.Execute(SQL)

                If rs.EOF Then
                    MsgBox("Usuário não encontrado na tabela de professores!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_login()
                Else
                    Dim status As String = rs.Fields("status").Value ' Obtém o status do usuário
                    If status = "BLOQUEADO" Then
                        MsgBox("Usuário está bloqueado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_login()
                    Else
                        SQL = "SELECT * FROM tb_cadastro_professores WHERE login = '" & log_usuario & "' AND senha = '" & log_senha & "'"
                        rs = db.Execute(SQL)

                        If rs.EOF Then
                            MsgBox("Senha incorreta!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            limpar_login()
                        Else
                            MsgBox("Usuário logado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            Me.Hide()
                            frm_painel_usu.Show()
                            limpar_login()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            bnt_login.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha_login.Select()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_senha_login_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_senha_login.KeyDown
        If e.KeyCode = Keys.Enter Then
            bnt_login.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frm_redefinir.Show()

    End Sub
End Class
