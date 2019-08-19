Imports System.Data.SqlClient

Public Class activacionUsuarios

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If estadoCmb.SelectedIndex >= 0 Then

            If identificacionTxt.Text = "" Then

                mensajeLbl.Text = "Debe ingresar una identificacion"

            Else

                Dim conexion As String
                conexion = "Data Source=WILLIAN-PC\SQLEXPRESS;Initial Catalog=ENIGMA000;Integrated Security=True"
                Dim cn As New SqlConnection
                cn.ConnectionString = conexion

                Dim estado As String
                estado = estadoCmb.SelectedIndex

                Dim params(4) As SqlParameter

                params(0) = New SqlParameter("@NDI", SqlDbType.Char, 8)
                params(0).Value = identificacionTxt.Text

                params(1) = New SqlParameter("@AOI", SqlDbType.Char, 1500)
                params(1).Value = estado

                params(2) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
                'params(3).Value = ""
                params(2).Direction = ParameterDirection.Output

                params(3) = New SqlParameter("@OPT", SqlDbType.Char, 3)
                'params(4).Value = ""
                params(3).Direction = ParameterDirection.Output

                params(4) = New SqlParameter("@RST", SqlDbType.Char, 100)
                'params(5).Value = ""
                params(4).Direction = ParameterDirection.Output

                Dim command As New SqlCommand()
                Command.Connection = cn
                Command.CommandType = CommandType.StoredProcedure
                command.CommandText = "ACTIVATE"

                Command.Parameters.AddRange(params)

                cn.Open()

                Command.ExecuteReader()
                mensajeLbl.Text = params(4).Value.ToString


                If params(3).Value.ToString = "200" Then

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