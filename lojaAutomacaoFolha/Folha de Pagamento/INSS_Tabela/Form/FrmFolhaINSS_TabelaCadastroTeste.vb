Public Class FrmFolhaINSS_TabelaCadastroTeste


    Private Sub MskReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskReferencia.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim isValidFormat As Boolean = CheckDateFormat(MskReferencia.Text, "yyyy/MM")

            If isValidFormat Then



                Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_Ref_DB(MskReferencia.Text)

                ListView1.Items.Clear()

                For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

                    ListView1.Items.Add(i)

                    Select Case i

                        Case 1
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
                            ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

                        Case 2
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
                            ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

                        Case 3
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
                            ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

                        Case 4
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
                            ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

                    End Select



                Next


            Else

                MsgBox("Referencia inValida")

            End If

        End If

    End Sub

    Function CheckDateFormat(input As String, format As String) As Boolean

        Dim parsedDate As Date
        Return Date.TryParseExact(input, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate)

    End Function


    Private Sub FrmFolhaINSS_TabelaCadastroTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Query As String

        Query = "Select count(*) from inss where INSStabelaStatus=0"

        If ApontaSQL(Query) = 0 Then

            MsgBox("Não existe tabela digitada para a conferência")

            Me.Close()

        End If


        INSS_mostra_tabela(gravaSQLretorno("Select concat(substring(INSSREF,1,4) ,'/',substring(INSSREF,5)) from `00000000000000`.inss where INSStabelaStatus=0"))

    End Sub

    Private Function INSS_mostra_tabela(StrReferencia As String)

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_Ref_DB(StrReferencia)

        ListView1.Items.Clear()

        For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

            ListView1.Items.Add(i)

            Select Case i

                Case 1
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

                Case 2
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

                Case 3
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

                Case 4
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

            End Select



        Next
    End Function
End Class