<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registroUsuario))
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.accesoCmb = New System.Windows.Forms.ComboBox()
        Me.grupoCmb = New System.Windows.Forms.ComboBox()
        Me.archivoTxt = New System.Windows.Forms.TextBox()
        Me.repetirTxt = New System.Windows.Forms.TextBox()
        Me.correoTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(26, 308)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(12, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Atrás"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BorderColor = System.Drawing.Color.Gray
        Me.MyPanel1.BorderWidth = 10
        Me.MyPanel1.Controls.Add(Me.accesoCmb)
        Me.MyPanel1.Controls.Add(Me.grupoCmb)
        Me.MyPanel1.Controls.Add(Me.archivoTxt)
        Me.MyPanel1.Controls.Add(Me.mensajeLbl)
        Me.MyPanel1.Controls.Add(Me.repetirTxt)
        Me.MyPanel1.Controls.Add(Me.correoTxt)
        Me.MyPanel1.Controls.Add(Me.nombreTxt)
        Me.MyPanel1.Controls.Add(Me.Label1)
        Me.MyPanel1.Controls.Add(Me.Label11)
        Me.MyPanel1.Controls.Add(Me.Label10)
        Me.MyPanel1.Controls.Add(Me.Label9)
        Me.MyPanel1.Controls.Add(Me.Label8)
        Me.MyPanel1.Controls.Add(Me.Label7)
        Me.MyPanel1.Controls.Add(Me.Label6)
        Me.MyPanel1.Controls.Add(Me.identificacionTxt)
        Me.MyPanel1.Location = New System.Drawing.Point(294, 55)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(349, 352)
        Me.MyPanel1.TabIndex = 15
        '
        'accesoCmb
        '
        Me.accesoCmb.FormattingEnabled = True
        Me.accesoCmb.Items.AddRange(New Object() {"Escribe", "Lee", "Ambos"})
        Me.accesoCmb.Location = New System.Drawing.Point(123, 266)
        Me.accesoCmb.Name = "accesoCmb"
        Me.accesoCmb.Size = New System.Drawing.Size(205, 21)
        Me.accesoCmb.TabIndex = 41
        '
        'grupoCmb
        '
        Me.grupoCmb.FormattingEnabled = True
        Me.grupoCmb.Items.AddRange(New Object() {"GRP-1", "GRP-2", "GRP-3", "GRP-4", "GRP-5"})
        Me.grupoCmb.Location = New System.Drawing.Point(123, 17)
        Me.grupoCmb.Name = "grupoCmb"
        Me.grupoCmb.Size = New System.Drawing.Size(205, 21)
        Me.grupoCmb.TabIndex = 40
        '
        'archivoTxt
        '
        Me.archivoTxt.BackColor = System.Drawing.Color.White
        Me.archivoTxt.Location = New System.Drawing.Point(123, 225)
        Me.archivoTxt.Name = "archivoTxt"
        Me.archivoTxt.Size = New System.Drawing.Size(205, 20)
        Me.archivoTxt.TabIndex = 39
        '
        'repetirTxt
        '
        Me.repetirTxt.BackColor = System.Drawing.Color.White
        Me.repetirTxt.Location = New System.Drawing.Point(123, 184)
        Me.repetirTxt.Name = "repetirTxt"
        Me.repetirTxt.Size = New System.Drawing.Size(205, 20)
        Me.repetirTxt.TabIndex = 38
        '
        'correoTxt
        '
        Me.correoTxt.BackColor = System.Drawing.Color.White
        Me.correoTxt.Location = New System.Drawing.Point(123, 142)
        Me.correoTxt.Name = "correoTxt"
        Me.correoTxt.Size = New System.Drawing.Size(205, 20)
        Me.correoTxt.TabIndex = 37
        '
        'nombreTxt
        '
        Me.nombreTxt.BackColor = System.Drawing.Color.White
        Me.nombreTxt.Location = New System.Drawing.Point(123, 99)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(205, 20)
        Me.nombreTxt.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(29, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Acceso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(25, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Archivo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightCyan
        Me.Label10.Location = New System.Drawing.Point(25, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Repetir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightCyan
        Me.Label9.Location = New System.Drawing.Point(25, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 24)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(25, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(25, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Grupo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(25, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Identif."
        '
        'identificacionTxt
        '
        Me.identificacionTxt.BackColor = System.Drawing.Color.White
        Me.identificacionTxt.Location = New System.Drawing.Point(123, 56)
        Me.identificacionTxt.MaxLength = 9
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.Size = New System.Drawing.Size(205, 20)
        Me.identificacionTxt.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(593, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label5.Location = New System.Drawing.Point(360, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "REGISTRO DE USUARIOS"
        '
        'registroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "registroUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registroUsuario"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents archivoTxt As TextBox
    Friend WithEvents repetirTxt As TextBox
    Friend WithEvents correoTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents accesoCmb As ComboBox
    Friend WithEvents grupoCmb As ComboBox
End Class
