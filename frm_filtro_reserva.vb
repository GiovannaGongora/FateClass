Imports System.Data.OleDb

Public Class frm_filtro_reserva
    Dim reservasPorSala As New Dictionary(Of String, Dictionary(Of String, List(Of String)))

    Private Sub frm_filtro_reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

    End Sub

    Private Sub frm_filtro_reserva_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        If log_usuario = "admin" Then
            frm_painel_adm.Show()
        Else
            frm_painel_usu.Show()
        End If
    End Sub
    Private Sub LimparCamposFiltro()

        For index As Integer = 0 To chk_software.Items.Count - 1
            chk_software.SetItemChecked(index, False)
        Next

        For index As Integer = 0 To chk_adicionais.Items.Count - 1
            chk_adicionais.SetItemChecked(index, False)
        Next

        ' Limpa a seleção do tipo de sala
        cmb_tipo_sala.SelectedIndex = -1

        ' Redefine a data de reserva para a data atual
        data_reserva.Value = DateTime.Now

        ' Limpa o DataGridView de resultados
        dgv_salas.Rows.Clear()
    End Sub

    Private Sub dgv_salas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_salas.CellContentClick
        Try
            Debug.WriteLine("Célula clicada: " & e.RowIndex & ", " & e.ColumnIndex)
            Debug.WriteLine("Valor de log_usuario: " & log_usuario)

            With dgv_salas
                If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
                    Debug.WriteLine("Inserindo reserva...")
                    Dim nomeSala As String = .Rows(e.RowIndex).Cells("NomeSala").Value.ToString()
                    Dim horario As String = .Rows(e.RowIndex).Cells("HORARIO").Value.ToString()
                    SQL = "INSERT INTO tb_reservas (login_reserva, data_reserva, nome_sala, horario) VALUES (" &
                "'" & log_usuario & "', " &
                "#" & data_reserva.Value.ToString("MM/dd/yyyy") & "#, " &
                "'" & nomeSala & "', " &
                "'" & horario & "')"
                    Debug.WriteLine("problema " & horario)
                    rs = db.Execute(SQL)
                    MsgBox("Reserva feita com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    ' Atualizar as reservas armazenadas
                    Dim dataReserva As String = data_reserva.Value.ToString("yyyyMMdd")
                    If Not reservasPorSala.ContainsKey(dataReserva) Then
                        reservasPorSala(dataReserva) = New Dictionary(Of String, List(Of String))()
                    End If
                    If Not reservasPorSala(dataReserva).ContainsKey(nomeSala) Then
                        reservasPorSala(dataReserva)(nomeSala) = New List(Of String)()
                    End If
                    reservasPorSala(dataReserva)(nomeSala).Add(horario)

                    ' Limpar os campos de filtro após a reserva ser efetuada
                    LimparCamposFiltro()
                End If
            End With
        Catch ex As Exception
            Debug.WriteLine("Erro ao processar: " & ex.Message)
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dataReserva As String = data_reserva.Value.ToString("MM/dd/yyyy")
        Dim tipoSala As String = If(cmb_tipo_sala.SelectedItem IsNot Nothing, cmb_tipo_sala.SelectedItem.ToString(), "")

        Dim selectedSoftwares As New List(Of String)
        Dim selectedCaracteristicas As New List(Of String)

        For index As Integer = 0 To chk_software.Items.Count - 1
            If chk_software.GetItemChecked(index) Then
                selectedSoftwares.Add(chk_software.Items(index).ToString())
            End If
        Next

        For index As Integer = 0 To chk_adicionais.Items.Count - 1
            If chk_adicionais.GetItemChecked(index) Then
                selectedCaracteristicas.Add(chk_adicionais.Items(index).ToString())
            End If
        Next

        Try
            Dim sql As String = "SELECT tb_salas.nome_salas, tb_salas.tipo_sala, tb_salas.softwares, tb_salas.caracteristicas, tb_salas.status " &
                        "FROM tb_salas " &
                        "WHERE tb_salas.tipo_sala = '" & tipoSala & "' " &
                        "AND tb_salas.status = 'DISPONIVEL'"

            ' Adicionar filtros de softwares se houver seleções
            If selectedSoftwares.Count > 0 Then
                For Each software In selectedSoftwares
                    sql &= " AND tb_salas.softwares LIKE '%" & software & "%'"
                Next
            End If

            ' Adicionar filtros de características se houver seleções
            If selectedCaracteristicas.Count > 0 Then
                For Each caracteristica In selectedCaracteristicas
                    sql &= " AND tb_salas.caracteristicas LIKE '%" & caracteristica & "%'"
                Next
            End If

            rs = db.Execute(sql)

            Dim cont As Integer = 1
            With dgv_salas
                .Rows.Clear()
                Do While Not rs.EOF ' Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MessageBox.Show("Erro ao executar a consulta: " & ex.Message)
        End Try
    End Sub

    Private Function ObterChaveUnicaParaDataESala(data As Date, sala As String) As String
        Return data.ToString("yyyyMMdd") & "_" & sala
    End Function

    Private Sub ComboBox_DropDown(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Obter a linha associada 
        Dim rowIndex As Integer = CInt(comboBox.Tag)

        ' Obter a chave única para as reservas do dia atual
        Dim currentKey As String = ObterChaveUnicaParaDataAtual()

        ' Obter a sala da linha atual
        Dim sala As String = dgv_salas.Rows(rowIndex).Cells("NomeSala").Value?.ToString()

        ' Armazenar todos os horários disponíveis
        Dim horariosDisponiveis As New List(Of String) From {
    "07:00-08:40",
    "08:50-10:30",
    "10:40-12:20",
    "13:00-14:40",
    "14:50-16:30",
    "16:40-18:20",
    "19:00-20:40",
    "20:50-21:30",
    "21:40-22:40"
}

        ' Obter os horários já reservados para a sala e data atuais, se houver
        Dim horariosReservados As List(Of String) = New List(Of String)
        If reservasPorSala.ContainsKey(sala) AndAlso reservasPorSala(sala).ContainsKey(currentKey) Then
            horariosReservados = reservasPorSala(sala)(currentKey)
        End If

        ' Obter o horário atual da célula, se houver, para incluir na lista de horários disponíveis
        Dim horarioAtual As String = dgv_salas.Rows(rowIndex).Cells("HORARIO").Value?.ToString()
        If Not String.IsNullOrEmpty(horarioAtual) Then
            horariosReservados.Remove(horarioAtual)
        End If

        ' Filtrar os horários disponíveis para excluir os já reservados
        Dim horariosParaExibir = horariosDisponiveis.Except(horariosReservados).ToList()

        ' Limpar os itens atuais do ComboBox e adicionar os horários disponíveis
        comboBox.Items.Clear()
        comboBox.Items.AddRange(horariosParaExibir.ToArray())

        ' Re-adicionar o horário atual da célula ao comboBox, se ele estiver selecionado
        If Not String.IsNullOrEmpty(horarioAtual) Then
            comboBox.Items.Add(horarioAtual)
            comboBox.SelectedItem = horarioAtual
        End If
    End Sub

    Private Sub dgv_salas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_salas.CellValueChanged
        ' Verifique se a célula editada é a célula HORARIO
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgv_salas.Columns("HORARIO").Index Then
                ' Obter a chave única para as reservas do dia atual
                Dim currentKey As String = ObterChaveUnicaParaDataAtual()
                ' Obter a sala da linha atual
                Dim sala As String = dgv_salas.Rows(e.RowIndex).Cells("NomeSala").Value?.ToString()
                ' Obter o horário selecionado
                Dim selectedHorario As String = dgv_salas.Rows(e.RowIndex).Cells("HORARIO").Value?.ToString()

                If Not reservasPorSala.ContainsKey(sala) Then
                    reservasPorSala(sala) = New Dictionary(Of String, List(Of String))()
                End If
                If Not reservasPorSala(sala).ContainsKey(currentKey) Then
                    reservasPorSala(sala)(currentKey) = New List(Of String)
                End If

                ' Remover a reserva anterior, se existir
                Dim oldHorario = dgv_salas.Rows(e.RowIndex).Cells("HORARIO").Tag?.ToString()
                If Not String.IsNullOrEmpty(oldHorario) AndAlso reservasPorSala(sala)(currentKey).Contains(oldHorario) Then
                    reservasPorSala(sala)(currentKey).Remove(oldHorario)
                End If

                ' Adicionar o novo horário
                If Not String.IsNullOrEmpty(selectedHorario) Then
                    reservasPorSala(sala)(currentKey).Add(selectedHorario)
                    dgv_salas.Rows(e.RowIndex).Cells("HORARIO").Tag = selectedHorario
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao processar a célula: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_salas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_salas.EditingControlShowing
        If dgv_salas.CurrentCell.ColumnIndex = dgv_salas.Columns("HORARIO").Index Then
            Dim comboBox As ComboBox = CType(e.Control, ComboBox)

            RemoveHandler comboBox.DropDown, AddressOf ComboBox_DropDown


            AddHandler comboBox.DropDown, AddressOf ComboBox_DropDown


            comboBox.Tag = dgv_salas.CurrentCell.RowIndex
        End If
    End Sub

    Private Function ObterChaveUnicaParaDataAtual() As String

        Dim dataAtual As Date = data_reserva.Value

        Return dataAtual.ToString("yyyyMMdd")
    End Function



End Class


