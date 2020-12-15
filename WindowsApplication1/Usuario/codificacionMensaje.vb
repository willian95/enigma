Imports System.Data.SqlClient

Public Class codificacionMensaje

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(5) As SqlParameter

        params(0) = New SqlParameter("@EMI", SqlDbType.Char, 9)
        params(0).Value = emisorTxt.Text

        params(1) = New SqlParameter("@DST", SqlDbType.Char, 9)
        params(1).Value = destinatarioTxt.Text

        params(2) = New SqlParameter("@TEX", SqlDbType.Char, 7500)
        params(2).Value = mensajeTxt.Text

        params(3) = New SqlParameter("@NRO", SqlDbType.Char, 9)
        'params(4).Value = ""
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        'params(5).Value = ""
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@RST", SqlDbType.Char, 100)
        'params(5).Value = ""
        params(5).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "ENCODE"

        command.Parameters.AddRange(params)
        My.Application.DoEvents()
        cn.Open()

        command.CommandTimeout = 0
        command.ExecuteReader()
        mensajeLbl.Text = params(5).Value.ToString

        If params(4).Value.ToString = "600" Then

            Dim obj As Object
            Dim archivo As Object

            My.Application.DoEvents()
            obj = CreateObject("Scripting.FileSystemObject")
            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            archivo = obj.CreateTextFile("./respuesta.txt", True, True)
            archivo.WriteLine(params(5).Value.ToString)
            archivo.close()

            emisorTxt.Text = ""
            destinatarioTxt.Text = ""
            mensajeTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()
    End Sub

    Private Sub codificacionMensaje_StyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.StyleChanged
        If Me.Visible Then
            Dim texto As String
            If Dir("./usuario.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                'Console.WriteLine(texto)
                emisorTxt.Text = texto
            End If
        End If
    End Sub

    Private Sub codificacionMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim texto As String
        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            'Console.WriteLine(texto)
            emisorTxt.Text = texto
        End If
    End Sub

    Private Sub codificacionMensaje_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim texto As String
            If Dir("./usuario.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                'Console.WriteLine(texto)
                emisorTxt.Text = texto
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        mensajeTxt.Text = ""
        destinatarioTxt.Text = ""

        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub codificacionMensaje_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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