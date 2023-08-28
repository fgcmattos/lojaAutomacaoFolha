Imports MySql.Data.MySqlClient
Public Class TrabalhadorAcao

    Public Shared Function GetTrabalhadorRescisao(strKeyCol As String) As List(Of Trabalhador)

        Dim lista As New List(Of Trabalhador)

        Dim Query As String = ""
            Query += "select "
            Query += "colaboradorPIS"                      '0
            Query += ",colaboradorNome "                   '1
            Query += ",colaboradorResidencia "             '2
            Query += ",colaboradorResidenciaCidade "       '3
            Query += ",colaboradorResidenciaUF "           '4
            Query += ",colaboradorResidenciaCEP "          '5
        Query += ",colaboradorResidenciaBairro "       '6
        Query += ",colaboradorCTPS "                   '7
        Query += ",colaboradorCTPSoe  "                '8
            Query += ",colaboradorCTPSuf "                 '9
            Query += ",colaboradorCTPSerie "               '10
            Query += ",colaboradorCTPSemissao "            '11
            Query += ",colaboradorCTPSvalidade "           '12
            Query += ",colaboradorCPF "                    '13
            Query += ",colaboradorNascimento "             '14
            Query += ",colaboradorMae "                    '15
            Query += " from colaborador "                   '16
            Query += " where chave = " & strKeyCol


            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New Trabalhador() With
                    {
                    .PisPasep = DTReader.GetValue(0),
                    .Nome = DTReader.GetValue(1),
                    .Endereco = DTReader.GetValue(2),
                    .Cidade = DTReader.GetValue(3),
                    .UF = DTReader.GetValue(4),
                    .CEP = DTReader.GetValue(5),
                    .Bairro = DTReader.GetValue(6),
                    .CTPS = DTReader.GetValue(7) & "," & DTReader.GetValue(10) & "," & DTReader.GetValue(9),
                    .Cpf = CPFcolocaMascara(DTReader.GetValue(13)),
                    .Nascimento = dataLatina(DTReader.GetValue(14)),
                    .Mae = DTReader.GetValue(15)
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
