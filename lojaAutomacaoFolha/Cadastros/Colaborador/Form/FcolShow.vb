Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Text


Public Class FcolShow


    Private Sub BtnMostraASO_Click(sender As Object, e As EventArgs) Handles BtnMostraASO.Click

        Dim Caminho As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\ASO"

        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)


    End Sub

    Private Sub BtnMostraPis_Click(sender As Object, e As EventArgs) Handles BtnMostraPis.Click

        Dim Caminho As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\PIS"


        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  '' CTPS show

        Dim Caminho As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\CTPS"
        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)


        '       Dim open As New FolderBrowserDialog
        '       open.Description = "Selecionar Pasta de imagens"
        ''      open.RootFolder = Environment.SpecialFolder.CommonPictures
        '       If open.ShowDialog = DialogResult.OK Then
        '           MsgBox(open.SelectedPath)
        '    '      CarregaImagens(open.SelectedPath)
        '           CarregaImagens(caminho)
        '       End If
        '       MsgBox(strImagens.Length)

    End Sub

    Private Sub BtnTitulo_Click(sender As Object, e As EventArgs) Handles BtnTitulo.Click

        Dim Caminho As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\titulo"
        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub BtnMostraRG_Click(sender As Object, e As EventArgs) Handles BtnMostraRG.Click

        Dim Caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\rg"


        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub BtnMostraCNH_Click(sender As Object, e As EventArgs) Handles BtnMostraCNH.Click

        Dim Caminho As String = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\cnh"

        If Not System.IO.Directory.Exists(Caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(Caminho)

    End Sub

    Private Sub BtnMostraReservista_Click(sender As Object, e As EventArgs) Handles BtnMostraReservista.Click
        Dim Caminho As String
        Dim arquivo As String


        ' verificação da existência do arquivo
        Caminho = "C:\" & Form1.EmpCNPJ.Text & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Documentos\reservista\reservista01.jpeg"



        'If Not System.IO.File.Exists(Application.StartupPath & Caminho) Then

        If Not System.IO.File.Exists(Caminho) Then

            arquivo = False
            MsgBox("Arquivo não está disponivel")

        Else
            FdocMostra.Show()
            FdocMostra.PictureBox1.Image = Image.FromFile(Caminho)

        End If
    End Sub
    Private strImagens(100) As String
    Private intContador As Integer = 0
    Private Sub BtoMostraFicha_Click(sender As Object, e As EventArgs) Handles BtoMostraFicha.Click

        Dim caminho As String = "C:\" & LimpaNumero(Form1.empCNPJ.Text) & "\folha\colaborador\" & CPFretiraMascara(lblCPF.Text) & "\Contrato\FichaDeInteresse"
        If Not System.IO.Directory.Exists(caminho) Then

            MsgBox("Arquivo não está disponivel")

            Exit Sub

        End If

        colIlustra(caminho)

        'Dim open As New FolderBrowserDialog
        'open.Description = "Selecionar Pasta de imagens"
        ''open.RootFolder = Environment.SpecialFolder.CommonPictures
        'If open.ShowDialog = DialogResult.OK Then
        '    MsgBox(open.SelectedPath)
        '    'CarregaImagens(open.SelectedPath)
        'CarregaImagens(caminho)
        'End If
        'MsgBox(strImagens.Length)

    End Sub
    Sub CarregaImagens(ByVal pasta As String)
        strImagens = Directory.GetFiles(pasta, "*.jpeg")
    End Sub
    Private Sub ColIlustra(caminho As String)

        CarregaImagens(caminho)

        If strImagens.Length = 0 Then

            MsgBox("Tipo de documento não digitalizado !")

            Exit Sub

        End If

        FcolDocSel.Show()

        For i = 0 To strImagens.Length - 1
            Select Case i

                Case 0
                    FcolDocSel.PictureT0.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT00.Text = strImagens(i)
                Case 1
                    FcolDocSel.PictureT1.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT01.Text = strImagens(i)
                Case 2
                    FcolDocSel.PictureT2.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT02.Text = strImagens(i)
                Case 3
                    FcolDocSel.PictureT3.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT03.Text = strImagens(i)
                Case 4
                    FcolDocSel.PictureT4.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT04.Text = strImagens(i)
                Case 5
                    FcolDocSel.PictureT5.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT05.Text = strImagens(i)
                Case 6
                    FcolDocSel.PictureT6.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT06.Text = strImagens(i)
                Case 7
                    FcolDocSel.PictureT7.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT07.Text = strImagens(i)
                Case 8
                    FcolDocSel.PictureT8.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT08.Text = strImagens(i)
                Case 9
                    FcolDocSel.PictureT9.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT09.Text = strImagens(i)
                Case 10
                    FcolDocSel.PictureT10.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT10.Text = strImagens(i)
                Case 11
                    FcolDocSel.PictureT11.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT11.Text = strImagens(i)
                Case 12
                    FcolDocSel.PictureT12.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT12.Text = strImagens(i)
                Case 13
                    FcolDocSel.PictureT13.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT13.Text = strImagens(i)
                Case 14
                    FcolDocSel.PictureT14.Image = Image.FromFile(strImagens(i))
                    FcolDocSel.LblT14.Text = strImagens(i)
            End Select


        Next
    End Sub

    Private Sub FcolShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnRetorna_Click(sender As Object, e As EventArgs) Handles btnRetorna.Click
        Me.Close()
    End Sub

    Private Sub BtoIMC_Click(sender As Object, e As EventArgs) Handles BtoIMC.Click
        Dim peso As Decimal
        Dim altura As Decimal
        Dim resultado As Decimal
        Dim PesoEsperado As Decimal
        Dim excessoPeso As Decimal = 0

        If col_10peso.Text = "" Then
            MsgBox("Peso invalido!")
            col_10peso.Focus()
            Exit Sub
        Else
            peso = CDec(col_10peso.Text)
        End If

        If Trim(col_10altura.Text) = "" Then
            MsgBox("Altura invalida!")
            col_10altura.Focus()
            Exit Sub
        Else
            altura = CDec(Replace(col_10altura.Text, ":", ","))
        End If

        resultado = Int((peso / (altura * altura)) * 100) / 100
        LabelIMCcalculado.Text = "IMC = " + CStr(resultado)

        If resultado > 24.9 Then

            PesoEsperado = 24.9 * (altura * altura)

            excessoPeso = peso - PesoEsperado
            labelexcessoPeso.Visible = True
            labelexcessoPeso.Text = "Excesso: " + CStr(Int(excessoPeso * 100) / 100) + "K"
        Else
            labelexcessoPeso.Visible = False

        End If


    End Sub

    Private Sub BtnImprime_Click(sender As Object, e As EventArgs) Handles BtnImprime.Click
        Dim TLcol As List(Of colaborador) = ColaboradorCapTela.GetColaboradorTelaPesquisa()  ' TELA de pesquisa


        Dim caminho As String = "C:\Users\paulo\text.txt"
        'verifica se o arquivo existe
        If File.Exists(caminho) Then
            File.Delete(caminho)
        End If
        Using sw As StreamWriter = New StreamWriter(caminho, True)
            sw.WriteLine("Relatório de Colaboradores - Conferência")
            sw.WriteLine("")
            sw.WriteLine("I D E N T I F I C A Ç Ã O")
            sw.WriteLine("-------------------------")
            sw.WriteLine("Nome_______: " & TLcol(0).Nome)
            sw.WriteLine("CPF   _____: " & TLcol(0).CPF)
            sw.WriteLine("Chave _____: " & TLcol(0).Chave.PadLeft(4, "0"))
            sw.WriteLine("Nascimento : " & TLcol(0).Nascimento)
            sw.WriteLine("Contrato Ativo :")
            sw.WriteLine("")
            sw.WriteLine("D O C U M E N T A Ç Ã O")
            sw.WriteLine("-----------------------")
            sw.WriteLine(Space(35) & "Orgão Exp   UF  Emissão     Validade")
            sw.WriteLine("RG ________: " & espacoEsquerda(TLcol(0).rg, 22, 1) & espacoEsquerda(TLcol(0).rgOE, 12, 1) & espacoEsquerda(TLcol(0).rgOEuf, 4, 1) & espacoEsquerda(TLcol(0).rgEmissao, 12, 1) & espacoEsquerda(TLcol(0).rgValidade, 12, 1))
            sw.WriteLine("CNH _______: " & espacoEsquerda(TLcol(0).cnh, 22, 1) & espacoEsquerda(TLcol(0).cnhOE, 12, 1) & espacoEsquerda(TLcol(0).cnhOEuf, 4, 1) & espacoEsquerda(TLcol(0).cnhEmissao, 12, 1) & espacoEsquerda(TLcol(0).cnhValidade, 4, 1))
            sw.WriteLine("CTPS ______: " & TLcol(0).CTPS)
            sw.WriteLine("RESERVISTA : " & TLcol(0).reser)
            sw.WriteLine("PIS _______: " & TLcol(0).PIS)
            sw.WriteLine("TITULO ____: " & espacoEsquerda(TLcol(0).te, 22, 1) & espacoEsquerda(TLcol(0).teOE, 12, 1) & espacoEsquerda(TLcol(0).teOEuf, 4, 1) & espacoEsquerda(TLcol(0).teEmissao, 12, 1) & espacoEsquerda(TLcol(0).teValidade, 12, 1))
            sw.WriteLine("Zona/Seção : " & TLcol(0).teZona & "/" & TLcol(0).teSecao)

            sw.WriteLine("")
            sw.WriteLine("F I L I A Ç Ã O")
            sw.WriteLine("---------------")
            sw.WriteLine("Nome da Mãe: " & TLcol(0).Mae)
            sw.WriteLine("CPF _______: " & TLcol(0).MaeCPF)
            sw.WriteLine("Nascimento_: " & TLcol(0).MaeNascimento)
            sw.WriteLine("Telefone __: " & TLcol(0).MaeFone)
            sw.WriteLine("Nome do Pai: " & TLcol(0).pai)
            sw.WriteLine("CPF _______: " & TLcol(0).paiCPF)
            sw.WriteLine("Nascimento_: " & TLcol(0).paiNascimento)
            sw.WriteLine("Telefone __: " & TLcol(0).paiFone)
            sw.WriteLine("")
            sw.WriteLine("P E S S O A L")
            sw.WriteLine("-------------")
            sw.WriteLine("Estado Civil: " & TLcol(0).EstadoCivil)
            sw.WriteLine("C O N T A T O")
            sw.WriteLine("---------------")
            sw.WriteLine("E N D E R E Ç O")
            sw.WriteLine("---------------")
            sw.WriteLine("E S C O L A R I D A D E")
            sw.WriteLine("---------------")
            sw.WriteLine("I M A G E N S")
            sw.WriteLine("---------------")
            sw.WriteLine("F I N A N C E I R O")
            sw.WriteLine("---------------")
            sw.WriteLine("D E P E N D E N T E S")
            sw.WriteLine("---------------")
            sw.WriteLine("C O M P L E M E N T O")
            sw.WriteLine("---------------")
            sw.WriteLine("R E F E R Ê N C I A S")
            sw.WriteLine("---------------")
            sw.WriteLine("I D  -  I N T E R N O")
            sw.WriteLine("---------------")
            sw.WriteLine()
            sw.WriteLine("SPIAL sistemas Ltda")

        End Using
        Shell("NotePad.Exe ""C:\Users\paulo\text.txt""")
    End Sub
    'Private Shared Function ExecutaComando(pComando As String, pParametros As String) As String
    '    Dim _ret As String = ""

    '    Dim procShell As New Process()

    '    'Seu comando vai aqui.
    '    procShell.StartInfo.FileName = pComando

    '    'Os argumentos, aqui.
    '    procShell.StartInfo.Arguments = pParametros

    '    procShell.StartInfo.CreateNoWindow = True
    '    procShell.StartInfo.RedirectStandardOutput = True
    '    procShell.StartInfo.UseShellExecute = False
    '    procShell.StartInfo.RedirectStandardError = True
    '    procShell.Start()

    '    Dim streamReader As New StreamReader(procShell.StandardOutput.BaseStream, procShell.StandardOutput.CurrentEncoding)

    '    Do
    '        Dim _line As String = streamReader.ReadLine()
    '        If (IsNothing(_line)) Then Exit Do
    '        _ret = _ret + _line + vbCrLf
    '    Loop

    '    streamReader.Close()

    '    Return _ret

    'End Function

End Class