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
        Query += "lpad(FCC_KeyCol,4,'0')"
        Query += ",FCC_cpf"
        Query += ",FCC_nome"
        Query += " From folha_col_contrato  "
        Query += " Where "
        Query += " FCC_status = 0 "
        Query += " Order By FCC_nome "

        Dim StrLinha As String = ""

        StrLinha = "Chave     CPF                Nome"
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


        Dim strChave As String = ListBox1.SelectedItem

        strChave = strChave.Substring(0, 4)

        Dim colContrato As List(Of colaborador) = ColaboradorAcoes.GetColContratoSQL(strChave)

        FrmFolhaContratoDeTrabalhoCadastramentoConferencia.Show()

        PreencheContratoInformacoesColaborador(colContrato)

        Me.Close()

    End Sub

    Private Function PreencheContratoInformacoesColaborador(Cc As Object)

        With FrmFolhaContratoDeTrabalhoCadastramentoConferencia

            .LblChave.Text = Cc(0).Chave
            .LblNome.Text = Cc(0).Nome
            .LblCPF.Text = Cc(0).CPF
            .LblRG.Text = Cc(0).rg
            .LblPIS.Text = Cc(0).PIS
            .LblCTPSnumero.Text = Cc(0).CTPS
            .LblCTPSserie.Text = Cc(0).CTPSserie
            .LblAdmissao.Text = Cc(0).Admissao
            .LblASOadmissao.Text = Cc(0).ASOadmissao

            Dim caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(Cc(0).CPF) & "\Contrato\FichaDeInteresse"

            If System.IO.Directory.Exists(caminho) Then

                'colIlustra(caminho)


            End If





        End With



    End Function

    Private Sub Butnancela_Click(sender As Object, e As EventArgs) Handles Butnancela.Click
        Me.Close()
    End Sub

End Class