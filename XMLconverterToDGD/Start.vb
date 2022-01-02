Imports System.Xml
Imports System.Text

Module Start
    Public oUstawienia As New Ustawienia()
    Public ia As New interactive
    Dim conString As String = $"Server={oUstawienia.sqlServer};Database={oUstawienia.sqldb};User Id={oUstawienia.sqlUserId};Password={oUstawienia.sqlPasswd}"

    Sub Main()
        Try
            'Tworzenie połączenia sql
            ia.CreateSQLConnection(oUstawienia.sqlServer, oUstawienia.sqldb, oUstawienia.sqlUserId, oUstawienia.sqlPasswd)

            If Not oUstawienia.iaConn Is Nothing Then
                'Start formy Main
                Dim frmMain As New frmMain
                Application.Run(frmMain)
                frmMain.Dispose()
                'zakończenie połączenia sql
            End If
        Catch ex As Exception
            MessageBox.Show($"Wystąpił błąd w trakcie startu aplikacji: {Environment.NewLine} {ex.Message}")
        Finally
            ia.CloseSQLConn(oUstawienia.iaConn)
        End Try
    End Sub
End Module
