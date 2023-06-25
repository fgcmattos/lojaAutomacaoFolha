Imports MySql.Data.MySqlClient
Public Class EmpregadorAcao

    Public Shared Function GetEmpregadorRescisao() As List(Of empregador)

        Dim lista As New List(Of empregador)



        Dim Query As String = ""
        Query += "select "
        Query += "empNome"                  '(0)
        Query += ",empCNPJ"                 '(1)
        Query += ",empEndereco"             '(2)
        Query += ",empCEP"                  '(3)
        Query += ",empCidade"               '(4)
        Query += ",empUF"                   '(5)
        Query += ",empcnae"                 '(6)
        Query += ",empEnderecoNumero"       '(7)
        Query += ",empEnderecoComplemento"  '(8)
        Query += ",empSociaGerente"         '(9)
        Query += ",empSociaGerenteCPF"      '(10)
        Query += ",empSociaGerenteRG"       '(11)
        Query += ",empBairro"               '(12)
        Query += ",empSindicalCodigo"       '(13)
        Query += ",empSindicalCNPJ"         '(14)
        Query += ",empSindicalRazaoSocial"  '(15)
        Query += ",empHoleriteLocal"        '(16)
        Query += " from empresa "

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New empregador() With
                    {
                    .RazaoSocial = DTReader.GetValue(0),
                    .Cnpj = DTReader.GetValue(1),
                    .Endereco = DTReader.GetValue(2),
                    .CEP = DTReader.GetValue(3),
                    .Municipio = DTReader.GetValue(4),
                    .Uf = DTReader.GetValue(5),
                    .CNAE = DTReader.GetValue(6),
                    .EnderecoNumero = DTReader.GetValue(7),
                    .EnderecoComplemento = DTReader.GetValue(8),
                    .sociaGerente = DTReader.GetValue(9),
                    .SociaGerenteCPF = CPFcolocaMascara(DTReader.GetValue(10)),
                    .SociaGerenteRG = DTReader.GetValue(11),
                    .Bairro = DTReader.GetValue(12),
                    .SindicalCodigo = DTReader.GetValue(13),
                    .SindicalCNPJ = DTReader.GetValue(14),
                    .SindicalRazaoSocial = DTReader.GetValue(15),
                    .EnderecoCompleto = Trim(.Endereco) & ". " & Trim(.EnderecoNumero) & " - " & Trim(.EnderecoComplemento) & " - " & Trim(.Municipio) & " - " & Trim(.Uf) & " CEP:" & Trim(.CEP),
                    .holeriteLocal = DTReader.GetValue(16)
                    }
                    )

            Catch ex As Exception

                MsgBox("Problemas Na Leitura da empresa!")

            End Try

            Conn.Close()
        End If


        Return lista
    End Function
End Class
