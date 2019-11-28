Imports System.Data.SqlClient
Imports System.IO


Public Class registroUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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

        Dim params(4) As SqlParameter

        params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        params(0).Value = grupo

        params(1) = New SqlParameter("@NDI", SqlDbType.Char, 8)
        params(1).Value = identificacionTxt.Text

        params(2) = New SqlParameter("@NAM", SqlDbType.VarChar, 7980)
        params(2).Value = nombreTxt.Text

        params(3) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(4).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "INSERTUSER"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(4).Value.ToString

        Console.WriteLine(params(0).Value.ToString + " 0")
        Console.WriteLine(params(1).Value.ToString + " 1")
        Console.WriteLine(params(2).Value.ToString + " 2")
        Console.WriteLine(params(3).Value.ToString + " 3")
        Console.WriteLine(params(4).Value.ToString + " 4")

        If params(3).Value.ToString = "100" Then

            Dim obj As Object
            Dim archivo As Object

            obj = CreateObject("Scripting.FileSystemObject")
            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            archivo = obj.CreateTextFile("./respuesta.txt", True, True)
            archivo.WriteLine(params(4).Value.ToString)
            archivo.close()

            identificacionTxt.Text = ""
            nombreTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""
        nombreTxt.Text = ""

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub registroUsuario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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