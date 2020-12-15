Public Class firstForm
    Private Sub MyPanel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MyPanel1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub firstForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Me.Hide()
        Form1.Show()
    End Sub
End Class