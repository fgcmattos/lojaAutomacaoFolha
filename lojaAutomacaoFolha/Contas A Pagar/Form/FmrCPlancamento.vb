Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports CrystalDecisions.Windows.Forms

Public Class FmrCPlancamento
    Dim oi As New MsgShow
    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intIsApuracao As Integer = CheckLancamento()

        If intIsApuracao = 100 Then Exit Sub ' Já criticado na função

        If intIsApuracao > 0 And intIsApuracao < 10 Then

            With oi

                .Msg = "(" & intIsApuracao & ")" & "Campos em Vermelho preenchido de forma incorreta!" + Chr(13) + Chr(13)
                .Msg += "Por gentileza certifique os valores digitados "
                .Style = vbCritical
                .Title = Me.Text
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If

        Dim StrData1 As String = DataLatina(DataAAAAMMDD(DateTimePicker1.Value.ToString.Substring(0, 10)))
        Dim StrData2 As String = DataLatina(DataAAAAMMDD(DateTimePicker2.Value.ToString.Substring(0, 10)))


        If LblAlteracao.Text = "C A D A S T R A M E N T O" Then

            Dim intIndex As Integer = ListView1.Items.Count
            With ListView1

                .Items.Add(intIndex + 1)
                .Items(intIndex).SubItems.Add(StrData1)
                .Items(intIndex).SubItems.Add(StrData2)

                .Items(intIndex).SubItems.Add(Cmbcredor.Text)
                .Items(intIndex).SubItems.Add(MskIndentifica.Text)
                .Items(intIndex).SubItems.Add(TxtNome.Text)
                .Items(intIndex).SubItems.Add(MskTelefone.Text)
                .Items(intIndex).SubItems.Add(CmbFerramenta.Text)
                .Items(intIndex).SubItems.Add(MskDocNumero.Text)
                .Items(intIndex).SubItems.Add(TxtValor.Text)
                .Items(intIndex).SubItems.Add(TxtHistorico.Text)


            End With

        Else

            Dim intIndeceAlatreacao As Integer = Convert.ToInt32(LblItem.Text) - 1

            With ListView1

                .Items(intIndeceAlatreacao).SubItems(1).Text = DataLatina(DataAAAAMMDD(DateTimePicker1.Value.ToString.Substring(0, 10)))
                .Items(intIndeceAlatreacao).SubItems(2).Text = DataLatina(DataAAAAMMDD(DateTimePicker2.Value.ToString.Substring(0, 10)))
                .Items(intIndeceAlatreacao).SubItems(3).Text = Cmbcredor.Text
                .Items(intIndeceAlatreacao).SubItems(4).Text = MskIndentifica.Text
                .Items(intIndeceAlatreacao).SubItems(5).Text = TxtNome.Text
                .Items(intIndeceAlatreacao).SubItems(6).Text = MskTelefone.Text
                .Items(intIndeceAlatreacao).SubItems(7).Text = CmbFerramenta.Text
                .Items(intIndeceAlatreacao).SubItems(8).Text = MskDocNumero.Text
                .Items(intIndeceAlatreacao).SubItems(9).Text = TxtValor.Text
                .Items(intIndeceAlatreacao).SubItems(10).Text = TxtHistorico.Text

            End With

            LblAlteracao.Text = "C A D A S T R A M E N T O"

            GroupBox3.Enabled = True


        End If

        LabelTotalLancado.Text = SomaValores(ListView1, 9)

        LimpaCPtransDireta()

        BtnDeleta.Visible = False

        Cmbcredor.Focus()

    End Sub

    Private Sub LimpaCPtransDireta()

        Dim Agenda As List(Of Aponta) = ApontaAcoes.GetApontaDB()

        DateTimePicker1.Value = Date.ParseExact(Agenda(0).Data, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
        DateTimePicker2.Value = Date.ParseExact(Agenda(0).Data, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)

        Cmbcredor.SelectedIndex = 0
        MskIndentifica.Text = ""
        TxtNome.Text = ""
        MskTelefone.Text = ""
        CmbFerramenta.SelectedIndex = 0
        MskDocNumero.Text = ""
        TxtValor.Text = "0,00"
        TxtHistorico.Text = ""

    End Sub

    Private Function SomaValores(objTabela As Object, intColuna As Integer) As String
        Dim total As Decimal = 0

        For Each item As ListViewItem In objTabela.Items

            total += Decimal.Parse((item.SubItems(intColuna).Text))

        Next
        'Dim cultureInfo As New System.Globalization.CultureInfo("en-US") ' Defina a cultura correta
        'cultureInfo.NumberFormat.NumberDecimalSeparator = ","
        'cultureInfo.NumberFormat.NumberGroupSeparator = "."

        'Return total.ToString("N2", cultureInfo)

        'Return total.ToString("N2", formatInfo) ' Retorna o total formatado como string

        Return NumeroLatino(total, 10, True)

    End Function

    Private Sub Cmbcredor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcredor.SelectedIndexChanged
        Select Case Cmbcredor.Text

            Case "Pessoa Juridica PJ"
                GroupBox1.Text = "Fornecedor"
                LblCPF_CNPJ.Text = "C.N.P.J"
                MskIndentifica.Mask = "##.###.###/####-##"

            Case "Pessoa Fisica    PF"
                GroupBox1.Text = "Pessoa Fisica"
                LblCPF_CNPJ.Text = "C.P.F"
                MskIndentifica.Mask = "###.###.###-##"

        End Select
    End Sub

    Private Function CheckLancamento() As Integer

        ' A função checa a tela e devolve o número de inconsistências apuradas

        Dim strISid As String = MskIndentifica.Text
        Dim intVerifica As Integer = 0

        If LblCPF_CNPJ.Text = "C.N.P.J" Then strISid = CNPJretiraMascara(strISid)
        If LblCPF_CNPJ.Text = "C.P.F" Then strISid = CPFretiraMascara(strISid) : intVerifica = 1

        If intVerifica = 0 Then
            If strISid.Length < 14 Then
                With oi
                    .Msg = "C.N.P.J inválido !"
                    .Style = vbCritical
                    MsgBox(.Msg, MsgBoxStyle.RetryCancel, .Title)

                End With

                MskIndentifica.Focus()

                Return (100)

                Exit Function

            End If

        Else

            If strISid.Length < 11 Then
                With oi
                    .Msg = "C.P.F inválido !"
                    .Style = vbCritical
                    MsgBox(.Msg, MsgBoxStyle.RetryCancel, .Title)

                End With

                MskIndentifica.Focus()

                Return (100)

                Exit Function

            End If

        End If

        Dim InIS As Integer = 0

        Dim IsId As String = MskIndentifica.Text.Replace(".", "").Replace("/", "").Replace(",", "").Replace("-", "").Trim
        Dim IsTel As String = MskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim

        If Cmbcredor.Text = "" Then LabelTipo.ForeColor = Color.Red : InIS += 1 Else LabelTipo.ForeColor = Color.Black
        If IsId = "" Then LblCPF_CNPJ.ForeColor = Color.Red : InIS += 1 Else LblCPF_CNPJ.ForeColor = Color.Black
        If TxtNome.Text = "" Then LblIdentificacao.ForeColor = Color.Red : InIS += 1 Else LblIdentificacao.ForeColor = Color.Black
        If IsTel = "" Then LblTelefone.ForeColor = Color.Red : InIS += 1 Else LblTelefone.ForeColor = Color.Black
        If CmbFerramenta.Text = "" Then LabelCobranca.ForeColor = Color.Red : InIS += 1 Else LabelCobranca.ForeColor = Color.Black
        If MskDocNumero.Text = "" Then LabelDocNumero.ForeColor = Color.Red : InIS += 1 Else LabelDocNumero.ForeColor = Color.Black
        If TxtValor.Text = "0,00" Then LabelValor.ForeColor = Color.Red : InIS += 1 Else LabelValor.ForeColor = Color.Black

        Dim StrData1 As String = DataAAAAMMDD(DateTimePicker1.Value.ToString.Substring(0, 10))
        Dim StrData2 As String = DataAAAAMMDD(DateTimePicker2.Value.ToString.Substring(0, 10))

        If StrData1 > StrData1 Then LabelDataOcorrencia.ForeColor = Color.Red : LabelDataVencimento.ForeColor = Color.Red : InIS += 1 _
            Else LabelDataOcorrencia.ForeColor = Color.Black : LabelDataVencimento.ForeColor = Color.Black

        If intVerifica = 0 Then
            If Not CNPJtesteAcao.CNPJchek(MskIndentifica.Text) Then
                LblCPF_CNPJ.ForeColor = Color.Red : InIS += 1
            Else
                LblCPF_CNPJ.ForeColor = Color.Black
            End If
        Else
            If Not CPFdigito(strISid) = strISid.Substring(9, 2) Then
                LblCPF_CNPJ.ForeColor = Color.Red : InIS += 1
            Else
                LblCPF_CNPJ.ForeColor = Color.Black
            End If

        End If

        If TxtHistorico.Text.Trim.Length = 0 Then LabelHistorco.ForeColor = Color.Red : InIS += 1 Else LabelHistorco.ForeColor = Color.Black

        Return (InIS)

    End Function

    Private Sub TxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValor.KeyPress

        With TxtValor

            Dim strMascarado As String = ""


            If .Text = "" Then

                .Text = "0,00"

                Exit Sub

            End If

            If .MaxLength < .Text.Length And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then

                e.KeyChar = ""

                Exit Sub

            End If

            'If e.KeyChar = Convert.ToChar(27) Then

            '    TxtValorBase.Text = "0,00"


            'End If

            'If e.KeyChar = Convert.ToChar(13) Then


            '    If .Text <= 0.00 Then

            '        MsgBox("A Base deve ter um valor maior que 0.00", vbExclamation, Me.Text)
            '        Exit Sub


            'End If




            'SendKeys.Send("{TAB}")


            'Exit Sub

            'End If

            If Asc(e.KeyChar) = 8 Then       ' BACKSPACE

                e.KeyChar = ""


                If .Text = "0,00" Then Exit Sub
                If .Text.Substring(0, 3) = "0,0" And .Text.Length = 4 Then .Text = "0,00" : SendKeys.Send("{END}") : Exit Sub
                If .Text.Substring(0, 2) = "0," And .Text.Length = 4 Then .Text = "0,0" + .Text.Substring(.Text.Length - 2, 1) : SendKeys.Send("{END}") : Exit Sub
                If .Text.Length = 4 Then .Text = "0," + .Text.Substring(0, 1) + .Text.Substring(2, 1) : SendKeys.Send("{END}") : Exit Sub

                .Text = .Text.Substring(0, .Text.Length - 1)
                Dim strSemMascara As String = Trim(Replace(Replace(.Text, ",", ""), ".", ""))
                Dim intSemMascara As Integer = strSemMascara.Length


                .Text = RetMascara(intSemMascara, strSemMascara)
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

                .Text = RetMascara(intSemMascara, strSemMascara)



                SendKeys.Send("{END}")

            Else

                e.KeyChar = ""

                .Focus()


                ' SendKeys.Send("{END}")


            End If

        End With
    End Sub

    Private Sub FmrCPlancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Agenda As List(Of Aponta) = ApontaAcoes.GetApontaDB()

        DateTimePicker1.Value = Date.ParseExact(Agenda(0).Data, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
        DateTimePicker2.Value = Date.ParseExact(Agenda(0).Data, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        Dim itemText As String

        If ListView1.SelectedItems.Count > 0 Then

            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            itemText = selectedItem.Text

            ' Faça algo com o texto do item selecionado
            'MessageBox.Show("Item selecionado: " & itemText)

            DateTimePicker1.Value = Date.ParseExact(selectedItem.SubItems(1).Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            DateTimePicker2.Value = Date.ParseExact(selectedItem.SubItems(2).Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)

            Cmbcredor.Text = selectedItem.SubItems(3).Text
            MskIndentifica.Text = selectedItem.SubItems(4).Text
            TxtNome.Text = selectedItem.SubItems(5).Text
            MskTelefone.Text = selectedItem.SubItems(6).Text
            CmbFerramenta.Text = selectedItem.SubItems(7).Text
            MskDocNumero.Text = selectedItem.SubItems(8).Text
            TxtValor.Text = selectedItem.SubItems(9).Text
            TxtHistorico.Text = selectedItem.SubItems(10).Text

            GroupBox3.Enabled = False

            LblAlteracao.Text = "A L T E R A Ç Ã O"
            LblItem.Text = selectedItem.SubItems(0).Text
            BtnDeleta.Visible = True
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BtnDeleta_Click(sender As Object, e As EventArgs) Handles BtnDeleta.Click

        If ListView1.SelectedItems.Count > 0 Then

            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ListView1.Items.Remove(selectedItem)

            Dim intContador As Integer = 0
            'Or Each item As ListViewItem In objTabela.Items
            For Each item As ListViewItem In ListView1.Items

                intContador += 1

                item.Text = intContador

            Next

            LabelTotalLancado.Text = SomaValores(ListView1, 9)

            LimpaCPtransDireta()

            BtnDeleta.Visible = False

            GroupBox3.Enabled = True

            LblAlteracao.Text = "C A D A S T R A M E N T O"

            Cmbcredor.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        With oi

            .Msg = "Confirma a Gravação ?" & Chr(13) & Chr(13)
            .Style = vbYesNo
            If MsgBox(.Msg, .Style, .Title) <> 6 Then Exit Sub

        End With
        Dim IntNUmeroRegistros As Integer = ListView1.Items.Count()

        Dim Query As String

        Query = "Insert into "
        Query += " CP "
        Query += "("
        Query += "CP_ordem "
        Query += ",CP_SIS_Lac"
        Query += ",CP_DTA_Fato"
        Query += ",CP_DTA_Venc"
        Query += ",CP_DTA_PG"
        Query += ",CP_Valor_Cobrado"
        Query += ",CP_Valor_Final"
        Query += ",CP_Valor_Desconto"
        Query += ",CP_Valor_Juros"
        Query += ",CP_Valor_Multa"
        Query += ",CP_Credor_Tipo"
        Query += ",CP_Credor_ID"
        Query += ",CP_Credor_Nome"
        Query += ",CP_Tipo_Cobranca"
        Query += ",CP_Doc_Numero"
        Query += ",CP_Historico"
        Query += ")"
        Query += " values "

        For Each item As ListViewItem In ListView1.Items

            Query += "("
            Query += "1"
            Query += "TD"
            Query += "," & "'" & DataAAAAMMDD(item.SubItems(1).Text) & "'"              ' Data do Fato
            Query += "," & "'" & DataAAAAMMDD(item.SubItems(2).Text) & "'"              ' Previsão de Pagamento
            Query += ", null"
            Query += "," & MoneyUSA(item.SubItems(9).Text) & "'"                        ' Valor acordado
            Query += ",0.00"
            Query += ",0.00"
            Query += ",0.00"
            Query += ",0.00"
            Query += "," & "'" & item.SubItems(3).Text & "'"                            ' Tipo de Credor
            Query += "," & "'" & item.SubItems(4).Text & "'"                            ' Indetificação do credor
            Query += "," & "'" & item.SubItems(5).Text & "'"                            ' Nome/Razao Social do Credor
            Query += "," & "'" & item.SubItems(7).Text & "'"                            ' Tipo de Cobrança
            Query += "," & "'" & item.SubItems(8).Text & "'"                            ' Número do documento de cobrança
            Query += "," & "'" & item.SubItems(10).Text & "'"                           ' Histórico
            Query += "),"

        Next

        Query = Query.Substring(0, Query.Length - 1)

        If GravaSQL(Query) Then
            With oi
                .Msg = "Gravação realizada com sucesso"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With

        Else
            With oi
                .Msg = "Gravação não Realizada"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)
            End With

        End If


    End Sub
End Class