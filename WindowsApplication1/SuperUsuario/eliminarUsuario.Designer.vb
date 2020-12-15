<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eliminarUsuario))
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'identificacionTxt
        '
        Me.identificacionTxt.Location = New System.Drawing.Point(125, 53)
        Me.identificacionTxt.MaxLength = 9
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.Size = New System.Drawing.Size(229, 20)
        Me.identificacionTxt.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(606, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.ForeColor = System.Drawing.Color.White
        Me.mensajeLbl.Location = New System.Drawing.Point(48, 88)
        Me.mensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 4
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
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BorderColor = System.Drawing.Color.Gray
        Me.MyPanel1.BorderWidth = 10
        Me.MyPanel1.Controls.Add(Me.Label1)
        Me.MyPanel1.Controls.Add(Me.identificacionTxt)
        Me.MyPanel1.Controls.Add(Me.mensajeLbl)
        Me.MyPanel1.Location = New System.Drawing.Point(279, 259)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(377, 143)
        Me.MyPanel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(33, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Identif."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label4.Location = New System.Drawing.Point(273, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 31)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ELIMINACIÓN  DE USUARIO"
        '
        'eliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "eliminarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eliminarUsuario"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents identificacionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
