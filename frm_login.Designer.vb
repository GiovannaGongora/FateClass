<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.bnt_login = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SAIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_senha_login
        '
        Me.txt_senha_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_login.Location = New System.Drawing.Point(442, 311)
        Me.txt_senha_login.Multiline = True
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_login.Size = New System.Drawing.Size(166, 23)
        Me.txt_senha_login.TabIndex = 5
        '
        'txt_user
        '
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(441, 252)
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(165, 23)
        Me.txt_user.TabIndex = 4
        '
        'bnt_login
        '
        Me.bnt_login.BackColor = System.Drawing.Color.White
        Me.bnt_login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bnt_login.FlatAppearance.BorderSize = 0
        Me.bnt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bnt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.bnt_login.Location = New System.Drawing.Point(403, 412)
        Me.bnt_login.Name = "bnt_login"
        Me.bnt_login.Size = New System.Drawing.Size(203, 37)
        Me.bnt_login.TabIndex = 3
        Me.bnt_login.Text = "ENTRAR"
        Me.bnt_login.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.SteelBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(438, 357)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(135, 16)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Esqueci minha senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.login_icon
        Me.PictureBox1.Location = New System.Drawing.Point(429, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_13borda
        Me.PictureBox4.Location = New System.Drawing.Point(-48, -24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(377, 584)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.WindowsApp2.My.Resources.Resources.icons8_senha_24
        Me.PictureBox3.Location = New System.Drawing.Point(406, 305)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(350, 292)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(283, 62)
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.userlogin
        Me.PictureBox2.Location = New System.Drawing.Point(407, 246)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(350, 233)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(283, 66)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(698, 544)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.bnt_login)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_senha_login As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents bnt_login As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
