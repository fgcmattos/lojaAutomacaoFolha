Imports MySql.Data.MySqlClient

Public Class frmFolCalPreliminarIndividual

    Public Shared INSS As List(Of INSStabela) = INSStabelaAcao.GetINSStabelaSQL()
    Public Shared IR As List(Of irTabela) = irTabelaAcao.GetIRtabelaSQL()
    Dim Hol As New FolhaHolerite
    Private Sub BtoCalcular_Click(sender As Object, e As EventArgs) Handles BtoCalcular.Click

        Dim strReferencia As String

        Dim strCodKey As String = Trim(TextColaboradorKey.Text)

        ListBox1.Items.Clear()

        strReferencia = achaMes(CmbReferencia.Text.Substring(0, InStr(CmbReferencia.Text, "/") - 1))

        strReferencia = CmbReferencia.Text.Substring(InStr(CmbReferencia.Text, "/")) + strReferencia

        ColaboradorCarrega(Hol, strCodKey, strReferencia, Me.CmbReferencia.Text)                ' Carrega atributos do colaborador no objeto HOL

        ParametrosDaReferenciaCarrega(strReferencia, Hol)                ' Carrega atributos da Referencia no objeto HOL

        ParametrosBasicosCalculo(strReferencia, Hol)

        Dim Vaut As List(Of FolHolLanc) = FolHolLancAcao.GetViaveisAutomaticas(Hol.Key)

        Dim VR As List(Of FolHolLanc) = FolHolLancAcao.GetVariaveisSQL(strCodKey, strReferencia)

        IncrementoVariaveisAutomaticas(Vaut, VR, Hol)                     ' Variaveis serao incrementadas do objeto Vaut para o
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  objeto Hol

        VR.Sort(Function(x, y) x.Variavel.CompareTo(y.Variavel))

        Dim baseFGTS As Decimal = 0
        Dim baseINSS As Decimal = 0
        Dim baseIR As Decimal = 0
        Dim baseDSRvariavel As Decimal = 0
        Dim SalVariavel As Decimal = 0
        Dim intFimDoLoop As Integer = VR.Count - 1
        Dim intContaExcesso As Integer = 0
        Dim incremento As Integer = 0

        For incremento = 0 To intFimDoLoop

            If VR(incremento).Unidade = "R$" And VR(incremento).Valor = 0 Then

                VR(incremento).Valor = VR(incremento).Qto

            End If

            If VR(incremento).Unidade = "%" Then VR(incremento).Valor = Int(((VR(incremento).Qto / 100) * Hol.SBEfetivo) * 100) / 100

            If VR(incremento).TipoFinanceiro = "D" Then

                VR(incremento).Valor = -Math.Abs(VR(incremento).Valor)

            End If

            Select Case VR(incremento).Calculo

                Case 1
                    'SALARIO

                    VR(incremento).Valor = Hol.SBEfetivo
                    VR(incremento).Qto = Hol.DTmes

                Case 20

                    VR(incremento).Valor = Math.Round((Hol.valorHoraTrabalhada * VR(incremento).Qto) * (1 + (VR(incremento).Calculo_parametro / 100)), 2)

            End Select

            If VR(incremento).Base_fgts Then baseFGTS += VR(incremento).Valor
            If VR(incremento).Base_INSS Then baseINSS += VR(incremento).Valor
            If VR(incremento).Base_ir Then baseIR += VR(incremento).Valor
            If VR(incremento).Calculo = 20 Then baseDSRvariavel += VR(incremento).Valor   ' Hora extra

        Next


        If baseDSRvariavel > 0 Then

            Dim decDsrValor As Decimal = Int(((baseDSRvariavel / Hol.PPC_dias_uteis_ref) * Hol.PPC_descansos_totais_do_mes) * 100) / 100

            addVR(Hol, "0021", "DSR SALARIO VARIAVEL", "R$", True, True, True, VR, "C", decDsrValor, 0, 0, 0)

            Hol.DSR_salario_variavel_base = baseDSRvariavel
            Hol.DSR_salario_variavel_valor = decDsrValor

        End If

        If VR(incremento).Base_fgts Then baseFGTS += VR(incremento).Valor
        If VR(incremento).Base_INSS Then baseINSS += VR(incremento).Valor
        If VR(incremento).Base_ir Then baseIR += VR(incremento).Valor

        With Hol
            ' Calculo do INSS
            '-----------------------------------
            .SBinss = baseINSS                                      '(.SB + .V1valor + .V2valor + .V3valor)
            .INSSvalor = -INSScalculo(.SBinss)
            addVR(Hol, "0002", "INSS", "R$", False, False, True, VR, "D", 0, .INSSvalor, 2, 0)
            '------------------------------------

            ' Calculo da base do FGTS
            '------------------------------------
            .SBfgts = baseFGTS
            .FGTSvalor = -Int((.SBfgts * 0.08) * 100) / 100

            '----------------------------------------------

            'Calculo IR
            .SBir = baseIR + .INSSvalor                     '.SB + .V1valor + .V2valor + .V3valor + .INSSvalor
            .IRvalor = -IRcalculo(.SBir)
            If Math.Abs(.IRvalor) > 10 Then
                addVR(Hol, "0100", "IR RETIDO NA FONTE", "R$", False, False, False, VR, "D", 0, .IRvalor, 0, 0)
            End If

            '=======================================
            Dim numTotalCreditos As Decimal = 0
            Dim numTotalDebitos As Decimal = 0
            Dim numLiquido As Decimal = 0
            For i = 0 To VR.Count - 1
                If VR(i).Variavel = "0002" Then VR(i).Valor = .INSSvalor
                If VR(i).Variavel = "0100" Then VR(i).Valor = .IRvalor
                If VR(i).TipoFinanceiro = "C" Then numTotalCreditos += VR(i).Valor Else numTotalDebitos += VR(i).Valor
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


            numLiquido = numTotalCreditos + numTotalDebitos

            VR.Sort(Function(x, y) x.Variavel.CompareTo(y.Variavel))
            VR.Sort(Function(x, y) x.TipoFinanceiro.CompareTo(y.TipoFinanceiro))

            ListBox1.Items.Add("Chave : " + .Key.ToString + espacoEsquerda("MES/ANO : " + .Referencia_mes_ano_tela, 50, 2))
            ListBox1.Items.Add("Nome : " + .ColNome)
            ListBox1.Items.Add("Dependentes IR : " + .ColIRdependentes.ToString)
            ListBox1.Items.Add("Salario Base : " + numeroLatino(.SB, 10, True))
            ListBox1.Items.Add("")

            HoleriteTelaCorpo(VR, Me.ListBox1)       ' impressao do corpo do holerite de tela


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

    End Sub


    Public Function DataNow() As String

        Dim IsDatashow As String = ""

        Dim Query As String = "select DATE_FORMAT(now(), '%Y%m%d%H%i%s')"

        If OpenDB() Then


            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                IsDatashow = DTReader(0)

            Catch ex As Exception
                MsgBox("Problemas na comunicacao")
                IsDatashow = "Erro!"
            End Try

            Conn.Close()

        End If

        Return IsDatashow

    End Function

    Public Function HoraExtra(tempo As Decimal, acr As Decimal) As Decimal

        'horaExtra = Int((hol.hora_propporcional_ref_valor * tempo) * (1 + (acrescimo / 100)) * 100) / 100

        Dim DecHoraExtra, DecAcrescimo As Decimal

        DecAcrescimo = acr

        DecHoraExtra = (Hol.valorHoraTrabalhada * tempo) * (1 + (DecAcrescimo / 100))

        Return Math.Round(DecHoraExtra, 2)

    End Function
    Public Function falta(SalarioBase As Decimal, tempo As Integer) As Decimal

        Dim SBdia As Decimal = Hol.valorDiaTabalhado
        falta = SBdia * tempo

    End Function
    Private Function achaMes(mes As String)
        Dim strReferencia As String = mes

        Select Case strReferencia
            Case "janeiro"
                strReferencia = "01"
            Case "fevereiro"
                strReferencia = "02"
            Case "março"
                strReferencia = "03"
            Case "abril"
                strReferencia = "04"
            Case "maio"
                strReferencia = "05"
            Case "junho"
                strReferencia = "06"
            Case "julho"
                strReferencia = "07"
            Case "agôsto"
                strReferencia = "08"
            Case "setembro"
                strReferencia = "09"
            Case "outubro"
                strReferencia = "10"
            Case "novembro"
                strReferencia = "11"
            Case "dezembro"
                strReferencia = "12"

        End Select
        Return strReferencia
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
            Return 0
        End If
        If baseIR > IR(2).Limite Then

            numSomaIR = IR(1).Valor
            If baseIR > IR(3).Limite Then
                numSomaIR += IR(2).Valor
                If baseIR > IR(4).Limite Then
                    numSomaIR += IR(3).Valor
                    numSomaIR += (baseIR - IR(4).Limite) * (IR(4).Taxa / 100)
                Else
                    numSomaIR += (baseIR - IR(3).Limite) * (IR(3).Taxa / 100)
                    numSomaIR = Int(numSomaIR * 100) / 100
                End If
            Else
                numSomaIR += (baseIR - IR(2).Limite) * (IR(2).Taxa / 100)
                numSomaIR = Int(numSomaIR * 100) / 100
            End If

        Else
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

        With Hol

            DSRhoraExtra = Int(((nHora / Hol.PPC_dias_uteis_ref) * .PPC_descansos_totais_do_mes) * 100) / 100

        End With

    End Function

    Sub DSRvariavelIncrementar(hora As Decimal, vr As Object)

        Dim nHora As Decimal = hora

        Dim decDsrValor As Decimal = Int(((nHora / Hol.PPC_dias_uteis_ref) * Hol.PPC_descansos_totais_do_mes) * 100) / 100

        addVR(Hol, "0021", "DSR SALARIO VARIAVEL", "R$", True, True, True, vr, "C", decDsrValor, 0, 0, 0)

    End Sub

End Class