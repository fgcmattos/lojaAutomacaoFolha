Imports MySql.Data.MySqlClient

Public Class ClassIRtabelaAcao

    Public Shared Function GetIR_DB(IsTabela As String) As List(Of ClassIRtabela)

        'IsTabela pode ser
        ' IR_ativa       - Quando o cálculo é realizado em produção
        ' REF              - YYYYAA - Quando utilizado para teste de uma nova tabela ou para pesquisa
        '                    INSSREF = '202201'

        Dim Query As String

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassIRtabela)

        Query = "select "
        Query += "IR_calc.idIR"                                                                                                                          '    0
        Query += ",IR_calc.IRREF"                                                                                                                        '    1
        Query += ",IR_calc.IRfaixa1"                                                                                                                     '    2
        Query += ",IR_calc.IRfaixa1Porcentagem"                                                                                                          '    3
        Query += ",IR_calc.IRfaixa2"                                                                                                                     '    4
        Query += ",IR_calc.IRfaixa2Porcentagem"                                                                                                          '    5
        Query += ",IR_calc.IRfaixa3"                                                                                                                     '    6
        Query += ",IR_calc.IRfaixa3Porcentagem"                                                                                                          '    7
        Query += ",IR_calc.IRfaixa4"                                                                                                                     '    8
        Query += ",IR_calc.IRfaixa4Porcentagem"                                                                                                          '    9
        Query += ",IR_calc.IRfaixa5"                                                                                                                     '    10
        Query += ",IR_calc.IRfaixa5Porcentagem"                                                                                                          '    11
        Query += ",IR_calc.IR_dataInicio"                                                                                                                '    12  
        Query += ",IR_calc.IR_dataFim"                                                                                                                   '    13
        Query += ",IR_calc.IRnumeroDeFaixas"                                                                                                             '    14  
        Query += ",IR_calc.IR_ativa"                                                                                                                     '    15  
        Query += ",IR_calc.IRfaixa1Valor"                                                                                                                '    16
        Query += ",IR_calc.IRfaixa2Valor"                                                                                                                '    17
        Query += ",IR_calc.IRfaixa3Valor"                                                                                                                '    18
        Query += ",IR_calc.IRfaixa4Valor"                                                                                                                '    19
        Query += ",IR_calc.IRfaixa5Valor"                                                                                                                '    20
        Query += ",IR_calc.IRfaixa1valor as faixa1ValorAcumulado"                                                                                        '    21
        Query += ",IR_calc.IRfaixa1valor + IR_calc.IRfaixa2valor as faixa2ValorAcumulado"                                                                '    22
        Query += ",IR_calc.IRfaixa1valor + IR_calc.IRfaixa2valor + IR_calc.IRfaixa3valor as faixa3ValorAcumulado"                                        '    23
        Query += ",IR_calc.IRfaixa1valor + IR_calc.IRfaixa2valor + IR_calc.IRfaixa3valor + IR_calc.IRfaixa4valor as faixa4ValorAcumulado"                '    24
        Query += ",IR_calc.IRfaixa1valor + IR_calc.IRfaixa2valor + IR_calc.IRfaixa3valor + IR_calc.IRfaixa4valor + IR_calc.IRfaixa5valor as faixa5ValorAcumulado"                '  25
        Query += ",IRdataCriacao"                                                                                                                        '    26
        Query += ",IRresponsavelDigitacao"                                                                                                               '    27
        Query += ",IRresponsavelDigitacaoTipo"                                                                                                           '    28
        Query += ",IRresponsavelConferencia"                                                                                                             '    29
        Query += ",IRresponsavelConferenciaTipo"                                                                                                         '    30
        Query += ",IRdataConferencia"                                                                                                                    '    31
        Query += ",coalesce((select usuarioNomeAcesso from usuario where  (usuarioChave = IRresponsavelDigitacao and usuarioTipo=IRresponsavelDigitacaoTipo COLLATE utf8mb4_general_ci)),'') as IRdigitacaoUsuario "          '  32
        Query += ",coalesce((select usuarioNomeAcesso from usuario where  (usuarioChave = IRresponsavelConferencia and usuarioTipo=IRresponsavelConferenciaTipo COLLATE utf8mb4_general_ci)),'') as IRconferenciaUsuario "    '  33
        Query += ",coalesce((select usuarioNomeAcesso from usuario where  (usuarioChave = IRresponsavelPublicacao and usuarioTipo=IRresponsavelPublicacaoTipo COLLATE utf8mb4_general_ci)),'') as IRpublicacaoUsuario "       '  34
        Query += ",IRresponsavelPublicacao"                                                                                                              '    35
        Query += ",IRresponsavelPublicacaoTipo"                                                                                                          '    36
        Query += ",IRdataPublicacao"                                                                                                                     '    37
        Query += ",IRtabelaNumero"                                                                                                                       '    38

        Query += " From "
        Query += " (select "
        Query += "idIR"
        Query += ",IRREF"
        Query += ",IRfaixa1"
        Query += ",IRfaixa1Porcentagem"
        Query += ",IRfaixa2"
        Query += ",IRfaixa2Porcentagem"
        Query += ",IRfaixa3"
        Query += ",IRfaixa3Porcentagem"
        Query += ",ifnull(IRfaixa4,0) as IRfaixa4"
        Query += ",ifnull(IRfaixa4Porcentagem,0) as IRfaixa4Porcentagem"
        Query += ",ifnull(IRfaixa5,0) as IRfaixa5"
        Query += ",ifnull(IRfaixa5Porcentagem,0) as IRfaixa5Porcentagem"
        Query += ",IR_dataInicio"
        Query += ",ifnull(IR_dataFim,'') as IR_dataFim"
        Query += ",IRnumeroDeFaixas"
        Query += ",IR_ativa"
        Query += ",if(IRfaixa1valor<>0,IRfaixa1valor,round(IRfaixa1*(IRfaixa1Porcentagem/100),2)) as IRfaixa1Valor"
        Query += ",if(IRfaixa2valor<>0,IRfaixa2valor,round((IRfaixa2-IRfaixa1)*(IRfaixa2Porcentagem/100),2)) as IRfaixa2Valor"
        Query += ",if(IRfaixa3valor<>0,IRfaixa3valor,round((IRfaixa3-IRfaixa2)*(IRfaixa3Porcentagem/100),2)) as IRfaixa3Valor"
        Query += ",if(IRnumeroDeFaixas>3,if(IRfaixa4valor<>0,IRfaixa4valor,round((IRfaixa4-IRfaixa3)*(IRfaixa4Porcentagem/100),2)),0) as IRfaixa4Valor"
        Query += ",if(IRnumeroDeFaixas>4,if(IRfaixa5valor<>0,IRfaixa5valor,round((IRfaixa5-IRfaixa4)*(IRfaixa5Porcentagem/100),2)),0) as IRfaixa5Valor"
        Query += ",IRdataCriacao"
        Query += ",ifnull(IRresponsavelDigitacao,0) as IRResponsavelDigitacao"
        Query += ",ifnull(IRresponsavelDigitacaoTipo,'') as IRResponsavelDigitacaoTipo"
        Query += ",ifnull(IRresponsavelConferencia,0) as IRresponsavelConferencia"
        Query += ",ifnull(IRresponsavelConferenciaTipo,'') as IRresponsavelConferenciaTipo"
        Query += ",ifnull(IRdataConferencia,'') as IRdataConferencia"
        Query += ",IRtabelaNumero"
        Query += ",ifnull(IRresponsavelPublicacao,0) as IRresponsavelPublicacao"
        Query += ",ifnull(IRresponsavelPublicacaoTipo,'') as IRresponsavelPublicacaoTipo"
        Query += ",ifnull(IRdataPublicacao,'') as IRdataPublicacao"



        Query += " from folha_tabela_imposto_renda_pf "
        Query += "where " & IsTabela                                         'IR_ativa"
        Query += ")"
        Query += "  as IR_calc"

        Dim CMD As New MySqlCommand(Query, Conn)


        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassIRtabela() With
                        {
                        .Class_idIR = DTReader.GetValue(0),
                        .Class_IRref = DTReader.GetValue(1),
                        .Class_IRfaixa1 = DTReader.GetValue(2),
                        .Class_IRfaixa1Porcentagem = DTReader.GetValue(3),
                        .Class_IRfaixa2 = DTReader.GetValue(4),
                        .Class_IRfaixa2Porcentagem = DTReader.GetValue(5),
                        .Class_IRfaixa3 = DTReader.GetValue(6),
                        .Class_IRfaixa3Porcentagem = DTReader.GetValue(7),
                        .Class_IRfaixa4 = DTReader.GetValue(8),
                        .Class_IRfaixa4Porcentagem = DTReader.GetValue(9),
                        .Class_IRfaixa5 = DTReader.GetValue(10),
                        .Class_IRfaixa5Porcentagem = DTReader.GetValue(11),
                        .Class_IR_dataInicio = IIf(DTReader.GetValue(12) = "", DateTime.MinValue, DTReader.GetValue(12)),
                        .Class_IR_dataFim = IIf(DTReader.GetValue(13) = "", DateTime.MinValue, DTReader.GetValue(13)),
                        .Class_IRnumeroDeFaixas = DTReader.GetValue(14),
                        .Class_IR_ativa = DTReader.GetValue(15),
                        .Class_IRfaixa1Valor = DTReader.GetValue(16),
                        .Class_IRfaixa2Valor = DTReader.GetValue(17),
                        .Class_IRfaixa3Valor = DTReader.GetValue(18),
                        .Class_IRfaixa4Valor = DTReader.GetValue(19),
                        .Class_IRfaixa5Valor = DTReader.GetValue(20),
                        .Class_IRfaixa1Acumulado = DTReader.GetValue(21),
                        .Class_IRfaixa2Acumulado = DTReader.GetValue(22),
                        .Class_IRfaixa3Acumulado = DTReader.GetValue(23),
                        .Class_IRfaixa4Acumulado = DTReader.GetValue(24),
                        .Class_IRfaixa5Acumulado = DTReader.GetValue(25),
                        .Class_IRdataCriacao = DTReader.GetValue(26),
                        .Class_IRresponsavelDigitacao = DTReader.GetValue(27),
                        .Class_IRresponsavelDigitacaoTipo = DTReader.GetValue(28),
                        .Class_IRresponsavelConferencia = DTReader.GetValue(29),
                        .Class_IRresponsavelConferenciaTipo = DTReader.GetValue(30),
                        .Class_IRdataConferencia = IIf(DTReader.GetValue(31) = "", DateTime.MinValue, DTReader.GetValue(31)),
                        .Class_IRresponsavelDigitacaoNome = DTReader.GetValue(32),
                        .Class_IRresponsavelConferenciaNome = DTReader.GetValue(33),
                        .Class_IRresponsavelPublicacaoNome = DTReader.GetValue(34),
                        .Class_IRresponsavelPublicacao = DTReader.GetValue(35),
                        .Class_IRresponsavelPublicacaoTipo = DTReader.GetValue(36),
                        .Class_IRdataPublicação = IIf(DTReader.GetValue(37) = "", DateTime.MinValue, DTReader.GetValue(37)),
                        .Class_IR_numero = DTReader.GetValue(38)
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
