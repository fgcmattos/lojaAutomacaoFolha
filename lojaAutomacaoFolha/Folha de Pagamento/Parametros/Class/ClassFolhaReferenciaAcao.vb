Imports MySql.Data.MySqlClient
Public Class ClassFolhaReferenciaAcao

    Public Shared Function GetReferenciaDB(Ref As String) As List(Of ClassFolhaReferencia)

        Dim query As String

        query = "Select "
        query += "(Select count(*) From diasuteiscab  Where DUCabAnoMes = '202306') as n_count"
        query += ",if(isnull(DUcab_abertura),'',DUcab_abertura) as abertura"
        query += ",if(isnull(DUcab_fechamento) or DUcab_fechamento='','0',DUcab_fechamento) as fechamento"
        query += " From diasuteiscab"
        query += " Where DUCabAnoMes = '" & Ref & "'"

        Dim lista As New List(Of ClassFolhaReferencia)

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(query, Conn)


        If OpenDB() Then

            DTReader = CMD.ExecuteReader
            DTReader.Read()
            lista.Add(New ClassFolhaReferencia() With
            {
            .encerramentoTeste = DTReader.GetValue(0),
            .Referencia = DTReader.GetValue(1),
            .Encerramento = DTReader.GetValue(2)
            }
            )

            Conn.Close()

        End If

        Return lista

    End Function

End Class
