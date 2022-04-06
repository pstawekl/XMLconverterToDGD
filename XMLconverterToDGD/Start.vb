Imports System.Xml
Imports System.Text

Module Start
    Public oUstawienia As New Ustawienia()
    Public iSQL As New Interactive.interactiveSQL
    Public iXML As New Interactive.interactiveXML
    Public interactive As New Interactive.interactive
    Public IfSQLConnectionIsBad As Boolean = False
    Dim conString As String = $"Server={oUstawienia.sqlServer};Database={oUstawienia.sqldb};User Id={oUstawienia.sqlUserId};Password={oUstawienia.sqlPasswd}"

    Sub Main()
        Try
            'Tworzenie połączenia sql
            iSQL.CreateSQLConnection(oUstawienia.sqlServer, oUstawienia.sqldb, oUstawienia.sqlUserId, oUstawienia.sqlPasswd, oUstawienia.iConn)
            If IfSQLConnectionIsBad = True Then
                Dim frm As New frmConnToDB
                Dim result As DialogResult
                result = frm.ShowDialog()
                If frm.DialogResult = DialogResult.OK Then
                    MessageBox.Show($"Uzyskano poprawne połączenie z bazą danych.")
                End If
                frm.Dispose()
            End If

            If Not oUstawienia.iConn Is Nothing Then
                'Start formy Main
                Dim frmMain As New frmMain
                Application.Run(frmMain)
                frmMain.Dispose()
                'zakończenie połączenia sql
            End If
        Catch ex As Exception
            MessageBox.Show($"Wystąpił błąd w trakcie startu aplikacji: {Environment.NewLine} {ex.Message}")
        Finally
            iSQL.CloseSQLConn(oUstawienia.iConn)
        End Try
    End Sub
End Module
