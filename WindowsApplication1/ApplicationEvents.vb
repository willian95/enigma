Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_ShutDown(
            ByVal sender As Object,
            ByVal e As System.EventArgs
        ) Handles Me.Shutdown
            'My.Application.Log.WriteEntry("My Application Shutdown")
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



End Namespace

