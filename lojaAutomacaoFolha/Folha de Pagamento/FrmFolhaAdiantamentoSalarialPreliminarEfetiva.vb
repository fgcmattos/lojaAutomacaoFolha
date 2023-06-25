Imports MySql.Data.MySqlClient
Public Class FrmFolhaAdiantamentoSalarialPreliminarEfetiva
    Public OI As New MsgShow
    Private Sub FrmFolhaAdiantamentoSalarialPreliminarEfetiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strDataEvento As String
        Dim strColaboradores As String
        Dim strVariavel As String
        Dim strDescricao As String
        Dim strValor As String
        Dim strPorcentagem As String
        Dim strReferencia As String
        Dim query As String = ""
        Dim strListboxCab As String = "REF               DATA PAG     QTO VERBA         DESCRIÇÃO                       VALOR(R$) "
        Dim strListboxTraco As String = "=================================================================================================================="
        ListBox1.Items.Add(strListboxCab)
        ListBox1.Items.Add(strListboxtRACO)
        query += "Select "
        query += "FL_referencia"
        query += ",FL_data_Pagamento"
        query += ",count(*)"
        query += ",FL_VARIAVEL"
        query += ",FL_DESCRICAO"
        query += ", sum(FL_valor)"
        query += ",FL_QTO"
        query += " From folha_lancamento"
        query += " Where "
        query += "FL_folha_tipo = 2"
        query += " And FL_folha2_status = 'G'"
        query += " Group By FL_referencia"

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()
                    strReferencia = DTReader.GetValue(0)
                    strReferencia = strReferencia.Substring(4, 2) & "/" & strReferencia.Substring(0, 4)
                    strReferencia = espacoEsquerda(strReferencia, 10, 1)
                    strDataEvento = espacoEsquerda(dataLatina(DTReader.GetValue(1)), 15, 2)
                    strColaboradores = espacoEsquerda(DTReader.GetValue(2), 10, 2)
                    strVariavel = espacoEsquerda(DTReader.GetValue(3), 10, 2)
                    strDescricao = espacoEsquerda(Trim(DTReader.GetValue(4)), 30, 2)
                    strValor = espacoEsquerda(MoneyLatino(DTReader.GetValue(5)), 15, 2)
                    strPorcentagem = espacoEsquerda(MoneyLatino(DTReader.GetValue(6)), 15, 2)

                    ListBox1.Items.Add(strReferencia & strDataEvento & strColaboradores & strVariavel & strDescricao & strValor & strPorcentagem)

                End While
            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged



    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.Items.Count < 3 Then Exit Sub
        'MsgBox(ListBox1.SelectedItem)
        Dim strLinha As String = ListBox1.SelectedItem
        Dim strReferencia As String = strLinha.Substring(0, 7)
        Dim strDataPagamento As String = strLinha.Substring(15, 10)
        Dim strQTO As String = strLinha.Substring(30, 5)
        Dim strValor As String = strLinha.Substring(75, 15)
        Dim strPorcentagem As String = Trim(strLinha.Substring(91))

        DateTimePicker1.Value = strDataPagamento
        DateTimePicker1.Visible = True


        MskReferencia.Text = strReferencia
        MskPorcentagemDoSalario.Text = strPorcentagem
        DateTimePicker1.Value = strDataPagamento
        MskColaboradores.Text = strQTO
        MskTotalAdiantamento.Text = strValor
        DateTimePicker1.Focus()

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnEfetiva.Click

        Dim Tm As List(Of Aponta) = ApontaAcoes.GetApontaDB()

        Dim strReferencia As String = MskReferencia.Text
        strReferencia = strReferencia.Substring(3, 4) & strReferencia.Substring(0, 2)
        With OI

            .msg = "Confirma Liberaçao da Folha de Adiantamento?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
            If .resposta <> 6 Then Exit Sub

        End With


        MsgBox(DateTimePicker1.Value)

        Dim strDataAdiantamentoPagamento As String = dataAAAAMMDD(DateTimePicker1.Value)

        MsgBox(strDataAdiantamentoPagamento)

        Dim query As String = ""

        query = "Update folha_lancamento set "
        query += "FL_folha_tipo = if(FL_folha2_status = 'W',1,2)"
        query += ",FL_folha2_status = 'E'"
        query += ",FL_liberadoPor = " & Form1.Form1Chave.Text
        query += ",FL_data_Liberacao = Now()"
        query += " where "
        query += "FL_folha_tipo = 2"
        query += " And FL_referencia = '" & strReferencia & "'"
        'query += " and FL_folha2_status = 'W'"

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

            Catch ex As Exception
                MsgBox("Problemas Na Gravação!")
            End Try

            Conn.Close()
            With OI
                .msg = "Gravação Realizada com sucesso!"
                .style = vbExclamation
                MsgBox(.msg, .style, .title)
            End With
        End If


    End Sub

End Class
