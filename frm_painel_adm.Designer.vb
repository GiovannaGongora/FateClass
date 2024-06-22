<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_painel_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_painel_adm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_mr = New System.Windows.Forms.Button()
        Me.btn_menu_relatorios = New System.Windows.Forms.Button()
        Me.btn_menu_reservar_salas = New System.Windows.Forms.Button()
        Me.btn_menu_cadastrar_prof = New System.Windows.Forms.Button()
        Me.btn_menu_cadastrar_salas = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Menu Administrador"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_4black
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(342, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Desconectar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_mr
        '
        Me.btn_mr.Image = Global.WindowsApp2.My.Resources.Resources.mr
        Me.btn_mr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mr.Location = New System.Drawing.Point(124, 244)
        Me.btn_mr.Name = "btn_mr"
        Me.btn_mr.Size = New System.Drawing.Size(203, 48)
        Me.btn_mr.TabIndex = 4
        Me.btn_mr.Text = "Minhas Reservas"
        Me.btn_mr.UseVisualStyleBackColor = True
        '
        'btn_menu_relatorios
        '
        Me.btn_menu_relatorios.Image = CType(resources.GetObject("btn_menu_relatorios.Image"), System.Drawing.Image)
        Me.btn_menu_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu_relatorios.Location = New System.Drawing.Point(234, 184)
        Me.btn_menu_relatorios.Name = "btn_menu_relatorios"
        Me.btn_menu_relatorios.Size = New System.Drawing.Size(203, 54)
        Me.btn_menu_relatorios.TabIndex = 3
        Me.btn_menu_relatorios.Text = "Solicitar Relatórios"
        Me.btn_menu_relatorios.UseVisualStyleBackColor = True
        '
        'btn_menu_reservar_salas
        '
        Me.btn_menu_reservar_salas.Image = CType(resources.GetObject("btn_menu_reservar_salas.Image"), System.Drawing.Image)
        Me.btn_menu_reservar_salas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu_reservar_salas.Location = New System.Drawing.Point(234, 124)
        Me.btn_menu_reservar_salas.Name = "btn_menu_reservar_salas"
        Me.btn_menu_reservar_salas.Size = New System.Drawing.Size(203, 54)
        Me.btn_menu_reservar_salas.TabIndex = 2
        Me.btn_menu_reservar_salas.Text = "Reservar Salas"
        Me.btn_menu_reservar_salas.UseVisualStyleBackColor = True
        '
        'btn_menu_cadastrar_prof
        '
        Me.btn_menu_cadastrar_prof.Image = CType(resources.GetObject("btn_menu_cadastrar_prof.Image"), System.Drawing.Image)
        Me.btn_menu_cadastrar_prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu_cadastrar_prof.Location = New System.Drawing.Point(19, 184)
        Me.btn_menu_cadastrar_prof.Name = "btn_menu_cadastrar_prof"
        Me.btn_menu_cadastrar_prof.Size = New System.Drawing.Size(203, 54)
        Me.btn_menu_cadastrar_prof.TabIndex = 1
        Me.btn_menu_cadastrar_prof.Text = "Gerenciar  Professores"
        Me.btn_menu_cadastrar_prof.UseVisualStyleBackColor = True
        '
        'btn_menu_cadastrar_salas
        '
        Me.btn_menu_cadastrar_salas.Image = CType(resources.GetObject("btn_menu_cadastrar_salas.Image"), System.Drawing.Image)
        Me.btn_menu_cadastrar_salas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu_cadastrar_salas.Location = New System.Drawing.Point(19, 124)
        Me.btn_menu_cadastrar_salas.Name = "btn_menu_cadastrar_salas"
        Me.btn_menu_cadastrar_salas.Size = New System.Drawing.Size(203, 54)
        Me.btn_menu_cadastrar_salas.TabIndex = 0
        Me.btn_menu_cadastrar_salas.Text = "Gerenciar Salas"
        Me.btn_menu_cadastrar_salas.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-204, -97)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(874, 819)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'frm_painel_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_mr)
        Me.Controls.Add(Me.btn_menu_relatorios)
        Me.Controls.Add(Me.btn_menu_reservar_salas)
        Me.Controls.Add(Me.btn_menu_cadastrar_prof)
        Me.Controls.Add(Me.btn_menu_cadastrar_salas)
        Me.Controls.Add(Me.PictureBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_painel_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Painel ADM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_menu_cadastrar_salas As Button
    Friend WithEvents btn_menu_cadastrar_prof As Button
    Friend WithEvents btn_menu_reservar_salas As Button
    Friend WithEvents btn_menu_relatorios As Button
    Friend WithEvents btn_mr As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
End Class
