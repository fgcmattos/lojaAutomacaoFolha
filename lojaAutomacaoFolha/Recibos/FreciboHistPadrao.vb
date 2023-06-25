Imports System.Web.UI.WebControls
Imports Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel
Imports MySql.Data.MySqlClient
Public Class FreciboHistPadrao
    Public strResultado As String
    Public Hrp As List(Of ReciboHist) = ReciboRP.GetReciboHist()                ' Históricos de Recibos Prontos
    Public Dv As List(Of ReciboVariaveis) = ReciboRP.GetReciboVariaveis()       ' Dicionário de Variaveis
    Public oi As New MsgShow

    Private Sub FreciboHistPadrao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oi.title = "Manutenção do Histórico de Recibos"
        LVcarregaHistorico()

        ' Carregamento de orientacoes de preenchimento do historico
        For i = 0 To Dv.Count() - 1

            LvParametros.Items.Add(Dv(i).Codigo)
            LvParametros.Items(i).SubItems.Add(Dv(i).Descricao)
            LvParametros.Items(i).Group = LvParametros.Groups(Dv(i).GrupoListView)

        Next

    End Sub

    Private Sub LViewRecHistPadrao_DoubleClick(sender As Object, e As EventArgs) Handles LViewRecHistPadrao.DoubleClick

        Me.Width = 1300
        Me.Height = 574

        LblCodigo.Text = LViewRecHistPadrao.SelectedItems(0).Text
        TxNome.Text = LViewRecHistPadrao.SelectedItems(0).SubItems(1).Text
        TxFuncao.Text = LViewRecHistPadrao.SelectedItems(0).SubItems(2).Text
        LblResponsavel.Text = LViewRecHistPadrao.SelectedItems(0).SubItems(3).Text
        RtHistorico.Text = LViewRecHistPadrao.SelectedItems(0).SubItems(4).Text

        GrpPlanilhaPesquisa.Enabled = False
        LblEdicao.Visible = True

    End Sub

    Private Sub BtnGravaHistorico_Click(sender As Object, e As EventArgs) Handles BtnGravaHistorico.Click

        Dim indice As Integer = LViewRecHistPadrao.FocusedItem.Index

        If Not reciboHistoricoCompare(indice) Then

            MsgBox("Não foram feitas alterações!")

            Exit Sub

        End If

        If ReciboHistoricoCheck(Trim(RtHistorico.Text), 3) Then

            Dim msg As String
            Dim style As String
            Dim title As String
            Dim ctxt As String
            Dim help As String
            Dim resposta As String
            '---------------------
            msg = strResultado & Chr(13) & Chr(13) & "Confirma alterações "
            style = vbYesNo + vbQuestion + vbDefaultButton1
            title = "Mesa de Edição"
            'help = "folha.hlp"
            'ctxt = 1000

            resposta = MsgBox(msg, style, title)

            If resposta <> 6 Then

                Exit Sub

                RtHistorico.Focus()

            End If

            If OpenDB() Then
                Dim query = Hrp(indice).Grava
                Dim DTReader As MySqlDataReader
                Dim CMD As New MySqlCommand(query, Conn)
                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                Catch ex As Exception
                    MsgBox("Problemas Na Gravação!")
                    Exit Sub
                End Try
                Conn.Close()
            End If

            MsgBox("Gravação realizada com sucesso!", , "Mesa de Edição")

            LblEdicao.Visible = False
            GrpPlanilhaPesquisa.Enabled = True
            limpaTela()
            Hrp.Clear()

            LVcarregaHistorico()

            LblEdicao.Visible = False
            GrpPlanilhaPesquisa.Enabled = True
            limpaTela()
            Me.Width = 772
            Me.Height = 279

            LViewRecHistPadrao.Focus()

        Else

            MsgBox("Erro Na criação de Variaveis !", vbCritical, strResultado)

        End If


    End Sub



    Private Function reciboHistoricoCompare(indice As Integer) As Boolean

        Dim strComando As String = ""

        Dim bolVerifica As Boolean = False

        reciboHistoricoCompare = True

        strResultado = ""

        If Hrp(indice).Nome <> TxNome.Text Then

            strResultado = "Nome Alterado"

            bolVerifica = True

            strComando = "reciboHistPadNome = '" & TxNome.Text & "'"

        End If

        If Hrp(indice).Funcao <> TxFuncao.Text Then

            If strResultado <> "" Then

                strResultado += Chr(13) & "Função Alterado"

            Else

                strResultado += "Função Alterado"

            End If

            bolVerifica = True

            If strComando <> "" Then

                strComando += ","

            End If

            strComando += "recibohistpadUtilidade = '" & TxFuncao.Text & "'"

        End If

        If Hrp(indice).Historico <> RtHistorico.Text Then

            If strResultado <> "" Then

                strResultado += Chr(13) + "Histórico Alterado"

            Else

                strResultado = "Histórico Alterado"

            End If

            bolVerifica = True

            If strComando <> "" Then

                strComando += ","

            End If

            strComando += "reciboHistPadHistorico = '" & RtHistorico.Text & "'"

        End If

        If strComando <> "" Then

            Hrp(indice).Grava = "Update recibohistpad set " & strComando & " where reciboHistPadCod = " & Hrp(indice).codigo

        End If

        reciboHistoricoCompare = bolVerifica

    End Function

    Private Sub BtnCancelaEdicao_Click(sender As Object, e As EventArgs) Handles BtnCancelaEdicao.Click
        Dim indice As Integer = LViewRecHistPadrao.FocusedItem.Index
        'If reciboHistoricoCompare(indice) Then

        Dim msg As String
            Dim style As String
            Dim title As String
            'Dim ctxt As String
            'Dim help As String
            Dim resposta As String
            '---------------------
            msg = "Confirma Cancelamento (Alterações serão abandonadas)?"
            style = vbYesNo + vbQuestion + vbDefaultButton1
            title = "Mesa de Edição"
            'help = "folha.hlp"
            'ctxt = 1000

            resposta = MsgBox(msg, style, title)
        'MsgBox(resposta)
        If resposta = 6 Then
            recVarLimpaTela()
            Exit Sub

        End If
        'End If


    End Sub

    Private Function limpaTela()

        TxNome.Text = ""
        TxFuncao.Text = ""
        RtHistorico.Text = ""

    End Function

    Public Function LVcarregaHistorico()

        Hrp = ReciboRP.GetReciboHist()
        LViewRecHistPadrao.Items.Clear()

        For i = 0 To Hrp.Count() - 1

            LViewRecHistPadrao.Items.Add(Hrp(i).codigo)
            LViewRecHistPadrao.Items(i).SubItems.Add(Hrp(i).Nome)
            LViewRecHistPadrao.Items(i).SubItems.Add(Hrp(i).Funcao)
            LViewRecHistPadrao.Items(i).SubItems.Add(Hrp(i).Responsavel)
            LViewRecHistPadrao.Items(i).SubItems.Add(Hrp(i).Historico)



        Next


    End Function

    Private Function contaString(str As String, frase As String) As Integer

        contaString = 0

        Dim strLetra As String

        For i = 0 To Len(frase) - 1

            strLetra = frase.Substring(i, 1)

            If strLetra = str Then contaString += 1

        Next

    End Function

    Private Sub BtnApaga_Click(sender As Object, e As EventArgs) Handles BtnApaga.Click

        With oi
            .msg = "Confirma a RETIRADA do registro?"
            .style = vbYesNo
            .resposta = MsgBox(.msg, .style, .title)
        End With

        If oi.resposta = 6 Then

            If OpenDB() Then
                Dim query As String = ""

                query = "DELETE FROM recibohistpad WHERE reciboHistPadCod = " & LblCodigo.Text

                Dim DTReader As MySqlDataReader
                Dim CMD As New MySqlCommand(query, Conn)
                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                    With oi
                        .msg = "Registro Retirado da Base com sucesso!"
                        .style = vbExclamation
                        MsgBox(.msg, .style, .title)
                    End With
                Catch ex As Exception

                    With oi
                        .msg = "Gravação não Efetivada! erro DB"
                        .style = vbCritical
                        MsgBox(.msg, .style, .title)
                    End With

                End Try

                Conn.Close()

            End If

            recVarLimpaTela()

            Exit Sub

        End If

    End Sub
    Private Function recVarLimpaTela()

        RtHistorico.Text = ""
        TxFuncao.Text = ""
        TxNome.Text = ""
        LblCodigo.Text = ""


        LViewRecHistPadrao.Items.Clear()
        'atualizar a carga
        LVcarregaHistorico()

        Me.Width = 772
        Me.Height = 279

        LblEdicao.Visible = False
        GrpPlanilhaPesquisa.Enabled = True
        GrpPlanilhaPesquisa.Focus()
    End Function

    Private Sub GrpMesa_Enter(sender As Object, e As EventArgs) Handles GrpMesa.Enter

    End Sub
End Class