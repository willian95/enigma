Imports System.Data.SqlClient

Public Class codificacionMensaje

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        conexion = "Data Source=WILLIAN-PC\SQLEXPRESS;Initial Catalog=ENIGMA000;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(6) As SqlParameter

        params(0) = New SqlParameter("@EMI", SqlDbType.Char, 8)
        params(0).Value = emisorTxt.Text

        params(1) = New SqlParameter("@DST", SqlDbType.Char, 8)
        params(1).Value = destinatarioTxt.Text

        params(2) = New SqlParameter("@TEX", SqlDbType.Char, 7500)
        params(2).Value = mensajeTxt.Text

        params(3) = New SqlParameter("@GRP", SqlDbType.Char, 1)
        'params(3).Value = ""
        params(3).Direction = ParameterDirection.Output

        params(4) = New SqlParameter("@NRO", SqlDbType.Char, 8)
        'params(4).Value = ""
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        'params(5).Value = ""
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@RST", SqlDbType.Char, 100)
        'params(5).Value = ""
        params(6).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "ENCODE"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(6).Value.ToString


        If params(5).Value.ToString = "600" Then

            Me.Hide()
            Form1.Show()

        End If

        cn.Close()

    End Sub
End Class