
Imports System.Net.Sockets
Imports System.Text
'Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim Oi As New MsgShow

    ''''''''''''Private client As TcpClient = New TcpClient()
    ''''''''''''Private serverIP As String = "192.168.0.1" ' Insira o endereço IP do servidor aqui
    ''''''''''''Private serverPort As Integer = 80 ' Insira a porta do servidor aqui

    ''''''''''''Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    ''''''''''''    Try
    ''''''''''''        client.Connect(serverIP, serverPort)

    ''''''''''''        Dim stream As NetworkStream = client.GetStream()
    ''''''''''''        Dim buffer As Byte() = New Byte(1023) {}
    ''''''''''''        Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
    ''''''''''''        Dim currentTime As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

    ''''''''''''        'TextBox1.Text = currentTime
    ''''''''''''        form1DataHora.Text = currentTime
    ''''''''''''    Catch ex As Exception
    ''''''''''''        ' Tratar possíveis erros de conexão com o servidor
    ''''''''''''    Finally
    ''''''''''''        If client.Connected Then
    ''''''''''''            client.Close()
    ''''''''''''        End If
    ''''''''''''    End Try
    ''''''''''''End Sub

    Private Sub DesligarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesligarToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub MarcaçãoDePontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaçãoDePontoToolStripMenuItem.Click

        frmFolhaDiarioRelatorio.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        menuGeraOrdem(Me.MenuStrip1) ' recebe um objeto MenuStrip1
        '                              retorna com o campo AccessibleName estruturado 
        MenuTrava(False, Me.MenuStrip1)
        Oi.Title = Me.Text

    End Sub

    Private Sub BaixarFormulariosAbertos()
        Dim formulariosParaFechar As New List(Of Form)
        Dim frm As Form

        For Each frm In Application.OpenForms
            If Not frm Is Me Then
                ' Adicione o formulário à lista de formulários para fechar
                formulariosParaFechar.Add(frm)
            End If
        Next frm

        ' Feche os formulários fora do loop
        For Each frm In formulariosParaFechar
            frm.Close()
        Next frm
    End Sub

    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesteToolStripMenuItem.Click

        testeReport.Show()

    End Sub

    Private Sub ColetaDeInformaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColetaDeInformaçõesToolStripMenuItem.Click

        'frmImpColetaInformacoes.show()
        FormRel.txtRel.Text = "0"
        FormRel.Show()

    End Sub

    Private Sub DeclaraçãoDeRaçaECorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeclaraçãoDeRaçaECorToolStripMenuItem.Click

        FormRel.txtRel.Text = "1"
        FormRel.Show()

    End Sub

    Private Sub CadastroToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem4.Click
        'MsgBox("verificar")

        formUsuarioCad.Show()

    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        With fColCadAutz
            .Text = "CPF - Validação para liberar C A D A S T R A M E N T O"
            .Show()
        End With

    End Sub

    Private Sub LogarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogarToolStripMenuItem.Click
        '// Verificando DB
        If Not SistemaInicializado() Then ' Verifica a presenca de autorizacao

            With Oi
                .Msg = "Sistema Não autorizado!"
                .Style = vbCritical
                MsgBox(.Msg, .Style, .Title)
                Exit Sub
            End With

        End If
        '-----------------------------------------------------

        '// Verifica a existencia de usuarios
        Dim intUsuarios As Integer = 0
        Dim query As String = ""
        query = "select count(*) from usuario_administrador "
        intUsuarios = gravaSQLretorno(query)
        If intUsuarios = 0 Then
            formUsuarioCad.Show()
            frmADMcad.Show()
            Exit Sub
        End If
        '-----------------------------------------------------

        FmrIndUsu.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        FreciboNew.Show()
        FreciboNew.MskColChave.Focus()
    End Sub

    Private Sub PontoCapturadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PontoCapturadoToolStripMenuItem.Click
        Dim msg As String
        Dim style As String
        Dim title As String
        'Dim ctxt As String
        'Dim help As String
        Dim resposta As String
        '---------------------

        msg = "Confirma Carga?"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "Carga de captura do ponto"
        'help = "folha.hlp"
        'ctxt = 1000

        resposta = MsgBox(msg, style, title)
        'MsgBox(resposta)
        If resposta <> 6 Then
            MsgBox("Ok!...Carga Cancelada.",, title)
            Exit Sub

        End If
        ' Os arquivos folhaDiario e logDigitas devem ser zerados

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\log.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            MsgBox("Carga iniciada!")
            Dim j As Integer
            While Not MyReader.EndOfData
                Try
                    If OpenDB() Then
                        Dim Query As String
                        Query = "insert into logdigital (seqCapt,chave,date) values ("

                        Dim complemento As String = ""

                        currentRow = MyReader.ReadFields()
                        Dim currentField As String
                        j = 0
                        For Each currentField In currentRow
                            'MsgBox(currentField)

                            If j = 2 Then
                                complemento = complemento & "'" & currentField & "'"
                            Else
                                complemento = complemento & currentField & ","
                            End If
                            j += 1
                        Next

                        Query = Query & complemento & ")"
                        Dim CMD As New MySqlCommand(Query, Conn)
                        Dim DTReader As MySqlDataReader
                        DTReader = CMD.ExecuteReader

                    End If
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
                Conn.Close()

            End While

        End Using

        'Carga folhaDiario
        Dim seqCapt As Integer
        Dim momento As String
        Dim data As String
        Dim hora As Integer
        Dim minuto As Integer
        Dim chave As Integer
        Dim chaveOld As Integer = 0
        Dim dataOld As Integer = 0
        Dim contador As Integer = 0
        Dim mGerado, hGerado As Integer
        Dim minutoOld, horaOld As Integer
        Dim horaIncremento As Integer = 0
        Dim minutoIncremento As Integer = 0
        Dim arryAux(1000, 10) As String
        Dim elementoMatriz As Integer = 0

        If OpenDB() Then
            Dim Query As String = "call folhaCaptura_folhaDiario"
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader
            DTReader = CMD.ExecuteReader
            While DTReader.Read
                seqCapt = DTReader.GetString(1)
                chave = DTReader.GetString(2)                                   ' chave
                momento = DTReader.GetString(3)                                 ' momento
                data = dataAAAAMMDD(Replace(momento.Substring(0, 10), "-", ""))
                hora = momento.Substring(11, 2)
                minuto = momento.Substring(14, 2)
                If data = dataOld And chave = chaveOld Then
                    contador = contador + 1
                Else
                    contador = 0
                    dataOld = data
                    chaveOld = chave
                End If

                If contador Mod 2 = 0 Then
                    mGerado = 0
                    hGerado = 0

                Else

                    If minuto < minutoOld Then
                        horaIncremento = -1
                        minutoIncremento = 60
                    Else
                        horaIncremento = 0
                        minutoIncremento = 0
                    End If

                    mGerado = minuto - minutoOld + minutoIncremento
                    hGerado = hora - horaOld + horaIncremento

                End If
                horaOld = hora
                minutoOld = minuto
                arryAux(elementoMatriz, 0) = seqCapt
                arryAux(elementoMatriz, 1) = data
                arryAux(elementoMatriz, 2) = hora
                arryAux(elementoMatriz, 3) = minuto
                arryAux(elementoMatriz, 4) = contador
                arryAux(elementoMatriz, 5) = chave
                arryAux(elementoMatriz, 6) = mGerado
                arryAux(elementoMatriz, 7) = hGerado * 60
                arryAux(elementoMatriz, 8) = DTReader.GetString(4)  ' Turno
                arryAux(elementoMatriz, 9) = DTReader.GetString(5)  ' Turno Duracao
                arryAux(elementoMatriz, 10) = DTReader.GetString(6) ' Turno Descanso
                elementoMatriz = elementoMatriz + 1
            End While
        End If

        Conn.Close()


        For i = 0 To elementoMatriz - 1
            If OpenDB() Then
                Dim Query As String = ""
                Query = "insert into folhaDiario ("
                Query = Query & "seqCapt"
                Query = Query & ",data"
                Query = Query & ",hora"
                Query = Query & ",minuto"
                Query = Query & ",tipo"
                Query = Query & ",colaborador"
                Query = Query & ",tempoGerado"
                Query = Query & ",tempoAcumulado"
                Query = Query & ",turno"
                Query = Query & ",turnoTempo"
                Query = Query & ",turnoDescanso"
                Query = Query & ")"
                Query = Query & "        values "
                Query = Query & "("
                Query = Query & arryAux(i, 0)
                Query = Query & ",'" & arryAux(i, 1) & "'"
                Query = Query & "," & arryAux(i, 2)
                Query = Query & "," & arryAux(i, 3)
                Query = Query & "," & arryAux(i, 4)
                Query = Query & "," & arryAux(i, 5)
                Query = Query & "," & Val(arryAux(i, 6)) + Val(arryAux(i, 7))
                Query = Query & "," & 0
                Query = Query & ",'" & arryAux(i, 8) & "'"
                Query = Query & ",'" & arryAux(i, 9) & "'"
                Query = Query & ",'" & arryAux(i, 10) & "'"
                Query = Query & ")"

                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader
                DTReader = CMD.ExecuteReader
                Conn.Close()

            End If


        Next
        MsgBox("Carga realizada com sucesso!")
    End Sub

    Private Sub PontoAcertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PontoAcertosToolStripMenuItem.Click

        Dim strPath As String

        strPath = "c:\folha\trans\ponto\correcoes\ajusteCorrecoes.txt"

        If Not System.IO.File.Exists(strPath) Then

            MsgBox("Arquivo " & strPath & " não existe!")
            Exit Sub
        End If

        Dim correcao As List(Of PontoCorrecao) = pontoCorrecaoRP.GetPontoCorrecao()

        '=================================================================================

        Dim qtoCorrigir As Integer = correcao.Count()
        Dim qtoEncontrados As Integer = 0
        For i = 0 To qtoCorrigir - 1
            If OpenDB() Then

                Dim Query As String = "select count(*) as qto from ajustedigital where logId = " & correcao(i).SeqCaptura
                Dim CMD As New MySqlCommand(Query, Conn)
                Dim DTReader As MySqlDataReader

                Try
                    DTReader = CMD.ExecuteReader
                    DTReader.Read()
                    If DTReader.GetString(0) > 0 Then
                        qtoEncontrados += 1
                        correcao(i).Gravar = False
                    End If

                Catch ex As Exception
                    MsgBox("Problemas Na Leitura!")
                End Try

                Conn.Close()
            End If
        Next
        Dim msg As String
        Dim style As String
        Dim title As String
        Dim resposta As String
        Dim rgCorrigir As Integer
        '---------------------
        rgCorrigir = (qtoCorrigir - qtoEncontrados)

        msg = "Dos " & qtoCorrigir & " Registros ha corrigir " & rgCorrigir & " estao liberadoros para Acerto...Confirma Carga?"
        style = vbYesNo + vbQuestion + vbDefaultButton1
        title = "Carga de captura do ponto"

        If rgCorrigir = 0 Then
            MsgBox("Carga não Realizada")
            Exit Sub
        End If

        resposta = MsgBox(msg, style, title)

        If resposta <> 6 Then
            MsgBox("Ok!...Carga Cancelada.",, title)
            Exit Sub
        End If

        For i = 0 To qtoCorrigir - 1
            If correcao(i).Gravar Then

                If OpenDB() Then

                    Dim Query As String = "insert into ajusteDigital (logId,date,obs) values (" & correcao(i).SeqCaptura & ",'" & correcao(i).DataHoraMinuto & "','" & correcao(i).OBS & "')"
                    Dim CMD As New MySqlCommand(Query, Conn)
                    Dim DTReader As MySqlDataReader

                    Try
                        DTReader = CMD.ExecuteReader
                        DTReader.Read()
                    Catch ex As Exception

                        MsgBox("Problemas Na Gravação!")

                    End Try

                    Conn.Close()

                End If

            End If
        Next
        If OpenDB() Then

            Dim Query As String = "call pontoAcerto() "
            Dim CMD As New MySqlCommand(Query, Conn)
            Dim DTReader As MySqlDataReader

            Try
                DTReader = CMD.ExecuteReader
                DTReader.Read()
                MsgBox(DTReader.GetString(0))
            Catch ex As Exception

                MsgBox("Problemas Na Leitura!")

            End Try

            Conn.Close()

        End If

    End Sub

    Private Sub CaracterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaracterToolStripMenuItem.Click
        frmTurno.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem6.Click
        FmrDescanso.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem3.Click

        frmCadastroAcesso.Show()

    End Sub

    Private Sub LançamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LançamentosToolStripMenuItem.Click
        FmrCPlancamento.Show()
    End Sub

    Private Sub InclusãoToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles InclusãoToolStripMenuItem4.Click
        FrmCartaoInclusao.Show()
    End Sub

    Private Sub AlteraçãoToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles AlteraçãoToolStripMenuItem9.Click
        frmCartaoManutencao.Show()
    End Sub

    Private Sub AlteraçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlteraçãoToolStripMenuItem1.Click
        FColPesq.Show()
        FColPesq.lblTipo.Text = "P E S Q U I S A  - M A N U T E N Ç Ã O   C A D A S T R A L"
        'FcolAlt.Show()
    End Sub

    Private Sub FichaCadastralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaCadastralToolStripMenuItem.Click
        FColPesq.Show()
        FColPesq.lblTipo.Text = "P E S Q U I S A  - F I C H A   C A D A S T R A L"
    End Sub


    Private Sub PesquisaImpressãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisaImpressãoToolStripMenuItem.Click
        fmrReciboPesquisa.Show()
    End Sub

    Private Sub HistoricosPadrãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricosPadrãoToolStripMenuItem.Click
        FrmReciboConformidade.Show()
    End Sub

    Private Sub PlanoDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanoDeContasToolStripMenuItem.Click
        FcontPCcadastro.Show()
    End Sub

    Private Sub InclusãoToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles InclusãoToolStripMenuItem5.Click

        FreciboHistPadraoInclusao.Show()

    End Sub

    Private Sub PesquisaToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem6.Click

        FreciboHistPadrao.Show()
        FreciboHistPadrao.Width = 772
        FreciboHistPadrao.Height = 279

    End Sub

    Private Sub InclusãioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InclusãioToolStripMenuItem.Click

        With FrmCNPJautoriza
            .Text = "CNPJ - Validação para liberar C A D A S T R A M E N T O"
            .Show()
        End With

    End Sub

    Private Sub IncrementarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncrementarToolStripMenuItem.Click

        frmFolhaLancVar.Show()

    End Sub

    Private Sub AutomáticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomáticosToolStripMenuItem.Click

        frmFolLancAutomaticos.Show()

    End Sub

    Private Sub DescançoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescançoToolStripMenuItem.Click

        FrmFolhaRefDescanso.Show()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click

        FrmFolhaSalAjusteManual.Show()

    End Sub

    Private Sub CálculoAutomáticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoAutomáticoToolStripMenuItem.Click

        frmFolhaRescisaoManual.Show() 'Preencimento Do TRCT

    End Sub

    Private Sub GravaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GravaçãoToolStripMenuItem.Click

        frmFolhaRescisaoDestratoGravacao.Show()

    End Sub

    Private Sub IndividualToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem.Click

        frmFolCalPreliminarIndividual.Show()

    End Sub

    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        FrmFolhaAdiantamentoSalarialPreliminarTodos.Show()
    End Sub

    Private Sub EfetivarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfetivarToolStripMenuItem.Click
        FrmFolhaAdiantamentoSalarialPreliminarEfetiva.Show()
    End Sub

    Private Sub HoleriteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HoleriteToolStripMenuItem1.Click
        FrmFolhaAdiantamentoSalarialHolerite.Show()
    End Sub

    Private Sub CadastramentoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CadastramentoToolStripMenuItem2.Click
        'FrmFolhaContratoDeTrabalhoCadastramento.show()
        FrmFolhaContratoDeTrabalhoAutorizados.Show()

    End Sub

    Private Sub CrysTalReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrysTalReportToolStripMenuItem.Click

        formCrstalTeste1.Show()

    End Sub

    Private Sub ResumoBancárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumoBancárioToolStripMenuItem.Click

        FrmFolhaAdiantamentoResumoPagamento.Show()

    End Sub

    Private Sub EfetivarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EfetivarToolStripMenuItem1.Click

        FrmFolhaEfetivacao.Show()

    End Sub

    Private Sub PesquisaToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem11.Click

        FrmFolhaContratoDeTrabalhoPesquisa.Show()

    End Sub

    Private Sub CadastroToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem7.Click

        FcolCadCargo.Show()

    End Sub

    Private Sub CadastroToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem8.Click

        FcolCadSetor.Show()

    End Sub

    Private Sub CadastramentoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CadastramentoToolStripMenuItem3.Click

        frmFolha_salariosCadastro.Show()

    End Sub

    Private Sub ProduçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduçãoToolStripMenuItem.Click

        frmDBselecao.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        MenuTrava(False, Me.MenuStrip1)
        barraLimpa()
        Me.BackgroundImage = Image.FromFile("C:\Users\paulo\Desktop\paulo\desenvolvimentoSoftwareFolha\icones\login0.jpeg")
        BaixarFormulariosAbertos()

    End Sub
    Private Function barraLimpa()

        form1Status.Text = "Status : Off Line //"
        empCNPJ.Text = "CNPJ : //"
        Form1chave.Text = "Chave : //"
        Form1usuarioNome.Text = "Usuário : //"
        Form1terminal.Text = "Terminal : //"
        Form1Inicio.Text = "Inicio : //"
        Form1tempo.Text = "Tempo : //"

    End Function

    Private Sub InclusãoToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles InclusãoToolStripMenuItem6.Click
        frmADMcad.Show()
    End Sub

    Private Sub ManutençãoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ManutençãoToolStripMenuItem2.Click
        formUsuarioManutencao.Show()
    End Sub

    Private Sub ColaboradorToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        '// Verificando DB
        If Not SistemaInicializado() Then ' Verifica a presenca de autorizacao

            With Oi
                .Msg = "Sistema Não autorizado!"
                .Style = vbCritical
                MsgBox(.msg, .style, .title)
                Exit Sub
            End With

        End If
        '-----------------------------------------------------

        '// Verifica a existencia de usuarios
        Dim intUsuarios As Integer = 0
        Dim query As String = ""
        query = "select count(*) from usuario_administrador "
        intUsuarios = gravaSQLretorno(query)
        If intUsuarios = 0 Then
            'formUsuarioCad.Show()
            frmADMcad.Show()
            Exit Sub
        End If
        '-----------------------------------------------------

        FmrIndUsu.Show()

    End Sub
    Private Sub InclusãoToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles InclusãoToolStripMenuItem8.Click

        With FrmCNPJautoriza
            .Text = "CNPJ - Validação para C A D A S T R A M E N T O"
            .Show()
        End With

    End Sub

    Private Sub PesquisaToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem14.Click
        FrmFornecedorPesq.Show()
        FrmFornecedorPesq.lblTipo.Text = "P E S Q U I S A    D E     F O R N E C E D O R"
    End Sub

    Private Sub PesquisaToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem15.Click
        frmLogPesquisa.Show
    End Sub

    Private Sub RegistroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem1.Click

        FrmFolhaContratoAtivacao.Show()

    End Sub
End Class
