Imports System.Data.SqlClient

Public Class cambiarClave

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim conexion As String
        Dim conexionTxt As String
        Dim conectar As conectionTxt
        conectar = New conectionTxt

        conexionTxt = conectar.readTxt()
        conexion = conexionTxt

        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim params(6) As SqlParameter

        params(0) = New SqlParameter("@NDI", SqlDbType.Char, 8)
        params(0).Value = identificacionTxt.Text

        params(1) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
        params(1).Value = nombreTxt.Text

        params(2) = New SqlParameter("@PSW", SqlDbType.Char, 1500)
        params(2).Value = claveTxt.Text

        params(3) = New SqlParameter("@NEW", SqlDbType.Char, 1500)
        params(3).Value = nuevaClaveTxt.Text

        params(4) = New SqlParameter("@REP", SqlDbType.Char, 1500)
        params(4).Value = repetirClaveTxt.Text

        params(5) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@RST", SqlDbType.Char, 80)
        params(6).Direction = ParameterDirection.Output



        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CHGPASSWORD"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(6).Value.ToString

        If params(5).Value.ToString = "300" Then

            Me.Hide()
            Form1.Show()

        End If


        Console.WriteLine(params(6).Value.ToString + " 6")
        Console.WriteLine(params(5).Value.ToString + " 5")

        cn.Close()

    End Sub
End Class