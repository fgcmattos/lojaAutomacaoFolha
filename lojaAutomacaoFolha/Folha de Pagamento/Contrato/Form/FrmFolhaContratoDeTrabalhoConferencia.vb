Imports MySql.Data.MySqlClient

Public Class FrmFolhaContratoDeTrabalhoConferencia

    Public oi As New MsgShow
    Private Sub FrmFolhaContratoDeTrabalhoConferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Conferência das informações da digitação de um contrato de trabalho
        ' vem da condição
        ' STATUS FCC_status = 0 NA TABELA folha_col_contrato
        '
        '   0 Digitado
        '   1 Conferido
        '   2 Aprovado
        '   3 Ativo
        '   4 Cancelado
        '   5 Terminado


        oi.Title = Me.Text

        Dim Query As String
        Query = "Select "
        Query += "lpad(ID_FCC,4,'0')"
        Query += ",lpad(FCC_KeyCol,4,'0')"
        Query += ",FCC_cpf"
        Query += ",FCC_nome"
        Query += " From folha_col_contrato  "
        Query += " Where "
        Query += " FCC_status = 0 "
        Query += " Order By FCC_nome "

        Dim StrLinha As String = ""

        StrLinha = "Id      Chave     CPF                Nome "
        ListBox1.Items.Clear()
        ListBox1.Items.Add(StrLinha)
        If OpenDB() Then
            Dim DTReader As MySqlDataReader
            Dim CMD As New MySqlCommand(Query, Conn)
            DTReader = CMD.ExecuteReader

            While DTReader.Read()
                StrLinha = DTReader.GetValue(0)
                StrLinha += "    "
                StrLinha += DTReader.GetValue(1)
                StrLinha += "    "
                StrLinha += DTReader.GetValue(2)
                StrLinha += "    "
                StrLinha += DTReader.GetValue(3)

                ListBox1.Items.Add(StrLinha)

            End While



        End If

        Conn.Close()

    End Sub

    Private Sub ButIniciar_Click(sender As Object, e As EventArgs) Handles ButIniciar.Click

        If ListBox1.SelectedItem = Nothing Or ListBox1.SelectedIndex = 0 Then

            With Oi
                .Msg = "Por favor!, selecione um colaborador"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If


        Dim isId As String = ListBox1.SelectedItem

        isId = isId.Substring(0, 4)

        Dim colContrato As List(Of ClassContratoFolha) = ColaboradorAcoes.GetColContratoSQL_All(isId)

        With FrmFolhaContratoDeTrabalhoCadastramentoConferencia

            .Show()

            ComboCarregar(.CmbTipo, "folha_col_contrato_tipo", "concat(FCT_codigo,' - ' , FCT_descricao)", "")

            ComboCarregar(.CmbCategoria, "folha_col_contrato_categoria", "concat(Fcc_Codigo,' - ' , Fcc_descricao)", "")

            ComboCarregar(.CmbSetor, "folha_setor", "concat(folha_setor_codigo,' - ',folha_setor_descricao)", "")

            ComboCarregar(.CmbCargo, "folha_cargo", "concat(folha_cargo_codigo,' - ',folha_cargo_descricao)", "")

            ComboCarregar(.CmbCBO, "folha_cbo", "concat(folha_cbo_codigo,' - ',folha_cbo_descricao)", "")

        End With

        PreencheContratoInformacoesColaborador(colContrato)

        Me.Close()

    End Sub

    Private Function PreencheContratoInformacoesColaborador(Cc As Object)

        With FrmFolhaContratoDeTrabalhoCadastramentoConferencia

            .LblChave.Text = Cc(0).FCC_keyCol
            .LblNome.Text = Cc(0).FCC_nome
            .LblCPF.Text = Cc(0).FCC_cpf
            .LblRG.Text = Cc(0).FCC_rg
            .LblPIS.Text = Cc(0).FCC_pis
            .LblCTPSnumero.Text = Cc(0).FCC_ctps_numero
            .LblCTPSserie.Text = Cc(0).FCC_ctps_serie
            .LblAdmissao.Text = Cc(0).FCC_admissao_data
            .LblASOadmissao.Text = Cc(0).FCC_aso_admissao


            .CmbTipo.Text = Cc(0).FCC_tipo & " - " & Cc(0).FCC_tipoDescricao
            .CmbCategoria.Text = Cc(0).FCC_categoriaCodigo & " - " & Cc(0).FCC_categoriaDescricao
            .CmbSetor.Text = Cc(0).FCC_setor
            .CmbCargo.Text = Cc(0).FCC_cargo
            .CmbCBO.Text = Cc(0).FCC_cbo
            .MskReferencia.Text = Cc(0).FCC_referencia
            Dim IsSalario As String = numeroLatino(Cc(0).FCC_salario, 10, True)
            .CmbSalario.Items.Add(IsSalario)
            .CmbSalario.Text = IsSalario
            .CmbRegistroFisico.Text = Cc(0).FCC_registro_fisico
            .TxtLivro.Text = Cc(0).FCC_registro_livro
            .TxtPagina.Text = Cc(0).FCC_registro_pagina
            .TxtRegistroNumero.Text = Cc(0).FCC_registro_ordem
            .TxtSindicatoCodigo.Text = Cc(0).FCC_sindical_codigo
            .MskCNPJsindicato.Text = Cc(0).FCC_CNPJentidadeSindical
            .TxtSindicatoRazaoSocial.Text = Cc(0).FCC_RazaoEntidadeSindical
            .MskCargaHorariaSemanal.Text = Cc(0).FCC_carga_horaria_semanal.ToString
            .MskNumeroDescansosNaSemana.Text = Cc(0).FCC_descanso_semanal
            .MskInicioDaJornada.Text = Cc(0).FCC_jornada_dia_inicio.ToString
            .MskDescansoNaJornada.Text = Cc(0).FCC_jornada_descanso.ToString
            .LblCargaHorariaDiaria.Text = Cc(0).FCC_jornada_dia.ToString
            .LblCargaHorariaMensal.Text = Cc(0).FCC_jornada_mes.ToString
            .LblFimDaJornada.Text = Cc(0).FCC_jornada_dia_fim.ToString

            Dim caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(Cc(0).FCC_cpf) & "\Contrato\FichaDeInteresse"

            If System.IO.Directory.Exists(caminho) Then

                'colIlustra(caminho)

            End If


        End With



    End Function

    Private Sub Butnancela_Click(sender As Object, e As EventArgs) Handles Butnancela.Click
        Me.Close()
    End Sub

End Class