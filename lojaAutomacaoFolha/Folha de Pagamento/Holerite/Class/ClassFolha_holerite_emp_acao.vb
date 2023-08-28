Imports MySql.Data.MySqlClient
Public Class ClassFolha_holerite_emp_acao

    Public Shared Function GetholempDB() As List(Of ClassFolha_holerite_emp)

        Dim Query As String = "Select empCNPJ,empNome,empEndereco,empCidade,empUF,empCEP from empresa"

        Dim DTReader As MySqlDataReader

        Dim lista As New List(Of ClassFolha_holerite_emp)

        Dim strAponta As String = ""


        Dim CMD As New MySqlCommand(Query, Conn)

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()

                lista.Add(New ClassFolha_holerite_emp() With
                {
                .CNPJ = DTReader.GetValue(0),
                .Razao_social = DTReader.GetValue(1),
                .Endereco = DTReader.GetValue(2),
                .Cidade = DTReader.GetValue(3),
                .UF = DTReader.GetValue(4),
                .CEP = DTReader.GetValue(5)
                }
                )

            Catch ex As Exception

                MsgBox("Problemas ApontaAcoes!")

            End Try

        End If

        Conn.Close()

        Return lista
    End Function
End Class
