Imports MySql.Data.MySqlClient

Module ModuleVB_MySQL

    Public Function GravaSQL(query As String) As Boolean

        Dim CMD As New MySqlCommand(query, Conn)
        Dim STRretorna As Boolean = True
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

            Catch ex As Exception
                MsgBox(ex.Message)
                STRretorna = False
            End Try

            Conn.Close()

        End If

        Return (STRretorna)

    End Function

    Public Function gravaSQLretorno(query As String) As String

        Dim strRetorno As String = ""

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        Try
            If OpenDB() Then

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                strRetorno = DTReader.GetValue(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Conn.Close()

        Return (strRetorno)

    End Function

    Public Function ApontaSQL(query As String) As Integer

        ApontaSQL = 0

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)


        If OpenDB() Then

            DTReader = CMD.ExecuteReader
            DTReader.Read()
            ApontaSQL = DTReader(0)

            Conn.Close()

        End If

        Return ApontaSQL

    End Function

    Public Function ApontaElementosSQL(arq As String, camp As String, cond As String, NumStr As Boolean) As Boolean

        ' NumStr parametriza a pesquisa se campo é string ou numerico
        ' numerico true
        ' string false

        Dim query As String

        query = "select count(*) from "
        query += arq
        query += " where "
        query += camp
        If NumStr Then
            query += " = " & cond
        Else
            query += " = '" & cond & "'"
        End If


        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetValue(0) > 0 Then

                    ApontaElementosSQL = True

                Else

                    ApontaElementosSQL = False

                End If


            Catch ex As Exception

                MsgBox("Problemas Na Pesquisa!")

            End Try

            Conn.Close()

        End If

        Return ApontaElementosSQL

    End Function
End Module
