Imports MySql.Data.MySqlClient
Public Class ClassFolha_cargoAcao

    Public Shared Function GetFolhaCargoDB(setor As Integer) As List(Of ClassFolha_Cargo)

        Dim intSetor As Integer = setor

        Dim Query As String = ""

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassFolha_Cargo)

        Query += "select"
        Query += " folha_cargo_Codigo"
        Query += ",folha_cargo_descricao"
        Query += " From folha_cargo"
        Query += " Where folha_cargo_setor = " & intSetor
        Query += " order by folha_cargo_Codigo "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassFolha_Cargo() With
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
