
Public Class ColaboradorCapTela


    Public Shared Function GetColaborador() As List(Of colaborador)
        Dim oi As New MsgShow
        oi.title = "Cadastro de Colaborador"

        Dim arrayDep(10, 7) As String
        Dim i As Integer = 0
        Dim rgEmissao, rgValidade As String
        Dim cnhEmissao, cnhValidade As String
        Dim dataAgora As String = Now

        dataAgora = dataAAAAMMDD(dataAgora.Substring(0, 10))
        ' VERIFICACAO DO RG
        rgEmissao = fColCad.col_01_rgEmissao.Text

        If rgEmissao = "  /  /" And
            fColCad.col_01_rg.Text = "" And
            fColCad.col_01_rgOE.Text = "" And
            fColCad.col_01_rgOEuf.Text = "" Then
            rgEmissao = ""
        ElseIf rgEmissao <> "  /  /" And
            (fColCad.col_01_rg.Text = "" Or
             fColCad.col_01_rgOE.Text = "" Or
             fColCad.col_01_rgOEuf.Text = "") Then
            MsgBox("Data sem complemento!")
            fColCad.col_01_rgEmissao.Focus()
            Exit Function
        Else
            rgEmissao = dataAAAAMMDD(rgEmissao)
            If Not DataVerifica(True, True, False, rgEmissao, dataAgora) Then
                MsgBox("RG emissão  - Data inválida !")
                fColCad.col_01_rgEmissao.Focus()
                Exit Function
            End If
        End If

        rgValidade = fColCad.col_01_rgValidade.Text

        If rgEmissao = "" And rgValidade = "  /  /" Then

            rgValidade = ""

        ElseIf rgEmissao <> "" And (rgValidade = "  /  /" Or rgValidade = "") Then

            MsgBox("RG Validade - Data Invalida!")
            fColCad.col_01_rgValidade.Focus()
            Exit Function
        ElseIf rgEmissao <> "" And rgValidade <> "  /  /" Then
            rgValidade = dataAAAAMMDD(rgValidade)
            If Not DataVerifica(False, True, True, rgValidade, rgEmissao) Then
                MsgBox("Data inválida !")
                fColCad.col_01_rgValidade.Focus()
                Exit Function
            End If
        End If
        ' FIM DA VERIFICACAO DO RG ----------------------------------------------

        ' VERIFICACAO DA CNH
        cnhEmissao = fColCad.col_01_cnhEmissao.Text

        If cnhEmissao = "  /  /" And
            fColCad.col_01_cnh.Text = "" And
            fColCad.col_01_cnhOE.Text = "" And
            fColCad.col_01_cnhOEuf.Text = "" Then
            cnhEmissao = ""
        ElseIf cnhEmissao <> "  /  /" And
            (fColCad.col_01_cnh.Text = "" Or
             fColCad.col_01_cnhOE.Text = "" Or
             fColCad.col_01_cnhOEuf.Text = "") Then
            MsgBox("Data sem complemento!")
            fColCad.col_01_cnhEmissao.Focus()
            Exit Function
        Else
            cnhEmissao = dataAAAAMMDD(cnhEmissao)
            If Not DataVerifica(True, True, False, cnhEmissao, dataAgora) Then
                MsgBox("Data inválida !")
                fColCad.col_01_cnhEmissao.Focus()
                Exit Function
            End If
        End If

        cnhValidade = fColCad.col_01_cnhValidade.Text
        If cnhEmissao = "" And cnhValidade = "  /  /" Then

            cnhValidade = ""

        ElseIf cnhEmissao <> "" And cnhValidade = "  /  /" Then

            MsgBox("Data Invalida!")
            fColCad.col_01_cnhValidade.Focus()
            Exit Function
        ElseIf cnhEmissao <> "" And cnhValidade <> "  /  /" Then
            cnhValidade = dataAAAAMMDD(cnhValidade)
            If Not DataVerifica(False, True, True, cnhValidade, cnhEmissao) Then
                MsgBox("Data inválida !")
                fColCad.col_01_cnhValidade.Focus()
                Exit Function
            End If
        End If
        ' FIM DA VERIFICACAO DA CNH ----------------------------------------------

        ' data de admissao - Chek ------------------------------------------------

        Dim strAdmissaoTeste As String = fColCad.col_12Admissao.Text

        Try

            Dim datTeste As Date = DateAdd("d", 1, strAdmissaoTeste)

        Catch ex As Exception
            With oi
                .msg = "Data de Admissão inválida!"
                .msg += Chr(13) & Chr(13)
                .msg += "Por favor, entre com uma data válida"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
            End With

            fColCad.col_12Admissao.Focus()
            Exit Function

        End Try

        Dim strRef As String = fColCad.col_12Admissao.Text.Substring(3)



        strRef = Replace(strRef, "/", "")
        strRef = strRef.Substring(2, 4) & strRef.Substring(0, 2)

        For Each dep As Object In fColCad.ListViewDependente.Items

            arrayDep(i, 1) = dep.text               ' Grau de parentesco
            arrayDep(i, 2) = dep.subitems(1).text   ' Nome do dependente
            arrayDep(i, 3) = dep.subitems(2).text   ' Data de CPF
            arrayDep(i, 4) = dep.subitems(3).text   ' Data de nascimento
            arrayDep(i, 5) = dep.subitems(5).text   ' IR
            arrayDep(i, 6) = dep.subitems(6).text   ' SF
            i += 1

        Next

        Dim auxInstrucao As String

        If fColCad.cmbInstrucao.Text.Length = 0 Then

            auxInstrucao = ""

        Else

            auxInstrucao = fColCad.cmbInstrucao.Text.Substring(0, 2)

        End If





        Dim lista As New List(Of colaborador) From {
            New colaborador() With {
                .CPF = CPFretiraMascara(fColCad.lblCPF.Text),
                .Nome = fColCad.txtNome.Text,
                .Nascimento = dataAAAAMMDD(fColCad.mskNascimento.Text),
                .rg = fColCad.col_01_rg.Text,
                .rgOE = fColCad.col_01_rgOE.Text,
                .rgOEuf = fColCad.col_01_rgOEuf.Text,
                .rgEmissao = rgEmissao,
                .rgValidade = rgValidade,
                .PISvalidade = dataAAAAMMDD(fColCad.col_01_PISvalidade.Text),
                .te = fColCad.col_01_te.Text,
                .teOE = fColCad.col_01_teOE.Text,
                .teOEuf = fColCad.col_01_teOEuf.Text,
                .teEmissao = dataAAAAMMDD(fColCad.col_01_teEmissao.Text),
                .teValidade = dataAAAAMMDD(fColCad.col_01_teValidade.Text),
                .teZona = fColCad.col_01_teZona.Text,
                .teSecao = fColCad.col_01_teSecao.Text,
                .CTPS = fColCad.col_01_CTPS.Text,
                .CTPSserie = fColCad.col_01_CTPSserie.Text,
                .CTPSOE = fColCad.col_01_CTPSOE.Text,
                .CTPSOEuf = fColCad.col_01_CTPSOEuf.Text,
                .CTPSvalidade = dataAAAAMMDD(fColCad.col_01_CTPSvalidade.Text),
                .CTPSemissao = dataAAAAMMDD(fColCad.col_01_CTPSemissao.Text),
                .Mae = fColCad.col_02_Mae.Text,
                .MaeNascimento = dataAAAAMMDD(fColCad.col_02_MaeNascimento.Text),
                .MaeCPF = CPFretiraMascara(fColCad.col_02_MaeCPF.Text),
                .MaeFone = LimpaNumero(FColMant.col_02_MaeFone.Text),
                .pai = fColCad.col_02_pai.Text,
                .paiNascimento = dataAAAAMMDD(fColCad.col_02_paiNascimento.Text),
                .paiCPF = CPFretiraMascara(fColCad.col_02_paiCPF.Text),
                .paiFone = LimpaNumero(fColCad.col_02_paiFone.Text),
                .Sexo = fColCad.col_03Sexo.Text,
                .EstadoCivil = fColCad.col_03EstadoCivil.Text.Substring(0, 1),
                .UniaoEstavel = IIf(fColCad.col_03UniaoEstavel.Checked, "1", "0"),
                .Esposa = fColCad.col_03Esposa.Text,
                .EsposaCPF = CPFretiraMascara(fColCad.col_03EsposaCPF.Text),
                .EsposaFone = LimpaNumero(fColCad.col_03EsposaFone.Text),
                .EsposaNascimento = dataAAAAMMDD(fColCad.col_03EsposaNascimento.Text),
                .Companheira = fColCad.col_03Companheira.Text,
                .CompanheiraCPF = CPFretiraMascara(dataAAAAMMDD(fColCad.col_03CompanheiraCPF.Text)),
                .CompanheiraFone = LimpaNumero(fColCad.col_03CompanheiraFone.Text),
                .CompanheiraNascimento = dataAAAAMMDD(fColCad.col_03CompanheiraNascimento.Text),
                .Fone1 = LimpaNumero(fColCad.col_04Fone1.Text),
                .Fone2 = LimpaNumero(fColCad.col_04Fone2.Text),
                .email = fColCad.col_04email.Text,
                .AutorizaComunicaEmail = IIf(fColCad.col_04AutorizaComunicaEmail.Checked, 1, 0),
                .endereco = fColCad.col_05endereco.Text,
                .cidade = fColCad.col_05cidade.Text,
                .EndUF = fColCad.cmbEndUF.Text,
                .cep = fColCad.col_05cep.Text,
                .Instrucao = auxInstrucao,
                .Curso = fColCad.col_06Curso.Text,
                .ConselhoRegional = fColCad.col_06ConselhoRegional.Text,
                .ConselhoRegionalNumero = fColCad.col_06ConselhoRegionalNumero.Text,
                .ConselhoRegionalData = dataAAAAMMDD(fColCad.col_06ConselhoRegionalData.Text),
                .ConselhoRegionalOE = fColCad.col_06OE.Text,
                .banco = fColCad.col_08banco.Text,
                .agencia = fColCad.col_08agencia.Text,
                .agenciaDigito = fColCad.col_08agenciaDigito.Text,
                .conta = fColCad.col_08conta.Text,
                .contaDigito = fColCad.col_08contaDigito.Text, 'local
                .altura = IIf(Trim(fColCad.col_10altura.Text) = ":", "", fColCad.col_10altura.Text),
                .PIX = fColCad.col_08pix_numero.Text,
                .PIXidentificacao = fColCad.col_08pix_identificacao.Text,
                .peso = fColCad.col_10peso.Text,
                .cabelo = fColCad.col_10cabelo.Text,
                .olhos = fColCad.col_10olhos.Text,
                .tipoSangue = fColCad.col_10tipoSangue.Text,
                .cor = fColCad.col_10cor.Text,
                .deficiente = IIf(fColCad.col_10deficiente.Checked, 1, 0),
                .deficienteTipo = fColCad.col_10deficienteTipo.Text,
                .deficienteOutros = fColCad.col_10deficienteOutros.Text,
                .nome1 = fColCad.col_11nome1.Text,
                .Telefone1 = LimpaNumero(fColCad.col_11Telefone1.Text),
                .conhecimento1 = fColCad.col_11conhecimento1.Text,
                .Nome2 = fColCad.col_11Nome2.Text,
                .Telefone2 = LimpaNumero(fColCad.col_11Telefone2.Text),
                .Conhecimento2 = fColCad.col_11Conhecimento2.Text,
                .Empresa1 = fColCad.col_11Empresa1.Text,
                .Contato1 = fColCad.col_11Contato1.Text,
                .EmpresaTel1 = LimpaNumero(fColCad.col_11EmpresaTel1.Text),
                .Empresa2 = fColCad.col_11Empresa2.Text,
                .Contato2 = fColCad.col_11Contato2.Text,
                .EmpresaTel2 = LimpaNumero(fColCad.col_11EmpresaTel2.Text),
                .p1 = arrayDep(0, 1),
                .n1 = arrayDep(0, 2),
                .cpf1 = CPFretiraMascara(arrayDep(0, 3)),
                .nas1 = dataAAAAMMDD(arrayDep(0, 4)),
                .depIR1 = arrayDep(0, 5),
                .depSF1 = arrayDep(0, 6),
                .p2 = arrayDep(1, 1),
                .n2 = arrayDep(1, 2),
                .cpf2 = CPFretiraMascara(arrayDep(1, 3)),
                .nas2 = dataAAAAMMDD(arrayDep(1, 4)),
                .depIR2 = arrayDep(1, 5),
                .depSF2 = arrayDep(1, 6),
                .p3 = arrayDep(2, 1),
                .n3 = arrayDep(2, 2),
                .cpf3 = CPFretiraMascara(arrayDep(2, 3)),
                .nas3 = dataAAAAMMDD(arrayDep(2, 4)),
                .depIR3 = arrayDep(2, 5),
                .depSF3 = arrayDep(2, 6),
                .p4 = arrayDep(3, 1),
                .n4 = arrayDep(3, 2),
                .cpf4 = CPFretiraMascara(arrayDep(3, 3)),
                .nas4 = dataAAAAMMDD(arrayDep(3, 4)),
                .depIR4 = arrayDep(3, 5),
                .depSF4 = arrayDep(3, 6),
                .p5 = arrayDep(4, 1),
                .n5 = arrayDep(4, 2),
                .cpf5 = CPFretiraMascara(arrayDep(4, 3)),
                .nas5 = dataAAAAMMDD(arrayDep(4, 4)),
                .depIR5 = arrayDep(4, 5),
                .depSF5 = arrayDep(4, 6),
                .p6 = arrayDep(5, 1),
                .n6 = arrayDep(5, 2),
                .cpf6 = CPFretiraMascara(arrayDep(5, 3)),
                .nas6 = dataAAAAMMDD(arrayDep(5, 4)),
                .depIR6 = arrayDep(5, 5),
                .depSF6 = arrayDep(5, 6),
                .Cracha = fColCad.col_12nomeCracha.Text,
                .Cargo = fColCad.col_12Cargo.Text,
                .ASOadmissao = dataAAAAMMDD(fColCad.col_12ASOadmissao.Text),
                .Admissao = dataAAAAMMDD(fColCad.col_12Admissao.Text),
                .AdmissaoRef = strRef,
                .DependentesTotais = fColCad.ListViewDependente.Items.Count(),
                .DependentesIR = fColCad.LblirQTO.Text,
                .DependentesSF = fColCad.LblirQTO.Text
            }}

        Return lista
    End Function


    Public Shared Function GetColaboradorMant() As List(Of colaborador)

        '/ Carreagamento da tela do formulario FColMant

        Dim arrayDep(10, 7) As String

        Dim i As Integer = 0

        Dim dataAgora As String = Now



        For Each dep As Object In FColMant.ListViewDependente.Items

            arrayDep(i, 1) = dep.text               ' Grau de parentesco
            arrayDep(i, 2) = dep.subitems(1).text   ' Nome do dependente
            arrayDep(i, 3) = dep.subitems(2).text   ' Data de CPF
            arrayDep(i, 4) = dep.subitems(3).text   ' Data de nascimento
            arrayDep(i, 5) = dep.subitems(5).text   ' ir
            arrayDep(i, 6) = dep.subitems(6).text   ' SF
            i += 1

        Next


        Dim lista As New List(Of colaborador) From {
            New colaborador() With {
                .CPF = CPFretiraMascara(FColMant.lblCPF.Text),
                .Nome = FColMant.txtNome.Text,
                .Nascimento = dataAAAAMMDD(FColMant.mskNascimento.Text),
                .rg = FColMant.col_01_rg.Text,
                .rgOE = FColMant.col_01_rgOE.Text,
                .rgOEuf = FColMant.col_01_rgOEuf.Text,
                .rgEmissao = dataAAAAMMDD(FColMant.col_01_rgEmissao.Text),            'rgEmissao,
                .rgValidade = dataAAAAMMDD(FColMant.col_01_rgValidade.Text),          'rgValidade,
                .cnh = FColMant.col_01_cnh.Text,
                .cnhOE = FColMant.col_01_cnhOE.Text,
                .cnhOEuf = FColMant.col_01_cnhOEuf.Text,
                .cnhEmissao = dataAAAAMMDD(FColMant.col_01_cnhEmissao.Text),
                .cnhValidade = dataAAAAMMDD(FColMant.col_01_cnhValidade.Text),
                .CTPS = FColMant.col_01_CTPS.Text,
                .CTPSserie = FColMant.col_01_CTPSserie.Text,
                .CTPSOE = FColMant.col_01_CTPSOE.Text,
                .CTPSOEuf = FColMant.col_01_CTPSOEuf.Text,
                .CTPSvalidade = dataAAAAMMDD(FColMant.col_01_CTPSvalidade.Text),
                .CTPSemissao = dataAAAAMMDD(FColMant.col_01_CTPSemissao.Text),
                .reser = FColMant.col_01_reser.Text,
                .reserOE = FColMant.col_01_reserOE.Text,
                .reserOEuf = FColMant.col_01_reserOEuf.Text,
                .reserEmissao = dataAAAAMMDD(FColMant.col_01_reserEmissao.Text),
                .reserValidade = dataAAAAMMDD(FColMant.col_01_reserValidade.Text),
                .PIS = FColMant.col_01_PIS.Text,
                .PISoe = FColMant.col_01_PISoe.Text,
                .PISoeUF = FColMant.col_01_PISoeUF.Text,
                .PISemissao = dataAAAAMMDD(FColMant.col_01_PISemissao.Text),
                .PISvalidade = dataAAAAMMDD(FColMant.col_01_PISvalidade.Text),
                .te = FColMant.col_01_te.Text,
                .teOE = FColMant.col_01_teOE.Text,
                .teOEuf = FColMant.col_01_teOEuf.Text,
                .teEmissao = dataAAAAMMDD(FColMant.col_01_teEmissao.Text),
                .teValidade = dataAAAAMMDD(FColMant.col_01_teValidade.Text),
                .teZona = FColMant.col_01_teZona.Text,
                .teSecao = FColMant.col_01_teSecao.Text,
                .Mae = FColMant.col_02_Mae.Text,
                .MaeNascimento = dataAAAAMMDD(FColMant.col_02_MaeNascimento.Text),
                .MaeCPF = CPFretiraMascara(FColMant.col_02_MaeCPF.Text),
                .MaeFone = telefoneRetiraMascara(FColMant.col_02_MaeFone.Text),
                .pai = FColMant.col_02_pai.Text,
                .paiNascimento = dataAAAAMMDD(FColMant.col_02_paiNascimento.Text),
                .paiCPF = CPFretiraMascara(FColMant.col_02_paiCPF.Text),
                .paiFone = telefoneRetiraMascara(FColMant.col_02_paiFone.Text),
                .Sexo = FColMant.col_03Sexo.Text,
                .EstadoCivil = FColMant.col_03EstadoCivil.Text.Substring(0, 1),
                .UniaoEstavel = IIf(FColMant.col_03UniaoEstavel.Checked, "1", "0"),
                .Esposa = FColMant.col_03Esposa.Text,
                .EsposaCPF = CPFretiraMascara(FColMant.col_03EsposaCPF.Text),
                .EsposaFone = telefoneRetiraMascara(FColMant.col_03EsposaFone.Text),
                .EsposaNascimento = dataAAAAMMDD(FColMant.col_03EsposaNascimento.Text),
                .Companheira = FColMant.col_03Companheira.Text,
                .CompanheiraCPF = CPFretiraMascara(FColMant.col_03CompanheiraCPF.Text),
                .CompanheiraFone = telefoneRetiraMascara(FColMant.col_03CompanheiraFone.Text),
                .CompanheiraNascimento = dataAAAAMMDD(FColMant.col_03CompanheiraNascimento.Text),
                .Fone1 = telefoneRetiraMascara(FColMant.col_04Fone1.Text),
                .Fone2 = telefoneRetiraMascara(FColMant.col_04Fone2.Text),
                .email = FColMant.col_04email.Text,
                .AutorizaComunicaEmail = IIf(FColMant.col_04AutorizaComunicaEmail.Checked, 1, 0),
                .endereco = FColMant.col_05endereco.Text,
                .bairro = FColMant.col_05bairro.Text,
                .cidade = FColMant.col_05cidade.Text,
                .EndUF = FColMant.cmbEndUF.Text,
                .cep = IIf(LimpaNumero(FColMant.col_05cep.Text) = "", "", FColMant.col_05cep.Text),
                .Instrucao = FColMant.cmbInstrucao.Text.Substring(0, 2),
                .Curso = FColMant.col_06Curso.Text,
                .ConselhoRegional = FColMant.col_06ConselhoRegional.Text,
                .ConselhoRegionalNumero = FColMant.col_06ConselhoRegionalNumero.Text,
                .ConselhoRegionalData = dataAAAAMMDD(FColMant.col_06ConselhoRegionalData.Text),
                .ConselhoRegionalOE = FColMant.col_06OE.Text,
                .banco = FColMant.col_08banco.Text,
                .agencia = FColMant.col_08agencia.Text,
                .agenciaDigito = FColMant.col_08agenciaDigito.Text,
                .conta = FColMant.col_08conta.Text,
                .contaDigito = FColMant.col_08contaDigito.Text, 'local
                .PIX = FColMant.col_08pix_numero.Text,
                .PIXidentificacao = FColMant.col_08pix_identificacao.Text,
                .altura = LimpaNumero(FColMant.col_10altura.Text),
                .peso = FColMant.col_10peso.Text,
                .cabelo = FColMant.col_10cabelo.Text,
                .olhos = FColMant.col_10olhos.Text,
                .tipoSangue = FColMant.col_10tipoSangue.Text,
                .cor = FColMant.col_10cor.Text,
                .deficiente = IIf(FColMant.col_10deficiente.Checked, 1, 0),
                .deficienteTipo = FColMant.col_10deficienteTipo.Text,
                .deficienteOutros = FColMant.col_10deficienteOutros.Text,
                .nome1 = FColMant.col_11nome1.Text,
                .Telefone1 = LimpaNumero(FColMant.col_11Telefone1.Text),
                .conhecimento1 = FColMant.col_11conhecimento1.Text,
                .Nome2 = FColMant.col_11Nome2.Text,
                .Telefone2 = LimpaNumero(FColMant.col_11Telefone2.Text),
                .Conhecimento2 = FColMant.col_11Conhecimento2.Text,
                .Empresa1 = FColMant.col_11Empresa1.Text,
                .Contato1 = FColMant.col_11Contato1.Text,
                .EmpresaTel1 = LimpaNumero(FColMant.col_11EmpresaTel1.Text),
                .Empresa2 = FColMant.col_11Empresa2.Text,
                .Contato2 = FColMant.col_11Contato2.Text,
                .EmpresaTel2 = LimpaNumero(FColMant.col_11EmpresaTel2.Text),
        .p1 = arrayDep(0, 1),
        .n1 = arrayDep(0, 2),
        .cpf1 = CPFretiraMascara(arrayDep(0, 3)),
        .nas1 = dataAAAAMMDD(arrayDep(0, 4)),
        .depIR1 = arrayDep(0, 5),
        .depSF1 = arrayDep(0, 6),
        .p2 = arrayDep(1, 1),
        .n2 = arrayDep(1, 2),
        .cpf2 = CPFretiraMascara(arrayDep(1, 3)),
        .nas2 = dataAAAAMMDD(arrayDep(1, 4)),
        .depIR2 = arrayDep(1, 5),
        .depSF2 = arrayDep(1, 6),
        .p3 = arrayDep(2, 1),
        .n3 = arrayDep(2, 2),
        .cpf3 = CPFretiraMascara(arrayDep(2, 3)),
        .nas3 = dataAAAAMMDD(arrayDep(2, 4)),
        .depIR3 = arrayDep(2, 5),
        .depSF3 = arrayDep(2, 6),
        .p4 = arrayDep(3, 1),
        .n4 = arrayDep(3, 2),
        .cpf4 = CPFretiraMascara(arrayDep(3, 3)),
        .nas4 = dataAAAAMMDD(arrayDep(3, 4)),
        .depIR4 = arrayDep(3, 5),
        .depSF4 = arrayDep(3, 6),
        .p5 = arrayDep(4, 1),
        .n5 = arrayDep(4, 2),
        .cpf5 = CPFretiraMascara(arrayDep(4, 3)),
        .nas5 = dataAAAAMMDD(arrayDep(4, 4)),
        .depIR5 = arrayDep(5, 5),
        .depSF5 = arrayDep(5, 6),
        .p6 = arrayDep(5, 1),
        .n6 = arrayDep(5, 2),
        .cpf6 = CPFretiraMascara(arrayDep(5, 3)),
        .nas6 = dataAAAAMMDD(arrayDep(5, 4)),
        .depIR6 = arrayDep(6, 5),
        .depSF6 = arrayDep(6, 6),
        .Cracha = FColMant.col_12nomeCracha.Text,
        .Cargo = FColMant.col_12funcao.Text,
        .ASOadmissao = dataAAAAMMDD(FColMant.col_12ASOadmissao.Text),
        .Admissao = dataAAAAMMDD(FColMant.col_12Admissao.Text),
        .AdmissaoRef = FColMant.col_12Admissao.Text.Substring(3),
        .DependentesIR = FColMant.ListViewDependente.Items.Count(),
        .Cbo = FColMant.col_12CBO.Text,
        .Setor = FColMant.col_12Setor.Text,
        .ASOrescisao = dataAAAAMMDD(FColMant.col_12ASOrescisao.Text),
        .rescisao = dataAAAAMMDD(FColMant.col_12rescisao.Text)
        }}

        Return lista
    End Function

    Public Shared Function GetColaboradorTelaPesquisa() As List(Of colaborador)

        Dim oi As New MsgShow
        oi.title = "Cadastro de Colaborador"

        Dim arrayDep(10, 7) As String
        Dim i As Integer = 0
        Dim rgEmissao, rgValidade As String
        Dim cnhEmissao, cnhValidade As String
        Dim dataAgora As String = Now

        dataAgora = dataAAAAMMDD(dataAgora.Substring(0, 10))

        rgEmissao = FcolShow.col_01_rgEmissao.Text
        rgValidade = FcolShow.col_01_rgValidade.Text
        cnhEmissao = FcolShow.col_01_cnhEmissao.Text
        cnhValidade = FcolShow.col_01_cnhValidade.Text

        Dim strAdmissaoTeste As String = FcolShow.col_12Admissao.Text



        Dim strRef As String = FcolShow.col_12Admissao.Text.Substring(3)


        For Each dep As Object In FcolShow.ListViewDependente.Items

            arrayDep(i, 1) = dep.text               ' Grau de parentesco
            arrayDep(i, 2) = dep.subitems(1).text   ' Nome do dependente
            arrayDep(i, 3) = dep.subitems(2).text   ' Data de CPF
            arrayDep(i, 4) = dep.subitems(3).text   ' Data de nascimento
            arrayDep(i, 5) = dep.subitems(5).text   ' IR
            arrayDep(i, 6) = dep.subitems(6).text   ' SF
            i += 1

        Next

        Dim auxInstrucao As String = ""

        Dim lista As New List(Of colaborador) From {
            New colaborador() With {
                .Chave = FcolShow.lblChave.Text,
                .CPF = FcolShow.lblCPF.Text,
                .Nome = FcolShow.txtNome.Text,
                .Nascimento = FcolShow.mskNascimento.Text,
                .rg = FcolShow.col_01_rg.Text,
                .rgOE = FcolShow.col_01_rgOE.Text,
                .rgOEuf = FcolShow.col_01_rgOEuf.Text,
                .rgEmissao = rgEmissao,
                .rgValidade = rgValidade,
                .cnh = FcolShow.col_01_cnh.Text,
                .cnhOE = FcolShow.col_01_cnhOE.Text,
                .cnhOEuf = FcolShow.col_01_cnhOEuf.Text,
                .cnhEmissao = FcolShow.col_01_cnhEmissao.Text,
                .cnhValidade = FcolShow.col_01_cnhValidade.Text,
                .PISvalidade = FcolShow.col_01_PISvalidade.Text,
                .te = FcolShow.col_01_te.Text,
                .teOE = FcolShow.col_01_teOE.Text,
                .teOEuf = FcolShow.col_01_teOEuf.Text,
                .teEmissao = FcolShow.col_01_teEmissao.Text,
                .teValidade = FcolShow.col_01_teValidade.Text,
                .teZona = FcolShow.col_01_teZona.Text,
                .teSecao = FcolShow.col_01_teSecao.Text,
                .CTPS = FcolShow.col_01_CTPS.Text,
                .CTPSserie = FcolShow.col_01_CTPSserie.Text,
                .CTPSOE = FcolShow.col_01_CTPSOE.Text,
                .CTPSOEuf = FcolShow.col_01_CTPSOEuf.Text,
                .CTPSvalidade = FcolShow.col_01_CTPSvalidade.Text,
                .CTPSemissao = FcolShow.col_01_CTPSemissao.Text,
                .Mae = FcolShow.col_02_Mae.Text,
                .MaeNascimento = FcolShow.col_02_MaeNascimento.Text,
                .MaeCPF = FcolShow.col_02_MaeCPF.Text,
                .MaeFone = FColMant.col_02_MaeFone.Text,
                .pai = FcolShow.col_02_pai.Text,
                .paiNascimento = FcolShow.col_02_paiNascimento.Text,
                .paiCPF = FcolShow.col_02_paiCPF.Text,
                .paiFone = FcolShow.col_02_paiFone.Text,
                .Sexo = FcolShow.col_03Sexo.Text,
                .EstadoCivil = FcolShow.col_03EstadoCivil.Text.Substring(0, 1),
                .UniaoEstavel = IIf(FcolShow.col_03UniaoEstavel.Checked, "1", "0"),
                .Esposa = FcolShow.col_03Esposa.Text,
                .EsposaCPF = FcolShow.col_03EsposaCPF.Text,
                .EsposaFone = FcolShow.col_03EsposaFone.Text,
                .EsposaNascimento = FcolShow.col_03EsposaNascimento.Text,
                .Companheira = FcolShow.col_03Companheira.Text,
                .CompanheiraCPF = FcolShow.col_03CompanheiraCPF.Text,
                .CompanheiraFone = FcolShow.col_03CompanheiraFone.Text,
                .CompanheiraNascimento = FcolShow.col_03CompanheiraNascimento.Text,
                .Fone1 = LimpaNumero(FcolShow.col_04Fone1.Text),
                .Fone2 = LimpaNumero(FcolShow.col_04Fone2.Text),
                .email = FcolShow.col_04Email.Text,
                .AutorizaComunicaEmail = IIf(FcolShow.col_04AutorizaComunicaEmail.Checked, 1, 0),
                .endereco = FcolShow.col_05endereco.Text,
                .cidade = FcolShow.col_05cidade.Text,
                .EndUF = FcolShow.cmbEndUF.Text,
                .cep = FcolShow.col_05cep.Text,
                .Instrucao = auxInstrucao,
                .Curso = FcolShow.col_06Curso.Text,
                .ConselhoRegional = FcolShow.col_06ConselhoRegional.Text,
                .ConselhoRegionalNumero = FcolShow.col_06ConselhoRegionalNumero.Text,
                .ConselhoRegionalData = FcolShow.col_06ConselhoRegionalData.Text,
                .ConselhoRegionalOE = FcolShow.col_06OE.Text,
                .banco = FcolShow.col_08banco.Text,
                .agencia = FcolShow.col_08agencia.Text,
                .agenciaDigito = FcolShow.col_08agenciaDigito.Text,
                .conta = FcolShow.col_08conta.Text,
                .contaDigito = FcolShow.col_08contaDigito.Text, 'local
                .altura = IIf(Trim(FcolShow.col_10altura.Text) = ":", "", FcolShow.col_10altura.Text),
                .PIX = FcolShow.col_08PIX_numero.Text,
                .PIXidentificacao = FcolShow.col_08pix_identificacao.Text,
                .peso = FcolShow.col_10peso.Text,
                .cabelo = FcolShow.col_10cabelo.Text,
                .olhos = FcolShow.col_10olhos.Text,
                .tipoSangue = FcolShow.col_10tipoSangue.Text,
                .cor = FcolShow.col_10cor.Text,
                .deficiente = IIf(FcolShow.col_10deficiente.Checked, 1, 0),
                .deficienteTipo = FcolShow.col_10deficienteTipo.Text,
                .deficienteOutros = FcolShow.col_10deficienteOutros.Text,
                .nome1 = FcolShow.col_11nome1.Text,
                .Telefone1 = LimpaNumero(FcolShow.col_11Telefone1.Text),
                .conhecimento1 = FcolShow.col_11conhecimento1.Text,
                .Nome2 = FcolShow.col_11Nome2.Text,
                .Telefone2 = LimpaNumero(FcolShow.col_11Telefone2.Text),
                .Conhecimento2 = FcolShow.col_11Conhecimento2.Text,
                .Empresa1 = FcolShow.col_11Empresa1.Text,
                .Contato1 = FcolShow.col_11Contato1.Text,
                .EmpresaTel1 = LimpaNumero(FcolShow.col_11EmpresaTel1.Text),
                .Empresa2 = FcolShow.col_11Empresa2.Text,
                .Contato2 = FcolShow.col_11Contato2.Text,
                .EmpresaTel2 = LimpaNumero(FcolShow.col_11EmpresaTel2.Text),
                .p1 = arrayDep(0, 1),
                .n1 = arrayDep(0, 2),
                .cpf1 = arrayDep(0, 3),
                .nas1 = arrayDep(0, 4),
                .depIR1 = arrayDep(0, 5),
                .depSF1 = arrayDep(0, 6),
                .p2 = arrayDep(1, 1),
                .n2 = arrayDep(1, 2),
                .cpf2 = arrayDep(1, 3),
                .nas2 = arrayDep(1, 4),
                .depIR2 = arrayDep(1, 5),
                .depSF2 = arrayDep(1, 6),
                .p3 = arrayDep(2, 1),
                .n3 = arrayDep(2, 2),
                .cpf3 = arrayDep(2, 3),
                .nas3 = arrayDep(2, 4),
                .depIR3 = arrayDep(2, 5),
                .depSF3 = arrayDep(2, 6),
                .p4 = arrayDep(3, 1),
                .n4 = arrayDep(3, 2),
                .cpf4 = arrayDep(3, 3),
                .nas4 = arrayDep(3, 4),
                .depIR4 = arrayDep(3, 5),
                .depSF4 = arrayDep(3, 6),
                .p5 = arrayDep(4, 1),
                .n5 = arrayDep(4, 2),
                .cpf5 = arrayDep(4, 3),
                .nas5 = arrayDep(4, 4),
                .depIR5 = arrayDep(4, 5),
                .depSF5 = arrayDep(4, 6),
                .p6 = arrayDep(5, 1),
                .n6 = arrayDep(5, 2),
                .cpf6 = arrayDep(5, 3),
                .nas6 = arrayDep(5, 4),
                .depIR6 = arrayDep(5, 5),
                .depSF6 = arrayDep(5, 6),
                .Cracha = FcolShow.col_12nomeCracha.Text,
                .Cargo = FcolShow.col_12cargo.Text,
                .ASOadmissao = FcolShow.col_12ASOadmissao.Text,
                .Admissao = FcolShow.col_12Admissao.Text,
                .AdmissaoRef = strRef,
                .DependentesTotais = FcolShow.ListViewDependente.Items.Count(),
                .DependentesIR = FcolShow.LblirQTO.Text,
                .DependentesSF = FcolShow.LblirQTO.Text
            }}

        Return lista
    End Function


End Class
