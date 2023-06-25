Imports MySql.Data.MySqlClient

Public Class FrmFolhaEfetivacao
    Public Shared INSS As List(Of INSStabela) = INSStabelaAcao.GetINSStabelaSQL()
    Public Shared IR As List(Of irTabela) = irTabelaAcao.GetIRtabelaSQL()
    Dim hol As New FolhaHolerite
    Dim intUltimo_Reg_Cab As Integer
    Dim oi As New MsgShow
    Private Sub FrmFolhaEfetivacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = Me.Text
    End Sub

    Private Sub BtoCalcular_Click(sender As Object, e As EventArgs) Handles BtoCalcular.Click
        Dim query As String = ""
        Dim strReferencia As String
        Dim strCodKey As String = Trim(TextColaboradorKey.Text)


        strReferencia = achaMes(CmbReferencia.Text.Substring(0, InStr(CmbReferencia.Text, "/") - 1))
        strReferencia = CmbReferencia.Text.Substring(InStr(CmbReferencia.Text, "/")) + strReferencia

        If folhaFechada(strReferencia) Then

            With oi
                .msg = "Referência já calculada, Quer novo cálculo?"
                .style = vbYesNo
                .resposta = MsgBox(.msg, .style, .title)
                If .resposta <> 6 Then
                    Exit Sub
                Else

                    query = "delete From folha_close_Cab;"
                    query += "delete From folha_close_corpo;"
                    gravaSQL(query)
                    query = ""

                End If



            End With

        End If

        Dim emp As List(Of empregador) = EmpregadorAcao.GetEmpregadorRescisao()

        Dim colHolerite As List(Of ClassColaborador_Holerite) = ClassColaborador_HoleriteAcao.getColaboradoresAptosDB()

        Dim incremento As Integer = 0

        For ind = 0 To colHolerite.Count - 1

            'Dim VR As List(Of FolHolLanc) = FolHolLancAcao.GetVariaveisSQL(colHolerite(ind).keyCol, strReferencia)



            ListBox1.Items.Clear()

            With hol

                .Key = colHolerite(ind).keyCol
                .ColNome = colHolerite(ind).Nome
                .Referencia_mes_ano = strReferencia                'AAAAMM
                .Referencia_mes_ano_tela = CmbReferencia.Text      'MM/AAAA
                .SB = colHolerite(ind).SalarioAtual
                .ColIRdependentes = colHolerite(ind).DependentesIR
                .HorasTrabalhadasSemana = colHolerite(ind).colaboradorHorasTrabalhadasSemana
                .diasDeDescansoSemanal = colHolerite(ind).colaboradorDiasDescansoSemanaas
                .AdmissaoData = colHolerite(ind).colaboradorAdmissao
                .AdmissaoReferencia = colHolerite(ind).colaboradorAdmissaoReferencia
                .INSSpercentualTotal = 0.2
                .colCBO = colHolerite(ind).colaboradorCBO
                .colCargo = colHolerite(ind).colaboradorFuncao
                .colSetor = colHolerite(ind).colaboradorSetor
                .colSFdependentes = colHolerite(ind).colaboradorDependenteSF
                .colHoleriteLocal = emp(0).holeriteLocal
                .Emp_razaoSocial = emp(0).RazaoSocial
                .Emp_CNPJ = CNPJcolocaMascara(emp(0).Cnpj)
                .Emp_enderecoCompleto = emp(0).EnderecoCompleto

            End With

            ParametrosDaReferenciaCarrega(strReferencia, hol)

            ParametrosBasicosCalculo(strReferencia, hol)

            Dim Vaut As List(Of FolHolLanc) = FolHolLancAcao.GetViaveisAutomaticas(hol.Key)

            Dim VR As List(Of FolHolLanc) = FolHolLancAcao.GetVariaveisSQL(colHolerite(ind).keyCol, strReferencia)

            IncrementoVariaveisAutomaticas(Vaut, VR, hol)                     ' Variaveis serao incrementadas do objeto Vaut para o
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  objeto Hol
            VR.Sort(Function(x, y) x.Variavel.CompareTo(y.Variavel))

            Dim baseFGTS As Decimal = 0
            Dim baseINSS As Decimal = 0
            Dim baseIR As Decimal = 0
            Dim baseDSRvariavel As Decimal = 0
            Dim SalVariavel As Decimal = 0
            Dim intFimDoLoop As Integer = VR.Count - 1
            Dim intContaExcesso As Integer = 0


            Dim a As String
            For incremento = 0 To intFimDoLoop

                SalVariavel = 0
                a = VR(incremento).Variavel

                If VR(incremento).Unidade = "R$" And VR(incremento).Valor = 0 Then

                    VR(incremento).Valor = VR(incremento).Qto

                End If

                If VR(incremento).Unidade = "%" Then VR(incremento).Valor = Int(((VR(incremento).Qto / 100) * hol.SBEfetivo) * 100) / 100

                If VR(incremento).TipoFinanceiro = "D" Then

                    VR(incremento).Valor = -Math.Abs(VR(incremento).Valor)

                End If

                Select Case VR(incremento).Calculo

                    Case 1
                        'SALARIO

                        VR(incremento).Valor = hol.SBEfetivo
                        VR(incremento).Qto = hol.DTmes

                    Case 20

                        VR(incremento).Valor = Math.Round((hol.valorHoraTrabalhada * VR(incremento).Qto) * (1 + (VR(incremento).Calculo_parametro / 100)), 2)

                End Select

                If VR(incremento).Base_fgts Then baseFGTS += VR(incremento).Valor
                If VR(incremento).Base_INSS Then baseINSS += VR(incremento).Valor
                If VR(incremento).Base_ir Then baseIR += VR(incremento).Valor
                If VR(incremento).Calculo = 20 Then baseDSRvariavel += VR(incremento).Valor   ' Hora extra

            Next

            incremento -= 1

            If baseDSRvariavel > 0 Then

                Dim decDsrValor As Decimal = Int(((baseDSRvariavel / hol.PPC_dias_uteis_ref) * hol.PPC_descansos_totais_do_mes) * 100) / 100

                addVR(hol, "0021", "DSR SALARIO VARIAVEL", "R$", True, True, True, VR, "C", decDsrValor, 0, 0, 0)

                hol.DSR_salario_variavel_base = baseDSRvariavel
                hol.DSR_salario_variavel_valor = decDsrValor

                incremento += 1

            End If

            If VR(incremento).Base_fgts Then baseFGTS += VR(incremento).Valor
            If VR(incremento).Base_INSS Then baseINSS += VR(incremento).Valor
            If VR(incremento).Base_ir Then baseIR += VR(incremento).Valor

            With hol
                ' Calculo do INSS
                '-----------------------------------
                .SBinss = baseINSS                                      '(.SB + .V1valor + .V2valor + .V3valor)
                .INSSvalor = INSScalculo(.SBinss)
                addVR(hol, "0002", "INSS", "R$", False, False, True, VR, "D", 0, .INSSvalor, 2, 0)
                '------------------------------------

                ' Calculo da base do FGTS
                '------------------------------------
                .SBfgts = baseFGTS
                .FGTSvalor = -Int((.SBfgts * 0.08) * 100) / 100

                '----------------------------------------------

                'Calculo IR
                .SBir = baseIR - .INSSvalor                     '.SB + .V1valor + .V2valor + .V3valor + .INSSvalor
                .IRvalor = IRcalculo(.SBir)
                If Math.Abs(.IRvalor) > 10 Then
                    addVR(hol, "0100", "IR RETIDO NA FONTE", "R$", False, False, False, VR, "D", 0, .IRvalor, 0, 0)
                End If

                '=======================================
                Dim numTotalCreditos As Decimal = 0
                Dim numTotalDebitos As Decimal = 0
                Dim numLiquido As Decimal = 0
                For i = 0 To VR.Count - 1
                    If VR(i).Variavel = "0002" Then VR(i).Valor = - .INSSvalor
                    If VR(i).Variavel = "0100" Then VR(i).Valor = - .IRvalor
                    If VR(i).TipoFinanceiro = "C" Then numTotalCreditos += VR(i).Valor Else numTotalDebitos += -VR(i).Valor
                Next

                ' Calculo dos compromissos gerados pela folha 
                .INSSvalorTotal = Int((.SBEfetivo * .INSSpercentualTotal) * 100) / 100
                .INSSpatronalValor = .INSSvalorTotal + .INSSvalor
                .pagamentoGeradoNaCompetencia = (.INSSpatronalValor + .FGTSvalor)
                .FeriasRef = Int((.SBfgts / 12) * 100) / 100
                .TercoFeriasRef = Int(((.SBfgts / 3) / 12) * 100) / 100
                .DecimoTerceiroRef = Int((.SBfgts / 12) * 100) / 100
                .provisionadoRef = .FeriasRef + .TercoFeriasRef + .DecimoTerceiroRef
                .totalReferencia = .pagamentoGeradoNaCompetencia + .SBfgts
                .CustoTotalColaboradorNaReferencia = .pagamentoGeradoNaCompetencia + .provisionadoRef + .SBfgts


                numLiquido = numTotalCreditos - numTotalDebitos

                .Tliquido = numLiquido
                .Tcredito = numTotalCreditos
                .Tdebito = numTotalDebitos

                VR.Sort(Function(x, y) x.Variavel.CompareTo(y.Variavel))
                VR.Sort(Function(x, y) x.TipoFinanceiro.CompareTo(y.TipoFinanceiro))

                ListBox1.Items.Add("Chave : " + .Key.ToString + espacoEsquerda("MES/ANO : " + .Referencia_mes_ano_tela, 50, 2))
                ListBox1.Items.Add("Nome : " + .ColNome)
                ListBox1.Items.Add("Dependentes IR : " + .ColIRdependentes.ToString)
                ListBox1.Items.Add("Salario Base : " + numeroLatino(.SB, 10, True))
                ListBox1.Items.Add("")
                Dim strUnidade As String = ""
                Dim strQTO As String = ""
                Dim strValor As String = ""
                Dim strDescricao As String = ""
                FolhaGravaCabecario(hol)
                For i = 0 To VR.Count - 1

                    If VR(i).Valor <> 0 Then

                        strUnidade = VR(i).Unidade
                        strQTO = VR(i).Qto

                        If strUnidade = "R$" Then

                            strQTO = "       -"

                            strUnidade = Space(8) & "R$"

                        Else

                            strQTO = espacoEsquerda(VR(i).Qto.ToString, 8, 2)

                            strUnidade = espacoEsquerda(VR(i).Unidade, 10, 1)

                        End If



                        strValor = numeroLatino(VR(i).Valor, 13, False)

                        strDescricao = espacoEsquerda(VR(i).Descricao, 27, 1)

                        If strQTO = "0,00" Then strQTO = ""

                        ListBox1.Items.Add(VR(i).Variavel + " - " + strDescricao + strQTO + " " + strUnidade + strValor) ' espacoEsquerda(numeroLatino(VR(i).Valor, 13, False), 9, 2))

                        If VR(i).Unidade = "R$" Or VR(i).Qto < 0 Then
                            VR(i).Qto = 0
                        End If

                        FolhaGravaCorpo(VR(i).Variavel, Trim(strDescricao), VR(i).Qto, Trim(strUnidade), Math.Abs(VR(i).Valor), IIf(VR(i).Base_INSS, "S", "N"), IIf(VR(i).Base_fgts, "S", "N"), IIf(VR(i).Base_ir, "S", "N"), VR(i).TipoFinanceiro, VR(i).ValorBase, VR(i).DataOcorrencia, VR(i).Historico)

                    End If

                Next

                'numLiquido = numTotalCreditos + numTotalDebito
                ListBox1.Items.Add("=================================================================")
                ListBox1.Items.Add("Total de Créditos : " + numeroLatino(numTotalCreditos, 13, True))
                ListBox1.Items.Add("Total de Debitos  : " + numeroLatino(numTotalDebitos, 13, True))
                ListBox1.Items.Add("Total líquido     : " + numeroLatino(numLiquido, 13, True))
                ListBox1.Items.Add("=================================================================")

                ListBox1.Items.Add("Parametros usados no calculo")
                ListBox1.Items.Add("-----------------------------------------------------------------")
                ListBox1.Items.Add("Salario Base FGTS -------------: " + espacoEsquerda(numeroLatino(.SBfgts, 15, True), 15, 1))
                ListBox1.Items.Add("Salario Base INSS -------------: " + espacoEsquerda(numeroLatino(.SBinss, 15, True), 15, 1))
                ListBox1.Items.Add("Salario Base IR ---------------: " + espacoEsquerda(numeroLatino(.SBir, 15, True), 15, 1))
                ListBox1.Items.Add("FGTS recolhido do mes ---------: " + espacoEsquerda(numeroLatino(.FGTSvalor, 15, True), 15, 1))
                ListBox1.Items.Add("Valor hora contratado ---------: " + espacoEsquerda(numeroLatino(.valorHoraTrabalhada, 15, True), 15, 1))
                ListBox1.Items.Add("Valor dia contratado ----------: " + espacoEsquerda(numeroLatino(.valorDiaTabalhado, 15, True), 15, 1))
                ListBox1.Items.Add("Horas contratadas por a Semana : " + espacoEsquerda(.HorasTrabalhadasSemana, 15, 1))
                ListBox1.Items.Add("Dias  de descanso por Semana --: " + espacoEsquerda(.diasDeDescansoSemanal, 15, 1))
                ListBox1.Items.Add("Horas contradas por dia -------: " + espacoEsquerda(.HorasTrabalhadasDia, 15, 1))
                ListBox1.Items.Add("Horas contratadas por mes -----: " + espacoEsquerda(.horasTrabalhadasMes, 15, 1))

                ListBox1.Items.Add("Data da Admissão --------------: " + espacoEsquerda(dataLatina(.AdmissaoData), 15, 1))


                Dim strAno As String = .AdmissaoData.Substring(0, 4)
                Dim strMes As String = .AdmissaoData.Substring(4, 2)
                Dim strDia As String = .AdmissaoData.Substring(6, 2)
                Dim strDataNow As String = DataNow().Substring(0, 8)
                Dim strAnoNow As String = strDataNow.Substring(0, 4)
                Dim strMesNow As String = strDataNow.Substring(4, 2)
                Dim strDiaNow As String = strDataNow.Substring(6, 2)

                ListBox1.Items.Add("Tempo de Empresa --------------: " + espacoEsquerda(calculoDaIdade(strAno, strMes, strDia, strAnoNow, strMesNow, strDiaNow), 15, 1))
                ListBox1.Items.Add(espacoEsquerda("Calculado em: " & dataLatina(strDataNow), 57, 2))

                ListBox1.Items.Add("=================================================================")

                ListBox1.Items.Add("Compromissos G E R A D O S")
                ListBox1.Items.Add("-----------------------------------------------------------------")
                ListBox1.Items.Add(espacoEsquerda("I N S S", 15, 2) & espacoEsquerda("I N S S", 15, 2) & espacoEsquerda("I N S S", 15, 2))
                ListBox1.Items.Add(espacoEsquerda("Colaborador", 20, 3) & espacoEsquerda("Patronal", 11, 2) & espacoEsquerda("Geral (Guia1)", 20, 2))
                ListBox1.Items.Add(numeroLatino(.INSSvalor, 15, True) & numeroLatino(.INSSpatronalValor, 15, True) & numeroLatino(.INSSvalorTotal, 15, True))
                ListBox1.Items.Add("-----------------------------------------------------------------")
                ListBox1.Items.Add(espacoEsquerda("FGTS", 15, 1) & numeroLatino(.FGTSvalor, 15, True))
                ListBox1.Items.Add("-----------------------------------------------------------------")
                ListBox1.Items.Add(espacoEsquerda("Total Custos Gerados:", 15, 1) & numeroLatino(.pagamentoGeradoNaCompetencia, 15, True) & espacoEsquerda("(INSS Patronal + FGTS)", 24, 2))
                ListBox1.Items.Add("=================================================================")
                ListBox1.Items.Add(espacoEsquerda("Total pag. Ref.:", 15, True) & numeroLatino(.totalReferencia, 15, True))
                ListBox1.Items.Add("-----------------------------------------------------------------")

                ListBox1.Items.Add("Compromissos P R O V I S I O N A D O S")
                ListBox1.Items.Add("-----------------------------------------------------------------")
                ListBox1.Items.Add(espacoEsquerda("F É R I A S", 20, 3) & espacoEsquerda("1/3  F É R I A S", 12, 3) & espacoEsquerda("13o. SALARIO", 20, 3))
                ListBox1.Items.Add(numeroLatino(.FeriasRef, 15, True) & numeroLatino(.TercoFeriasRef, 20, True) & numeroLatino(.DecimoTerceiroRef, 16, True))
                ListBox1.Items.Add(espacoEsquerda("Provisionamento da  Ref.:", 15, 1) & numeroLatino(.provisionadoRef, 15, True))
                ListBox1.Items.Add("-----------------------------------------------------------------")

                ListBox1.Items.Add("Custo Total Colaborador :" & numeroLatino(.CustoTotalColaboradorNaReferencia, 15, True))
                '=======================================
            End With

            'FolhaGravaCabecario(hol)

            MsgBox("continua " & ind)
        Next
    End Sub


    Public Function FolhaGravaCabecario(holerite As Object)

        Dim Query As String = ""
        With holerite
            Query = "insert into folha_close_cab "
            Query += "("
            Query += "fcCol_keyCol"
            Query += ",fcCol_nome"
            Query += ",fcCol_local"
            Query += ",fcCol_ref"
            Query += ",fcCol_IRRFdep"
            Query += ",fcCol_sfDep"
            Query += ",fcCol_cbo"
            Query += ",fcCol_Cargo"
            Query += ",fcCol_setor"
            Query += ",fcCol_SB"
            Query += ",fcCol_sbINSS"
            Query += ",fcCol_sbFGTS"
            Query += ",fcCol_sbIRRF"
            Query += ",fcCol_IRRFfaixa"
            Query += ",fcCol_IRRFdesconto"
            Query += ",fcCol_FGTScol"
            Query += ",fcCol_INSScol"
            Query += ",fcCol_INSSpercentualTotal"
            Query += ",fcCol_INSSpatronalValor"
            Query += ",fcCol_INSSvalorTotal"
            Query += ",fcCol_total_INSSpatronal_FGTSreferencia"
            Query += ",fcCol_referencia_total"
            Query += ",fcCol_colaborador_custo_total_referencia"
            Query += ",fcCol_admissao_data"
            Query += ",fcCol_admissao_referencia"
            Query += ",fcCol_referencia_provisionado"
            Query += ",fcCol_diasTrabalhadosNaReferencia"
            Query += ",fcCol_IRcol"
            Query += ",fcCol_Tdebitos"
            Query += ",fcCol_Tcreditos"
            Query += ",fcCol_Tliquido"
            Query += ",fcCol_hora_trabalhada"
            Query += ",fcCol_Descanso_Semanal"
            Query += ",fcCol_hora_trabalhada_valor"
            Query += ",fcCol_dia_trabalhado_valor"
            Query += ",fcCol_Ferias_proporcional"
            Query += ",fcCol_ferias_terco"
            Query += ",fcCol_decimo_terceiro"
            Query += ",fcCol_descansos_ref"
            Query += ",fcCol_dias_uteis"
            Query += ",fcCol_emp_RazaoSocial"
            Query += ",fcCol_emp_CNPJ"
            Query += ",fcCol_emp_endereco"
            Query += ",fcCol_salario_variavel_Base"
            Query += ",fcCol_salario_variavel_valor"
            Query += ")"
            Query += " values "
            Query += "("
            Query += .key.ToString
            Query += ",'" & .colNome & "'"
            Query += ",'" & .colHoleriteLocal & "'"
            Query += ",'" & .Referencia_mes_ano & "'"
            Query += "," & .colIRdependentes
            Query += "," & .colSFdependentes
            Query += ",'" & .colCBO & "'"
            Query += ",'" & .colCargo & "'"
            Query += ",'" & .colSetor & "'"
            Query += "," & MoneyUSA(.SB)
            Query += "," & MoneyUSA(.SBinss)
            Query += "," & MoneyUSA(.SBfgts)
            Query += "," & MoneyUSA(.SBir)
            Query += "," & .IRfaixa
            Query += "," & MoneyUSA(Math.Abs(.IRdesconto))
            Query += "," & MoneyUSA(Math.Abs(.FGTSvalor))
            Query += "," & MoneyUSA(Math.Abs(.INSSvalor))
            Query += "," & MoneyUSA(.INSSpercentualTotal)
            Query += "," & MoneyUSA(.INSSpatronalValor)
            Query += "," & MoneyUSA(Math.Abs(.inssValorTotal))
            Query += "," & MoneyUSA(.pagamentoGeradoNaCompetencia)
            Query += "," & MoneyUSA(.totalReferencia)
            Query += "," & MoneyUSA(.CustoTotalColaboradorNaReferencia)
            Query += ",'" & .AdmissaoData & "'"
            Query += ",'" & .AdmissaoReferencia & "'"
            Query += "," & MoneyUSA(.provisionadoRef)
            Query += "," & .DiasTrabalhadosNareferencia
            Query += "," & MoneyUSA(.IRvalor)
            Query += "," & MoneyUSA(Math.Abs(.Tdebito))
            Query += "," & MoneyUSA(.Tcredito)
            Query += "," & MoneyUSA(.Tliquido)
            Query += "," & .HorasTrabalhadasDia
            Query += "," & .diasDeDescansoSemanal
            Query += "," & MoneyUSA(.valorHoraTrabalhada)
            Query += "," & MoneyUSA(.valorDiaTabalhado)
            Query += "," & MoneyUSA(.FeriasRef)
            Query += "," & MoneyUSA(.TercoFeriasRef)
            Query += "," & MoneyUSA(.DecimoTerceiroRef)
            Query += "," & .PPC_descansos_totais_do_mes
            Query += "," & .PPC_dias_uteis_ref
            Query += ",'" & .Emp_razaoSocial & "'"
            Query += ",'" & .Emp_CNPJ & "'"
            Query += ",'" & .Emp_enderecoCompleto & "'"
            Query += "," & MoneyUSA(.DSR_salario_variavel_base)
            Query += "," & MoneyUSA(.DSR_salario_variavel_valor)
            Query += ");"
            Query += "Select MAX(ID_fcab) FROM folha_close_cab;"

            intUltimo_Reg_Cab = gravaSQLretorno(Query)


        End With
    End Function

    'FolhaGravaCorpo(VR(i).Variavel, Trim(strDescricao), VR(i).Qto, Trim(strUnidade), Math.Abs(VR(i).Valor), IIf(VR(i).Base_INSS, "S", "N"), IIf(VR(i).Base_fgts, "S", "N"), IIf(VR(i).Base_ir, "S", "N"), VR(i).TipoFinanceiro, VR(i).ValorBase, VR(i).DataOcorrencia, VR(i).Historico)

    Public Function FolhaGravaCorpo(strRubrica As String, strRubricaDescricao As String, strQTO As String, strUN As String, strValor As String, strBaseInss As String, strBaseFGTS As String, strBaseIR As String, strTipoFinanceiro As String, strValorBase As String, strDataOcorrencia As String, strHistorico As String)

        Dim Query As String = ""
        Query = "insert into folha_close_corpo("
        Query += "FcloseCorpo_keyCol"
        Query += ",FcloseCorpo_referencia"
        Query += ",FcloseCorpo_rubrica"
        Query += ",FcloseCorpo_descricao"
        Query += ",FcloseCorpo_QTO"
        Query += ",FcloseCorpo_UN"
        Query += ",FcloseCorpo_usuario"
        Query += ",FcloseCorpo_base_INSS"
        Query += ",FcloseCorpo_base_FGTS"
        Query += ",FcloseCorpo_base_IR"
        Query += ",FcloseCorpo_tipo_financeiro"
        Query += ",FcloseCorpo_valor"
        Query += ",FcloseCorpo_valor_base"
        Query += ",FcloseCorpo_data_ocorrencia"
        Query += ",FcloseCorpo_historico"
        Query += ",FcloseCorpo_debito_holerite"
        Query += ",FcloseCorpo_credito_holerite"
        Query += ",ID_folha_close_cab"
        Query += ")"
        Query += " values ("
        Query += hol.Key.ToString
        Query += ",'" & hol.Referencia_mes_ano & "'"
        Query += ",'" & strRubrica & "'"
        Query += ",'" & strRubricaDescricao & "'"
        Query += "," & MoneyUSA(strQTO)
        Query += ",'" & strUN & "'"
        Query += "," & 1
        Query += ",'" & strBaseInss & "'"
        Query += ",'" & strBaseFGTS & "'"
        Query += ",'" & strBaseIR & "'"
        Query += ",'" & strTipoFinanceiro & "'"
        Query += "," & MoneyUSA(strValor)
        Query += "," & MoneyUSA(strValorBase)
        Query += ",'" & MoneyUSA(strDataOcorrencia) & "'"
        Query += ",'" & strHistorico & "'"
        If strTipoFinanceiro = "D" Then
            Query += "," & MoneyUSA(strValor)
            Query += ",0"
        Else
            Query += ",0"
            Query += "," & MoneyUSA(strValor)
        End If
        Query += "," & intUltimo_Reg_Cab
        Query += ");"


        gravaSQL(Query)

    End Function
    Public Function DataNow() As String

        Dim Query As String = "select DATE_FORMAT(now(), '%Y%m%d%H%i%s')"
        If OpenDB() Then


            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                DataNow = DTReader(0)

            Catch ex As Exception
                MsgBox("Problemas na comunicacao")
                DataNow = "Erro!"
            End Try

            Conn.Close()
            Return DataNow
        End If
    End Function

    Public Function HoraExtra(tempo As Decimal, acr As Decimal) As Decimal

        'horaExtra = Int((hol.hora_propporcional_ref_valor * tempo) * (1 + (acrescimo / 100)) * 100) / 100

        Dim DecHoraExtra, DecAcrescimo As Decimal

        DecAcrescimo = acr

        DecHoraExtra = (hol.valorHoraTrabalhada * tempo) * (1 + (DecAcrescimo / 100))

        Return Math.Round(DecHoraExtra, 2)

    End Function
    Public Function falta(SalarioBase As Decimal, tempo As Integer) As Decimal

        Dim SBdia As Decimal = hol.valorDiaTabalhado
        falta = SBdia * tempo

    End Function

    Private Function INSScalculo(baseInss As Decimal)

        Dim numSomaINISS As Decimal = 0

        For i = 0 To INSS.Count - 1
            If INSS(i).Limite < baseInss Then

                numSomaINISS += INSS(i).Valor

            Else

                numSomaINISS += ((baseInss - INSS(i - 1).Limite)) * (INSS(i).Taxa / 100)

                Exit For

            End If

        Next
        Return Int(numSomaINISS * 100) / 100

    End Function

    Private Function IRcalculo(baseIR As Decimal)


        Dim numSomaIR As Decimal = 0

        If baseIR > IR(1).Limite Then
            numSomaIR = IR(0).Valor
        Else
            hol.IRFaixa = 0
            Return 0
        End If
        If baseIR > IR(2).Limite Then

            numSomaIR = IR(1).Valor
            If baseIR > IR(3).Limite Then
                numSomaIR += IR(2).Valor
                If baseIR > IR(4).Limite Then
                    hol.IRFaixa = 4
                    numSomaIR += IR(3).Valor
                    numSomaIR += (baseIR - IR(4).Limite) * (IR(4).Taxa / 100)
                Else
                    hol.IRFaixa = 3
                    numSomaIR += (baseIR - IR(3).Limite) * (IR(3).Taxa / 100)
                    numSomaIR = Int(numSomaIR * 100) / 100
                End If
            Else
                hol.IRFaixa = 2
                numSomaIR += (baseIR - IR(2).Limite) * (IR(2).Taxa / 100)
                numSomaIR = Int(numSomaIR * 100) / 100
            End If

        Else
            hol.IRFaixa = 1
            numSomaIR = (baseIR - IR(1).Limite) * (IR(1).Taxa / 100)
            numSomaIR = Int(numSomaIR * 100) / 100

        End If



        If numSomaIR < 10 Then

            numSomaIR = 0

        End If


        Return numSomaIR

    End Function
    Private Function DSRhoraExtra(nHora As Decimal, strAnoMes As String)

        'DSR = (valor total das horas extras no mês / dias úteis no mês) x domingos e feriados do mês.

        With hol

            DSRhoraExtra = Int(((nHora / hol.PPC_dias_uteis_ref) * .PPC_descansos_totais_do_mes) * 100) / 100

        End With

    End Function

    ''''Private Function addVR(variavel As String, descricao As String, unidade As String, b_INSS As Boolean, b_fgts As Boolean, b_IR As Boolean, vr As Object, t_financeiro As String, VALOR As Decimal, QTO As Decimal)
    ''''    vr.Add(New FolHolLanc() With
    '''' {
    ''''        .referencia = hol.Referencia_mes_ano,
    ''''        .Col_key = hol.Key,
    ''''        .Variavel = variavel,
    ''''        .Descricao = descricao,
    ''''        .Qto = QTO,
    ''''        .Unidade = unidade,
    ''''        .Base_INSS = b_INSS,
    ''''        .Base_fgts = b_fgts,
    ''''        .Base_ir = b_IR,
    ''''        .Valor = VALOR,
    ''''        .TipoFinanceiro = t_financeiro
    '''' }
    '''' )
    ''''End Function

    Private Sub BtnIprintHolerite_Click(sender As Object, e As EventArgs) Handles BtnIprintHolerite.Click

        Dim strReferencia As String



        '''FrmFolhaHoleriteClose_rel.Show()
        FrmFolhaHoleriteClose_Final_rel.show()

    End Sub
End Class