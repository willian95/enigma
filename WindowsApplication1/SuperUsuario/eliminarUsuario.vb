Imports System.Data.SqlClient

Public Class eliminarUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        Dim conectar As conectionTxt
        Dim conexionTxt As String
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(3) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 8)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(3).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "DELETEUSER"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(3).Value.ToString

        If params(2).Value.ToString = "500" Then

            Dim obj As Object
            Dim archivo As Object

            obj = CreateObject("Scripting.FileSystemObject")
            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            archivo = obj.CreateTextFile("./respuesta.txt", True, True)
            archivo.WriteLine(params(3).Value.ToString)
            archivo.close()

            identificacionTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()

    End Sub

    Private Sub eliminarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        identificacionTxt.Text = ""

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub eliminarUsuario_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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