Imports MySql.Data.MySqlClient
Public Class frmFolhaRescisaoDestratoGravacao

    Private Sub frmFolhaRescisaoDestratoGravacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Public Shared Function GetApontaDB() As List(Of Aponta)

    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        ' necessario verificar se a tabela folha_col_contrato registra o colabarador

        Dim strReferencia As String = MskKeyCod.Text
        Dim contrato As List(Of FolhaColContrato) = FolhaColContratoAcao.GetEmpregadorFolhaColContratoRescisaoAviso(strReferencia)


        Dim strCaminho As String = ""

        If Trim(strReferencia) = "" Then

            Exit Sub

        End If

        strCaminho = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & contrato(0).colaboradorCpf & "\Foto\Cracha\Cracha.jpg"

        If System.IO.File.Exists(strCaminho) Then

            Me.PictureBox1.Image = Image.FromFile(strCaminho)

        End If


        Dim strCNPJsindical As String = contrato(0).CNPJEntidadeSindical
        'If Len(strCNPJsindical) > 70 Then

        '    strCNPJsindical = strCNPJsindical.Substring(0, 70) & Chr(13) & strCNPJsindical.Substring(70)

        'End If

        LblColaborador.Text = contrato(0).Colaborador
        LblCategoria.Text = contrato(0).Categoria & ". " & contrato(0).Categoriadescricao
        LblTipoDoContrato.Text = contrato(0).ContratoTipo & ". " & contrato(0).ContratoTipoDescricao
        LblCodigoSindical.Text = contrato(0).SindicalCodigo
        LblCNPJsindical.Text = strCNPJsindical
        LblDataAdmissao.Text = dataLatina(contrato(0).AdmissaoData)
        LblCargoAtual.Text = contrato(0).ColaboradorCargo
        LblSalarioAtual.Text = MoneyLatino(contrato(0).RemuneracaoAtual)
        Dim agenda As List(Of Aponta) = ApontaAcoes.GetApontaDB()
        LblTempoEmpresa.Text = TempoEntreDatas(LblDataAdmissao.Text, dataLatina(agenda(0).Data))

        ' tipos de Destratos para o contrato
        CmbTipoDeAcordo.Items.Clear()

        Dim Query As String = "select * from folha_col_contrato_afastamento where FCA_tipo_contrato_atendido=" & contrato(0).ContratoTipo
        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then

            Try

                DTReader = CMD.ExecuteReader
                While DTReader.Read()


                    CmbTipoDeAcordo.Items.Add(DTReader(1) & " - " & DTReader(2))

                End While

            Catch ex As Exception

                MsgBox("Problemas ApontaAcoes!")

            End Try

        End If

        Conn.Close()

    End Sub

    Private Sub MskDataAviso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskDataAviso.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            Dim agenda As List(Of Aponta) = ApontaAcoes.GetApontaDB()
            Dim strDataAviso As String = MskDataAviso.Text
            Dim datData As Date

            If Trim(Replace(strDataAviso, "/", "")) = "" Then

                MskDataAviso.Text = dataLatina(agenda(0).Data)

                Exit Sub

            End If

            Try

                datData = DateAdd("m", 1, strDataAviso)




            Catch ex As Exception

                MsgBox("Data Invalida!")

            End Try




        End If

    End Sub

    Private Sub MskAfastamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskAfastamento.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            Dim agenda As List(Of Aponta) = ApontaAcoes.GetApontaDB()
            Dim strDataAfastamento As String = MskAfastamento.Text
            Dim datData As Date

            If Trim(Replace(strDataAfastamento, "/", "")) = "" Then

                If CheckBox1.Checked Then

                    datData = Convert.ToDateTime(MskDataAviso.Text)

                    datData = DateAdd("d", 30, datData)

                    MskAfastamento.Text = datData

                Else

                    MskAfastamento.Text = MskDataAviso.Text

                End If

                Exit Sub

            End If

            Try

                datData = DateAdd("m", 1, strDataAfastamento)


            Catch ex As Exception

                MsgBox("Data Invalida!")

            End Try

            If DateDiff("d", MskDataAviso.Text, MskAfastamento.Text) < 0 Then

                MsgBox("Data Invalida!" + Chr(13) + "Data do Aviso não pode ser superior a Data do Afastamento")

            End If

            datData = Convert.ToDateTime(strDataAfastamento)

            datData = DateAdd("d", 10, datData)

            MskDataFatalAcerto.Text = Convert.ToString(datData)

        End If
    End Sub



    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click
        Dim Query As String = ""

        Query = "Update folha_col_contrato set "
        Query += "FCC_afastamentoDescricao = '" & CmbTipoDeAcordo.Text.Substring(6) & "'"
        Query += ",FCC_remuneracaoMesAnterior =" & MoneyUSA(LblSalarioAtual.Text)           ' FCC_remuneracaoMesAnterior.    
        Query += ",FCC_avisoPrevio_data = '" & dataAAAAMMDD(MskDataAviso.Text) & "'"         ' FCC_avisoPrevio_data          
        Query += ",FCC_afastamento_data = '" & dataAAAAMMDD(MskAfastamento.Text) & "'"       ' FCC_afastamento_data         
        Query += ",FCC_afastamentoCodigo = '" & CmbTipoDeAcordo.Text.Substring(0, 4) & "'"   ' FCC_afastamentoCodigo         
        Query += ",FCC_pensaoAlimenticiaTRCT = 0.00"
        Query += ",FCC_pensaoAlimenticiaFGTS = 0.00"
        Query += ",FCC_status =1"
        Query += " where "
        Query += "FCC_keycol = " & MskKeyCod.Text
        Query += " and "
        Query += "FCC_status = 0"
        Dim CMD As New MySqlCommand(Query, Conn)
        Dim DTReader As MySqlDataReader

        If OpenDB() Then
            Try

                DTReader = CMD.ExecuteReader
                DTReader.Read()



            Catch ex As Exception

                MsgBox("Problemas Na Gravacao do contrato!")

            End Try

            Conn.Close()

        End If

    End Sub
End Class