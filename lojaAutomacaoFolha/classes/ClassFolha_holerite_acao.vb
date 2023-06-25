Imports MySql.Data.MySqlClient
Public Class ClassFolha_holerite_acao

    Public Shared Function GetEmpHolDB() As List(Of ClassFolha_holerite)

        Dim query As String = "Select "
        query += "empNome"
        query += ",empCNPJ"
        query += ",empEndereco"
        query += ",empCidade"
        query += ",empUF"
        query += ",empCEP"
        query += " From empresa"


        Dim lista As New List(Of ClassFolha_holerite)

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)


        If OpenDB() Then

            DTReader = CMD.ExecuteReader
            DTReader.Read()
            lista.Add(New ClassFolha_holerite() With
            {
            .Razao_social = DTReader.GetValue(0),
            .CNPJ = DTReader.GetValue(1),
            .Endereco = DTReader.GetValue(2),
            .Cidade = DTReader.GetValue(3),
            .UF = DTReader.GetValue(4),
            .CEP = DTReader.GetValue(2)
            }
            )

            Conn.Close()

        End If

        Return lista

    End Function

End Class
