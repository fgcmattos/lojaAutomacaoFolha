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

        query = "select * from cartao"

        If CmbBandeiraPesq.Text <> "" Then

            'If Not cond Then

            query += " where "

            cond = True

            'Else

            'query += ","

            'End If

            query += "bandeira like '" & Trim(CmbBandeiraPesq.Text) & "%'"


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

        Elementos = ct.Count

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
    Function cartaoLimpar()

        CmbBandeira.Text = ""
        MskNumero.Text = ""
        MskValidade.Text = ""
        MskSeguranca.Text = ""
        MskFatura.Text = ""

    End Function

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
End Class