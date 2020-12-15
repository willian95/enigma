Imports System.Data.SqlClient

Public Class seeTest
    Private Sub seeTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim identificador As String

        If Dir("./usuario.txt") <> "" Then
            identificador = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        End If

        identificadorTxt.Text = identificador

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt
        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(10) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificador

        params(1) = New SqlParameter("@USU", SqlDbType.Char, 9)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@RC1", SqlDbType.Char, 20)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@RC2", SqlDbType.Char, 20)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@RC3", SqlDbType.Char, 20)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@RC4", SqlDbType.Char, 20)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@RC5", SqlDbType.Char, 20)
        params(6).Direction = ParameterDirection.Output

        params(7) = New SqlParameter("@RC6", SqlDbType.Char, 20)
        params(7).Direction = ParameterDirection.Output

        params(8) = New SqlParameter("@RC7", SqlDbType.Char, 20)
        params(8).Direction = ParameterDirection.Output

        params(9) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(9).Direction = ParameterDirection.Output

        params(10) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(10).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SEETEST"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        MensajeLbl.Text = params(10).Value.ToString

        cn.Close()

        Dim rc1 As String
        Dim rc2 As String
        Dim rc3 As String
        Dim rc4 As String
        Dim rc5 As String
        Dim rc6 As String
        Dim rc7 As String
        Dim rc8 As String
        Dim rc9 As String

        rc1 = params(2).Value.ToString()
        a1txt.Text = rc1.Substring(0, 2)
        b1txt.Text = rc1.Substring(2, 2)
        c1txt.Text = rc1.Substring(4, 2)
        d1txt.Text = rc1.Substring(6, 2)
        e1txt.Text = rc1.Substring(8, 2)
        f1txt.Text = rc1.Substring(10, 2)
        g1txt.Text = rc1.Substring(12, 2)

        rc2 = params(3).Value.ToString()
        a2txt.Text = rc2.Substring(0, 2)
        b2txt.Text = rc2.Substring(2, 2)
        c2txt.Text = rc2.Substring(4, 2)
        d2txt.Text = rc2.Substring(6, 2)
        e2txt.Text = rc2.Substring(8, 2)
        f2txt.Text = rc2.Substring(10, 2)
        g2txt.Text = rc2.Substring(12, 2)

        rc3 = params(4).Value.ToString()
        a3txt.Text = rc3.Substring(0, 2)
        b3txt.Text = rc3.Substring(2, 2)
        c3txt.Text = rc3.Substring(4, 2)
        d3txt.Text = rc3.Substring(6, 2)
        e3txt.Text = rc3.Substring(8, 2)
        f3txt.Text = rc3.Substring(10, 2)
        g3txt.Text = rc3.Substring(12, 2)

        rc4 = params(5).Value.ToString()
        a4txt.Text = rc4.Substring(0, 2)
        b4txt.Text = rc4.Substring(2, 2)
        c4txt.Text = rc4.Substring(4, 2)
        d4txt.Text = rc4.Substring(6, 2)
        e4txt.Text = rc4.Substring(8, 2)
        f4txt.Text = rc4.Substring(10, 2)
        g4txt.Text = rc4.Substring(12, 2)

        rc5 = params(6).Value.ToString()
        a5txt.Text = rc5.Substring(0, 2)
        b5txt.Text = rc5.Substring(2, 2)
        c5txt.Text = rc5.Substring(4, 2)
        d5txt.Text = rc5.Substring(6, 2)
        e5txt.Text = rc5.Substring(8, 2)
        f5txt.Text = rc5.Substring(10, 2)
        g5txt.Text = rc5.Substring(12, 2)

        rc6 = params(7).Value.ToString()
        a6txt.Text = rc6.Substring(0, 2)
        b6txt.Text = rc6.Substring(2, 2)
        c6txt.Text = rc6.Substring(4, 2)
        d6txt.Text = rc6.Substring(6, 2)
        e6txt.Text = rc6.Substring(8, 2)
        f6txt.Text = rc6.Substring(10, 2)
        g6txt.Text = rc6.Substring(12, 2)

        rc7 = params(8).Value.ToString()
        a7txt.Text = rc7.Substring(0, 2)
        b7txt.Text = rc7.Substring(2, 2)
        c7txt.Text = rc7.Substring(4, 2)
        d7txt.Text = rc7.Substring(6, 2)
        e7txt.Text = rc7.Substring(8, 2)
        f7txt.Text = rc7.Substring(10, 2)
        g7txt.Text = rc7.Substring(12, 2)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub seeTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub seeTest_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim identificador As String

        If Dir("./usuario.txt") <> "" Then
            identificador = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        End If

        identificadorTxt.Text = identificador

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt
        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(10) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 9)
        params(0).Value = identificador

        params(1) = New SqlParameter("@USU", SqlDbType.Char, 9)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@RC1", SqlDbType.Char, 20)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@RC2", SqlDbType.Char, 20)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@RC3", SqlDbType.Char, 20)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@RC4", SqlDbType.Char, 20)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@RC5", SqlDbType.Char, 20)
        params(6).Direction = ParameterDirection.Output

        params(7) = New SqlParameter("@RC6", SqlDbType.Char, 20)
        params(7).Direction = ParameterDirection.Output

        params(8) = New SqlParameter("@RC7", SqlDbType.Char, 20)
        params(8).Direction = ParameterDirection.Output

        params(9) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(9).Direction = ParameterDirection.Output

        params(10) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(10).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SEETEST"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        MensajeLbl.Text = params(10).Value.ToString

        cn.Close()

        Dim rc1 As String
        Dim rc2 As String
        Dim rc3 As String
        Dim rc4 As String
        Dim rc5 As String
        Dim rc6 As String
        Dim rc7 As String
        Dim rc8 As String
        Dim rc9 As String

        rc1 = params(2).Value.ToString()
        a1txt.Text = rc1.Substring(0, 2)
        b1txt.Text = rc1.Substring(2, 2)
        c1txt.Text = rc1.Substring(4, 2)
        d1txt.Text = rc1.Substring(6, 2)
        e1txt.Text = rc1.Substring(8, 2)
        f1txt.Text = rc1.Substring(10, 2)
        g1txt.Text = rc1.Substring(12, 2)

        rc2 = params(3).Value.ToString()
        a2txt.Text = rc2.Substring(0, 2)
        b2txt.Text = rc2.Substring(2, 2)
        c2txt.Text = rc2.Substring(4, 2)
        d2txt.Text = rc2.Substring(6, 2)
        e2txt.Text = rc2.Substring(8, 2)
        f2txt.Text = rc2.Substring(10, 2)
        g2txt.Text = rc2.Substring(12, 2)

        rc3 = params(4).Value.ToString()
        a3txt.Text = rc3.Substring(0, 2)
        b3txt.Text = rc3.Substring(2, 2)
        c3txt.Text = rc3.Substring(4, 2)
        d3txt.Text = rc3.Substring(6, 2)
        e3txt.Text = rc3.Substring(8, 2)
        f3txt.Text = rc3.Substring(10, 2)
        g3txt.Text = rc3.Substring(12, 2)

        rc4 = params(5).Value.ToString()
        a4txt.Text = rc4.Substring(0, 2)
        b4txt.Text = rc4.Substring(2, 2)
        c4txt.Text = rc4.Substring(4, 2)
        d4txt.Text = rc4.Substring(6, 2)
        e4txt.Text = rc4.Substring(8, 2)
        f4txt.Text = rc4.Substring(10, 2)
        g4txt.Text = rc4.Substring(12, 2)

        rc5 = params(6).Value.ToString()
        a5txt.Text = rc5.Substring(0, 2)
        b5txt.Text = rc5.Substring(2, 2)
        c5txt.Text = rc5.Substring(4, 2)
        d5txt.Text = rc5.Substring(6, 2)
        e5txt.Text = rc5.Substring(8, 2)
        f5txt.Text = rc5.Substring(10, 2)
        g5txt.Text = rc5.Substring(12, 2)

        rc6 = params(7).Value.ToString()
        a6txt.Text = rc6.Substring(0, 2)
        b6txt.Text = rc6.Substring(2, 2)
        c6txt.Text = rc6.Substring(4, 2)
        d6txt.Text = rc6.Substring(6, 2)
        e6txt.Text = rc6.Substring(8, 2)
        f6txt.Text = rc6.Substring(10, 2)
        g6txt.Text = rc6.Substring(12, 2)

        rc7 = params(8).Value.ToString()
        a7txt.Text = rc7.Substring(0, 2)
        b7txt.Text = rc7.Substring(2, 2)
        c7txt.Text = rc7.Substring(4, 2)
        d7txt.Text = rc7.Substring(6, 2)
        e7txt.Text = rc7.Substring(8, 2)
        f7txt.Text = rc7.Substring(10, 2)
        g7txt.Text = rc7.Substring(12, 2)
    End Sub
End Class