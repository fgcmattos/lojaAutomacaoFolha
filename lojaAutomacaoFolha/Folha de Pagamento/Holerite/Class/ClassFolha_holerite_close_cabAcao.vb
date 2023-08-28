Imports MySql.Data.MySqlClient

Public Class ClassFolha_holerite_close_cabAcao

    Public Shared Function GetHoleriteCabDB(referencia) As List(Of ClassFolha_holerite_close_cab)
        Dim emp As List(Of empregador) = EmpregadorAcao.GetEmpregadorRescisao()

        Dim strReferencia As String = referencia

        Dim strRefMesAno As String = strReferencia.Substring(4, 2) & "/" & strReferencia.Substring(0, 4)


        Dim Query As String = ""

        Query += "Select "
        Query += "id_fcab"                                  '0
        Query += ",lpad(fcCol_keyCol,6,'0')"     ' LPAD('1234567', 8, '0');
        Query += ",fcCol_nome"                              '2
        Query += ",fcCol_cbo"                               '3
        Query += ",fcCol_Cargo"                             '4
        Query += ",fcCol_ref"                               '5
        Query += ",fcCol_local"                             '6
        Query += ",fcCol_setor"                             '7
        Query += ",fcCol_SB"                                '8
        Query += ",fcCol_sbINSS"                            '9
        Query += ",fcCol_sbFGTS"                            '10
        Query += ",fcCol_sbIRRF"                            '11
        Query += ",fcCol_IRRFfaixa"                         '12
        Query += ",fcCol_INSScol"                           '13
        Query += ",fcCol_FGTScol"                           '14
        Query += ",if(isnull(fcCol_diastrabalhadosNaReferencia),0,fcCol_diastrabalhadosNaReferencia)" '15
        Query += ",fcCol_IRcol"                             '16
        Query += ",fcCol_IRRFdesconto"                      '17
        Query += ",fcCol_IRRFdep"                           '18
        Query += ",fcCol_sfDep"                             '19
        Query += ",fcCol_Tdebitos"                          '20
        Query += ",fcCol_Tcreditos"                         '21
        Query += ",fcCol_Tliquido"                          '22
        Query += ",fcCol_hora_trabalhada"                   '23
        Query += ",fcCol_hora_trabalhada_valor"             '24
        Query += ",fcCol_dia_trabalhado_valor"              '25
        Query += ",fcCol_dias_uteis"                        '26
        Query += ",fcCol_descansos_ref"                     '27
        Query += ",fcCol_Ferias_proporcional"               '28
        Query += ",fcCol_ferias_terco"                      '29
        Query += ",fcCol_decimo_terceiro"                   '30
        Query += ",fcCol_descanso_semanal"                  '31
        Query += ",fcCol_INSSpercentualTotal"               '32
        Query += ",fcCol_INSSpatronalValor"                 '33
        Query += ",fcCol_INSSvalorTotal"                    '34
        Query += ",fcCol_total_INSSpatronal_FGTSreferencia" '35
        Query += ",fcCol_referencia_total"                  '36
        Query += ",fcCol_colaborador_custo_total_referencia" '37
        Query += ",fcCol_admissao_data"                     '38
        Query += ",fcCol_admissao_referencia"               '39
        Query += ",fcCol_referencia_provisionado"           '40
        Query += ",fcCol_diasTrabalhadosNaReferencia"       '41
        Query += ",fcCol_salario_variavel_Base"             '42
        Query += ",fcCol_salario_variavel_valor"            '43
        Query += " from folha_close_cab"
        Query += " where fcCol_ref = '" & strReferencia & "'"
        Query += " order by  fcCol_keyCol"

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassFolha_holerite_close_cab)

        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then


            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lista.Add(New ClassFolha_holerite_close_cab() With
                    {
                    .Class_id_fcab = DTReader.GetValue(0),
                    .Class_keyCol = DTReader.GetValue(1),
                    .Class_nome = DTReader.GetValue(2),
                    .Class_cbo = DTReader.GetValue(3),
                    .Class_Cargo = DTReader.GetValue(4),
                    .Class_ref = DTReader.GetValue(5),
                    .Class_ref_Mes_Ano = strRefMesAno,
                    .Class_local = DTReader.GetValue(6),
                    .Class_setor = DTReader.GetValue(7),
                    .Class_SB = DTReader.GetValue(8),
                    .Class_sbINSS = DTReader.GetValue(9),
                    .Class_sbFGTS = DTReader.GetValue(10),
                    .Class_sbIRRF = DTReader.GetValue(11),
                    .Class_IRRFfaixa = DTReader.GetValue(12),
                    .Class_INSScol = DTReader.GetValue(13),
                    .Class_FGTScol = DTReader.GetValue(14),
                    .Class_dias_trabalhadosNaReferencia = DTReader.GetValue(15),
                    .Class_IRcol = DTReader.GetValue(16),
                    .Class_IRRFdesconto = DTReader.GetValue(17),
                    .Class_IRRFdep = DTReader.GetValue(18),
                    .Class_sfDep = DTReader.GetValue(19),
                    .Class_Tdebitos = DTReader.GetValue(20),
                    .Class_Tcreditos = DTReader.GetValue(21),
                    .Class_Tliquido = DTReader.GetValue(22),
                    .Class_hora_trabalhada = DTReader.GetValue(23),
                    .Class_valor_hora_trabalhada = DTReader.GetValue(24),
                    .Class_valor_dia_trabalhado = DTReader.GetValue(25),
                    .Class_dias_uteis = DTReader.GetValue(26),
                    .Class_descansos_ref = DTReader.GetValue(27),
                    .Class_Ferias_proporcional = DTReader.GetValue(28),
                    .Class_ferias_terco = DTReader.GetValue(29),
                    .Class_decimo_terceiro = DTReader.GetValue(30),
                    .Class_descanso_semanal = DTReader.GetValue(31),
                    .Class_INSSpercentualTotal = DTReader.GetValue(32),
                    .Class_INSSpatronalValor = DTReader.GetValue(33),
                    .Class_INSSvalorTotal = DTReader.GetValue(34),
                    .Class_total_INSSpatronal_FGTSreferencia = DTReader.GetValue(35),
                    .Class_referencia_total = DTReader.GetValue(36),
                    .Class_colaborador_custo_total_referencia = DTReader.GetValue(37),
                    .Class_admissao_data = DTReader.GetValue(38),
                    .Class_admissao_referencia = DTReader.GetValue(39),
                    .Class_referencia_provisionado = DTReader.GetValue(40),
                    .Class_diasTrabalhadosNaReferencia = DTReader.GetValue(41),
                    .Class_emp_RazaoSocial = emp(0).RazaoSocial,
                    .Class_emp_CNPJ = emp(0).Cnpj,
                    .Class_emp_Endereco = emp(0).EnderecoCompleto,
                    .Class_sbDRSvariavel = DTReader.GetValue(42),
                    .Class_DSRvariavel = DTReader.GetValue(43)
                    }
                    )
                End While

            Catch ex As Exception

                MsgBox("Problemas com ClassFolha_holerite_close_cab!")

            End Try

        End If

        Conn.Close()

        Return lista

    End Function

End Class
