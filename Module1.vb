Imports System.Data.OleDb

Module Module1
    Public diretorio, SQL, aux_cpf, resp, NDS, HORA As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho_banco = Application.StartupPath & "\Banco\banco_fateclass.mdb"
    Public cont As Integer
    Public log_usuario, log_senha As String
    Public reservasPorSala As New Dictionary(Of String, Dictionary(Of String, List(Of String)))
    Public reservas As New Dictionary(Of String, List(Of String))



    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO AO CONECTAR", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro_professores()
        Try
            With frm_cadastro_professores
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_email.Clear()
                .cmb_data_nasc.Value = Now
                .txt_tel.Clear()
                .txt_login.Clear()
                .txt_senha.Clear()
                .cmb_status.SelectedIndex = -1 ' Limpa a seleção do combobox
                .img_foto.Load(Application.StartupPath & "\ICONES\adicionar-imagem.png")
                .txt_cpf.Focus()
            End With

        Catch ex As Exception
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            ' Adicione mensagens de log para depuração
            Debug.WriteLine("Erro: " & ex.Message)
            Debug.WriteLine("StackTrace: " & ex.StackTrace)

        End Try
    End Sub


    Sub carregar_dados_professores()

        Try
            SQL = "select * from tb_cadastro_professores order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With frm_cadastro_professores.dgv_professores
                .Rows.Clear()
                Do While Not rs.EOF ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields("cpf").Value, rs.Fields("nome").Value, Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub


    Sub carregar_tipo()
        Try
            With frm_cadastro_professores.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frm_cadastro_professores.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO,")
        End Try
    End Sub

    Sub limpar_login()
        With frm_login
            .txt_user.Clear()
            .txt_senha_login.Clear()
            .txt_user.Focus()
        End With
    End Sub

    Sub CarregarDadosSalas()

        Try
            SQL = "select * from tb_salas order by nome_salas asc"
            rs = db.Execute(SQL)
            cont = 1
            With frm_cadastro_salas.dgv_cadastro_salas
                .Rows.Clear()
                Do While Not rs.EOF ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields("nome_salas").Value, rs.Fields("tipo_sala").Value, rs.Fields("status").Value.ToString(), Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub
    Sub CarregarDadosSalasMR()

        Try

            SQL = "SELECT * FROM tb_reservas WHERE login_reserva = '" & log_usuario & "' ORDER BY nome_sala ASC"
            rs = db.Execute(SQL)
            cont = 1

            ' Acesse o DataGridView correspondente no formulário
            With frm_minhas_reservas.dgv_mr
                .Rows.Clear()
                Do While Not rs.EOF ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields("nome_sala").Value, rs.Fields("data_reserva").Value, rs.Fields("horario").Value, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar! Detalhes: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Sub carregar_dados_reservas()
        Try
            SQL = "SELECT login_reserva, data_reserva, horario FROM tb_reservas ORDER BY nome_sala, data_reserva, horario ASC"
            rs = db.Execute(SQL)
            cont = 1
            With frm_filtro_reserva.dgv_salas
                .Rows.Clear()
                Do While Not rs.EOF ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields("NomeSala").Value, rs.Fields("HORARIO").Value)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
