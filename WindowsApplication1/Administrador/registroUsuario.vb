Imports System.Data.SqlClient
Imports System.IO


Public Class registroUsuario



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""
        nombreTxt.Text = ""
        correoTxt.Text = ""
        repetirTxt.Text = ""
        archivoTxt.Text = ""
        accesoCmb.SelectedIndex = 0
        mensajeLbl.Text = ""

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub registroUsuario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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


    Private Sub MyPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MyPanel1.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click



        If grupoCmb.SelectedIndex + 1 = 0 Or identificacionTxt.Text = "" Or nombreTxt.Text = "" Or correoTxt.Text = "" Or repetirTxt.Text = "" Or archivoTxt.Text = "" Or accesoCmb.SelectedIndex + 1 = 0 Then

            mensajeLbl.Text = "Todos los campos son obligatorios"


        Else

            Dim conexion As String
            Dim conectar As conectionTxt
            Dim conexionTxt As String
            conectar = New conectionTxt

            conexionTxt = conectar.readTxt()
            conexion = conexionTxt
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim grupo As String
            grupo = grupoCmb.SelectedIndex + 1

            Dim acceso As String

            If accesoCmb.SelectedIndex + 1 = 1 Then
                acceso = "W"
            ElseIf accesoCmb.SelectedIndex + 1 = 2 Then
                acceso = "R"
            ElseIf accesoCmb.SelectedIndex + 1 = 3 Then
                acceso = "B"
            End If

            Dim params(8) As SqlParameter

            params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
            params(0).Value = grupo

            params(1) = New SqlParameter("@NDI", SqlDbType.Char, 9)
            params(1).Value = identificacionTxt.Text

            params(2) = New SqlParameter("@NAM", SqlDbType.VarChar, 60)
            params(2).Value = nombreTxt.Text

            params(3) = New SqlParameter("@NCE", SqlDbType.VarChar, 60)
            params(3).Value = correoTxt.Text

            params(4) = New SqlParameter("@RCE", SqlDbType.VarChar, 60)
            params(4).Value = repetirTxt.Text

            params(5) = New SqlParameter("@ARC", SqlDbType.VarChar, 80)
            params(5).Value = archivoTxt.Text

            params(6) = New SqlParameter("@ACC", SqlDbType.VarChar, 1)
            params(6).Value = acceso

            params(7) = New SqlParameter("@OPT", SqlDbType.Char, 3)
            params(7).Direction = ParameterDirection.Output

            params(8) = New SqlParameter("@RST", SqlDbType.Char, 100)
            params(8).Direction = ParameterDirection.Output

            Dim command As New SqlCommand()
            command.Connection = cn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "INSERTUSER"

            command.Parameters.AddRange(params)

            My.Application.DoEvents()
            cn.Open()

            command.CommandTimeout = 0
            command.ExecuteReader()
            mensajeLbl.Text = params(8).Value.ToString

            Console.WriteLine(params(6).Value.ToString)

            cn.Close()

            If params(7).Value.ToString = "100" Then

                Dim obj As Object
                Dim archivo As Object

                My.Application.DoEvents()
                obj = CreateObject("Scripting.FileSystemObject")
                If Dir("./respuesta.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./respuesta.txt")
                End If

                archivo = obj.CreateTextFile("./respuesta.txt", True, True)
                archivo.WriteLine(params(8).Value.ToString)
                archivo.close()

                identificacionTxt.Text = ""
                nombreTxt.Text = ""
                correoTxt.Text = ""
                repetirTxt.Text = ""
                archivoTxt.Text = ""
                accesoCmb.SelectedIndex = 0
                mensajeLbl.Text = ""

                Me.Hide()
                Form1.Show()

            End If

        End If

    End Sub

    Private Sub registroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class