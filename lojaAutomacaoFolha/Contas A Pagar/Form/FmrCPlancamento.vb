'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports CrystalDecisions.Windows.Forms
Imports System.Windows.Forms

Public Class FmrCPlancamento

    'Inherits Form

    'Public Sub New()
    '    ' Inicialize o formulário
    '    InitializeComponent()

    '    ' Chame o método para criar o TextBox em tempo de execução
    '    CriarTextBox()
    'End Sub

    'Private Sub CriarTextBox()
    '    ' Crie uma instância de TextBox
    '    Dim txtBox As New TextBox()

    '    ' Configure as propriedades do TextBox
    '    txtBox.Name = "editTxt"
    '    txtBox.Text = "dsafdffdfasdfdsafds"
    '    txtBox.Location = New Point(691, 309) ' Defina a posição do TextBox no formulário
    '    txtBox.Size = New Size(150, 20) ' Defina o tamanho do TextBox
    '    txtBox.BringToFront()
    '    txtBox.Visible = True
    '    ' Adicione o TextBox ao formulário
    '    Me.Controls.Add(txtBox)
    '    Me.Refresh()
    'End Sub
    Dim coor As New Class_Listview_Lista

    Dim editingTextBox As TextBox ' Para manter controle do controle de edição
    Dim oi As New MsgShow
    Private Query As String

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

                Dim strCodigoCC As String = CmbCentroDeCusto.Text.Substring(0, 3)
                Dim strNomeCC As String = CmbCentroDeCusto.Text.Substring(6)


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

                .Items(intIndex).SubItems.Add(strCodigoCC)
                .Items(intIndex).SubItems.Add(strNomeCC)


            End With

        Else

            Dim intIndeceAlatreacao As Integer = Convert.ToInt32(LblItem.Text) - 1

            With ListView1

                Dim strCodigoCC As String = CmbCentroDeCusto.Text.Substring(0, 3)
                Dim strNomeCC As String = CmbCentroDeCusto.Text.Substring(6)

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
                .Items(intIndeceAlatreacao).SubItems(11).Text = strCodigoCC
                .Items(intIndeceAlatreacao).SubItems(12).Text = strNomeCC


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

        CmbCentroDeCusto.SelectedIndex = 0
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

        If CmbCentroDeCusto.Text.Replace("-", "").Trim = "" Then

            With oi
                .Msg = "Centro de custo não selecionado !" & Chr(13) & Chr(13)
                .Msg += "Por favor selecione um centro de custo apropriado para o seu lançamento"
                .Style = vbCritical
                MsgBox(.Msg, MsgBoxStyle.RetryCancel, .Title)

            End With

            CmbCentroDeCusto.Focus()

            Return (100)

        End If

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
        ComboCarregar(CmbCentroDeCusto, "centro_custo", "concat(cc_codigo,' - ' , cc_descricao)", "Order by cc_descricao")


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

            CmbCentroDeCusto.Text = selectedItem.SubItems(11).Text & " - " & selectedItem.SubItems(12).Text

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

        Query = "SELECT IFNULL(MAX(CP_ordem), 0) FROM CP;"
        Dim IntSequencial As Integer = gravaSQLretorno(Query)

        Query = "SELECT IFNULL(MAX(CP_Lote_Lancamento), 0) FROM CP;"
        Dim IntLote As Integer = gravaSQLretorno(Query) + 1

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
        Query += ",CP_Credor_Fone"
        Query += ",CP_Lote_Lancamento"
        Query += ",CP_Centro_Custo_codigo"
        Query += ",CP_Centro_Custo_nome"

        Query += ",CP_usuario_lancamento_codigo"
        Query += ",CP_usuario_lancamento_Tipo"
        Query += ",CP_usuario_lancamento_nome"
        Query += ",CP_usuario_lancamento_data"
        Query += ")"
        Query += " values "

        Dim IncIncremento As Integer = 0

        For Each item As ListViewItem In ListView1.Items

            Dim IntCheckCredor As Integer = IIf(item.SubItems(3).Text = "Pessoa Juridica PJ", 0, 1)

            IncIncremento += 1

            Query += "("
            Query += "(" & IntSequencial + IncIncremento & ")"
            Query += ",'TD'"
            Query += "," & "'" & DataAAAAMMDD(item.SubItems(1).Text) & "'"                                                                              ' Data do Fato
            Query += "," & "'" & DataAAAAMMDD(item.SubItems(2).Text) & "'"                                                                              ' Previsão de Pagamento
            Query += ", null"
            Query += "," & MoneyUSA(item.SubItems(9).Text)                                                                                              ' Valor acordado
            Query += ",0.00"
            Query += ",0.00"
            Query += ",0.00"
            Query += ",0.00"
            Query += "," & IntCheckCredor                                                                                                               ' Tipo de Credor
            Query += "," & "'" & IIf(IntCheckCredor = 0, CNPJretiraMascara(item.SubItems(4).Text), CPFretiraMascara(item.SubItems(4).Text)) & "'"       ' Indetificação do credor
            Query += "," & "'" & item.SubItems(5).Text & "'"                                                                                            ' Nome/Razao Social do Credor
            Query += "," & "'" & item.SubItems(7).Text & "'"                                                                                            ' Tipo de Cobrança
            Query += "," & "'" & item.SubItems(8).Text & "'"                                                                                            ' Número do documento de cobrança
            Query += "," & "'" & item.SubItems(10).Text & "'"                                                                                           ' Histórico
            Query += "," & "'" & item.SubItems(6).Text & "'"                                                                                            ' Credor Telefone
            Query += "," & IntLote
            Query += "," & "'" & item.SubItems(11).Text & "'"
            Query += "," & "'" & item.SubItems(12).Text & "'"

            Query += "," & usuClass.Usuario_Chave

            Query += "," & "'" & usuClass.Usuario_Tipo & "'"

            Query += "," & "'" & usuClass.Usuario_Nome & "'"

            Query += ", now()"

            Query += "),"

        Next

        Query = Query.Substring(0, Query.Length - 1) & ";"

        If GravaSQL(Query) Then
            With oi
                .Msg = "Gravação realizada com sucesso"
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With
            Me.Close()
        Else
            With oi
                .Msg = "Gravação não Realizada"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)
            End With

        End If


    End Sub

    Private Sub BtnCriaEdicaoParcela_Click(sender As Object, e As EventArgs) Handles BtnCriaEdicaoParcela.Click

        Dim inParcelas As Integer = Convert.ToInt32(MskNparcelas.Text)

        Dim dtAgora As String = gravaSQLretorno("SELECT DATE_FORMAT(now(), '%d/%m/%Y')")

        ListView2.Items.Clear()

        For i As Integer = 0 To inParcelas

            With ListView2
                If i < inParcelas Then

                    .Items.Add(i + 1)
                    .Items(i).SubItems.Add("")
                    .Items(i).SubItems.Add(dtAgora)
                    .Items(i).SubItems.Add("0,00")
                    .Items(i).SubItems.Add("")
                Else

                    .Items.Add("T O T A L")
                    .Items(i).SubItems.Add("")
                    .Items(i).SubItems.Add("")
                    .Items(i).SubItems.Add("0,00")

                End If

            End With
        Next

    End Sub




    Private Sub ListView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseDoubleClick

        '' Captura o item e a subitem (célula) clicados
        'Dim item As ListViewItem = ListView2.GetItemAt(e.X, e.Y)
        'Dim subItem As ListViewItem.ListViewSubItem = item.GetSubItemAt(e.X, e.Y)

        'If subItem IsNot Nothing Then
        '    ' Inicia a edição
        '    StartEditing(subItem, item)
        'End If

        ' Obtenha o item clicado
        'Dim item As ListViewItem = ListView2.GetItemAt(e.X, e.Y)

        'If item IsNot Nothing Then
        '    ' Determine qual subitem foi clicado
        '    Dim subItemIndex As Integer = -1
        '    Dim x As Integer = e.X
        '    For i As Integer = 0 To item.SubItems.Count - 1
        '        If x < item.SubItems(i).Bounds.Left Then
        '            ' A coordenada x está antes do início deste subitem, então paramos aqui
        '            Exit For
        '        End If
        '        If x >= item.SubItems(i).Bounds.Left And x <= item.SubItems(i).Bounds.Right Then
        '            ' A coordenada x está dentro deste subitem
        '            subItemIndex = i
        '            Exit For
        '        End If
        '    Next

        '    If subItemIndex >= 0 Then
        '        ' Inicie a edição
        '        StartEditing(item.SubItems(subItemIndex), item)
        '    End If
        'End If
        Dim columnIndex As Integer = 1 ' Coluna que você deseja permitir a edição

        ' Verifique se o clique ocorreu em uma área de subitem da coluna desejada

        'Dim item As ListViewItem = ListView2.GetItemAt(e.X, e.Y)
        'If item IsNot Nothing AndAlso e.X > item.SubItems(columnIndex).Bounds.Left AndAlso e.X < item.SubItems(columnIndex).Bounds.Right Then
        '    ' Inicie a edição
        '    'StartEditing(item.SubItems(columnIndex))
        '    MsgBox(item.SubItems(columnIndex))
        'End If

    End Sub
    Private Sub StartEditing(subItem As ListViewItem.ListViewSubItem, item As ListViewItem)
        ' Crie um controle TextBox para edição
        editingTextBox = New TextBox()
        editingTextBox.Text = subItem.Text
        editingTextBox.Bounds = subItem.Bounds
        editingTextBox.Tag = subItem ' Guarde a referência ao subItem

        ' Adicione o controle TextBox ao controle ListView2
        ListView2.Controls.Add(editingTextBox)

        ' Lidar com o evento de perda de foco para encerrar a edição
        AddHandler editingTextBox.LostFocus, AddressOf EndEditing

        ' Lidar com a tecla Enter para encerrar a edição
        AddHandler editingTextBox.KeyDown, AddressOf TextBox_KeyDown

        ' Defina o foco no controle TextBox e selecione todo o texto
        editingTextBox.Focus()
        editingTextBox.SelectAll()
    End Sub

    Private Sub EndEditing(sender As Object, e As EventArgs)
        ' Quando a edição estiver concluída, atualize o valor do subItem
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim subItem As ListViewItem.ListViewSubItem = DirectCast(textBox.Tag, ListViewItem.ListViewSubItem)
        subItem.Text = textBox.Text

        ' Remova o controle TextBox
        ListView2.Controls.Remove(textBox)
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        ' Se a tecla Enter for pressionada, encerre a edição
        If e.KeyCode = Keys.Enter Then
            EndEditing(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub ListView2_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView2.MouseDown
        '   Leitura de uma celula do ListView
        '=====================================
        Dim columnIndex As Integer = -1
        Dim lineIndex As Integer = -1
        Dim chaveIndex As String
        '======================================
        ' Obter informações sobre a posição do clique
        Dim info As ListViewHitTestInfo = ListView2.HitTest(e.Location)
        Dim cellBounds As Rectangle = info.SubItem.Bounds


        ' Verificar se um item foi clicado
        If info.Item IsNot Nothing Then
            ' Verificar se um subitem foi clicado
            If info.SubItem IsNot Nothing Then
                ' Obter o índice da coluna clicada
                columnIndex = info.Item.SubItems.IndexOf(info.SubItem)
                lineIndex = info.Item.Index
                chaveIndex = info.SubItem.Text
                'EditTxt.Location = e.Location

                'MessageBox.Show("Célula clicada: " & info.SubItem.Text & " (Coluna: " & columnIndex & ", Linha: " & lineIndex & ")")

                'MessageBox.Show("Tipo de usuário: " & ListView1.Items(lineIndex).SubItems(9).Text)

                Select Case columnIndex

                    Case 0

                    Case 1
                        'TxtADM.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text

                    Case 2
                        With DateTimePickerEdicao
                            .Text = chaveIndex
                            .Width = ListView2.Columns(columnIndex).Width
                            .Location = New Point(cellBounds.Left + ListView2.Left, cellBounds.Top + ListView2.Top)
                            .Visible = True
                            .Focus()
                        End With
                        coor.Coluna = columnIndex
                        coor.Linha = lineIndex
                        ListView2.Enabled = False

                    Case 3

                        EditTxtValor.Text = chaveIndex
                        EditTxtValor.Width = ListView2.Columns(columnIndex).Width
                        'EditTxt.Location = e.Location
                        ' Calcula as coordenadas corretas para o TextBox
                        EditTxtValor.Location = New Point(cellBounds.Left + ListView2.Left, cellBounds.Top + ListView2.Top)
                        EditTxtValor.Visible = True

                        coor.Coluna = columnIndex
                        coor.Linha = lineIndex
                        EditTxtValor.Focus()
                        ListView2.Enabled = False

                    Case 4
                        'TxtOriginal.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text
                    Case 5
                        'TxtAlterado.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text
                    Case 6
                        'TxtSistema.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text
                    Case 8
                        'TxtUsuario.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text
                    Case 9
                        'MskUsuarioTipo.Text = ListView1.Items(lineIndex).SubItems(columnIndex).Text
                End Select

            End If

        Else
            columnIndex = -1
        End If






        'Dim columnIndex As Integer = 1 ' Coluna que você deseja permitir a edição

        '' Obtenha a linha clicada
        'Dim clickedItem As ListViewItem = ListView2.GetItemAt(e.X, e.Y)

        'If clickedItem IsNot Nothing AndAlso e.Button = MouseButtons.Left Then
        '    ' Calcule a coluna com base nas coordenadas do mouse
        '    Dim clickedSubItem As ListViewItem.ListViewSubItem = Nothing
        '    Dim x As Integer = e.X
        '    Dim colWidth As Integer = 0

        '    For Each subItem As ListViewItem.ListViewSubItem In clickedItem.SubItems
        '        colWidth += subItem.Bounds.Width

        '        If x < colWidth Then
        '            clickedSubItem = subItem
        '            Exit For
        '        End If
        '    Next

        '    If clickedSubItem IsNot Nothing Then
        '        ' Inicie a edição
        '        StartEditing(clickedSubItem)
        '    End If
        'End If
    End Sub


    Private Sub StartEditing(subItem As ListViewItem.ListViewSubItem)
        ' Implemente a lógica para criar um controle de edição (por exemplo, TextBox) e iniciar a edição aqui
        ' Certifique-se de lidar com eventos como LostFocus ou Enter para encerrar a edição e atualizar o subitem

        MsgBox(subItem.Text)
    End Sub

    Private Sub EditTxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EditTxtValor.KeyPress

        With EditTxtValor

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

            If e.KeyChar = Convert.ToChar(13) Then


                If .Text <= 0.00 Then

                    MsgBox("A Base deve ter um valor maior que 0.00", vbExclamation, Me.Text)
                    Exit Sub


                End If

                'MsgBox(ListView2.Items(coor.Linha).SubItems(coor.Coluna).Text)
                'ListView2.Items(coor.Linha).SubItems(coor.Coluna).Text = .Text

                AcertaListview(Me.ListView2, Me.EditTxtValor, coor.Linha, coor.Coluna, 3)     ' Grava edição e soma a coluna 3

                'SendKeys.Send("{TAB}")

                .Visible = False

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

    Private Sub EditTxtValor_TextChanged(sender As Object, e As EventArgs) Handles EditTxtValor.TextChanged

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class