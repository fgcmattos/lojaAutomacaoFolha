Imports MySql.Data.MySqlClient
Public Class ReciboRP

    Public Shared Function ReciboCargaEmissor() As List(Of recibo)

        ''//            Tem como função carregar parcialmente o objeto recibo com os 
        ''              campos do emissor ficando a sequencia dos demais campos 
        ''              a serem preenchidos pela tela do sistema chamador
        ''//

        Dim lista As New List(Of recibo)
        Dim a As Integer = 0
        If OpenDB() Then

            Dim Query As String = "select * from empresa"

            Query = "Select empNome"
            Query += ",empCNPJ"
            Query += ",empEndereco"
            Query += ",empEnderecoNumero"
            Query += ",empEnderecoComplemento"
            Query += ",empCidade"
            Query += ",empUF"
            Query += ",concat(empEndereco, ',', empEnderecoNumero, ' - ', empEnderecoComplemento, ' - ', empCidade, '-', empUF, ' CEP:', substring(empCep, 1, 5), '-', substring(empCep, 6)) "
            Query += " From empresa "

            Dim DTReader As MySqlDataReader

            Dim CMD As New MySqlCommand(Query, Conn)

            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New recibo() With
               {
                .EmissorNome = DTReader.GetString(0),                                      'E1
                .EmissorIdTipo = "CNPJ",                                                   'E2
                .EmissorIdNumero = CNPJcolocaMascara(DTReader.GetString(1)),               'E3
                .EmissorEndereco = DTReader.GetString(2),                                  'E4
                .EmissorEnderecoNumero = DTReader.GetString(3),                            'E5
                .EmissorEnderecoComplemento = DTReader.GetString(4),                       'E6
                .EmissorCidade = DTReader.GetString(5),                                    'E7
                .EmissorUF = DTReader.GetString(6),                                        'E8
                .EmissorLocal = DTReader.GetString(7)                                      'E9
               }
               )
                Conn.Close()

            Catch ex As Exception
                MsgBox("Problemas Na leitura do arquivo de empresa!")
                Conn.Close()
            End Try

        End If

        Return lista

    End Function

    Public Shared Function GetReciboHist() As List(Of ReciboHist)

        Dim lista As New List(Of ReciboHist)

        If OpenDB() Then

            Dim query As String = "select * from recibohistpad order by reciboHistPadCod"
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New ReciboHist() With
                    {
                        .codigo = DTReader.GetString(1),            ' Codigo do Historico
                        .Funcao = DTReader.GetString(4),            ' Função objetivo do Historico
                        .Nome = DTReader.GetString(2),              ' Nome de conhecimento do historico
                        .Historico = DTReader.GetString(3),         ' Nome de conhecimento do historico
                        .Responsavel = DTReader.GetString(5)        ' Criador do historico
                    }
                    )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura dos Históricos!")
            End Try

            Conn.Close()
        End If


        Return lista
    End Function

    Public Shared Function GetReciboVariaveis() As List(Of ReciboVariaveis)

        Dim lista As New List(Of ReciboVariaveis)


        If OpenDB() Then

            Dim query As String = "SELECT * FROM comercio.reciboVariaveis order by reciboVariaveisOrdem,reciboVariaveisCodigo"
            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New ReciboVariaveis() With
                    {
                        .Id = DTReader.GetString(0),                ' ID da tabela recibovariaveis
                        .Codigo = DTReader.GetString(1),            ' Codigo do Parametro
                        .Descricao = DTReader.GetString(2),         ' Descricao do Parametro
                        .GrupoListView = DTReader.GetString(3)      ' Grupo para show no ListView
                    }
                    )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura dos Históricos!")
            End Try

            Conn.Close()
        End If


        Return lista
    End Function

    Public Shared Function GetReciboREstart(Numero As String) As List(Of Recibo)

        Dim strCodigoLocal As String = Numero.Substring(0, 7)
        Dim intCodigoSequencial As Integer = Val(Numero.Substring(8))

        Dim lista As New List(Of Recibo)


        If OpenDB() Then

            Dim query As String
            query = "SELECT ReciboFavorecido,ReciboTextoPactuado,reciboValorBR,ReciboFavorecidoRG,ReciboCPF_CNPJ,reciboDataEmissao,reciboDataLocal"
            query += ",ReciboNumeroLocal,ReciboNumeroLocal,ReciboNumeroSequencial,ReciboFavorecidoRGemissao,ReciboReferencia"
            query += " FROM recibo "
            query += "where ReciboNumeroLocal = "
            query += "'" & strCodigoLocal & "'"
            query += " and ReciboNumeroSequencial = "
            query += intCodigoSequencial.ToString

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read
                    lista.Add(New Recibo() With
                    {
                        .Favorecido = DTReader.GetString(0),
                        .TextoPactuado = DTReader.GetString(1),
                        .ValorBR = DTReader.GetString(2),
                        .FavorecidoRg = DTReader.GetString(3),
                        .FavorecidoCpf_Cnpj = DTReader.GetString(4),
                        .DataEmissao = DTReader.GetString(5),
                        .LocalData = DTReader.GetString(6),
                        .NumeroAnoMesSeq = DTReader.GetString(7),
                        .NumeroSequencial = DTReader.GetString(8),
                        .FavorecidoRgEmissao = DTReader.GetString(9),
                        .Referencia = DTReader.GetString(10)
                    }
                    )
                End While
            Catch ex As Exception
                MsgBox("Problemas Na Leitura dos Históricos!")
            End Try

            Conn.Close()
        End If


        Return lista
    End Function

End Class
