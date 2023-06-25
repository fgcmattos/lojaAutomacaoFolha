Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class FrmFolhaContratoDeTrabalhoPesquisa
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Dim StrWhere As String = ""
        Dim booLocal As Boolean = False

        If TxtChavePesquisa.Text <> "" Then
            StrWhere = "where FCC_keyCol = " & TxtChavePesquisa.Text
        Else

            If TxtNomePesquisa.Text <> "" Then
                booLocal = True
                StrWhere = "Where FCC_nome like '%" & Trim(TxtNomePesquisa.Text) & "%'"
            End If

            If CmbSetor.Text <> "" Then

                If booLocal Then

                    StrWhere += " And "

                Else

                    StrWhere += " Where "

                    booLocal = True

                End If

                StrWhere += "FCC_setor = " & CmbSetor.Text.Substring(0, 2)

            End If

            If CmbCargo.Text <> "" Then
                If booLocal Then

                    StrWhere += " And "
                Else
                    StrWhere += " Where "
                    booLocal = True

                End If

                StrWhere += "FCC_Cargo = " & Trim(CmbCargo.Text.Substring(0, 2))
            End If

            If CmbStatus.Text <> "" Then
                If booLocal Then

                    StrWhere += " And "

                Else
                    StrWhere += " Where "
                    booLocal = True

                End If

                StrWhere += "FCC_Status = " & Trim(CmbStatus.Text.Substring(0, 2))

            End If

            If TxtSalario.Text <> "" Then

                If booLocal Then

                    StrWhere += " And "
                Else

                    StrWhere += " Where "

                End If

                StrWhere += "FCC_salario = " & MoneyUSA(TxtSalario.Text)
            End If

        End If

        Dim Query As String = ""
        Query += "Select "

        Query += "FCC_numero"
        Query += ",lPad(FCC_keyCol,4,'0')"
        Query += ",FCC_nome"
        Query += ",FCC_setor"
        Query += ",FCC_cargo"
        Query += ",FCC_status"
        Query += ",FCC_salario"

        Query += " from folha_col_contrato " & StrWhere
        Query += " Order by "
        Query += "FCC_setor"
        Query += ",FCC_cargo"

        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        lvSlecao.Items.Clear()

        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                While DTReader.Read()

                    lvSlecao.Items.Add(DTReader.GetValue(0))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(DTReader.GetValue(3))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(DTReader.GetValue(4))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(DTReader.GetValue(5))
                    lvSlecao.Items(lvSlecao.Items.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(6)))


                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()

        End If


    End Sub

    Private Sub LvSlecao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSlecao.SelectedIndexChanged

    End Sub

    Private Sub LvSlecao_DoubleClick(sender As Object, e As EventArgs) Handles lvSlecao.DoubleClick
        If lvSlecao.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvSlecao.SelectedItems(0)
            Dim selectedText As String = selectedItem.Text
            ' Faça algo com o item selecionado
            MsgBox("Item selecionado: " & selectedText)

            FrmFolhaContratoManutencao.Show()

            Dim CtFolha As List(Of ClassContratoFolha) = ClassContratoFolhaAcao.GetFolhaContratoDB(selectedText)

            ClassContratoFolhaAcao.PutFolhaContratoTL(CtFolha)

        End If
    End Sub

    Private Sub FrmFolhaContratoDeTrabalhoPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ComboCarregar(Me.CmbTipo, "folha_col_contrato_tipo", "concat(FCT_codigo,' - ' , FCT_descricao)", "")

        'ComboCarregar(Me.CmbCategoria, "folha_col_contrato_categoria", "concat(Fcc_Codigo,' - ' , Fcc_descricao)", "")

        ComboCarregar(Me.CmbSetor, "folha_setor", "concat(folha_setor_codigo,' - ',folha_setor_descricao)", "")

        ComboCarregar(Me.CmbCargo, "folha_cargo", "concat(folha_cargo_codigo,' - ',folha_cargo_descricao)", "")

        'ComboCarregar(Me.CmbCBO, "folha_cbo", "concat(folha_cbo_codigo,' - ',folha_cbo_descricao)", "")

    End Sub
End Class