Imports MySql.Data.MySqlClient
Public Class ClassFolha_SetorAcao

    Public Shared Function GetFolhaSetorDB() As List(Of ClassFolha_Setor)

        Dim Query As String = ""

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassFolha_Setor)

        Query += "select"
        Query += " folha_setor_Codigo"
        Query += ",folha_setor_descricao"
        Query += " From folha_setor"
        Query += " order by folha_setor_Codigo "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassFolha_Setor() With
                        {
                        .codigo = DTReader.GetValue(0),
                        .Descricao = DTReader.GetValue(1),
                        .ComboOpcao = .codigo & " - " & .Descricao
                        }
                        )
                End While
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

        Conn.Close()

        Return lista

    End Function
End Class
