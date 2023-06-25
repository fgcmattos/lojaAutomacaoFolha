

Public Class FrmFornecedorCad
    Public oi As New MsgShow
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GrpEmpresaAtributos.Enter

    End Sub

    Private Sub FrmFornecedorCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Query As String = "Select UFsigla from uf order by UFsigla"
        Dim objCombo As Object = CmbUF
        CmbUF = ClassAponta_DB_acao.GetApontaDB(Query, objCombo)

        Query = "Select Emp_tipo_fiscal_Nome from emp_tipo_fiscal order by Emp_tipo_fiscal_Key"
        objCombo = CmbTipoFiscal
        CmbTipoFiscal = ClassAponta_DB_acao.GetApontaDB(Query, objCombo)

    End Sub

    Private Sub TxtRazaoSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRazaoSocial.KeyPress

        Dim StrChar As String = e.KeyChar

        If StrChar = Convert.ToChar(13) Then

            'Dim BolChek As Boolean = True

            e.KeyChar = ""

            If Len(Trim(TxtRazaoSocial.Text)) < 10 Then

                With oi
                    .title = Me.Text
                    .style = vbExclamation
                    .msg = "Razão da Empresa menor do que 10 digitos" & Chr(13) & Chr(13) & "Enttre com nome Razão Válido"
                    MsgBox(.msg, .style, .title)
                End With
                TxtRazaoSocial.Focus()

                Exit Sub

            End If

            BtnInicia.Enabled = True

            TxtRazaoSocial.Enabled = False : LabelRazaoSocial.Visible = False : LblIniciar.Visible = True : BtnInicia.Focus()


            Exit Sub

        End If

        If StrChar = Convert.ToChar(27) Then

            e.KeyChar = ""

            Me.Close()

        End If
    End Sub

    Private Sub BtnInicia_Click(sender As Object, e As EventArgs) Handles BtnInicia.Click
        LblIniciar.Visible = False
        GrpEmpresaAtributos.Enabled = True
        TxtRazaoFantasia.Focus()
        GrpIdentifica.Enabled = False

    End Sub
    Private Sub BtnInicia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnInicia.KeyPress
        Dim StrChar As String = e.KeyChar

        e.KeyChar = ""

        If StrChar = Convert.ToChar(27) Then

            LabelRazaoSocial.Visible = True

            LblIniciar.Visible = False

            TxtRazaoSocial.Enabled = True

            BtnInicia.Enabled = False

            TxtRazaoSocial.Focus()

        End If

    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click

        Select Case FornecedorCriticaTela()
            Case 1
                TxtRazaoFantasia.Focus()

                Exit Sub
            Case 2

                CmbTipoFiscal.Focus()

                Exit Sub
            Case 3

                TxtEndereco.Focus()

                Exit Sub
            Case 4

                CbxAtuacaoServico.Focus()

                Exit Sub
            Case 5

                TxtInscricaoEstadual.Focus()

                Exit Sub
            Case 6

                TxtInscricaoMunicipal.Focus()

                Exit Sub
            Case 7

                TxtCidade.Focus()

                Exit Sub

        End Select


        'Dim objTelaFornecedor As List(Of ClassFornecedor) = ClassFornecedorAcao.FornecedorCarregaTela()
        Dim StrRetorno As String = "Gravação Realizada com sucesso !"

        If Not ClassFornecedorAcao.FornecedorGravaObjDB() Then


            StrRetorno = "Gravação não Realizada !"

            With oi
                .Msg = StrRetorno
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With
        Else
            With oi
                .Msg = StrRetorno
                .Style = vbExclamation
                MsgBox(.Msg, .Style, .Title)
            End With

            Me.Close()
        End If
    End Sub

    Private Function FornecedorCriticaTela() As Integer

        Dim IntRetorno As Integer = 0

        If Trim(TxtRazaoFantasia.Text) = "" Then
            With oi
                .Title = Me.Text
                .Style = vbYesNo + vbQuestion + vbDefaultButton1
                .Msg = "Razão Fantasia não informada " & Chr(13) & Chr(13) & "Deseja informar"
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then

                    IntRetorno = 1

                    Return (IntRetorno)

                    Exit Function

                End If

            End With
        End If

        If Trim(CmbTipoFiscal.Text) = "" Then

            With oi
                .title = Me.Text
                .style = vbExclamation + vbDefaultButton1
                .msg = "Tipo Fiscal não selecionado " & Chr(13) & Chr(13) & "Por favor selecione um dos disponiveis no Combo"
                .resposta = MsgBox(.msg, .style, .title)

                IntRetorno = 2

                Return (IntRetorno)

                Exit Function

            End With

        End If

        If Trim(TxtInscricaoEstadual.Text) = "" Then

            With oi
                .Title = Me.Text
                .Style = vbYesNo + vbQuestion + vbDefaultButton1
                .Msg = "Inscrição Estadual não Digita " & Chr(13) & Chr(13) & "Aceita entrada"
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then

                    TxtInscricaoEstadual.Text = "000000000"

                Else

                    IntRetorno = 5

                End If



                Return (IntRetorno)

                Exit Function

            End With

        End If

        If Trim(TxtInscricaoMunicipal.Text) = "" Then

            With oi
                .Title = Me.Text
                .Style = vbYesNo + vbQuestion + vbDefaultButton1
                .Msg = "Inscrição Municipal não Digita " & Chr(13) & Chr(13) & "Aceita entrada"
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then

                    TxtInscricaoMunicipal.Text = "000000000"

                Else

                    IntRetorno = 6

                End If



                Return (IntRetorno)

                Exit Function

            End With

        End If

        If Trim(TxtEndereco.Text) = "" Then

            With oi
                .title = Me.Text
                .style = vbYesNo + vbQuestion + vbDefaultButton1
                .msg = "Endereço não Digitado " & Chr(13) & Chr(13) & "Aceita entrada"
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then

                    TxtEndereco.Text = "Endereço desconhecido"
                    TxtEnderecoNumero.Text = "S/N"
                    TxtEnderecoComplemento.Text = "Sem Complemento"
                    MskCEP.Text = "00000-000"

                Else

                    IntRetorno = 3

                End If



                Return (IntRetorno)

                Exit Function

            End With

        End If

        If Trim(TxtCidade.Text) = "" Then

            With oi
                .Title = Me.Text
                .Style = vbYesNo + vbQuestion + vbDefaultButton1
                .Msg = "Cidade não Digita " & Chr(13) & Chr(13) & "Aceita entrada"
                .Resposta = MsgBox(.Msg, .Style, .Title)
                If .Resposta = 6 Then

                    TxtCidade.Text = "Cidade Desconhecida"

                Else

                    IntRetorno = 7

                End If



                Return (IntRetorno)

                Exit Function

            End With

        End If

        If Not (CbxAtuacaoServico.Checked Or CbxAtuacaoComercio.Checked Or CbxAtuacaoIndustria.Checked) Then

            With oi
                .Title = Me.Text
                .Style = vbExclamation + vbDefaultButton1
                .Msg = "Tipo Atuação da empresa não definido " & Chr(13) & Chr(13) & "Por favor selecione uma ou mais Atuações do Fornecedor (Serviço, Comercio ou Industria)"
                .Resposta = MsgBox(.Msg, .Style, .Title)

                IntRetorno = 4

                Return (IntRetorno)

                Exit Function

            End With

        End If

        'TxtEnderecoNumero
        'TxtEnderecoComplemento
        'MskCEP
        'TxtCidade
        'TxtUsuarioNome
        'CmbUF
        'MskTelefone
        'MskTelefone2
        'MskCelular
        'TxtEmail
        'TxtSite
        'TxtComercialContato
        'MskComercialFone
        'MskGerADM
        'MskGerADMfone


    End Function
End Class