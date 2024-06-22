Imports System.Data.OleDb

Public Class frm_cadastro_professores
    Private Sub frm_cadastro_professores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados_professores()
        carregar_tipo()
    End Sub

    Private Sub bnt_cadastrar_Click(sender As Object, e As EventArgs) Handles bnt_cadastrar.Click
        Try
            If String.IsNullOrWhiteSpace(txt_cpf.Text) OrElse
             String.IsNullOrWhiteSpace(txt_nome.Text) OrElse
            String.IsNullOrWhiteSpace(cmb_data_nasc.Text) OrElse
             String.IsNullOrWhiteSpace(txt_tel.Text) OrElse
            String.IsNullOrWhiteSpace(txt_email.Text) OrElse
             String.IsNullOrWhiteSpace(txt_login.Text) OrElse
             String.IsNullOrWhiteSpace(txt_senha.Text) OrElse
             String.IsNullOrWhiteSpace(cmb_status.Text) Then

                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                limpar_cadastro_professores()

                Exit Sub
            End If
            SQL = "select * from tb_cadastro_professores where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = "insert into tb_cadastro_professores values ('" & txt_cpf.Text & "', " &
                                                            "'" & txt_nome.Text & "', " &
                                                            "'" & txt_email.Text & "', " &
                                                            "'" & cmb_data_nasc.Value.Date & "', " &
                                                            "'" & txt_tel.Text & "', " &
                                                            "'" & txt_login.Text & "', " &
                                                            "'" & txt_senha.Text & "', " &
                                                            "'" & cmb_status.SelectedItem.ToString & "', " &
                                                            "'" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados Gravados com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                If aux_cpf = txt_cpf.Text Then
                    ' se o CPF carregado é o mesmo que está sendo editado
                    SQL = "update tb_cadastro_professores set NOME='" & txt_nome.Text & "', " &
                                                  "EMAIL='" & txt_email.Text & "', " &
                                                  "DATA_NASC='" & cmb_data_nasc.Value.Date & "', " &
                                                  "TELEFONE='" & txt_tel.Text & "', " &
                                                  "LOGIN='" & txt_login.Text & "', " &
                                                  "SENHA='" & txt_senha.Text & "', " &
                                                  "STATUS='" & cmb_status.SelectedItem.ToString & "', " &
                                                  "FOTO='" & diretorio & "' " &
                                                  "where CPF='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    MsgBox("O CPF já está cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End If
            End If
            limpar_cadastro_professores()
            carregar_dados_professores()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Debug.WriteLine("Erro: " & ex.Message)
            Debug.WriteLine("StackTrace: " & ex.StackTrace)
        End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a foto do usuario"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_cadastro_professores where " & cmb_tipo.Text & " Like '" & txt_buscar.Text & "%' order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With dgv_professores
                .Rows.Clear()
                Do While rs.EOF = False ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_professores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_professores.CellContentClick
        Try
            With dgv_professores

                'Editar
                If .CurrentRow.Cells(3).Selected = True Then 'Se a coluna com o botão editar for selecionada
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_cadastro_professores where cpf ='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If Not rs.EOF Then ' Se existir
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_email.Text = rs.Fields(2).Value
                        cmb_data_nasc.Value = rs.Fields(3).Value
                        txt_tel.Text = rs.Fields(4).Value
                        txt_login.Text = rs.Fields(5).Value
                        txt_senha.Text = rs.Fields(6).Value
                        cmb_status.SelectedItem = rs.Fields(7).Value.ToString()
                        diretorio = rs.Fields(8).Value
                        img_foto.Load(diretorio)

                    End If
                    'Excluir
                ElseIf .CurrentRow.Cells(4).Selected Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o " + vbNewLine &
                                  "CPF:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "DELETE * from tb_cadastro_professores where cpf ='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados_professores()
                    End If
                Else
                    Exit Sub

                End If


            End With
        Catch ex As Exception
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frm_cadastro_professores_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        frm_painel_adm.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


End Class