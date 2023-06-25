Imports MySql.Data.MySqlClient
Public Class ClassRegistroAcao

    Public Shared Function getRegistroDB() As List(Of ClassRegistro)
        'em construcao 18/11/2021
        Dim Query As String = ""

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassRegistro)

        Query += "select"
        Query += " folha_cargo_Codigo"
        Query += ",folha_cargo_descricao"
        Query += " From folha_cargo"
        Query += " Where folha_cargo_setor = "
        Query += " order by folha_cargo_Codigo "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassRegistro() With
                        {
                        .EmpCNPJ = DTReader.GetValue(0),
                        .EmpNome = DTReader.GetValue(1),
                        .EmpEndereco = DTReader.GetValue(2)
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
