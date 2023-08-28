Public Class empregador

    Public Property Cnpj As String            ' CNPJ ou CEI
    Public Property RazaoSocial As String     ' Nome oficial da empresa
    Public Property Endereco As String        ' Endereco da empresa
    Public Property EnderecoNumero As String
    Public Property EnderecoCompleto As String
    Public Property Bairro As String         ' Bairro 
    Public Property Municipio As String       ' Cidade
    Public Property Uf As String              ' Estado
    Public Property CEP As String             ' CEP
    Public Property EnderecoComplemento As String
    Public Property CNAE As String            ' Código Nacional de Atividade Econômica
    Public Property SociaGerente As String
    Public Property SociaGerenteCPF As String
    Public Property SociaGerenteRG As String
    Public Property SindicalCodigo As String
    Public Property SindicalCNPJ As String
    Public Property SindicalRazaoSocial As String
    Public Property holeriteLocal As String
    Public Property CnpjCab As String = "01 CNPJ/CEI"
    Public Property RazaoSocialCab As String = "02 Razão Social / Nome"
    Public Property EnderecoCab As String = "03 Endereço (logradouro, nº, andar, apartamento)"
    Public Property BairroCab As String = "04 Bairro"
    Public Property MunicipioCab As String = "05 Município"
    Public Property UfCab As String = "06 UF"
    Public Property CEPCab As String = "07 CEP"
    Public Property CNAECab As String = "08 CNAE"
    Public Property CNPJTomadorObra As String = "09 CNPJ/CEI Tomador/Obra"

End Class


