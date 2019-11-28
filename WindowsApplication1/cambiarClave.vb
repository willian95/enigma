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

        'params(1) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
        'params(1).Value = nombreTxt.Text

        params(1) = New SqlParameter("@PSW", SqlDbType.Char, 1500)

        If claveTxt.Text = "" Then
            'Dim claveValueNull = DBNull.Value
            params(1).Value = DBNull.Value
        Else
            params(1).Value = claveTxt.Text
        End If

        Console.WriteLine(claveTxt.Text + " clave")

        params(2) = New SqlParameter("@NEW", SqlDbType.Char, 1500)
        params(2).Value = nuevaClaveTxt.Text

        params(3) = New SqlParameter("@REP", SqlDbType.Char, 1500)
        params(3).Value = repetirClaveTxt.Text

        params(4) = New SqlParameter("@OPT", SqlDbType.Char, 3)
        params(4).Direction = ParameterDirection.Output

        params(5) = New SqlParameter("@RST", SqlDbType.Char, 80)
        params(5).Direction = ParameterDirection.Output

        params(6) = New SqlParameter("@NAM", SqlDbType.Char, 1500)
        params(6).Direction = ParameterDirection.Output

        Dim command As New SqlCommand()
        command.Connection = cn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CHGPASSWORD"

        command.Parameters.AddRange(params)

        cn.Open()

        command.ExecuteReader()
        mensajeLbl.Text = params(6).Value.ToString

        If params(4).Value.ToString = "300" Then

            Dim obj As Object
            Dim archivo As Object

            obj = CreateObject("Scripting.FileSystemObject")
            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            archivo = obj.CreateTextFile("./respuesta.txt", True, True)
            archivo.WriteLine(params(5).Value.ToString)
            archivo.close()

            identificacionTxt.Text = ""
            claveTxt.Text = ""
            nuevaClaveTxt.Text = ""
            repetirClaveTxt.Text = ""
            mensajeLbl.Text = ""

            Me.Hide()
            Form1.Show()

        End If

        Console.WriteLine(params(0).Value.ToString + " 0")
        Console.WriteLine(params(1).Value.ToString + " 1")
        Console.WriteLine(params(2).Value.ToString + " 2")
        Console.WriteLine(params(3).Value.ToString + " 3")
        Console.WriteLine(params(4).Value.ToString + " 4")
        Console.WriteLine(params(5).Value.ToString + " 5")
        Console.WriteLine(params(6).Value.ToString + " 6")

        cn.Close()

    End Sub

    Private Sub cambiarClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim texto As String

        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            identificacionTxt.Text = texto
            Console.WriteLine(texto)
        End If
        If Dir("./clave.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./clave.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            If texto <> "" Then
                claveTxt.Text = texto
                Console.WriteLine(texto)
            End If
        End If
    End Sub

    Private Sub cambiarClave_StyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.StyleChanged
        Dim texto As String

        If Dir("./respuesta.txt") <> "" Then
            My.Computer.FileSystem.DeleteFile("./respuesta.txt")
        End If

        If Dir("./usuario.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            identificacionTxt.Text = texto
            Console.WriteLine(texto)
        End If
        If Dir("./clave.txt") <> "" Then
            texto = My.Computer.FileSystem.ReadAllText("./clave.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
            If texto <> "" Then
                claveTxt.Text = texto
                Console.WriteLine(texto)
            End If
        End If
    End Sub

    Private Sub cambiarClave_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim texto As String

            If Dir("./respuesta.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("./respuesta.txt")
            End If

            If Dir("./usuario.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./usuario.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                identificacionTxt.Text = texto
                Console.WriteLine(texto)
            End If
            If Dir("./clave.txt") <> "" Then
                texto = My.Computer.FileSystem.ReadAllText("./clave.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
                If texto <> "" Then
                    claveTxt.Text = texto
                    Console.WriteLine(texto)
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nuevaClaveTxt.Text = ""
        repetirClaveTxt.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cambiarClave_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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