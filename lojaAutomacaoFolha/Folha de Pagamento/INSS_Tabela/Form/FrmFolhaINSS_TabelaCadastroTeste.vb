Imports Microsoft.Reporting
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Linq

Public Class FrmFolhaINSS_TabelaCadastroTeste

    Dim oi As New MsgShow



    '''''Private Sub MskReferencia_KeyPress(sender As Object, e As KeyPressEventArgs)

    '''''    If e.KeyChar = Convert.ToChar(13) Then

    '''''        Dim isValidFormat As Boolean = CheckDateFormat(MskReferencia.Text, "yyyy/MM")

    '''''        If isValidFormat Then



    '''''            Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_Ref_DB(MskReferencia.Text)

    '''''            ListView1.Items.Clear()

    '''''            For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

    '''''                ListView1.Items.Add(i)

    '''''                Select Case i

    '''''                    Case 1
    '''''                        ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
    '''''                        ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
    '''''                        ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
    '''''                        ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

    '''''                    Case 2
    '''''                        ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
    '''''                        ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
    '''''                        ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
    '''''                        ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

    '''''                    Case 3
    '''''                        ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
    '''''                        ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
    '''''                        ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
    '''''                        ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

    '''''                    Case 4
    '''''                        ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
    '''''                        ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
    '''''                        ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
    '''''                        ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

    '''''                End Select



    '''''            Next


    '''''        Else

    '''''            MsgBox("Referencia inValida")

    '''''        End If

    '''''    End If

    '''''End Sub

    Function CheckDateFormat(input As String, format As String) As Boolean

        Dim parsedDate As Date
        Return Date.TryParseExact(input, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate)

    End Function

    Private Sub FrmFolhaINSS_TabelaCadastroTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.Title = Me.Text

        Dim Query As String

        Query = "Select count(*) from inss where INSStabelaStatus=0"

        If ApontaSQL(Query) = 0 Then

            MsgBox("Não existe tabela digitada para a conferência")

            Me.Close()

            Exit Sub

        End If


        INSS_mostra_tabela(gravaSQLretorno("Select INSSREF from inss where INSStabelaStatus=0"))



    End Sub

    Private Function INSS_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "INSSREF = '" & StrReferencia & "'"

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_DB(IsComparacao)

        ListView1.Items.Clear()

        LblDataCriacao.Text = INSStabela(0).Class_INSSdataCriacao
        LblCriadoPor.Text = INSStabela(0).Class_INSSresponsavelDigitacao
        LblReferencia.Text = INSStabela(0).Class_INSSREF.Substring(0, 4) & "/" & INSStabela(0).Class_INSSREF.Substring(4)

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

        'Gerando 5 bases aleatórias
        Dim IsMatBaseInss(5, 5) As Decimal
        'Dim numeroAleatorio As Integer = Int((max - min + 1) * Rnd()) + min

        IsMatBaseInss(1, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa1 - 750 + 1) * Rnd() + 750, 2)
        IsMatBaseInss(2, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa2 - INSStabela(0).Class_INSSfaixa1 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa1, 2)
        IsMatBaseInss(3, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa3 - INSStabela(0).Class_INSSfaixa2 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa2, 2)
        IsMatBaseInss(4, 0) = Math.Round(Int(INSStabela(0).Class_INSSfaixa4 - INSStabela(0).Class_INSSfaixa3 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa3, 2)
        IsMatBaseInss(5, 0) = Math.Round(Int(40000 - INSStabela(0).Class_INSSfaixa4 + 1) * Rnd() + INSStabela(0).Class_INSSfaixa4, 2)

        ' Gerando os calculos por base - Gravação no item (base,5)
        IsMatBaseInss(1, 5) = INSScalculo(IsMatBaseInss(1, 0), IsComparacao)
        IsMatBaseInss(2, 5) = INSScalculo(IsMatBaseInss(2, 0), IsComparacao)
        IsMatBaseInss(3, 5) = INSScalculo(IsMatBaseInss(3, 0), IsComparacao)
        IsMatBaseInss(4, 5) = INSScalculo(IsMatBaseInss(4, 0), IsComparacao)
        IsMatBaseInss(5, 5) = INSScalculo(IsMatBaseInss(5, 0), IsComparacao)

        ' Exibindo as base selecionadas
        LblBase1.Text = numeroLatino(IsMatBaseInss(1, 0), 10, True)
        LblBase2.Text = numeroLatino(IsMatBaseInss(2, 0), 10, True)
        LblBase3.Text = numeroLatino(IsMatBaseInss(3, 0), 10, True)
        LblBase4.Text = numeroLatino(IsMatBaseInss(4, 0), 10, True)
        LblBase5.Text = numeroLatino(IsMatBaseInss(5, 0), 10, True)

        ' Exibindo os descontos apurados de cada base 
        LblTotal_b1.Text = numeroLatino(IsMatBaseInss(1, 5), 8, True)
        LblTotal_b2.Text = numeroLatino(IsMatBaseInss(2, 5), 8, True)
        LblTotal_b3.Text = numeroLatino(IsMatBaseInss(3, 5), 8, True)
        LblTotal_b4.Text = numeroLatino(IsMatBaseInss(4, 5), 8, True)
        LblTotal_b5.Text = numeroLatino(IsMatBaseInss(5, 5), 8, True)



        If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa1 Then

            LblFaixa1_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)

            If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa2 Then

                LblFaixa2_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)

                If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa3 Then

                    LblFaixa3_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)

                    If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa4 Then

                        LblFaixa4_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)
                    Else

                        LblFaixa4_b1.Text = numeroLatino(0, 8, True)

                    End If

                Else
                    LblFaixa3_b1.Text = numeroLatino(0, 8, True)
                    LblFaixa4_b1.Text = numeroLatino(0, 8, True)

                End If

            Else
                LblFaixa2_b1.Text = numeroLatino(0, 8, True)
                LblFaixa3_b1.Text = numeroLatino(0, 8, True)
                LblFaixa4_b1.Text = numeroLatino(0, 8, True)

            End If

        Else
            LblFaixa1_b1.Text = numeroLatino(Math.Round((IsMatBaseInss(1, 0) * INSStabela(0).Class_INSSfaixa1Porcentagem) / 100, 2), 8, True)
            LblFaixa2_b1.Text = numeroLatino(0, 8, True)
            LblFaixa3_b1.Text = numeroLatino(0, 8, True)
            LblFaixa4_b1.Text = numeroLatino(0, 8, True)

        End If

        If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        LblFaixa2_b2.Text = numeroLatino(Math.Round(IsMatBaseInss(2, 5) - INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        LblFaixa3_b2.Text = numeroLatino(0, 8, True)
        LblFaixa4_b2.Text = numeroLatino(0, 8, True)

        If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        LblFaixa3_b3.Text = numeroLatino(Math.Round(IsMatBaseInss(3, 5) - INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True)
        LblFaixa4_b3.Text = numeroLatino(0, 8, True)



        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)

        If INSStabela(0).Class_INSSnumeroDeFaixas > 3 Then

            LblFaixa4_b4.Text = numeroLatino(Math.Round(IsMatBaseInss(4, 5) - INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True)

        Else

            LblFaixa3_b4.Text = numeroLatino(Math.Round(IsMatBaseInss(4, 5) - INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True)

        End If

        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(1, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b1.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(2, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b2.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(3, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b3.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        'If IsMatBaseInss(4, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b4.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)

        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa1 Then LblFaixa1_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa2 Then LblFaixa2_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa3 Then LblFaixa3_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True)
        If IsMatBaseInss(5, 0) >= INSStabela(0).Class_INSSfaixa4 Then LblFaixa4_b5.Text = numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True)
    End Function

    Private Sub CheckBoxOK1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK1.CheckedChanged

        With CheckBoxOK1
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With

    End Sub



    Private Sub CheckBoxOK2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK2.CheckedChanged
        With CheckBoxOK2
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With

    End Sub

    Private Sub CheckBoxOK3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK3.CheckedChanged
        With CheckBoxOK3
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK4.CheckedChanged
        With CheckBoxOK4
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK5.CheckedChanged
        With CheckBoxOK5
            If .Checked Then
                .Text = "OK"
                .ForeColor = Color.Green
            Else
                .Text = "Não OK"
                .ForeColor = Color.Red
            End If
        End With
    End Sub

    Private Sub CheckBoxOK6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOK6.CheckedChanged
        With CheckBoxOK6
            If .Checked Then

                If TxtValorBase.Text = "0,00" Then

                    With oi

                        .Msg = "Teste Simulado inválido !"
                        .Style = vbCritical
                        MsgBox(.Msg, .Style, .Title)
                        CheckBoxOK6.Checked = False
                        LblINSSValorSimulado.Text = "0,00"
                        TxtValorBase.Focus()
                        Exit Sub

                    End With

                End If
                TxtValorBase.Enabled = False
                LblINSSValorSimulado.Text = INSScalculo(TxtValorBase.Text, "INSStabelaStatus=0")
                .Text = "OK"
                .ForeColor = Color.Green
                TxtValorBase.Enabled = False

            Else

                .Text = "Não OK"
                .ForeColor = Color.Red
                TxtValorBase.Enabled = True
                TxtValorBase.Enabled = True

            End If
        End With
    End Sub


    Private Sub TxtValorBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorBase.KeyPress
        With TxtValorBase

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

                Exit Sub

            End If

            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If

            If e.KeyChar = Convert.ToChar(27) Then

                TxtValorBase.Text = "0,00"


            End If

            If e.KeyChar = Convert.ToChar(13) Then


                If .Text <= 0.00 Then

                    MsgBox("A Base deve ter um valor maior que 0.00", vbExclamation, Me.Text)
                    Exit Sub


                End If

                LblINSSValorSimulado.Text = INSScalculo(TxtValorBase.Text, "INSStabelaStatus=0")


                'SendKeys.Send("{TAB}")


                Exit Sub

            End If

            If Asc(e.KeyChar) = 8 Then       ' BACKSPACE

                e.KeyChar = ""


                If .Text = "0,00" Then Exit Sub
                If .Text.Substring(0, 3) = "0,0" And .Text.Length = 4 Then .Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
                If .Text.Substring(0, 2) = "0," And .Text.Length = 4 Then .Text = "0,0" + .Text.Substring(.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
                If .Text.Length = 4 Then .Text = "0," + .Text.Substring(0, 1) + .Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

                .Text = .Text.Substring(0, .Text.Length - 1)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length


                .Text = retMascara(intSemMascara, strSemMascara)
                SendKeys.Send("{END}")
                Exit Sub

            End If

            If e.KeyChar >= "0" And e.KeyChar <= "9" Then

                Dim strComMascara As String = Trim(.Text)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length
                Dim strRetorno As String = ""
                Dim strPressionada As String = e.KeyChar

                e.KeyChar = ""

                If intSemMascara > 13 Then

                    Exit Sub

                End If

                If intSemMascara < 4 And strSemMascara.Substring(0, 1) = "0" Then

                    strSemMascara += strPressionada
                    strSemMascara = strSemMascara.Substring(1)

                Else

                    strSemMascara += strPressionada
                    intSemMascara += 1

                End If

                .Text = retMascara(intSemMascara, strSemMascara)



                SendKeys.Send("{END}")

            Else

                e.KeyChar = ""

                .Focus()


                ' SendKeys.Send("{END}")


            End If

        End With
    End Sub

    Private Sub BtnConferencia_Click(sender As Object, e As EventArgs) Handles BtnConferencia.Click

        Dim IsSemCheck As Boolean = True

        Dim IsTexto As String = ""

        If Not CheckBoxOK1.Checked Then IsSemCheck = False : IsTexto = "1.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK2.Checked Then IsSemCheck = False : IsTexto += "2.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK3.Checked Then IsSemCheck = False : IsTexto += "3.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK4.Checked Then IsSemCheck = False : IsTexto += "4.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK5.Checked Then IsSemCheck = False : IsTexto += "5.º Teste não Confirmado " + Chr(13)
        If Not CheckBoxOK6.Checked Then IsSemCheck = False : IsTexto += "6.º Teste não Confirmado " + Chr(13)

        If Not IsSemCheck Then
            With oi

                .Msg = IsTexto & Chr(13) & "Confira todos os testes"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)

                Exit Sub

            End With
        End If

        With oi

            .Msg = " Confirma Checagem para gravação ?"
            .Style = vbYesNo
            If MsgBox(.Msg, .Style, .Title) <> 6 Then



            Else


                Dim Query As String
                Query = "UPDATE inss "
                Query += "SET INSStabelaStatus = 1 "
                Query += ",INSSresponsavelConferenciaTipo ='" & usuClass.Usuario_Tipo & "'"
                Query += ",INSSresponsavelConferencia =" & usuClass.Usuario_Chave
                Query += ",INSSresponsavelConferencia =" & usuClass.Usuario_Chave
                Query += ",INSSdataConferencia = now()"
                Query += " where "
                Query += "INSSREF = '" & Replace(LblReferencia.Text, "/", "") & "'"
                If gravaSQL(Query) Then
                    With oi

                        .Msg = "Conferência Gravada com sucesso !"
                        .Style = vbExclamation
                        MsgBox(.Msg, .Style, .Title)
                        Me.Close()
                        Exit Sub

                    End With
                End If

            End If

            Exit Sub

        End With

    End Sub

    Private Sub TxtValorBase_TextChanged(sender As Object, e As EventArgs) Handles TxtValorBase.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With oi

            .Msg = "Confirma a retirada da tabela?"
            .Style = vbYesNo
            If MsgBox(.Msg, .Style, .Title) <> 6 Then
                .Msg = "Tabela Mantida"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End If

            Dim Query = "delete from inss where INSSREF= '" & LblReferencia.Text.Replace("/", "") & "'"

            If gravaSQL(Query) Then
                .Msg = "Tabela retirada do sistema com sucesso"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Me.Close()
            Else
                .Msg = "Problema na Retirada da Tabela" & Chr(13)
                .Msg += "Tende de novo"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End If


        End With
    End Sub
End Class