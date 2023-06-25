Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class FrmCartaoInclusao
    Dim oi As New MsgShow

    Private Sub Btotermina_Click(sender As Object, e As EventArgs) Handles Btotermina.Click

        With oi
            .Msg = "Confirma A Saída da tela  "
            .Style = vbYesNo + vbQuestion + vbDefaultButton1
            .Resposta = MsgBox(.Msg, .Style, .Title)
            If .Resposta <> 6 Then
                Me.Close()
            End If

        End With

    End Sub

    Private Sub BtoLimpa_Click(sender As Object, e As EventArgs) Handles BtoLimpa.Click

        LimpaCartao()

    End Sub

    Function LimpaCartao()

        CmbBandeira.Text = ""
        MskNumero.Text = ""
        TxtResponsavel.Text = ""
        TxtNomeImpresso.Text = ""
        MskValidade.Text = ""
        MskSeguranca.Text = ""
        MskFatura.Text = ""

    End Function

    Private Sub BtoGrava_Click(sender As Object, e As EventArgs) Handles BtoGrava.Click

        Dim strTeste As String = VerificaCamposCartao()

        If strTeste <> "" Then

            With oi
                .Msg = strTeste
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If

        With oi
            .Msg = "Confirma A Gravação "
            .Style = vbYesNo + vbQuestion + vbDefaultButton1
            .Resposta = MsgBox(.Msg, .Style, .Title)
            If .Resposta <> 6 Then
                .Msg = "Gravação não Efetivada "
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End If

        End With


        If OpenDB() Then

            Dim Query As String

            Query = "Insert Into cartao "
            Query += "("
            Query += "bandeira"
            Query += ",Numero"
            Query += ",Responsavel"
            Query += ",nome_impresso"
            Query += ",Validade"
            Query += ",fatura"
            Query += ",codSeg"
            Query += ",Banco"
            Query += ",agencia"
            Query += ",agencia_dg"
            Query += ",conta_corrente"
            Query += ",conta_corrente_dg"
            Query += ")"
            Query += " values "
            Query += "("
            Query += "'" & CmbBandeira.Text & "'"
            Query += ",'" & MskNumero.Text & "'"
            Query += ",'" & TxtResponsavel.Text & "'"
            Query += ",'" & TxtNomeImpresso.Text & "'"
            Query += ",'" & MskValidade.Text & "'"
            Query += "," & MskFatura.Text
            Query += ",'" & MskSeguranca.Text & "'"
            Query += ",''"
            Query += ",''"
            Query += ",''"
            Query += ",''"
            Query += ",''"
            Query += ")"

            If gravaSQL(Query) Then

                With oi
                    .Msg = "Gravação Realizada com sucesso"
                    .Style = vbExclamation
                    MsgBox(.Msg, .Style, .Title)

                    LimpaCartao()

                End With

                Exit Sub

            Else
                With oi
                    .Msg = "Gravação não Realizada "
                    .Msg += Chr(13) & Chr(13) & "Caso não consiga fazer a gravação contate seu supervisor "
                    .Style = vbExclamation
                    MsgBox(.Msg, .Style, .Title)
                End With

            End If



        End If

    End Sub

    Private Function VerificaCamposCartao() As String

        Dim StrErro As String = ""

        If Trim(CmbBandeira.Text) = "" Then



            StrErro = "Bandeira Inválida ! "

        End If

        If Len(Trim(Replace(MskNumero.Text, "-", ""))) < 16 Then

            If StrErro = "" Then

                StrErro = "Número do cartão Inválido ! "

            Else

                StrErro += Chr(13) & "Número do cartão Inválido ! "

            End If

        End If

        If Trim(TxtResponsavel.Text) = "" Then

            If StrErro = "" Then

                StrErro = "Responsável Inválido ! "

            Else

                StrErro += Chr(13) & "Responsável Inválido ! "

            End If

        End If

        If Trim(TxtNomeImpresso.Text) = "" Then

            TxtNomeImpresso.Text = TxtResponsavel.Text

        End If


        Dim IntMes As Integer
        Dim IntAno As Integer

        IntMes = IIf(Trim(MskValidade.Text.Substring(0, 2)) = "", 0, MskValidade.Text.Substring(0, 2))
        IntAno = IIf(Len(MskValidade.Text) > 3, MskValidade.Text.Substring(3), 0)

        If (IntMes > 12 Or IntMes < 1) Or (IntAno < 23) Then

            If StrErro = "" Then

                StrErro = "Validade do cartão Errada ! "

            Else

                StrErro += Chr(13) & "Validade do cartão Errada ! "

            End If

        End If


        If Trim(MskSeguranca.Text) = "" Then

            If StrErro = "" Then

                StrErro = "Código de seguraça inválido ! "

            Else

                StrErro += Chr(13) & "Código de seguraça inválido ! "

            End If

        End If

        Dim IntDiaFatura As Integer

        If Trim(MskFatura.Text) = "" Then

            IntDiaFatura = 0

        Else

            IntDiaFatura = Int(MskFatura.Text)

        End If


        If IntDiaFatura = 0 Or IntDiaFatura > 28 Then

            If StrErro = "" Then

                StrErro = "Dia da fatura inválido ! "

            Else

                StrErro += Chr(13) & "Dia da fatura inválido ! "

            End If



        End If

        Dim Query As String

        Query = "select count(*) from cartao where numero = '" & MskNumero.Text & "'"

        If ApontaSQL(Query) > 0 Then


            If StrErro = "" Then

                StrErro = "Número de cartão já cadastrado ! "

            Else

                StrErro += Chr(13) & "Número de cartão já cadastrado !"

            End If

        End If

        If StrErro <> "" Then

            StrErro += Chr(13) & Chr(13) & "Por Favor corrija as inconsistências apontadas ! "

        End If

        Return (StrErro)

    End Function



    Private Sub frmCartaoInclusao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oi.Title = Me.Text

    End Sub
End Class