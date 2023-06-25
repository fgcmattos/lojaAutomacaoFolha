Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FmrReciboRel

    Private Sub FmrReciboRel_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim RecRestart As List(Of Recibo) = ReciboRP.ReciboCargaEmissor()

        Dim STRrecibo As String = ""

        Dim formulario As String = ""

        If Me.Text = "R E C I B O - I M P R E S S Ã O" Then

            formulario = "FreciboNew"

            STRrecibo = FreciboNew.lblAnoMesSequencial.Text

        ElseIf Me.Text = "R E S T A R T  D A  I M P R E S S Ã O  D E  R E C I B O" Then

            formulario = "fmrReciboPesquisa"

            STRrecibo = fmrReciboPesquisa.LblRecibo.Text

        End If

        Dim RecRestart1 As List(Of Recibo) = ReciboRP.GetReciboREstart(STRrecibo)

        ' Necessario descobrir de que formulario vem a requisicao
        If formulario = "FreciboNew" Then
            '''Dim apRecibo As List(Of recibo) = ReciboAcoes.

            Rrecibo.SetParameterValue("NomeBeneficiado", FreciboNew.LblColNome.Text)
            Rrecibo.SetParameterValue("Rg", FreciboNew.LblColRG.Text)
            Rrecibo.SetParameterValue("Cpf", FreciboNew.LblColCPF.Text)
            Rrecibo.SetParameterValue("ValorRecibo", "valor R$ (" & FreciboNew.rc(0).ValorBR & ")")
            Rrecibo.SetParameterValue("DataEmissao", FreciboNew.mskReciboData.Text)
            Rrecibo.SetParameterValue("textoPactuado", FreciboNew.rbHist.Text)
            Rrecibo.SetParameterValue("Cabecario", FreciboNew.rc(0).Cabecario)
            '''Rrecibo.SetParameterValue("ReciboNumero", apRecibo(0).NumeroLocal & apRecibo(0).NumeroAnoMesSeq)
            FreciboNew.rc(0).Referencia = FreciboNew.TxtReferencia.Text
            Rrecibo.SetParameterValue("Referencia", "REF: " + FreciboNew.rc(0).Referencia)

        ElseIf formulario = "fmrReciboPesquisa" Then

            Rrecibo.SetParameterValue("NomeBeneficiado", RecRestart(0).Favorecido)
            Rrecibo.SetParameterValue("Rg", RecRestart(0).FavorecidoRg)
            Rrecibo.SetParameterValue("Cpf", RecRestart(0).FavorecidoCpf_Cnpj)
            Rrecibo.SetParameterValue("ValorRecibo", "valor R$ (" & RecRestart1(0).ValorBR & ")")
            Rrecibo.SetParameterValue("DataEmissao", dataLatina(RecRestart(0).DataEmissao))
            Rrecibo.SetParameterValue("textoPactuado", RecRestart(0).TextoPactuado)
            Rrecibo.SetParameterValue("Cabecario", RecRestart(0).Cabecario)
            Rrecibo.SetParameterValue("ReciboNumero", RecRestart(0).NumeroAnoMesSeq)

        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Rrecibo_InitReport(sender As Object, e As EventArgs) Handles Rrecibo.InitReport

    End Sub
End Class