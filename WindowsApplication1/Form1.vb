Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        conexion = "Data Source=WILLIAN-PC\SQLEXPRESS;Initial Catalog=ENIGMA000;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

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

        command.ExecuteReader()
        mensajeLbl.Text = params(5).Value.ToString


        If params(4).Value.ToString = "014" Or params(4).Value.ToString = "013" Or params(4).Value.ToString = "012" Then

            Me.Hide()
            cambiarClave.Show()

        End If

        Console.WriteLine(params(5).Value.ToString + " 5")
        Console.WriteLine(params(4).Value.ToString + " 4")

        cn.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        menuAdministrador.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        menuSuperUsuario.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        menuUsuario.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim conexionTxt As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()

        Console.WriteLine(conexionTxt)

    End Sub
End Class
