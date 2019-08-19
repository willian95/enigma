Imports System.Data.SqlClient


Public Class registroUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        conexion = "Data Source=WILLIAN-PC\SQLEXPRESS;Initial Catalog=ENIGMA000;Integrated Security=True"
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

        Console.WriteLine(params(4).Value.ToString)

        If params(3).Value.ToString = "100" Then

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()



    End Sub
End Class