Imports System.Data.SqlClient

Public Class modificaUsuario
    Private Sub modificaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim identificacion As String
        Dim nombre As String
        Dim correo As String
        Dim repetir As String
        Dim archivo As String
        Dim acceso As String

        If Dir("./usuarioSeleccionado.txt") <> "" Then
            identificacion = My.Computer.FileSystem.ReadAllText("./usuarioSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            identificacionTxt.Text = identificacion
        End If

        If Dir("./nombreSeleccionado.txt") <> "" Then
            nombre = My.Computer.FileSystem.ReadAllText("./nombreSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            nombreTxt.Text = nombre
        End If

        If Dir("./correoSeleccionado.txt") <> "" Then
            correo = My.Computer.FileSystem.ReadAllText("./correoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            correoTxt.Text = correo
            repetirTxt.Text = correo
        End If

        If Dir("./archivoSeleccionado.txt") <> "" Then
            archivo = My.Computer.FileSystem.ReadAllText("./archivoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            archivoTxt.Text = archivo
        End If

        If Dir("./accesoSeleccionado.txt") <> "" Then
            acceso = My.Computer.FileSystem.ReadAllText("./accesoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory

            If acceso.ToString.Trim() = "W" Then
                accesoCmb.SelectedIndex = 0
            End If
            If acceso.ToString.Trim() = "R" Then
                accesoCmb.SelectedIndex = 1
            End If
            If acceso.ToString.Trim() = "B" Then
                Console.WriteLine("Entre")
                accesoCmb.SelectedIndex = 2
            End If
        End If






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim grupo As String
        If Dir("./grupoSeleccionado.txt") <> "" Then
            grupo = My.Computer.FileSystem.ReadAllText("./grupoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        End If

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
        command.CommandText = "MODIFYUSER"

        command.Parameters.AddRange(params)

        My.Application.DoEvents()
        cn.Open()

        command.CommandTimeout = 0
        command.ExecuteReader()
        mensajeLbl.Text = params(8).Value.ToString

        cn.Close()

        If params(7).Value.ToString = "180" Then

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
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""
        nombreTxt.Text = ""
        correoTxt.Text = ""
        repetirTxt.Text = ""
        archivoTxt.Text = ""
        mensajeLbl.Text = ""

        Me.Hide()
        seleccionarUsuario.Show()
    End Sub

    Private Sub modificaUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub modificaUsuario_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim identificacion As String
            Dim nombre As String
            Dim correo As String
            Dim repetir As String
            Dim archivo As String
            Dim acceso As String

            If Dir("./usuarioSeleccionado.txt") <> "" Then
                identificacion = My.Computer.FileSystem.ReadAllText("./usuarioSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                identificacionTxt.Text = identificacion
            End If

            If Dir("./nombreSeleccionado.txt") <> "" Then
                nombre = My.Computer.FileSystem.ReadAllText("./nombreSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                nombreTxt.Text = nombre
            End If

            If Dir("./correoSeleccionado.txt") <> "" Then
                correo = My.Computer.FileSystem.ReadAllText("./correoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                correoTxt.Text = correo
                repetirTxt.Text = correo
            End If

            If Dir("./archivoSeleccionado.txt") <> "" Then
                archivo = My.Computer.FileSystem.ReadAllText("./archivoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                archivoTxt.Text = archivo
            End If

            If Dir("./accesoSeleccionado.txt") <> "" Then
                acceso = My.Computer.FileSystem.ReadAllText("./accesoSeleccionado.txt") 'System.AppDomain.CurrentDomain.BaseDirectory

                If acceso.ToString.Trim() = "W" Then
                    accesoCmb.SelectedIndex = 0
                End If
                If acceso.ToString.Trim() = "R" Then
                    accesoCmb.SelectedIndex = 1
                End If
                If acceso.ToString.Trim() = "B" Then
                    Console.WriteLine("Entre")
                    accesoCmb.SelectedIndex = 2
                End If
            End If
        End If
    End Sub


End Class