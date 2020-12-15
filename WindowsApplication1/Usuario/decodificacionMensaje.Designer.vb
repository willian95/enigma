<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class decodificacionMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(decodificacionMensaje))
        Me.destinatarioTxt = New System.Windows.Forms.TextBox()
        Me.emisorTxt = New System.Windows.Forms.TextBox()
        Me.numeroMensajeTxt = New System.Windows.Forms.TextBox()
        Me.mensajeTxt = New System.Windows.Forms.TextBox()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'destinatarioTxt
        '
        Me.destinatarioTxt.Location = New System.Drawing.Point(140, 25)
        Me.destinatarioTxt.Name = "destinatarioTxt"
        Me.destinatarioTxt.ReadOnly = True
        Me.destinatarioTxt.Size = New System.Drawing.Size(287, 20)
        Me.destinatarioTxt.TabIndex = 5
        '
        'emisorTxt
        '
        Me.emisorTxt.Location = New System.Drawing.Point(140, 58)
        Me.emisorTxt.MaxLength = 9
        Me.emisorTxt.Name = "emisorTxt"
        Me.emisorTxt.Size = New System.Drawing.Size(287, 20)
        Me.emisorTxt.TabIndex = 6
        '
        'numeroMensajeTxt
        '
        Me.numeroMensajeTxt.Location = New System.Drawing.Point(140, 90)
        Me.numeroMensajeTxt.Name = "numeroMensajeTxt"
        Me.numeroMensajeTxt.Size = New System.Drawing.Size(287, 20)
        Me.numeroMensajeTxt.TabIndex = 7
        '
        'mensajeTxt
        '
        Me.mensajeTxt.Location = New System.Drawing.Point(19, 129)
        Me.mensajeTxt.Multiline = True
        Me.mensajeTxt.Name = "mensajeTxt"
        Me.mensajeTxt.ReadOnly = True
        Me.mensajeTxt.Size = New System.Drawing.Size(408, 135)
        Me.mensajeTxt.TabIndex = 8
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(30, 286)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(599, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel1.BorderWidth = 5
        Me.MyPanel1.Controls.Add(Me.Label8)
        Me.MyPanel1.Controls.Add(Me.Label7)
        Me.MyPanel1.Controls.Add(Me.mensajeLbl)
        Me.MyPanel1.Controls.Add(Me.Label6)
        Me.MyPanel1.Controls.Add(Me.destinatarioTxt)
        Me.MyPanel1.Controls.Add(Me.mensajeTxt)
        Me.MyPanel1.Controls.Add(Me.emisorTxt)
        Me.MyPanel1.Controls.Add(Me.numeroMensajeTxt)
        Me.MyPanel1.Location = New System.Drawing.Point(222, 69)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(450, 332)
        Me.MyPanel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(15, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "N° Mensaje"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(15, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Emisor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(15, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Destinatario"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(204, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "DECODIFICACIÓN DE MENSAJES"
        '
        'decodificacionMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "decodificacionMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "codificacionMensaje"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents destinatarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents emisorTxt As System.Windows.Forms.TextBox
    Friend WithEvents numeroMensajeTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
