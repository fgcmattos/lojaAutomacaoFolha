Public Class CartaoClass
    Public Property CodInterno As String    ' Codigo de controle interno
    Public Property Bandeira As String      ' Adninistradora do cartao
    Public Property Numero As String        ' Numero do Cartao
    Public Property Responsavel As String   ' Responsavel
    Public Property NomeImpresso As String  ' Numero do Cartao
    Public Property Validade As String      ' Validade MM/AA
    Public Property Fatura As String        ' Data de vencimento da fatura
    Public Property CodigoSeg As String     ' Codigo de seguranca do Cartao
    Public Property Banco As String         ' Instituição financeira do cartão

    Public Property Agencia As String       ' Agência vinculada ao cartão
    Public Property Agencia_dg As String    ' Digito do codigo da agência
    Public Property Conta As String         ' Conta vinculada ao Cartão
    Public Property Conta_dg As String      ' Digito do codigo da conta

    Public Property Ativacao As DateTime      ' Digito do codigo da conta
    Public Property Desativacao As DateTime  ' Digito do codigo da conta

End Class
