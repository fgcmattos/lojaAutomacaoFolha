Imports MySql.Data.MySqlClient

Module ModuleRecibos

    Public Function ReciboHistoricoCheck(hist As String, variavelLenght As Integer) As Boolean

        ReciboHistoricoCheck = True

        Dim strDigito As String = ""
        Dim intContJanela As Integer = 0
        Dim arrVariavel(100, 1) As String
        Dim inArrVariavel As Integer = 0
        Dim inChekLength As Integer = 0
        Dim strTeste As String = ""
        Dim strErr As String = ""
        Dim intString As Integer = 0


        intString = ContaString("#", hist)

        If intString Mod 2 <> 0 Then

            MsgBox("Número de # não pode ser Impar!" & Chr(13) & "Número de # = " & intString)

            ReciboHistoricoCheck = False

            Exit Function

        End If

        For i = 0 To Len(hist) - 1

            strDigito = hist.Substring(i, 1)

            If strDigito = "#" Then

                intContJanela += 1

                inChekLength = 0

                For j = (i + 1) To ((i + 1) + variavelLenght)

                    strDigito = hist.Substring(j, 1)

                    If strDigito <> "#" Then

                        arrVariavel(inArrVariavel, 0) += strDigito

                        inChekLength += 1

                        If inChekLength > variavelLenght Then

                            'strResultado = "Variavel formada entre # tem mais do que " & variavelLenght & " digitos. Verifique o seu histórico"

                            ReciboHistoricoCheck = False

                            Exit Function

                        End If

                    Else

                        inArrVariavel += 1

                        intContJanela += 1

                        i = j

                        Exit For

                    End If

                Next



            End If
        Next

        'MsgBox("# " & intContJanela & " Variaveis = " & inArrVariavel)


        If OpenDB() Then
            Dim query = " Select * from recibovariaveis "
            Dim DTReader As MySqlDataReader
            Dim CMD As New MySqlCommand(query, Conn)
            Try
                DTReader = CMD.ExecuteReader


                While DTReader.Read()

                    strTeste = DTReader.GetString(1)

                    For k = 0 To inArrVariavel
                        If arrVariavel(k, 0) = strTeste Then
                            arrVariavel(k, 1) = strTeste
                            'Exit For esistem mais de uma variavel igual no historico
                        End If
                    Next

                End While


            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
                Exit Function
            End Try
            Conn.Close()
        End If
        For k = 0 To inArrVariavel

            If arrVariavel(k, 0) <> arrVariavel(k, 1) Then

                strErr += "Variável " & arrVariavel(k, 0) & " Não Existe !" & Chr(13) & Chr(13)

            End If

        Next

        If strErr <> "" Then

            MsgBox(Chr(13) & Chr(13) & strErr, vbCritical, "Erro na definição de variáveis !")

            ReciboHistoricoCheck = False

        End If

    End Function

End Module
