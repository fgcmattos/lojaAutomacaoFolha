Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FrmFolhaContratoAtivacao

    Private Sub MskChavePesq_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskChavePesq.MaskInputRejected

    End Sub



    Private Sub MskChavePesq_Validated(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MskChavePesq.Validating
        Dim input As String = MskChavePesq.Text

        If input.Length = 0 Then Exit Sub

        If input.Length < 2 Then
            ' Se o valor digitado for menor que 2 caracteres, está incorreto
            e.Cancel = True
            MessageBox.Show("A entrada deve ter dois caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MskChavePesq.Focus()

        ElseIf Not Char.IsLetter(input(0)) Or Not Char.IsDigit(input(1)) Then
            ' Se o primeiro caractere não for uma letra ou o segundo caractere não for um dígito, está incorreto
            e.Cancel = True
            MessageBox.Show("A entrada deve começar com uma letra seguida de 3 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MskChavePesq.Focus()
            Exit Sub

        End If

        MskChavePesq.Text = MskChavePesq.Text.Substring(0, 1) & MskChavePesq.Text.Replace(" ", "").Substring(1).PadLeft(4, "0"c)

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        Dim StrChave As String = MskChavePesq.Text.Replace(" ", "")
        Dim StrNome As String = TxtNome.Text.Replace(" ", "")
        Dim strCPF As String = CPFretiraMascara(MskCPF_Pesq.Text).Replace(" ", "")

        GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho"
        ListView1.Items.Clear()

        Dim Query As String

        Query = "SELECT "
        Query += "colaborador.chave"
        Query += ",colaboradorNome"
        Query += ",colaboradorcpf"
        Query += ",if(colaboradorContratoAtivo,'ATIVO','INATIVO') as colaboradorContratoAtivo"
        Query += ",IF("
        Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol) IS NULL,0,"
        Query += "(SELECT COUNT(*) FROM folha_col_contrato WHERE colaborador.chave = FCC_keyCol GROUP BY FCC_keyCol)) AS QTO_contratos"
        Query += ",IFNULL("
        Query += "DATE_FORMAT("
        Query += "("
        Query += "SELECT t1.FCC_afastamento_data"
        Query += " FROM folha_col_contrato t1"
        Query += " WHERE t1.FCC_afastamento_data = ("
        Query += "SELECT MAX(t2.FCC_afastamento_data)"
        Query += " FROM folha_col_contrato t2"
        Query += " WHERE t1.FCC_keyCol = t2.FCC_keyCol"
        Query += ")"
        Query += ")"
        Query += ",'%d/%m/%Y')"
        Query += ",'__/__/____'"
        Query += ") AS ultimo_afastamento_data"
        Query += ",ifnull(colaboradorOBS,'')"
        Query += " FROM colaborador"
        Query += " Where "
        Query += " not colaboradorContratoAtivo;"


        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader

                While DTReader.Read()

                    ListView1.Items.Add(DTReader(0))                                        ' Chave
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(1))    ' Colaborador
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(2))    ' CPF
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(3))    ' Status
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(4))    ' QTO de contratos
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(5))    ' Última data de contração
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DTReader(6))    ' OBS

                End While

                GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho [" & ListView1.Items.Count & "]"

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            Conn.Close()

        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class