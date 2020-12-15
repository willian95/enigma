<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoSoyUnRobotDecodificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoSoyUnRobotDecodificar))
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyPanel2 = New WindowsApplication1.MyPanel()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.valor = New System.Windows.Forms.TextBox()
        Me.codigoTxt = New System.Windows.Forms.TextBox()
        Me.operacionTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyPanel1
        '
        Me.MyPanel1.BackgroundImage = CType(resources.GetObject("MyPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.Button2)
        Me.MyPanel1.Controls.Add(Me.Button1)
        Me.MyPanel1.Controls.Add(Me.Label8)
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Location = New System.Drawing.Point(1, 0)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(684, 462)
        Me.MyPanel1.TabIndex = 1
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
        Me.Button2.Location = New System.Drawing.Point(24, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(596, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(304, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(367, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "TEST NO SOY UN ROBOT"
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel2.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel2.BorderWidth = 5
        Me.MyPanel2.Controls.Add(Me.mensajeLbl)
        Me.MyPanel2.Controls.Add(Me.valor)
        Me.MyPanel2.Controls.Add(Me.codigoTxt)
        Me.MyPanel2.Controls.Add(Me.operacionTxt)
        Me.MyPanel2.Controls.Add(Me.Label1)
        Me.MyPanel2.Controls.Add(Me.Label4)
        Me.MyPanel2.Controls.Add(Me.identificacionTxt)
        Me.MyPanel2.Location = New System.Drawing.Point(299, 127)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(372, 256)
        Me.MyPanel2.TabIndex = 0
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(47, 185)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 23
        '
        'valor
        '
        Me.valor.BackColor = System.Drawing.Color.White
        Me.valor.Location = New System.Drawing.Point(130, 139)
        Me.valor.Name = "valor"
        Me.valor.Size = New System.Drawing.Size(136, 20)
        Me.valor.TabIndex = 21
        Me.valor.UseSystemPasswordChar = True
        '
        'codigoTxt
        '
        Me.codigoTxt.BackColor = System.Drawing.Color.White
        Me.codigoTxt.Location = New System.Drawing.Point(130, 104)
        Me.codigoTxt.Name = "codigoTxt"
        Me.codigoTxt.ReadOnly = True
        Me.codigoTxt.Size = New System.Drawing.Size(136, 20)
        Me.codigoTxt.TabIndex = 20
        '
        'operacionTxt
        '
        Me.operacionTxt.BackColor = System.Drawing.Color.White
        Me.operacionTxt.Location = New System.Drawing.Point(130, 69)
        Me.operacionTxt.Name = "operacionTxt"
        Me.operacionTxt.ReadOnly = True
        Me.operacionTxt.Size = New System.Drawing.Size(220, 20)
        Me.operacionTxt.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(16, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Operación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Identif."
        '
        'identificacionTxt
        '
        Me.identificacionTxt.BackColor = System.Drawing.Color.White
        Me.identificacionTxt.Location = New System.Drawing.Point(131, 36)
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.ReadOnly = True
        Me.identificacionTxt.Size = New System.Drawing.Size(219, 20)
        Me.identificacionTxt.TabIndex = 17
        '
        'NoSoyUnRobotDecodificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Name = "NoSoyUnRobotDecodificar"
        Me.Text = "NoSoyUnRobotDecodificar"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents mensajeLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents valor As TextBox
    Friend WithEvents codigoTxt As TextBox
    Friend WithEvents operacionTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents identificacionTxt As TextBox
End Class
