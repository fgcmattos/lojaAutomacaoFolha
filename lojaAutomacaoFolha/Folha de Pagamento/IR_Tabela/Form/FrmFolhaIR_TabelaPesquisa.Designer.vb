<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaIR_TabelaPesquisa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupEscolhaTabela = New System.Windows.Forms.GroupBox()
        Me.ListSelecao = New System.Windows.Forms.ListBox()
        Me.BtnSelecao = New System.Windows.Forms.Button()
        Me.GroupTabelaShow = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupIdentificacaoDaTabela = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblTabelaPosterior = New System.Windows.Forms.Label()
        Me.LblTabelaAnterior = New System.Windows.Forms.Label()
        Me.LblDataDesativacao = New System.Windows.Forms.Label()
        Me.LblDataAtivacao = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblTabelaNumero = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblLiberacaoResponsavelTipo = New System.Windows.Forms.Label()
        Me.LblLiberacaoResponsavelChave = New System.Windows.Forms.Label()
        Me.LblLiberacaoData = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblConferenciaAnalistaTipo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblConferenciaAnalistaChave = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblConferenciaData = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblDigitacaoOperadorTipo = New System.Windows.Forms.Label()
        Me.LblDigitacaoOperadorChave = New System.Windows.Forms.Label()
        Me.LblDigitacaoData = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupPainelDePesquisa = New System.Windows.Forms.GroupBox()
        Me.CmbTabelaStatus = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.GroupEscolhaTabela.SuspendLayout()
        Me.GroupTabelaShow.SuspendLayout()
        Me.GroupIdentificacaoDaTabela.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupPainelDePesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupEscolhaTabela
        '
        Me.GroupEscolhaTabela.Controls.Add(Me.ListSelecao)
        Me.GroupEscolhaTabela.Controls.Add(Me.BtnSelecao)
        Me.GroupEscolhaTabela.Location = New System.Drawing.Point(500, 3)
        Me.GroupEscolhaTabela.Name = "GroupEscolhaTabela"
        Me.GroupEscolhaTabela.Size = New System.Drawing.Size(297, 175)
        Me.GroupEscolhaTabela.TabIndex = 9
        Me.GroupEscolhaTabela.TabStop = False
        Me.GroupEscolhaTabela.Text = "Escolha a Tabela"
        Me.GroupEscolhaTabela.Visible = False
        '
        'ListSelecao
        '
        Me.ListSelecao.FormattingEnabled = True
        Me.ListSelecao.Location = New System.Drawing.Point(24, 19)
        Me.ListSelecao.Name = "ListSelecao"
        Me.ListSelecao.Size = New System.Drawing.Size(254, 108)
        Me.ListSelecao.TabIndex = 4
        '
        'BtnSelecao
        '
        Me.BtnSelecao.Location = New System.Drawing.Point(180, 133)
        Me.BtnSelecao.Name = "BtnSelecao"
        Me.BtnSelecao.Size = New System.Drawing.Size(105, 24)
        Me.BtnSelecao.TabIndex = 5
        Me.BtnSelecao.Text = "Selecione"
        Me.BtnSelecao.UseVisualStyleBackColor = True
        '
        'GroupTabelaShow
        '
        Me.GroupTabelaShow.Controls.Add(Me.ListView1)
        Me.GroupTabelaShow.Location = New System.Drawing.Point(22, 423)
        Me.GroupTabelaShow.Name = "GroupTabelaShow"
        Me.GroupTabelaShow.Size = New System.Drawing.Size(622, 190)
        Me.GroupTabelaShow.TabIndex = 8
        Me.GroupTabelaShow.TabStop = False
        Me.GroupTabelaShow.Text = "Tabela"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(42, 31)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(540, 127)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Faixa"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valor da Faixa"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "% da Faixa"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Imposto da Faixa"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Imposto Acumulado da Faixa"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 160
        '
        'GroupIdentificacaoDaTabela
        '
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.GroupBox6)
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.LblTabelaNumero)
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.Label12)
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.GroupBox5)
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.GroupBox4)
        Me.GroupIdentificacaoDaTabela.Controls.Add(Me.GroupBox3)
        Me.GroupIdentificacaoDaTabela.Location = New System.Drawing.Point(22, 184)
        Me.GroupIdentificacaoDaTabela.Name = "GroupIdentificacaoDaTabela"
        Me.GroupIdentificacaoDaTabela.Size = New System.Drawing.Size(852, 233)
        Me.GroupIdentificacaoDaTabela.TabIndex = 7
        Me.GroupIdentificacaoDaTabela.TabStop = False
        Me.GroupIdentificacaoDaTabela.Text = "Identificação da Tabela"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblTabelaPosterior)
        Me.GroupBox6.Controls.Add(Me.LblTabelaAnterior)
        Me.GroupBox6.Controls.Add(Me.LblDataDesativacao)
        Me.GroupBox6.Controls.Add(Me.LblDataAtivacao)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(316, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(530, 63)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OPERAÇÃO"
        '
        'LblTabelaPosterior
        '
        Me.LblTabelaPosterior.AutoSize = True
        Me.LblTabelaPosterior.Location = New System.Drawing.Point(454, 41)
        Me.LblTabelaPosterior.Name = "LblTabelaPosterior"
        Me.LblTabelaPosterior.Size = New System.Drawing.Size(44, 13)
        Me.LblTabelaPosterior.TabIndex = 11
        Me.LblTabelaPosterior.Text = "Número"
        '
        'LblTabelaAnterior
        '
        Me.LblTabelaAnterior.AutoSize = True
        Me.LblTabelaAnterior.Location = New System.Drawing.Point(454, 20)
        Me.LblTabelaAnterior.Name = "LblTabelaAnterior"
        Me.LblTabelaAnterior.Size = New System.Drawing.Size(44, 13)
        Me.LblTabelaAnterior.TabIndex = 10
        Me.LblTabelaAnterior.Text = "Número"
        '
        'LblDataDesativacao
        '
        Me.LblDataDesativacao.AutoSize = True
        Me.LblDataDesativacao.Location = New System.Drawing.Point(147, 37)
        Me.LblDataDesativacao.Name = "LblDataDesativacao"
        Me.LblDataDesativacao.Size = New System.Drawing.Size(44, 13)
        Me.LblDataDesativacao.TabIndex = 9
        Me.LblDataDesativacao.Text = "Número"
        '
        'LblDataAtivacao
        '
        Me.LblDataAtivacao.AutoSize = True
        Me.LblDataAtivacao.Location = New System.Drawing.Point(147, 16)
        Me.LblDataAtivacao.Name = "LblDataAtivacao"
        Me.LblDataAtivacao.Size = New System.Drawing.Size(44, 13)
        Me.LblDataAtivacao.TabIndex = 8
        Me.LblDataAtivacao.Text = "Número"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(351, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Tabela Posterior:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(351, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Tabela Anterior:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Data da Desativação:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Data da Ativação:"
        '
        'LblTabelaNumero
        '
        Me.LblTabelaNumero.AutoSize = True
        Me.LblTabelaNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTabelaNumero.Location = New System.Drawing.Point(213, 25)
        Me.LblTabelaNumero.Name = "LblTabelaNumero"
        Me.LblTabelaNumero.Size = New System.Drawing.Size(0, 25)
        Me.LblTabelaNumero.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Tabela Número:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoResponsavelTipo)
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoResponsavelChave)
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoData)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(580, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Liberação"
        '
        'LblLiberacaoResponsavelTipo
        '
        Me.LblLiberacaoResponsavelTipo.AutoSize = True
        Me.LblLiberacaoResponsavelTipo.Location = New System.Drawing.Point(130, 83)
        Me.LblLiberacaoResponsavelTipo.Name = "LblLiberacaoResponsavelTipo"
        Me.LblLiberacaoResponsavelTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoResponsavelTipo.TabIndex = 11
        Me.LblLiberacaoResponsavelTipo.Text = "Número"
        '
        'LblLiberacaoResponsavelChave
        '
        Me.LblLiberacaoResponsavelChave.AutoSize = True
        Me.LblLiberacaoResponsavelChave.Location = New System.Drawing.Point(130, 55)
        Me.LblLiberacaoResponsavelChave.Name = "LblLiberacaoResponsavelChave"
        Me.LblLiberacaoResponsavelChave.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoResponsavelChave.TabIndex = 10
        Me.LblLiberacaoResponsavelChave.Text = "Número"
        '
        'LblLiberacaoData
        '
        Me.LblLiberacaoData.AutoSize = True
        Me.LblLiberacaoData.Location = New System.Drawing.Point(130, 26)
        Me.LblLiberacaoData.Name = "LblLiberacaoData"
        Me.LblLiberacaoData.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoData.TabIndex = 9
        Me.LblLiberacaoData.Text = "Número"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Responsável Tipo :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Responsável Chave :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Data :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblConferenciaAnalistaTipo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LblConferenciaAnalistaChave)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.LblConferenciaData)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(317, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Conferência"
        '
        'LblConferenciaAnalistaTipo
        '
        Me.LblConferenciaAnalistaTipo.AutoSize = True
        Me.LblConferenciaAnalistaTipo.Location = New System.Drawing.Point(96, 83)
        Me.LblConferenciaAnalistaTipo.Name = "LblConferenciaAnalistaTipo"
        Me.LblConferenciaAnalistaTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaAnalistaTipo.TabIndex = 11
        Me.LblConferenciaAnalistaTipo.Text = "Número"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Analista Tipo :"
        '
        'LblConferenciaAnalistaChave
        '
        Me.LblConferenciaAnalistaChave.AutoSize = True
        Me.LblConferenciaAnalistaChave.Location = New System.Drawing.Point(96, 55)
        Me.LblConferenciaAnalistaChave.Name = "LblConferenciaAnalistaChave"
        Me.LblConferenciaAnalistaChave.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaAnalistaChave.TabIndex = 10
        Me.LblConferenciaAnalistaChave.Text = "Número"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Analista Chave :"
        '
        'LblConferenciaData
        '
        Me.LblConferenciaData.AutoSize = True
        Me.LblConferenciaData.Location = New System.Drawing.Point(96, 26)
        Me.LblConferenciaData.Name = "LblConferenciaData"
        Me.LblConferenciaData.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaData.TabIndex = 9
        Me.LblConferenciaData.Text = "Número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Data :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoOperadorTipo)
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoOperadorChave)
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoData)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Digitação"
        '
        'LblDigitacaoOperadorTipo
        '
        Me.LblDigitacaoOperadorTipo.AutoSize = True
        Me.LblDigitacaoOperadorTipo.Location = New System.Drawing.Point(104, 79)
        Me.LblDigitacaoOperadorTipo.Name = "LblDigitacaoOperadorTipo"
        Me.LblDigitacaoOperadorTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoOperadorTipo.TabIndex = 8
        Me.LblDigitacaoOperadorTipo.Text = "Número"
        '
        'LblDigitacaoOperadorChave
        '
        Me.LblDigitacaoOperadorChave.AutoSize = True
        Me.LblDigitacaoOperadorChave.Location = New System.Drawing.Point(104, 51)
        Me.LblDigitacaoOperadorChave.Name = "LblDigitacaoOperadorChave"
        Me.LblDigitacaoOperadorChave.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoOperadorChave.TabIndex = 7
        Me.LblDigitacaoOperadorChave.Text = "Número"
        '
        'LblDigitacaoData
        '
        Me.LblDigitacaoData.AutoSize = True
        Me.LblDigitacaoData.Location = New System.Drawing.Point(104, 26)
        Me.LblDigitacaoData.Name = "LblDigitacaoData"
        Me.LblDigitacaoData.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoData.TabIndex = 6
        Me.LblDigitacaoData.Text = "Número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Operador Tipo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Operador Chave :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data :"
        '
        'GroupPainelDePesquisa
        '
        Me.GroupPainelDePesquisa.Controls.Add(Me.CmbTabelaStatus)
        Me.GroupPainelDePesquisa.Controls.Add(Me.Label18)
        Me.GroupPainelDePesquisa.Controls.Add(Me.BtnPesquisa)
        Me.GroupPainelDePesquisa.Controls.Add(Me.Label2)
        Me.GroupPainelDePesquisa.Controls.Add(Me.Label1)
        Me.GroupPainelDePesquisa.Controls.Add(Me.MskNumero)
        Me.GroupPainelDePesquisa.Controls.Add(Me.MskReferencia)
        Me.GroupPainelDePesquisa.Location = New System.Drawing.Point(22, 3)
        Me.GroupPainelDePesquisa.Name = "GroupPainelDePesquisa"
        Me.GroupPainelDePesquisa.Size = New System.Drawing.Size(447, 151)
        Me.GroupPainelDePesquisa.TabIndex = 6
        Me.GroupPainelDePesquisa.TabStop = False
        Me.GroupPainelDePesquisa.Text = "Painel de Pesquisa"
        '
        'CmbTabelaStatus
        '
        Me.CmbTabelaStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTabelaStatus.FormattingEnabled = True
        Me.CmbTabelaStatus.Location = New System.Drawing.Point(105, 124)
        Me.CmbTabelaStatus.Name = "CmbTabelaStatus"
        Me.CmbTabelaStatus.Size = New System.Drawing.Size(145, 21)
        Me.CmbTabelaStatus.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Status da Tabela"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(257, 126)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(172, 19)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Referência"
        '
        'MskNumero
        '
        Me.MskNumero.Location = New System.Drawing.Point(83, 79)
        Me.MskNumero.Mask = "####.##"
        Me.MskNumero.Name = "MskNumero"
        Me.MskNumero.Size = New System.Drawing.Size(98, 20)
        Me.MskNumero.TabIndex = 1
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(83, 32)
        Me.MskReferencia.Mask = "####/##"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(98, 20)
        Me.MskReferencia.TabIndex = 0
        '
        'FrmFolhaIR_TabelaPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 616)
        Me.Controls.Add(Me.GroupEscolhaTabela)
        Me.Controls.Add(Me.GroupTabelaShow)
        Me.Controls.Add(Me.GroupIdentificacaoDaTabela)
        Me.Controls.Add(Me.GroupPainelDePesquisa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaIR_TabelaPesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOLHA - Tabela IR   -  P E S Q U I S A"
        Me.GroupEscolhaTabela.ResumeLayout(False)
        Me.GroupTabelaShow.ResumeLayout(False)
        Me.GroupIdentificacaoDaTabela.ResumeLayout(False)
        Me.GroupIdentificacaoDaTabela.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupPainelDePesquisa.ResumeLayout(False)
        Me.GroupPainelDePesquisa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupEscolhaTabela As GroupBox
    Friend WithEvents ListSelecao As ListBox
    Friend WithEvents BtnSelecao As Button
    Friend WithEvents GroupTabelaShow As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupIdentificacaoDaTabela As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblTabelaPosterior As Label
    Friend WithEvents LblTabelaAnterior As Label
    Friend WithEvents LblDataDesativacao As Label
    Friend WithEvents LblDataAtivacao As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblTabelaNumero As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblLiberacaoResponsavelTipo As Label
    Friend WithEvents LblLiberacaoResponsavelChave As Label
    Friend WithEvents LblLiberacaoData As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LblConferenciaAnalistaTipo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblConferenciaAnalistaChave As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblConferenciaData As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblDigitacaoOperadorTipo As Label
    Friend WithEvents LblDigitacaoOperadorChave As Label
    Friend WithEvents LblDigitacaoData As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupPainelDePesquisa As GroupBox
    Friend WithEvents CmbTabelaStatus As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MskNumero As MaskedTextBox
    Friend WithEvents MskReferencia As MaskedTextBox
End Class
