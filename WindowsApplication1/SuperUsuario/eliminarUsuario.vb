Imports System.Data.SqlClient

Public Class eliminarUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        conexion = "Data Source=WILLIAN-PC\SQLEXPRESS;Initial Catalog=ENIGMA000;Integrated Security=True"
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

        If params(3).Value.ToString = "500" Then

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()

    End Sub
End Class