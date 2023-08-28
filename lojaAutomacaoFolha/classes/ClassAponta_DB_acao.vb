Imports MySql.Data.MySqlClient

Public Class ClassAponta_DB_acao
    Public Shared Function GetApontaDB(StrComando As String, ObjCombo As Object) As Object

        Dim Query As String = StrComando

        Dim DTReader As MySqlDataReader

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then


            Try

                DTReader = CMD.ExecuteReader


                While DTReader.Read()

                    ObjCombo.items.add(DTReader.GetString(0))

                End While

            Catch ex As Exception

                MsgBox(ex)

            End Try

        End If

        Conn.Close()

        Return ObjCombo

    End Function
End Class