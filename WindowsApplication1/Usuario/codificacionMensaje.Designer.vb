<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class codificacionMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(codificacionMensaje))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.destinatarioTxt = New System.Windows.Forms.TextBox()
        Me.emisorTxt = New System.Windows.Forms.TextBox()
        Me.numeroMensajeTxt = New System.Windows.Forms.TextBox()
        Me.mensajeTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mensajeLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codificacion Mensaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destinatario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Emisor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nº Mensaje"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mensaje"
        '
        'destinatarioTxt
        '
        Me.destinatarioTxt.Location = New System.Drawing.Point(275, 67)
        Me.destinatarioTxt.Name = "destinatarioTxt"
        Me.destinatarioTxt.Size = New System.Drawing.Size(197, 20)
        Me.destinatarioTxt.TabIndex = 5
        '
        'emisorTxt
        '
        Me.emisorTxt.Location = New System.Drawing.Point(275, 111)
        Me.emisorTxt.Name = "emisorTxt"
        Me.emisorTxt.Size = New System.Drawing.Size(197, 20)
        Me.emisorTxt.TabIndex = 6
        '
        'numeroMensajeTxt
        '
        Me.numeroMensajeTxt.Location = New System.Drawing.Point(275, 162)
        Me.numeroMensajeTxt.Name = "numeroMensajeTxt"
        Me.numeroMensajeTxt.Size = New System.Drawing.Size(197, 20)
        Me.numeroMensajeTxt.TabIndex = 7
        '
        'mensajeTxt
        '
        Me.mensajeTxt.Location = New System.Drawing.Point(209, 236)
        Me.mensajeTxt.Multiline = True
        Me.mensajeTxt.Name = "mensajeTxt"
        Me.mensajeTxt.Size = New System.Drawing.Size(263, 135)
        Me.mensajeTxt.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Codificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mensajeLbl
        '
        Me.mensajeLbl.AutoSize = True
        Me.mensajeLbl.Location = New System.Drawing.Point(86, 428)
        Me.mensajeLbl.Name = "mensajeLbl"
        Me.mensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.mensajeLbl.TabIndex = 10
        '
        'codificacionMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.mensajeLbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mensajeTxt)
        Me.Controls.Add(Me.numeroMensajeTxt)
        Me.Controls.Add(Me.emisorTxt)
        Me.Controls.Add(Me.destinatarioTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "codificacionMensaje"
        Me.Text = "codificacionMensaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents destinatarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents emisorTxt As System.Windows.Forms.TextBox
    Friend WithEvents numeroMensajeTxt As System.Windows.Forms.TextBox
    Friend WithEvents mensajeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mensajeLbl As System.Windows.Forms.Label
End Class
