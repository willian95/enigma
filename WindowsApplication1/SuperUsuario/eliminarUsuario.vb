Imports System.Data.SqlClient

Public Class eliminarUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(2) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(2).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "DELETEUSER"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(2).Value.ToString

        If params(1).Value.ToString = "500" Then

            Dim obj As Object
            Dim archivo As Object

            obj = CreateObject("Scripting.FileSystemObject")
            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            archivo = obj.CreateTextFile("./respuesta.txt", True, True)
            archivo.WriteLine(params(2).Value.ToString)
            archivo.close()

            identificacionTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()

    End Sub

    Private Sub eliminarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub eliminarUsuario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
End Class