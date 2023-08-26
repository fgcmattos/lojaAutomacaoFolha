Imports MySql.Data.MySqlClient
Public Class frmFolha_salariosCadastro
    Dim oi As New MsgShow
    Private Sub frmFolha_salariosCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = Me.Text

        carregaLv()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = ListView1.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        GruEntradaSalarios.Enabled = True

        LblTitulo.Text = "Setor :  " & ListView1.Items(Indice).SubItems(0).Text
        LblTitulo.Text += "  "
        LblTitulo.Text += ListView1.Items(Indice).SubItems(1).Text
        LblTitulo.Text += "  "
        LblTitulo.Text += "Cargo :  " & ListView1.Items(Indice).SubItems(2).Text
        LblTitulo.Text += "  "
        LblTitulo.Text += ListView1.Items(Indice).SubItems(3).Text

        TxtSB.Text = ListView1.Items(Indice).SubItems(4).Text
        TxtSMedio.Text = ListView1.Items(Indice).SubItems(5).Text
        TxtSmaximo.Text = ListView1.Items(Indice).SubItems(6).Text
        TxtSutilizado.Text = ListView1.Items(Indice).SubItems(7).Text
        MskDataInicio.Text = ListView1.Items(Indice).SubItems(8).Text

        GruShow.Enabled = False

    End Sub
    Private Sub CarregaLv()

        Dim query As String

        query = "select "
        query += " folha_cargo_setor"
        query += " ,(select folha_setor_descricao from folha_setor where folha_setor_codigo =folha_cargo.folha_cargo_setor)"
        query += " ,folha_cargo_Codigo"
        query += " ,folha_cargo_descricao"
        query += " from "
        query += "	folha_cargo "
        query += "    where "
        query += "    isnull(folha_cargo_SB_reg) "
        query += " order by "
        query += "folha_cargo_setor"
        query += ",folha_cargo_codigo"

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                ListView1.Items.Clear()

                While DTReader.Read()
                    With ListView1
                        .Items.Add(DTReader.GetValue(0))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(3))
                        .Items(.Items.Count - 1).SubItems.Add("0,00")
                        .Items(.Items.Count - 1).SubItems.Add("0,00")
                        .Items(.Items.Count - 1).SubItems.Add("0,00")
                        .Items(.Items.Count - 1).SubItems.Add("0,00")
                        .Items(.Items.Count - 1).SubItems.Add("DD/MM/AAAA")


                    End With

                End While


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()

        End If
    End Sub

    Private Sub BtnDiponibiliza_Click(sender As Object, e As EventArgs) Handles BtnDiponibiliza.Click
        Try
            Dim dtTeste As Date = MskDataInicio.Text
            dtTeste = DateAdd("d", 1, dtTeste)
        Catch ex As Exception
            With oi
                .msg = "Data inválida!"
                .msg += Chr(13)
                .msg += Chr(13)
                .msg = "Por favor, entre com data válida"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
                Exit Sub
            End With

        End Try


        Dim Indice As Integer
        Dim lv As ListView.SelectedIndexCollection
        lv = ListView1.SelectedIndices

        Indice = lv.Item(0) ' indice selecionado no listview

        ListView1.Items(Indice).SubItems(4).Text = TxtSB.Text
        ListView1.Items(Indice).SubItems(5).Text = TxtSMedio.Text
        ListView1.Items(Indice).SubItems(6).Text = TxtSmaximo.Text
        ListView1.Items(Indice).SubItems(7).Text = TxtSutilizado.Text
        ListView1.Items(Indice).SubItems(8).Text = MskDataInicio.Text

        limpaTela()


    End Sub

    Private Sub LimpaTela()

        GruEntradaSalarios.Enabled = False

        TxtSB.Text = ""
        TxtSMedio.Text = ""
        TxtSmaximo.Text = ""
        TxtSutilizado.Text = ""
        LblTitulo.Text = ""
        MskDataInicio.Text = "__/__/____"
        GruShow.Enabled = True
        GruEntradaSalarios.Enabled = False

    End Sub
    Private Sub TxtSB_TextChanged(sender As Object, e As EventArgs) Handles TxtSB.TextChanged

    End Sub

    Private Sub TxtSB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSB.KeyPress
        With TxtSB

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

    Private Sub TxtSB_GotFocus(sender As Object, e As EventArgs) Handles TxtSB.GotFocus
        My.Computer.Keyboard.SendKeys("", True)
    End Sub

    Private Sub TxtSMedio_TextChanged(sender As Object, e As EventArgs) Handles TxtSMedio.TextChanged

    End Sub

    Private Sub TxtSMedio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSMedio.KeyPress
        With TxtSMedio

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

                SendKeys.Send("{TAB}")

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


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With
    End Sub

    Private Sub TxtSmaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSmaximo.KeyPress
        With TxtSmaximo

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

                SendKeys.Send("{TAB}")

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


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With
    End Sub

    Private Sub TxtSutilizado_TextChanged(sender As Object, e As EventArgs) Handles TxtSutilizado.TextChanged

    End Sub

    Private Sub TxtSutilizado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSutilizado.KeyPress
        With TxtSutilizado

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


                'My.Computer.Keyboard.SendKeys("", True)


            End If
        End With
    End Sub

    Private Sub TxtSMedio_GotFocus(sender As Object, e As EventArgs) Handles TxtSMedio.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub TxtSmaximo_GotFocus(sender As Object, e As EventArgs) Handles TxtSmaximo.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub TxtSutilizado_GotFocus(sender As Object, e As EventArgs) Handles TxtSutilizado.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub TxtSB_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles TxtSB.HelpRequested

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LimpaTela()

    End Sub

    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click

        Me.Close()

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

        Dim intConta As Integer = 0

        For i = 0 To ListView1.Items.Count - 1

            If ListView1.Items(i).SubItems(7).Text <> "0,00" Then

                intConta += 1

            End If

        Next

        If intConta = 0 Then
            With oi
                .msg = "Não existem Registros a Serem Gravados: "
                .style = vbCritical
                MsgBox(.msg, .style, .title)
            End With
            Exit Sub
        End If

        With oi
            .msg = "Registros a Serem Gravados: " & intConta
            .msg += Chr(13)
            .msg += Chr(13)
            .msg += "Confirma a gravação ?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta = 6 Then
                Dim query As String = ""
                For i = 0 To ListView1.Items.Count - 1

                    If ListView1.Items(i).SubItems(7).Text <> "0,00" Then
                        query += "insert into folha_salario_base "
                        query += "("
                        query += "folha_salario_base_Setor"
                        query += ",folha_salario_base_Cargo"
                        query += ",folha_salario_base_minimo"
                        query += ",folha_salario_base_Maximo"
                        query += ",folha_salario_base_media"
                        query += ",folha_salario_utilizado"
                        query += ",folha_salario_base_referencia"
                        query += ",folha_salario_base_inicio"
                        query += ")"
                        query += " values "
                        query += "("
                        query += ListView1.Items(i).SubItems(0).Text
                        query += "," & ListView1.Items(i).SubItems(2).Text
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(4).Text)
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(5).Text)
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(6).Text)
                        query += "," & MoneyUSA(ListView1.Items(i).SubItems(7).Text)
                        query += ",'" & dataAAAAMMDD(ListView1.Items(i).SubItems(8).Text).Substring(0, 6) & "'"
                        query += ",'" & dataAAAAMMDD(ListView1.Items(i).SubItems(8).Text) & "'"

                        query += ");"
                        query += "Update folha_cargo set "
                        query += "folha_cargo_SB_reg = "
                        query += "(Select max(idfolha_salario_base) from folha_salario_base "
                        query += " where "
                        query += "folha_cargo_Codigo = " & ListView1.Items(i).SubItems(2).Text
                        query += " and "
                        query += "folha_cargo_setor = " & ListView1.Items(i).SubItems(0).Text & ")"
                        query += " where "
                        query += "folha_cargo_Codigo = " & ListView1.Items(i).SubItems(2).Text
                        query += " and "
                        query += "folha_cargo_setor =" & ListView1.Items(i).SubItems(0).Text & ";"

                    End If
                Next
                gravaSQL(query)
                carregaLv()
                With oi

                    .msg = "Gravação Realizada com sucesso!"
                    .style = vbExclamation
                    MsgBox(.msg, .style, .title)

                End With
            End If


        End With
    End Sub

    Private Sub TxtSutilizado_MarginChanged(sender As Object, e As EventArgs) Handles TxtSutilizado.MarginChanged

    End Sub

    Private Sub MskDataInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskDataInicio.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub MskDataInicio_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskDataInicio.MaskInputRejected

    End Sub
End Class