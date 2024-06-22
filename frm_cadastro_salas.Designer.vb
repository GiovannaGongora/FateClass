<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_salas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_salas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.dgv_cadastro_salas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnt_cadastrar_salas = New System.Windows.Forms.Button()
        Me.cmb_tipo_sala = New System.Windows.Forms.ComboBox()
        Me.chk_softwares = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cmb_capacidade = New System.Windows.Forms.ComboBox()
        Me.chk_caracteristicas = New System.Windows.Forms.CheckedListBox()
        Me.cmb_status_salas = New System.Windows.Forms.ComboBox()
        Me.txt_nome_sala = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMESALA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOSALA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISPONIBILIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDITAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EXCLUIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cadastro_salas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome da Sala"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.dgv_cadastro_salas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.bnt_cadastrar_salas)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_sala)
        Me.GroupBox1.Controls.Add(Me.chk_softwares)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.cmb_capacidade)
        Me.GroupBox1.Controls.Add(Me.chk_caracteristicas)
        Me.GroupBox1.Controls.Add(Me.cmb_status_salas)
        Me.GroupBox1.Controls.Add(Me.txt_nome_sala)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 500)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS DA SALA"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_7black_escrita
        Me.PictureBox7.Location = New System.Drawing.Point(22, 447)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(117, 45)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'dgv_cadastro_salas
        '
        Me.dgv_cadastro_salas.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgv_cadastro_salas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_cadastro_salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cadastro_salas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NOMESALA, Me.TIPOSALA, Me.DISPONIBILIDADE, Me.EDITAR, Me.EXCLUIR})
        Me.dgv_cadastro_salas.Location = New System.Drawing.Point(22, 222)
        Me.dgv_cadastro_salas.Name = "dgv_cadastro_salas"
        Me.dgv_cadastro_salas.Size = New System.Drawing.Size(775, 219)
        Me.dgv_cadastro_salas.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(656, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de Sala"
        '
        'bnt_cadastrar_salas
        '
        Me.bnt_cadastrar_salas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.bnt_cadastrar_salas.Location = New System.Drawing.Point(23, 182)
        Me.bnt_cadastrar_salas.Name = "bnt_cadastrar_salas"
        Me.bnt_cadastrar_salas.Size = New System.Drawing.Size(121, 34)
        Me.bnt_cadastrar_salas.TabIndex = 11
        Me.bnt_cadastrar_salas.Text = "CADASTRAR"
        Me.bnt_cadastrar_salas.UseVisualStyleBackColor = True
        '
        'cmb_tipo_sala
        '
        Me.cmb_tipo_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_sala.FormattingEnabled = True
        Me.cmb_tipo_sala.Items.AddRange(New Object() {"LABORATORIO", "SALA CONVENCIONAL", "AUDITORIO"})
        Me.cmb_tipo_sala.Location = New System.Drawing.Point(658, 54)
        Me.cmb_tipo_sala.Name = "cmb_tipo_sala"
        Me.cmb_tipo_sala.Size = New System.Drawing.Size(121, 23)
        Me.cmb_tipo_sala.TabIndex = 12
        '
        'chk_softwares
        '
        Me.chk_softwares.BackColor = System.Drawing.SystemColors.HighlightText
        Me.chk_softwares.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chk_softwares.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_softwares.FormattingEnabled = True
        Me.chk_softwares.Items.AddRange(New Object() {"POSTGREESQL", "PORTUGOL", "PACOTE OFFICE", "VISUAL STUDIO CODE", "VISUAL STUDIO", "DEVC++", "KIRITO", "PHP", "SWIFT", "JAVA", "KOTLIN"})
        Me.chk_softwares.Location = New System.Drawing.Point(443, 60)
        Me.chk_softwares.Name = "chk_softwares"
        Me.chk_softwares.Size = New System.Drawing.Size(176, 57)
        Me.chk_softwares.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(640, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(155, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Caracteristicas da Sala"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(657, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Disponibilidade"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApp2.My.Resources.Resources.image
        Me.PictureBox5.Location = New System.Drawing.Point(435, 52)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(193, 93)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'cmb_capacidade
        '
        Me.cmb_capacidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_capacidade.FormattingEnabled = True
        Me.cmb_capacidade.Items.AddRange(New Object() {"10-20", "20-35", "40+"})
        Me.cmb_capacidade.Location = New System.Drawing.Point(660, 178)
        Me.cmb_capacidade.Name = "cmb_capacidade"
        Me.cmb_capacidade.Size = New System.Drawing.Size(121, 23)
        Me.cmb_capacidade.TabIndex = 13
        '
        'chk_caracteristicas
        '
        Me.chk_caracteristicas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_caracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chk_caracteristicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_caracteristicas.FormattingEnabled = True
        Me.chk_caracteristicas.Items.AddRange(New Object() {"AR CONDICIONADO", "COMPUTADORES", "INTERNET"})
        Me.chk_caracteristicas.Location = New System.Drawing.Point(231, 61)
        Me.chk_caracteristicas.Name = "chk_caracteristicas"
        Me.chk_caracteristicas.Size = New System.Drawing.Size(176, 57)
        Me.chk_caracteristicas.TabIndex = 4
        '
        'cmb_status_salas
        '
        Me.cmb_status_salas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_status_salas.FormattingEnabled = True
        Me.cmb_status_salas.Items.AddRange(New Object() {"DISPONIVEL ", "INDISPONIVEL"})
        Me.cmb_status_salas.Location = New System.Drawing.Point(660, 112)
        Me.cmb_status_salas.Name = "cmb_status_salas"
        Me.cmb_status_salas.Size = New System.Drawing.Size(121, 23)
        Me.cmb_status_salas.TabIndex = 14
        '
        'txt_nome_sala
        '
        Me.txt_nome_sala.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_sala.Location = New System.Drawing.Point(55, 67)
        Me.txt_nome_sala.Name = "txt_nome_sala"
        Me.txt_nome_sala.Size = New System.Drawing.Size(110, 17)
        Me.txt_nome_sala.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(639, 167)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(155, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(642, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(155, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(439, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Softwares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(657, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Capacidade"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApp2.My.Resources.Resources.image
        Me.PictureBox6.Location = New System.Drawing.Point(223, 53)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(193, 91)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'ID
        '
        Me.ID.HeaderText = "N"
        Me.ID.Name = "ID"
        '
        'NOMESALA
        '
        Me.NOMESALA.HeaderText = "NOME SALA"
        Me.NOMESALA.Name = "NOMESALA"
        '
        'TIPOSALA
        '
        Me.TIPOSALA.HeaderText = "TIPO DE SALA"
        Me.TIPOSALA.Name = "TIPOSALA"
        '
        'DISPONIBILIDADE
        '
        Me.DISPONIBILIDADE.HeaderText = "DISPONIBILIDADE"
        Me.DISPONIBILIDADE.Name = "DISPONIBILIDADE"
        '
        'EDITAR
        '
        Me.EDITAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDITAR.HeaderText = "EDITAR"
        Me.EDITAR.Image = CType(resources.GetObject("EDITAR.Image"), System.Drawing.Image)
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EDITAR.Width = 58
        '
        'EXCLUIR
        '
        Me.EXCLUIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EXCLUIR.HeaderText = "EXCLUIR"
        Me.EXCLUIR.Image = CType(resources.GetObject("EXCLUIR.Image"), System.Drawing.Image)
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EXCLUIR.Width = 65
        '
        'frm_cadastro_salas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 515)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_salas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro De Salas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cadastro_salas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_nome_sala As TextBox
    Friend WithEvents chk_softwares As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_caracteristicas As CheckedListBox
    Friend WithEvents bnt_cadastrar_salas As Button
    Friend WithEvents cmb_tipo_sala As ComboBox
    Friend WithEvents cmb_capacidade As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_status_salas As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgv_cadastro_salas As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOMESALA As DataGridViewTextBoxColumn
    Friend WithEvents TIPOSALA As DataGridViewTextBoxColumn
    Friend WithEvents DISPONIBILIDADE As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
End Class
