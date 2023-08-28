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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.MskIndentifica = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.LblCPF_CNPJ = New System.Windows.Forms.Label()
        Me.LblIdentificacao = New System.Windows.Forms.Label()
        Me.TTxtHistorico = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.CmbFerramenta = New System.Windows.Forms.ComboBox()
        Me.LabelCobranca = New System.Windows.Forms.Label()
        Me.LabelDataVencimento = New System.Windows.Forms.Label()
        Me.Cmbcredor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.LabelDataOcorrencia = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.LabelDocNumero = New System.Windows.Forms.Label()
        Me.MskDocNumero = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.MskDocNumero)
        Me.GroupBox2.Controls.Add(Me.LabelDocNumero)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TTxtHistorico)
        Me.GroupBox2.Controls.Add(Me.TxtValor)
        Me.GroupBox2.Controls.Add(Me.CmbFerramenta)
        Me.GroupBox2.Controls.Add(Me.LabelCobranca)
        Me.GroupBox2.Controls.Add(Me.LabelDataVencimento)
        Me.GroupBox2.Controls.Add(Me.Cmbcredor)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LabelValor)
        Me.GroupBox2.Controls.Add(Me.LabelDataOcorrencia)
        Me.GroupBox2.Controls.Add(Me.LabelTipo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 325)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "L A N Ç A M E N T O"
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 65)
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
        'TTxtHistorico
        '
        Me.TTxtHistorico.Location = New System.Drawing.Point(72, 264)
        Me.TTxtHistorico.MaxLength = 150
        Me.TTxtHistorico.Name = "TTxtHistorico"
        Me.TTxtHistorico.Size = New System.Drawing.Size(682, 20)
        Me.TTxtHistorico.TabIndex = 11
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(626, 142)
        Me.TxtValor.MaxLength = 15
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(110, 20)
        Me.TxtValor.TabIndex = 7
        '
        'CmbFerramenta
        '
        Me.CmbFerramenta.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.CmbFerramenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFerramenta.FormattingEnabled = True
        Me.CmbFerramenta.Items.AddRange(New Object() {"Boleto", "Fatura", "Nota Fiscal", "Recibo"})
        Me.CmbFerramenta.Location = New System.Drawing.Point(626, 28)
        Me.CmbFerramenta.Name = "CmbFerramenta"
        Me.CmbFerramenta.Size = New System.Drawing.Size(137, 21)
        Me.CmbFerramenta.TabIndex = 5
        '
        'LabelCobranca
        '
        Me.LabelCobranca.AutoSize = True
        Me.LabelCobranca.Location = New System.Drawing.Point(511, 36)
        Me.LabelCobranca.Name = "LabelCobranca"
        Me.LabelCobranca.Size = New System.Drawing.Size(92, 13)
        Me.LabelCobranca.TabIndex = 10
        Me.LabelCobranca.Text = "Tipo de Cobrança"
        '
        'LabelDataVencimento
        '
        Me.LabelDataVencimento.AutoSize = True
        Me.LabelDataVencimento.Location = New System.Drawing.Point(13, 230)
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
        Me.Cmbcredor.Items.AddRange(New Object() {"Pessoa Juridica PJ", "Pessoa Fisica    PF"})
        Me.Cmbcredor.Location = New System.Drawing.Point(95, 23)
        Me.Cmbcredor.Name = "Cmbcredor"
        Me.Cmbcredor.Size = New System.Drawing.Size(168, 21)
        Me.Cmbcredor.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Incrementa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Histórico"
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Location = New System.Drawing.Point(572, 145)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(31, 13)
        Me.LabelValor.TabIndex = 3
        Me.LabelValor.Text = "Valor"
        '
        'LabelDataOcorrencia
        '
        Me.LabelDataOcorrencia.AutoSize = True
        Me.LabelDataOcorrencia.Location = New System.Drawing.Point(13, 204)
        Me.LabelDataOcorrencia.Name = "LabelDataOcorrencia"
        Me.LabelDataOcorrencia.Size = New System.Drawing.Size(85, 13)
        Me.LabelDataOcorrencia.TabIndex = 2
        Me.LabelDataOcorrencia.Text = "Data Ocorrencia"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Location = New System.Drawing.Point(13, 31)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(62, 13)
        Me.LabelTipo.TabIndex = 1
        Me.LabelTipo.Text = "Credor Tipo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(774, 219)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lançamentos a Gravar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(624, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Gravar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 22)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(729, 158)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BtnTermina
        '
        Me.BtnTermina.Location = New System.Drawing.Point(13, 559)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(150, 28)
        Me.BtnTermina.TabIndex = 3
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'LabelDocNumero
        '
        Me.LabelDocNumero.AutoSize = True
        Me.LabelDocNumero.Location = New System.Drawing.Point(559, 83)
        Me.LabelDocNumero.Name = "LabelDocNumero"
        Me.LabelDocNumero.Size = New System.Drawing.Size(44, 13)
        Me.LabelDocNumero.TabIndex = 15
        Me.LabelDocNumero.Text = "Doc. N."
        '
        'MskDocNumero
        '
        Me.MskDocNumero.Location = New System.Drawing.Point(622, 79)
        Me.MskDocNumero.Mask = "#########"
        Me.MskDocNumero.Name = "MskDocNumero"
        Me.MskDocNumero.Size = New System.Drawing.Size(140, 20)
        Me.MskDocNumero.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 201)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(122, 228)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'FmrCPlancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 597)
        Me.Controls.Add(Me.BtnTermina)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FmrCPlancamento"
        Me.Text = "C O N T A S   A   P A G A R   -  Lançamento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelTipo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelValor As Label
    Friend WithEvents LabelDataOcorrencia As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnTermina As Button
    Friend WithEvents TTxtHistorico As TextBox
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
End Class
