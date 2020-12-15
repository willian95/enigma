<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiarClave
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cambiarClave))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuevaClaveTxt = New System.Windows.Forms.TextBox()
        Me.repetirClaveTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.claveTxt = New System.Windows.Forms.TextBox()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.atrasButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(37, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identif."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(40, 155)
        Me.Label3.MinimumSize = New System.Drawing.Size(60, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nueva"
        '
        'nuevaClaveTxt
        '
        Me.nuevaClaveTxt.Location = New System.Drawing.Point(180, 179)
        Me.nuevaClaveTxt.Name = "nuevaClaveTxt"
        Me.nuevaClaveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nuevaClaveTxt.Size = New System.Drawing.Size(205, 20)
        Me.nuevaClaveTxt.TabIndex = 7
        '
        'repetirClaveTxt
        '
        Me.repetirClaveTxt.Location = New System.Drawing.Point(181, 241)
        Me.repetirClaveTxt.Name = "repetirClaveTxt"
        Me.repetirClaveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repetirClaveTxt.Size = New System.Drawing.Size(203, 20)
        Me.repetirClaveTxt.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(604, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(38, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña"
        '
        'claveTxt
        '
        Me.claveTxt.Location = New System.Drawing.Point(182, 120)
        Me.claveTxt.Name = "claveTxt"
        Me.claveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.claveTxt.ReadOnly = True
        Me.claveTxt.Size = New System.Drawing.Size(205, 20)
        Me.claveTxt.TabIndex = 6
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(61, 285)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 10
        '
        'atrasButton
        '
        Me.atrasButton.BackColor = System.Drawing.Color.Transparent
        Me.atrasButton.BackgroundImage = CType(resources.GetObject("atrasButton.BackgroundImage"), System.Drawing.Image)
        Me.atrasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atrasButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.atrasButton.FlatAppearance.BorderSize = 3
        Me.atrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atrasButton.ForeColor = System.Drawing.Color.White
        Me.atrasButton.Location = New System.Drawing.Point(12, 410)
        Me.atrasButton.Name = "atrasButton"
        Me.atrasButton.Size = New System.Drawing.Size(50, 40)
        Me.atrasButton.TabIndex = 11
        Me.atrasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.atrasButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(37, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(40, 179)
        Me.Label6.MinimumSize = New System.Drawing.Size(60, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(39, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repetir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(39, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contraseña"
        '
        'identificacionTxt
        '
        Me.identificacionTxt.BackColor = System.Drawing.Color.White
        Me.identificacionTxt.Location = New System.Drawing.Point(179, 32)
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.ReadOnly = True
        Me.identificacionTxt.Size = New System.Drawing.Size(205, 20)
        Me.identificacionTxt.TabIndex = 15
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel1.BorderWidth = 5
        Me.MyPanel1.Controls.Add(Me.nameLabel)
        Me.MyPanel1.Controls.Add(Me.Label1)
        Me.MyPanel1.Controls.Add(Me.identificacionTxt)
        Me.MyPanel1.Controls.Add(Me.Label3)
        Me.MyPanel1.Controls.Add(Me.Label7)
        Me.MyPanel1.Controls.Add(Me.Label4)
        Me.MyPanel1.Controls.Add(Me.Label6)
        Me.MyPanel1.Controls.Add(Me.nuevaClaveTxt)
        Me.MyPanel1.Controls.Add(Me.Label2)
        Me.MyPanel1.Controls.Add(Me.repetirClaveTxt)
        Me.MyPanel1.Controls.Add(Me.mensajeLbl)
        Me.MyPanel1.Controls.Add(Me.Label5)
        Me.MyPanel1.Controls.Add(Me.claveTxt)
        Me.MyPanel1.Location = New System.Drawing.Point(220, 69)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(434, 334)
        Me.MyPanel1.TabIndex = 16
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(179, 75)
        Me.nameLabel.MaximumSize = New System.Drawing.Size(200, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 13)
        Me.nameLabel.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(278, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(353, 31)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CAMBIAR CONTRASEÑA"
        '
        'cambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.atrasButton)
        Me.Controls.Add(Me.Button1)
        Me.Name = "cambiarClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cambiarClave"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nuevaClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents repetirClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents claveTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents atrasButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label8 As Label
End Class
