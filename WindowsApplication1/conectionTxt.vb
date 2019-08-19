Public Class conectionTxt

    Function readTxt() As String

        Dim textoConexion As String
        textoConexion = My.Computer.FileSystem.ReadAllText("./conexion.txt") 'System.AppDomain.CurrentDomain.BaseDirectory
        Return textoConexion

    End Function

End Class
