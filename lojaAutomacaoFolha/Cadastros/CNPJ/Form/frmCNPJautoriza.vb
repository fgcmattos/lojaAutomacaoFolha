Public Class FrmCNPJautoriza

    Dim Oi As New MsgShow

    Private Sub BtnValida_Click(sender As Object, e As EventArgs) Handles BtnValida.Click

        Dim STRcnpj As String = CNPJretiraMascara(MskCNPJ.Text)


        Select Case CNPJchek(STRcnpj)

            Case 1
                MskCNPJ.Focus()

            Case 2
                MskCNPJ.Focus()

            Case 3
                With Oi
                    .title = Me.Text
                    .style = vbYesNo + vbQuestion + vbDefaultButton1
                    .msg = "CNPJ válido, Inicia o Cadastramento?"

                    If MsgBox(.msg, .style, .title) = 6 Then

                        FrmFornecedorCad.Show()

                        FrmFornecedorCad.lblCNPJ.Text = Replace(MskCNPJ.Text, ",", ".")


                        Me.Close()
                    End If

                End With

                MskCNPJ.Focus()

            Case 4
                MskCNPJ.Focus()

        End Select

    End Sub

    Private Sub BtnCancela_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        Me.Close()
    End Sub

    Private Sub MskCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskCNPJ.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            Me.Close()

        End If

        If e.KeyChar = Convert.ToChar(13) Then

            Dim STRcnpj As String = CNPJretiraMascara(MskCNPJ.Text)

            Select Case CNPJchek(STRcnpj)
                Case 1
                    MskCNPJ.Focus()

                Case 2
                    MskCNPJ.Focus()

                Case 3
                    With Oi
                        .title = Me.Text
                        .style = vbYesNo + vbQuestion + vbDefaultButton1
                        .msg = "CNPJ válido, Inicia o Cadastramento?"

                        If MsgBox(.msg, .style, .title) = 6 Then

                            FrmFornecedorCad.Show()

                            FrmFornecedorCad.lblCNPJ.Text = Replace(MskCNPJ.Text, ",", ".")

                            Me.Close()

                        End If

                    End With

                    MskCNPJ.Focus()

                Case 4
                    MskCNPJ.Focus()

            End Select

        End If
    End Sub

    Private Function CNPJchek(strCNPJ As String) As Integer

        If Len(strCNPJ) < 14 Then

            With Oi

                .title = Me.Text
                .style = vbExclamation
                .msg = "CNPJ com mesmo de 14 digitos"

                MsgBox(.msg, .style, .title)

                CNPJchek = 1

                Exit Function

            End With

        End If

        If CNPJtesteAcao.CNPJchek(MskCNPJ.Text) Then

            Dim query As String = "Select "

            If ApontaElementosSQL("fornecedor", "forIdentificacao", strCNPJ, False) Then

                With Oi

                    .title = Me.Text
                    .style = vbExclamation
                    .msg = "CNPJ Já Cadastrado" & Chr(13) & Chr(13) & "Caso necessite, utilize o módulo De Manutenção"
                    MsgBox(.msg, .style, .title)

                End With

                CNPJchek = 2

                Exit Function

            End If

            CNPJchek = 3

            Exit Function

        Else

            With Oi
                .title = Me.Text
                .style = vbExclamation
                .msg = "CNPJ inválido !"
                MsgBox(.msg, .style, .title)
            End With

            CNPJchek = 4

        End If

        MskCNPJ.Focus()

    End Function

End Class