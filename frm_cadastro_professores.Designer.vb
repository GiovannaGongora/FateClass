<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_professores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_professores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.bnt_cadastrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_professores = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDITAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EXCLUIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_professores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.txt_login)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Controls.Add(Me.cmb_data_nasc)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb_status)
        Me.GroupBox1.Controls.Add(Me.img_foto)
        Me.GroupBox1.Controls.Add(Me.bnt_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS DO USUARIO"
        '
        'txt_login
        '
        Me.txt_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(171, 167)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(113, 17)
        Me.txt_login.TabIndex = 16
        '
        'txt_tel
        '
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(31, 167)
        Me.txt_tel.Mask = "(99)99999-9999"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(115, 17)
        Me.txt_tel.TabIndex = 0
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.cmb_data_nasc.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmb_data_nasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(385, 101)
        Me.cmb_data_nasc.Margin = New System.Windows.Forms.Padding(1)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(120, 24)
        Me.cmb_data_nasc.TabIndex = 6
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(34, 103)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(310, 17)
        Me.txt_email.TabIndex = 0
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(41, 49)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 17)
        Me.txt_cpf.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(444, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "STATUS"
        '
        'cmb_status
        '
        Me.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"ATIVO", "BLOQUEADO"})
        Me.cmb_status.Location = New System.Drawing.Point(447, 163)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(121, 23)
        Me.cmb_status.TabIndex = 17
        '
        'img_foto
        '
        Me.img_foto.Image = Global.WindowsApp2.My.Resources.Resources.adicionar_imagem
        Me.img_foto.Location = New System.Drawing.Point(587, 20)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(137, 137)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 16
        Me.img_foto.TabStop = False
        '
        'bnt_cadastrar
        '
        Me.bnt_cadastrar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.bnt_cadastrar.FlatAppearance.BorderSize = 0
        Me.bnt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bnt_cadastrar.Location = New System.Drawing.Point(587, 163)
        Me.bnt_cadastrar.Name = "bnt_cadastrar"
        Me.bnt_cadastrar.Size = New System.Drawing.Size(137, 33)
        Me.bnt_cadastrar.TabIndex = 15
        Me.bnt_cadastrar.Text = "CADASTRAR"
        Me.bnt_cadastrar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(294, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SENHA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(165, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TELEFONE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DATA DE NASCIMENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(25, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 27)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txt_nome)
        Me.Panel2.Location = New System.Drawing.Point(205, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 27)
        Me.Panel2.TabIndex = 28
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(5, 6)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(327, 17)
        Me.txt_nome.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(26, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 27)
        Me.Panel3.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(25, 162)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(130, 27)
        Me.Panel4.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(162, 162)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(130, 27)
        Me.Panel5.TabIndex = 29
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txt_senha)
        Me.Panel6.Location = New System.Drawing.Point(297, 162)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(130, 27)
        Me.Panel6.TabIndex = 30
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(12, 7)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(115, 17)
        Me.txt_senha.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.dgv_professores)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 376)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VISUALIZAR USUARIOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_7black_escrita
        Me.PictureBox1.Location = New System.Drawing.Point(7, 297)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'dgv_professores
        '
        Me.dgv_professores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_professores.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgv_professores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_professores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_professores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_professores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.NOME, Me.CPF, Me.EDITAR, Me.EXCLUIR})
        Me.dgv_professores.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_professores.Location = New System.Drawing.Point(6, 46)
        Me.dgv_professores.Name = "dgv_professores"
        Me.dgv_professores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_professores.Size = New System.Drawing.Size(733, 245)
        Me.dgv_professores.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.txt_buscar, Me.ToolStripLabel3, Me.cmb_tipo})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(735, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripLabel2.Text = "Digite o Nome ou CPF:"
        '
        'txt_buscar
        '
        Me.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel3.Text = "Selecione o tipo:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 25)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero"
        Me.Column1.Name = "Column1"
        '
        'NOME
        '
        Me.NOME.HeaderText = "NOME"
        Me.NOME.Name = "NOME"
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
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
        'frm_cadastro_professores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(764, 588)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_professores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro De Professores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_professores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bnt_cadastrar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_login As TextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_professores As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
End Class
