<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrCPlancamento
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbCentroDeCusto = New System.Windows.Forms.ComboBox()
        Me.LabelCentroDeCusto = New System.Windows.Forms.Label()
        Me.BtnDeleta = New System.Windows.Forms.Button()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.LblAlteracao = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MskDocNumero = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDocNumero = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.MskIndentifica = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.LblCPF_CNPJ = New System.Windows.Forms.Label()
        Me.LblIdentificacao = New System.Windows.Forms.Label()
        Me.TxtHistorico = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.CmbFerramenta = New System.Windows.Forms.ComboBox()
        Me.LabelCobranca = New System.Windows.Forms.Label()
        Me.LabelDataVencimento = New System.Windows.Forms.Label()
        Me.Cmbcredor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelHistorco = New System.Windows.Forms.Label()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.LabelDataOcorrencia = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalLancado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbCentroDeCusto)
        Me.GroupBox2.Controls.Add(Me.LabelCentroDeCusto)
        Me.GroupBox2.Controls.Add(Me.BtnDeleta)
        Me.GroupBox2.Controls.Add(Me.LblItem)
        Me.GroupBox2.Controls.Add(Me.LblAlteracao)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.MskDocNumero)
        Me.GroupBox2.Controls.Add(Me.LabelDocNumero)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TxtHistorico)
        Me.GroupBox2.Controls.Add(Me.TxtValor)
        Me.GroupBox2.Controls.Add(Me.CmbFerramenta)
        Me.GroupBox2.Controls.Add(Me.LabelCobranca)
        Me.GroupBox2.Controls.Add(Me.LabelDataVencimento)
        Me.GroupBox2.Controls.Add(Me.Cmbcredor)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LabelHistorco)
        Me.GroupBox2.Controls.Add(Me.LabelValor)
        Me.GroupBox2.Controls.Add(Me.LabelDataOcorrencia)
        Me.GroupBox2.Controls.Add(Me.LabelTipo)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 303)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "L A N Ç A M E N T O"
        '
        'CmbCentroDeCusto
        '
        Me.CmbCentroDeCusto.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.CmbCentroDeCusto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCentroDeCusto.FormattingEnabled = True
        Me.CmbCentroDeCusto.Items.AddRange(New Object() {"", "Pessoa Juridica PJ", "Pessoa Fisica    PF"})
        Me.CmbCentroDeCusto.Location = New System.Drawing.Point(105, 32)
        Me.CmbCentroDeCusto.Name = "CmbCentroDeCusto"
        Me.CmbCentroDeCusto.Size = New System.Drawing.Size(315, 21)
        Me.CmbCentroDeCusto.TabIndex = 19
        '
        'LabelCentroDeCusto
        '
        Me.LabelCentroDeCusto.AutoSize = True
        Me.LabelCentroDeCusto.Location = New System.Drawing.Point(16, 40)
        Me.LabelCentroDeCusto.Name = "LabelCentroDeCusto"
        Me.LabelCentroDeCusto.Size = New System.Drawing.Size(83, 13)
        Me.LabelCentroDeCusto.TabIndex = 20
        Me.LabelCentroDeCusto.Text = "Centro de Custo"
        '
        'BtnDeleta
        '
        Me.BtnDeleta.Location = New System.Drawing.Point(265, 266)
        Me.BtnDeleta.Name = "BtnDeleta"
        Me.BtnDeleta.Size = New System.Drawing.Size(234, 26)
        Me.BtnDeleta.TabIndex = 18
        Me.BtnDeleta.Text = "R E M O V E R"
        Me.BtnDeleta.UseVisualStyleBackColor = True
        Me.BtnDeleta.Visible = False
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.Location = New System.Drawing.Point(856, 142)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(0, 13)
        Me.LblItem.TabIndex = 17
        '
        'LblAlteracao
        '
        Me.LblAlteracao.AutoSize = True
        Me.LblAlteracao.Location = New System.Drawing.Point(856, 28)
        Me.LblAlteracao.Name = "LblAlteracao"
        Me.LblAlteracao.Size = New System.Drawing.Size(140, 13)
        Me.LblAlteracao.TabIndex = 16
        Me.LblAlteracao.Text = "C A D A S T R A M E N T O"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(583, 211)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(583, 184)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'MskDocNumero
        '
        Me.MskDocNumero.Location = New System.Drawing.Point(629, 119)
        Me.MskDocNumero.Mask = "#########"
        Me.MskDocNumero.Name = "MskDocNumero"
        Me.MskDocNumero.Size = New System.Drawing.Size(136, 20)
        Me.MskDocNumero.TabIndex = 6
        '
        'LabelDocNumero
        '
        Me.LabelDocNumero.AutoSize = True
        Me.LabelDocNumero.Location = New System.Drawing.Point(562, 123)
        Me.LabelDocNumero.Name = "LabelDocNumero"
        Me.LabelDocNumero.Size = New System.Drawing.Size(44, 13)
        Me.LabelDocNumero.TabIndex = 15
        Me.LabelDocNumero.Text = "Doc. N."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.MskTelefone)
        Me.GroupBox1.Controls.Add(Me.MskIndentifica)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.LblTelefone)
        Me.GroupBox1.Controls.Add(Me.LblCPF_CNPJ)
        Me.GroupBox1.Controls.Add(Me.LblIdentificacao)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 115)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione o Tipo de Credor"
        '
        'MskTelefone
        '
        Me.MskTelefone.Location = New System.Drawing.Point(128, 81)
        Me.MskTelefone.Mask = "(99) 00000-0000"
        Me.MskTelefone.Name = "MskTelefone"
        Me.MskTelefone.Size = New System.Drawing.Size(114, 20)
        Me.MskTelefone.TabIndex = 4
        '
        'MskIndentifica
        '
        Me.MskIndentifica.Location = New System.Drawing.Point(128, 18)
        Me.MskIndentifica.Name = "MskIndentifica"
        Me.MskIndentifica.Size = New System.Drawing.Size(114, 20)
        Me.MskIndentifica.TabIndex = 2
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(129, 46)
        Me.TxtNome.MaxLength = 30
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(307, 20)
        Me.TxtNome.TabIndex = 3
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.Location = New System.Drawing.Point(22, 84)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefone.TabIndex = 6
        Me.LblTelefone.Text = "Telefone"
        '
        'LblCPF_CNPJ
        '
        Me.LblCPF_CNPJ.AutoSize = True
        Me.LblCPF_CNPJ.Location = New System.Drawing.Point(22, 25)
        Me.LblCPF_CNPJ.Name = "LblCPF_CNPJ"
        Me.LblCPF_CNPJ.Size = New System.Drawing.Size(65, 13)
        Me.LblCPF_CNPJ.TabIndex = 5
        Me.LblCPF_CNPJ.Text = "CPF / CNPJ"
        '
        'LblIdentificacao
        '
        Me.LblIdentificacao.AutoSize = True
        Me.LblIdentificacao.Location = New System.Drawing.Point(21, 50)
        Me.LblIdentificacao.Name = "LblIdentificacao"
        Me.LblIdentificacao.Size = New System.Drawing.Size(103, 13)
        Me.LblIdentificacao.TabIndex = 4
        Me.LblIdentificacao.Text = "Razão Social/Nome"
        '
        'TxtHistorico
        '
        Me.TxtHistorico.Location = New System.Drawing.Point(72, 237)
        Me.TxtHistorico.MaxLength = 150
        Me.TxtHistorico.Name = "TxtHistorico"
        Me.TxtHistorico.Size = New System.Drawing.Size(848, 20)
        Me.TxtHistorico.TabIndex = 10
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(629, 148)
        Me.TxtValor.MaxLength = 15
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(110, 20)
        Me.TxtValor.TabIndex = 7
        Me.TxtValor.Text = "0,00"
        Me.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbFerramenta
        '
        Me.CmbFerramenta.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.CmbFerramenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFerramenta.FormattingEnabled = True
        Me.CmbFerramenta.Items.AddRange(New Object() {"", "Boleto", "Cartão de Débito", "Cartão de Crédito", "Fatura", "Nota Fiscal", "PIX", "Recibo"})
        Me.CmbFerramenta.Location = New System.Drawing.Point(629, 86)
        Me.CmbFerramenta.Name = "CmbFerramenta"
        Me.CmbFerramenta.Size = New System.Drawing.Size(137, 21)
        Me.CmbFerramenta.TabIndex = 5
        '
        'LabelCobranca
        '
        Me.LabelCobranca.AutoSize = True
        Me.LabelCobranca.Location = New System.Drawing.Point(514, 94)
        Me.LabelCobranca.Name = "LabelCobranca"
        Me.LabelCobranca.Size = New System.Drawing.Size(92, 13)
        Me.LabelCobranca.TabIndex = 10
        Me.LabelCobranca.Text = "Tipo de Cobrança"
        '
        'LabelDataVencimento
        '
        Me.LabelDataVencimento.AutoSize = True
        Me.LabelDataVencimento.Location = New System.Drawing.Point(474, 213)
        Me.LabelDataVencimento.Name = "LabelDataVencimento"
        Me.LabelDataVencimento.Size = New System.Drawing.Size(89, 13)
        Me.LabelDataVencimento.TabIndex = 8
        Me.LabelDataVencimento.Text = "Data Vencimento"
        '
        'Cmbcredor
        '
        Me.Cmbcredor.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.Cmbcredor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcredor.FormattingEnabled = True
        Me.Cmbcredor.Items.AddRange(New Object() {"", "Pessoa Juridica PJ", "Pessoa Fisica    PF"})
        Me.Cmbcredor.Location = New System.Drawing.Point(105, 68)
        Me.Cmbcredor.Name = "Cmbcredor"
        Me.Cmbcredor.Size = New System.Drawing.Size(168, 21)
        Me.Cmbcredor.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Incrementa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelHistorco
        '
        Me.LabelHistorco.AutoSize = True
        Me.LabelHistorco.Location = New System.Drawing.Point(12, 237)
        Me.LabelHistorco.Name = "LabelHistorco"
        Me.LabelHistorco.Size = New System.Drawing.Size(48, 13)
        Me.LabelHistorco.TabIndex = 4
        Me.LabelHistorco.Text = "Histórico"
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Location = New System.Drawing.Point(575, 155)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(31, 13)
        Me.LabelValor.TabIndex = 3
        Me.LabelValor.Text = "Valor"
        '
        'LabelDataOcorrencia
        '
        Me.LabelDataOcorrencia.AutoSize = True
        Me.LabelDataOcorrencia.Location = New System.Drawing.Point(474, 187)
        Me.LabelDataOcorrencia.Name = "LabelDataOcorrencia"
        Me.LabelDataOcorrencia.Size = New System.Drawing.Size(85, 13)
        Me.LabelDataOcorrencia.TabIndex = 2
        Me.LabelDataOcorrencia.Text = "Data Ocorrencia"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Location = New System.Drawing.Point(34, 76)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(62, 13)
        Me.LabelTipo.TabIndex = 1
        Me.LabelTipo.Text = "Credor Tipo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelTotalLancado)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1105, 277)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lançamentos a Gravar"
        '
        'LabelTotalLancado
        '
        Me.LabelTotalLancado.AutoSize = True
        Me.LabelTotalLancado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalLancado.Location = New System.Drawing.Point(944, 241)
        Me.LabelTotalLancado.Name = "LabelTotalLancado"
        Me.LabelTotalLancado.Size = New System.Drawing.Size(49, 24)
        Me.LabelTotalLancado.TabIndex = 5
        Me.LabelTotalLancado.Text = "0,00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(791, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "T O T A L   L A N Ç A D O ----->"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Gravar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(19, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1086, 216)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DT FATO"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DT PAG."
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TIPO"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CNPJ/CPF"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NOME"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TEL"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TIPO COBRANÇA"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "N.DOC"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "VALOR"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Historico"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Cod CC"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CC"
        '
        'BtnTermina
        '
        Me.BtnTermina.Location = New System.Drawing.Point(37, 604)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(133, 28)
        Me.BtnTermina.TabIndex = 3
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'FmrCPlancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 638)
        Me.Controls.Add(Me.BtnTermina)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmrCPlancamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C O N T A S   A   P A G A R   -  Lançamento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelTipo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelHistorco As Label
    Friend WithEvents LabelValor As Label
    Friend WithEvents LabelDataOcorrencia As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnTermina As Button
    Friend WithEvents TxtHistorico As TextBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents CmbFerramenta As ComboBox
    Friend WithEvents LabelCobranca As Label
    Friend WithEvents LabelDataVencimento As Label
    Friend WithEvents Cmbcredor As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblCPF_CNPJ As Label
    Friend WithEvents LblIdentificacao As Label
    Friend WithEvents MskTelefone As MaskedTextBox
    Friend WithEvents MskIndentifica As MaskedTextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents LblTelefone As Label
    Friend WithEvents LabelDocNumero As Label
    Friend WithEvents MskDocNumero As MaskedTextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents LabelTotalLancado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents LblItem As Label
    Friend WithEvents LblAlteracao As Label
    Friend WithEvents BtnDeleta As Button
    Friend WithEvents CmbCentroDeCusto As ComboBox
    Friend WithEvents LabelCentroDeCusto As Label
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
