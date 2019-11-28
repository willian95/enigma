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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.num_mensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajeLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultar Mensajes"
        '
        'table
        '
        Me.table.AllowUserToDeleteRows = False
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_mensaje, Me.emisor, Me.feha})
        Me.table.Location = New System.Drawing.Point(128, 48)
        Me.table.Name = "table"
        Me.table.ReadOnly = True
        Me.table.Size = New System.Drawing.Size(344, 295)
        Me.table.TabIndex = 11
        '
        'num_mensaje
        '
        Me.num_mensaje.HeaderText = "N Mensaje"
        Me.num_mensaje.Name = "num_mensaje"
        Me.num_mensaje.ReadOnly = True
        '
        'emisor
        '
        Me.emisor.HeaderText = "Emisor"
        Me.emisor.Name = "emisor"
        Me.emisor.ReadOnly = True
        '
        'feha
        '
        Me.feha.HeaderText = "Fecha"
        Me.feha.Name = "feha"
        Me.feha.ReadOnly = True
        '
        'MensajeLbl
        '
        Me.MensajeLbl.AutoSize = True
        Me.MensajeLbl.Location = New System.Drawing.Point(42, 394)
        Me.MensajeLbl.Name = "MensajeLbl"
        Me.MensajeLbl.Size = New System.Drawing.Size(0, 13)
        Me.MensajeLbl.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Atrás"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'consultaMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MensajeLbl)
        Me.Controls.Add(Me.table)
        Me.Controls.Add(Me.Label1)
        Me.Name = "consultaMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "codificacionMensaje"
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents table As System.Windows.Forms.DataGridView
    Friend WithEvents num_mensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MensajeLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
