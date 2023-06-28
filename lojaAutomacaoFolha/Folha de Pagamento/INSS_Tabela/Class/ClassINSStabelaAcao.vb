﻿Imports MySql.Data.MySqlClient

Public Class ClassINSStabelaAcao

    Public Shared Function GetINSS_DB() As List(Of ClassINSStabela)

        Dim Query As String

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassINSStabela)

        Query = "select "
        Query += "INSS_calc.idINSS"
        Query += ",INSS_calc.INSSdata"
        Query += ",INSS_calc.INSSfaixa1"
        Query += ",INSS_calc.INSSfaixa1Porcentagem"
        Query += ",INSS_calc.INSSfaixa2"
        Query += ",INSS_calc.INSSfaixa2Porcentagem"
        Query += ",INSS_calc.INSSfaixa3"
        Query += ",INSS_calc.INSSfaixa3Porcentagem"
        Query += ",INSS_calc.INSSfaixa4"
        Query += ",INSS_calc.INSSfaixa4Porcentagem"
        Query += ",INSS_calc.INSS_dataInicio"
        Query += ",INSS_calc.INSS_dataFim"
        Query += ",INSS_calc.INSSnumeroDeFaixas"
        Query += ",INSS_calc.INSS_ativa"
        Query += ",INSS_calc.INSSfaixa1Valor"
        Query += ",INSS_calc.INSSfaixa2Valor"
        Query += ",INSS_calc.INSSfaixa3Valor"
        Query += ",INSS_calc.INSSfaixa4Valor"
        Query += ",INSS_calc.INSSfaixa1valor as faixa1ValorAcumulado"
        Query += ",INSS_calc.INSSfaixa1valor + INSS_calc.INSSfaixa2valor as faixa2ValorAcumulado"
        Query += ",INSS_calc.INSSfaixa1valor + INSS_calc.INSSfaixa2valor + INSS_calc.INSSfaixa3valor as faixa3ValorAcumulado"
        Query += ",INSS_calc.INSSfaixa1valor + INSS_calc.INSSfaixa2valor + INSS_calc.INSSfaixa3valor + INSS_calc.INSSfaixa4valor as faixa4ValorAcumulado"
        Query += " From "
        Query += " (select "
        Query += "	idINSS"
        Query += ",ifnull(INSSdata,'') as INSSdata"
        Query += ",INSSfaixa1"
        Query += ",INSSfaixa1Porcentagem"
        Query += ",INSSfaixa2"
        Query += ",INSSfaixa2Porcentagem"
        Query += ",INSSfaixa3"
        Query += ",INSSfaixa3Porcentagem"
        Query += ",INSSfaixa4"
        Query += ",INSSfaixa4Porcentagem"
        Query += ",INSS_dataInicio"
        Query += ",ifnull(INSS_dataFim,'') as INSS_dataFim"
        Query += ",INSSnumeroDeFaixas"
        Query += ",INSS_ativa"
        Query += ",if(INSSfaixa1valor<>0,INSSfaixa1valor,INSSfaixa1*(INSSfaixa1Porcentagem/100)) as INSSfaixa1Valor"
        Query += ",if(INSSfaixa2valor<>0,INSSfaixa2valor,(INSSfaixa2-INSSfaixa1)*(INSSfaixa2Porcentagem/100)) as INSSfaixa2Valor"
        Query += ",if(INSSfaixa3valor<>0,INSSfaixa3valor,(INSSfaixa3-INSSfaixa2)*(INSSfaixa3Porcentagem/100)) as INSSfaixa3Valor"
        Query += ",if(INSSfaixa4valor<>0,INSSfaixa4valor,(INSSfaixa4-INSSfaixa3)*(INSSfaixa4Porcentagem/100)) as INSSfaixa4Valor"
        Query += "	from inss "
        Query += "	where INSS_ativa"
        Query += "  )"
        Query += "  as INSS_calc"

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
