Imports System.ComponentModel

Public Class frmFolhaRescisaoManual
    Public oi As New MsgShow
    Private Sub frmFolhaRescisaoManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim patrao As List(Of empregador) = EmpregadorAcao.GetEmpregadorRescisao()


        Lc1.Text = patrao(0).CnpjCab
        Lc2.Text = patrao(0).RazaoSocialCab
        Lc3.Text = patrao(0).EnderecoCab
        Lc4.Text = patrao(0).BairroCab
        Lc5.Text = patrao(0).MunicipioCab
        Lc6.Text = patrao(0).UfCab
        Lc7.Text = patrao(0).CEPCab
        Lc8.Text = patrao(0).CNAECab
        Lc9.Text = patrao(0).CNPJTomadorObra

        L1.Text = CNPJcolocaMascara(patrao(0).Cnpj)
        L2.Text = patrao(0).RazaoSocial
        L3.Text = patrao(0).Endereco & ", " & patrao(0).enderecoNumero & " " & patrao(0).enderecoComplemento
        L4.Text = patrao(0).Bairro
        L5.Text = patrao(0).Municipio
        L6.Text = patrao(0).Uf
        L7.Text = patrao(0).CEP
        L8.Text = patrao(0).CNAE
        L9.Text = ""

    End Sub

    Private Sub BtnImprime_Click(sender As Object, e As EventArgs) Handles BtnImprime.Click

        FrmFolhaRescisaoManualRel.Show()

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        Dim strKeyCol As String = MskkeyCol.Text

        Dim contrato As List(Of FolhaColContrato) = FolhaColContratoAcao.GetEmpregadorFolhaColContrato(strKeyCol)

        Dim trb As List(Of Trabalhador) = TrabalhadorAcao.GetTrabalhadorRescisao(strKeyCol)




        lblPIS.Text = trb(0).PisPasep
        lblNome.Text = trb(0).Nome
        lblEndereco.Text = trb(0).Endereco
        LblBairro.Text = trb(0).Bairro
        lblcidade.Text = trb(0).Cidade
        lblUF.Text = trb(0).UF
        LblCep.Text = trb(0).CEP
        LblCTPS.Text = trb(0).CTPS
        LblCPF.Text = trb(0).Cpf
        LblNascimento.Text = trb(0).Nascimento
        lblMae.Text = trb(0).Mae

        'trb(0).Nascimento
        lblMaeCab.Text = trb(0).MaeCab
        LblNascimentoCAb.Text = trb(0).NascimentoCab
        LblCPFcab.Text = trb(0).CpfCab
        LblCTPScab.Text = trb(0).CTPSCab
        lblCEPcab.Text = trb(0).CEPCab
        lblPISCab.Text = trb(0).PisPasepCab
        lblNomeCab.Text = trb(0).NomeCab
        lblEnderecoCab.Text = trb(0).EnderecoCab
        LblBairroCab.Text = trb(0).BairroCab
        lblcidadeCab.Text = trb(0).CidadeCab
        lblUFcab.Text = trb(0).UFCab

        LblcontrTipoCab.Text = contrato(0).TipoCab
        LblcontrTipo.Text = contrato(0).ContratoTipo
        LblcontrAfastamentoCausaCab.Text = contrato(0).AfastamentoCab
        LblcontrAfastamentoCausa.Text = contrato(0).AfastamentoCausa
        LblcontrRemuneracaMesAnteriorCab.Text = contrato(0).RemuneracaoMesAnteriorCab
        LblcontrRemuneracaMesAnterior.Text = Trim(numeroLatino(contrato(0).RemuneracaoMesAnterior, 10, True))
        LblcontrSindicalCodCab.Text = contrato(0).SindicalCodigoCab
        LblcontrSindicalCod.Text = contrato(0).SindicalCodigo
        LblcontrAdmissaoDataCab.Text = contrato(0).AdmissaoDataCab
        LblcontrAdmissaoData.Text = dataLatina(contrato(0).AdmissaoData)
        LblcontrAvisoDataCab.Text = contrato(0).AvisoPrevioDataCab
        LblcontrAvisoData.Text = dataLatina(contrato(0).AvisoPrevioData)
        LblcontrCNPJsindicalCab.Text = contrato(0).CNPJEntidadeSindicalCab
        LblcontrCNPJsindical.Text = contrato(0).CNPJEntidadeSindical
        LblcontrAfastamentoDataCab.Text = contrato(0).AfastamentoDataCab
        LblcontrAfastamentoData.Text = dataLatina(contrato(0).AfastamentoData)
        LblcontrAfastamentoCodigoCab.Text = contrato(0).AfastamentoCodigoCab
        LblcontrAfastamentoCodigo.Text = contrato(0).AfastamentoCodigo
        LblcontrPensaoTRCTCab.Text = contrato(0).PensaoAlimenticiaTRCTCab
        LblcontrPensaoTRCT.Text = contrato(0).PensaoAlimenticiaTRCT
        LblcontrPensaoFGTScab.Text = contrato(0).PensaoAlimenticiaFGTSCab
        LblcontrPensaoFGTS.Text = contrato(0).PensaoAlimenticiaFGTS
        LblcontrCategoriacab.Text = contrato(0).CategoriaCab
        LblcontrCategoria.Text = contrato(0).Categoria

        LblTitulo0.Text = contrato(0).Vr_l0_titulo0CAb

        LblTitulo1.Text = contrato(0).Vr_l1_Titulo1CAb

        LblRubrica1.Text = contrato(0).Vr_l2_Titulo1CAb
        LblValor1.Text = contrato(0).Vr_l2_Titulo2CAb
        LblRubrica2.Text = contrato(0).Vr_l2_Titulo3CAb
        LblValor2.Text = contrato(0).Vr_l2_Titulo4CAb
        LblRubrica3.Text = contrato(0).Vr_l2_Titulo5CAb
        LblValor3.Text = contrato(0).Vr_l2_Titulo6CAb

        Lbl50cab.Text = contrato(0).Vr_l3_1CAb
        Lbl50.Text = "0,00"
        Lbl51cab.Text = contrato(0).Vr_l3_2CAb
        Lbl51.Text = "0,00"
        Lbl52Cab.Text = contrato(0).Vr_l3_3CAb
        Lbl52.Text = "0,00"

        Lbl53Cab.Text = contrato(0).Vr_l4_1CAb
        Lbl53.Text = "0,00"
        Lbl54Cab.Text = contrato(0).Vr_l4_2CAb
        Lbl54.Text = "0,00"
        Lbl55Cab.Text = contrato(0).Vr_l4_3CAb
        Lbl55.Text = "0,00"

        Lbl56Cab.Text = contrato(0).Vr_l5_1CAb
        Lbl56.Text = "0,00"
        Lbl57Cab.Text = contrato(0).Vr_l5_2CAb
        Lbl57.Text = "0,00"
        Lbl58Cab.Text = contrato(0).Vr_l5_3CAb
        Lbl58.Text = "0,00"

        Lbl59Cab.Text = contrato(0).Vr_l6_1CAb
        Lbl59.Text = "0,00"
        Lbl60Cab.Text = contrato(0).Vr_l6_2CAb
        Lbl60.Text = "0,00"
        Lbl62Cab.Text = contrato(0).Vr_l6_3CAb
        Lbl62.Text = "0,00"

        Lbl63Cab.Text = contrato(0).Vr_l7_1CAb
        Lbl63.Text = "0,00"
        Lbl64Cab.Text = contrato(0).Vr_l7_2CAb
        Lbl64.Text = "0,00"
        Lbl65Cab.Text = contrato(0).Vr_l7_3CAb
        Lbl65.Text = "0,00"

        Lbl66Cab.Text = contrato(0).Vr_l8_1CAb
        Lbl66.Text = "0,00"
        Lbl68Cab.Text = contrato(0).Vr_l8_2CAb
        Lbl68.Text = "0,00"
        Lbl69Cab.Text = contrato(0).Vr_l8_3CAb
        Lbl69.Text = "0,00"

        Lbl70Cab.Text = contrato(0).Vr_l9_1CAb
        Lbl70.Text = "0,00"
        Lbl71Cab.Text = contrato(0).Vr_l9_2CAb
        Lbl71.Text = "0,00"
        Lbl95Cab.Text = contrato(0).Vr_l9_3CAb
        Lbl95.Text = "0,00"

        Lbl99Cab.Text = contrato(0).Vr_l10_1CAb
        Lbl99.Text = "0,00"
        Lbl100Cab.Text = contrato(0).Vr_l10_2CAb
        Lbl100.Text = "0,00"

        LblDedTituloDeducoesCab.Text = contrato(0).Vr_l11_1CAb

        LbldedDesconto1Cab.Text = contrato(0).Vr_l11_2CAb
        LbldedValor1Cab.Text = contrato(0).Vr_l11_3CAb
        LbldedDesconto2Cab.Text = contrato(0).Vr_l11_4CAb
        LbldedValor2Cab.Text = contrato(0).Vr_l11_5CAb
        LbldedDesconto3Cab.Text = contrato(0).Vr_l11_6CAb
        LbldedValor3Cab.Text = contrato(0).Vr_l11_7CAb

        LblDed100Cab.Text = contrato(0).Vr_l12_1CAb
        LblDed100.Text = "0,00"
        LblDed101Cab.Text = contrato(0).Vr_l12_2CAb
        LblDed101.Text = "0,00"
        LblDed102Cab.Text = contrato(0).Vr_l12_3CAb
        LblDed102.Text = "0,00"

        LblDed103Cab.Text = contrato(0).Vr_l13_1CAb
        LblDed103.Text = "0,00"
        LblDed112_1Cab.Text = contrato(0).Vr_l13_2CAb
        LblDed112_1.Text = "0,00"
        LblDed112_2Cab.Text = contrato(0).Vr_l13_3CAb
        LblDed112_2.Text = "0,00"

        LblDed112_3Cab.Text = contrato(0).Vr_l14_1CAb
        LblDed112_3.Text = "0,00"
        LblDed114_1Cab.Text = contrato(0).Vr_l14_2CAb
        LblDed114_1.Text = "0,00"
        LblDed114_2Cab.Text = contrato(0).Vr_l14_3CAb
        LblDed114_2.Text = "0,00"

        LblDed115_1Cab.Text = contrato(0).Vr_l15_1CAb
        LblDed115_1.Text = "0,00"
        LblDed115_2Cab.Text = contrato(0).Vr_l15_2CAb
        LblDed115_2.Text = "0,00"

        LblDedTotalDeducoesCab.Text = Space(2) & contrato(0).Vr_l16_1CAb
        LblDedTotalDeducoes.Text = "0,00" & Space(2)
        LblDedTotalLiquidoCab.Text = Space(2) & contrato(0).Vr_l16_2CAb
        LblDedTotalLiquido.Text = "0,00" & Space(2)

        VerbasRescisoriasSoma()

        '''''Lbl95Cab.Text = contrato(0).Vr_l9_3CAb
        ''''    Public Property Vr_l10_1CAb As String = "99 Ajuste de Saldo Devedor"
        ''''Public Property Vr_l10_1 As String
        ''''Public Property Vr_l10_2CAb As String = "TOTAL BRUTO"
    End Sub

    Private Sub Lbl50cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl50cab.DoubleClick

        LblVerbasRescisoriasRubricaCab.Text = Lbl50cab.Text
        LblVerbasRescisoriasValor.Text = Lbl50.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl50cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl50.Text
        LbledicaoVerbasRecisoriasIndice.Text = 1
        edicaoControleVariaveis(True)
        'lblEdicaoNome.Text = LblRubrica1.Name
        'lblEdicaoConteudo.text = LblRubrica1.Text
    End Sub

    Private Sub EdicaoControleVariaveis(booLiga As Boolean)

        GruVerbasRescisorias.Enabled = Not booLiga
        GruEdicaoVerbasRescisoria.Enabled = booLiga
        If GruVerbasRescisorias.Enabled Then
            LblVerbasRescisoriasRubricaCab.Text = "Rubrica"
            LblVerbasRescisoriasValor.Text = "Valor"
            TxtVerbasRescisoriasRubricaCab.Text = "Rubrica"
            TxtVerbasRescisoriasValor.Text = "0,00"
        End If


    End Sub

    Private Function SomaLiquida() As String

        Dim decSoma As Decimal = 0
        Dim strSinal As String = ""

        decSoma = Math.Round(Val(MoneyUSA(Lbl100.Text)) - Val(MoneyUSA(LblDedTotalDeducoes.Text)), 2)

        If decSoma < 0 Then strSinal = "- " : decSoma = -decSoma

        SomaLiquida = strSinal & Trim(MoneyLatino(decSoma))

        Return SomaLiquida

    End Function
    Private Sub edicaoControleVariaveisDeducoes(booLiga As Boolean)

        GruDeducoes.Enabled = Not booLiga
        GruEdicaoVerbasRescisoriaDeducoes.Enabled = booLiga

        If GruDeducoes.Enabled Then
            LblRubricaDeducoesCab.Text = "Rubrica"
            LblValorDeducoes.Text = "Valor"
            TxtRubricaDeducoesCab.Text = "Rubrica"
            TxtValorDeducoes.Text = "0,00"
        End If

    End Sub


    Private Sub EdicaoRescisao(intVariavel As Integer)

        Dim intCondicaoContrato As Integer = intVariavel

        Select Case intCondicaoContrato

            Case 1

                Lbl50cab.Text = TxtVerbasRescisoriasRubricaCab.Text   ' contrato(0).Vr_l3_1CAb
                Lbl50.Text = TxtVerbasRescisoriasValor.Text         ' contrato(0).Vr_l3_1
            Case 2
                Lbl51cab.Text = TxtVerbasRescisoriasRubricaCab.Text      ' contrato(0).Vr_l3_2CAb
                Lbl51.Text = TxtVerbasRescisoriasValor.Text
            Case 3
                Lbl52Cab.Text = TxtVerbasRescisoriasRubricaCab.Text           'contrato(0).Vr_l3_3CAb
                Lbl52.Text = TxtVerbasRescisoriasValor.Text         '
            Case 4
                Lbl53Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l4_1CAb
                Lbl53.Text = TxtVerbasRescisoriasValor.Text
            Case 5
                Lbl54Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l4_2CAb
                Lbl54.Text = TxtVerbasRescisoriasValor.Text
            Case 6
                Lbl55Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l4_3CAb
                Lbl55.Text = TxtVerbasRescisoriasValor.Text
            Case 7
                Lbl56Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l5_1CAb
                Lbl56.Text = TxtVerbasRescisoriasValor.Text
            Case 8
                Lbl57Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l5_2CAb
                Lbl57.Text = TxtVerbasRescisoriasValor.Text
            Case 9
                Lbl58Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l5_3CAb
                Lbl58.Text = TxtVerbasRescisoriasValor.Text
            Case 10

                Lbl59Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l6_1CAb
                Lbl59.Text = TxtVerbasRescisoriasValor.Text
            Case 11
                Lbl60Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l6_2CAb
                Lbl60.Text = TxtVerbasRescisoriasValor.Text
            Case 12
                Lbl62Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l6_3CAb
                Lbl62.Text = TxtVerbasRescisoriasValor.Text
            Case 13
                Lbl63Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l7_1CAb
                Lbl63.Text = TxtVerbasRescisoriasValor.Text
            Case 14
                Lbl64Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l7_2CAb
                Lbl64.Text = TxtVerbasRescisoriasValor.Text
            Case 15
                Lbl65Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l7_3CAb
                Lbl65.Text = TxtVerbasRescisoriasValor.Text
            Case 16
                Lbl66Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l8_1CAb
                Lbl66.Text = TxtVerbasRescisoriasValor.Text
            Case 17
                Lbl68Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l8_2CAb
                Lbl68.Text = TxtVerbasRescisoriasValor.Text
            Case 18
                Lbl69Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l8_3CAb
                Lbl69.Text = TxtVerbasRescisoriasValor.Text
            Case 19
                Lbl70Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l9_1CAb
                Lbl70.Text = TxtVerbasRescisoriasValor.Text
            Case 20
                Lbl71Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l9_2CAb
                Lbl71.Text = TxtVerbasRescisoriasValor.Text
            Case 21
                Lbl95Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l9_3CAb
                Lbl95.Text = TxtVerbasRescisoriasValor.Text
            Case 22
                Lbl99Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l10_1CAb
                Lbl99.Text = TxtVerbasRescisoriasValor.Text
            Case 23
                Lbl100Cab.Text = TxtVerbasRescisoriasRubricaCab.Text    ' contrato(0).Vr_l10_2CAb
                Lbl100.Text = TxtVerbasRescisoriasValor.Text


        End Select

        Lbl100.Text = MoneyLatino(VerbasRescisoriasSoma())

        'Select Case intCondicaoContrato
        '    Case 1
        '        LblcontrTipoCab.Text = TxtCab.Text      'contrato(0).TipoCab
        '        LblcontrTipo.Text = Txt.Text            'contrato(0).ContratoTipo
        '    Case 2
        '        LblcontrAfastamentoCausaCab.Text = TxtCab.Text      'contrato(0).AfastamentoCab
        '        LblcontrAfastamentoCausa.Text = Txt.Text            'contrato(0).AfastamentoCausa
        '    Case 3



        '        LblcontrRemuneracaMesAnteriorCab.Text = TxtCab.Text         ' contrato(0).RemuneracaoMesAnteriorCab
        '        LblcontrRemuneracaMesAnterior.Text = Txt.Text           'Trim(numeroLatino(contrato(0).RemuneracaoMesAnterior, 10, True))
        '    Case 4
        '        LblcontrSindicalCodCab.Text = TxtCab.Text       'contrato(0).SindicalCodigoCab
        '        LblcontrSindicalCod.Text = Txt.Text             'contrato(0).SindicalCodigo
        '    Case 5
        '        LblcontrAdmissaoDataCab.Text = TxtCab.Text      'contrato(0).AdmissaoDataCab
        '        LblcontrAdmissaoData.Text = Txt.Text            'dataLatina(contrato(0).AdmissaoData)
        '    Case 6
        '        LblcontrAvisoDataCab.Text = TxtCab.Text         'contrato(0).AvisoPrevioDataCab
        '        LblcontrAvisoData.Text = Txt.Text           'dataLatina(contrato(0).AvisoPrevioData)
        '    Case 7
        '        LblcontrCNPJsindicalCab.Text = TxtCab.Text      'contrato(0).CNPJEntidadeSindicalCab
        '        LblcontrCNPJsindical.Text = Txt.Text            'contrato(0).CNPJEntidadeSindical
        '    Case 8
        '        LblcontrAfastamentoDataCab.Text = TxtCab.Text       'contrato(0).AfastamentoDataCab
        '        LblcontrAfastamentoData.Text = Txt.Text             'dataLatina(contrato(0).AfastamentoData)
        '    Case 9
        '        LblcontrAfastamentoCodigoCab.Text = TxtCab.Text         'contrato(0).AfastamentoCodigoCab
        '        LblcontrAfastamentoCodigo.Text = Txt.Text           'contrato(0).AfastamentoCodigo
        '    Case 10
        '        LblcontrPensaoTRCTCab.Text = TxtCab.Text        'contrato(0).PensaoAlimenticiaTRCTCab
        '        LblcontrPensaoTRCT.Text = Txt.Text          'contrato(0).PensaoAlimenticiaTRCT
        '    Case 11
        '        LblcontrPensaoFGTScab.Text = TxtCab.Text        'contrato(0).PensaoAlimenticiaFGTSCab
        '        LblcontrPensaoFGTS.Text = Txt.Text          'contrato(0).PensaoAlimenticiaFGTS
        '    Case 12
        '        LblcontrCategoriacab.Text = TxtCab.Text         'contrato(0).CategoriaCab
        '        LblcontrCategoria.Text = Txt.Text           'contrato(0).Categoria
        '    Case 13
        '        LblTitulo0.Text = TxtCab.Text       'contrato(0).Vr_l0_titulo0CAb
        '    Case 14
        '        LblTitulo1.Text = TxtCab.Text       'contrato(0).Vr_l1_Titulo1CAb
        '    Case 15
        '        LblRubrica1.Text = TxtCab.Text      'contrato(0).Vr_l2_Titulo1CAb
        '        LblValor1.Text = Txt.Text           'contrato(0).Vr_l2_Titulo2CAb
        '    Case 16
        '        LblRubrica2.Text = TxtCab.Text      'contrato(0).Vr_l2_Titulo3CAb
        '        LblValor2.Text = Txt.Text           'contrato(0).Vr_l2_Titulo4CAb
        '    Case 17
        '        LblRubrica3.Text = TxtCab.Text      'contrato(0).Vr_l2_Titulo5CAb
        '        LblValor3.Text = Txt.Text           'contrato(0).Vr_l2_Titulo6CAb

        'End Select



    End Sub
    Private Sub EdicaoRescisaoDeducao(intVariavel As Integer)


        Dim intCondicaoContrato As Integer = intVariavel

        Select Case intCondicaoContrato

            Case 1

                LblDed100Cab.Text = TxtRubricaDeducoesCab.Text   ' contrato(0).Vr_l3_1CAb
                LblDed100.Text = TxtValorDeducoes.Text         ' contrato(0).Vr_l3_1
            Case 2
                LblDed101Cab.Text = TxtRubricaDeducoesCab.Text      ' contrato(0).Vr_l3_2CAb
                LblDed101.Text = TxtValorDeducoes.Text
            Case 3
                LblDed102Cab.Text = TxtRubricaDeducoesCab.Text           'contrato(0).Vr_l3_3CAb
                LblDed102.Text = TxtValorDeducoes.Text         '
            Case 4
                LblDed103Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l4_1CAb
                LblDed103.Text = TxtValorDeducoes.Text
            Case 5
                LblDed112_1Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l4_2CAb
                LblDed112_1.Text = TxtValorDeducoes.Text
            Case 6
                LblDed112_2Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l4_3CAb
                LblDed112_2.Text = TxtValorDeducoes.Text
            Case 7
                LblDed114_1Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l5_1CAb
                LblDed114_1.Text = TxtValorDeducoes.Text
            Case 8
                LblDed114_1Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l5_2CAb
                LblDed114_1.Text = TxtValorDeducoes.Text
            Case 9
                LblDed114_2Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l5_3CAb
                LblDed114_2.Text = TxtValorDeducoes.Text
            Case 10

                LblDed115_1Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l6_1CAb
                LblDed115_1.Text = TxtValorDeducoes.Text
            Case 11
                LblDed115_2Cab.Text = TxtRubricaDeducoesCab.Text    ' contrato(0).Vr_l6_2CAb
                LblDed115_2.Text = TxtValorDeducoes.Text

        End Select

        LblDedTotalDeducoes.Text = MoneyLatino(VerbasRescisoriasDeducoesSoma)

    End Sub
    Private Function VerbasRescisoriasSoma()

        Dim DecSoma As Decimal
        DecSoma = MoneyUSA(Lbl50.Text) / 100
        DecSoma += MoneyUSA(Lbl53.Text) / 100
        DecSoma += MoneyUSA(Lbl56.Text) / 100
        DecSoma += MoneyUSA(Lbl59.Text) / 100
        DecSoma += MoneyUSA(Lbl63.Text) / 100
        DecSoma += MoneyUSA(Lbl66.Text) / 100
        DecSoma += MoneyUSA(Lbl70.Text) / 100
        DecSoma += MoneyUSA(Lbl99.Text) / 100
        DecSoma += MoneyUSA(Lbl51.Text) / 100
        DecSoma += MoneyUSA(Lbl54.Text) / 100
        DecSoma += MoneyUSA(Lbl57.Text) / 100
        DecSoma += MoneyUSA(Lbl60.Text) / 100
        DecSoma += MoneyUSA(Lbl64.Text) / 100
        DecSoma += MoneyUSA(Lbl68.Text) / 100
        DecSoma += MoneyUSA(Lbl71.Text) / 100
        DecSoma += MoneyUSA(Lbl52.Text) / 100
        DecSoma += MoneyUSA(Lbl55.Text) / 100
        DecSoma += MoneyUSA(Lbl58.Text) / 100
        DecSoma += MoneyUSA(Lbl62.Text) / 100
        DecSoma += MoneyUSA(Lbl65.Text) / 100
        DecSoma += MoneyUSA(Lbl69.Text) / 100
        DecSoma += MoneyUSA(Lbl95.Text) / 100

        Return DecSoma

    End Function
    Private Function VerbasRescisoriasDeducoesSoma()

        Dim DecSoma As Decimal
        DecSoma = MoneyUSA(LblDed100.Text) / 100
        DecSoma += MoneyUSA(LblDed101.Text) / 100
        DecSoma += MoneyUSA(LblDed102.Text) / 100
        DecSoma += MoneyUSA(LblDed103.Text) / 100
        DecSoma += MoneyUSA(LblDed112_1.Text) / 100
        DecSoma += MoneyUSA(LblDed112_2.Text) / 100
        DecSoma += MoneyUSA(LblDed114_1.Text) / 100
        DecSoma += MoneyUSA(LblDed114_2.Text) / 100
        DecSoma += MoneyUSA(LblDed115_1.Text) / 100
        DecSoma += MoneyUSA(LblDed115_2.Text) / 100

        Return DecSoma

    End Function
    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        EdicaoRescisao(Int(LbledicaoVerbasRecisoriasIndice.Text))
        EdicaoControleVariaveis(False)
        LblDedTotalLiquido.Text = SomaLiquida()
    End Sub

    Private Sub Lbl51cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl51cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl51cab.Text
        LblVerbasRescisoriasValor.Text = Lbl51.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl51cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl51.Text
        LbledicaoVerbasRecisoriasIndice.Text = 2
        edicaoControleVariaveis(True)
    End Sub

    Private Sub BtnVerbasRescisoriasCancela_Click(sender As Object, e As EventArgs) Handles BtnVerbasRescisoriasCancela.Click

        edicaoControleVariaveis(False)

    End Sub

    Private Sub Lbl52Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl52Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl52Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl52.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl52Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl52.Text
        LbledicaoVerbasRecisoriasIndice.Text = 3
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl53Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl53Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl53Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl53.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl53Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl53.Text
        LbledicaoVerbasRecisoriasIndice.Text = 4
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl54Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl54Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl54Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl54.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl54Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl54.Text
        LbledicaoVerbasRecisoriasIndice.Text = 5
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl55Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl55Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl55Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl55.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl55Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl55.Text
        LbledicaoVerbasRecisoriasIndice.Text = 6
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl56Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl56Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl56Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl56.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl56Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl56.Text
        LbledicaoVerbasRecisoriasIndice.Text = 7
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl57Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl57Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl57Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl57.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl57Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl57.Text
        LbledicaoVerbasRecisoriasIndice.Text = 8
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl58Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl58Cab.DoubleClick
        LblVerbasRescisoriasRubricaCab.Text = Lbl58Cab.Text
        LblVerbasRescisoriasValor.Text = Lbl58.Text
        TxtVerbasRescisoriasRubricaCab.Text = Lbl58Cab.Text
        TxtVerbasRescisoriasValor.Text = Lbl58.Text
        LbledicaoVerbasRecisoriasIndice.Text = 9
        edicaoControleVariaveis(True)
    End Sub

    Private Sub Lbl59Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl59Cab.DoubleClick
        With Lbl59Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl59.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl59.Text
            LbledicaoVerbasRecisoriasIndice.Text = 10
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl60Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl60Cab.DoubleClick
        With Lbl60Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl60.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl60.Text
            LbledicaoVerbasRecisoriasIndice.Text = 11
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl62Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl62Cab.DoubleClick
        With Lbl62Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = .Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = .Text
            LbledicaoVerbasRecisoriasIndice.Text = 12
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl63Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl63Cab.DoubleClick
        With Lbl63Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl63.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl63.Text
            LbledicaoVerbasRecisoriasIndice.Text = 13
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl64Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl64Cab.DoubleClick
        With Lbl64Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl64.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl64.Text
            LbledicaoVerbasRecisoriasIndice.Text = 14
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl65Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl65Cab.DoubleClick
        With Lbl65Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl65.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl65.Text
            LbledicaoVerbasRecisoriasIndice.Text = 15
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl66Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl66Cab.DoubleClick
        With Lbl66Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl66.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl66.Text
            LbledicaoVerbasRecisoriasIndice.Text = 16
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl68Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl68Cab.DoubleClick
        With Lbl68Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl68.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl68.Text
            LbledicaoVerbasRecisoriasIndice.Text = 17
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl69Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl69Cab.DoubleClick
        With Lbl69Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl69.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl69.Text
            LbledicaoVerbasRecisoriasIndice.Text = 18
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl70Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl70Cab.DoubleClick
        With Lbl70Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl70.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl70.Text
            LbledicaoVerbasRecisoriasIndice.Text = 19
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl71Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl71Cab.DoubleClick
        With Lbl71Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl71.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl71.Text
            LbledicaoVerbasRecisoriasIndice.Text = 20
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl95Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl95Cab.DoubleClick
        With Lbl95Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl95.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl95.Text
            LbledicaoVerbasRecisoriasIndice.Text = 21
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub Lbl99Cab_DoubleClick(sender As Object, e As EventArgs) Handles Lbl99Cab.DoubleClick
        With Lbl99Cab
            LblVerbasRescisoriasRubricaCab.Text = .Text
            LblVerbasRescisoriasValor.Text = Lbl99.Text
            TxtVerbasRescisoriasRubricaCab.Text = .Text
            TxtVerbasRescisoriasValor.Text = Lbl99.Text
            LbledicaoVerbasRecisoriasIndice.Text = 22
            edicaoControleVariaveis(True)
        End With
    End Sub

    Private Sub TxtVerbasRescisoriasValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVerbasRescisoriasValor.KeyPress

        With TxtVerbasRescisoriasValor

            If e.KeyChar = Convert.ToChar(13) Then

                'lblExtenso.Text = Extenso(.Text)
                'txtValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                'lblReciboData.ForeColor = System.Drawing.Color.Maroon
                'LblReciboDataAponta.Visible = True
                'mskReciboData.Enabled = True
                'mskReciboData.Focus()

                BtnAlterar.Focus()

                Exit Sub

            End If

            If Asc(e.KeyChar) = 8 Then       ' BACKSPACE

                e.KeyChar = ""


                If .Text = "0,00" Then Exit Sub
                If .Text.Substring(0, 3) = "0,0" And .Text.Length = 4 Then .Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
                If .Text.Substring(0, 2) = "0," And .Text.Length = 4 Then .Text = "0,0" + .Text.Substring(.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
                If .Text.Length = 4 Then .Text = "0," + .Text.Substring(0, 1) + .Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

                .Text = .Text.Substring(0, .Text.Length - 1)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length


                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")
                Exit Sub

            End If

            If e.KeyChar >= "0" And e.KeyChar <= "9" Then

                Dim strComMascara As String = Trim(.Text)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length
                Dim strRetorno As String = ""
                Dim strPressionada As String = e.KeyChar

                e.KeyChar = ""

                If intSemMascara > 13 Then

                    Exit Sub

                End If

                If intSemMascara < 4 And strSemMascara.Substring(0, 1) = "0" Then

                    strSemMascara += strPressionada
                    strSemMascara = strSemMascara.Substring(1)

                Else

                    strSemMascara += strPressionada
                    intSemMascara += 1

                End If

                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")

            Else

                e.KeyChar = ""

                .Focus()


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With

    End Sub

    Private Sub TxtVerbasRescisoriasValor_GotFocus(sender As Object, e As EventArgs) Handles TxtVerbasRescisoriasValor.GotFocus

        SendKeys.Send("{END}")

    End Sub

    Private Sub LblDed100Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed100Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed100Cab.Text
        LblValorDeducoes.Text = LblDed100.Text
        TxtRubricaDeducoesCab.Text = LblDed100Cab.Text
        TxtValorDeducoes.Text = LblDed100.Text
        LblEdicaoDeducoesIndice.Text = 1
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub BtnDeducoesAltera_Click(sender As Object, e As EventArgs) Handles BtnDeducoesAltera.Click

        EdicaoRescisaoDeducao(Int(LblEdicaoDeducoesIndice.Text))
        edicaoControleVariaveisDeducoes(False)
        LblDedTotalLiquido.Text = SomaLiquida()

    End Sub

    Private Sub LblDed100Cab_Click(sender As Object, e As EventArgs) Handles LblDed100Cab.Click

    End Sub

    Private Sub TxtVerbasRescisoriasValor_TextChanged(sender As Object, e As EventArgs) Handles TxtVerbasRescisoriasValor.TextChanged

    End Sub

    Private Sub TxtValorDeducoes_TextChanged(sender As Object, e As EventArgs) Handles TxtValorDeducoes.TextChanged

    End Sub

    Private Sub TxtValorDeducoes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorDeducoes.KeyPress

        With TxtValorDeducoes

            If e.KeyChar = Convert.ToChar(13) Then

                BtnDeducoesAltera.Focus()

                Exit Sub

            End If

            If Asc(e.KeyChar) = 8 Then       ' BACKSPACE

                e.KeyChar = ""


                If .Text = "0,00" Then Exit Sub
                If .Text.Substring(0, 3) = "0,0" And .Text.Length = 4 Then .Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
                If .Text.Substring(0, 2) = "0," And .Text.Length = 4 Then .Text = "0,0" + .Text.Substring(.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
                If .Text.Length = 4 Then .Text = "0," + .Text.Substring(0, 1) + .Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

                .Text = .Text.Substring(0, .Text.Length - 1)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length


                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")
                Exit Sub

            End If

            If e.KeyChar >= "0" And e.KeyChar <= "9" Then

                Dim strComMascara As String = Trim(.Text)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length
                Dim strRetorno As String = ""
                Dim strPressionada As String = e.KeyChar

                e.KeyChar = ""

                If intSemMascara > 13 Then

                    Exit Sub

                End If

                If intSemMascara < 4 And strSemMascara.Substring(0, 1) = "0" Then

                    strSemMascara += strPressionada
                    strSemMascara = strSemMascara.Substring(1)

                Else

                    strSemMascara += strPressionada
                    intSemMascara += 1

                End If

                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")

            Else

                e.KeyChar = ""

                .Focus()


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With
    End Sub

    Private Sub LblDed101Cab_Click(sender As Object, e As EventArgs) Handles LblDed101Cab.Click

    End Sub

    Private Sub LblDed101Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed101Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed101Cab.Text
        LblValorDeducoes.Text = LblDed101.Text
        TxtRubricaDeducoesCab.Text = LblDed101Cab.Text
        TxtValorDeducoes.Text = LblDed101.Text
        LblEdicaoDeducoesIndice.Text = 2
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed102Cab_Click(sender As Object, e As EventArgs) Handles LblDed102Cab.Click

    End Sub

    Private Sub LblDed102Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed102Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed102Cab.Text
        LblValorDeducoes.Text = LblDed102.Text
        TxtRubricaDeducoesCab.Text = LblDed102Cab.Text
        TxtValorDeducoes.Text = LblDed102.Text
        LblEdicaoDeducoesIndice.Text = 3
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed103Cab_Click(sender As Object, e As EventArgs) Handles LblDed103Cab.Click

    End Sub

    Private Sub LblDed103Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed103Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed103Cab.Text
        LblValorDeducoes.Text = LblDed103.Text
        TxtRubricaDeducoesCab.Text = LblDed103Cab.Text
        TxtValorDeducoes.Text = LblDed103.Text
        LblEdicaoDeducoesIndice.Text = 4
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed112_1Cab_Click(sender As Object, e As EventArgs) Handles LblDed112_1Cab.Click

    End Sub

    Private Sub LblDed112_1Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed112_1Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed112_1Cab.Text
        LblValorDeducoes.Text = LblDed112_1.Text
        TxtRubricaDeducoesCab.Text = LblDed112_1Cab.Text
        TxtValorDeducoes.Text = LblDed112_1.Text
        LblEdicaoDeducoesIndice.Text = 5
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed112_2Cab_Click(sender As Object, e As EventArgs) Handles LblDed112_2Cab.Click

    End Sub

    Private Sub LblDed112_2Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed112_2Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed112_2Cab.Text
        LblValorDeducoes.Text = LblDed112_2.Text
        TxtRubricaDeducoesCab.Text = LblDed112_2Cab.Text
        TxtValorDeducoes.Text = LblDed112_2.Text
        LblEdicaoDeducoesIndice.Text = 6
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed112_3Cab_Click(sender As Object, e As EventArgs) Handles LblDed112_3Cab.Click

    End Sub

    Private Sub LblDed112_3Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed112_3Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed112_3Cab.Text
        LblValorDeducoes.Text = LblDed112_3.Text
        TxtRubricaDeducoesCab.Text = LblDed112_3Cab.Text
        TxtValorDeducoes.Text = LblDed112_3.Text
        LblEdicaoDeducoesIndice.Text = 7
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed114_1Cab_Click(sender As Object, e As EventArgs) Handles LblDed114_1Cab.Click

    End Sub

    Private Sub LblDed114_1Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed114_1Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed114_1Cab.Text
        LblValorDeducoes.Text = LblDed114_1.Text
        TxtRubricaDeducoesCab.Text = LblDed114_1Cab.Text
        TxtValorDeducoes.Text = LblDed114_1.Text
        LblEdicaoDeducoesIndice.Text = 8
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed114_2Cab_Click(sender As Object, e As EventArgs) Handles LblDed114_2Cab.Click

    End Sub

    Private Sub LblDed114_2Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed114_2Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed114_2Cab.Text
        LblValorDeducoes.Text = LblDed114_2.Text
        TxtRubricaDeducoesCab.Text = LblDed114_2Cab.Text
        TxtValorDeducoes.Text = LblDed114_2.Text
        LblEdicaoDeducoesIndice.Text = 9
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed115_1Cab_Click(sender As Object, e As EventArgs) Handles LblDed115_1Cab.Click

    End Sub

    Private Sub LblDed115_1Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed115_1Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed115_1Cab.Text
        LblValorDeducoes.Text = LblDed115_1.Text
        TxtRubricaDeducoesCab.Text = LblDed115_1Cab.Text
        TxtValorDeducoes.Text = LblDed115_1.Text
        LblEdicaoDeducoesIndice.Text = 10
        edicaoControleVariaveisDeducoes(True)
    End Sub

    Private Sub LblDed115_2Cab_Click(sender As Object, e As EventArgs) Handles LblDed115_2Cab.Click

    End Sub

    Private Sub LblDed115_2Cab_DoubleClick(sender As Object, e As EventArgs) Handles LblDed115_2Cab.DoubleClick
        LblRubricaDeducoesCab.Text = LblDed115_2Cab.Text
        LblValorDeducoes.Text = LblDed115_2.Text
        TxtRubricaDeducoesCab.Text = LblDed115_2Cab.Text
        TxtValorDeducoes.Text = LblDed115_2.Text
        LblEdicaoDeducoesIndice.Text = 11
        edicaoControleVariaveisDeducoes(True)
    End Sub
End Class