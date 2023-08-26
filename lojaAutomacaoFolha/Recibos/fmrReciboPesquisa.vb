Imports System.Web.UI.WebControls.WebParts
Imports MySql.Data.MySqlClient


Public Class fmrReciboPesquisa

    ''Public RecRestart As List(Of recibo) = ReciboRP.ReciboCargaEmissor()
    ''Public RecRestart1 As List(0f recibo)= ReciboRP.GetReciboREstart()



    Private Sub fmrReciboPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dados = New List(Of Tuple(Of Integer, String))() From {
       Tuple.Create(0, "Colaborador"),
       Tuple.Create(1, "Fornecedor"),
       Tuple.Create(2, "Geral"),
       Tuple.Create(100, "Todos")}

        With CmbTipo
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dados.ToList()
            .DisplayMember = "Item2"
            .ValueMember = "Item1"
        End With

        CmbTipo.SelectedValue = 100




        Dim dados1 = New List(Of Tuple(Of Integer, String))() From {
      Tuple.Create(0, "Impresso"),
      Tuple.Create(1, "Assinado"),
      Tuple.Create(2, "Cancelado"),
      Tuple.Create(3, "Anulado"),
      Tuple.Create(100, "Todos")}

        With CmbStatus
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dados1.ToList()
            .DisplayMember = "Item2"
            .ValueMember = "Item1"
        End With

        CmbStatus.SelectedValue = 100


    End Sub

    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click
        Me.Close()
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick


        'RecRestart = ReciboRP.GetReciboREstart(ListView1.SelectedItems(0).Text)

        'RecRestart1 = ReciboRP.GetReciboREstart(ListView1.SelectedItems(0).Text)

        'RecRestart1(0).ValorBR = "V A L O R (#R$" & RecRestart(0).ValorBR & "#)"

        Lblrecibo.text = ListView1.SelectedItems(0).Text

        FmrReciboRel.Text = "R E S T A R T  D A  I M P R E S S Ã O  D E  R E C I B O"

        FmrReciboRel.Show()

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        ListView1.Items.Clear()
        Dim Query As String = ""
        Dim QuerySoma As String
        Dim QueryCampos As String
        Dim QuerySomaColaborador As String
        Dim QueryQTO As String
        Dim QueryQTOcolaborador As String
        Dim QueryQTOfornecedor As String
        Dim QuerySomaFornecedor As String
        Dim QueryQTOgeral As String
        Dim QuerySomaGeral As String

        Dim numeroLocal As String
        Dim numeroSequencial As String
        Dim strValorTotal As String = ""
        'Dim strSomaFornecedor As String
        Dim strValorQTO As Integer = 0
        Dim intAponta As Integer 
        Dim strValorTotalColaborador As String = ""
        Dim strValorQTOcolaborador As String = ""



        'Tratamento das variáveis de pesquisa
        Dim strNumero As String = IIf(Trim(MskNumero.Text.Replace(",", "")) = "", "", Trim(MskNumero.Text.Replace(",", ".")))
        Dim strFavorecido As String = IIf(Trim(TxtFavorecido.Text) = "", "", "%" & Trim(TxtFavorecido.Text) & "%")
        Dim strEmissao As String = IIf(Trim(MskEmissao.Text.Replace("/", "")) = "", "", dataAAAAMMDD(MskEmissao.Text))
        Dim strAssinatura As String = IIf(Trim(MskAssinatura.Text.Replace("/", "")) = "", "", dataAAAAMMDD(MskAssinatura.Text))
        Dim strValor As String = Trim(TxtValor.Text)
        Dim strDocumento As String = Trim(MskDocumento.Text)
        Dim strHistorico As String = Trim(TxtHistorico.Text)
        Dim strNumeroSemMascara As String = Trim(strNumero.Replace(".", ""))
        Dim strValorQTOFornecedor As String = ""
        Dim strValorTotalFornecedor As String = ""
        Dim strValorTotalGeral As String = ""
        Dim strValorQTOgeral As String = ""
        Dim intReciboTipo As Integer = CmbTipo.SelectedValue
        Dim intReciboStatus As Integer = CmbStatus.SelectedValue

        ListView1.View = View.Details
        ListView1.GridLines = True

        Select Case Len(strNumeroSemMascara)
            Case = 1, 2, 3

                MsgBox("Pesquisa não será realizada", vbCritical, "Erro Na determinação do Número do Recibo")
                Exit Sub

            Case = 4
                numeroLocal = strNumero.Substring(0, 4) & "%"
                numeroSequencial = ""
                Query = " Where ReciboNumeroLocal like  '" & numeroLocal & "'"
            Case = 5
                numeroLocal = strNumero.Substring(0, 6) & "%"
                numeroSequencial = strNumero.Substring(8)
                Query = " Where ReciboNumeroLocal like '" & numeroLocal & "'"
                'Query += " and ReciboNumeroSequencial = " & numeroSequencial

            Case = 6
                numeroLocal = strNumero.Substring(0, 7)
                numeroSequencial = ""
                Query = " Where ReciboNumeroLocal = '" & numeroLocal & "'"

            Case > 6
                numeroLocal = strNumero.Substring(0, 7)
                numeroSequencial = strNumero.Substring(8)
                Query = " Where ReciboNumeroLocal =  '" & numeroLocal & "'"
                Query += " and ReciboNumeroSequencial = " & numeroSequencial

        End Select

        If strFavorecido <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If
            Query += " reciboFavorecido Like '" & Trim(strFavorecido) & "'"

        End If

        If strEmissao <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " reciboDataEmissao = '" & strEmissao & "'"

        End If

        If strAssinatura <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " reciboDataAssinatura = '" & strAssinatura & "'"

        End If

        If strValor <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " ReciboValorNumerico = " & strValor

        End If

        If strDocumento <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " ReciboCPF_CNPJ = '" & strDocumento & "'"


        End If

        If strHistorico <> "" Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " ReciboTextoPactuado like '%" & strHistorico & "%'"

        End If

        If intReciboTipo <> 100 Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " ReciboTipo = " & intReciboTipo

        End If

        If intReciboStatus <> 100 Then

            If Query = "" Then
                Query = " where "
            Else
                Query += " and  "
            End If

            Query += " ReciboStatus = " & intReciboStatus

        End If



        Dim QueryComplementar As String = " A.reciboStatus = A2.StatusCod And A.reciboTipo = A1.TipoCod"



        QueryCampos = "idRecibo"
        QueryCampos += ",concat(ReciboNumeroLocal,'.',ReciboNumeroSequencial)"
        QueryCampos += ",reciboFavorecido"
        QueryCampos += ",ReciboDataEmissao"
        QueryCampos += ",ReciboDataAssinatura"
        QueryCampos += ",reciboValorBR "
        QueryCampos += ",reciboTipo "
        QueryCampos += ",reciboStatus "
        QueryCampos += ",Tipo_Descricao "
        QueryCampos += ",Status_Descricao "


        If Query <> "" Then
            QuerySoma = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo " & Query & ")"
            QueryQTO = ",(select count(*) from recibo " & Query & ")"
            QueryQTOcolaborador = ",(select count(*) from recibo " & Query & " and reciboTipo = '0' )"
            QuerySomaColaborador = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo " & Query & " and reciboTipo = '0' ) "
            QueryQTOfornecedor = ",(select count(*) from recibo " & Query & " and reciboTipo = '1' )"
            QuerySomaFornecedor = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo " & Query & " and reciboTipo = '1' ) "
            QueryQTOgeral = ",(select count(*) from recibo " & Query & " and reciboTipo = '2' )"
            QuerySomaGeral = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo " & Query & " and reciboTipo = '2' ) "

        Else

            QuerySoma = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo ) "
            QueryQTO = ",(select count(*) from recibo ) "
            QueryQTOcolaborador = ",(select count(*) from recibo where reciboTipo = '0' ) "
            QuerySomaColaborador = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo where reciboTipo = '0' ) "
            QueryQTOfornecedor = ",(select count(*) from recibo where reciboTipo = '1' ) "
            QuerySomaFornecedor = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo where reciboTipo = '1' ) "
            QueryQTOgeral = ",(select count(*) from recibo where reciboTipo = '2' ) "
            QuerySomaGeral = ",(select format(sum(ReciboValorNumerico),2,'de_DE') from recibo where reciboTipo = '2' ) "

        End If

        Dim QueryTable As String = " from "
        QueryTable += "recibo A "
        QueryTable += ",recibo_tipo A1 "
        QueryTable += ",recibo_status A2 "

        If Query = "" Then
            QueryComplementar = " Where " & QueryComplementar
        Else
            QueryComplementar = " And " & QueryComplementar
        End If

        Dim QuerySQL As String = "Select "

        QuerySQL += QueryCampos
        QuerySQL += QuerySoma
        QuerySQL += QueryQTO
        QuerySQL += QuerySomaColaborador
        QuerySQL += QueryQTOcolaborador
        QuerySQL += QuerySomaFornecedor
        QuerySQL += QueryQTOfornecedor
        QuerySQL += QuerySomaGeral
        QuerySQL += QueryQTOgeral
        QuerySQL += QueryTable
        QuerySQL += Query
        QuerySQL += QueryComplementar


        If OpenDB() Then

            Dim DTReader As MySqlDataReader
            Dim CMD As New MySqlCommand(QuerySQL, Conn)

            Try
                DTReader = CMD.ExecuteReader

                intAponta = 0
                While DTReader.Read

                    ListView1.Items.Add(DTReader.GetString(1))                                                  ' Numero do recibo
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(2))              ' Nome do Beneficiado
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dataLatina(DTReader.GetString(3)))  ' Emissao do recibo
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(4))              ' Assinatura
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(5))              ' Valor do recibo (Formatado)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(6))              ' TIPO   do recibo
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(8))              ' Tipo Descricao
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(7))              ' Status do recibo
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader.GetString(9))              ' Status Descricao
                    If intAponta = 0 Then

                        intAponta += 1
                        strValorTotal = DTReader.GetString(10)
                        strValorQTO = DTReader.GetString(11)

                        strValorQTOcolaborador = DTReader.GetString(13)
                        If Val(strValorQTOcolaborador) = 0 Then

                            strValorTotalColaborador = "0"

                        Else

                            strValorTotalColaborador = DTReader.GetString(12)

                        End If


                        strValorQTOFornecedor = DTReader.GetString(15)

                        If Val(strValorTotalFornecedor) = 0 Then

                            strValorTotalFornecedor = "0"

                        Else

                            strValorTotalFornecedor = DTReader.GetString(14)

                        End If

                        strValorQTOgeral = DTReader.GetString(17)

                        If Val(strValorQTOgeral) = 0 Then

                            strValorTotalGeral = "0"

                        Else

                            strValorTotalGeral = DTReader.GetString(16)

                        End If


                    End If
                End While

            Catch ex As Exception

                MsgBox(ex)

            End Try

            ListView2.Items.Clear()

            If strValorTotal <> "0,00" Then

                strValorTotal = espacoEsquerda(strValorTotal, 20, 0)
                If Val(strValorQTOcolaborador) <> 0 Then
                    ListView2.Items.Add("Colaborador")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorQTOcolaborador)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorTotalColaborador)
                End If

                If Val(strValorQTOFornecedor) <> 0 Then
                    ListView2.Items.Add("Fornecedor")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorQTOFornecedor)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorTotalFornecedor)
                End If

                If Val(strValorQTOgeral) <> 0 Then
                    ListView2.Items.Add("Geral")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorQTOgeral)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorTotalGeral)
                End If

                ListView2.Items.Add("T O T A I S")
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorQTO)
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(strValorTotal)

            End If

            Conn.Close()

        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class