Imports MySql.Data.MySqlClient
Public Class empresaEmpregadoraRP

    Public Shared Function GetEmpresa() As List(Of empresaEmpregadora)
        Dim arrayLocal(20) As String
        If OpenDB() Then

            Dim Query As String = "select * from empresa "
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                arrayLocal(0) = DTReader.GetString(1) ' Nome da Empresa
                arrayLocal(1) = DTReader.GetString(3) ' CNPJ
                arrayLocal(2) = DTReader.GetString(6) ' Endereco 
                arrayLocal(3) = DTReader.GetString(20) ' Endereco Numero
                arrayLocal(4) = DTReader.GetString(21) ' Endereco Complemento
                arrayLocal(5) = DTReader.GetString(8)  ' Cidade
                arrayLocal(6) = DTReader.GetString(9)  ' UF
                arrayLocal(8) = DTReader.GetString(7)  ' CEP
                arrayLocal(9) = DTReader.GetString(22)  ' Socio Gerente
                arrayLocal(10) = DTReader.GetString(23)  ' Socio Gerente CPF
                arrayLocal(11) = DTReader.GetString(24)  ' Socio Gerente RG
            Catch ex As Exception
                MsgBox("Problemas Na Leitura da empresa!")

            End Try

            Conn.Close()
        End If

        Dim lista As New List(Of empresaEmpregadora) From {
            New empresaEmpregadora() With {
                .nome = arrayLocal(0),
                .CNPJ = arrayLocal(1),
                .Endereco = arrayLocal(2),
                .EnderecoNumero = arrayLocal(3),
                .EnderecoComplemento = arrayLocal(4),
                .Cidade = arrayLocal(5),
                .UF = arrayLocal(6),
                .CEP = arrayLocal(8),
                .sociaGerente = arrayLocal(9),
                .sociaGerenteCPF = arrayLocal(10),
                .socialGerenteRG = arrayLocal(11)
               }}

        Return lista
    End Function
End Class
