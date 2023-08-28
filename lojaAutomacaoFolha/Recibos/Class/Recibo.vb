Public Class Recibo

    Public Property Id As Integer
    Public Property Chave As Integer                        'I1
    Public Property Referencia As String
    Public Property NumeroLocal As String
    Public Property NumeroSequencial As Integer
    Public Property Status As Integer
    Public Property ValorBR As String                       'V1
    Public Property ValorExtenso As String                  'V2
    Public Property ValorNumerico As String
    Public Property TextoPactuado As String
    Public Property DataEmissao As String                   'D1
    Public Property DataAssinatura As String
    Public Property Favorecido As String                    'F1
    Public Property FavorecidoRg As String                  'F2
    Public Property FavorecidoRgEmissao As String           'F9
    Public Property FavorecidoInsEstadual As String         'F3
    Public Property FavorecidoInsMuncipal As String         'F4
    Public Property FavorecidoCidade As String              'F5
    Public Property FavorecidoUf As String                  'F6
    Public Property FavorecidoCpf_Cnpj As String            'F7
    Public Property FavorecidoRGorgaoExpedidor As String    'F8
    Public Property FavorecidoEndereco As String            'F10
    Public Property FavorecidoRGuf As String                'F11 nao esta implementado
    Public Property LocalData As String
    Public Property Cabecario As String
    Public Property Tipo As String
    Public Property DataPrestacaoServico                     'D2
    Public Property EmissorNome As String                    'E1
    Public Property EmissorIdTipo As String                  'E2
    Public Property EmissorIdNumero As String                'E3
    Public Property EmissorEndereco As String                'E4
    Public Property EmissorEnderecoNumero As String          'E5
    Public Property EmissorEnderecoComplemento As String     'E6
    Public Property EmissorCidade As String                  'E7
    Public Property EmissorUF As String                      'E8
    Public Property EmissorLocal As String                   'E9
    Public Property Gravar As String
    Public Property PortadorNome                             'P1
    Public Property PortadorRG                               'P2
    Public Property PortadorCPF                              'P3
    Public Property NumeroAnoMesSeq

End Class
