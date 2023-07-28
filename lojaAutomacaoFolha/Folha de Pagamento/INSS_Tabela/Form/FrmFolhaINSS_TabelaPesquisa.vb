Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Public Class FrmFolhaINSS_TabelaPesquisa
    Private Sub FrmFolhaINSS_TabelaPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboCarregar(Me.CmbTabelaStatus, "inss_status", "concat(inss_status_Codigo,' - ' , inss_status_descricao)", "")



    End Sub

    Private Function LimpaLabel()
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

    End Function

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
        Query = "Select count(*) from inss where INSStabelaStatus = " & IsTabelaStatus
        If InRef <> "" Then Query += " and INSSREF = '" & InRef & "'"
        If INNUm <> "." Then Query += " and INSStabelaNumero = '" & INNUm & "'"

        Dim InQtoTabelas As Integer = gravaSQLretorno(Query)

        Select Case InQtoTabelas

            Case 0

                MsgBox("Caracteristicas não encontradas na BASE !")
                Exit Sub

            Case 1

                Query = "Select INSSREF from inss where INSStabelaStatus = " & IsTabelaStatus

                IsReferencia = gravaSQLretorno(Query)

                INSS_mostra_tabela(IsReferencia)

            Case Else

                GrpInterruptor(False)      ' Trava os agrupamentos

                'ListSelecao.Location = New Point(200, 114)
                Query = "Select INSSREF from inss where INSStabelaStatus = " & IsTabelaStatus
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

        'Dim TabINSS As New INSSREF = '202201'



    End Sub

    Private Function INSS_mostra_tabela(StrReferencia As String)

        Dim IsComparacao As String = "INSSREF = '" & StrReferencia & "'"

        Dim INSStabela As List(Of ClassINSStabela) = ClassINSStabelaAcao.GetINSS_DB(IsComparacao)

        ListView1.Items.Clear()

        LblDigitacaoData.Text = INSStabela(0).Class_INSSdataCriacao
        LblDigitacaoOperadorChave.Text = INSStabela(0).Class_INSSresponsavelDigitacao

        'LblReferencia.Text = INSStabela(0).Class_INSSREF.Substring(0, 4) & "/" & INSStabela(0).Class_INSSREF.Substring(4)

        For i As Integer = 1 To INSStabela(0).Class_INSSnumeroDeFaixas

            ListView1.Items.Add(i)
            Select Case i
                Case 1
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Porcentagem, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Valor, 2), 8, True))
                    ListView1.Items(0).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa1Acumulado, 2), 8, True))

                Case 2
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Porcentagem, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Valor, 2), 8, True))
                    ListView1.Items(1).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa2Acumulado, 2), 8, True))

                Case 3
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Porcentagem, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Valor, 2), 8, True))
                    ListView1.Items(2).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa3Acumulado, 2), 8, True))

                Case 4
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Porcentagem, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Valor, 2), 8, True))
                    ListView1.Items(3).SubItems.Add(numeroLatino(Math.Round(INSStabela(0).Class_INSSfaixa4Acumulado, 2), 8, True))

            End Select

        Next

        LblTabelaNumero.Text = INSStabela(0).Class_INSS_numero
        LblDataAtivacao.Text = dataLatina(INSStabela(0).Class_INSS_dataInicio)
        LblDataDesativacao.Text = IIf(DateTime.MinValue = INSStabela(0).Class_INSS_dataFim, DateTime.MinValue, dataLatina(INSStabela(0).Class_INSS_dataFim))
        LblTabelaAnterior.Text = ""
        LblTabelaPosterior.Text = ""
        LblDigitacaoData.Text = INSStabela(0).Class_INSSdataCriacao
        LblDigitacaoOperadorChave.Text = INSStabela(0).Class_INSSresponsavelDigitacao & " - " & INSStabela(0).Class_INSSresponsavelDigitacaoNome
        LblDigitacaoOperadorTipo.Text = INSStabela(0).Class_INSSresponsavelDigitacaoTipo
        LblConferenciaData.Text = INSStabela(0).Class_INSSdataConferencia
        LblConferenciaAnalistaChave.Text = INSStabela(0).Class_INSSresponsavelConferencia & " - " & INSStabela(0).Class_INSSresponsavelConferenciaNome
        LblConferenciaAnalistaTipo.Text = INSStabela(0).Class_INSSresponsavelConferenciaTipo
        LblLiberacaoData.Text = INSStabela(0).Class_INSSdataPublicação
        LblLiberacaoResponsavelChave.Text = INSStabela(0).Class_INSSresponsavelPublicacao & " - " & INSStabela(0).Class_INSSresponsavelPublicacaoNome
        LblLiberacaoResponsavelTipo.Text = INSStabela(0).Class_INSSresponsavelPublicacaoTipo
        LblLiberacaoData.Text = INSStabela(0).Class_INSSdataPublicação

    End Function

    Private Sub BtnSelecao_Click(sender As Object, e As EventArgs) Handles BtnSelecao.Click




        If ListSelecao.SelectedIndex <> -1 Then

            Dim itemSelected As String = ListSelecao.SelectedItem.ToString()
            INSS_mostra_tabela(itemSelected)
            GroupEscolhaTabela.Visible = False
            GrpInterruptor(True)


        End If

    End Sub

    Private Function GrpInterruptor(IsLed As Boolean)

        GroupPainelDePesquisa.Enabled = IsLed
        GroupIdentificacaoDaTabela.Enabled = IsLed
        GroupTabelaShow.Enabled = IsLed

    End Function

End Class