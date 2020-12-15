Imports System.Data.SqlClient
Imports System.IO

Public Class consultaMensaje

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub consultaMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim identificador As String
        Dim grupo As String

        table.Rows.Clear()

        If Dir("./usuario.txt") <> "" Then
            identificador = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        End If

        destinatarioTxt.Text = identificador

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt
        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(4) As SqlParameter

        params(0) = New SqlParameter("@DST", SqlDbType.Char, 9)
        params(0).Value = identificador

        params(1) = New SqlParameter("@USU", SqlDbType.Char, 9)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@NEF", SqlDbType.Char, 1000)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(4).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "FINDMESSAGE"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        MensajeLbl.Text = params(4).Value.ToString

        cn.Close()

        Dim texto As String
        Dim nuevoTexto As String
        Dim textArre() As String
        Dim i As Integer
        Dim row As String()
        texto = params(2).Value.ToString
        textArre = texto.Split("*")

        Dim counter = 0
        Dim emisor = ""
        Dim numero = ""
        Dim fecha = ""

        For i = 0 To textArre.Length - 1

            If counter = 0 Then

                numero = textArre(i)

            End If

            If counter = 1 Then

                emisor = textArre(i)

            End If

            If counter = 2 Then

                fecha = textArre(i)
                row = New String() {numero, emisor, fecha}
                table.Rows.Add(row)

                'Console.WriteLine(row)

            End If

            counter = counter + 1

            If counter = 3 Then
                counter = 0
            End If

        Next i


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub consultaMensaje_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then

            table.Rows.Clear()

            Dim identificador As String
            Dim grupo As String

            If Dir("./usuario.txt") <> "" Then
                identificador = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            End If

            Dim conexion As String
            Dim conectar As conectionTxt
            Dim conexionTxt As String
            conectar = New conectionTxt
            conexionTxt = conectar.readTxt()
            conexion = conexionTxt
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim params(4) As SqlParameter

            params(0) = New SqlParameter("@DST", SqlDbType.Char, 9)
            params(0).Value = identificador

            params(1) = New SqlParameter("@USU", SqlDbType.Char, 9)
            params(1).Direction = ParameterDirection.Output

            params(2) = New SqlParameter("@NEF", SqlDbType.Char, 1000)
            params(2).Direction = ParameterDirection.Output

            params(3) = New SqlParameter("@OPT", SqlDbType.Char, 3)
            params(3).Direction = ParameterDirection.Output

            params(4) = New SqlParameter("@RST", SqlDbType.Char, 100)
            params(4).Direction = ParameterDirection.Output

            Dim command As New SqlCommand()
            command.Connection = cn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "FINDMESSAGE"

            command.Parameters.AddRange(params)

            cn.Open()

            command.ExecuteReader()
            MensajeLbl.Text = params(4).Value.ToString

            cn.Close()

            Dim texto As String
            Dim nuevoTexto As String
            Dim textArre() As String
            Dim i As Integer
            Dim row As String()
            texto = params(2).Value.ToString

            'MensajeLbl.Text = annio.ToString

            textArre = texto.Split("*")

            'Recorre String array
            Dim counter = 0
            Dim emisor = ""
            Dim numero = ""
            Dim fecha = ""

            table.ColumnCount = 3
            table.Columns(0).Name = "Product ID"
            table.Columns(1).Name = "Product Name"
            table.Columns(2).Name = "Product_Price"


            For i = 0 To textArre.Length - 1

                If counter = 0 Then

                    numero = textArre(i)

                End If

                If counter = 1 Then

                    emisor = textArre(i)

                End If

                If counter = 2 Then

                    fecha = textArre(i)
                    row = New String() {numero, emisor, fecha}


                    'Dim row As String() = New String() {"1", "Product 1", "1000"}
                    table.Rows.Add(row)

                End If

                counter = counter + 1

                If counter = 3 Then
                    counter = 0
                End If

            Next i

        End If
    End Sub

    Private Sub consultaMensaje_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MensajeLbl_Click(sender As Object, e As EventArgs) Handles MensajeLbl.Click

    End Sub

    Private Sub MyPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MyPanel1.Paint

    End Sub
End Class