Public Class frmConnToDB

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtServer.TextLength > 0 And txtDB.TextLength > 0 And txtServer.TextLength > 0 And txtUser.TextLength > 0 Then
            iSQL.CreateSQLConnection(txtServer.Text, txtDB.Text, txtUser.Text, txtPasswd.Text, oUstawienia.iConn)
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Najpierw wypełnij wszystkie pola.")
        End If
    End Sub
End Class