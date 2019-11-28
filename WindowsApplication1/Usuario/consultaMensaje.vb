Imports System.Data.SqlClient
Imports System.IO

Public Class consultaMensaje

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles table.CellContentClick

    End Sub

    Private Sub consultaMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim identificador As String
        Dim grupo As String

        table.Rows.Clear()

        If Dir("./usuario.txt") <> "" Then
            identificador = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        End If

        If Dir("./grupo.txt") <> "" Then
            grupo = My.Computer.FileSystem.ReadAllText("./grupo.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
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

        params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        params(0).Value = grupo

        params(1) = New SqlParameter("@DST", SqlDbType.Char, 8)
        params(1).Value = identificador

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
        Console.WriteLine(texto)
        textArre = texto.Split("*")

        Console.WriteLine(textArre)

        'Recorre String array
        'For i = 0 To textArre.Length - 1

        'row = New String() {textArre(i).Substring(0, 8), textArre(i).Substring(8, textArre(i).Length - 19), textArre(i).Substring(textArre(i).Length - 11)}
        'table.Rows.Add(row)

        'Next i



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

            If Dir("./grupo.txt") <> "" Then
                grupo = My.Computer.FileSystem.ReadAllText("./grupo.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
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

            params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
            params(0).Value = grupo

            params(1) = New SqlParameter("@DST", SqlDbType.Char, 8)
            params(1).Value = identificador

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
            For i = 0 To textArre.Length - 1

                Console.WriteLine(textArre(i) + " " + i.ToString())

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
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If
        If Dir("./clave.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./clave.txt")
        End If
        If Dir("./grupo.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./grupo.txt")
        End If
    End Sub
End Class