
Imports System.Security.Cryptography
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.ReportingServices.Diagnostics.Utilities
Imports MySql.Data.MySqlClient
Public Class FreciboNew

    Public rc As List(Of recibo) = ReciboRP.ReciboCargaEmissor() ' Recebendo empresa emissora
    'ReciboColaboradorCarregaSQ

    Public apontaTempo As List(Of Aponta) = ApontaAcoes.GetApontaDB()

    Public rcColaborador As List(Of Recibo)

    Public oi As New MsgShow

    Private Sub btnGrava_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        ''''''''''''''''''''''''''
        Dim pontoPosicao As String = InStr(txtValor.Text, ",")


        If Len(rbHist.Text) < 10 Then

            MsgBox("Por favor, reveja o conteudo do Campo Historico", vbCritical, "Campo Histórico com menos de 10 letras")
            Exit Sub

        End If

        rc(0).LocalData = lblLocalData.Text
        rc(0).TextoPactuado = Trim(rbHist.Text)

        If Not ReciboGrava() Then

            MsgBox("Error na geração do Recibo!")
            Exit Sub

        End If

        FmrReciboRel.Text = "R E C I B O - I M P R E S S Ã O"

        lblAnoMesSequencial.text = rc(0).NumeroAnoMesSeq

        FmrReciboRel.Show()

        'MsgBox("Registro Gravado Sob Object n° " & rc(0).NumeroAnoMesSeq,, "Sistema de Gravação de Recibos")

    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Me.Close()
    End Sub

    Private Sub btnFavOK_Click(sender As Object, e As EventArgs) Handles BtnFavOK.Click

        Dim rcColaborador As List(Of Recibo) = ReciboAcoes.ReciboColaboradorCarregaSQL(MskColChave.Text)

        'MsgBox(TbcFavorecido.SelectedIndex.ToString) ' 0,1,2

        Select Case TbcFavorecido.SelectedIndex

            Case 0
                LimpaIdentificacaoFornecedor()
                LimpaIdentificacaoGeral()

            Case 1
                LimpaIdentificacaoColaborador(True)
                LimpaIdentificacaoGeral()
            Case 2
                LimpaIdentificacaoColaborador(True)
                LimpaIdentificacaoFornecedor()

        End Select

        If TbcFavorecido.SelectedTab.Text <> "Fornecedor" Then

            rc(0).Chave = rcColaborador(0).Chave
            rc(0).Favorecido = rcColaborador(0).Favorecido
            rc(0).FavorecidoRg = rcColaborador(0).FavorecidoRg
            rc(0).FavorecidoCpf_Cnpj = rcColaborador(0).FavorecidoCpf_Cnpj
            rc(0).FavorecidoRGorgaoExpedidor = rcColaborador(0).FavorecidoRGorgaoExpedidor
            rc(0).FavorecidoRgEmissao = rcColaborador(0).FavorecidoRgEmissao
            rc(0).FavorecidoEndereco = rcColaborador(0).FavorecidoEndereco

            If TbcFavorecido.SelectedTab.Text <> "Colaborador" Then
                rc(0).Tipo = 0
            Else
                rc(0).Tipo = 2
            End If
        Else
            rc(0).Tipo = 1
            MsgBox("Rotina em desenvolvimento")
            Exit Sub

        End If




        TbcFavorecido.Enabled = False
        GruFavorecido.Enabled = False

        GruCaracteristicas.Enabled = True

        LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
        LblreciboValor.ForeColor = System.Drawing.Color.Maroon
        LblReciboValorAponta.Visible = True
        txtValor.Enabled = True
        txtValor.Focus()

    End Sub

    Private Sub btnGeraHistorico_Click(sender As Object, e As EventArgs)
        'rbHist.Text = "               (Eu, " & rc(0).Favorecido & ", portador do RG: " & rc(0).FavorecidoRg & " CPF: " & rc(0).Cpf_Cnpj
        'rbHist.Text = rbHist.Text & " recebi de S & R SERVIÇOS E REPARACAO DE ARTIGOS DO VESTUARIO LTDA, "
        'rbHist.Text = rbHist.Text & " CNPJ: 35.363.232/0001-99, Situada à Rua AV RAIMUNDO PEREIRA DE MAGALHAES, 1465 "
        'rbHist.Text = rbHist.Text & " LOJA 1091 - Shoping Plaza - São Paulo - SP - CEP 05145-907 "
        'rbHist.Text = rbHist.Text & " O valor de " & lblExtenso.Text & " proveniente de Adiantamento "
        'rbHist.Text = rbHist.Text & " salarial do perido de 01/04/2020 à 30/04/2020, que será descontado de meus proventos a receber em 05/05/2020)"

        ''rbHist.Text = rbHist.Text & stringRepita("__/_\", 703)
        'rbHist.Text = rbHist.Text & stringRepita("\ -- ", 700)

        'rbHist.SelectionAlignment = 0

    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress

        Dim strMascarado As String = ""

        With txtValor


            If .Text = "" Then

                .Text = "0,00"

            End If



            If e.KeyChar = Convert.ToChar(27) Then

                LblreciboValor.Enabled = False
                LblReciboValorAponta.Visible = False
                LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                LblreciboValor.ForeColor = System.Drawing.Color.Black

                TbcFavorecido.Enabled = True
                GruFavorecido.Enabled = True
                GruCaracteristicas.Enabled = False
                BtnFavOK.Focus()

            End If

            If e.KeyChar = Convert.ToChar(13) Then

                'MsgBox("Enter pressionado")
                If txtValor.Text = "0,00" Then

                    oi.msg = "valor inválido!"
                    oi.style = vbCritical
                    MsgBox(oi.msg, oi.style, oi.title)
                    Exit Sub

                End If
                lblExtenso.Text = Extenso(.Text)
                txtValor.Enabled = False
                LblReciboValorAponta.Visible = False
                LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                LblreciboValor.ForeColor = System.Drawing.Color.Black

                lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                lblReciboData.ForeColor = System.Drawing.Color.Maroon
                LblReciboDataAponta.Visible = True
                mskReciboData.Enabled = True
                mskReciboData.Focus()

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

    Private Sub lblReciboData_Click(sender As Object, e As EventArgs) Handles lblReciboData.Click
        Dim datahoraAtual As DateTime = Now
        mskReciboData.Text = datahoraAtual.ToShortDateString()
    End Sub

    Private Sub lblLocalRecibo_Click(sender As Object, e As EventArgs) Handles lblReciboLocal.Click
        txtReciboLocal.Text = "São Paulo"
    End Sub

    Function formataReal(valor As String) As String
        Dim nPontos, resto As Integer
        Dim volta As String

        If Len(valor) < 7 Then
            formataReal = valor
            Exit Function
        End If

        nPontos = Int(Len(valor) / 3)
        resto = Len(valor) - (3 * nPontos)

        volta = valor.Substring(Len(valor) - 3)
        For i = 1 To (nPontos - 1)
            If i < (nPontos - 1) Or resto <> 0 Then
                volta = "." & valor.Substring(Len(valor) - (3 * (i + 1)), 3) & volta
            Else
                volta = valor.Substring(Len(valor) - (3 * (i + 1)), 3) & volta
            End If

        Next
        If resto = 0 Then
            formataReal = volta
        Else
            formataReal = valor.Substring(0, resto) & volta
        End If

    End Function

    Private Sub btnFavOK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnFavOK.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then
            TbcFavorecido.Enabled = True
            MskColChave.Focus()
            BtnFavOK.Enabled = False
        End If
    End Sub

    Private Function stringRepita(parte As String, qto As Integer) As String

        Dim repeticoes As Integer = Int(qto / Len(parte))
        Dim diferenca As Integer = (qto - (repeticoes * Len(parte)))
        Dim retornoVolta As String = ""
        For i = 1 To repeticoes
            retornoVolta += parte
        Next

        stringRepita = retornoVolta + parte.Substring(0, diferenca)


    End Function

    Private Sub FreciboNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaHistRrecibo()

    End Sub

    Private Sub BtnPreencheHistorico_Click(sender As Object, e As EventArgs) Handles BtnPreencheHistorico.Click

        Dim StrTexto As String = ""

        Dim StrCodigo As String = Trim(CmbHistPad.Text.Substring(0, 2))

        '===================================================
        If OpenDB() Then
            Dim Query As String = "Select reciboHistPadHistorico,reciboHistPadReferencia from recibohistpad where reciboHistPadCod = " + StrCodigo
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader

                DTReader.Read()

                'CmbHistPad.Items.Add(DTReader.GetString(1) & " - " & DTReader.GetString(2) & " / " & DTReader.GetString(3))
                StrTexto = Trim(DTReader.GetString(0))
                rc(0).Referencia = Trim(DTReader.GetString(1))
            Catch ex As Exception
                Conn.Close()
                MsgBox("Problemas com a leitura do Arquivo recibohistpad")
                Exit Sub
            End Try

            Conn.Close()
        End If
        '===================================================
        Dim IntLen As Integer = StrTexto.Length

        Dim StrFraseConstrucao As String = ""
        Dim StrVariavel As String = ""
        Dim StrLetra As String = ""
        Dim IntContador As Integer = 0

        For i = 0 To (IntLen - 1)

            StrLetra = StrTexto.Substring(i, 1)

            If StrLetra = "#" Then

                StrVariavel = ""

                For j = (i + 1) To (i + 4)

                    If StrTexto.Substring(j, 1) <> "#" Then

                        StrVariavel += StrTexto.Substring(j, 1)

                    Else

                        i = j
                        Exit For
                    End If

                Next


                'StrVariavel = StrTexto.Substring(i + 1, 2)

                'i += 2

                Select Case StrVariavel

                    Case "F0"

                        StrFraseConstrucao += rc(0).Chave

                    Case "F1"

                        StrFraseConstrucao += rc(0).Favorecido
                    Case "F2"

                        StrFraseConstrucao += rc(0).FavorecidoRg

                    Case "F3"

                        StrFraseConstrucao += rc(0).FavorecidoInsEstadual

                    Case "F4"

                        StrFraseConstrucao += rc(0).FavorecidoInsMuncipal
                    Case "F5"
                        StrFraseConstrucao += rc(0).FavorecidoCidade

                    Case "F6"

                        StrFraseConstrucao += rc(0).EmissorUF

                    Case "F7"

                        StrFraseConstrucao += rc(0).FavorecidoCpf_Cnpj

                    Case "F8"

                        StrFraseConstrucao += rc(0).FavorecidoRGorgaoExpedidor

                    Case "F9"

                        StrFraseConstrucao += dataLatina(rc(0).FavorecidoRgEmissao)

                    Case "F10"

                        StrFraseConstrucao += rc(0).EmissorEndereco

                    Case "E1"

                        StrFraseConstrucao += rc(0).EmissorNome

                    Case "E2"
                        StrFraseConstrucao += rc(0).EmissorIdTipo

                    Case "E3"

                        StrFraseConstrucao += rc(0).EmissorIdNumero

                    Case "E4"

                        StrFraseConstrucao += rc(0).EmissorEndereco

                    Case "E5"

                        StrFraseConstrucao += rc(0).EmissorEnderecoNumero

                    Case "E6"

                        StrFraseConstrucao += rc(0).EmissorEnderecoComplemento

                    Case "E7"

                        StrFraseConstrucao += rc(0).EmissorCidade

                    Case "E8"

                        StrFraseConstrucao += rc(0).EmissorUF

                    Case "E9"

                        StrFraseConstrucao += rc(0).EmissorLocal

                    Case "V1"

                        StrFraseConstrucao += rc(0).ValorBR

                    Case "V2"

                        StrFraseConstrucao += rc(0).ValorExtenso

                    Case "P1"
                        StrFraseConstrucao += rc(0).PortadorNome

                    Case "P2"

                        StrFraseConstrucao += rc(0).PortadorRG

                    Case "P3"

                        StrFraseConstrucao += rc(0).PortadorCPF

                    Case "D1"

                        StrFraseConstrucao += dataLatina(rc(0).DataEmissao)

                    Case "D2"

                        rc(0).DataPrestacaoServico = InputBox("Data da Prestação do Serviço ?")
                        StrFraseConstrucao += rc(0).DataPrestacaoServico

                    Case "C1"

                        StrFraseConstrucao = rc(0).Cabecario

                    Case "C2"

                        StrFraseConstrucao = rc(0).LocalData

                        'Case Else

                        '    oi.msg = "Variável " & StrVariavel & "Não registrada"
                        '    oi.style = vbCritical
                        '    MsgBox(oi.msg, oi.style, oi.title)

                        '    StrFraseConstrucao += StrLetra

                End Select




            Else
                StrFraseConstrucao += StrLetra

            End If

        Next


        rbHist.Text = StrFraseConstrucao
        TxtReferencia.Text = rc(0).Referencia



    End Sub

    Private Function CarregaHistRrecibo()

        CmbHistPad.Items.Clear()

        If OpenDB() Then
            Dim Query As String = "Select * from recibohistpad order by reciboHistPadCod"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read

                    CmbHistPad.Items.Add(DTReader.GetString(1) & " - " & DTReader.GetString(2) & " / " & DTReader.GetString(3))

                End While

            Catch ex As Exception
                Conn.Close()
                MsgBox("Problemas com a leitura do Arquivo recibohistpad")

            End Try

            Conn.Close()

        End If

    End Function

    Private Sub BtnHistAtualiza_Click(sender As Object, e As EventArgs) Handles BtnHistAtualiza.Click
        CarregaHistRrecibo()
    End Sub

    Private Function ReciboGrava() As Boolean

        ReciboGrava = True



        Dim query As String

        query = "Select count(reciboNumeroLocal) + 1 from recibo where reciboNumeroLocal = '" & apontaTempo(0).AnoPontoMes & "';"
        Dim intQto As Integer = gravaSQLretorno(query)

        rc(0).NumeroAnoMesSeq += "." & intQto.ToString

        query = "insert into recibo "
        query += "("
        query += "ReciboStatus"
        query += ",ReciboNumeroLocal"
        query += ",ReciboNumeroSequencial"
        query += ",reciboValorBR"
        query += ",ReciboValorNumerico"
        query += ",ReciboTextoPactuado"
        query += ",ReciboDataEmissao"
        query += ",ReciboDataAssinatura"
        query += ",ReciboCPF_CNPJ"
        query += ",ReciboFavorecido"
        query += ",ReciboFavorecidoRG"
        query += ",reciboInscricaoEstadual"
        query += ",reciboInscricaoMunicipal"
        query += ",ReciboCidade"
        query += ",ReciboUF"
        query += ",reciboDataLocal"
        query += ",ReciboTipo"
        query += ",reciboColaboradorChave"
        query += ",reciboPortadorNome"
        query += ",reciboPortadorRG"
        query += ",reciboPortadorCPF"
        query += ",reciboFavorecidoRGemissao"
        query += ",reciboReferencia"
        query += ")"
        query += " values "
        query += "(0"
        query += ",'" & apontaTempo(0).AnoPontoMes & "'"
        query += "," & intQto
        query += ",'" & rc(0).ValorBR & "'"
        query += "," & rc(0).ValorNumerico
        query += ",'" & rc(0).TextoPactuado & "'"
        query += ",'" & rc(0).DataEmissao & "'"
        query += ",'" & rc(0).DataAssinatura & "'"
        query += ",'" & rc(0).FavorecidoCpf_Cnpj & "'"
        query += ",'" & rc(0).Favorecido & "'"
        query += ",'" & rc(0).FavorecidoRg & "'"
        query += ",'" & rc(0).FavorecidoInsEstadual & "'"
        query += ",'" & rc(0).FavorecidoInsMuncipal & "'"
        query += ",'" & rc(0).FavorecidoCidade & "'"
        query += ",'" & rc(0).FavorecidoUf & "'"
        query += ",'" & rc(0).LocalData & "'"
        query += ",'" & rc(0).Tipo & "'"
        query += "," & rc(0).Chave
        query += ",'" & rc(0).PortadorNome & "'"
        query += ",'" & rc(0).PortadorRG & "'"
        query += ",'" & rc(0).PortadorCPF & "'"
        query += ",'" & rc(0).FavorecidoRgEmissao & "'"
        query += ",'" & rc(0).Referencia & "'"
        query += ");"

        If OpenDB() Then

            Dim CMD As New MySqlCommand(query, Conn)
            Dim DTReader As MySqlDataReader

            Try

                DTReader = CMD.ExecuteReader

                DTReader.Read()

                'rc(0).NumeroAnoMesSeq = DTReader.GetString(0)


            Catch ex As Exception

                MsgBox("Problemas na Gravação do Recibo - função ReciboGrava()")

                ReciboGrava = False

            End Try

            Conn.Close()

        End If



    End Function

    Private Sub mskReciboData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskReciboData.KeyPress

        Dim strData As List(Of Aponta) = ApontaAcoes.GetApontaDB()

        Dim dig As String = e.KeyChar

        With mskReciboData
            If dig = Convert.ToChar(27) Then

                LblreciboValor.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                LblreciboValor.ForeColor = System.Drawing.Color.Maroon
                LblReciboDataAponta.Visible = True
                txtValor.Enabled = True
                txtValor.Focus()

                lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                lblReciboData.ForeColor = System.Drawing.Color.Black
                LblReciboDataAponta.Visible = False
                mskReciboData.Enabled = False



            End If

            If dig = Convert.ToChar(13) Then

                'MsgBox("Enter pressionado")


                If Trim(Replace(.Text, "/", "")) = "" Then



                    mskReciboData.Text = dataLatina(strData(0).Data)


                End If

                Dim strCabecario As String = ""
                strCabecario = rc(0).EmissorCidade & ", " & strData(0).MesDia & " de " & strData(0).MesNome & " de " & strData(0).Ano & "."
                lblLocalData.Text = rc(0).EmissorCidade & ",  " & mskReciboData.Text
                lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                lblReciboData.ForeColor = System.Drawing.Color.Black
                LblReciboDataAponta.Visible = False
                mskReciboData.Enabled = False

                lblReciboLocal.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                lblReciboLocal.ForeColor = System.Drawing.Color.Maroon
                LblReciboDataAponta.Visible = True
                txtReciboLocal.Enabled = True
                txtReciboLocal.Focus()

                If txtReciboLocal.Text = "" Then

                    txtReciboLocal.Text = strCabecario

                End If
            End If
        End With
    End Sub

    Private Sub txtValor_GotFocus(sender As Object, e As EventArgs) Handles txtValor.GotFocus
        SendKeys.Send("{END}")
    End Sub

    Private Sub txtReciboLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReciboLocal.KeyPress

        Dim dig As String = e.KeyChar

        With txtReciboLocal
            If dig = Convert.ToChar(27) Then

                lblReciboData.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Bold)
                lblReciboData.ForeColor = System.Drawing.Color.Maroon
                LblReciboDataAponta.Visible = True
                mskReciboData.Enabled = True
                mskReciboData.Focus()

                lblReciboLocal.Font = New Font(FontFamily.GenericSansSerif, 8.25F, FontStyle.Regular)
                lblReciboLocal.ForeColor = System.Drawing.Color.Black
                LblReciboLOcalAponta.Visible = False
                txtReciboLocal.Enabled = False



            End If

            If dig = Convert.ToChar(13) Then

                'MsgBox("Enter pressionado")
                If .Text = "" Then

                    oi.msg = "Local inválido!"
                    oi.style = vbCritical
                    MsgBox(oi.msg, oi.style, oi.title)


                    Exit Sub

                End If
                rc(0).ValorBR = txtValor.Text
                rc(0).ValorExtenso = lblExtenso.Text
                rc(0).ValorNumerico = Replace(Replace(rc(0).ValorBR, ".", ""), ",", ".")
                CmbHistPad.Focus()
                Exit Sub


            End If
        End With
    End Sub

    Private Sub btnOkcaracteristica_Click(sender As Object, e As EventArgs) Handles btnOkcaracteristica.Click

        rc(0).Chave = IIf(TbcFavorecido.SelectedIndex = 0, MskColChave.Text, 0)
        rc(0).ValorBR = txtValor.Text
        rc(0).ValorExtenso = lblExtenso.Text
        rc(0).ValorNumerico = Replace(Replace(rc(0).ValorBR, ".", ""), ",", ".")
        rc(0).Cabecario = txtReciboLocal.Text
        rc(0).LocalData = lblLocalData.Text
        rc(0).NumeroAnoMesSeq = mskReciboData.Text.Substring(6) & "." & mskReciboData.Text.Substring(3, 2)
        TabControl1.TabPages(1).Focus()

    End Sub

    Private Sub MskColChave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskColChave.KeyPress

        Dim Mn As New MsgShow

        Mn.title = "Gerenciamento de Impressão de Recibos"

        If e.KeyChar = "" Then
            With Mn
                .style = vbCritical
                .msg = "Chave inválida"
                MsgBox(.msg, .style, .title)
            End With
            MskColChave.Focus()
            Exit Sub
        End If

        If e.KeyChar = Convert.ToChar(13) Then

            LimpaIdentificacaoColaborador(False)

            If OpenDB() Then
                Dim Query As String = ""
                Query += "select "
                Query += " count(*) as qto "
                Query += ",colaboradorNome "
                Query += ",colaboradorRG "
                Query += ",colaboradorCPF "
                Query += ",concat(colaboradorRGoe,' - ',colaboradorRGuf) "
                Query += ",colaboradorRGemissao "
                Query += ",concat(colaboradorResidencia,' - ',colaboradorResidenciaCidade,' - ',colaboradorResidenciaUF,'- CEP:',colaboradorResidenciaCEP)"
                Query += " from colaborador where chave = "
                Query += MskColChave.Text
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader
                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                    If DTReader.GetString(0) = "0" Then
                        With Mn
                            .style = vbCritical
                            .msg = "Colaborador não encontrado!"
                            MsgBox(.msg, .style, .title)
                        End With
                        MskColChave.Focus()
                        Conn.Close()
                        Exit Sub
                    End If
                    LblColNome.Text = DTReader.GetString(1)
                    LblColRG.Text = DTReader.GetString(2)
                    LblColCPF.Text = CPFcolocaMascara(DTReader.GetString(3))
                    LblExpedidor.Text = DTReader.GetString(4)
                    LblEmissao.Text = dataLatina(DTReader.GetString(5))
                    LblEndereco.Text = DTReader.GetString(6)
                Catch ex As Exception
                    Conn.Close()
                    MsgBox("Problemas com a leitura do Arquivo")
                    Exit Sub
                End Try

                Conn.Close()
            End If
        End If

    End Sub

    Private Function LimpaIdentificacaoColaborador(col As Boolean)
        If col Then MskColChave.Text = ""
        LblColNome.Text = ""
        LblColRG.Text = ""
        LblColCPF.Text = ""
        LblExpedidor.Text = ""
        LblEmissao.Text = ""
        LblColCPF.Text = ""
        LblEndereco.Text = ""
    End Function

    Private Function LimpaIdentificacaoFornecedor()
        MskCNPJ.Text = ""
        TxtCNPJnome.Text = ""
        TxtInscricaoMunicipal.Text = ""
        TxtInscricaoEstadual.Text = ""
        TxtPortadorNome.Text = ""
        TxtPortadorRG.Text = ""
        TxtPortadorRGorgaoExp.Text = ""
        TxtPortadorRGdataEmissao.Text = ""
        TxtPortadorCPF.Text = ""
        MskPortadorFuncao.Text = ""
    End Function

    Private Function LimpaIdentificacaoGeral()
        TxtGeralNome.Text = ""
        mskGeralRG.Text = ""
        TxtGeralOeUF.Text = ""
        MskGeralEmissao.Text = ""
        mskGeralCPF.Text = ""
        MskGeralFone.Text = ""
        TxtGeralEndereco.Text = ""
    End Function


End Class