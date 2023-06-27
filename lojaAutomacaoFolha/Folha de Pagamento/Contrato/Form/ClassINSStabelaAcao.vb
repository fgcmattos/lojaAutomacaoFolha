Imports MySql.Data.MySqlClient

Public Class ClassINSStabelaAcao

    Public Shared Function GetINSS_DB() As List(Of ClassINSStabela)

        Dim Query As String

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassINSStabela)

        Query = "select "
        Query += "idINSS"
        Query += ",ifnull(INSSdata,'')"
        Query += ",INSSfaixa1"
        Query += ",INSSfaixa1Porcentagem"
        Query += ",INSSfaixa2"
        Query += ",INSSfaixa2Porcentagem"
        Query += ",INSSfaixa3"
        Query += ",INSSfaixa3Porcentagem"
        Query += ",INSSfaixa4"
        Query += ",INSSfaixa4Porcentagem"
        Query += ",INSS_dataInicio"
        Query += ",ifnull(INSS_dataFim,'')"
        Query += ",INSSnumeroDeFaixas"
        Query += ",INSS_ativa"
        Query += ",if(INSSfaixa1valor<>0,INSSfaixa1valor,INSSfaixa1*(INSSfaixa1Porcentagem/100))"
        Query += ",if(INSSfaixa2valor<>0,INSSfaixa2valor,(INSSfaixa2-INSSfaixa1)*(INSSfaixa2Porcentagem/100))"
        Query += ",if(INSSfaixa3valor<>0,INSSfaixa2valor,(INSSfaixa3-INSSfaixa2)*(INSSfaixa3Porcentagem/100))"
        Query += ",if(INSSfaixa4valor<>0,INSSfaixa3valor,(INSSfaixa4-INSSfaixa4)*(INSSfaixa4Porcentagem/100))"
        Query += ",INSSfaixa1valor"
        Query += ",INSSfaixa1valor +INSSfaixa2valor"
        Query += ",INSSfaixa1valor +INSSfaixa2valor + INSSfaixa3valor"
        Query += ",INSSfaixa1valor +INSSfaixa2valor + INSSfaixa3valor + + INSSfaixa4valor"

        Query += " From inss"
        Query += " where "
        Query += "INSS_ativa"

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassINSStabela() With
                        {
                        .Class_idINSS = DTReader.GetValue(0),
                        .Class_INSSdata = DTReader.GetValue(1),
                        .Class_INSSfaixa1 = DTReader.GetValue(2),
                        .Class_INSSfaixa1Porcentagem = DTReader.GetValue(3),
                        .Class_INSSfaixa2 = DTReader.GetValue(4),
                        .Class_INSSfaixa2Porcentagem = DTReader.GetValue(5),
                        .Class_INSSfaixa3 = DTReader.GetValue(6),
                        .Class_INSSfaixa3Porcentagem = DTReader.GetValue(7),
                        .Class_INSSfaixa4 = DTReader.GetValue(8),
                        .Class_INSSfaixa4Porcentagem = DTReader.GetValue(9),
                        .Class_INSS_dataInicio = DTReader.GetValue(10),
                        .Class_INSS_dataFim = DTReader.GetValue(11),
                        .Class_INSSnumeroDeFaixas = DTReader.GetValue(12),
                        .Class_INSS_ativa = DTReader.GetValue(13),
                        .Class_INSSfaixa1Valor = DTReader.GetValue(14),
                        .Class_INSSfaixa2Valor = DTReader.GetValue(15),
                        .Class_INSSfaixa3Valor = DTReader.GetValue(16),
                        .Class_INSSfaixa4Valor = DTReader.GetValue(17),
                        .Class_INSSfaixa1Acumulado = DTReader.GetValue(18),
                        .Class_INSSfaixa2Acumulado = DTReader.GetValue(19),
                        .Class_INSSfaixa3Acumulado = DTReader.GetValue(20),
                        .Class_INSSfaixa4Acumulado = DTReader.GetValue(21)
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
