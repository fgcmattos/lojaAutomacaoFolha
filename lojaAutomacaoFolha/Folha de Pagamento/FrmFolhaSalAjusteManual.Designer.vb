<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaSalAjusteManual
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GruEvolucao = New System.Windows.Forms.GroupBox()
        Me.LswRemEvol = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GruColPesq = New System.Windows.Forms.GroupBox()
        Me.LblRG = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblUltimaMovimentacaoReg = New System.Windows.Forms.Label()
        Me.LblUltimaMovimentacao = New System.Windows.Forms.Label()
        Me.GruDigitacao = New System.Windows.Forms.GroupBox()
        Me.LblReferencia = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnAbreEdicao = New System.Windows.Forms.Button()
        Me.MskColPesq = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCPFtela = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblSalarioAtualValor = New System.Windows.Forms.Label()
        Me.LblSalarioAtual = New System.Windows.Forms.Label()
        Me.LblPesqColNome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GruEdicao = New System.Windows.Forms.GroupBox()
        Me.BtnEdicaoCancela = New System.Windows.Forms.Button()
        Me.BtnEdicaoGrava = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbEdicaoCargo = New System.Windows.Forms.ComboBox()
        Me.GruVriacao = New System.Windows.Forms.GroupBox()
        Me.TxtEdicaoVariacao = New System.Windows.Forms.TextBox()
        Me.LblVariacao = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEdicaoHistorico = New System.Windows.Forms.TextBox()
        Me.CmbEdicaoFato = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblEdicaoSalAtualValor = New System.Windows.Forms.Label()
        Me.LbledicaoSalarioAtual = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MskEdicaoData = New System.Windows.Forms.MaskedTextBox()
        Me.MskEdicaoNovoSalario = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GruEvolucao.SuspendLayout()
        Me.GruColPesq.SuspendLayout()
        Me.GruDigitacao.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GruEdicao.SuspendLayout()
        Me.GruVriacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GruEvolucao)
        Me.GroupBox1.Controls.Add(Me.GruColPesq)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 539)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GruEvolucao
        '
        Me.GruEvolucao.Controls.Add(Me.LswRemEvol)
        Me.GruEvolucao.Location = New System.Drawing.Point(6, 318)
        Me.GruEvolucao.Name = "GruEvolucao"
        Me.GruEvolucao.Size = New System.Drawing.Size(969, 211)
        Me.GruEvolucao.TabIndex = 5
        Me.GruEvolucao.TabStop = False
        Me.GruEvolucao.Text = "H I S T Ó R I C O  D E  E V O L U Ç Ã O"
        '
        'LswRemEvol
        '
        Me.LswRemEvol.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LswRemEvol.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.LswRemEvol.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LswRemEvol.FullRowSelect = True
        Me.LswRemEvol.GridLines = True
        Me.LswRemEvol.HideSelection = False
        Me.LswRemEvol.Location = New System.Drawing.Point(4, 19)
        Me.LswRemEvol.Name = "LswRemEvol"
        Me.LswRemEvol.Size = New System.Drawing.Size(959, 188)
        Me.LswRemEvol.TabIndex = 1
        Me.LswRemEvol.UseCompatibleStateImageBehavior = False
        Me.LswRemEvol.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reg"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fato"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cargo"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "%"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Valor"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Registro"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Baixa"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Histórico"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Tempo"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "SalarioAtual"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Nome"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CPF"
        '
        'GruColPesq
        '
        Me.GruColPesq.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruColPesq.Controls.Add(Me.LblRG)
        Me.GruColPesq.Controls.Add(Me.Label12)
        Me.GruColPesq.Controls.Add(Me.LblUltimaMovimentacaoReg)
        Me.GruColPesq.Controls.Add(Me.LblUltimaMovimentacao)
        Me.GruColPesq.Controls.Add(Me.GruDigitacao)
        Me.GruColPesq.Controls.Add(Me.lblCPF)
        Me.GruColPesq.Controls.Add(Me.PictureBox1)
        Me.GruColPesq.Controls.Add(Me.LblCPFtela)
        Me.GruColPesq.Controls.Add(Me.Label4)
        Me.GruColPesq.Controls.Add(Me.LblSalarioAtualValor)
        Me.GruColPesq.Controls.Add(Me.LblSalarioAtual)
        Me.GruColPesq.Controls.Add(Me.LblPesqColNome)
        Me.GruColPesq.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruColPesq.Location = New System.Drawing.Point(2, 19)
        Me.GruColPesq.Name = "GruColPesq"
        Me.GruColPesq.Size = New System.Drawing.Size(507, 293)
        Me.GruColPesq.TabIndex = 4
        Me.GruColPesq.TabStop = False
        Me.GruColPesq.Text = "Pesquisa do Colaborador"
        '
        'LblRG
        '
        Me.LblRG.AutoSize = True
        Me.LblRG.Location = New System.Drawing.Point(337, 277)
        Me.LblRG.Name = "LblRG"
        Me.LblRG.Size = New System.Drawing.Size(0, 13)
        Me.LblRG.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "RG "
        '
        'LblUltimaMovimentacaoReg
        '
        Me.LblUltimaMovimentacaoReg.AutoSize = True
        Me.LblUltimaMovimentacaoReg.Location = New System.Drawing.Point(22, 274)
        Me.LblUltimaMovimentacaoReg.Name = "LblUltimaMovimentacaoReg"
        Me.LblUltimaMovimentacaoReg.Size = New System.Drawing.Size(39, 13)
        Me.LblUltimaMovimentacaoReg.TabIndex = 21
        Me.LblUltimaMovimentacaoReg.Text = "Label2"
        '
        'LblUltimaMovimentacao
        '
        Me.LblUltimaMovimentacao.AutoSize = True
        Me.LblUltimaMovimentacao.Location = New System.Drawing.Point(22, 241)
        Me.LblUltimaMovimentacao.Name = "LblUltimaMovimentacao"
        Me.LblUltimaMovimentacao.Size = New System.Drawing.Size(39, 13)
        Me.LblUltimaMovimentacao.TabIndex = 20
        Me.LblUltimaMovimentacao.Text = "Label2"
        '
        'GruDigitacao
        '
        Me.GruDigitacao.Controls.Add(Me.LblReferencia)
        Me.GruDigitacao.Controls.Add(Me.Label10)
        Me.GruDigitacao.Controls.Add(Me.BtnAbreEdicao)
        Me.GruDigitacao.Controls.Add(Me.MskColPesq)
        Me.GruDigitacao.Controls.Add(Me.Label1)
        Me.GruDigitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruDigitacao.Location = New System.Drawing.Point(25, 19)
        Me.GruDigitacao.Name = "GruDigitacao"
        Me.GruDigitacao.Size = New System.Drawing.Size(214, 186)
        Me.GruDigitacao.TabIndex = 19
        Me.GruDigitacao.TabStop = False
        Me.GruDigitacao.Text = "D I G I T A Ç Â O"
        '
        'LblReferencia
        '
        Me.LblReferencia.AutoSize = True
        Me.LblReferencia.Font = New System.Drawing.Font("Courier New", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReferencia.Location = New System.Drawing.Point(113, 19)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(87, 22)
        Me.LblReferencia.TabIndex = 9
        Me.LblReferencia.Text = "08/2021"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "REFERÊNCIA"
        '
        'BtnAbreEdicao
        '
        Me.BtnAbreEdicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAbreEdicao.Location = New System.Drawing.Point(27, 117)
        Me.BtnAbreEdicao.Name = "BtnAbreEdicao"
        Me.BtnAbreEdicao.Size = New System.Drawing.Size(173, 21)
        Me.BtnAbreEdicao.TabIndex = 7
        Me.BtnAbreEdicao.Tag = ""
        Me.BtnAbreEdicao.Text = "Abre Edição"
        Me.BtnAbreEdicao.UseVisualStyleBackColor = True
        '
        'MskColPesq
        '
        Me.MskColPesq.Location = New System.Drawing.Point(142, 63)
        Me.MskColPesq.Mask = "0000"
        Me.MskColPesq.Name = "MskColPesq"
        Me.MskColPesq.Size = New System.Drawing.Size(49, 20)
        Me.MskColPesq.TabIndex = 6
        Me.MskColPesq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Colaborador"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(11, 190)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(0, 13)
        Me.lblCPF.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(258, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'LblCPFtela
        '
        Me.LblCPFtela.AutoSize = True
        Me.LblCPFtela.Location = New System.Drawing.Point(337, 260)
        Me.LblCPFtela.Name = "LblCPFtela"
        Me.LblCPFtela.Size = New System.Drawing.Size(27, 13)
        Me.LblCPFtela.TabIndex = 8
        Me.LblCPFtela.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CPF"
        '
        'LblSalarioAtualValor
        '
        Me.LblSalarioAtualValor.AutoSize = True
        Me.LblSalarioAtualValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalarioAtualValor.Location = New System.Drawing.Point(358, 236)
        Me.LblSalarioAtualValor.Name = "LblSalarioAtualValor"
        Me.LblSalarioAtualValor.Size = New System.Drawing.Size(97, 16)
        Me.LblSalarioAtualValor.TabIndex = 6
        Me.LblSalarioAtualValor.Text = "Salário Atual"
        '
        'LblSalarioAtual
        '
        Me.LblSalarioAtual.AutoSize = True
        Me.LblSalarioAtual.Location = New System.Drawing.Point(269, 236)
        Me.LblSalarioAtual.Name = "LblSalarioAtual"
        Me.LblSalarioAtual.Size = New System.Drawing.Size(83, 13)
        Me.LblSalarioAtual.TabIndex = 5
        Me.LblSalarioAtual.Text = "Salário Atual R$"
        '
        'LblPesqColNome
        '
        Me.LblPesqColNome.AutoSize = True
        Me.LblPesqColNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPesqColNome.Location = New System.Drawing.Point(164, 260)
        Me.LblPesqColNome.Name = "LblPesqColNome"
        Me.LblPesqColNome.Size = New System.Drawing.Size(39, 13)
        Me.LblPesqColNome.TabIndex = 2
        Me.LblPesqColNome.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GruEdicao)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(515, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 293)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " E D I Ç Ã O  D E  R E N D I M E N T O S"
        '
        'GruEdicao
        '
        Me.GruEdicao.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruEdicao.Controls.Add(Me.BtnEdicaoCancela)
        Me.GruEdicao.Controls.Add(Me.BtnEdicaoGrava)
        Me.GruEdicao.Controls.Add(Me.Label9)
        Me.GruEdicao.Controls.Add(Me.CmbEdicaoCargo)
        Me.GruEdicao.Controls.Add(Me.GruVriacao)
        Me.GruEdicao.Controls.Add(Me.CheckedListBox1)
        Me.GruEdicao.Controls.Add(Me.Label8)
        Me.GruEdicao.Controls.Add(Me.TxtEdicaoHistorico)
        Me.GruEdicao.Controls.Add(Me.CmbEdicaoFato)
        Me.GruEdicao.Controls.Add(Me.Label7)
        Me.GruEdicao.Controls.Add(Me.Label6)
        Me.GruEdicao.Controls.Add(Me.Label5)
        Me.GruEdicao.Controls.Add(Me.LblEdicaoSalAtualValor)
        Me.GruEdicao.Controls.Add(Me.LbledicaoSalarioAtual)
        Me.GruEdicao.Controls.Add(Me.Label3)
        Me.GruEdicao.Controls.Add(Me.MskEdicaoData)
        Me.GruEdicao.Controls.Add(Me.MskEdicaoNovoSalario)
        Me.GruEdicao.Controls.Add(Me.Label2)
        Me.GruEdicao.Enabled = False
        Me.GruEdicao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruEdicao.Location = New System.Drawing.Point(6, 19)
        Me.GruEdicao.Name = "GruEdicao"
        Me.GruEdicao.Size = New System.Drawing.Size(448, 268)
        Me.GruEdicao.TabIndex = 0
        Me.GruEdicao.TabStop = False
        Me.GruEdicao.Text = "Edição de Salário"
        '
        'BtnEdicaoCancela
        '
        Me.BtnEdicaoCancela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdicaoCancela.Location = New System.Drawing.Point(316, 214)
        Me.BtnEdicaoCancela.Name = "BtnEdicaoCancela"
        Me.BtnEdicaoCancela.Size = New System.Drawing.Size(115, 21)
        Me.BtnEdicaoCancela.TabIndex = 22
        Me.BtnEdicaoCancela.Tag = ""
        Me.BtnEdicaoCancela.Text = "Cancela Edição"
        Me.BtnEdicaoCancela.UseVisualStyleBackColor = True
        '
        'BtnEdicaoGrava
        '
        Me.BtnEdicaoGrava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdicaoGrava.Location = New System.Drawing.Point(316, 241)
        Me.BtnEdicaoGrava.Name = "BtnEdicaoGrava"
        Me.BtnEdicaoGrava.Size = New System.Drawing.Size(115, 21)
        Me.BtnEdicaoGrava.TabIndex = 21
        Me.BtnEdicaoGrava.Tag = ""
        Me.BtnEdicaoGrava.Text = "Grava Edição"
        Me.BtnEdicaoGrava.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cargo"
        '
        'CmbEdicaoCargo
        '
        Me.CmbEdicaoCargo.FormattingEnabled = True
        Me.CmbEdicaoCargo.Items.AddRange(New Object() {"Atendente I", "Atendente II", "Coord. Atendente", "Costureiro(a) I", "Costureiro(a) II", "Costureiro(a) III", "Coord.Costura", "Gerente de Loja"})
        Me.CmbEdicaoCargo.Location = New System.Drawing.Point(6, 206)
        Me.CmbEdicaoCargo.Name = "CmbEdicaoCargo"
        Me.CmbEdicaoCargo.Size = New System.Drawing.Size(304, 21)
        Me.CmbEdicaoCargo.TabIndex = 19
        '
        'GruVriacao
        '
        Me.GruVriacao.Controls.Add(Me.TxtEdicaoVariacao)
        Me.GruVriacao.Controls.Add(Me.LblVariacao)
        Me.GruVriacao.Location = New System.Drawing.Point(186, 33)
        Me.GruVriacao.Name = "GruVriacao"
        Me.GruVriacao.Size = New System.Drawing.Size(86, 57)
        Me.GruVriacao.TabIndex = 18
        Me.GruVriacao.TabStop = False
        '
        'TxtEdicaoVariacao
        '
        Me.TxtEdicaoVariacao.Location = New System.Drawing.Point(9, 32)
        Me.TxtEdicaoVariacao.MaxLength = 5
        Me.TxtEdicaoVariacao.Name = "TxtEdicaoVariacao"
        Me.TxtEdicaoVariacao.Size = New System.Drawing.Size(65, 20)
        Me.TxtEdicaoVariacao.TabIndex = 13
        '
        'LblVariacao
        '
        Me.LblVariacao.AutoSize = True
        Me.LblVariacao.Location = New System.Drawing.Point(6, 9)
        Me.LblVariacao.Name = "LblVariacao"
        Me.LblVariacao.Size = New System.Drawing.Size(75, 13)
        Me.LblVariacao.TabIndex = 12
        Me.LblVariacao.Text = "% de Variação"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.CheckedListBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Porcentagem"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(9, 58)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(102, 19)
        Me.CheckedListBox1.TabIndex = 17
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "h i s t ó r i c o"
        '
        'TxtEdicaoHistorico
        '
        Me.TxtEdicaoHistorico.Location = New System.Drawing.Point(6, 242)
        Me.TxtEdicaoHistorico.Name = "TxtEdicaoHistorico"
        Me.TxtEdicaoHistorico.Size = New System.Drawing.Size(304, 20)
        Me.TxtEdicaoHistorico.TabIndex = 14
        '
        'CmbEdicaoFato
        '
        Me.CmbEdicaoFato.FormattingEnabled = True
        Me.CmbEdicaoFato.Items.AddRange(New Object() {"Promoção", "Dissídio", "Contratação"})
        Me.CmbEdicaoFato.Location = New System.Drawing.Point(6, 164)
        Me.CmbEdicaoFato.Name = "CmbEdicaoFato"
        Me.CmbEdicaoFato.Size = New System.Drawing.Size(304, 21)
        Me.CmbEdicaoFato.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tempo No Cargo Anterior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Paramêtro"
        '
        'LblEdicaoSalAtualValor
        '
        Me.LblEdicaoSalAtualValor.AutoSize = True
        Me.LblEdicaoSalAtualValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdicaoSalAtualValor.Location = New System.Drawing.Point(214, 16)
        Me.LblEdicaoSalAtualValor.Name = "LblEdicaoSalAtualValor"
        Me.LblEdicaoSalAtualValor.Size = New System.Drawing.Size(99, 16)
        Me.LblEdicaoSalAtualValor.TabIndex = 5
        Me.LblEdicaoSalAtualValor.Text = "Novo Salário"
        '
        'LbledicaoSalarioAtual
        '
        Me.LbledicaoSalarioAtual.AutoSize = True
        Me.LbledicaoSalarioAtual.Location = New System.Drawing.Point(145, 19)
        Me.LbledicaoSalarioAtual.Name = "LbledicaoSalarioAtual"
        Me.LbledicaoSalarioAtual.Size = New System.Drawing.Size(66, 13)
        Me.LbledicaoSalarioAtual.TabIndex = 4
        Me.LbledicaoSalarioAtual.Text = "Salário Atual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data de Ativação"
        '
        'MskEdicaoData
        '
        Me.MskEdicaoData.Location = New System.Drawing.Point(186, 109)
        Me.MskEdicaoData.Mask = "00/00/0000"
        Me.MskEdicaoData.Name = "MskEdicaoData"
        Me.MskEdicaoData.Size = New System.Drawing.Size(75, 20)
        Me.MskEdicaoData.TabIndex = 2
        Me.MskEdicaoData.ValidatingType = GetType(Date)
        '
        'MskEdicaoNovoSalario
        '
        Me.MskEdicaoNovoSalario.Location = New System.Drawing.Point(9, 109)
        Me.MskEdicaoNovoSalario.Name = "MskEdicaoNovoSalario"
        Me.MskEdicaoNovoSalario.Size = New System.Drawing.Size(115, 20)
        Me.MskEdicaoNovoSalario.TabIndex = 1
        Me.MskEdicaoNovoSalario.Text = "0,00"
        Me.MskEdicaoNovoSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Novo Salário"
        '
        'FrmFolhaSalAjusteManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 563)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFolhaSalAjusteManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folha de Pagamento - Manutenção Manual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GruEvolucao.ResumeLayout(False)
        Me.GruColPesq.ResumeLayout(False)
        Me.GruColPesq.PerformLayout()
        Me.GruDigitacao.ResumeLayout(False)
        Me.GruDigitacao.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GruEdicao.ResumeLayout(False)
        Me.GruEdicao.PerformLayout()
        Me.GruVriacao.ResumeLayout(False)
        Me.GruVriacao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GruEdicao As GroupBox
    Friend WithEvents LblEdicaoSalAtualValor As Label
    Friend WithEvents LbledicaoSalarioAtual As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MskEdicaoData As MaskedTextBox
    Friend WithEvents MskEdicaoNovoSalario As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GruEvolucao As GroupBox
    Friend WithEvents LswRemEvol As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents GruColPesq As GroupBox
    Friend WithEvents LblSalarioAtualValor As Label
    Friend WithEvents LblSalarioAtual As Label
    Friend WithEvents LblPesqColNome As Label
    Friend WithEvents LblCPFtela As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents GruDigitacao As GroupBox
    Friend WithEvents BtnAbreEdicao As Button
    Friend WithEvents MskColPesq As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEdicaoHistorico As TextBox
    Friend WithEvents CmbEdicaoFato As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GruVriacao As GroupBox
    Friend WithEvents LblVariacao As Label
    Friend WithEvents TxtEdicaoVariacao As TextBox
    Friend WithEvents BtnEdicaoCancela As Button
    Friend WithEvents BtnEdicaoGrava As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbEdicaoCargo As ComboBox
    Friend WithEvents LblUltimaMovimentacao As Label
    Friend WithEvents LblUltimaMovimentacaoReg As Label
    Friend WithEvents LblReferencia As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblRG As Label
    Friend WithEvents Label12 As Label
End Class
