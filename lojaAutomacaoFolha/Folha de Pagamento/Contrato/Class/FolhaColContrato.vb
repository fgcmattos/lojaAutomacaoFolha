Public Class FolhaColContrato
    Public Property Colaborador As String
    Public Property ColaboradorCPF As String
    Public Property ColaboradorCargo As String
    Public Property ContratoTipo As String                  ' tipo do contrato de trabalho - table folha_col_contrato campo campo FCC_Tipo 
    Public Property ContratoTipoDescricao As String         ' Descricao do tipo - Table folha_col_contrato campo FCC_tipoDescricao
    Public Property AvisoPrevioData As String               ' Data do recebimento da noticia de afastamento - Colhida em frmFolhaRescisaoDestratoGravacao campo
    Public Property Afastamento As String                   ' Data do afastamento - Colhida em frmFolhaRescisaoDestratoGravacao campo
    Public Property AfastamentoCodigo As String             ' codigo do afastamento  - table folha_contratoafastamento campo Fca_codigo
    Public Property AfastamentoCausa As String              ' Identifica pelo codigo - table folha_contratoafastamento campo Fca_descricao
    Public Property AfastamentoData As String               ' Calculado a partir do afastamento
    Public Property RemuneracaoAtual As String              ' Table colaborador campo colaboradorSalarioAtual
    Public Property RemuneracaoMesAnterior As Decimal       ' Valor colhido na Table folha_rendimentos
    Public Property AdmissaoData As String                  ' data Colhida na Table colaborador campo colaboradorAdmissao
    Public Property PensaoAlimenticiaTRCT As Decimal
    Public Property PensaoAlimenticiaFGTS As String
    Public Property Categoria As String                     ' Codigo de categoria do colaborador table colaborador campo
    Public Property Categoriadescricao As String            ' descricao da categoria table folhA_contratocategoria campo Fcc_descricao
    Public Property SindicalCodigo As String                ' Table empresa campo empSindicalCodigo
    Public Property CNPJEntidadeSindical As String          ' table empresa campo empSindicalCNPJ
    Public Property EntidadeSindicalRazao As String         ' table empresa campo empSindicalRazaoSocial

    Public Property TipoCab As String = "21 Tipo de Contrato"
    Public Property AfastamentoCab As String = "22 Causa do Afastamento"
    Public Property RemuneracaoMesAnteriorCab As String = "23 Remuneração Mês Ant."
    Public Property AdmissaoDataCab As String = "24 Data de Admissão"
    Public Property AvisoPrevioDataCab As String = "25 Data do Aviso Prévio"
    Public Property AfastamentoDataCab As String = "26 Data do Afastamento"
    Public Property AfastamentoCodigoCab As String = "27 Cód. Afastamento"
    Public Property PensaoAlimenticiaTRCTCab As String = "28 Pensão Alim (%) TRCT"
    Public Property PensaoAlimenticiaFGTSCab As String = "29 Pensão Alim(%) FGTS"
    Public Property CategoriaCab As String = "30 Categoria do Trabalhador"
    Public Property SindicalCodigoCab As String = "31 Código Sindical"
    Public Property CNPJEntidadeSindicalCab As String = "32 CNPJ e Nome da Entidade Sindical Laboral"

    Public Property Vr_l0_titulo0CAb As String = "DESCRIÇÃO DAS VERBAS RESCISÓRIAS"

    Public Property Vr_l1_Titulo1CAb As String = "Verbas Rescisórias"

    Public Property Vr_l2_Titulo1CAb As String = "Rubrica"
    Public Property Vr_l2_Titulo2CAb As String = "Valor"
    Public Property Vr_l2_Titulo3CAb As String = "Rubrica"
    Public Property Vr_l2_Titulo4CAb As String = "Valor"
    Public Property Vr_l2_Titulo5CAb As String = "Rubrica"
    Public Property Vr_l2_Titulo6CAb As String = "Valor"

    Public Property Vr_l3_1CAb As String = "50 Saldo de Salário (# dias)"
    Public Property Vr_l3_1 As String
    Public Property Vr_l3_2CAb As String = "51 Comissão"
    Public Property Vr_l3_2 As String
    Public Property Vr_l3_3CAb As String = "52 Gratificação"
    Public Property Vr_l3_3 As String

    Public Property Vr_l4_1CAb As String = "53 Adicional Insalubridade"
    Public Property Vr_l4_1 As String
    Public Property Vr_l4_2CAb As String = "54 Adicional de peiculosidade"
    Public Property Vr_l4_2 As String
    Public Property Vr_l4_3CAb As String = "55 Adicional Noturno"
    Public Property Vr_l4_3 As String

    Public Property Vr_l5_1CAb As String = "56.1 Horas Extras"
    Public Property Vr_l5_1 As String
    Public Property Vr_l5_2CAb As String = "57 Gorjetas"
    Public Property Vr_l5_2 As String
    Public Property Vr_l5_3CAb As String = "58 Descanso Semanal" & Chr(13) & "Remunerado(DSR)"
    Public Property Vr_l5_3 As String

    Public Property Vr_l6_1CAb As String = "59 Reflexo do DSR sobre" & Chr(13) & "Salário Variável"
    Public Property Vr_l6_1 As String
    Public Property Vr_l6_2CAb As String = "60 Multa Art. 477, § 8º/CLT"
    Public Property Vr_l6_2 As String
    Public Property Vr_l6_3CAb As String = "62 Salário-Familia"
    Public Property Vr_l6_3 As String

    Public Property Vr_l7_1CAb As String = "63 Décimo-Terceiro Salário" & Chr(13) & "Proporcional(3 avos)"
    Public Property Vr_l7_1 As String
    Public Property Vr_l7_2CAb As String = "64 Décimo-Terceiro Salário" & Chr(13) & "Exercícios Anteriores "
    Public Property Vr_l7_2 As String
    Public Property Vr_l7_3CAb As String = "65 Férias Proporcionais"
    Public Property Vr_l7_3 As String

    Public Property Vr_l8_1CAb As String = "66.1 Férias Vencidas" & Chr(13) & "(Per.Aquis)"
    Public Property Vr_l8_1 As String
    Public Property Vr_l8_2CAb As String = "68 Terço Constitucional de" & Chr(13) & "Férias"
    Public Property Vr_l8_2 As String
    Public Property Vr_l8_3CAb As String = "69 Aviso-Prévio Indenizado"
    Public Property Vr_l8_3 As String

    Public Property Vr_l9_1CAb As String = "70 Décimo-Terceiro Salário" & Chr(13) & "(Aviso-Prévio Indenizado)"
    Public Property Vr_l9_1 As String
    Public Property Vr_l9_2CAb As String = "71 Férias" & Chr(13) & "(Aviso-Prévio Indenizado)"
    Public Property Vr_l9_2 As String
    Public Property Vr_l9_3CAb As String = "95 Rescisão Negativa"
    Public Property Vr_l9_3 As String

    Public Property Vr_l10_1CAb As String = "99 Ajuste de Saldo Devedor"
    Public Property Vr_l10_1 As String
    Public Property Vr_l10_2CAb As String = "  TOTAL BRUTO"
    Public Property Vr_l10_2 As String
    Public Property Vr_l10_3CAb As String = "65 Férias Proporcionais"
    Public Property Vr_l10_3 As String

    Public Property Vr_l11_1CAb As String = "Deduções"
    Public Property Vr_l11_2CAb As String = "Descontos"
    Public Property Vr_l11_3CAb As String = "Valor"
    Public Property Vr_l11_4CAb As String = "Descontos"
    Public Property Vr_l11_5CAb As String = "Valor"
    Public Property Vr_l11_6CAb As String = "Descontos"
    Public Property Vr_l11_7CAb As String = "Valor"

    Public Property Vr_l12_1CAb As String = "100 Pensão Alimenticia"
    Public Property Vr_l12_1 As String
    Public Property Vr_l12_2CAb As String = "101 Adiantamento Salarial"
    Public Property Vr_l12_2 As String
    Public Property Vr_l12_3CAb As String = "102 Adiantamento 13º Salário"
    Public Property Vr_l12_3 As String

    Public Property Vr_l13_1CAb As String = "103 Aviso Prévio Não Cumprido (30)"
    Public Property Vr_l13_1 As String
    Public Property Vr_l13_2CAb As String = "112.1 Previdência Social" & Chr(13) & "(7.50%)"
    Public Property Vr_l13_2 As String
    Public Property Vr_l13_3CAb As String = "112.2 Previdência Social 13º" & Chr(13) & "Salário (7.50%)"
    Public Property Vr_l13_3 As String


    Public Property Vr_l14_1CAb As String = "112.3 INSS Férias (7.50)"
    Public Property Vr_l14_1 As String
    Public Property Vr_l14_2CAb As String = "114.1 IRRF"
    Public Property Vr_l14_2 As String
    Public Property Vr_l14_3CAb As String = "114.2 IRRF sobre 13º Salário"
    Public Property Vr_l14_3 As String

    Public Property Vr_l15_1CAb As String = "115.1 Adiantamento Férias"
    Public Property Vr_l15_1 As String
    Public Property Vr_l15_2CAb As String = "115.2 Férias Antecipadas"
    Public Property Vr_l15_2 As String


    Public Property Vr_l16_1CAb As String = "TOTAL DEDUÇÕES"
    Public Property Vr_l16_1 As String
    Public Property Vr_l16_2CAb As String = "VALOR LÍQUIDO"
    Public Property Vr_l16_2 As String

    Public Property Registro As String
    Public Property Cargo As String
    Public Property Setor As String
    Public Property Banco As String
    Public Property Conta As String
    Public Property PIX As String



    'Public Property AfastamentoCodigo As String
    'Public Property AfastamentoCausa As String
    'Public Property AfastamentoData As String
    'Public Property RemuneracaoMesAnterior As Decimal
    'Public Property AdmissaoData As String
    'Public Property AvisoPrevioData As String
    'Public Property PensaoAlimenticiaTRCT As Decimal
    'Public Property PensaoAlimenticiaFGTS As String
    'Public Property Categoria As String
    'Public Property SindicalCodigo As String
    'Public Property CNPJEntidadeSindical As String

End Class
