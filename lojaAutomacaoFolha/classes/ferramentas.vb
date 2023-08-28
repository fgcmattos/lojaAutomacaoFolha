Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Module Module1

    Private Oi As New MsgShow

    'Function Form2Limpa() As Boolean
    'Form2Limpa = False    ' Argumento fantasma

    'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorCPF.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorNome.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorNascimento.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked Then fmrColaboradorManutencao.colaboradorIdade.Text() = ""

    'If fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked Then fmrColaboradorManutencao.colaboradorMae.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked Then fmrColaboradorManutencao.colaboradorPai.Text() = ""

    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRG.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGuf.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGemissor.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorRGemissao.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPS.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSuf.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSemissor.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSemissao.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCTPSserie.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNH.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHSuf.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHemissor.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHemissao.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorPIS.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTitulo.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTituloZona.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorTituloSecao.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorASO.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked Then fmrColaboradorManutencao.colaboradorCNHvalidade.Text() = ""

    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorEstadoCivil.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorSexo.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorNomeCracha.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroCPF.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroNome.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked Then fmrColaboradorManutencao.colaboradorCompanheiroNascimento.Text() = ""

    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidencia.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidenciaUF.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorResidenciaCEP.Text() = ""

    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorCelular1.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorCelular2.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorFixo.Text() = ""
    'If fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked Then fmrColaboradorManutencao.colaboradorEmail.Text() = ""

    'fmrColaboradorManutencao.CheckBoxLimpaIdentificacao.Checked = False
    'fmrColaboradorManutencao.CheckBoxLimpaFiliacao.Checked = False
    'fmrColaboradorManutencao.CheckBoxLimpaDocumentos.Checked = False
    'fmrColaboradorManutencao.CheckBoxLimpaPessoais.Checked = False
    'fmrColaboradorManutencao.CheckBoxLimpaEndereco.Checked = False
    'fmrColaboradorManutencao.CheckBoxLimpaContatos.Checked = False

    '    Form2Limpa = True ' Returno fantasma
    'End Function

    Public Function FolhaFechada(referencia As String) As Boolean
        Dim booRetorno As Boolean = False
        Dim query As String
        query = "Select count(*) from folha_close_cab where fcCol_ref = '" & referencia & "'"
        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                If DTReader.GetValue(0) > 0 Then booRetorno = True
            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()



        End If

        Return (booRetorno)

    End Function


    'Public Function SQLvetor(query As String) As Object

    '    ' / tentativa de passar o vetor do Mysql para o visual - nao deu certo
    '    'Dim DTReader As MySqlDataReader
    '    'Dim CMD As New MySqlCommand(query, Conn)
    '    'Dim MySqlVetor As Object

    '    'If OpenDB() Then

    '    '    DTReader = CMD.ExecuteReader
    '    '    DTReader.Read()
    '    '    MySqlVetor = DTReader.
    '    '    Return(MySqlVetor)
    '    '    Conn.Close()

    '    'End If



    'End Function
    Public Function TelefoneRetiraMascara(strTelefoneRecebido As String) As String

        Dim strTelefone As String = strTelefoneRecebido
        strTelefone = Trim(Replace(Replace(Replace(strTelefone, "(", ""), ")", ""), "-", ""))

        If strTelefone = "" Then

            Return strTelefone

        Else

            Return strTelefoneRecebido

        End If

    End Function

    Public Function MoneyLatino(money As String) As String
        ' Rotina recebe numero com decimal indicada por .
        ' Numeros ate 999 trilhoes

        If InStr(money, ",") <> 0 Then
            money = Replace(money, ",", ".")
        End If

        Dim strLetra As String = ""

        Dim inDecimal As Integer

        If InStr(money, ".") = 0 Then money += ",00"        ' isso e certo

        inDecimal = money.Length - (InStr(money, ".")) + 1


        money = Replace(money, ".", ",")


        Select Case inDecimal
            Case 1
                money += "00"
            Case 2
                money += "0"

        End Select



        Dim inStrLenght As Integer = money.Length

        Dim strRetorno As String = ""

        Dim strDecimal As String = Microsoft.VisualBasic.Right(money, 3)

        Dim strTruncado As String = money.Substring(0, (money.Length - 3))

        Dim strCento As String = Microsoft.VisualBasic.Right(strTruncado, 3)

        Dim strMilhar As String = ""

        Dim strMilhao As String = ""

        Dim strBilhao As String = ""

        If inStrLenght > 6 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strMilhar = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If

        If inStrLenght > 9 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strMilhao = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If

        If inStrLenght > 12 Then

            strTruncado = money.Substring(0, (strTruncado.Length - 3))

            strBilhao = Microsoft.VisualBasic.Right(strTruncado, 3)

        End If




        'Dim strMilhao As String = Microsoft.VisualBasic.Right(Strteste, 3)

        strRetorno = strDecimal

        If strCento <> "" Then strRetorno = strCento & strRetorno

        If strMilhar <> "" Then strRetorno = strMilhar & "." & strRetorno

        If strMilhao <> "" Then strRetorno = strMilhao & "." & strRetorno

        If strBilhao <> "" Then strRetorno = strBilhao & "." & strRetorno

        Return strRetorno

    End Function

    Public Function MoneyUSA(money As String) As String

        Dim strMoney As String
        strMoney = Replace(money, ".", "")
        strMoney = Replace(strMoney, ",", ".")
        Return strMoney

    End Function


    Public Function ColaboradorSelectAll()


        Dim Query As String = ""

        Query = "idcolaborador"
        Query += ",chave"
        Query += ",if(isnull(colaboradorCPF),"",colaboradorCPF)"
        Query += ",if(isnull(colaboradorNome),"",colaboradorNome)"
        Query += ",if(isnull(colaboradorNascimento),"",colaboradorNascimento)"
        Query += ",if(isnull(colaboradorRG),"",colaboradorRG)"
        Query += ",if(isnull(colaboradorRGoe),"",colaboradorRGoe)"
        Query += ",if(isnull(colaboradorRGuf),"",colaboradorRGuf)"
        Query += ",if(isnull(colaboradorRGemissao),"",colaboradorRGemissao)"
        Query += ",if(isnull(colaboradorRGvalidade),"",colaboradorRGvalidade)"
        Query += ",if(isnull(colaboradorCTPS),"",colaboradorCTPS)"
        Query += ",if(isnull(colaboradorCTPSoe),"",colaboradorCTPSoe)"
        Query += ",if(isnull(colaboradorCTPSuf),"",colaboradorCTPSuf)"
        Query += ",if(isnull(colaboradorCTPSerie),"",colaboradorCTPSerie)"
        Query += ",if(isnull(colaboradorCTPSemissao),"",colaboradorCTPSemissao)"
        Query += ",if(isnull(colaboradorCTPSvalidade),"",colaboradorCTPSvalidade)"
        Query += ",if(isnull(colaboradorCNH),"",colaboradorCNH)"
        Query += ",if(isnull(colaboradorCNHoe),"",colaboradorCNHoe)"
        Query += ",if(isnull(colaboradorCNHuf),"",colaboradorCNHuf)"
        Query += ",if(isnull(colaboradorCNHemissao),"",colaboradorCNHemissao)"
        Query += ",if(isnull(colaboradorCNHvalidade),"",colaboradorCNHvalidade)"
        Query += ",if(isnull(colaboradorCNH1habilitacao),"",colaboradorCNH1habilitacao)"
        Query += ",if(isnull(colaboradorPIS),"",colaboradorPIS)"
        Query += ",if(isnull(colaboradorPISoe),"",colaboradorPISoe)"
        Query += ",if(isnull(colaboradorPISoeUF),"",colaboradorPISoeUF)"
        Query += ",if(isnull(colaboradorPISemissao),"",colaboradorPISemissao)"
        Query += ",if(isnull(colaboradorPISvalidade),"",colaboradorPISvalidade)"
        Query += ",if(isnull(colaboradorReservista),"",colaboradorReservista)"
        Query += ",if(isnull(colaboradorReservistaOE),"",colaboradorReservistaOE)"
        Query += ",if(isnull(colaboradorReservistaOEuf),"",colaboradorReservistaOEuf)"
        Query += ",if(isnull(colaboradorReservistaEmissao),"",colaboradorReservistaEmissao)"
        Query += ",if(isnull(colaboradorReservistaValidade),"",colaboradorReservistaValidade)"
        Query += ",if(isnull(colaboradorTituloNumero),"",colaboradorTituloNumero)"
        Query += ",if(isnull(colaboradorTituloOE),"",colaboradorTituloOE)"
        Query += ",if(isnull(colaboradorTituloOEuf),"",colaboradorTituloOEuf)"
        Query += ",if(isnull(colaboradorTituloZona),"",colaboradorTituloZona)"
        Query += ",if(isnull(colaboradorTituloSecao),"",colaboradorTituloSecao)"
        Query += ",if(isnull(colaboradorTituloEmissao),"",colaboradorTituloEmissao)"
        Query += ",if(isnull(colaboradorTituloValidade),"",colaboradorTituloValidade)"
        Query += ",if(isnull(colaboradorMae),"",colaboradorMae)"
        Query += ",if(isnull(colaboradorMaeCPF),"",colaboradorMaeCPF)"
        Query += ",if(isnull(colaboradorMaeNascimento),"",colaboradorMaeNascimento)"
        Query += ",if(isnull(colaboradorMaeFone),"",colaboradorMaeFone)"
        Query += ",if(isnull(colaboradorPai),"",colaboradorPai)"
        Query += ",if(isnull(colaboradorPaiCPF),"",colaboradorPaiCPF)"
        Query += ",if(isnull(colaboradorPaiNascimento),"",colaboradorPaiNascimento)"
        Query += ",if(isnull(colaboradorPaiFone),"",colaboradorPaiFone)"
        Query += ",if(isnull(colaboradorEstadoCivil),"",colaboradorEstadoCivil)"
        Query += ",if(isnull(colaboradorUniaoEstavel),"",colaboradorUniaoEstavel)"
        Query += ",if(isnull(colaboradorSexo),"",colaboradorSexo)"
        Query += ",if(isnull(colaboradorEsposolNome),"",colaboradorEsposolNome)"
        Query += ",if(isnull(colaboradorEsposoCPF),"",colaboradorEsposoCPF)"
        Query += ",if(isnull(colaboradorEsposoNascimento),"",colaboradorEsposoNascimento)"
        Query += ",if(isnull(colaboradorEsposoFone),"",colaboradorEsposoFone)"
        Query += ",if(isnull(colaboradorCompanheiroNome),"",colaboradorCompanheiroNome)"
        Query += ",if(isnull(colaboradorCompanheiroCPF),"",colaboradorCompanheiroCPF)"
        Query += ",if(isnull(colaboradorCompanheiroNascimento),"",colaboradorCompanheiroNascimento)"
        Query += ",if(isnull(colaboradorCompanheiroFone),"",colaboradorCompanheiroFone)"
        Query += ",if(isnull(colaboradorResidencia),"",colaboradorResidencia)"
        Query += ",if(isnull(colaboradorResidenciaCidade),"",colaboradorResidenciaCidade)"
        Query += ",if(isnull(colaboradorResidenciaUF),"",colaboradorResidenciaUF)"
        Query += ",if(isnull(colaboradorResidenciaCEP),"",colaboradorResidenciaCEP)"
        Query += ",if(isnull(colaboradorFone1),"",colaboradorFone1)"
        Query += ",if(isnull(colaboradorFone2),"",colaboradorFone2)"
        Query += ",if(isnull(colaboradorEmail),"",colaboradorEmail)"
        Query += ",if(isnull(colaboradorAutorizaEmail),"",colaboradorAutorizaEmail)"
        Query += ",if(isnull(colaboradorInstrucao),"",colaboradorInstrucao)"
        Query += ",if(isnull(colaboradorCurso),"",colaboradorCurso)"
        Query += ",if(isnull(colaboradorConselhoRegional),"",colaboradorConselhoRegional)"
        Query += ",if(isnull(colaboradorConselhoRegionalNumero),"",colaboradorConselhoRegionalNumero)"
        Query += ",if(isnull(colaboradorConselhoRegionalData),"",colaboradorConselhoRegionalData)"
        Query += ",if(isnull(colaboradorConselhoRegionalOE),"",colaboradorConselhoRegionalOE)"
        Query += ",if(isnull(colaboradorBanco),"",colaboradorBanco)"
        Query += ",if(isnull(colaboradorAgencia),"",colaboradorAgencia)"
        Query += ",if(isnull(colaboradorContaCorrente),"",colaboradorContaCorrente)"
        Query += ",if(isnull(colaboradorContaCorrenteDigito),"",colaboradorContaCorrenteDigito)"
        Query += ",if(isnull(colaboradorDependente1Parentesco),"",colaboradorDependente1Parentesco)"
        Query += ",if(isnull(colaboradorDependente1Nome),"",colaboradorDependente1Nome)"
        Query += ",if(isnull(colaboradorDependente1CPF),"",colaboradorDependente1CPF)"
        Query += ",if(isnull(colaboradorDependente1Nascimento),"",colaboradorDependente1Nascimento)"
        Query += ",if(isnull(colaboradorDependente2Parentesco),"",colaboradorDependente2Parentesco)"
        Query += ",if(isnull(colaboradorDependente2Nome),"",colaboradorDependente2Nome)"
        Query += ",if(isnull(colaboradorDependente2CPF),"",colaboradorDependente2CPF)"
        Query += ",if(isnull(colaboradorDependente2Nascimento),"",colaboradorDependente2Nascimento)"
        Query += ",if(isnull(colaboradorDependente3Parentesco),"",colaboradorDependente3Parentesco)"
        Query += ",if(isnull(colaboradorDependente3Nome),"",colaboradorDependente3Nome)"
        Query += ",if(isnull(colaboradorDependente3CPF),"",colaboradorDependente3CPF)"
        Query += ",if(isnull(colaboradorDependente3Nascimento),"",colaboradorDependente3Nascimento)"
        Query += ",if(isnull(colaboradorDependente4Parentesco),"",colaboradorDependente4Parentesco)"
        Query += ",if(isnull(colaboradorDependente4Nome),"",colaboradorDependente4Nome)"
        Query += ",if(isnull(colaboradorDependente4CPF),"",colaboradorDependente4CPF)"
        Query += ",if(isnull(colaboradorDependente4Nascimento),"",colaboradorDependente4Nascimento)"
        Query += ",if(isnull(colaboradorDependente5Parentesco),"",colaboradorDependente5Parentesco)"
        Query += ",if(isnull(colaboradorDependente5Nome),"",colaboradorDependente5Nome)"
        Query += ",if(isnull(colaboradorDependente5CPF),"",colaboradorDependente5CPF)"
        Query += ",if(isnull(colaboradorDependente5Nascimento),"",colaboradorDependente5Nascimento)"
        Query += ",if(isnull(colaboradorDependente6Parentesco),"",colaboradorDependente6Parentesco)"
        Query += ",if(isnull(colaboradorDependente6Nome),"",colaboradorDependente6Nome)"
        Query += ",if(isnull(colaboradorDependente6CPF),"",colaboradorDependente6CPF)"
        Query += ",if(isnull(colaboradorDependente6Nascimento),"",colaboradorDependente6Nascimento)"
        Query += ",if(isnull(colaboradorAltura),"",colaboradorAltura)"
        Query += ",if(isnull(colaboradorPeso),"",colaboradorPeso)"
        Query += ",if(isnull(colaboradorCabelo),"",colaboradorCabelo)"
        Query += ",if(isnull(colaboradorOlhos),"",colaboradorOlhos)"
        Query += ",if(isnull(colaboradorTipoDeSangues),"",colaboradorTipoDeSangues)"
        Query += ",if(isnull(colaboradorCor),"",colaboradorCor)"
        Query += ",if(isnull(colaboradorDeficiente),"",colaboradorDeficiente)"
        Query += ",if(isnull(colaboradorDeficienteTipo),"",colaboradorDeficienteTipo)"
        Query += ",if(isnull(colaboradorDeficienteOutros),"",colaboradorDeficienteOutros)"
        Query += ",if(isnull(colaboradorContatoNome1),"",colaboradorContatoNome1)"
        Query += ",if(isnull(colaboradorContatoNome1Telefone),"",colaboradorContatoNome1Telefone)"
        Query += ",if(isnull(colaboradorContatoNome1Conhecimento),"",colaboradorContatoNome1Conhecimento)"
        Query += ",if(isnull(colaboradorContatoNome2),"",colaboradorContatoNome2)"
        Query += ",if(isnull(colaboradorContatoNome2telefone),"",colaboradorContatoNome2telefone)"
        Query += ",if(isnull(colaboradorContatoNome2Conhecimento),"",colaboradorContatoNome2Conhecimento)"
        Query += ",if(isnull(colaboradorEmpresaNome1),"",colaboradorEmpresaNome1)"
        Query += ",if(isnull(colaboradorEmpresaNome1Contato),"",colaboradorEmpresaNome1Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome1Telefone),"",colaboradorEmpresaNome1Telefone)"
        Query += ",if(isnull(colaboradorEmpresaNome2),"",colaboradorEmpresaNome2)"
        Query += ",if(isnull(colaboradorEmpresaNome2Contato),"",colaboradorEmpresaNome2Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome2Telefone),"",colaboradorEmpresaNome2Telefone)"
        Query += ",if(isnull(colaboradorFuncao),"",colaboradorFuncao)"
        Query += ",if(isnull(colaboradorNomeCracha),"",colaboradorNomeCracha)"
        Query += ",if(isnull(colaboradorASOadmissao),"",colaboradorASOadmissao)"
        Query += ",if(isnull(colaboradorAdmissao),"",colaboradorAdmissao)"
        Query += ",if(isnull(colaboradorAdmissaoReferencia),"",colaboradorAdmissaoReferencia)"
        Query += ",if(isnull(colaboradorCadastroDataHora),"",colaboradorCadastroDataHora)"
        Query += ",if(isnull(colaboradorUsuarioCadastroResponsavel),"",colaboradorUsuarioCadastroResponsavel)"
        Query += ",if(isnull(colaboradorStatus),"",colaboradorStatus)"
        Query += ",if(isnull(colaboradorPIX),"",colaboradorPIX)"
        Query += ",if(isnull(colaboradorSalarioAtual),"",colaboradorSalarioAtual)"
        Query += ",if(isnull(colaboradorDependentesIR),"",colaboradorDependentesIR)"
        Query += ",if(isnull(colaboradorHorasTrabalhadasSemana),"",colaboradorHorasTrabalhadasSemana)"
        Query += ",if(isnull(colaboradorDiasDescansoSemana),"",colaboradorDiasDescansoSemana)"
        Query += ",if(isnull(colaboradorResidenciaBairro),"",colaboradorResidenciaBairro)"
        Query += ",if(isnull(colaboradorRescisaoData),"",colaboradorRescisaoData)"
        Query += ",if(isnull(colaboradorASOrescisao),"",colaboradorASOrescisao)"
        Query += ",if(isnull(colaboradorDependenteIR),"",colaboradorDependenteIR)"
        Query += ",if(isnull(colaboradorDependenteSF),"",colaboradorDependenteSF)"
        Query += ",if(isnull(colaboradorCBO),"",colaboradorCBO)"
        Query += ",if(isnull(colaboradorSetor),"",colaboradorSetor)"
        Query += ",if(isnull(colaboradorDependente1IR),"",colaboradorDependente1IR)"
        Query += ",if(isnull(colaboradorDependente1SF),"",colaboradorDependente1SF)"
        Query += ",if(isnull(colaboradorDependente2IR),"",colaboradorDependente2IR)"
        Query += ",if(isnull(colaboradorDependente2SF),"",colaboradorDependente2SF)"
        Query += ",if(isnull(colaboradorDependente3IR),"",colaboradorDependente3IR)"
        Query += ",if(isnull(colaboradorDependente3SL),"",colaboradorDependente3SL)"
        Query += ",if(isnull(colaboradorDependente4IR),"",colaboradorDependente4IR)"
        Query += ",if(isnull(colaboradorDependente4SF),"",colaboradorDependente4SF)"
        Query += ",if(isnull(colaboradorDependente5IR),"",colaboradorDependente5IR)"
        Query += ",if(isnull(colaboradorDependente5SF),"",colaboradorDependente5SF)"
        Query += ",if(isnull(colaboradorDependente6IR),"",colaboradorDependente6IR)"
        Query += ",if(isnull(colaboradorDependente6SF),"",colaboradorDependente6SF)"

        Return Query

    End Function

    Public Function StrQTO(strString As String, strChar As String) As Integer

        ' Contar o numero de caracter dentro de uma string

        Dim intContador As Integer = 0

        For i = 0 To strString.Length - 1

            If strString.Substring(i, 1) = strChar Then intContador += 1

        Next

        Return intContador

    End Function

    Public Sub ComboCarregar(Combo As Object, strTabela As String, frase As String, condicao As String)

        Combo.items.clear()
        Dim Query As String = ""
        Query += " select "
        Query += frase                              ' "concat(e_Social_tab1_codigo,' - ' , e_Social_tab1_descricao)"
        Query += " from " & strTabela

        If condicao <> "" Then Query += " " & condicao

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    Combo.items.add(DTReader.GetValue(0))

                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()

        End If

    End Sub

    Public Sub IncrementoVariaveisAutomaticas(Vaut As Object, VR As Object, hol As Object)
        ' 1 - Preparando o objeto 
        ' incremento das variaveis AUTOMATICAS


        For i = 0 To Vaut.Count - 1

            addVR(hol, Vaut(i).Variavel, Vaut(i).Descricao, Vaut(i).Unidade, Vaut(i).Base_INSS, Vaut(i).Base_fgts, Vaut(i).Base_ir, VR, Vaut(i).TipoFinanceiro, Vaut(i).Valor, Vaut(i).Qto, Vaut(i).Calculo, Vaut(i).Calculo_parametro)

        Next


    End Sub

    Sub AddVR(hol As Object, variavel As String, descricao As String, unidade As String, b_INSS As Boolean, b_fgts As Boolean, b_IR As Boolean, vr As Object, t_financeiro As String, VALOR As Decimal, QTO As Decimal, Calculo As Integer, CalculoParametro As Decimal)
        vr.Add(New FolHolLanc() With
     {
            .referencia = hol.Referencia_mes_ano,
            .Col_key = hol.Key,
            .Variavel = variavel,
            .Descricao = descricao,
            .Qto = QTO,
            .Unidade = unidade,
            .Base_INSS = b_INSS,
            .Base_fgts = b_fgts,
            .Base_ir = b_IR,
            .Valor = VALOR,
            .TipoFinanceiro = t_financeiro,
            .Calculo = Calculo,
            .Calculo_parametro = CalculoParametro
     }
     )
    End Sub


    Public Function Col_query_show(chave As Integer) As String

        '/ tem como funcao substituir a procedure sp_colaboradorShow

        Dim rcb_chave As Integer = chave

        Dim Query As String
        Query = " select "
        Query += "idcolaborador"
        Query += ",lpad(" & chave & ",4,'0')"
        Query += ",if(isnull(colaboradorCPF),'',colaboradorCPF)"
        Query += ",if(isnull(colaboradorNome),'',colaboradorNome),"
        Query += "if(isnull(colaboradorNascimento),'',colaboradorNascimento)"
        Query += ",if(isnull(colaboradorRG),'',colaboradorRG)"
        Query += ",if(isnull(colaboradorRGoe),'',colaboradorRGoe)"
        Query += ",if(isnull(colaboradorRGuf),'',colaboradorRGuf)"
        Query += ",if(isnull(colaboradorRGemissao),'',colaboradorRGemissao)"
        Query += ",if(isnull(colaboradorRGvalidade),'',colaboradorRGvalidade)"
        Query += ",if(isnull(colaboradorCTPS),'',colaboradorCTPS)"
        Query += ",if(isnull(colaboradorCTPSoe),'',colaboradorCTPSoe)"
        Query += ",if(isnull(colaboradorCTPSuf),'',colaboradorCTPSuf)"
        Query += ",if(isnull(colaboradorCTPSerie),'',colaboradorCTPSerie)"
        Query += ",if(isnull(colaboradorCTPSemissao),'',colaboradorCTPSemissao)"
        Query += ",if(isnull(colaboradorCTPSvalidade),'',colaboradorCTPSvalidade)"
        Query += ",if(isnull(colaboradorCNH),'',colaboradorCNH)"
        Query += ",if(isnull(colaboradorCNHoe),'',colaboradorCNHoe)"
        Query += ",if(isnull(colaboradorCNHuf),'',colaboradorCNHuf)"
        Query += ",if(isnull(colaboradorCNHemissao),'',colaboradorCNHemissao)"
        Query += ",if(isnull(colaboradorCNHvalidade),'',colaboradorCNHvalidade)"
        Query += ",if(isnull(colaboradorCNH1habilitacao),'',colaboradorCNH1habilitacao)"
        Query += ",if(isnull(colaboradorPIS),'',colaboradorPIS)"
        Query += ",if(isnull(colaboradorPISoe),'',colaboradorPISoe)"
        Query += ",if(isnull(colaboradorPISoeUF),'',colaboradorPISoeUF)"
        Query += ",if(isnull(colaboradorPISemissao),'',colaboradorPISemissao)"
        Query += ",if(isnull(colaboradorPISvalidade),'',colaboradorPISvalidade)"
        Query += ",if(isnull(colaboradorReservista),'',colaboradorReservista)"
        Query += ",if(isnull(colaboradorReservistaOE),'',colaboradorReservistaOE)"
        Query += ",if(isnull(colaboradorReservistaOEuf),'',colaboradorReservistaOEuf)"
        Query += ",if(isnull(colaboradorReservistaEmissao),'',colaboradorReservistaEmissao)"
        Query += ",if(isnull(colaboradorReservistaValidade),'',colaboradorReservistaValidade)"
        Query += ",if(isnull(colaboradorTituloNumero),'',colaboradorTituloNumero)"
        Query += ",if(isnull(colaboradorTituloOE),'',colaboradorTituloOE)"
        Query += ",if(isnull(colaboradorTituloOEuf),'',colaboradorTituloOEuf)"
        Query += ",if(isnull(colaboradorTituloZona),'',colaboradorTituloZona)"
        Query += ",if(isnull(colaboradorTituloSecao),'',colaboradorTituloSecao)"
        Query += ",if(isnull(colaboradorTituloEmissao),'',colaboradorTituloEmissao)"
        Query += ",if(isnull(colaboradorTituloValidade),'',colaboradorTituloValidade)"
        Query += ",if(isnull(colaboradorMae),'',colaboradorMae)"
        Query += " ,if(isnull(colaboradorMaeCPF),'',colaboradorMaeCPF)"
        Query += ",if(isnull(colaboradorMaeNascimento),'',colaboradorMaeNascimento)"
        Query += ",if(isnull(colaboradorMaeFone),'',colaboradorMaeFone)"
        Query += ",if(isnull(colaboradorPai),'',colaboradorPai)"
        Query += ",if(isnull(colaboradorPaiCPF),'',colaboradorPaiCPF)"
        Query += ",if(isnull(colaboradorPaiNascimento),'',colaboradorPaiNascimento)"
        Query += ",if(isnull(colaboradorPaiFone),'',colaboradorPaiFone)"
        Query += ",if(isnull(colaboradorEstadoCivil),'',colaboradorEstadoCivil)"
        Query += ",if(isnull(colaboradorUniaoEstavel),'',colaboradorUniaoEstavel)"
        Query += ",if(isnull(colaboradorSexo),'',colaboradorSexo)"
        Query += ",if(isnull(colaboradorEsposolNome),'',colaboradorEsposolNome)"
        Query += ",if(isnull(colaboradorEsposoCPF),'',colaboradorEsposoCPF)"
        Query += ",if(isnull(colaboradorEsposoNascimento),'',colaboradorEsposoNascimento)"
        Query += ",if(isnull(colaboradorEsposoFone),'',colaboradorEsposoFone)"
        Query += ",if(isnull(colaboradorCompanheiroNome),'',colaboradorCompanheiroNome)"
        Query += ",if(isnull(colaboradorCompanheiroCPF),'',colaboradorCompanheiroCPF)"
        Query += ",if(isnull(colaboradorCompanheiroNascimento),'',colaboradorCompanheiroNascimento)"
        Query += ",if(isnull(colaboradorCompanheiroFone),'',colaboradorCompanheiroFone)"
        Query += ",if(isnull(colaboradorResidencia),'',colaboradorResidencia)"
        Query += ",if(isnull(colaboradorResidenciaCidade),'',colaboradorResidenciaCidade)"
        Query += ",if(isnull(colaboradorResidenciaUF),'',colaboradorResidenciaUF)"
        Query += ",if(isnull(colaboradorResidenciaCEP),'',colaboradorResidenciaCEP)"
        Query += ",if(isnull(colaboradorFone1),'',colaboradorFone1)"
        Query += ",if(isnull(colaboradorFone2),'',colaboradorFone2)"
        Query += ",if(isnull(colaboradorEmail),'',colaboradorEmail)"
        Query += ",if(isnull(colaboradorAutorizaEmail),'',colaboradorAutorizaEmail)"
        Query += ",if(isnull(colaboradorInstrucao),'',colaboradorInstrucao)"
        Query += ",if(isnull(colaboradorCurso),'',colaboradorCurso)"
        Query += ",if(isnull(colaboradorConselhoRegional),'',colaboradorConselhoRegional)"
        Query += ",if(isnull(colaboradorConselhoRegionalNumero),'',colaboradorConselhoRegionalNumero)"
        Query += ",if(isnull(colaboradorConselhoRegionalData),'',colaboradorConselhoRegionalData)"
        Query += ",if(isnull(colaboradorConselhoRegionalOE),'',colaboradorConselhoRegionalOE)"
        Query += ",if(isnull(colaboradorBanco),'',colaboradorBanco)"
        Query += ",if(isnull(colaboradorAgencia),'',colaboradorAgencia)"
        Query += ",if(isnull(colaboradorContaCorrente),'',colaboradorContaCorrente)"
        Query += ",if(isnull(colaboradorContaCorrenteDigito),'',colaboradorContaCorrenteDigito)"
        Query += ",if(isnull(colaboradorDependente1Parentesco),'',colaboradorDependente1Parentesco)"
        Query += ",if(isnull(colaboradorDependente1Nome),'',colaboradorDependente1Nome)"
        Query += ",if(isnull(colaboradorDependente1CPF),'',colaboradorDependente1CPF)"
        Query += ",if(isnull(colaboradorDependente1Nascimento),'',colaboradorDependente1Nascimento)"
        Query += ",if(isnull(colaboradorDependente2Parentesco),'',colaboradorDependente2Parentesco)"
        Query += ",if(isnull(colaboradorDependente2Nome),'',colaboradorDependente2Nome)"
        Query += ",if(isnull(colaboradorDependente2CPF),'',colaboradorDependente2CPF)"
        Query += ",if(isnull(colaboradorDependente2Nascimento),'',colaboradorDependente2Nascimento)"
        Query += ",if(isnull(colaboradorDependente3Parentesco),'',colaboradorDependente3Parentesco)"
        Query += ",if(isnull(colaboradorDependente3Nome),'',colaboradorDependente3Nome)"
        Query += ",if(isnull(colaboradorDependente3CPF),'',colaboradorDependente3CPF)"
        Query += ",if(isnull(colaboradorDependente3Nascimento),'',colaboradorDependente3Nascimento)"
        Query += ",if(isnull(colaboradorDependente4Parentesco),'',colaboradorDependente4Parentesco)"
        Query += ",if(isnull(colaboradorDependente4Nome),'',colaboradorDependente4Nome)"
        Query += ",if(isnull(colaboradorDependente4CPF),'',colaboradorDependente4CPF)"
        Query += ",if(isnull(colaboradorDependente4Nascimento),'',colaboradorDependente4Nascimento)"
        Query += ",if(isnull(colaboradorDependente5Parentesco),'',colaboradorDependente5Parentesco)"
        Query += ",if(isnull(colaboradorDependente5Nome),'',colaboradorDependente5Nome)"
        Query += ",if(isnull(colaboradorDependente5CPF),'',colaboradorDependente5CPF)"
        Query += ",if(isnull(colaboradorDependente5Nascimento),'',colaboradorDependente5Nascimento)"
        Query += ",if(isnull(colaboradorDependente6Parentesco),'',colaboradorDependente6Parentesco)"
        Query += ",if(isnull(colaboradorDependente6Nome),'',colaboradorDependente6Nome)"
        Query += ",if(isnull(colaboradorDependente6CPF),'',colaboradorDependente6CPF)"
        Query += ",if(isnull(colaboradorDependente6Nascimento),'',colaboradorDependente6Nascimento)"
        Query += ",if(isnull(colaboradorAltura),'',colaboradorAltura)"
        Query += ",if(isnull(colaboradorPeso),'',colaboradorPeso)"
        Query += ",if(isnull(colaboradorCabelo),'',colaboradorCabelo)"
        Query += ",if(isnull(colaboradorOlhos),'',colaboradorOlhos)"
        Query += ",if(isnull(colaboradorTipoDeSangues),'',colaboradorTipoDeSangues)"
        Query += ",if(isnull(colaboradorCor),'',colaboradorCor)"
        Query += ",if(isnull(colaboradorDeficiente),'',colaboradorDeficiente)"
        Query += ",if(isnull(colaboradorDeficienteTipo),'',colaboradorDeficienteTipo)"
        Query += ",if(isnull(colaboradorDeficienteOutros),'',colaboradorDeficienteOutros)"
        Query += ",if(isnull(colaboradorContatoNome1),'',colaboradorContatoNome1)"
        Query += ",if(isnull(colaboradorContatoNome1Telefone),'',colaboradorContatoNome1Telefone)"
        Query += ",if(isnull(colaboradorContatoNome1Conhecimento),'',colaboradorContatoNome1Conhecimento)"
        Query += ",if(isnull(colaboradorContatoNome2),'',colaboradorContatoNome2)"
        Query += ",if(isnull(colaboradorContatoNome2telefone),'',colaboradorContatoNome2telefone)"
        Query += ",if(isnull(colaboradorContatoNome2Conhecimento),'',colaboradorContatoNome2Conhecimento)"
        Query += ",if(isnull(colaboradorEmpresaNome1),'',colaboradorEmpresaNome1)"
        Query += ",if(isnull(colaboradorEmpresaNome1Contato),'',colaboradorEmpresaNome1Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome1Telefone),'',colaboradorEmpresaNome1Telefone)"
        Query += ",if(isnull(colaboradorEmpresaNome2),'',colaboradorEmpresaNome2)"
        Query += ",if(isnull(colaboradorEmpresaNome2Contato),'',colaboradorEmpresaNome2Contato)"
        Query += ",if(isnull(colaboradorEmpresaNome2Telefone),'',colaboradorEmpresaNome2Telefone)"
        Query += ",if(isnull(colaboradorCargo),'',colaboradorCargo)"
        Query += ",if(isnull(colaboradorNomeCracha),'',colaboradorNomeCracha)"
        Query += ",if(isnull(colaboradorASOadmissao),'',colaboradorASOadmissao)"
        Query += ",if(isnull(colaboradorAdmissao),'',colaboradorAdmissao)"
        Query += ",if(isnull(colaboradorAdmissaoReferencia),'',colaboradorAdmissaoReferencia)"
        Query += ",if(isnull(colaboradorCadastroDataHora),'',DATE_FORMAT(colaboradorCadastroDataHora, '%d/%m/%Y %H:%i'))"
        Query += ",if(isnull(colaboradorUsuarioCadastroResponsavel),'',colaboradorUsuarioCadastroResponsavel)"
        Query += ",if(isnull(colaboradorStatus),'',colaboradorStatus)"
        Query += ",if(isnull(colaboradorPIX),'',colaboradorPIX)"
        Query += ",if(isnull(colaboradorSalarioAtual),'',colaboradorSalarioAtual)"
        Query += ",if(isnull(colaboradorHorasTrabalhadasSemana),'',colaboradorHorasTrabalhadasSemana)"
        Query += ",if(isnull(colaboradorDiasDescansoSemana),'',colaboradorDiasDescansoSemana)"
        Query += ",if(isnull(colaboradorResidenciaBairro),'',colaboradorResidenciaBairro)"
        Query += ",if(isnull(colaboradorRescisaoData),'',colaboradorRescisaoData)"
        Query += ",if(isnull(colaboradorASOrescisao),'',colaboradorASOrescisao)"
        Query += ",if(isnull(colaboradorDependentesIR),'',colaboradorDependentesIR)"
        Query += ",if(isnull(colaboradorDependentesSF),'',colaboradorDependentesSF)"
        Query += ",if(isnull(colaboradorCBO),'',colaboradorCBO)"
        Query += ",if(isnull(colaboradorSetor),'',colaboradorSetor)"
        Query += ",if(isnull(colaboradorDependente1IR),'',colaboradorDependente1IR)"
        Query += ",if(isnull(colaboradorDependente1SF),'',colaboradorDependente1SF)"
        Query += ",if(isnull(colaboradorDependente2IR),'',colaboradorDependente2IR)"
        Query += ",if(isnull(colaboradorDependente2SF),'',colaboradorDependente2SF)"
        Query += ",if(isnull(colaboradorDependente3IR),'',colaboradorDependente3IR)"
        Query += ",if(isnull(colaboradorDependente3SF),'',colaboradorDependente3SF)"
        Query += ",if(isnull(colaboradorDependente4IR),'',colaboradorDependente4IR)"
        Query += ",if(isnull(colaboradorDependente4SF),'',colaboradorDependente4SF)"
        Query += ",if(isnull(colaboradorDependente5IR),'',colaboradorDependente5IR)"
        Query += ",if(isnull(colaboradorDependente5SF),'',colaboradorDependente5SF)"
        Query += ",if(isnull(colaboradorDependente6IR),'',colaboradorDependente6IR)"
        Query += ",if(isnull(colaboradorDependente6SF),'',colaboradorDependente6SF)"
        Query += ",if(isnull(colaboradorCategoria),'',colaboradorCategoria)"
        Query += ",if(isnull(colaboradorContratoTipo),'',colaboradorContratoTipo)"
        Query += ",if(isnull(colaboradorEmpresa),'',colaboradorEmpresa)"
        Query += ",if(isnull(colaboradorPixIdentificacao),'',colaboradorPixIdentificacao)"
        Query += ",if(isnull(colaboradorDepTotal),'',colaboradorDepTotal)"
        Query += " from "
        Query += " colaborador "
        Query += " where "
        Query += " chave = " & rcb_chave

        Return Query

    End Function

    Public Sub StatusDeCapa()

        Form1.form1Status.BackColor = Color.White
        Form1.form1Status.Text = "Status: On-Line // "
        Form1.Form1chave.BackColor = Color.White
        Form1.Form1chave.Text = "Chave : " & usuClass.Usuario_Chave.ToString.PadLeft(4, "0") & " // "
        Form1.Form1usuarioNome.BackColor = Color.White
        Form1.Form1usuarioNome.Text = "Usuário : " & usuClass.Usuario_Nome_Acesso & "//"

        Form1.BackgroundImage = Image.FromFile("C:\Users\paulo\Desktop\paulo\desenvolvimentoSoftwareFolha\icones\loginAutorizado.jpeg")

        Dim Query As String = "Select empCNPJ from empresa"

        gravaSQLretorno(Query)

        Form1.empCNPJ.BackColor = Color.White
        Form1.empCNPJ.Text = "CNPJ : " & CNPJcolocaMascara(gravaSQLretorno(Query)) & " // "


        Form1.Form1terminal.BackColor = Color.White
        Form1.Form1terminal.Text = "Terminal : Desconhecido // "

        Dim ap As List(Of Aponta) = ApontaAcoes.GetApontaDB()
        Form1.Form1Inicio.BackColor = Color.White
        Form1.Form1Inicio.Text = dataLatina(ap(0).Data) & " - " & ap(0).Tempo & " // "
        Form1.Timer1.Start()
        'Form1.form1DataHora = current

    End Sub

    Public Function ContaString(str As String, frase As String) As Integer

        ContaString = 0

        Dim strLetra As String

        For i = 0 To Len(frase) - 1

            strLetra = frase.Substring(i, 1)

            If strLetra = str Then ContaString += 1

        Next

    End Function

End Module