<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_redefinir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_redefinir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usu_ns = New System.Windows.Forms.TextBox()
        Me.txt_email_ns = New System.Windows.Forms.TextBox()
        Me.txt_ns = New System.Windows.Forms.TextBox()
        Me.txt_conf_ns = New System.Windows.Forms.TextBox()
        Me.btn_redefinir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nova Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirme a nova Senha"
        '
        'txt_usu_ns
        '
        Me.txt_usu_ns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usu_ns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usu_ns.Location = New System.Drawing.Point(107, 129)
        Me.txt_usu_ns.Name = "txt_usu_ns"
        Me.txt_usu_ns.Size = New System.Drawing.Size(114, 17)
        Me.txt_usu_ns.TabIndex = 8
        '
        'txt_email_ns
        '
        Me.txt_email_ns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email_ns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_ns.Location = New System.Drawing.Point(106, 172)
        Me.txt_email_ns.Name = "txt_email_ns"
        Me.txt_email_ns.Size = New System.Drawing.Size(212, 17)
        Me.txt_email_ns.TabIndex = 9
        '
        'txt_ns
        '
        Me.txt_ns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ns.Location = New System.Drawing.Point(561, 129)
        Me.txt_ns.Name = "txt_ns"
        Me.txt_ns.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ns.Size = New System.Drawing.Size(123, 17)
        Me.txt_ns.TabIndex = 10
        '
        'txt_conf_ns
        '
        Me.txt_conf_ns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_conf_ns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conf_ns.Location = New System.Drawing.Point(561, 171)
        Me.txt_conf_ns.Name = "txt_conf_ns"
        Me.txt_conf_ns.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_conf_ns.Size = New System.Drawing.Size(123, 17)
        Me.txt_conf_ns.TabIndex = 11
        '
        'btn_redefinir
        '
        Me.btn_redefinir.Location = New System.Drawing.Point(307, 237)
        Me.btn_redefinir.Name = "btn_redefinir"
        Me.btn_redefinir.Size = New System.Drawing.Size(138, 43)
        Me.btn_redefinir.TabIndex = 12
        Me.btn_redefinir.Text = "Redefinir"
        Me.btn_redefinir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 42)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Redefinir Senha"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApp2.My.Resources.Resources.v4Asset_7black_escrita1
        Me.PictureBox5.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(134, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(85, 156)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(257, 46)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(541, 155)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 46)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(541, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 46)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 46)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-126, 33)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(347, 566)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(544, -311)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(347, 566)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'frm_redefinir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 307)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btn_redefinir)
        Me.Controls.Add(Me.txt_conf_ns)
        Me.Controls.Add(Me.txt_ns)
        Me.Controls.Add(Me.txt_email_ns)
        Me.Controls.Add(Me.txt_usu_ns)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_redefinir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redefinir Senha"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txt_usu_ns As TextBox
    Friend WithEvents txt_email_ns As TextBox
    Friend WithEvents txt_ns As TextBox
    Friend WithEvents txt_conf_ns As TextBox
    Friend WithEvents btn_redefinir As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
