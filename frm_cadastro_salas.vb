Imports System.Data.OleDb
Imports System.Reflection

Public Class frm_cadastro_salas
    Private Sub frm_cadastro_salas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        CarregarDadosSalas()

    End Sub

    Private Sub bnt_cadastrar_salas_Click(sender As Object, e As EventArgs) Handles bnt_cadastrar_salas.Click
        Try

            Dim selectedSoftwares As New List(Of String)
            Dim selectedCaracteristicas As New List(Of String)

            For index As Integer = 0 To chk_softwares.Items.Count - 1
                If chk_softwares.GetItemChecked(index) Then
                    selectedSoftwares.Add(chk_softwares.Items(index).ToString())
                End If
            Next

            For index As Integer = 0 To chk_caracteristicas.Items.Count - 1
                If chk_caracteristicas.GetItemChecked(index) Then
                    selectedCaracteristicas.Add(chk_caracteristicas.Items(index).ToString())
                End If
            Next


            Dim softwares As String = String.Join(", ", selectedSoftwares)
            Dim caracteristicas As String = String.Join(", ", selectedCaracteristicas)

            SQL = "SELECT*FROM tb_salas where nome_salas ='" & txt_nome_sala.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then


                SQL = "INSERT INTO tb_salas (nome_salas, softwares, tipo_sala, caracteristicas, capacidade, status) " &
              "VALUES ('" & txt_nome_sala.Text & "', " &
                       "'" & softwares & "', " &
                       "'" & cmb_tipo_sala.SelectedItem.ToString & "', " &
                       "'" & caracteristicas & "'," &
                       "'" & cmb_capacidade.SelectedItem.ToString & "', " &
                       "'" & cmb_status_salas.SelectedItem.ToString & "')"

                rs = db.Execute(SQL)

                MsgBox("Características adicionadas com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else

                SQL = "UPDATE tb_salas SET " &
              "softwares = '" & softwares & "', " &
              "tipo_sala = '" & cmb_tipo_sala.SelectedItem.ToString() & "', " &
              "caracteristicas = '" & caracteristicas & "', " &
              "capacidade = '" & cmb_capacidade.SelectedItem.ToString() & "', " &
              "status = '" & cmb_status_salas.SelectedItem.ToString() & "' " &
              "WHERE nome_salas = '" & txt_nome_sala.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            CarregarDadosSalas()
        Catch ex As Exception
            MsgBox("Erro ao adicionar características: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Debug.WriteLine("Erro: " & ex.Message)
            Debug.WriteLine("StackTrace: " & ex.StackTrace)
        End Try

    End Sub

    Private Sub frm_cadastro_salas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        frm_painel_adm.Show()
    End Sub


    Private Sub dgv_cadastro_salas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastro_salas.CellContentClick
        Try
            Dim selectedSoftwares As New List(Of String)
            Dim selectedCaracteristicas As New List(Of String)

            For index As Integer = 0 To chk_softwares.Items.Count - 1
                If chk_softwares.GetItemChecked(index) Then
                    selectedSoftwares.Add(chk_softwares.Items(index).ToString())
                End If
            Next

            For index As Integer = 0 To chk_caracteristicas.Items.Count - 1
                If chk_caracteristicas.GetItemChecked(index) Then
                    selectedCaracteristicas.Add(chk_caracteristicas.Items(index).ToString())
                End If
            Next


            Dim softwares As String = String.Join(", ", selectedSoftwares)
            Dim caracteristicas As String = String.Join(", ", selectedCaracteristicas)
            With dgv_cadastro_salas
                If .CurrentRow.Cells(4).Selected = True Then ' Se a coluna com o botão editar for selecionada
                    NDS = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_salas where nome_salas ='" & NDS & "'"
                    rs = db.Execute(SQL)
                    If Not rs.EOF Then ' Se existir
                        txt_nome_sala.Text = rs.Fields("nome_salas").Value.ToString()

                        ' Limpa as seleções anteriores
                        For i As Integer = 0 To chk_softwares.Items.Count - 1
                            chk_softwares.SetItemChecked(i, False)
                        Next

                        ' Define os softwares selecionados
                        Dim softwaresArray As String() = rs.Fields("softwares").Value.ToString().Split(","c)
                        For Each software As String In softwaresArray
                            For i As Integer = 0 To chk_softwares.Items.Count - 1
                                If chk_softwares.Items(i).ToString() = software Then
                                    chk_softwares.SetItemChecked(i, True)
                                End If
                            Next
                        Next

                        cmb_tipo_sala.SelectedItem = rs.Fields("tipo_sala").Value.ToString()

                        ' Limpa as seleções anteriores
                        For i As Integer = 0 To chk_caracteristicas.Items.Count - 1
                            chk_caracteristicas.SetItemChecked(i, False)
                        Next

                        ' Define as características selecionadas
                        Dim caracteristicasArray As String() = rs.Fields("caracteristicas").Value.ToString().Split(","c)
                        For Each caracteristica As String In caracteristicasArray
                            For i As Integer = 0 To chk_caracteristicas.Items.Count - 1
                                If chk_caracteristicas.Items(i).ToString() = caracteristica Then
                                    chk_caracteristicas.SetItemChecked(i, True)
                                End If
                            Next
                        Next

                        cmb_capacidade.SelectedItem = rs.Fields("capacidade").Value.ToString()
                        cmb_status_salas.SelectedItem = rs.Fields("status").Value.ToString()
                    End If


                    'Excluir
                ElseIf .CurrentRow.Cells(5).Selected Then
                    NDS = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir a Sala" & NDS & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "DELETE * from tb_salas where nome_salas ='" & NDS & "'"
                        rs = db.Execute(SQL)
                        CarregarDadosSalas()
                    End If
                Else
                    Exit Sub

                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Debug.WriteLine("Erro: " & ex.Message)
            Debug.WriteLine("StackTrace: " & ex.StackTrace)
        End Try
    End Sub
End Class