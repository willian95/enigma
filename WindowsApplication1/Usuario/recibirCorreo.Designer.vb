<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recibirCorreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recibirCorreo))
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyPanel2 = New WindowsApplication1.MyPanel()
        Me.archivoTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numeroTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.emisorTxt = New System.Windows.Forms.TextBox()
        Me.destinatarioTxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyPanel1
        '
        Me.MyPanel1.BackgroundImage = CType(resources.GetObject("MyPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.Button1)
        Me.MyPanel1.Controls.Add(Me.Label8)
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Controls.Add(Me.Button2)
        Me.MyPanel1.Location = New System.Drawing.Point(1, 1)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(682, 461)
        Me.MyPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(23, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(238, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(413, 31)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "RECIBIR MENSAJE vía eMAIL"
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel2.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel2.BorderWidth = 5
        Me.MyPanel2.Controls.Add(Me.archivoTxt)
        Me.MyPanel2.Controls.Add(Me.Label3)
        Me.MyPanel2.Controls.Add(Me.Label5)
        Me.MyPanel2.Controls.Add(Me.numeroTxt)
        Me.MyPanel2.Controls.Add(Me.Label2)
        Me.MyPanel2.Controls.Add(Me.Label1)
        Me.MyPanel2.Controls.Add(Me.Label6)
        Me.MyPanel2.Controls.Add(Me.Label4)
        Me.MyPanel2.Controls.Add(Me.mensajeLbl)
        Me.MyPanel2.Controls.Add(Me.emisorTxt)
        Me.MyPanel2.Controls.Add(Me.destinatarioTxt)
        Me.MyPanel2.Location = New System.Drawing.Point(231, 138)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(418, 248)
        Me.MyPanel2.TabIndex = 22
        '
        'archivoTxt
        '
        Me.archivoTxt.Location = New System.Drawing.Point(169, 155)
        Me.archivoTxt.Name = "archivoTxt"
        Me.archivoTxt.Size = New System.Drawing.Size(213, 20)
        Me.archivoTxt.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(18, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Archivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(18, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nombre"
        '
        'numeroTxt
        '
        Me.numeroTxt.Location = New System.Drawing.Point(169, 94)
        Me.numeroTxt.Name = "numeroTxt"
        Me.numeroTxt.Size = New System.Drawing.Size(213, 20)
        Me.numeroTxt.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(18, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mensaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(18, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Número"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(18, 11)
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
        Me.Label4.Location = New System.Drawing.Point(18, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Emisor"
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(51, 208)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 10
        '
        'emisorTxt
        '
        Me.emisorTxt.Location = New System.Drawing.Point(169, 54)
        Me.emisorTxt.MaxLength = 9
        Me.emisorTxt.Name = "emisorTxt"
        Me.emisorTxt.Size = New System.Drawing.Size(213, 20)
        Me.emisorTxt.TabIndex = 6
        '
        'destinatarioTxt
        '
        Me.destinatarioTxt.Location = New System.Drawing.Point(169, 16)
        Me.destinatarioTxt.Name = "destinatarioTxt"
        Me.destinatarioTxt.ReadOnly = True
        Me.destinatarioTxt.Size = New System.Drawing.Size(213, 20)
        Me.destinatarioTxt.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(601, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'recibirCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Name = "recibirCorreo"
        Me.Text = "recibirCorreo"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents archivoTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numeroTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mensajeLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents emisorTxt As TextBox
    Friend WithEvents destinatarioTxt As TextBox
    Friend WithEvents Button1 As Button
End Class
