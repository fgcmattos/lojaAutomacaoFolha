Imports MySql.Data.MySqlClient
Module ConnectionDB
    Public Conn As New MySqlConnection
    Dim Result As Boolean
    Dim StrConn As String

    Public Function OpenDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                StrConn = "server=localhost;user=root;password=223584;port=3306;database=comercio;sslmode=none"
                'StrConn = "server=3.18.70.171;user=fernando;password=95702198;port=3306;database=comercio;sslmode=none"
                Conn.ConnectionString = StrConn
                Conn.Open()
                Result = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Result = False
        End Try
        Return Result
    End Function
End Module
