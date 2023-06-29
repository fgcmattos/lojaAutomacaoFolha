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

    End Sub
End Class