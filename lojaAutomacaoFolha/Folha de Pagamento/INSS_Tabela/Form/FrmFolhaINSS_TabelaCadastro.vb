Public Class FrmFolhaINSS_TabelaCadastro
    Dim oi As New MsgShow

    Private Function LimpaEdicao()

        TxtValorFaixa.Text = ""
        TxtPorcentagemFaixa.Text = ""
        TxtImpostoFaixa.Text = ""
        TxtImpostoFaixaAcumulado.Text = ""

    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        If ListView1.SelectedItems.Count > 0 Then

            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim itemSubItems As String() = selectedItem.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subItem) subItem.Text).ToArray()
            LblFaixa.Text = selectedItem.Text
            TxtValorFaixa.Text = itemSubItems(1)
            TxtPorcentagemFaixa.Text = itemSubItems(2)
            TxtImpostoFaixa.Text = itemSubItems(3)
            TxtImpostoFaixaAcumulado.Text = itemSubItems(4)

        End If

    End Sub

    Private Sub BtnIncrementa_Click(sender As Object, e As EventArgs) Handles BtnIncrementa.Click

        Dim intIndex As Integer = ListView1.Items.Count

        With ListView1

            If Int(LblFaixa.Text) <= intIndex Then

                Dim indSelecionado As Integer = Int(LblFaixa.Text) - 1

                .Items(indSelecionado).Text = LblFaixa.Text
                .Items(indSelecionado).SubItems(1).Text = TxtValorFaixa.Text
                .Items(indSelecionado).SubItems(2).Text = TxtPorcentagemFaixa.Text
                .Items(indSelecionado).SubItems(3).Text = TxtImpostoFaixa.Text
                .Items(indSelecionado).SubItems(4).Text = TxtImpostoFaixaAcumulado.Text

            Else

                .Items.Add(LblFaixa.Text)
                .Items(intIndex).SubItems.Add(TxtValorFaixa.Text)
                .Items(intIndex).SubItems.Add(TxtPorcentagemFaixa.Text)
                .Items(intIndex).SubItems.Add(TxtImpostoFaixa.Text)
                .Items(intIndex).SubItems.Add(TxtImpostoFaixaAcumulado.Text)
                intIndex += 1

            End If


        End With

        LimpaEdicao()

        LblFaixa.Text = intIndex + 1

    End Sub

    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown

        If e.Button = MouseButtons.Right Then ' Verifica se o botão pressionado é o botão direito do mouse
            Dim clickedItem As ListViewItem = ListView1.GetItemAt(e.X, e.Y)
            If clickedItem IsNot Nothing Then
                Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ListView1.Items.Remove(clickedItem)

                    Dim intVariavel As Integer = 1

                    For Each item As ListViewItem In ListView1.Items

                        ' Acessar as propriedades do item aqui
                        item.Text = intVariavel
                        intVariavel += 1

                    Next
                End If
            End If
        End If

        LblFaixa.Text = ListView1.Items.Count + 1

    End Sub

    Private Sub BtnLiberaEdicao_Click(sender As Object, e As EventArgs) Handles BtnLiberaEdicao.Click

        Dim StrData1 As String = dataAAAAMMDD(DateTimePicker1.Value.ToString.Substring(0, 10)).Substring(0, 6)

        Dim data_tabela_em_vigor As String = gravaSQLretorno("select INSS_dataInicio from inss where INSS_ativa")

        If data_tabela_em_vigor >= StrData1 Then

            With oi
                .Msg = "Início data de válidade da tabela em vigor é " & data_tabela_em_vigor & Chr(13)
                .Msg += "Portanto a data de validade da nova Tabela tem que ser superior a essa data"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If


        Dim data_do_servidor As String = gravaSQLretorno("select concat(Year(Now()), lpad(Month(Now()), 2,'0'))")

        If data_do_servidor > StrData1 Then
            With oi
                .Msg = "Início da data de válidade da nova tabela" & Chr(13)
                .Msg += "não pode ser no passado, Ano e Mês atual " & data_do_servidor
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If

        TxtValorFaixa.Focus()

        EditarCampoTextBox(TxtValorFaixa)

    End Sub

    Private Sub TxtValorFaixa_TextChanged(sender As Object, e As EventArgs) Handles TxtValorFaixa.TextChanged

    End Sub

    Private Sub TxtValorFaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorFaixa.KeyPress

        With TxtValorFaixa

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                'LblreciboValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'tbcFavorecido.Enabled = True
                'GruFavorecido.Enabled = True
                'GruCaracteristicas.Enabled = False
                'btnFavOK.Focus()

            End If

            If e.KeyChar = Convert.ToChar(13) Then



                'lblExtenso.Text = Extenso(.Text)
                'txtValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                'lblReciboData.ForeColor = System.Drawing.Color.Maroon
                'LblReciboDataAponta.Visible = True
                'mskReciboData.Enabled = True
                'mskReciboData.Focus()

                SendKeys.Send("{TAB}")

                EditarCampoTextBox(TxtPorcentagemFaixa)

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

    Private Sub TxtPorcentagemFaixa_TextChanged(sender As Object, e As EventArgs) Handles TxtPorcentagemFaixa.TextChanged

    End Sub

    Private Sub TxtPorcentagemFaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPorcentagemFaixa.KeyPress

        With TxtPorcentagemFaixa

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                'LblreciboValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'tbcFavorecido.Enabled = True
                'GruFavorecido.Enabled = True
                'GruCaracteristicas.Enabled = False
                'btnFavOK.Focus()

            End If

            If e.KeyChar = Convert.ToChar(13) Then



                'lblExtenso.Text = Extenso(.Text)
                'txtValor.Enabled = False
                'LblReciboValorAponta.Visible = False
                'LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                'LblreciboValor.ForeColor = System.Drawing.Color.Black

                'lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                'lblReciboData.ForeColor = System.Drawing.Color.Maroon
                'LblReciboDataAponta.Visible = True
                'mskReciboData.Enabled = True
                'mskReciboData.Focus()

                SendKeys.Send("{TAB}")

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

End Class