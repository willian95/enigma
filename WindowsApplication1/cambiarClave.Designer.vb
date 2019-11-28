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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.nuevaClaveTxt = New System.Windows.Forms.TextBox()
        Me.repetirClaveTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.claveTxt = New System.Windows.Forms.TextBox()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificaciòn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nueva Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repetir Contraseña"
        '
        'identificacionTxt
        '
        Me.identificacionTxt.Location = New System.Drawing.Point(295, 152)
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.ReadOnly = True
        Me.identificacionTxt.Size = New System.Drawing.Size(152, 20)
        Me.identificacionTxt.TabIndex = 4
        '
        'nuevaClaveTxt
        '
        Me.nuevaClaveTxt.Location = New System.Drawing.Point(295, 233)
        Me.nuevaClaveTxt.Name = "nuevaClaveTxt"
        Me.nuevaClaveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nuevaClaveTxt.Size = New System.Drawing.Size(152, 20)
        Me.nuevaClaveTxt.TabIndex = 7
        '
        'repetirClaveTxt
        '
        Me.repetirClaveTxt.Location = New System.Drawing.Point(295, 275)
        Me.repetirClaveTxt.Name = "repetirClaveTxt"
        Me.repetirClaveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repetirClaveTxt.Size = New System.Drawing.Size(150, 20)
        Me.repetirClaveTxt.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña"
        '
        'claveTxt
        '
        Me.claveTxt.Location = New System.Drawing.Point(295, 193)
        Me.claveTxt.Name = "claveTxt"
        Me.claveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.claveTxt.ReadOnly = True
        Me.claveTxt.Size = New System.Drawing.Size(152, 20)
        Me.claveTxt.TabIndex = 6
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.Location = New System.Drawing.Point(191, 414)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Atrás"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.mensajeLbl)
        Me.Controls.Add(Me.claveTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.repetirClaveTxt)
        Me.Controls.Add(Me.nuevaClaveTxt)
        Me.Controls.Add(Me.identificacionTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambiarClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cambiarClave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents identificacionTxt As System.Windows.Forms.TextBox
    Friend WithEvents nuevaClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents repetirClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents claveTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
