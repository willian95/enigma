Imports System.Data.SqlClient

Public Class nombreGrupo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If grupoCmb.SelectedIndex >= 0 Then

            If nombreTxt.Text = "" Then

                mensajeLbl.Text = "Debe ingresar un nombre"

            Else

                Dim conexion As String
                Dim conexionTxt As String
                Dim conectar As conectionTxt
                conectar = New conectionTxt

                conexionTxt = conectar.readTxt()
                conexion = conexionTxt
                Dim cn As New SqlConnection
                cn.ConnectionString = conexion

                Dim grupo As String
                grupo = grupoCmb.SelectedIndex + 1

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

                Console.WriteLine(params(3).Value.ToString)

                If params(2).Value.ToString = "400" Then

                    Me.Hide()
                    Form1.Show()

                End If

                cn.Close()

            End If

        Else

            mensajeLbl.Text = "Debe seleccionar un grupo"

        End If

    End Sub
End Class