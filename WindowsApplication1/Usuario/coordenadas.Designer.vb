<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coordenadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coordenadas))
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyPanel2 = New WindowsApplication1.MyPanel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.fc5Lbl = New System.Windows.Forms.Label()
        Me.fc4Lbl = New System.Windows.Forms.Label()
        Me.fc3Lbl = New System.Windows.Forms.Label()
        Me.fc2Lbl = New System.Windows.Forms.Label()
        Me.fc1Lbl = New System.Windows.Forms.Label()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.operacionTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
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
        Me.MyPanel1.Controls.Add(Me.Button2)
        Me.MyPanel1.Controls.Add(Me.Label8)
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Controls.Add(Me.Button1)
        Me.MyPanel1.Location = New System.Drawing.Point(2, 1)
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
        Me.Button2.Location = New System.Drawing.Point(25, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(239, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(428, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "INGRESO DE COORDENADAS"
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel2.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel2.BorderWidth = 5
        Me.MyPanel2.Controls.Add(Me.TextBox5)
        Me.MyPanel2.Controls.Add(Me.TextBox4)
        Me.MyPanel2.Controls.Add(Me.TextBox3)
        Me.MyPanel2.Controls.Add(Me.TextBox2)
        Me.MyPanel2.Controls.Add(Me.TextBox1)
        Me.MyPanel2.Controls.Add(Me.fc5Lbl)
        Me.MyPanel2.Controls.Add(Me.fc4Lbl)
        Me.MyPanel2.Controls.Add(Me.fc3Lbl)
        Me.MyPanel2.Controls.Add(Me.fc2Lbl)
        Me.MyPanel2.Controls.Add(Me.fc1Lbl)
        Me.MyPanel2.Controls.Add(Me.mensajeLbl)
        Me.MyPanel2.Controls.Add(Me.operacionTxt)
        Me.MyPanel2.Controls.Add(Me.Label1)
        Me.MyPanel2.Controls.Add(Me.Label4)
        Me.MyPanel2.Controls.Add(Me.identificacionTxt)
        Me.MyPanel2.Location = New System.Drawing.Point(218, 151)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(449, 220)
        Me.MyPanel2.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(304, 126)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(30, 20)
        Me.TextBox5.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(226, 126)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(30, 20)
        Me.TextBox4.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(158, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(30, 20)
        Me.TextBox3.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(93, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(30, 20)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(36, 127)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox1.TabIndex = 29
        '
        'fc5Lbl
        '
        Me.fc5Lbl.AutoSize = True
        Me.fc5Lbl.ForeColor = System.Drawing.Color.White
        Me.fc5Lbl.Location = New System.Drawing.Point(306, 110)
        Me.fc5Lbl.Name = "fc5Lbl"
        Me.fc5Lbl.Size = New System.Drawing.Size(22, 13)
        Me.fc5Lbl.TabIndex = 28
        Me.fc5Lbl.Text = "fc5"
        '
        'fc4Lbl
        '
        Me.fc4Lbl.AutoSize = True
        Me.fc4Lbl.ForeColor = System.Drawing.Color.White
        Me.fc4Lbl.Location = New System.Drawing.Point(231, 110)
        Me.fc4Lbl.Name = "fc4Lbl"
        Me.fc4Lbl.Size = New System.Drawing.Size(22, 13)
        Me.fc4Lbl.TabIndex = 27
        Me.fc4Lbl.Text = "fc4"
        '
        'fc3Lbl
        '
        Me.fc3Lbl.AutoSize = True
        Me.fc3Lbl.ForeColor = System.Drawing.Color.White
        Me.fc3Lbl.Location = New System.Drawing.Point(162, 110)
        Me.fc3Lbl.Name = "fc3Lbl"
        Me.fc3Lbl.Size = New System.Drawing.Size(22, 13)
        Me.fc3Lbl.TabIndex = 26
        Me.fc3Lbl.Text = "fc3"
        '
        'fc2Lbl
        '
        Me.fc2Lbl.AutoSize = True
        Me.fc2Lbl.ForeColor = System.Drawing.Color.White
        Me.fc2Lbl.Location = New System.Drawing.Point(98, 110)
        Me.fc2Lbl.Name = "fc2Lbl"
        Me.fc2Lbl.Size = New System.Drawing.Size(22, 13)
        Me.fc2Lbl.TabIndex = 25
        Me.fc2Lbl.Text = "fc2"
        '
        'fc1Lbl
        '
        Me.fc1Lbl.AutoSize = True
        Me.fc1Lbl.ForeColor = System.Drawing.Color.White
        Me.fc1Lbl.Location = New System.Drawing.Point(42, 110)
        Me.fc1Lbl.Name = "fc1Lbl"
        Me.fc1Lbl.Size = New System.Drawing.Size(22, 13)
        Me.fc1Lbl.TabIndex = 24
        Me.fc1Lbl.Text = "fc1"
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(42, 179)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 23
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
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(617, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'coordenadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Name = "coordenadas"
        Me.Text = "Form2"
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
    Friend WithEvents operacionTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents fc5Lbl As Label
    Friend WithEvents fc4Lbl As Label
    Friend WithEvents fc3Lbl As Label
    Friend WithEvents fc2Lbl As Label
    Friend WithEvents fc1Lbl As Label
End Class
