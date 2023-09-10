Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmCartaoManutencao
    Private Sub Btotermina_Click(sender As Object, e As EventArgs) Handles Btotermina.Click
        Me.Close()
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        Dim query As String
        Dim cond As Boolean = False

        query = "select "
        query += "idcartao"                             ' 0
        query += ",bandeira"                            ' 1
        query += ",Numero"                              ' 2
        query += ",Responsavel"                         ' 3
        query += ",nome_impresso"                       ' 4
        query += ",Validade"                            ' 5
        query += ",fatura"                              ' 6
        query += ",codSeg"                              ' 7
        query += ",Banco"                               ' 8
        query += ",agencia"                             ' 9
        query += ",agencia_dg"                          '10 
        query += ",conta_corrente"                      '11
        query += ",conta_corrente_dg"                   '12
        query += ",ifnull(data_ativação,'')"            '13
        query += ",ifnull(data_desativacao,'')"         '14
        query += " from cartao "

        If CmbBandeiraPesq.Text <> "" Then

            query += " where "

            cond = True

            query += "bandeira Like '" & Trim(CmbBandeiraPesq.Text) & "%'"


        End If

        If Trim(Replace(MskNumeroPesq.Text, "-", "")) <> "" Then

            If Not cond Then

                query += " where "
                cond = True

            Else

                query += " and "

            End If

            query += " numero like '" & Trim(MskNumeroPesq.Text) & "%'"

        End If

        If Trim(Replace(MskVencimentoPesq.Text, "/", "")) <> "" Then
            If Not cond Then
                query += " where "
                cond = True
            Else

                query += " and "

            End If

            query += "validade like '" & Trim(MskVencimentoPesq.Text) & "%'"
        End If

        If MskSegurancaPesq.Text <> "" Then
            If Not cond Then
                query += " where "
                cond = True
            Else

                query += " and "

            End If

            query += " seguranca = '" & Trim(MskSegurancaPesq.Text) & "'"
        End If
        If MskFaturaPesq.Text <> "" Then
            If Not cond Then
                query += " where "
                cond = True
            Else

                query += " and "

            End If

            query += " fatura = " & Trim(MskFaturaPesq.Text)
        End If

        'MsgBox(query)

        Dim ct As List(Of CartaoClass) = CartaoClassRP.Getcartao(query)

        Dim Elementos As Integer

        ListView1.Items.Clear()

        Elementos = ct.Count

        For i As Integer = 0 To Elementos - 1

            With ListView1

                .Items.Add(ct(i).CodInterno)
                .Items(i).SubItems.Add(ct(i).Bandeira)
                .Items(i).SubItems.Add(ct(i).Numero)
                .Items(i).SubItems.Add(ct(i).Responsavel)
                .Items(i).SubItems.Add(ct(i).NomeImpresso)
                .Items(i).SubItems.Add(ct(i).Validade)
                .Items(i).SubItems.Add(ct(i).CodigoSeg)
                .Items(i).SubItems.Add(ct(i).Fatura)
                .Items(i).SubItems.Add(ct(i).Ativacao)
                .Items(i).SubItems.Add(ct(i).Desativacao)
                .Items(i).SubItems.Add(ct(i).Banco)
                .Items(i).SubItems.Add(ct(i).Agencia)
                .Items(i).SubItems.Add(ct(i).Conta)


            End With

        Next


        If Elementos = 0 Then

            MsgBox("Pesquisa Não encontrada na Base de dados!")
            cartaoLimpar()
            Exit Sub

        ElseIf Elementos = 1 Then

            'MsgBox("Apenas Um elemento encontrado")

            'Prencher janela de alteracao
            Lid.Text = ct(0).codInterno
            CmbBandeira.Text = ct(0).bandeira
            MskNumero.Text = ct(0).numero
            MskValidade.Text = ct(0).validade
            MskSeguranca.Text = ct(0).codigoSeg
            MskFatura.Text = ct(0).fatura

        Else

            'MsgBox("Varios elementos encontrado")

            FrmPesquisa.Show()
            FrmPesquisa.Text = "P E S Q U I S A  D E  C A R T Õ E S"
            FrmPesquisa.ListView1.View = View.Details
            FrmPesquisa.ListView1.GridLines = True
            'Dim Mostrar As String = ""

            For i = 0 To elementos - 1


                FrmPesquisa.ListView1.Items.Add(ct.Item(i).codInterno)
                FrmPesquisa.ListView1.Items(FrmPesquisa.ListView1.Items.Count - 1).SubItems.Add((ct(i).bandeira))
                FrmPesquisa.ListView1.Items(FrmPesquisa.ListView1.Items.Count - 1).SubItems.Add((ct(i).numero))
                FrmPesquisa.ListView1.Items(FrmPesquisa.ListView1.Items.Count - 1).SubItems.Add((ct(i).validade))
                FrmPesquisa.ListView1.Items(FrmPesquisa.ListView1.Items.Count - 1).SubItems.Add((ct(i).fatura))
                FrmPesquisa.ListView1.Items(FrmPesquisa.ListView1.Items.Count - 1).SubItems.Add((ct(i).codigoSeg))

            Next

        End If


    End Sub

    Private Sub frmCartaoManutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtoLimpa_Click(sender As Object, e As EventArgs) Handles BtoLimpa.Click

        cartaoLimpar()

    End Sub
    Sub cartaoLimpar()

        CmbBandeira.Text = ""
        MskNumero.Text = ""
        MskValidade.Text = ""
        MskSeguranca.Text = ""
        MskFatura.Text = ""

    End Sub

    Private Sub BtoGrava_Click(sender As Object, e As EventArgs) Handles BtoGrava.Click
        If OpenDB() Then
            Dim query As String
            Dim DTReader As MySqlDataReader
            query = "call cartaoManutencao ('" & CmbBandeira.Text & "','" & MskNumero.Text & "','" & MskValidade.Text & "'," & MskFatura.Text & ",'" & MskSeguranca.Text & "'," & Lid.Text & ",1)"

            Dim CMD As New MySqlCommand(query, Conn)

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()

                MsgBox(DTReader.GetString(0))

            Catch ex As Exception
                MsgBox("Problemas Na Leitura!")
            End Try

            Conn.Close()
            cartaoLimpar()
        End If
    End Sub

    Private Sub GpbPainel_Enter(sender As Object, e As EventArgs) Handles GpbPainel.Enter

    End Sub

    Private Sub CheckBoxAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAtivo.CheckedChanged

        If CheckBoxAtivo.Text = "Ativado" Then

            CheckBoxAtivo.Text = "Desativado"

        Else

            CheckBoxAtivo.Text = "Ativado"

        End If

    End Sub
End Class