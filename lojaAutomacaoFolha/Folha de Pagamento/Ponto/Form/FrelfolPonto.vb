Public Class FrelfolPonto
    Private Sub FrelfolPonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load


        Dim lista As List(Of folCaptDiario) = folhaPontoCaptura.GetPonto()

        'Dim emp As New empresaEmpregadora


        Dim periodo As String = "Período: " & frmFolhaDiarioRelatorio.mskDataInicio.Text & " à " & frmFolhaDiarioRelatorio.mskDataFim.Text

        Dim cargo As String = frmFolhaDiarioRelatorio.lblCargo.Text
        Dim chave As String = frmFolhaDiarioRelatorio.lblChave.Text
        Dim cpf As String = "CPF: " & formaString(1, frmFolhaDiarioRelatorio.LblCPF.Text)
        Dim colaborador As String = chave & " - " & Trim(frmFolhaDiarioRelatorio.LblNome.Text)
        Dim rg As String = "RG: " & frmFolhaDiarioRelatorio.LblRG.Text
        Dim DatasaldoAnterior As String = "Saldo em " & dataSoma(frmFolhaDiarioRelatorio.mskDataInicio.Text, -1)
        Dim saldoAnterior As String = bhSaldoHoras(chave, frmFolhaDiarioRelatorio.mskDataInicio.Text)
        Dim descanso As String = "Descanso do Turno: " & frmFolhaDiarioRelatorio.LblDescanso.Text
        Dim turno As String = "Turno: " & frmFolhaDiarioRelatorio.LblTurno.Text
        Dim turnoInicio As String = "Inicio: " & frmFolhaDiarioRelatorio.lblturnoInico.Text
        Dim turnoFim As String = "Término: " & frmFolhaDiarioRelatorio.lblTurnoFim.Text
        Dim turnoDuracao As String = "Duração do Turno: " & frmFolhaDiarioRelatorio.lblTurnoDuracao.Text
        Dim impressao As String = "Impressão: " & Now()
        Dim endereco, empresa As String
        Dim cor As List(Of captObs) = captObsRP.GetcaptObs()
        Dim emp As List(Of empresaEmpregadora) = empresaEmpregadoraRP.GetEmpresa()
        empresa = "CNPJ:" & formaString(3, emp(0).CNPJ) & " - " & emp(0).nome
        endereco = emp(0).Endereco & "," & emp(0).EnderecoNumero & " - " & emp(0).Cidade & " - " & emp(0).UF & " CEP: " & emp(0).CEP
        Dim nCorrecoes As Integer = cor.Count()
        Dim correcao1, correcao2, correcao3 As String
        correcao1 = ""
        correcao2 = ""
        correcao3 = ""

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.ReportEmbeddedResource = "lojaAutomacaoFolha.rptFolhaCapt.rdlc"

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource("folhaCapturaDS", lista)

        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("impressao", impressao))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("colaborador", colaborador))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("cpf", cpf))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("RG", rg))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("saldoAnterior", DatasaldoAnterior & "  ---> " & saldoAnterior))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("turno", turno))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("turnoInicio", turnoInicio))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("turnoFim", turnoFim))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("turnoDuracao", turnoDuracao))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Descanso", descanso))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("empresa", empresa))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("endereco", endereco))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("cargo", cargo))
        If nCorrecoes = 1 Then
            correcao1 = dataLatina(cor.Item(0).DataDaCorrecao) & " | " & cor.Item(0).HorarioAcorrigir & " | " & cor.Item(0).HorarioCorrigido & " | " & dataLatina(cor.Item(0).DataDaCorrecaoDoHorario) & " | " & cor.Item(0).NSR & " | " & Trim(cor.Item(0).OBS) & " |"
        End If
        If nCorrecoes = 2 Then
            correcao1 = dataLatina(cor.Item(0).DataDaCorrecao) & " | " & cor.Item(0).HorarioAcorrigir & " | " & cor.Item(0).HorarioCorrigido & " | " & dataLatina(cor.Item(0).DataDaCorrecaoDoHorario) & " | " & cor.Item(0).NSR & " | " & cor.Item(0).OBS & " |"
            correcao2 = dataLatina(cor.Item(1).DataDaCorrecao) & " | " & cor.Item(1).HorarioAcorrigir & " | " & cor.Item(1).HorarioCorrigido & " | " & dataLatina(cor.Item(1).DataDaCorrecaoDoHorario) & " | " & cor.Item(1).NSR & " | " & cor.Item(1).OBS & " |"
        End If
        If nCorrecoes = 3 Then
            correcao1 = dataLatina(cor.Item(0).DataDaCorrecao) & " | " & cor.Item(0).HorarioAcorrigir & " | " & cor.Item(0).HorarioCorrigido & " | " & dataLatina(cor.Item(0).DataDaCorrecaoDoHorario) & " | " & cor.Item(0).NSR & " | " & cor.Item(0).OBS & " |"
            correcao2 = dataLatina(cor.Item(1).DataDaCorrecao) & " | " & cor.Item(1).HorarioAcorrigir & " | " & cor.Item(1).HorarioCorrigido & " | " & dataLatina(cor.Item(1).DataDaCorrecaoDoHorario) & " | " & cor.Item(1).NSR & " | " & cor.Item(1).OBS & " |"
            correcao3 = cor.Item(2).DataDaCorrecao & " " & cor.Item(2).HorarioAcorrigir & " " & cor.Item(2).HorarioCorrigido & " " & cor.Item(2).DataDaCorrecaoDoHorario & " " & cor.Item(2).NSR & " " & cor.Item(2).OBS

        End If

        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("correcao1", correcao1))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("correcao2", correcao2))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("correcao3", correcao3))

        ds.Value = lista


        Me.ReportViewer1.RefreshReport()

    End Sub
End Class