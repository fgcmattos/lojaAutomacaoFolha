Imports MySql.Data.MySqlClient
Public Class CartaoClassRP

    Public Shared Function Getcartao(pesquisa As String) As List(Of CartaoClass)
        Dim dtDataAtivacao, dtDataDesativacao As DateTime
        Dim lista As New List(Of CartaoClass)

        If OpenDB() Then

            Dim query As String = pesquisa
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read

                    If Not DateTime.TryParse(DTReader.GetString(13), dtDataAtivacao) Then

                        dtDataAtivacao = Nothing

                    End If

                    If Not DateTime.TryParse(DTReader.GetString(14), dtDataDesativacao) Then

                        dtDataDesativacao = Nothing

                    End If

                    lista.Add(New CartaoClass() With
            {
                .CodInterno = DTReader.GetString(0),    ' Codigo de controle Interno 
                .Bandeira = DTReader.GetString(1),      ' ADM do Cartao
                .Numero = DTReader.GetString(2),        ' Numero do cartao
                .Responsavel = DTReader.GetString(3),   ' Responsavel
                .NomeImpresso = DTReader.GetString(4),  ' Nome Impresso
                .Validade = DTReader.GetString(5),      ' Nome Impresso no Cartao
                .Fatura = DTReader.GetString(6),        ' Dia da fatura
                .CodigoSeg = DTReader.GetString(7),     ' Codigo de seguranca do cartao
                .Banco = DTReader.GetString(8),
                .Agencia = DTReader.GetString(9),
                .Agencia_dg = DTReader.GetString(10),
                .Conta = DTReader.GetString(11),
                .Conta_dg = DTReader.GetString(12),
                .Ativacao = dtDataAtivacao,
                .Desativacao = dtDataDesativacao
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
