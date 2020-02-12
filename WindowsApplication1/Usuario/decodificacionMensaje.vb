Imports System.Data.SqlClient

Public Class decodificacionMensaje

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

        params(0) = New SqlParameter("@EMI", SqlDbType.Char, 8)
        params(0).Value = emisorTxt.Text

        params(1) = New SqlParameter("@DST", SqlDbType.Char, 8)
        params(1).Value = destinatarioTxt.Text

        params(2) = New SqlParameter("@NRO", SqlDbType.Char, 8)
        params(2).Value = numeroMensajeTxt.Text

        params(3) = New SqlParameter("@TEX", SqlDbType.Char, 7500)
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
        command.CommandText = "DECODE"

        command.Parameters.AddRange(params)
        My.Application.DoEvents()
        cn.Open()
        command.CommandTimeout = 0
        Console.WriteLine(params(0).Value.ToString + " 0")
        Console.WriteLine(params(1).Value.ToString + " 1")
        Console.WriteLine(params(2).Value.ToString + " 2")

        command.ExecuteReader()
        mensajeLbl.Text = params(5).Value.ToString

        Console.WriteLine(params(3).Value.ToString + " 3")
        mensajeTxt.Text = params(3).Value.ToString


        'If params(5).Value.ToString = "600" Then

        'Me.Hide()
        'Form1.Show()

        'End If

        cn.Close()
    End Sub

    Private Sub decodificacionMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mensajeTxt.Text = ""
        numeroMensajeTxt.Text = ""
        destinatarioTxt.Text = ""
        emisorTxt.Text = ""
        numeroMensajeTxt.Text = ""

        Dim texto As String
        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            'Console.WriteLine(texto)
            destinatarioTxt.Text = texto
        End If
    End Sub

    Private Sub decodificacionMensaje_StyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.StyleChanged
        If Me.Visible Then
            Dim texto As String
            If Dir("./usuario.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                'Console.WriteLine(texto)
                destinatarioTxt.Text = texto
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        emisorTxt.Text = ""
        numeroMensajeTxt.Text = ""
        mensajeTxt.Text = ""

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub decodificacionMensaje_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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