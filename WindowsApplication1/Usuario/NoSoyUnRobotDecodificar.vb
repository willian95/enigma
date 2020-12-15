Imports System.Data.SqlClient

Public Class NoSoyUnRobotDecodificar
    Private Sub NoSoyUnRobotDecodificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim texto As String
        mensajeLbl.Text = ""
        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory

            Dim conexion As String
            Dim conexionTxt As String
            Dim conectar As conectionTxt
            conectar = New conectionTxt

            conexionTxt = conectar.readTxt()
            conexion = conexionTxt

            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim params(8) As SqlParameter

            params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
            params(0).Value = texto

            params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
            params(1).Value = "DECODE"

            params(2) = New SqlParameter("@USU", SqlDbType.Char, 9)
            params(2).Direction = ParameterDirection.Output

            params(3) = New SqlParameter("@EOD", SqlDbType.Char, 6)
            params(3).Direction = ParameterDirection.Output

            params(4) = New SqlParameter("@POS", SqlDbType.Char, 10)
            params(4).Direction = ParameterDirection.Output

            params(5) = New SqlParameter("@NRO", SqlDbType.Char, 10)
            params(5).Direction = ParameterDirection.Output

            params(6) = New SqlParameter("COD", SqlDbType.Char, 10)
            params(6).Direction = ParameterDirection.Output

            params(7) = New SqlParameter("OPT", SqlDbType.Char, 3)
            params(7).Direction = ParameterDirection.Output

            params(8) = New SqlParameter("RST", SqlDbType.Char, 100)
            params(8).Direction = ParameterDirection.Output

            Dim command As New SqlCommand()
            command.Connection = cn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ROWCOLUMN"

            command.Parameters.AddRange(params)

            cn.Open()

            command.CommandTimeout = 0
            command.ExecuteReader()

            If params(7).Value.ToString = "RC0" Then

                identificacionTxt.Text = texto
                operacionTxt.Text = params(1).Value.ToString
                codigoTxt.Text = params(6).Value.ToString

                Dim obj As Object
                Dim archivo As Object

                obj = CreateObject("Scripting.FileSystemObject")
                If Dir("./noSoyUnRobotPos.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./noSoyUnRobotPos.txt")
                End If

                obj = CreateObject("Scripting.FileSystemObject")
                If Dir("./noSoyUnRobotNro.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./noSoyUnRobotNro.txt")
                End If

                archivo = obj.CreateTextFile("./noSoyUnRobotPos.txt", True, True)
                archivo.WriteLine(params(4).Value.ToString)
                archivo.close()

                archivo = obj.CreateTextFile("./noSoyUnRobotNro.txt", True, True)
                archivo.WriteLine(params(5).Value.ToString)
                archivo.close()

            Else

                Dim obj As Object
                Dim archivo As Object

                obj = CreateObject("Scripting.FileSystemObject")
                If Dir("./respuesta.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./respuesta.txt")
                End If

                archivo = obj.CreateTextFile("./respuesta.txt", True, True)
                archivo.WriteLine(params(8).Value.ToString)
                archivo.close()

                Me.Close()
                menuUsuario.Show()

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        valor.Text = ""

        Me.Hide()
        menuUsuario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        Dim conexionTxt As String
        Dim texto As String
        Dim Pos As String
        Dim Nro As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt

        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(8) As SqlParameter

        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt")
        End If

        If Dir("./noSoyUnRobotPos.txt") <> "" Then
            Pos = My.Computer.FileSystem.ReadAllText("./noSoyUnRobotPos.txt")
        End If

        If Dir("./noSoyUnRobotNro.txt") <> "" Then
            Nro = My.Computer.FileSystem.ReadAllText("./noSoyUnRobotNro.txt")
        End If

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
        params(1).Value = "DECODE"

        params(2) = New SqlParameter("@POS", SqlDbType.Char, 10)
        params(2).Value = Pos

        params(3) = New SqlParameter("@NRO", SqlDbType.Char, 10)
        params(3).Value = Nro

        params(4) = New SqlParameter("@VAL", SqlDbType.Char, 10)
        params(4).Value = valor.Text

        params(5) = New SqlParameter("USU", SqlDbType.Char, 9)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("EOD", SqlDbType.Char, 6)
        params(6).Direction = ParameterDirection.Output

        params(7) = New SqlParameter("OPT", SqlDbType.Char, 3)
        params(7).Direction = ParameterDirection.Output

        params(8) = New SqlParameter("RST", SqlDbType.Char, 100)
        params(8).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CHECKROWCOL"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(8).Value.ToString

        cn.Close()

        If params(7).Value.ToString = "FC0" Then
            valor.Text = ""
            Me.Hide()
            coordenadasDecodificar.Show()

        End If

        Console.WriteLine(params(0).Value.ToString())
        Console.WriteLine(params(7).Value.ToString())
        Console.WriteLine(params(8).Value.ToString())
    End Sub

    Private Sub NoSoyUnRobotDecodificar_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim texto As String
            mensajeLbl.Text = ""
            If Dir("./respuesta.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./respuesta.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                mensajeLbl.Text = texto
                If Dir("./respuesta.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./respuesta.txt")
                End If
            End If

            If Dir("./usuario.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory

                Dim conexion As String
                Dim conexionTxt As String
                Dim conectar As conectionTxt
                conectar = New conectionTxt

                conexionTxt = conectar.readTxt()
                conexion = conexionTxt

                Dim cn As New SqlConnection
                cn.ConnectionString = conexion

                Dim params(8) As SqlParameter

                params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
                params(0).Value = texto

                params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
                params(1).Value = "DECODE"

                params(2) = New SqlParameter("@USU", SqlDbType.Char, 9)
                params(2).Direction = ParameterDirection.Output

                params(3) = New SqlParameter("@EOD", SqlDbType.Char, 6)
                params(3).Direction = ParameterDirection.Output

                params(4) = New SqlParameter("@POS", SqlDbType.Char, 10)
                params(4).Direction = ParameterDirection.Output

                params(5) = New SqlParameter("@NRO", SqlDbType.Char, 10)
                params(5).Direction = ParameterDirection.Output

                params(6) = New SqlParameter("COD", SqlDbType.Char, 10)
                params(6).Direction = ParameterDirection.Output

                params(7) = New SqlParameter("OPT", SqlDbType.Char, 3)
                params(7).Direction = ParameterDirection.Output

                params(8) = New SqlParameter("RST", SqlDbType.Char, 100)
                params(8).Direction = ParameterDirection.Output

                Dim command As New SqlCommand()
                command.Connection = cn
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "ROWCOLUMN"

                command.Parameters.AddRange(params)

                cn.Open()

                command.CommandTimeout = 0
                command.ExecuteReader()

                If params(7).Value.ToString = "RC0" Then

                    identificacionTxt.Text = texto
                    operacionTxt.Text = params(1).Value.ToString
                    codigoTxt.Text = params(6).Value.ToString

                    Dim obj As Object
                    Dim archivo As Object

                    obj = CreateObject("Scripting.FileSystemObject")
                    If Dir("./noSoyUnRobotPos.txt") <> "" Then
                        My.Computer.FileSystem.DeleteFile("./noSoyUnRobotPos.txt")
                    End If

                    obj = CreateObject("Scripting.FileSystemObject")
                    If Dir("./noSoyUnRobotNro.txt") <> "" Then
                        My.Computer.FileSystem.DeleteFile("./noSoyUnRobotNro.txt")
                    End If

                    archivo = obj.CreateTextFile("./noSoyUnRobotPos.txt", True, True)
                    archivo.WriteLine(params(4).Value.ToString)
                    archivo.close()

                    archivo = obj.CreateTextFile("./noSoyUnRobotNro.txt", True, True)
                    archivo.WriteLine(params(5).Value.ToString)
                    archivo.close()

                Else

                    Dim obj As Object
                    Dim archivo As Object

                    obj = CreateObject("Scripting.FileSystemObject")
                    If Dir("./respuesta.txt") <> "" Then
                        My.Computer.FileSystem.DeleteFile("./respuesta.txt")
                    End If

                    archivo = obj.CreateTextFile("./respuesta.txt", True, True)
                    archivo.WriteLine(params(8).Value.ToString)
                    archivo.close()

                    Me.Close()
                    menuUsuario.Show()

                End If

            End If

        End If
    End Sub

    Private Sub NoSoyUnRobotDecodificar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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