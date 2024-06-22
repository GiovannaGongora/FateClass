<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_filtro_reserva
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_filtro_reserva))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipo_sala = New System.Windows.Forms.ComboBox()
        Me.chk_software = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_adicionais = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.data_reserva = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_salas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeSala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOSALA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORARIO = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RESERVAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_salas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selecione a Data :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo De Sala"
        '
        'cmb_tipo_sala
        '
        Me.cmb_tipo_sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_sala.FormattingEnabled = True
        Me.cmb_tipo_sala.Items.AddRange(New Object() {"SALA CONVENCIONAL", "LABORATORIO", "AUDITORIO"})
        Me.cmb_tipo_sala.Location = New System.Drawing.Point(37, 110)
        Me.cmb_tipo_sala.Name = "cmb_tipo_sala"
        Me.cmb_tipo_sala.Size = New System.Drawing.Size(196, 26)
        Me.cmb_tipo_sala.TabIndex = 6
        '
        'chk_software
        '
        Me.chk_software.BackColor = System.Drawing.Color.White
        Me.chk_software.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chk_software.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_software.FormattingEnabled = True
        Me.chk_software.Items.AddRange(New Object() {"POSTGREESQL", "PORTUGOL", "PACOTEOFFICE", "VISUAL STUDIO CODE", "VISUAL STUDIO", "DEVC++", "KIRITO", "PHP", "SWIFT", "JAVA", "KOTLIN"})
        Me.chk_software.Location = New System.Drawing.Point(275, 44)
        Me.chk_software.Name = "chk_software"
        Me.chk_software.Size = New System.Drawing.Size(216, 76)
        Me.chk_software.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Selecione o Software"
        '
        'chk_adicionais
        '
        Me.chk_adicionais.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chk_adicionais.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_adicionais.FormattingEnabled = True
        Me.chk_adicionais.Items.AddRange(New Object() {"AR CONDICIONADO", "COMPUTADOR", "INTERNET"})
        Me.chk_adicionais.Location = New System.Drawing.Point(518, 44)
        Me.chk_adicionais.Name = "chk_adicionais"
        Me.chk_adicionais.Size = New System.Drawing.Size(186, 95)
        Me.chk_adicionais.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.data_reserva)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.chk_adicionais)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chk_software)
        Me.Panel1.Controls.Add(Me.cmb_tipo_sala)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 207)
        Me.Panel1.TabIndex = 12
        '
        'data_reserva
        '
        Me.data_reserva.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_reserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.data_reserva.Location = New System.Drawing.Point(36, 42)
        Me.data_reserva.Name = "data_reserva"
        Me.data_reserva.Size = New System.Drawing.Size(200, 20)
        Me.data_reserva.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(37, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 27)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Visualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Selecione as Carcteristicas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.image1
        Me.PictureBox2.Location = New System.Drawing.Point(509, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp2.My.Resources.Resources.image1
        Me.PictureBox3.Location = New System.Drawing.Point(268, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(229, 114)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(33, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 26)
        Me.Panel2.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dgv_salas)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 409)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SALAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_7black_escrita
        Me.PictureBox1.Location = New System.Drawing.Point(0, 349)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'dgv_salas
        '
        Me.dgv_salas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_salas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NomeSala, Me.TIPOSALA, Me.STATUS, Me.HORARIO, Me.RESERVAR})
        Me.dgv_salas.Location = New System.Drawing.Point(0, 24)
        Me.dgv_salas.Name = "dgv_salas"
        Me.dgv_salas.Size = New System.Drawing.Size(732, 319)
        Me.dgv_salas.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'NomeSala
        '
        Me.NomeSala.HeaderText = "NOME DA SALA"
        Me.NomeSala.Name = "NomeSala"
        '
        'TIPOSALA
        '
        Me.TIPOSALA.HeaderText = "TIPO DE SALA"
        Me.TIPOSALA.Name = "TIPOSALA"
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        '
        'HORARIO
        '
        Me.HORARIO.HeaderText = "HORARIO"
        Me.HORARIO.Items.AddRange(New Object() {"07:00-08:40", "08:50-10:30", "10:40-12:20", "13:00-14:40", "14:50-16:30", "16:40-18:20", "19:00-20:40", "20:50-21:30", "21:40-22:40"})
        Me.HORARIO.Name = "HORARIO"
        '
        'RESERVAR
        '
        Me.RESERVAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESERVAR.HeaderText = "RESERVAR"
        Me.RESERVAR.Image = CType(resources.GetObject("RESERVAR.Image"), System.Drawing.Image)
        Me.RESERVAR.Name = "RESERVAR"
        Me.RESERVAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RESERVAR.Width = 89
        '
        'frm_filtro_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 627)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_filtro_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservar Salas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_salas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tipo_sala As ComboBox
    Friend WithEvents chk_software As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_adicionais As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_salas As DataGridView
    Friend WithEvents data_reserva As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NomeSala As DataGridViewTextBoxColumn
    Friend WithEvents TIPOSALA As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents HORARIO As DataGridViewComboBoxColumn
    Friend WithEvents RESERVAR As DataGridViewImageColumn
End Class
