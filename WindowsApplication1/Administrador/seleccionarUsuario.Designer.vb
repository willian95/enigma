<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccionarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seleccionarUsuario))
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MyPanel2 = New WindowsApplication1.MyPanel()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.MyPanel1.Controls.Add(Me.Label5)
        Me.MyPanel1.Controls.Add(Me.Button1)
        Me.MyPanel1.Controls.Add(Me.Button2)
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(684, 462)
        Me.MyPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label5.Location = New System.Drawing.Point(377, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "MODIFICAR USUARIO"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(600, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(29, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel2.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel2.BorderWidth = 5
        Me.MyPanel2.Controls.Add(Me.mensajeLbl)
        Me.MyPanel2.Controls.Add(Me.Label6)
        Me.MyPanel2.Controls.Add(Me.identificacionTxt)
        Me.MyPanel2.Location = New System.Drawing.Point(281, 74)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(369, 310)
        Me.MyPanel2.TabIndex = 0
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(49, 260)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(29, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Identif."
        '
        'identificacionTxt
        '
        Me.identificacionTxt.BackColor = System.Drawing.Color.White
        Me.identificacionTxt.Location = New System.Drawing.Point(127, 35)
        Me.identificacionTxt.MaxLength = 9
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.Size = New System.Drawing.Size(205, 20)
        Me.identificacionTxt.TabIndex = 29
        '
        'seleccionarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Name = "seleccionarUsuario"
        Me.Text = "modificarUsuario"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents mensajeLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
End Class
