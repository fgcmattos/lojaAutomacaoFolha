
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmFolhaRescisaoManualRel
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmFolhaRescisaoManualRel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' identificacao do empregador
        folhaRescisao.SetParameterValue("cnpjCab", frmFolhaRescisaoManual.Lc1.Text)
        folhaRescisao.SetParameterValue("cnpj", frmFolhaRescisaoManual.L1.Text)
        folhaRescisao.SetParameterValue("razaoSocialCab", frmFolhaRescisaoManual.Lc2.Text)
        folhaRescisao.SetParameterValue("razaoSocial", frmFolhaRescisaoManual.L2.Text)
        folhaRescisao.SetParameterValue("enderecoCab", frmFolhaRescisaoManual.Lc3.Text)
        folhaRescisao.SetParameterValue("endereco", frmFolhaRescisaoManual.L3.Text)
        folhaRescisao.SetParameterValue("bairroCab", frmFolhaRescisaoManual.Lc4.Text)
        folhaRescisao.SetParameterValue("bairro", frmFolhaRescisaoManual.L4.Text)
        folhaRescisao.SetParameterValue("municipioCab", frmFolhaRescisaoManual.Lc5.Text)
        folhaRescisao.SetParameterValue("municipio", frmFolhaRescisaoManual.L5.Text)
        folhaRescisao.SetParameterValue("ufCab", frmFolhaRescisaoManual.Lc6.Text)
        folhaRescisao.SetParameterValue("uf", frmFolhaRescisaoManual.L6.Text)
        folhaRescisao.SetParameterValue("cepCab", frmFolhaRescisaoManual.Lc7.Text)
        folhaRescisao.SetParameterValue("cep", frmFolhaRescisaoManual.L7.Text)
        folhaRescisao.SetParameterValue("cnaeCab", frmFolhaRescisaoManual.Lc8.Text)
        folhaRescisao.SetParameterValue("cnae", frmFolhaRescisaoManual.L8.Text)
        folhaRescisao.SetParameterValue("tomadoraObraCab", frmFolhaRescisaoManual.Lc9.Text)
        folhaRescisao.SetParameterValue("tomadoraObra", frmFolhaRescisaoManual.L9.Text)
        ' fim da identificacao do emprengador

        ' Inicio do Trabalhador
        folhaRescisao.SetParameterValue("tblPISpasepCab", frmFolhaRescisaoManual.lblPISCab.Text)
        folhaRescisao.SetParameterValue("tblPISpasep", frmFolhaRescisaoManual.lblPIS.Text)
        folhaRescisao.SetParameterValue("tblNomeCab", frmFolhaRescisaoManual.lblNomeCab.Text)
        folhaRescisao.SetParameterValue("tblNome", frmFolhaRescisaoManual.lblNome.Text)
        folhaRescisao.SetParameterValue("tblEnderecoCab", frmFolhaRescisaoManual.lblEnderecoCab.Text)
        folhaRescisao.SetParameterValue("tblEndereco", frmFolhaRescisaoManual.lblEndereco.Text)
        folhaRescisao.SetParameterValue("tblBairroCab", frmFolhaRescisaoManual.LblBairroCab.Text)
        folhaRescisao.SetParameterValue("tblBairro", frmFolhaRescisaoManual.LblBairro.Text)
        folhaRescisao.SetParameterValue("tblMunicipioCab", frmFolhaRescisaoManual.lblcidadeCab.Text)
        folhaRescisao.SetParameterValue("tblMunicipio", frmFolhaRescisaoManual.lblcidade.Text)
        folhaRescisao.SetParameterValue("tblUFCab", frmFolhaRescisaoManual.lblUFcab.Text)
        folhaRescisao.SetParameterValue("tblUF", frmFolhaRescisaoManual.lblUF.Text)
        folhaRescisao.SetParameterValue("tblCEPCab", frmFolhaRescisaoManual.lblCEPcab.Text)
        folhaRescisao.SetParameterValue("tblCEP", frmFolhaRescisaoManual.LblCep.Text)
        folhaRescisao.SetParameterValue("tblCTPSCab", frmFolhaRescisaoManual.LblCTPScab.Text)
        folhaRescisao.SetParameterValue("tblCTPS", frmFolhaRescisaoManual.LblCTPS.Text)
        folhaRescisao.SetParameterValue("tblCPFCab", frmFolhaRescisaoManual.LblCPFcab.Text)
        folhaRescisao.SetParameterValue("tblCPF", frmFolhaRescisaoManual.LblCPF.Text)
        folhaRescisao.SetParameterValue("tblNascimentoCab", frmFolhaRescisaoManual.LblNascimentoCAb.Text)
        folhaRescisao.SetParameterValue("tblNascimento", frmFolhaRescisaoManual.LblNascimento.Text)
        folhaRescisao.SetParameterValue("tblMaeCab", frmFolhaRescisaoManual.lblMaeCab.Text)
        folhaRescisao.SetParameterValue("tblMae", frmFolhaRescisaoManual.lblMae.Text)


        ' identificacao do trabalhador
        folhaRescisao.SetParameterValue("ctrTipoCab", frmFolhaRescisaoManual.LblcontrTipoCab.Text)
        folhaRescisao.SetParameterValue("ctrTipo", frmFolhaRescisaoManual.LblcontrTipo.Text)
        folhaRescisao.SetParameterValue("ctrCausaAfastamentoCab", frmFolhaRescisaoManual.LblcontrAfastamentoCausaCab.Text)
        folhaRescisao.SetParameterValue("ctrCausaAfastamento", frmFolhaRescisaoManual.LblcontrAfastamentoCausa.Text)
        folhaRescisao.SetParameterValue("ctrRemuneracaoMesAnteriorCab", frmFolhaRescisaoManual.LblcontrRemuneracaMesAnteriorCab.Text)
        folhaRescisao.SetParameterValue("ctrRemuneracaoMesAnterior", frmFolhaRescisaoManual.LblcontrRemuneracaMesAnterior.Text)
        folhaRescisao.SetParameterValue("ctrAdmissaoDataCab", frmFolhaRescisaoManual.LblcontrAdmissaoDataCab.Text)
        folhaRescisao.SetParameterValue("ctrAdmissaoData", frmFolhaRescisaoManual.LblcontrAdmissaoData.Text)
        folhaRescisao.SetParameterValue("ctrAvisoDataCab", frmFolhaRescisaoManual.LblcontrAvisoDataCab.Text)
        folhaRescisao.SetParameterValue("ctrAvisoData", frmFolhaRescisaoManual.LblcontrAvisoData.Text)
        folhaRescisao.SetParameterValue("ctrAfastamentoDataCab", frmFolhaRescisaoManual.LblcontrAfastamentoDataCab.Text)
        folhaRescisao.SetParameterValue("ctrAfastamentoData", frmFolhaRescisaoManual.LblcontrAfastamentoData.Text)
        folhaRescisao.SetParameterValue("ctrAfastamentoCodigoCab", frmFolhaRescisaoManual.LblcontrAfastamentoCodigoCab.Text)
        folhaRescisao.SetParameterValue("ctrAfastamentoCodigo", frmFolhaRescisaoManual.LblcontrAfastamentoCodigo.Text)
        folhaRescisao.SetParameterValue("ctrPensaoTRCTCab", frmFolhaRescisaoManual.LblcontrPensaoTRCTCab.Text)
        folhaRescisao.SetParameterValue("ctrPensaoTRCT", frmFolhaRescisaoManual.LblcontrPensaoTRCT.Text)
        folhaRescisao.SetParameterValue("ctrPensaoFGTSCab", frmFolhaRescisaoManual.LblcontrPensaoFGTScab.Text)
        folhaRescisao.SetParameterValue("ctrPensaoFGTS", frmFolhaRescisaoManual.LblcontrPensaoFGTS.Text)
        folhaRescisao.SetParameterValue("ctrCategoriaCab", frmFolhaRescisaoManual.LblcontrCategoriacab.Text)
        folhaRescisao.SetParameterValue("ctrCategoria", frmFolhaRescisaoManual.LblcontrCategoria.Text)
        folhaRescisao.SetParameterValue("ctrSindicalCodigoCab", frmFolhaRescisaoManual.LblcontrSindicalCodCab.Text)
        folhaRescisao.SetParameterValue("ctrSindicalCodigo", frmFolhaRescisaoManual.LblcontrSindicalCod.Text)
        folhaRescisao.SetParameterValue("ctrCNPJSindicalCab", frmFolhaRescisaoManual.LblcontrCNPJsindicalCab.Text)
        folhaRescisao.SetParameterValue("ctrCNPJSindical", frmFolhaRescisaoManual.LblcontrCNPJsindical.Text)
        folhaRescisao.SetParameterValue("titVerbasRescisorias", frmFolhaRescisaoManual.LblTitulo1.Text)
        folhaRescisao.SetParameterValue("titRubrica1Cab", frmFolhaRescisaoManual.LblRubrica1.Text)
        folhaRescisao.SetParameterValue("titValor1Cab", frmFolhaRescisaoManual.LblValor1.Text)
        folhaRescisao.SetParameterValue("titRubrica2Cab", frmFolhaRescisaoManual.LblRubrica2.Text)
        folhaRescisao.SetParameterValue("titValor2Cab", frmFolhaRescisaoManual.LblValor2.Text)
        folhaRescisao.SetParameterValue("titRubrica3Cab", frmFolhaRescisaoManual.LblRubrica3.Text)
        folhaRescisao.SetParameterValue("titValor3Cab", frmFolhaRescisaoManual.LblValor3.Text)

        folhaRescisao.SetParameterValue("vrSalarioSaldoCab", frmFolhaRescisaoManual.Lbl50cab.Text)
        folhaRescisao.SetParameterValue("vrSalarioSaldo", frmFolhaRescisaoManual.Lbl50.Text)
        folhaRescisao.SetParameterValue("vrComissaoCab", frmFolhaRescisaoManual.Lbl51cab.Text)
        folhaRescisao.SetParameterValue("vrComissao", frmFolhaRescisaoManual.Lbl51.Text)
        folhaRescisao.SetParameterValue("vrGratificacaoCab", frmFolhaRescisaoManual.Lbl52Cab.Text)
        folhaRescisao.SetParameterValue("vrGratificacao", frmFolhaRescisaoManual.Lbl52.Text)

        folhaRescisao.SetParameterValue("vrAdInsalubridadeCab", frmFolhaRescisaoManual.Lbl53Cab.Text)
        folhaRescisao.SetParameterValue("vrAdInsalubridade", frmFolhaRescisaoManual.Lbl53.Text)
        folhaRescisao.SetParameterValue("vrAdPericulosidadeCab", frmFolhaRescisaoManual.Lbl54Cab.Text)
        folhaRescisao.SetParameterValue("vrAdPericulosidade", frmFolhaRescisaoManual.Lbl54.Text)
        folhaRescisao.SetParameterValue("vrAdNoturnoCab", frmFolhaRescisaoManual.Lbl55Cab.Text)
        folhaRescisao.SetParameterValue("vrAdNoturno", frmFolhaRescisaoManual.Lbl55.Text)

        folhaRescisao.SetParameterValue("vrHoraExtraCab", frmFolhaRescisaoManual.Lbl56Cab.Text)
        folhaRescisao.SetParameterValue("vrHoraExtra", frmFolhaRescisaoManual.Lbl56.Text)
        folhaRescisao.SetParameterValue("vrGorjetaCab", frmFolhaRescisaoManual.Lbl57Cab.Text)
        folhaRescisao.SetParameterValue("vrGorjeta", frmFolhaRescisaoManual.Lbl57.Text)
        folhaRescisao.SetParameterValue("vrDSRCab", frmFolhaRescisaoManual.Lbl58Cab.Text)
        folhaRescisao.SetParameterValue("vrDSR", frmFolhaRescisaoManual.Lbl58.Text)

        folhaRescisao.SetParameterValue("vrDSRReflexoCab", frmFolhaRescisaoManual.Lbl59Cab.Text)
        folhaRescisao.SetParameterValue("vrDSRReflexo", frmFolhaRescisaoManual.Lbl59.Text)
        folhaRescisao.SetParameterValue("vrMultArtigo477Cab", frmFolhaRescisaoManual.Lbl60Cab.Text)
        folhaRescisao.SetParameterValue("vrMultArtigo477", frmFolhaRescisaoManual.Lbl60.Text)
        folhaRescisao.SetParameterValue("vrSalarioFamiliaCab", frmFolhaRescisaoManual.Lbl62Cab.Text)
        folhaRescisao.SetParameterValue("vrSalarioFamilia", frmFolhaRescisaoManual.Lbl62.Text)

        folhaRescisao.SetParameterValue("vrDecimoterceiroCab", frmFolhaRescisaoManual.Lbl63Cab.Text)
        folhaRescisao.SetParameterValue("vrDecimoTerceiro", frmFolhaRescisaoManual.Lbl63.Text)
        folhaRescisao.SetParameterValue("vrDecimoTerceiroExAntCab", frmFolhaRescisaoManual.Lbl64Cab.Text)
        folhaRescisao.SetParameterValue("vrDecimoTerceiroExAnt", frmFolhaRescisaoManual.Lbl64.Text)
        folhaRescisao.SetParameterValue("vrFeriasProporcionaisCab", frmFolhaRescisaoManual.Lbl65Cab.Text)
        folhaRescisao.SetParameterValue("vrFeriasProporcionais", frmFolhaRescisaoManual.Lbl65.Text)

        folhaRescisao.SetParameterValue("vrFeriasVencidasCab", frmFolhaRescisaoManual.Lbl66Cab.Text)
        folhaRescisao.SetParameterValue("vrFeriasVencidas", frmFolhaRescisaoManual.Lbl66.Text)
        folhaRescisao.SetParameterValue("vrTercoConstitucionalCab", frmFolhaRescisaoManual.Lbl68Cab.Text)
        folhaRescisao.SetParameterValue("vrTercoConstitucional", frmFolhaRescisaoManual.Lbl68.Text)
        folhaRescisao.SetParameterValue("vrAvisoPrevioIndenizadoCab", frmFolhaRescisaoManual.Lbl69Cab.Text)
        folhaRescisao.SetParameterValue("vrAvisoPrevioIndenizado", frmFolhaRescisaoManual.Lbl69.Text)

        folhaRescisao.SetParameterValue("vrDecimoTerceiroAvisoPrevioCab", frmFolhaRescisaoManual.Lbl70Cab.Text)
        folhaRescisao.SetParameterValue("vrDecimoTerceiroAvisoPrevio", frmFolhaRescisaoManual.Lbl70.Text)
        folhaRescisao.SetParameterValue("vrFeriasAvisoPrevioIndenizadoCab", frmFolhaRescisaoManual.Lbl71Cab.Text)
        folhaRescisao.SetParameterValue("vrFeriasAvisoPrevioIndenizado", frmFolhaRescisaoManual.Lbl71.Text)
        folhaRescisao.SetParameterValue("vrrevisaoNegativaCab", frmFolhaRescisaoManual.Lbl95Cab.Text)
        folhaRescisao.SetParameterValue("vrrevisaoNegativa", frmFolhaRescisaoManual.Lbl95.Text)


        folhaRescisao.SetParameterValue("vrAjusteSaldoDevedorCab", frmFolhaRescisaoManual.Lbl99Cab.Text)
        folhaRescisao.SetParameterValue("vrAjusteSaldoDevedor", frmFolhaRescisaoManual.Lbl99.Text)
        folhaRescisao.SetParameterValue("vrTotalBrutoCab", frmFolhaRescisaoManual.Lbl100Cab.Text)
        folhaRescisao.SetParameterValue("vrTotalBruto", frmFolhaRescisaoManual.Lbl100.Text & "  ")

        folhaRescisao.SetParameterValue("dedTituloCab", frmFolhaRescisaoManual.LblDedTituloDeducoesCab.Text)
        folhaRescisao.SetParameterValue("dedDescontos1Cab", frmFolhaRescisaoManual.LbldedDesconto1Cab.Text)
        folhaRescisao.SetParameterValue("dedValor1Cab", frmFolhaRescisaoManual.LbldedValor1Cab.Text)
        folhaRescisao.SetParameterValue("dedDescontos2Cab", frmFolhaRescisaoManual.LbldedDesconto2Cab.Text)
        folhaRescisao.SetParameterValue("dedValor2Cab", frmFolhaRescisaoManual.LbldedValor2Cab.Text)
        folhaRescisao.SetParameterValue("dedDescontos3Cab", frmFolhaRescisaoManual.LbldedDesconto3Cab.Text)
        folhaRescisao.SetParameterValue("dedValor3Cab", frmFolhaRescisaoManual.LbldedValor3Cab.Text)

        folhaRescisao.SetParameterValue("dedPensaoAlimenticiaCab", frmFolhaRescisaoManual.LblDed100Cab.Text)
        folhaRescisao.SetParameterValue("dedPensaoAlimenticia", frmFolhaRescisaoManual.LblDed100.Text)
        folhaRescisao.SetParameterValue("dedAdiantamentoSalarialCab", frmFolhaRescisaoManual.LblDed101Cab.Text)
        folhaRescisao.SetParameterValue("dedAdiantamentoSalarial", frmFolhaRescisaoManual.LblDed101.Text)
        folhaRescisao.SetParameterValue("dedAdiantamento13SalarioCab", frmFolhaRescisaoManual.LblDed102Cab.Text)
        folhaRescisao.SetParameterValue("dedAdiantamento13Salario", frmFolhaRescisaoManual.LblDed102.Text)


        folhaRescisao.SetParameterValue("dedAvisoNaoCumpridoCab", frmFolhaRescisaoManual.LblDed103Cab.Text)
        folhaRescisao.SetParameterValue("dedAvisoNaoCumprido", frmFolhaRescisaoManual.LblDed103.Text)
        folhaRescisao.SetParameterValue("dedPrevidenciaSocialCab", frmFolhaRescisaoManual.LblDed112_1Cab.Text)
        folhaRescisao.SetParameterValue("dedPrevidenciaSocial", frmFolhaRescisaoManual.LblDed112_1.Text)
        folhaRescisao.SetParameterValue("dedPrevidenciaSocial13Cab", frmFolhaRescisaoManual.LblDed112_2Cab.Text)
        folhaRescisao.SetParameterValue("dedPrevidenciaSocial13", frmFolhaRescisaoManual.LblDed112_2.Text)

        folhaRescisao.SetParameterValue("dedINSSFeriasCab", frmFolhaRescisaoManual.LblDed112_3Cab.Text)
        folhaRescisao.SetParameterValue("dedINSSFerias", frmFolhaRescisaoManual.LblDed112_3.Text)
        folhaRescisao.SetParameterValue("dedIRRFCab", frmFolhaRescisaoManual.LblDed114_1Cab.Text)
        folhaRescisao.SetParameterValue("dedIRRF", frmFolhaRescisaoManual.LblDed114_1.Text)
        folhaRescisao.SetParameterValue("dedIRRF13Cab", frmFolhaRescisaoManual.LblDed114_2Cab.Text)
        folhaRescisao.SetParameterValue("dedIRRF13", frmFolhaRescisaoManual.LblDed114_2.Text)


        folhaRescisao.SetParameterValue("dedAdiantamentoFeriasCab", frmFolhaRescisaoManual.LblDed115_1Cab.Text)
        folhaRescisao.SetParameterValue("dedAdiantamentoFerias", frmFolhaRescisaoManual.LblDed115_1.Text)
        folhaRescisao.SetParameterValue("dedFeriasAntecipadasCab", frmFolhaRescisaoManual.LblDed115_2Cab.Text)
        folhaRescisao.SetParameterValue("dedFeriasAntecipadas", frmFolhaRescisaoManual.LblDed115_2.Text)

        folhaRescisao.SetParameterValue("dedTotalDeducoesCab", frmFolhaRescisaoManual.LblDedTotalDeducoesCab.Text)
        folhaRescisao.SetParameterValue("dedTotalDeducoes", frmFolhaRescisaoManual.LblDedTotalDeducoes.Text & "  ")
        folhaRescisao.SetParameterValue("rsValorLiquidoCab", frmFolhaRescisaoManual.LblDedTotalLiquidoCab.Text)
        folhaRescisao.SetParameterValue("rsValorLiquido", frmFolhaRescisaoManual.LblDedTotalLiquido.Text & "  ")

    End Sub
End Class