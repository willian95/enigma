Imports System.Data.SqlClient

Public Class seleccionarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(9) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@NDU", SqlDbType.Char, 9)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@PSW", SqlDbType.Char, 30)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@NAM", SqlDbType.Char, 60)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@NCE", SqlDbType.Char, 60)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@ARC", SqlDbType.Char, 80)
        params(6).Direction = ParameterDirection.Output

        params(7) = New SqlParameter("@ACC", SqlDbType.Char, 1)
        params(7).Direction = ParameterDirection.Output

        params(8) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(8).Direction = ParameterDirection.Output

        params(9) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(9).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SELECTUSER"

        command.Parameters.AddRange(params)

        cn.Open()

        My.Application.DoEvents()
        command.CommandTimeout = 0
        command.ExecuteReader()
        mensajeLbl.Text = params(9).Value.ToString

        Dim obj As Object
        Dim archivo As Object

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./usuarioSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuarioSeleccionado.txt")
        End If

        If Dir("./grupoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./grupoSeleccionado.txt")
        End If

        If Dir("./nombreSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./nombreSeleccionado.txt")
        End If

        If Dir("./claveSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./claveSeleccionado.txt")
        End If

        If Dir("./correoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./correoSeleccionado.txt")
        End If

        If Dir("./archivoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./archivoSeleccionado.txt")
        End If

        If Dir("./accesoSeleccionado.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./accesoSeleccionado.txt")
        End If

        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        If params(8).Value.ToString = "150" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuarioSeleccionado.txt")
            archivo.WriteLine(params(2).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupoSeleccionado.txt")
            archivo.WriteLine(params(1).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./nombreSeleccionado.txt")
            archivo.WriteLine(params(4).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./claveSeleccionado.txt")
            archivo.WriteLine(params(3).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./correoSeleccionado.txt")
            archivo.WriteLine(params(5).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./archivoSeleccionado.txt")
            archivo.WriteLine(params(6).Value.ToString)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./accesoSeleccionado.txt")
            archivo.WriteLine(params(7).Value.ToString)
            archivo.close()

            identificacionTxt.Text = ""

            Me.Hide()
            modificaUsuario.Show()


        End If

        cn.Close()

        Console.WriteLine(params(8).Value.ToString)


    End Sub

    Private Sub seleccionarUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Dir("./usuario.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuario.txt")
        End If
        If Dir("./nombre.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./nombre.txt")
        End If
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""

        Me.Hide()
        menuAdministrador.Show()
    End Sub
End Class