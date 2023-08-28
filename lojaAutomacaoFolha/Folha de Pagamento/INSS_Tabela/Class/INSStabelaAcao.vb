Imports MySql.Data.MySqlClient
Public Class INSStabelaAcao

    Public Shared Function GetINSStabelaSQL() As List(Of INSStabela)

        Dim lista As New List(Of INSStabela)

        Dim DTReader As MySqlDataReader

        Dim Query As String = "select inssfaixa,CAST(inssfim AS DECIMAL(10,2)),CAST(taxa AS DECIMAL(10,2)),CAST(valorporfaixa AS DECIMAL(10,2)) from inss_tabelapf"

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read



                    lista.Add(New INSStabela() With
                {
                .Faixa = DTReader.GetString(0),
                .Limite = DTReader.GetString(1),
                .Taxa = DTReader.GetString(2),
                .Valor = DTReader.GetString(3)
                }
                )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura da Base de Dados! INSStabelaAcao.GetINSStabelaSQL()")
            End Try

            Conn.Close()

        End If

        Return lista

    End Function

End Class
