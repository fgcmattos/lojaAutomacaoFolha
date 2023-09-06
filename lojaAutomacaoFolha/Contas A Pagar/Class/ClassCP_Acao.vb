Imports MySql.Data.MySqlClient

Public Class ClassCP_Acao

    Public Shared Function GetCP_DB(queryWhere As String) As List(Of ClassCP)
        ' queryWhere é o Whw completo do SQL

        'Dim emp As List(Of ClassCP) = ClassCP_Acao.GetCP_DB()

        Dim lista As New List(Of ClassCP)


        Dim Query As String = ""
        Query += "select "
        Query += "ID_CP"                                                                   '  0
        Query += ",CP_ordem"                                                               '  1
        Query += ",CP_SIS_Lac"                                                             '  2
        Query += ",CP_DTA_Fato"                                                            '  3
        Query += ",CP_DTA_Venc"                                                            '  4
        Query += ",ifnull(CP_DTA_PG,'')"                                                   '  5
        Query += ",CP_Valor_Cobrado"                                                       '  6
        Query += ",CP_Valor_Final"                                                         '  7
        Query += ",CP_Valor_Desconto"                                                      '  8
        Query += ",CP_Valor_Juros"                                                         '  9
        Query += ",CP_Valor_Multa"                                                         ' 10
        Query += ",CP_Credor_Tipo"                                                         ' 11
        Query += ",CP_Credor_ID"                                                           ' 12
        Query += ",CP_Credor_Nome"                                                         ' 13
        Query += ",CP_Tipo_Cobranca"                                                       ' 14
        Query += ",CP_Doc_Numero"                                                          ' 15
        Query += ",CP_Historico"                                                           ' 16
        Query += ",CP_DTA_Inclusao"                                                        ' 17
        Query += ",CP_Credor_Fone"                                                         ' 18
        Query += ",CP_Lote_Lancamento"                                                     ' 19
        Query += ",CP_Status "                                                             ' 20
        Query += ",DATEDIFF(STR_TO_DATE(CP_DTA_Venc, '%Y%m%d'),NOW()) as Prazo"            ' 21
        Query += ",CP_Centro_Custo_codigo"                                                 ' 22
        Query += ",CP_Centro_Custo_nome "                                                  ' 23
        Query += " From CP "
        Query += queryWhere


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        Try
            If OpenDB() Then
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassCP() With
                    {
                    .Class_ID_CP = DTReader.GetValue(0),
                    .Class_CP_ordem = DTReader.GetValue(1),
                    .Class_CP_SIS_Lac = DTReader.GetValue(2),
                    .Class_CP_DTA_Fato = DTReader.GetValue(3),
                    .Class_CP_DTA_Venc = DTReader.GetValue(4),
                    .Class_CP_DTA_PG = DTReader.GetValue(5),
                    .Class_CP_Valor_Cobrado = DTReader.GetValue(6),
                    .Class_CP_Valor_Final = DTReader.GetValue(7),
                    .Class_CP_Valor_Desconto = DTReader.GetValue(8),
                    .Class_CP_Valor_Juros = DTReader.GetValue(9),
                    .Class_CP_Valor_Multa = DTReader.GetValue(10),
                    .Class_CP_Credor_Tipo = DTReader.GetValue(11),
                    .Class_CP_Credor_ID = DTReader.GetValue(12),
                    .Class_CP_Credor_Nome = DTReader.GetValue(13),
                    .Class_CP_Tipo_Cobranca = DTReader.GetValue(14),
                    .Class_CP_Doc_Numero = DTReader.GetValue(15),
                    .Class_CP_Historico = DTReader.GetValue(16),
                    .Class_CP_DTA_Inclusao = DTReader.GetValue(17),
                    .Class_CP_Credor_Fone = DTReader.GetValue(18),
                    .Class_CP_Lote_Lancamento = DTReader.GetValue(19),
                    .Class_CP_Prazo = DTReader.GetValue(21),
                    .Class_CP_Centro_Custo_codigo = DTReader.GetValue(22),
                    .Class_CP_Centro_Custo_nome = DTReader.GetValue(23)
                    }
                    )

                End While
            End If
        Catch ex As Exception

            MsgBox("Problemas Na Leitura CP")

        End Try



        Conn.Close()


        Return lista

    End Function

End Class

