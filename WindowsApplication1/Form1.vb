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

        Console.WriteLine(claveTxt.Text)

        Dim params(5) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 8)
        params(0).Value = usuarioTxt.Text

        params(1) = New SqlParameter("@PWU", SqlDbType.Char, 1500)
        params(1).Value = claveTxt.Text

        params(2) = New SqlParameter("@GDU", SqlDbType.Char, 1)
        'params(2).Value = ""
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
        'params(3).Value = ""
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        'params(4).Value = ""
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@RST", SqlDbType.Char, 100)
        'params(5).Value = ""
        params(5).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CHECKUSER"

        command.Parameters.AddRange(params)

        cn.Open()
        My.Application.DoEvents()
        command.CommandTimeout = 0
        command.ExecuteReader()
        mensajeLbl.Text = params(5).Value.ToString

        Dim obj As Object
        Dim archivo As Object

        obj = CreateObject("Scripting.FileSystemObject")
        If Dir("./usuario.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./usuario.txt")
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

        If params(4).Value.ToString = "014" Or params(4).Value.ToString = "013" Or params(4).Value.ToString = "012" Then

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./usuario.txt")
            archivo.WriteLine(usuarioTxt.Text)
            archivo.close()

            My.Application.DoEvents()
            archivo = obj.CreateTextFile("./grupo.txt")
            archivo.WriteLine(params(2).Value.ToString())
            archivo.close()

            usuarioTxt.Text = ""
            claveTxt.Text = ""

            mensajeLbl.Text = ""

            Me.Hide()
            cambiarClave.Show()

        ElseIf params(4).Value.ToString = "018" Then

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

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuUsuario.Show()

        ElseIf params(4).Value.ToString = "019" Then

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

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuSuperUsuario.Show()

        ElseIf params(4).Value.ToString = "020" Then

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

            usuarioTxt.Text = ""
            claveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            menuAdministrador.Show()

        End If

        Console.WriteLine(params(5).Value.ToString + " 5")
        Console.WriteLine(params(4).Value.ToString + " 4")

        cn.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        menuAdministrador.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        menuSuperUsuario.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        menuUsuario.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim conexionTxt As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()

        Console.WriteLine(conexionTxt)

    End Sub

    Private Sub Form1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim texto As String
            If Dir("./respuesta.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./respuesta.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                Console.WriteLine(texto)
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

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
