Public Class FrmCPLibera_lancamento
    Dim oi As New MsgShow
    Private ignoreItemCheckedEvent = False

    Private Sub FrmCPLibera_lancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.Title = Me.Text
        ignoreItemCheckedEvent = True

        Dim cp As List(Of ClassCP) = ClassCP_Acao.GetCP_DB(" Where CP_Status = 0 ")

        If cp.Count = 0 Then

            With oi

                .Msg = "Não existe lançamentos para liberar"
                .Style = vbCritical

                MsgBox(.Msg, .Style, .Title)

            End With

            Me.Close()

            Exit Sub

        End If

        Dim strCredorTipo As String
        Dim strCredoIdentificacao As String

        For i = 0 To cp.Count - 1

            With ListView1

                strCredorTipo = cp(i).Class_CP_Credor_Tipo
                If strCredorTipo = 1 Then
                    strCredoIdentificacao = CPFcolocaMascara(cp(i).Class_CP_Credor_ID)
                Else
                    strCredoIdentificacao = CNPJcolocaMascara(cp(i).Class_CP_Credor_ID)
                End If

                .Items.Add(cp(i).Class_ID_CP)
                .Items(i).SubItems.Add(DataLatina(cp(i).Class_CP_DTA_Fato))
                .Items(i).SubItems.Add(DataLatina(cp(i).Class_CP_DTA_Venc))
                .Items(i).SubItems.Add(cp(i).Class_CP_Prazo)
                .Items(i).SubItems.Add(strCredoIdentificacao)
                .Items(i).SubItems.Add(cp(i).Class_CP_Credor_Nome)
                .Items(i).SubItems.Add(cp(i).Class_CP_Credor_Fone)
                .Items(i).SubItems.Add(cp(i).Class_CP_Tipo_Cobranca)
                .Items(i).SubItems.Add(cp(i).Class_CP_Doc_Numero)
                .Items(i).SubItems.Add(NumeroLatino(cp(i).Class_CP_Valor_Cobrado, 10, True))
                .Items(i).SubItems.Add(cp(i).Class_CP_Historico)
                .Items(i).SubItems.Add(cp(i).Class_CP_Centro_Custo_codigo)
                .Items(i).SubItems.Add(cp(i).Class_CP_Centro_Custo_nome)

            End With



        Next

        LabelTotalLiberar.Text = SomaValores(ListView1, 9, False)

        ignoreItemCheckedEvent = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Query As String
        Query = "UPDATE CP SET "
        Query += "CP_Status = 1"
        Query += ",CP_usuario_aprovacao_codigo = " & usuClass.Usuario_Chave
        Query += ",CP_usuario_aprovacao_tipo = '" & usuClass.Usuario_Tipo & "'"
        Query += ",CP_usuario_aprovacao_nome = '" & usuClass.Usuario_Nome & "'"
        Query += ",CP_usuario_aprovacao_data = now() "

        Dim strWhere As String = ""

        For Each item As ListViewItem In ListView1.Items

            If item.Checked Then

                strWhere += item.Text & ","

            End If

        Next

        If strWhere = "" Then

            With oi

                .Msg = "Nenhum lançamento selecionado !" & Chr(13) & Chr(13)
                .Msg += "Por favor, selecione pelo menos um lançamento"
                .Style = vbExclamation
                .Title = Me.Text
                MsgBox(.Msg, .Style, .Title)
                Exit Sub

            End With

        End If

        strWhere = strWhere.Substring(0, strWhere.Length - 1)

        With oi

            .Msg = "Confirma a liberação dos selecionados !" & Chr(13) & Chr(13)

            .Style = vbYesNo
            .Title = Me.Text
            If MsgBox(.Msg, .Style, .Title) <> 6 Then
                Exit Sub
            End If

        End With

        Query += " Where ID_CP in (" & strWhere & ");"

        If GravaSQL(Query) Then

            With oi

                .Msg = "Gravação Realizada com sucesso !"
                .Style = vbExclamation
                .Title = Me.Text
                MsgBox(.Msg, .Style, .Title)
                Me.Close()

            End With

        Else
            With oi

                .Msg = "Gravação não realizada !" & Chr(13) & Chr(13)
                .Msg += "Por favor tente de novo, se o problema persistir contate o suporte"
                .Style = vbCritical
                .Title = Me.Text
                MsgBox(.Msg, .Style, .Title)
                Me.Close()

            End With
        End If

    End Sub

    Private Function SomaValores(objTabela As Object, intColuna As Integer, boTipo As Boolean) As String

        Dim boTeste As Boolean = boTipo
        Dim total As Decimal = 0

        For Each item As ListViewItem In objTabela.Items

            If item.Checked = boTeste Then

                total += Decimal.Parse((item.SubItems(intColuna).Text))

            End If
        Next


        Return NumeroLatino(total, 10, True)

    End Function



    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked

        If ignoreItemCheckedEvent Then

            Exit Sub

        End If

        LabelTotalLiberar.Text = SomaValores(ListView1, 9, False)
        LabelTotalLiberado.Text = SomaValores(ListView1, 9, True)

    End Sub
End Class