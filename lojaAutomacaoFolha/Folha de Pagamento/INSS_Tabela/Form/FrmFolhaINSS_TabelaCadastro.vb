Public Class FrmFolhaINSS_TabelaCadastro
    Dim oi As New MsgShow

    Private Function LimpaEdicao()

        TxtValorFaixa.Text = "0,00"
        TxtPorcentagemFaixa.Text = "0,00"
        TxtImpostoFaixa.Text = "0,00"
        TxtImpostoFaixaAcumulado.Text = "0,00"

    End Function

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

        TxtValorFaixa.Enabled = True

        TxtValorFaixa.Focus()

        EditarCampoTextBox(TxtValorFaixa)


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

        BtnIncrementa.Enabled = False

        TxtValorFaixa.Enabled = True

        TxtValorFaixa.Focus()

        EditarCampoTextBox(TxtValorFaixa)



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

        'Dim StrData1 As String = dataAAAAMMDD(DateTimePicker1.Value.ToString.Substring(0, 10)).Substring(0, 6)

        'Dim data_tabela_em_vigor As String = gravaSQLretorno("select INSS_dataInicio from inss where INSS_ativa")

        ''''If data_tabela_em_vigor >= StrData1 Then

        ''''    With oi
        ''''        .Msg = "Início data de válidade da tabela em vigor é " & data_tabela_em_vigor & Chr(13)
        ''''        .Msg += "Portanto a data de validade da nova Tabela tem que ser superior a essa data"
        ''''        .Style = vbExclamation
        ''''        MsgBox(.Msg, .Style, .Title)
        ''''        Exit Sub
        ''''    End With

        ''''End If


        'Dim data_do_servidor As String = gravaSQLretorno("select concat(Year(Now()), lpad(Month(Now()), 2,'0'))")

        '''If data_do_servidor > StrData1 Then
        '''    With oi
        '''        .Msg = "Início da data de válidade da nova tabela" & Chr(13)
        '''        .Msg += "não pode ser no passado, Ano e Mês atual " & data_do_servidor
        '''        .Style = vbExclamation
        '''        MsgBox(.Msg, .Style, .Title)
        '''        Exit Sub
        '''    End With

        '''End If

        TxtValorFaixa.Enabled = True

        TxtValorFaixa.Focus()

        EditarCampoTextBox(TxtValorFaixa)

        GroupBox3.Enabled = False

    End Sub

    Private Sub TxtValorFaixa_TextChanged(sender As Object, e As EventArgs) Handles TxtValorFaixa.TextChanged

    End Sub

    Private Sub TxtValorFaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorFaixa.KeyPress

        With TxtValorFaixa

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
                LimpaEdicao()
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





                If TxtValorFaixa.Text <= 0.00 Then

                    With oi

                        .Msg = "A Faixa deve ter um valor maior que 0.00"
                        .Style = vbExclamation
                        MsgBox(.Msg, .Style, .Title)
                        Exit Sub

                    End With

                End If

                TxtValorFaixa.Enabled = False

                TxtPorcentagemFaixa.Enabled = True

                TxtPorcentagemFaixa.Focus()

                EditarCampoTextBox(TxtPorcentagemFaixa)



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

    Private Sub TxtPorcentagemFaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPorcentagemFaixa.KeyPress

        With TxtPorcentagemFaixa

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If

            'MsgBox(.MaxLength & "     " & .Text)

            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                TxtPorcentagemFaixa.Enabled = False

                TxtValorFaixa.Enabled = True

                TxtValorFaixa.Focus()

                EditarCampoTextBox(TxtValorFaixa)

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


                TxtPorcentagemFaixa.Enabled = False

                TxtImpostoFaixa.Enabled = True

                TxtImpostoFaixa.Focus()

                EditarCampoTextBox(TxtImpostoFaixa)


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

    Private Sub TxtImpostoFaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpostoFaixa.KeyPress

        With TxtImpostoFaixa


            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

            End If

            'MsgBox(.MaxLength & "     " & .Text)

            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                TxtImpostoFaixa.Enabled = False

                TxtPorcentagemFaixa.Enabled = True

                TxtPorcentagemFaixa.Focus()

                EditarCampoTextBox(TxtPorcentagemFaixa)

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


                TxtImpostoFaixa.Enabled = False

                TxtImpostoFaixaAcumulado.Enabled = True

                TxtImpostoFaixaAcumulado.Focus()

                EditarCampoTextBox(TxtImpostoFaixaAcumulado)


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


        '''TxtImpostoFaixa.Enabled = False

        '''TxtImpostoFaixaAcumulado.Enabled = True

        '''SendKeys.Send("{TAB}")

        '''EditarCampoTextBox(TxtImpostoFaixaAcumulado)

    End Sub

    Private Sub TxtImpostoFaixaAcumulado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpostoFaixaAcumulado.KeyPress

        Dim strMascarado As String = ""

        With TxtImpostoFaixaAcumulado

            If .Text = "" Then

                .Text = "0,00"

            End If


            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                TxtImpostoFaixaAcumulado.Enabled = False

                TxtImpostoFaixa.Enabled = True

                TxtImpostoFaixa.Focus()

                EditarCampoTextBox(TxtImpostoFaixa)

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


                TxtImpostoFaixaAcumulado.Enabled = False

                BtnIncrementa.Enabled = True

                BtnIncrementa.Focus()

                'EditarCampoTextBox(TxtImpostoFaixaAcumulado)


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

    Private Sub BtnIncrementa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnIncrementa.KeyPress

        If e.KeyChar = Convert.ToChar(27) Then

            BtnIncrementa.Enabled = False

            TxtImpostoFaixaAcumulado.Enabled = True

            TxtImpostoFaixaAcumulado.Focus()

            EditarCampoTextBox(TxtImpostoFaixaAcumulado)

        End If

    End Sub



    Private Sub BtnGravaTabela_Click(sender As Object, e As EventArgs) Handles BtnGravaTabela.Click

        ' Rotina preparada para até 4 faixas

        TabeleINSSchecagem()

        Dim IsNumeroDeFaixas As Integer = ListView1.Items.Count()

        If IsNumeroDeFaixas > 4 Then
            With oi

                .Msg = "Número de faixas maior do que 4 " & Chr(13) & "Sistema não está preparado, entre em contato com o administrador"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub

            End With

        End If

        Dim Query As String

        Query = "Insert into inss "
        Query += "("
        If IsNumeroDeFaixas >= 1 Then
            Query += "INSSfaixa1"
            Query += ",INSSfaixa1Porcentagem"
            Query += ",INSSfaixa1Valor"
            Query += ",INSSfaixa1Acumulado"
        End If

        If IsNumeroDeFaixas >= 2 Then
            Query += ",INSSfaixa2"
            Query += ",INSSfaixa2Porcentagem"
            Query += ",INSSfaixa2Valor"
            Query += ",INSSfaixa2Acumulado"
        End If
        If IsNumeroDeFaixas >= 3 Then
            Query += ",INSSfaixa3"
            Query += ",INSSfaixa3Porcentagem"
            Query += ",INSSfaixa3Valor"
            Query += ",INSSfaixa3Acumulado"
        End If
        If IsNumeroDeFaixas >= 4 Then
            Query += ",INSSfaixa4"
            Query += ",INSSfaixa4Porcentagem"
            Query += ",INSSfaixa4Valor"
            Query += ",INSSfaixa4Acumulado"
        End If

        Query += ",INSS_dataInicio"
        Query += ",INSS_dataFim"
        Query += ",INSSnumeroDeFaixas"
        Query += ",INSS_ativa"
        Query += ",INSSref"
        Query += ",INSSresponsavelDigitacao"
        Query += ",INSSresponsavelDigitacaoTipo"

        Query += ")"
        Query += " values "
        Query += "("
        Dim StrVirgula As String = ""
        For Each item As ListViewItem In ListView1.Items

            'Query += StrVirgula & item.Text                                               ' faixa
            Query += StrVirgula & Replace(Replace(item.SubItems(1).Text, ".", ""), ",", ".")        ' valor da faixa
            Query += "," & Replace(Replace(item.SubItems(2).Text, ".", ""), ",", ".")               ' % da faixa
            Query += "," & Replace(Replace(item.SubItems(3).Text, ".", ""), ",", ".")               ' imposto da faixa
            Query += "," & Replace(Replace(item.SubItems(4).Text, ".", ""), ",", ".")               ' imposto acumulado da faixa
            StrVirgula = ","

        Next


        Query += ",'" & DateTimePicker1.Value.ToString("yyyyMMdd") & "'"
        Query += ",''"
        Query += "," & IsNumeroDeFaixas
        Query += ",false"
        Query += ",'" & DateTimePicker1.Value.ToString("yyyyMM") & "'"
        Query += "," & usuClass.Usuario_Chave
        Query += ",'" & usuClass.Usuario_Tipo & "'"
        Query += ")"

        If gravaSQL(Query) Then
            With oi
                .Msg = "Gravação realizada com sucesso!"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With
            Me.Close()

        Else
            With oi
                .Msg = "Gravação não realizada !" & Chr(13) & "Reveja os valores da tabela e tente de novo"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With

        End If

    End Sub

    Private Function TabeleINSSchecagem() As Boolean

        Dim BooRetorno As Boolean = True

        For Each item As ListViewItem In ListView1.Items

        Next

        Return (BooRetorno)

    End Function
    ' Manipulador do evento ColumnClick
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick

        ' Verificar se a coluna já está classificada
        If ListView1.Sorting = SortOrder.Ascending OrElse ListView1.Sorting = SortOrder.None Then
            ' Definir a ordem de classificação para Descending
            ListView1.Sorting = SortOrder.Descending
        Else
            ' Definir a ordem de classificação para Ascending
            ListView1.Sorting = SortOrder.Ascending
        End If

        ' Definir a coluna pela qual a ordenação será realizada
        ListView1.ListViewItemSorter = New ListViewComparer(e.Column)

        ' Executar a ordenação
        ListView1.Sort()

    End Sub

    ' Classe para comparar os itens do ListView
    Private Class ListViewComparer
        Implements IComparer

        Private columnIndex As Integer

        Public Sub New(index As Integer)
            columnIndex = index
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
            Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

            ' Comparar os valores da coluna especificada
            Return Decimal.Compare(itemX.SubItems(columnIndex).Text, itemY.SubItems(columnIndex).Text)
        End Function
    End Class

    Private Sub FrmFolhaINSS_TabelaCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.Title = Me.Text
        Dim Query As String = "Select count(*) from inss where INSStabelaStatus = 0"
        If gravaSQLretorno(Query) > 0 Then

            With oi
                .Msg = "Existe Tabela já digitada aguardando Conferência" & Chr(13) & Chr(13)
                .Msg += "Caso tenha que digitar nova tabela solicite o cancelamento da tabela que está aguardando conferência"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Me.Close()
            End With
        End If
    End Sub
End Class