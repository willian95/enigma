<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class codificacionMensaje
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(codificacionMensaje))
        Me.destinatarioTxt = New System.Windows.Forms.TextBox()
        Me.emisorTxt = New System.Windows.Forms.TextBox()
        Me.mensajeTxt = New System.Windows.Forms.TextBox()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'destinatarioTxt
        '
        Me.destinatarioTxt.Location = New System.Drawing.Point(169, 80)
        Me.destinatarioTxt.MaxLength = 9
        Me.destinatarioTxt.Name = "destinatarioTxt"
        Me.destinatarioTxt.Size = New System.Drawing.Size(213, 20)
        Me.destinatarioTxt.TabIndex = 5
        '
        'emisorTxt
        '
        Me.emisorTxt.Location = New System.Drawing.Point(169, 39)
        Me.emisorTxt.Name = "emisorTxt"
        Me.emisorTxt.ReadOnly = True
        Me.emisorTxt.Size = New System.Drawing.Size(213, 20)
        Me.emisorTxt.TabIndex = 6
        '
        'mensajeTxt
        '
        Me.mensajeTxt.Location = New System.Drawing.Point(22, 113)
        Me.mensajeTxt.Multiline = True
        Me.mensajeTxt.Name = "mensajeTxt"
        Me.mensajeTxt.Size = New System.Drawing.Size(360, 135)
        Me.mensajeTxt.TabIndex = 8
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(30, 268)
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
        Me.Button2.Location = New System.Drawing.Point(609, 410)
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
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
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
        Me.MyPanel1.Controls.Add(Me.Label6)
        Me.MyPanel1.Controls.Add(Me.Label4)
        Me.MyPanel1.Controls.Add(Me.mensajeLbl)
        Me.MyPanel1.Controls.Add(Me.emisorTxt)
        Me.MyPanel1.Controls.Add(Me.destinatarioTxt)
        Me.MyPanel1.Controls.Add(Me.mensajeTxt)
        Me.MyPanel1.Location = New System.Drawing.Point(241, 85)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(418, 305)
        Me.MyPanel1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(18, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Destinatario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(18, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Emisor"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(235, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(437, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CODIFICACIÓN DE MENSAJES"
        '
        'codificacionMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "codificacionMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "codificacionMensaje"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents destinatarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents emisorTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
End Class
