Public Class frm_redefinir
    Private Sub frm_redefinir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        RedefinirSenha()
    End Sub

    Private Sub RedefinirSenha()
        Dim NSusuario As String = txt_usu_ns.Text
        Dim NSemail As String = txt_email_ns.Text
        Dim novasenha As String = txt_ns.Text
        Dim Confirma As String = txt_conf_ns.Text

        If NSusuario = "" Or NSemail = "" Or novasenha = "" Or Confirma = "" Then
            MsgBox("Todos os campos devem estar preenchidos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End If

        Try

            SQL = "SELECT * FROM tb_cadastro_professores WHERE LOGIN = '" & NSusuario & "' AND EMAIL = '" & NSemail & "'"
            rs = db.Execute(SQL)

            If rs.EOF Then
                MsgBox("Login ou Email não cadastrados no sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Else

                If novasenha <> Confirma Then
                    MsgBox("As senhas do campo nova senha e confirmar senha precisam ser iguais.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                Else

                    SQL = "UPDATE tb_cadastro_professores SET SENHA='" & novasenha & "' WHERE LOGIN='" & NSusuario & "'"
                    rs = db.Execute(SQL)
                    MsgBox("SENHA ALTERADA!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

                    txt_usu_ns.Clear()
                    txt_email_ns.Clear()
                    txt_ns.Clear()
                    txt_conf_ns.Clear()
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Debug.WriteLine("Erro: " & ex.Message)
            Debug.WriteLine("StackTrace: " & ex.StackTrace)
        End Try
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usu_ns.KeyDown, txt_email_ns.KeyDown, txt_ns.KeyDown, txt_conf_ns.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RedefinirSenha()
        End If
    End Sub

    Private Sub frm_redefinir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        frm_login.Show()

    End Sub
End Class