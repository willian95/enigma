Imports System.Data.SqlClient

Public Class nombreGrupo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If grupoCmb.SelectedIndex >= 0 Then

            Dim conexion As String
            Dim conexionTxt As String
            Dim conectar As conectionTxt
            conectar = New conectionTxt

            conexionTxt = conectar.readTxt()
            conexion = conexionTxt
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim grupo As String
            grupo = grupoCmb.SelectedIndex

            Dim params(3) As SqlParameter

            params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
            params(0).Value = grupo

            params(1) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
            params(1).Value = nombreTxt.Text

            params(2) = New SqlParameter("@OPT", SqlDbType.Char, 3)
            params(2).Direction = ParameterDirection.Output

            params(3) = New SqlParameter("@RST", SqlDbType.Char, 100)
            params(3).Direction = ParameterDirection.Output


            Dim command As New SqlCommand()
            command.Connection = cn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "CHGGROUP"

            command.Parameters.AddRange(params)

            cn.Open()

            command.ExecuteReader()
            mensajeLbl.Text = params(3).Value.ToString

            If params(2).Value.ToString = "400" Then

                Dim obj As Object
                Dim archivo As Object

                obj = CreateObject("Scripting.FileSystemObject")
                If Dir("./respuesta.txt") <> "" Then
                    My.Computer.FileSystem.DeleteFile("./respuesta.txt")
                End If

                archivo = obj.CreateTextFile("./respuesta.txt", True, True)
                archivo.WriteLine(params(3).Value.ToString)
                archivo.close()

                nombreTxt.Text = ""
                mensajeLbl.Text = ""
                grupoCmb.SelectedIndex = 0

                Me.Hide()
                Form1.Show()

            End If

            cn.Close()

        Else

            mensajeLbl.Text = "Debe seleccionar un grupo"

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        nombreTxt.Text = ""
        grupoCmb.SelectedIndex = 0

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub nombreGrupo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub loadName(index)

        Dim conexion As String
        Dim conexionTxt As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(3) As SqlParameter

        params(0) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        params(0).Value = index

        params(1) = New SqlParameter("@NAM", SqlDbType.Char, 60)
        params(1).Direction = ParameterDirection.Output

        params(2) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(2).Direction = ParameterDirection.Output

        params(3) = New SqlParameter("@RST", SqlDbType.Char, 100)
        params(3).Direction = ParameterDirection.Output


        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SELECTGROUP"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        nombreTxt.Text = params(1).Value().ToString()

        cn.Close()



    End Sub


    Private Sub grupoCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grupoCmb.SelectedIndexChanged

        Dim valor As String
        valor = grupoCmb.SelectedIndex

        loadName(valor)



    End Sub

End Class