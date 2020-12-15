Public Class menuSuperUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        activacionUsuarios.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        eliminarUsuario.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        cambiarClave.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub menuSuperUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Visible Then

            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

        End If
    End Sub

    Private Sub menuSuperUsuario_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible Then

            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

        End If
    End Sub

    Private Sub menuSuperUsuario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Dir("./usuario.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuario.txt")
        End If
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If
        If Dir("./nombre.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./nombre.txt")
        End If
        If Dir("./clave.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./clave.txt")
        End If
        If Dir("./grupo.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./grupo.txt")
        End If

        If Dir("./accesoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./accesoSeleccionado.txt")
        End If

        If Dir("./archivoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./archivoSeleccionado.txt")
        End If

        If Dir("./claveSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./claveSeleccionado.txt")
        End If

        If Dir("./coordenadasPos.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasPos.txt")
        End If

        If Dir("./coordenadasNro.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasNro.txt")
        End If

        If Dir("./correoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./correoSeleccionado.txt")
        End If

        If Dir("./grupoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./grupoSeleccionado.txt")
        End If

        If Dir("./nombreSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./nombreSeleccionado.txt")
        End If

        If Dir("./NoSoyUnRobotPos.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./NoSoyUnRobotPos.txt")
        End If

        If Dir("./NoSoyUnRobotNro.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./NoSoyUnRobotNro.txt")
        End If

        If Dir("./usuarioSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuarioSeleccionado.txt")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        activacionUsuarios.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        eliminarUsuario.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        cambiarClave.Show()
    End Sub
End Class