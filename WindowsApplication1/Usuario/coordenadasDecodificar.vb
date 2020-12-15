Imports System.Data.SqlClient

Public Class coordenadasDecodificar
    Private Sub coordenadasDecodificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            identificacionTxt.Text = texto
            operacionTxt.Text = "DECODE"
        End If

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
        params(1).Value = "EDOCED"

        params(2) = New SqlParameter("USU", SqlDbType.Char, 9)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@EOD", SqlDbType.Char, 6)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("POS", SqlDbType.Char, 10)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("NRO", SqlDbType.Char, 10)
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

        command.ExecuteReader()
        mensajeLbl.Text = params(8).Value.ToString

        Dim obj As Object
        Dim archivo As Object

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./coordenadasPos.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasPos.txt")
        End If

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./coordenadasNro.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasNro.txt")
        End If

        archivo = obj.CreateTextFile("./coordenadasPos.txt", True, True)
        archivo.WriteLine(params(4).Value.ToString)
        archivo.close()

        archivo = obj.CreateTextFile("./coordenadasNro.txt", True, True)
        archivo.WriteLine(params(5).Value.ToString)
        archivo.close()

        cn.Close()

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        archivo = obj.CreateTextFile("./respuesta.txt", True, True)
        archivo.WriteLine(params(8).Value.ToString)
        archivo.close()

        If params(7).Value.ToString <> "RC0" Then
            Me.Hide()
            NoSoyUnRobot.Show()
        End If

        Dim fc1 As String

        fc1 = params(4).Value.ToString()
        fc1Lbl.Text = fc1.Substring(0, 2)
        fc2Lbl.Text = fc1.Substring(2, 2)
        fc3Lbl.Text = fc1.Substring(4, 2)
        fc4Lbl.Text = fc1.Substring(6, 2)
        fc5Lbl.Text = fc1.Substring(8, 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        Dim conexionTxt As String
        Dim texto As String
        Dim Pos As String
        Dim Nro As String
        Dim userResponse As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt

        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(8) As SqlParameter

        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt")
            identificacionTxt.Text = texto
            operacionTxt.Text = "EDOCED"
        End If

        If Dir("./coordenadasPos.txt") <> "" Then
            Pos = My.Computer.FileSystem.ReadAllText("./coordenadasPos.txt")
        End If

        If Dir("./coordenadasNro.txt") <> "" Then
            Nro = My.Computer.FileSystem.ReadAllText("./coordenadasNro.txt")
        End If

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
        params(1).Value = "EDOCED"

        params(2) = New SqlParameter("@POS", SqlDbType.Char, 10)
        params(2).Value = Pos

        params(3) = New SqlParameter("@NRO", SqlDbType.Char, 10)
        params(3).Value = Nro

        userResponse = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text
        params(4) = New SqlParameter("@VAL", SqlDbType.Char, 10)
        params(4).Value = userResponse

        params(5) = New SqlParameter("USU", SqlDbType.Char, 9)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@EOD", SqlDbType.Char, 6)
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

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

            Me.Hide()
            decodificacionMensaje.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        Me.Hide()
        NoSoyUnRobotDecodificar.Show()
    End Sub

    Private Sub coordenadasDecodificar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub coordenadasDecodificar_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
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
            identificacionTxt.Text = texto
            operacionTxt.Text = "DECODE"
        End If

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@OPC", SqlDbType.Char, 6)
        params(1).Value = "EDOCED"

        params(2) = New SqlParameter("USU", SqlDbType.Char, 9)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@EOD", SqlDbType.Char, 6)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("POS", SqlDbType.Char, 10)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("NRO", SqlDbType.Char, 10)
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

        command.ExecuteReader()
        mensajeLbl.Text = params(8).Value.ToString

        Dim obj As Object
        Dim archivo As Object

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./coordenadasPos.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasPos.txt")
        End If

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./coordenadasNro.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./coordenadasNro.txt")
        End If

        archivo = obj.CreateTextFile("./coordenadasPos.txt", True, True)
        archivo.WriteLine(params(4).Value.ToString)
        archivo.close()

        archivo = obj.CreateTextFile("./coordenadasNro.txt", True, True)
        archivo.WriteLine(params(5).Value.ToString)
        archivo.close()

        cn.Close()

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        archivo = obj.CreateTextFile("./respuesta.txt", True, True)
        archivo.WriteLine(params(8).Value.ToString)
        archivo.close()

        If params(7).Value.ToString <> "RC0" Then
            Me.Hide()
            NoSoyUnRobot.Show()
        End If

        Dim fc1 As String

        fc1 = params(4).Value.ToString()
        fc1Lbl.Text = fc1.Substring(0, 2)
        fc2Lbl.Text = fc1.Substring(2, 2)
        fc3Lbl.Text = fc1.Substring(4, 2)
        fc4Lbl.Text = fc1.Substring(6, 2)
        fc5Lbl.Text = fc1.Substring(8, 2)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub
End Class