Public Class captura
    Public Shared Function GetRecibo() As List(Of recibo)

        Dim lista As New List(Of recibo)

        lista.Add(New recibo() With
             {
                            .FavorecidoCpf_Cnpj = Replace(FreciboNew.LblColCPF.Text, ",", "."),
                            .FavorecidoRg = FreciboNew.LblColRG.Text,
                            .Favorecido = FreciboNew.LblColNome.Text,
                            .ValorNumerico = FreciboNew.txtValor.Text,
                            .DataAssinatura = FreciboNew.txtReciboLocal.Text,
                            .DataEmissao = FreciboNew.mskReciboData.Text,
                            .TextoPactuado = FreciboNew.rbHist.Text,
                            .LocalData = FreciboNew.lblLocalData.Text,
                            .ValorBR = FreciboNew.txtValor.Text
              }
                  )

        Return lista
    End Function

End Class
