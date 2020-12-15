<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificaUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificaUsuario))
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.MyPanel2 = New WindowsApplication1.MyPanel()
        Me.accesoCmb = New System.Windows.Forms.ComboBox()
        Me.archivoTxt = New System.Windows.Forms.TextBox()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.repetirTxt = New System.Windows.Forms.TextBox()
        Me.correoTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyPanel1
        '
        Me.MyPanel1.BackgroundImage = CType(resources.GetObject("MyPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Controls.Add(Me.Label5)
        Me.MyPanel1.Controls.Add(Me.Button2)
        Me.MyPanel1.Controls.Add(Me.Button1)
        Me.MyPanel1.Location = New System.Drawing.Point(1, 0)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(684, 462)
        Me.MyPanel1.TabIndex = 2
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel2.BorderColor = System.Drawing.Color.Gray
        Me.MyPanel2.BorderWidth = 10
        Me.MyPanel2.Controls.Add(Me.accesoCmb)
        Me.MyPanel2.Controls.Add(Me.archivoTxt)
        Me.MyPanel2.Controls.Add(Me.mensajeLbl)
        Me.MyPanel2.Controls.Add(Me.repetirTxt)
        Me.MyPanel2.Controls.Add(Me.correoTxt)
        Me.MyPanel2.Controls.Add(Me.nombreTxt)
        Me.MyPanel2.Controls.Add(Me.Label1)
        Me.MyPanel2.Controls.Add(Me.Label11)
        Me.MyPanel2.Controls.Add(Me.Label10)
        Me.MyPanel2.Controls.Add(Me.Label9)
        Me.MyPanel2.Controls.Add(Me.Label8)
        Me.MyPanel2.Controls.Add(Me.Label6)
        Me.MyPanel2.Controls.Add(Me.identificacionTxt)
        Me.MyPanel2.Location = New System.Drawing.Point(305, 67)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(349, 334)
        Me.MyPanel2.TabIndex = 22
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
        'archivoTxt
        '
        Me.archivoTxt.BackColor = System.Drawing.Color.White
        Me.archivoTxt.Location = New System.Drawing.Point(123, 225)
        Me.archivoTxt.Name = "archivoTxt"
        Me.archivoTxt.Size = New System.Drawing.Size(205, 20)
        Me.archivoTxt.TabIndex = 39
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(30, 306)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(400, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 8
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label5.Location = New System.Drawing.Point(371, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "MODIFICAR USUARIO"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(24, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(604, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Name = "modificaUsuario"
        Me.Text = "modificaUsuario"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents accesoCmb As ComboBox
    Friend WithEvents archivoTxt As TextBox
    Friend WithEvents mensajeLbl As Label
    Friend WithEvents repetirTxt As TextBox
    Friend WithEvents correoTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents Label5 As Label
End Class
