Imports MySql.Data.MySqlClient
Public Class irTabelaAcao
    Public Shared Function GetIRtabelaSQL() As List(Of irTabela)

        Dim lista As New List(Of irTabela)

        Dim DTReader As MySqlDataReader

        Dim Query As String

        Query = "select "
        Query += "ir_faixa, CAST(ir_inicio 	As Decimal(10, 2)) "
        Query += ",CAST(ir_taxa 				AS DECIMAL(10,2)) "
        Query += ",CAST(ir_valor_por_faixa 	AS DECIMAL(10,2)) "
        Query += ",CAST(ir_fim - ir_inicio 	AS DECIMAL(10,2)) "
        Query += "from "
        Query += "ir_tabelapf order by ir_faixa "

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read



                    lista.Add(New irTabela() With
                {
                .Faixa = DTReader.GetString(0),
                .Limite = DTReader.GetString(1),
                .Taxa = DTReader.GetString(2),
                .Valor = DTReader.GetString(3),
                .Elementos_por_faixa = Int(DTReader.GetString(4) * 100) / 100
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
