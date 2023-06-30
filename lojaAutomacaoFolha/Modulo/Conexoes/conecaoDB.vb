Imports MySql.Data.MySqlClient
Module conecaoDB
    Public Conn As New MySqlConnection
    Dim Result As Boolean
    Dim StrConn As String
    Public Function OpenDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                StrConn = "server=191.96.31.192;user=user;password=UhWHnMb398UX;port=3306;database=" & Reg.DB & ";sslmode=none"
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

