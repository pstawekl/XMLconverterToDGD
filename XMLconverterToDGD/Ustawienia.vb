Imports System.Data.SqlClient

Public Class Ustawienia
    Public Property sqlServer As String = ".\SQLEXPRESS"
    Public Property sqldb As String = "TestDatabase"
    Public Property sqlUserId As String = "sa"
    Public Property sqlPasswd As String = "el4505to"

    Public Property iaConn As SqlConnection
End Class
