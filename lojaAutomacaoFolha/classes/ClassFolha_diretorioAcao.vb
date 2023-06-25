Imports MySql.Data.MySqlClient
Public Class ClassFolha_diretorioAcao
    Public Shared Function GetFolhaDiretorio(CPF As String) As List(Of ClassFolha_diretorio)

        Dim strCPF As String = CPF

        Dim lista As New List(Of ClassFolha_diretorio)

        Dim strCaminhoSegmentoDiretorio As String = ""

        Dim Query As String = "select  "

        Dim mtAux(100, 3) As String


        Query += "FCD_codigo"              '0
        Query += ",FCD_Nome"               '1           diretorio
        Query += ",FCD_caminho"            '2           como chegar ao diretorio
        Query += " from folha_col_diretorios"
        Query += " where FCD_sistema =" & "'folha'"
        Query += " order by FCD_codigo "

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        Dim ind1 As Integer = 0

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    strCaminhoSegmentoDiretorio = "\" & Trim(DTReader.GetValue(1))
                    Select Case DTReader.GetValue(1)
                        Case "CNPJ"
                            strCaminhoSegmentoDiretorio = "c:\" & LimpaNumero(Form1.empCNPJ.Text)
                        Case "CPF"
                            strCaminhoSegmentoDiretorio = "\" & LimpaNumero(strCPF)
                    End Select

                    mtAux(ind1, 0) = DTReader.GetValue(0)
                    mtAux(ind1, 1) = DTReader.GetValue(1)
                    mtAux(ind1, 3) = strCaminhoSegmentoDiretorio
                    ind1 += 1

                End While

            Catch ex As Exception
                Dim oi As New MsgShow
                With oi
                    .msg = ex.Message
                    .style = vbCritical
                    MsgBox(.msg, .style, .title)
                    Exit Function
                End With


            End Try

            Conn.Close()
        End If
        Dim strFrase As String = ""
        Dim IntTamanho As Integer = 0
        Dim strComp As String = ""

        Dim intElementos As Integer = ind1 - 1

        For i = 0 To intElementos

            strComp = Trim(mtAux(i, 0))
            IntTamanho = strComp.Length
            mtAux(i, 2) += Trim(mtAux(i, 3))

            For j = (i + 1) To intElementos
                If Trim(mtAux(j, 0)).Length < IntTamanho Then Exit For
                If Trim(mtAux(j, 0)).Substring(0, IntTamanho) = strComp Then

                    mtAux(j, 2) += Trim(mtAux(i, 3))

                Else

                    Exit For

                End If

            Next
        Next

        For i = 0 To intElementos
            lista.Add(New ClassFolha_diretorio() With
                            {
                            .Codigo = mtAux(i, 0),
                            .NomeVariavel = mtAux(i, 1),
                            .Caminho = Trim(mtAux(i, 2))
                            }
                            )
        Next

        Return (lista)

    End Function
End Class
