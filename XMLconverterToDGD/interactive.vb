Imports System.Data.SqlClient
Public Class interactive
    Public Function GetDataTable(query As String, oconn As SqlConnection) As DataTable
        Try
            'deklaracja datatable dla return
            Dim MyDataTable As New DataTable

            If oconn.State = ConnectionState.Closed Then
                oconn.Open()
            End If

            Using oconn
                'utworzenie query
                Dim MySqlCommand As SqlCommand = New SqlCommand(query, oconn)

                'utworzenie datareadera i executedatareader
                Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader()

                'zaladowanie readera do datatable
                MyDataTable.Load(MyDataReader)

                'wyczyszczenie readera
                MyDataReader.Close()
            End Using

            'return datatable
            Return MyDataTable
        Catch ex As Exception
            Throw
        Finally
            If oconn.State = ConnectionState.Open Then
                oconn.Close()
            End If
        End Try
    End Function

    Public Function GetScalarInteger(query As String, oconn As SqlConnection) As Integer
        Try
            Dim MyInt As New Integer
            Dim cmd As SqlCommand

            If oconn.State = ConnectionState.Closed Then
                oconn.Open()
            End If

            Using oconn
                cmd = New SqlCommand(query, oconn)

                MyInt = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            'return integer
            If Not Convert.IsDBNull(MyInt) Then
                Return MyInt
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw
        Finally
            If oconn.State = ConnectionState.Open Then
                oconn.Close()
            End If
        End Try
    End Function

    Public Function GetScalarString(query As String, oconn As SqlConnection) As String
        Try
            Dim MyString As String = ""
            Dim cmd As SqlCommand

            If oconn.State = ConnectionState.Closed Then
                oconn.Open()
            End If

            Using oconn
                cmd = New SqlCommand(query, oconn)

                MyString = Convert.ToString(cmd.ExecuteScalar())
            End Using

            'return integer
            If Not Convert.IsDBNull(MyString) Then
                Return MyString
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw
        Finally
            If oconn.State = ConnectionState.Open Then
                oconn.Close()
            End If
        End Try
    End Function

    Public Function CreateSQLConnection(sqlServer As String, sqlDatabase As String, sqlUser As String, sqlPasswd As String)
        Try
            oUstawienia.iaConn = New SqlConnection($"Server={sqlServer};Database={sqlDatabase};User Id={sqlUser};Password={sqlPasswd}")
            oUstawienia.iaConn.Open()
            Return oUstawienia.iaConn
        Catch ex As Exception
            Return MessageBox.Show($"Wystąpił błąd w trakcie otwierania połączenia z serwerem sql: {Environment.NewLine} {ex.Message}")
        End Try
    End Function

    Friend Sub CloseSQLConn(oconn As SqlConnection)
        Try
            oconn.Close()
            oconn = Nothing
        Catch ex As Exception
            MessageBox.Show($"Wystąpił błąd w trakcie zamykania połączenia SQL: {Environment.NewLine} {ex.Message}")
        End Try
    End Sub
End Class
