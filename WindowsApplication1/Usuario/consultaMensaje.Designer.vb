<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultaMensaje))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyPanel1 = New WindowsApplication1.MyPanel()
        Me.destinatarioTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MensajeLbl = New System.Windows.Forms.Label()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyPanel1.SuspendLayout()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(12, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(284, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CONSULTAR MENSAJES"
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BorderColor = System.Drawing.Color.Silver
        Me.MyPanel1.BorderWidth = 5
        Me.MyPanel1.Controls.Add(Me.table)
        Me.MyPanel1.Controls.Add(Me.destinatarioTxt)
        Me.MyPanel1.Controls.Add(Me.Label6)
        Me.MyPanel1.Controls.Add(Me.MensajeLbl)
        Me.MyPanel1.Location = New System.Drawing.Point(256, 68)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(406, 372)
        Me.MyPanel1.TabIndex = 14
        '
        'destinatarioTxt
        '
        Me.destinatarioTxt.Location = New System.Drawing.Point(165, 32)
        Me.destinatarioTxt.Name = "destinatarioTxt"
        Me.destinatarioTxt.ReadOnly = True
        Me.destinatarioTxt.Size = New System.Drawing.Size(213, 20)
        Me.destinatarioTxt.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(30, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Destinatario"
        '
        'MensajeLbl
        '
        Me.MensajeLbl.AutoSize = True
        Me.MensajeLbl.ForeColor = System.Drawing.Color.White
        Me.MensajeLbl.Location = New System.Drawing.Point(41, 329)
        Me.MensajeLbl.MaximumSize = New System.Drawing.Size(240, 0)
        Me.MensajeLbl.Name = "MensajeLbl"
        Me.MensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.MensajeLbl.TabIndex = 12
        '
        'table
        '
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.Emisor, Me.fecha})
        Me.table.Location = New System.Drawing.Point(34, 81)
        Me.table.Name = "table"
        Me.table.Size = New System.Drawing.Size(344, 245)
        Me.table.TabIndex = 23
        '
        'numero
        '
        Me.numero.HeaderText = "N Mensaje"
        Me.numero.Name = "numero"
        '
        'Emisor
        '
        Me.Emisor.HeaderText = "Emisor"
        Me.Emisor.Name = "Emisor"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'consultaMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "consultaMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "codificacionMensaje"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents destinatarioTxt As TextBox
    Friend WithEvents table As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents Emisor As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
End Class
