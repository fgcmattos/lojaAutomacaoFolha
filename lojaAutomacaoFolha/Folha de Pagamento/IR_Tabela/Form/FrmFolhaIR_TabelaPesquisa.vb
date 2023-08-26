Imports MySql.Data.MySqlClient

Public Class FrmFolhaIR_TabelaPesquisa
    Private Sub FrmFolhaIR_TabelaPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboCarregar(Me.CmbTabelaStatus, "inss_status", "concat(inss_status_Codigo,' - ' , inss_status_descricao)", "")

    End Sub

    Private Sub LimpaLabel()
        LblTabelaNumero.Text = ""
        LblDataAtivacao.Text = ""
        LblDataDesativacao.Text = ""
        LblTabelaAnterior.Text = ""
        LblTabelaPosterior.Text = ""
        LblDigitacaoData.Text = ""
        LblDigitacaoOperadorChave.Text = ""
        LblDigitacaoOperadorTipo.Text = ""
        LblConferenciaData.Text = ""
        LblConferenciaAnalistaChave.Text = ""
        LblConferenciaAnalistaTipo.Text = ""
        LblLiberacaoData.Text = ""
        LblLiberacaoResponsavelChave.Text = ""
        LblLiberacaoResponsavelTipo.Text = ""

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        ListView1.Items.Clear()
        LimpaLabel()

        If Replace(CmbTabelaStatus.Text, " ", "") = "" Then

            MsgBox("Por favor, defina um status de tabela ")
            CmbTabelaStatus.Focus()
            Exit Sub

        End If

        Dim IsTabelaStatus As String = CmbTabelaStatus.Text.Substring(0, 1)
        Dim IsReferencia As String

        Dim InRef As String = Replace(Replace(MskReferencia.Text, "/", ""), " ", "")
        Dim INNUm As String = Replace(Replace(MskNumero.Text, ",", "."), " ", "")
        Dim Query As String
        Query = "Select count(*) from folha_tabela_imposto_renda_pf where IRtabelaStatus = " & IsTabelaStatus
        If InRef <> "" Then Query += " and INSSREF = '" & InRef & "'"
        If INNUm <> "." Then Query += " and INSStabelaNumero = '" & INNUm & "'"

        Dim InQtoTabelas As Integer = gravaSQLretorno(Query)

        Select Case InQtoTabelas

            Case 0

                MsgBox("Caracteristicas não encontradas na BASE !")
                Exit Sub

            Case 1

                Query = "Select IRREF from folha_tabela_imposto_renda_pf where IRtabelaStatus = " & IsTabelaStatus

                IsReferencia = gravaSQLretorno(Query)

                IR_mostra_tabela(IsReferencia)

            Case Else

                GrpInterruptor(False)      ' Trava os agrupamentos

                'ListSelecao.Location = New Point(200, 114)
                Query = "Select IRREF from folha_tabela_imposto_renda_pf where IRtabelaStatus = " & IsTabelaStatus
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader
                Try

                    If OpenDB() Then

                        DTReader = CMD.ExecuteReader

                        ListSelecao.Items.Clear()

                        While DTReader.Read()
                            ListSelecao.Items.Add(DTReader.GetValue(0))
                        End While

                    End If

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

                Conn.Close()


                GroupEscolhaTabela.Visible = True

                Exit Sub

        End Select




    End Sub

    Private Sub IR_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "IRREF = '" & StrReferencia & "'"

        Dim IRtabela As List(Of ClassIRtabela) = ClassIRtabelaAcao.GetIR_DB(IsComparacao)

        ListView1.Items.Clear()

        LblDigitacaoData.Text = IRtabela(0).Class_IRdataCriacao
        LblDigitacaoOperadorChave.Text = IRtabela(0).Class_IRresponsavelDigitacao

        'LblReferencia.Text = INSStabela(0).Class_INSSREF.Substring(0, 4) & "/" & INSStabela(0).Class_INSSREF.Substring(4)

        For i As Integer = 1 To IRtabela(0).Class_IRnumeroDeFaixas

            ListView1.Items.Add(i)
            Select Case i
                Case 1
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Porcentagem, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Valor, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa1Acumulado, 2), 8, True))

                Case 2
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Porcentagem, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Valor, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa2Acumulado, 2), 8, True))

                Case 3
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Porcentagem, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Valor, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa3Acumulado, 2), 8, True))

                Case 4
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa4Acumulado, 2), 8, True))
                Case 5
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Porcentagem, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Valor, 2), 8, True))
                    ListView1.Items(4).SubItems.Add(numeroLatino(Math.Round(IRtabela(0).Class_IRfaixa5Acumulado, 2), 8, True))

            End Select

        Next

        LblTabelaNumero.Text = IRtabela(0).Class_IR_numero
        LblDataAtivacao.Text = dataLatina(IRtabela(0).Class_IR_dataInicio)
        LblDataDesativacao.Text = IIf(DateTime.MinValue = IRtabela(0).Class_IR_dataFim, DateTime.MinValue, dataLatina(IRtabela(0).Class_IR_dataFim))
        LblTabelaAnterior.Text = ""
        LblTabelaPosterior.Text = ""
        LblDigitacaoData.Text = IRtabela(0).Class_IRdataCriacao
        LblDigitacaoOperadorChave.Text = IRtabela(0).Class_IRresponsavelDigitacao & " - " & IRtabela(0).Class_IRresponsavelDigitacaoNome
        LblDigitacaoOperadorTipo.Text = IRtabela(0).Class_IRresponsavelDigitacaoTipo
        LblConferenciaData.Text = IRtabela(0).Class_IRdataConferencia
        LblConferenciaAnalistaChave.Text = IRtabela(0).Class_IRresponsavelConferencia & " - " & IRtabela(0).Class_IRresponsavelConferenciaNome
        LblConferenciaAnalistaTipo.Text = IRtabela(0).Class_IRresponsavelConferenciaTipo
        LblLiberacaoData.Text = IRtabela(0).Class_IRdataPublicação
        LblLiberacaoResponsavelChave.Text = IRtabela(0).Class_IRresponsavelPublicacao & " - " & IRtabela(0).Class_IRresponsavelPublicacaoNome
        LblLiberacaoResponsavelTipo.Text = IRtabela(0).Class_IRresponsavelPublicacaoTipo
        LblLiberacaoData.Text = IRtabela(0).Class_IRdataPublicação

    End Sub

    Private Sub BtnSelecao_Click(sender As Object, e As EventArgs) Handles BtnSelecao.Click




        If ListSelecao.SelectedIndex <> -1 Then

            Dim itemSelected As String = ListSelecao.SelectedItem.ToString()
            IR_mostra_tabela(itemSelected)
            GroupEscolhaTabela.Visible = False
            GrpInterruptor(True)


        End If

    End Sub

    Private Sub GrpInterruptor(IsLed As Boolean)

        GroupPainelDePesquisa.Enabled = IsLed
        GroupIdentificacaoDaTabela.Enabled = IsLed
        GroupTabelaShow.Enabled = IsLed

    End Sub

End Class