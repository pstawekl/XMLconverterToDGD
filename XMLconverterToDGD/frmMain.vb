Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ZaladujDatagrid()
        Try
            Dim strSql As String = $"select * from ia_testtable"
            Dim dt As DataTable = ia.GetDataTable(strSql, oUstawienia.iaConn)
            dgd.DataSource = dt
        Catch ex As Exception
            MessageBox.Show($"Wystąpił błąd w trakcie ładowania datagrida: {Environment.NewLine} {ex.Message}")
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ZaladujDatagrid()
    End Sub

    Private Sub btnGetInt_Click(sender As Object, e As EventArgs) Handles btnGetInt.Click
        Try
            Dim myint As Integer = ia.GetScalarInteger($"select 1", oUstawienia.iaConn)
            MessageBox.Show(myint)
        Catch ex As Exception
            MessageBox.Show($"Wystąpił błąd w trakcie pobierania integera: {Environment.NewLine} {ex.Message}")
        End Try
    End Sub

    Private Sub btnGetString_Click(sender As Object, e As EventArgs) Handles btnGetString.Click
        Dim mystring As String = ia.GetScalarString($"select 'random string'", oUstawienia.iaConn)
        MessageBox.Show(mystring)
    End Sub
End Class
