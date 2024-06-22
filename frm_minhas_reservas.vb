Public Class frm_minhas_reservas
    Private Sub frm_minhas_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        CarregarDadosSalasMR()
    End Sub

    Private Sub dgv_mr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mr.CellContentClick
        Try
            With dgv_mr
                If .CurrentRow.Cells(4).Selected = True Then
                    NDS = .CurrentRow.Cells(1).Value
                    HORA = .CurrentRow.Cells(3).Value
                    resp = MsgBox("Deseja cancelar a reserva  " + vbNewLine &
                                                  "SALA:" & NDS & "?" & vbNewLine &
                                                  "HORÁRIO:" & HORA, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "DELETE FROM tb_reservas WHERE nome_sala ='" & NDS & "' AND login_reserva ='" & log_usuario & "' AND horario ='" & HORA & "'"
                        rs = db.Execute(SQL)
                    End If
                End If
                CarregarDadosSalasMR()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_minhas_reservas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        If log_usuario = "admin" Then
            frm_painel_adm.Show()
        Else
            frm_painel_usu.Show()
        End If
    End Sub
End Class