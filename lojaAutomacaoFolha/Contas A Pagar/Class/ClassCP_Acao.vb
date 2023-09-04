Imports MySql.Data.MySqlClient

Public Class ClassCP_Acao

    Public Shared Function GetCP() As List(Of ClassCP)

        'Dim emp As List(Of ClassCP) = ClassCP_Acao.GetCP_DB()

        Dim lista As New List(Of ClassCP)


        Dim queryWhere As String

        queryWhere = " where "
        queryWhere += "FL_folha_tipo = 2"
        queryWhere += " And FL_folha2_status = 'E'"
        'queryWhere += " And FL_referencia = '" & strReferencia & "'"
        queryWhere += " And FL_key_col = chave"

        Dim Query As String = ""
        Query += "select "
        Query += "chave"                               '0
        Query += ",colaboradorNome"                    '1
        Query += ",colaboradorResidencia"              '2
        Query += ",colaboradorResidenciaCidade"        '3
        Query += ",colaboradorResidenciaUF"            '4
        Query += ",colaboradorResidenciaCEP"           '5
        Query += ",colaboradorSalarioAtual"            '6
        Query += ",colaboradorAdmissao"                '7
        Query += ",colaboradorCargo"                  '8
        Query += ",colaboradorCBO"                     '9
        Query += ",'0'"                                '10
        Query += ",colaboradorSetor"                   '11
        Query += ",colaboradorDependentesIR"           '12
        Query += ",0"                                  '13
        Query += ",FL_referencia"                      '14
        Query += ",FL_VARIAVEL"                        '15 
        Query += ",FL_DESCRICAO"                       '16
        Query += ",FL_QTO"                             '17
        Query += ",FL_valor"                           '18
        Query += ",FL_data_Liberacao"                  '19
        Query += ",FL_data_Pagamento"                  '20
        Query += ",FL_data_Liberacao"                  '21
        Query += ",(select sum(FL_valor) from folha_lancamento "  '22
        Query += queryWhere
        Query += " and FL_tipo_financeiro = 'C' )"
        Query += ",(select sum(FL_valor) from folha_lancamento "  '23
        Query += queryWhere
        Query += " and FL_tipo_financeiro = 'D' )"
        Query += ",FL_tipo_financeiro"                 '24
        Query += ",'Folha de Pagamento'"               '25
        Query += ",FL_unidade"                         '26
        Query += ", colaboradorBanco"                  '27
        Query += ", colaboradorAgencia"                '28
        Query += ", colaboradorContaCorrente"          '29
        Query += ", colaboradorContaCorrenteDigito"    '30
        Query += ", colaboradorPIX"                    '31
        Query += ", 'CPF'"                             '32

        Query += " from "
        Query += "folha_lancamento"
        Query += ",colaborador"
        Query += queryWhere

        Dim decCreditoCol As Decimal = 0
        Dim decDebitoCol As Decimal = 0
        Dim decLiquidoCol As Decimal = 0

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        Dim StrKeyCol As String = ""


        Try
            If OpenDB() Then
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    decCreditoCol = IIf(IsDBNull(DTReader.GetValue(22)), 0, DTReader.GetValue(22))
                    decDebitoCol = IIf(IsDBNull(DTReader.GetValue(23)), 0, DTReader.GetValue(23))
                    decLiquidoCol = (decCreditoCol - decDebitoCol)
                    StrKeyCol = DTReader.GetValue(0)
                    StrKeyCol = StrKeyCol.PadLeft(4, "0")

                    'MsgBox(MoneyLatino(DTReader.GetValue(22)))

                    'lista.Add(New FolhaAdiantamento() With
                    '{
                    '.ColChave = StrKeyCol,
                    '.ColNome = DTReader.GetValue(1),
                    '.ColEndereco = DTReader.GetValue(2),
                    '.ColCidade = DTReader.GetValue(3),
                    '.ColUF = DTReader.GetValue(4),
                    '.ColCEP = DTReader.GetValue(5),
                    '.ColSalarioAtual = MoneyLatino(DTReader.GetValue(6)),
                    '.ColDataAdmissao = DTReader.GetValue(7),
                    '.ColCargo = DTReader.GetValue(8),
                    '.ColCBO = DTReader.GetValue(9),
                    '.ColFuncao = DTReader.GetValue(10),
                    '.ColSetor = DTReader.GetValue(11),
                    '.ColDepIR = DTReader.GetValue(12),
                    '.ColDepSL = DTReader.GetValue(13),
                    '.FL_verbaCodigo = DTReader.GetValue(15),
                    '.FL_verbaDescricao = DTReader.GetValue(16),
                    '.FL_verbaQTO = DTReader.GetValue(17),
                    '.FL_verbaUN = DTReader.GetValue(26),
                    '.FL_verbaValor = DTReader.GetValue(18),
                    '.FL_dataLiberacao = DTReader.GetValue(19),
                    '.FL_dataPagamento = DataLatina(DTReader.GetValue(20)),
                    '.FL_verbaCreditoTotal = decCreditoCol,
                    '.FL_verbaDebitoTotal = decDebitoCol,
                    '.FL_liquido = decLiquidoCol,
                    '.Processo = DTReader.GetValue(25),
                    '.ColBanco = DTReader.GetValue(27),
                    '.ColBancoAgencia = DTReader.GetValue(28),
                    '.ColBancoAgenciaContaCorrente = DTReader.GetValue(29),
                    '.ColBancoAgenciaContaCorrenteDigito = DTReader.GetValue(30),
                    '.ColPIX = IIf(IsDBNull(DTReader.GetValue(31)), "", DTReader.GetValue(31)),
                    '.ColPixID = DTReader.GetValue(32),
                    '}
                    ')

                End While
            End If
        Catch ex As Exception

            MsgBox("Problemas Na Leitura CP")

        End Try



        Conn.Close()


        Return lista

    End Function

End Class

