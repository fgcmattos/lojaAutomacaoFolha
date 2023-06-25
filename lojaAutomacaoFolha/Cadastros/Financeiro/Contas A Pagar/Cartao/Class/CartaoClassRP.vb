Imports MySql.Data.MySqlClient
Public Class CartaoClassRP

    Public Shared Function Getcartao(pesquisa As String) As List(Of CartaoClass)
        Dim lista As New List(Of CartaoClass)

        If OpenDB() Then

            Dim query As String = pesquisa
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New CartaoClass() With
            {
                .CodInterno = DTReader.GetString(0),    ' Codigo de controle Interno 
                .Bandeira = DTReader.GetString(1),      ' ADM do Cartao
                .Numero = DTReader.GetString(2),        ' Numero do cartao
                .Responsavel = DTReader.GetString(3),   ' Responsavel
                .NomeImpresso = DTReader.GetString(4),  ' Nome Impresso
                .Validade = DTReader.GetString(5),      ' Nome Impresso no Cartao
                .Fatura = DTReader.GetString(6),        ' Dia da fatura
                .CodigoSeg = DTReader.GetString(7)      ' Codigo de seguranca do cartao
            }
            )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura da Base de Dados!")
            End Try

            Conn.Close()

        End If


        Return lista
    End Function

End Class
