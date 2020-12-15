Imports System.Data.SqlClient

Public Class tarjetaCoordenadas
    Private Sub tarjetaCoordenadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim params(12) As SqlParameter

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

        params(9) = New SqlParameter("@RC8", SqlDbType.Char, 20)
        params(9).Direction = ParameterDirection.Output

        params(10) = New SqlParameter("@RC9", SqlDbType.Char, 20)
        params(10).Direction = ParameterDirection.Output

        params(11) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(11).Direction = ParameterDirection.Output

        params(12) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(12).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SEECARD"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        MensajeLbl.Text = params(12).Value.ToString

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
        h1txt.Text = rc1.Substring(14, 2)
        i1txt.Text = rc1.Substring(16, 2)
        j1txt.Text = rc1.Substring(18, 2)

        rc2 = params(3).Value.ToString()
        a2txt.Text = rc2.Substring(0, 2)
        b2txt.Text = rc2.Substring(2, 2)
        c2txt.Text = rc2.Substring(4, 2)
        d2txt.Text = rc2.Substring(6, 2)
        e2txt.Text = rc2.Substring(8, 2)
        f2txt.Text = rc2.Substring(10, 2)
        g2txt.Text = rc2.Substring(12, 2)
        h2txt.Text = rc2.Substring(14, 2)
        i2txt.Text = rc2.Substring(16, 2)
        j2txt.Text = rc2.Substring(18, 2)

        rc3 = params(4).Value.ToString()
        a3txt.Text = rc3.Substring(0, 2)
        b3txt.Text = rc3.Substring(2, 2)
        c3txt.Text = rc3.Substring(4, 2)
        d3txt.Text = rc3.Substring(6, 2)
        e3txt.Text = rc3.Substring(8, 2)
        f3txt.Text = rc3.Substring(10, 2)
        g3txt.Text = rc3.Substring(12, 2)
        h3txt.Text = rc3.Substring(14, 2)
        i3txt.Text = rc3.Substring(16, 2)
        j3txt.Text = rc3.Substring(18, 2)

        rc4 = params(5).Value.ToString()
        a4txt.Text = rc4.Substring(0, 2)
        b4txt.Text = rc4.Substring(2, 2)
        c4txt.Text = rc4.Substring(4, 2)
        d4txt.Text = rc4.Substring(6, 2)
        e4txt.Text = rc4.Substring(8, 2)
        f4txt.Text = rc4.Substring(10, 2)
        g4txt.Text = rc4.Substring(12, 2)
        h4txt.Text = rc4.Substring(14, 2)
        i4txt.Text = rc4.Substring(16, 2)
        j4txt.Text = rc4.Substring(18, 2)

        rc5 = params(6).Value.ToString()
        a5txt.Text = rc5.Substring(0, 2)
        b5txt.Text = rc5.Substring(2, 2)
        c5txt.Text = rc5.Substring(4, 2)
        d5txt.Text = rc5.Substring(6, 2)
        e5txt.Text = rc5.Substring(8, 2)
        f5txt.Text = rc5.Substring(10, 2)
        g5txt.Text = rc5.Substring(12, 2)
        h5txt.Text = rc5.Substring(14, 2)
        i5txt.Text = rc5.Substring(16, 2)
        j5txt.Text = rc5.Substring(18, 2)

        rc6 = params(7).Value.ToString()
        a6txt.Text = rc6.Substring(0, 2)
        b6txt.Text = rc6.Substring(2, 2)
        c6txt.Text = rc6.Substring(4, 2)
        d6txt.Text = rc6.Substring(6, 2)
        e6txt.Text = rc6.Substring(8, 2)
        f6txt.Text = rc6.Substring(10, 2)
        g6txt.Text = rc6.Substring(12, 2)
        h6txt.Text = rc6.Substring(14, 2)
        i6txt.Text = rc6.Substring(16, 2)
        j6txt.Text = rc6.Substring(18, 2)

        rc7 = params(8).Value.ToString()
        a7txt.Text = rc7.Substring(0, 2)
        b7txt.Text = rc7.Substring(2, 2)
        c7txt.Text = rc7.Substring(4, 2)
        d7txt.Text = rc7.Substring(6, 2)
        e7txt.Text = rc7.Substring(8, 2)
        f7txt.Text = rc7.Substring(10, 2)
        g7txt.Text = rc7.Substring(12, 2)
        h7txt.Text = rc7.Substring(14, 2)
        i7txt.Text = rc7.Substring(16, 2)
        j7txt.Text = rc7.Substring(18, 2)

        rc8 = params(9).Value.ToString()
        a8txt.Text = rc8.Substring(0, 2)
        b8txt.Text = rc8.Substring(2, 2)
        c8txt.Text = rc8.Substring(4, 2)
        d8txt.Text = rc8.Substring(6, 2)
        e8txt.Text = rc8.Substring(8, 2)
        f8txt.Text = rc8.Substring(10, 2)
        g8txt.Text = rc8.Substring(12, 2)
        h8txt.Text = rc8.Substring(14, 2)
        i8txt.Text = rc8.Substring(16, 2)
        j8txt.Text = rc8.Substring(18, 2)

        rc9 = params(10).Value.ToString()
        a9txt.Text = rc9.Substring(0, 2)
        b9txt.Text = rc9.Substring(2, 2)
        c9txt.Text = rc9.Substring(4, 2)
        d9txt.Text = rc9.Substring(6, 2)
        e9txt.Text = rc9.Substring(8, 2)
        f9txt.Text = rc9.Substring(10, 2)
        g9txt.Text = rc9.Substring(12, 2)
        h9txt.Text = rc9.Substring(14, 2)
        i9txt.Text = rc9.Substring(16, 2)
        j9txt.Text = rc9.Substring(18, 2)


    End Sub

    Private Sub TextBox41_TextChanged(sender As Object, e As EventArgs) Handles f4txt.TextChanged

    End Sub

    Private Sub b5txt_TextChanged(sender As Object, e As EventArgs) Handles b5txt.TextChanged

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        seeTest.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub tarjetaCoordenadas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub tarjetaCoordenadas_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
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

        Dim params(12) As SqlParameter

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

        params(9) = New SqlParameter("@RC8", SqlDbType.Char, 20)
        params(9).Direction = ParameterDirection.Output

        params(10) = New SqlParameter("@RC9", SqlDbType.Char, 20)
        params(10).Direction = ParameterDirection.Output

        params(11) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(11).Direction = ParameterDirection.Output

        params(12) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(12).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SEECARD"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        MensajeLbl.Text = params(12).Value.ToString

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
        h1txt.Text = rc1.Substring(14, 2)
        i1txt.Text = rc1.Substring(16, 2)
        j1txt.Text = rc1.Substring(18, 2)

        rc2 = params(3).Value.ToString()
        a2txt.Text = rc2.Substring(0, 2)
        b2txt.Text = rc2.Substring(2, 2)
        c2txt.Text = rc2.Substring(4, 2)
        d2txt.Text = rc2.Substring(6, 2)
        e2txt.Text = rc2.Substring(8, 2)
        f2txt.Text = rc2.Substring(10, 2)
        g2txt.Text = rc2.Substring(12, 2)
        h2txt.Text = rc2.Substring(14, 2)
        i2txt.Text = rc2.Substring(16, 2)
        j2txt.Text = rc2.Substring(18, 2)

        rc3 = params(4).Value.ToString()
        a3txt.Text = rc3.Substring(0, 2)
        b3txt.Text = rc3.Substring(2, 2)
        c3txt.Text = rc3.Substring(4, 2)
        d3txt.Text = rc3.Substring(6, 2)
        e3txt.Text = rc3.Substring(8, 2)
        f3txt.Text = rc3.Substring(10, 2)
        g3txt.Text = rc3.Substring(12, 2)
        h3txt.Text = rc3.Substring(14, 2)
        i3txt.Text = rc3.Substring(16, 2)
        j3txt.Text = rc3.Substring(18, 2)

        rc4 = params(5).Value.ToString()
        a4txt.Text = rc4.Substring(0, 2)
        b4txt.Text = rc4.Substring(2, 2)
        c4txt.Text = rc4.Substring(4, 2)
        d4txt.Text = rc4.Substring(6, 2)
        e4txt.Text = rc4.Substring(8, 2)
        f4txt.Text = rc4.Substring(10, 2)
        g4txt.Text = rc4.Substring(12, 2)
        h4txt.Text = rc4.Substring(14, 2)
        i4txt.Text = rc4.Substring(16, 2)
        j4txt.Text = rc4.Substring(18, 2)

        rc5 = params(6).Value.ToString()
        a5txt.Text = rc5.Substring(0, 2)
        b5txt.Text = rc5.Substring(2, 2)
        c5txt.Text = rc5.Substring(4, 2)
        d5txt.Text = rc5.Substring(6, 2)
        e5txt.Text = rc5.Substring(8, 2)
        f5txt.Text = rc5.Substring(10, 2)
        g5txt.Text = rc5.Substring(12, 2)
        h5txt.Text = rc5.Substring(14, 2)
        i5txt.Text = rc5.Substring(16, 2)
        j5txt.Text = rc5.Substring(18, 2)

        rc6 = params(7).Value.ToString()
        a6txt.Text = rc6.Substring(0, 2)
        b6txt.Text = rc6.Substring(2, 2)
        c6txt.Text = rc6.Substring(4, 2)
        d6txt.Text = rc6.Substring(6, 2)
        e6txt.Text = rc6.Substring(8, 2)
        f6txt.Text = rc6.Substring(10, 2)
        g6txt.Text = rc6.Substring(12, 2)
        h6txt.Text = rc6.Substring(14, 2)
        i6txt.Text = rc6.Substring(16, 2)
        j6txt.Text = rc6.Substring(18, 2)

        rc7 = params(8).Value.ToString()
        a7txt.Text = rc7.Substring(0, 2)
        b7txt.Text = rc7.Substring(2, 2)
        c7txt.Text = rc7.Substring(4, 2)
        d7txt.Text = rc7.Substring(6, 2)
        e7txt.Text = rc7.Substring(8, 2)
        f7txt.Text = rc7.Substring(10, 2)
        g7txt.Text = rc7.Substring(12, 2)
        h7txt.Text = rc7.Substring(14, 2)
        i7txt.Text = rc7.Substring(16, 2)
        j7txt.Text = rc7.Substring(18, 2)

        rc8 = params(9).Value.ToString()
        a8txt.Text = rc8.Substring(0, 2)
        b8txt.Text = rc8.Substring(2, 2)
        c8txt.Text = rc8.Substring(4, 2)
        d8txt.Text = rc8.Substring(6, 2)
        e8txt.Text = rc8.Substring(8, 2)
        f8txt.Text = rc8.Substring(10, 2)
        g8txt.Text = rc8.Substring(12, 2)
        h8txt.Text = rc8.Substring(14, 2)
        i8txt.Text = rc8.Substring(16, 2)
        j8txt.Text = rc8.Substring(18, 2)

        rc9 = params(10).Value.ToString()
        a9txt.Text = rc9.Substring(0, 2)
        b9txt.Text = rc9.Substring(2, 2)
        c9txt.Text = rc9.Substring(4, 2)
        d9txt.Text = rc9.Substring(6, 2)
        e9txt.Text = rc9.Substring(8, 2)
        f9txt.Text = rc9.Substring(10, 2)
        g9txt.Text = rc9.Substring(12, 2)
        h9txt.Text = rc9.Substring(14, 2)
        i9txt.Text = rc9.Substring(16, 2)
        j9txt.Text = rc9.Substring(18, 2)
    End Sub
End Class