Imports MySql.Data.MySqlClient
Public Class FrmFolhaContratoDeTrabalhoAutorizados
    Public oi As New MsgShow
    Private Sub FrmFolhaContratoDeTrabalhoAutorizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' O preenchimento da tela de colaboradores disponineis para gerar contrato
        ' vem de duas condições
        ' 1 - O cadastro de colaborador deve estar completo
        ' 2 - O colaborador não poe ter contrato de trabalho ativo

        oi.Title = Me.Text

        Dim Query As String
        Query = "Select "
        Query += "lpad(chave,4,'0')"
        Query += ",colaboradorcpf"
        Query += ",colaboradorNome"
        Query += " From colaborador "
        Query += " Where "
        Query += "colaboradorStatus = 0 "
        Query += " Order By colaboradornome "

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

        If ListBox1.SelectedItem = Nothing Then

            With oi
                .msg = "Por favor!, selecione um colaborador"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                Exit Sub
            End With

        End If

        If ListBox1.SelectedIndex = 0 Then
            With oi
                .msg = "Por favor!, selecione um colaborador"
                .style = vbCritical
                MsgBox(.msg, .style, .title)
                Exit Sub
            End With

        End If

        Dim strChave As String = ListBox1.SelectedItem

        strChave = strChave.Substring(0, 4)

        Dim colContrato As List(Of colaborador) = ColaboradorAcoes.GetColContratoSQL(strChave)

        FrmFolhaContratoDeTrabalhoCadastramento.Show()

        PreencheContratoInformacoesColaborador(colContrato)

        Me.Close()

    End Sub

    Private Function PreencheContratoInformacoesColaborador(Cc As Object)

        With FrmFolhaContratoDeTrabalhoCadastramento

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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class