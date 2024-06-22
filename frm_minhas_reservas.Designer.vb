<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_minhas_reservas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_minhas_reservas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_mr = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeSaLaMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaReservaMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCELAR = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_mr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Minhas Reservas"
        '
        'dgv_mr
        '
        Me.dgv_mr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_mr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N, Me.NomeSaLaMR, Me.DiaReservaMR, Me.horario, Me.CANCELAR})
        Me.dgv_mr.Location = New System.Drawing.Point(3, 109)
        Me.dgv_mr.Name = "dgv_mr"
        Me.dgv_mr.Size = New System.Drawing.Size(548, 318)
        Me.dgv_mr.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_4black
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.Design_sem_nome__1____Copia
        Me.PictureBox2.Location = New System.Drawing.Point(568, -9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 449)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'N
        '
        Me.N.HeaderText = "Num"
        Me.N.Name = "N"
        '
        'NomeSaLaMR
        '
        Me.NomeSaLaMR.HeaderText = "Nome Da Sala"
        Me.NomeSaLaMR.Name = "NomeSaLaMR"
        '
        'DiaReservaMR
        '
        Me.DiaReservaMR.HeaderText = "Dia Da Reserva"
        Me.DiaReservaMR.Name = "DiaReservaMR"
        '
        'horario
        '
        Me.horario.HeaderText = "Horario"
        Me.horario.Name = "horario"
        '
        'CANCELAR
        '
        Me.CANCELAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANCELAR.HeaderText = "Cancelar Rerserva"
        Me.CANCELAR.Image = CType(resources.GetObject("CANCELAR.Image"), System.Drawing.Image)
        Me.CANCELAR.Name = "CANCELAR"
        Me.CANCELAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CANCELAR.Width = 91
        '
        'frm_minhas_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 439)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_mr)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_minhas_reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minhas Reservas"
        CType(Me.dgv_mr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_mr As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents N As DataGridViewTextBoxColumn
    Friend WithEvents NomeSaLaMR As DataGridViewTextBoxColumn
    Friend WithEvents DiaReservaMR As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Friend WithEvents CANCELAR As DataGridViewImageColumn
End Class
