Imports MySql.Data.MySqlClient
Public Class ReciboAcoes

    Public Shared Function ReciboColaboradorCarregaSQL(chave As String) As List(Of recibo)

        Dim lista As New List(Of recibo)

        Dim Mn As New MsgShow

        If OpenDB() Then
            Dim Query As String = ""
            Query += "select "
            Query += " count(*) as qto "
            Query += ",colaboradorNome "
            Query += ",colaboradorRG "
            Query += ",colaboradorCPF "
            Query += ",concat(colaboradorRGoe,' - ',colaboradorRGuf) "
            Query += ",colaboradorRGemissao "
            Query += ",concat(colaboradorResidencia,' - ',colaboradorResidenciaCidade,' - ',colaboradorResidenciaUF,'- CEP:',colaboradorResidenciaCEP)"
            Query += ",colaboradorRGuf "
            Query += " from colaborador where chave = "
            Query += chave
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetString(0) = "0" Then
                    With Mn
                        .style = vbCritical
                        .msg = "Colaborador não encontrado!"
                        MsgBox(.msg, .style, .title)
                    End With
                    Exit Function
                End If
                lista.Add(New recibo() With
                    {
               .Favorecido = DTReader.GetString(1),
               .FavorecidoRg = DTReader.GetString(2),
               .FavorecidoRgEmissao = DTReader.GetString(5),
               .FavorecidoCpf_Cnpj = CPFcolocaMascara(DTReader.GetString(3)),
               .FavorecidoRGorgaoExpedidor = DTReader.GetString(4),
               .FavorecidoRGuf = DTReader.GetString(6),
               .FavorecidoEndereco = DTReader.GetString(6)
                }
                )
            Catch ex As Exception

                'Conn.Close()

                With Mn
                    .style = vbCritical
                    .msg = "Problemas com a leitura do Arquivo! (ReciboAcoes)"
                    MsgBox(.msg, .style, .title)
                End With

                MsgBox("Problemas com a leitura do Arquivo")

                'Return lista

                'Exit Function

            Finally

                Conn.Close() ' Fecha a conexão no final da leitura, seja ela bem-sucedida ou não.


            End Try

        End If

        Return lista

    End Function

End Class
