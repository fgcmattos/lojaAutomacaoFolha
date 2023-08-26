Imports MySql.Data.MySqlClient

Public Class ClassFornecedorAcao
    Public Shared Function FornecedorCarregaTela() As List(Of ClassFornecedor)

        Dim lista As New List(Of ClassFornecedor)

        'Dim intTipoFiscal As Integer = Mid(ObjTela.CmbTipoFiscal.Text, 1, 1)

        Try


            lista.Add(New ClassFornecedor() With
                    {
                        .ClassforIdentificacao = CNPJretiraMascara(FrmFornecedorCad.lblCNPJ.Text),
                        .ClassforRazaoSocial = FrmFornecedorCad.TxtRazaoSocial.Text,
                        .ClassforRazaoFantasia = FrmFornecedorCad.TxtRazaoFantasia.Text,
                        .ClassforTipoFiscal = 1,
                        .ClassforTipoFiscalDescricao = FrmFornecedorCad.CmbTipoFiscal.Text,
                        .ClassforEndereco = FrmFornecedorCad.TxtEndereco.Text,
                        .ClassforEndecoNumero = FrmFornecedorCad.TxtEnderecoNumero.Text,
                        .ClassforEnderecoComplemento = FrmFornecedorCad.TxtEnderecoComplemento.Text,
                        .ClassforEnderecoCidade = FrmFornecedorCad.TxtCidade.Text,
                        .ClassforUF = FrmFornecedorCad.CmbUF.Text,
                        .ClassforEnderecoCEP = FrmFornecedorCad.MskCEP.Text,
                        .ClassforFone1 = FrmFornecedorCad.MskTelefone.Text,
                        .ClassforFone2 = FrmFornecedorCad.MskTelefone2.Text,
                        .ClassforCelular = FrmFornecedorCad.MskCelular.Text,
                        .ClassforEmail = FrmFornecedorCad.TxtEmail.Text,
                        .ClassforSite = FrmFornecedorCad.TxtSite.Text,
                        .ClassforInscEstadual = FrmFornecedorCad.TxtInscricaoEstadual.Text,
                        .ClassforInscMunicipal = FrmFornecedorCad.TxtInscricaoMunicipal.Text,
                        .ClassforComercialNome = FrmFornecedorCad.TxtComercialContato.Text,
                        .ClassforComercialNomeTelefone = FrmFornecedorCad.MskComercialFone.Text,
                        .ClassforADMnome = FrmFornecedorCad.MskGerADM.Text,
                        .ClassforADMnomeTelefone = FrmFornecedorCad.MskGerADMfone.Text,
                        .ClassforServico = FrmFornecedorCad.CbxAtuacaoServico.Checked,
                        .ClassforComercio = FrmFornecedorCad.CbxAtuacaoComercio.Checked,
                        .ClassforIndustria = FrmFornecedorCad.CbxAtuacaoIndustria.Checked
                    }
                    )

        Catch ex As Exception

            MsgBox("Problemas Na Leitura da tela do fornecedor! FrmFornecedorCad")

        End Try

        Return lista

    End Function

    Public Shared Function FornecedorGravaObjDB() As Boolean

        Dim objFornecedor As List(Of ClassFornecedor) = ClassFornecedorAcao.FornecedorCarregaTela()

        Dim StrResultado As Boolean

        Dim Query As String

        Query = "Insert into fornecedor "
        Query += "("
        Query += "forKey"
        Query += ",forIdentificacao"
        Query += ",forRazaoSocial"
        Query += ",forRazaoFantasia"
        Query += ",forTipoFiscal"
        Query += ",forTipoFiscalDescricao"
        Query += ",forEndereco"
        Query += ",forEndecoNumero"
        Query += ",forEnderecoComplemento"
        Query += ",forEnderecoCidade"
        Query += ",forUF"
        Query += ",forEnderecoCEP"
        Query += ",forFone1"
        Query += ",forFone2"
        Query += ",forCelular"
        Query += ",forEmail"
        Query += ",forSite"
        Query += ",forServico"
        Query += ",forComercio"
        Query += ",forIndustria"
        Query += ",forComercialNome"
        Query += ",forComercialNomeTelefone"
        Query += ",forADMnome"
        Query += ",forADMnomeTelefone"
        Query += ",forProprietarioNome1"
        Query += ",forProprietarioCPF1"
        Query += ",forProprietarioNome2"
        Query += ",forProprietarioCPF2"
        Query += ",forInscEstadual"
        Query += ",forInscMunicipal"
        Query += ",forUsuarioCadastro"
        Query += ")"
        Query += " values "
        Query += "("
        Query += "'000'"
        Query += ",'" & objFornecedor(0).ClassforIdentificacao & "'"
        Query += ",'" & objFornecedor(0).ClassforRazaoSocial & "'"
        Query += ",'" & objFornecedor(0).ClassforRazaoFantasia & "'"
        Query += "," & objFornecedor(0).ClassforTipoFiscal
        Query += ",'" & objFornecedor(0).ClassforTipoFiscalDescricao & "'"
        Query += ",'" & objFornecedor(0).ClassforEndereco & "'"
        Query += ",'" & objFornecedor(0).ClassforEndecoNumero & "'"
        Query += ",'" & objFornecedor(0).ClassforEnderecoComplemento & "'"
        Query += ",'" & objFornecedor(0).ClassforEnderecoCidade & "'"
        Query += ",'" & objFornecedor(0).ClassforUF & "'"
        Query += ",'" & objFornecedor(0).ClassforEnderecoCEP & "'"
        Query += ",'" & objFornecedor(0).ClassforFone1 & "'"
        Query += ",'" & objFornecedor(0).ClassforFone2 & "'"
        Query += ",'" & objFornecedor(0).ClassforCelular & "'"
        Query += ",'" & objFornecedor(0).ClassforEmail & "'"
        Query += ",'" & objFornecedor(0).ClassforSite & "'"
        Query += "," & objFornecedor(0).ClassforServico
        Query += "," & objFornecedor(0).ClassforComercio
        Query += "," & objFornecedor(0).ClassforIndustria
        Query += ",'" & objFornecedor(0).ClassforComercialNome & "'"
        Query += ",'" & objFornecedor(0).ClassforComercialNomeTelefone & "'"
        Query += ",'" & objFornecedor(0).ClassforADMnome & "'"
        Query += ",'" & objFornecedor(0).ClassforADMnomeTelefone & "'"
        Query += ",'" & objFornecedor(0).ClassforProprietarioNome1 & "'"
        Query += ",'" & objFornecedor(0).ClassforProprietarioCPF1 & "'"
        Query += ",'" & objFornecedor(0).ClassforProprietarioNome2 & "'"
        Query += ",'" & objFornecedor(0).ClassforProprietarioCPF2 & "'"
        Query += ",'" & objFornecedor(0).ClassforInscEstadual & "'"
        Query += ",'" & objFornecedor(0).ClassforInscMunicipal & "'"
        Query += ",'" & objFornecedor(0).ClassforUsuarioCadastro & "'"
        Query += ")"

        StrResultado = gravaSQL(Query)

        Try


        Catch ex As Exception

            MsgBox("Problemas Na Leitura da tela do fornecedor! FrmFornecedorCad")

        End Try

        Return (StrResultado)

    End Function

    Public Shared Sub FornecedorGravaDBobjeto(StrCNPJ As String)

        'Dim objFornecedor As List(Of ClassFornecedor) = ClassFornecedorAcao.FornecedorCarregaTela()

        Dim Query As String

        Query = "select "
        Query += "forKey"                           ' 00
        Query += ",forIdentificacao"                ' 01
        Query += ",forRazaoSocial"                  ' 02
        Query += ",forRazaoFantasia"                ' 03
        Query += ",forTipoFiscal"                   ' 04
        Query += ",forTipoFiscalDescricao"          ' 05
        Query += ",forEndereco"                     ' 06
        Query += ",forEndecoNumero"                 ' 07
        Query += ",forEnderecoComplemento"          ' 08
        Query += ",forEnderecoCidade"               ' 09
        Query += ",forUF"                           ' 10
        Query += ",forEnderecoCEP"                  ' 11
        Query += ",forFone1"                        ' 12
        Query += ",forFone2"                        ' 13
        Query += ",forCelular"                      ' 14
        Query += ",forEmail"                        ' 15
        Query += ",forSite"                         ' 16
        Query += ",forServico"                      ' 17
        Query += ",forComercio"                     ' 18
        Query += ",forIndustria"                    ' 19
        Query += ",forComercialNome"                ' 20
        Query += ",forComercialNomeTelefone"        ' 21
        Query += ",forADMnome"                      ' 22
        Query += ",forADMnomeTelefone"              ' 23
        Query += ",forProprietarioNome1"            ' 24
        Query += ",forProprietarioCPF1"             ' 25
        Query += ",forProprietarioNome2"            ' 26
        Query += ",forProprietarioCPF2"             ' 27
        Query += ",forInscEstadual"                 ' 28
        Query += ",forInscMunicipal"                ' 29
        Query += ",forUsuarioCadastro"              ' 30
        Query += ",forDataCadastro"                 ' 31
        Query += " from fornecedor "
        Query += " Where "
        Query += " forIdentificacao ='" & StrCNPJ & "'"

        Dim DTReader As MySqlDataReader
        Dim CMD As New MySqlCommand(Query, Conn)
        Try

            If OpenDB() Then

                DTReader = CMD.ExecuteReader
                DTReader.Read()



                FrmFornecedorMostra.lblCNPJ.Text = CNPJcolocaMascara(DTReader(1))
                FrmFornecedorMostra.TxtRazaoSocial.Text = DTReader(2)
                FrmFornecedorMostra.TxtRazaoFantasia.Text = DTReader(3)
                FrmFornecedorMostra.CmbTipoFiscal.Text = DTReader(5)
                FrmFornecedorMostra.TxtEndereco.Text = DTReader(6)
                FrmFornecedorMostra.TxtEnderecoNumero.Text = DTReader(7)
                FrmFornecedorMostra.TxtEnderecoComplemento.Text = DTReader(8)
                FrmFornecedorMostra.TxtCidade.Text = DTReader(9)
                FrmFornecedorMostra.CmbUF.Text = DTReader(10)
                FrmFornecedorMostra.MskCEP.Text = DTReader(11)
                FrmFornecedorMostra.MskTelefone.Text = DTReader(12)
                FrmFornecedorMostra.MskTelefone2.Text = DTReader(13)
                FrmFornecedorMostra.MskCelular.Text = DTReader(14)
                FrmFornecedorMostra.TxtEmail.Text = DTReader(15)
                FrmFornecedorMostra.TxtSite.Text = DTReader(16)
                FrmFornecedorMostra.TxtInscricaoEstadual.Text = DTReader(28)
                FrmFornecedorMostra.TxtInscricaoMunicipal.Text = DTReader(29)
                FrmFornecedorMostra.TxtComercialContato.Text = DTReader(20)
                FrmFornecedorMostra.MskComercialFone.Text = DTReader(21)
                FrmFornecedorMostra.MskGerADM.Text = DTReader(22)
                FrmFornecedorMostra.MskGerADMfone.Text = DTReader(23)
                FrmFornecedorMostra.CbxAtuacaoServico.Checked = DTReader(17)
                FrmFornecedorMostra.CbxAtuacaoComercio.Checked = DTReader(18)
                FrmFornecedorMostra.CbxAtuacaoIndustria.Checked = DTReader(19)
                FrmFornecedorMostra.LblCadastradoPor.Text = FrmFornecedorMostra.LblCadastradoPor.Text & DTReader(30)
                FrmFornecedorMostra.LblCadastroData.Text = FrmFornecedorMostra.LblCadastroData.Text & DTReader(31)

                Conn.Close()

            End If



        Catch ex As Exception

            Conn.Close()

            MsgBox("Problemas Na Leitura da tela do fornecedor! FrmFornecedorCad")

        End Try

    End Sub


End Class
