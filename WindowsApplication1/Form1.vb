Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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
        params(0).Value = usuarioTxt.Text

        params(1) = New SqlParameter("@PWU", SqlDbType.Char, 30)
        params(1).Value = claveTxt.Text

        params(2) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        'params(2).Value = ""
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@NUN", SqlDbType.Char, 9)
        'params(3).Value = ""
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@SEQ", SqlDbType.Char, 4)
        'params(4).Value = ""
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@PSW", SqlDbType.Char, 30)
        'params(5).Value = ""
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@NAM", SqlDbType.Char, 60)
        'params(5).Value = ""
        params(6).Direction = ParameterDirection.Output

        params(7) = New SqlParameter("@NCE", SqlDbType.Char, 60)
        'params(5).Value = ""
        params(7).Direction = ParameterDirection.Output

        params(8) = New SqlParameter("@ARC", SqlDbType.Char, 80)
        'params(5).Value = ""
        params(8).Direction = ParameterDirection.Output

        params(9) = New SqlParameter("@AOI", SqlDbType.Char, 1)
        'params(5).Value = ""
        params(9).Direction = ParameterDirection.Output

        params(10) = New SqlParameter("@ACC", SqlDbType.Char, 1)
        'params(5).Value = ""
        params(10).Direction = ParameterDirection.Output

        params(11) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        'params(5).Value = ""
        params(11).Direction = ParameterDirection.Output

        params(12) = New SqlParameter("@RST", SqlDbType.Char, 100)
        'params(5).Value = ""
        params(12).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CHECKUSER"

        command.Parameters.AddRange(params)

        cn.Open()
        My.Application.DoEvents()
        command.CommandTimeout = 0
        command.ExecuteReader()
        mensajeLbl.Text = params(12).Value.ToString

        Dim obj As Object
        Dim archivo As Object

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./usuario.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuario.txt")
        End If

        If Dir("./nombre.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./nombre.txt")
        End If

        If Dir("./grupo.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./grupo.txt")
        End If

        If Dir("./clave.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./clave.txt")
        End If

        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        cn.Close()



        If params(11).Value.ToString = "014" Or params(11).Value.ToString = "013" Or params(11).Value.ToString = "015" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuario.txt")
            archivo.WriteLine(usuarioTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./clave.txt")
            archivo.Write(params(5).Value.ToString())
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupo.txt")
            archivo.WriteLine(params(2).Value.ToString())
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./nombre.txt")
            archivo.WriteLine(params(6).Value.ToString())
            archivo.close()

            usuarioTxt.Text = ""
            claveTxt.Text = ""

            mensajeLbl.Text = ""

            Me.Hide()
            cambiarClave.Show()

        ElseIf params(11).Value.ToString = "018" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuario.txt")
            archivo.WriteLine(usuarioTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./clave.txt")
            archivo.Write(claveTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupo.txt")
            archivo.WriteLine(params(2).Value.ToString())
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./nombre.txt")
            archivo.WriteLine(params(6).Value.ToString())
            archivo.close()

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuUsuario.Show()

        ElseIf params(11).Value.ToString = "019" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuario.txt")
            archivo.WriteLine(usuarioTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./clave.txt")
            archivo.Write(claveTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupo.txt")
            archivo.WriteLine(params(2).Value.ToString())
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./nombre.txt")
            archivo.WriteLine(params(6).Value.ToString())
            archivo.close()

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuSuperUsuario.Show()
            'menuUsuario.Show()


        ElseIf params(11).Value.ToString = "020" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuario.txt")
            archivo.WriteLine(usuarioTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./clave.txt")
            archivo.Write(claveTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupo.txt")
            archivo.WriteLine(params(2).Value.ToString())
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./nombre.txt")
            archivo.WriteLine(params(6).Value.ToString())
            archivo.close()

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuAdministrador.Show()

        End If

        Console.WriteLine("OPT " + params(11).Value.ToString)


    End Sub


    Private Sub Form1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim texto As String
            If Dir("./respuesta.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./respuesta.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                mensajeLbl.Text = texto
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir("./usuario.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuario.txt")
        End If
        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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


End Class
