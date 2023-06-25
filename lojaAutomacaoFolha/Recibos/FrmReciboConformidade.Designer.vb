<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReciboConformidade
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
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.BtnImprimeResumo = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtHistorico = New System.Windows.Forms.TextBox()
        Me.MskDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.MskAssinatura = New System.Windows.Forms.MaskedTextBox()
        Me.MskEmissao = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFavorecido = New System.Windows.Forms.TextBox()
        Me.MskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnTermina)
        Me.GroupBox2.Controls.Add(Me.BtnImprimeResumo)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1033, 398)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "S H O W  D A   P E S Q U I S A"
        '
        'BtnTermina
        '
        Me.BtnTermina.Location = New System.Drawing.Point(787, 362)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(240, 30)
        Me.BtnTermina.TabIndex = 2
        Me.BtnTermina.Text = "T E R M I N A"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'BtnImprimeResumo
        '
        Me.BtnImprimeResumo.Location = New System.Drawing.Point(11, 362)
        Me.BtnImprimeResumo.Name = "BtnImprimeResumo"
        Me.BtnImprimeResumo.Size = New System.Drawing.Size(240, 30)
        Me.BtnImprimeResumo.TabIndex = 1
        Me.BtnImprimeResumo.Text = "IMPRIME RESUMO"
        Me.BtnImprimeResumo.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(11, 18)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1016, 336)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "Número"
        Me.ColumnHeader0.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Favorecido"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Emissão"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Assinatura"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tipo"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descrição"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Descrição"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Imagem"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CmbStatus)
        Me.GroupBox1.Controls.Add(Me.CmbTipo)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.TxtValor)
        Me.GroupBox1.Controls.Add(Me.TxtHistorico)
        Me.GroupBox1.Controls.Add(Me.MskDocumento)
        Me.GroupBox1.Controls.Add(Me.MskAssinatura)
        Me.GroupBox1.Controls.Add(Me.MskEmissao)
        Me.GroupBox1.Controls.Add(Me.TxtFavorecido)
        Me.GroupBox1.Controls.Add(Me.MskNumero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1034, 206)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P A I N E L  D E   P E S Q U I S A"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Location = New System.Drawing.Point(645, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 142)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "T O T A I S   A P U R A D O S"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.SystemColors.Info
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(7, 15)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(359, 121)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Origem"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "QTO"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Valor(R$)"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(553, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "< -------------Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(553, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "< ----------------Tipo"
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"TODOS", "Impressos", "Assinados", "Destruidos", "Cancelados"})
        Me.CmbStatus.Location = New System.Drawing.Point(398, 75)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(149, 21)
        Me.CmbStatus.TabIndex = 23
        '
        'CmbTipo
        '
        Me.CmbTipo.DisplayMember = "item2"
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"0,TODOS", "1,Colaboradores", "2,Fornecedores", "3,Geral"})
        Me.CmbTipo.Location = New System.Drawing.Point(398, 40)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(149, 21)
        Me.CmbTipo.TabIndex = 22
        Me.CmbTipo.ValueMember = "item1"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.BackColor = System.Drawing.Color.Green
        Me.BtnPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisa.Location = New System.Drawing.Point(644, 164)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(367, 35)
        Me.BtnPesquisa.TabIndex = 21
        Me.BtnPesquisa.Text = "P E S Q U I S A"
        Me.BtnPesquisa.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(103, 127)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(114, 20)
        Me.TxtValor.TabIndex = 20
        '
        'TxtHistorico
        '
        Me.TxtHistorico.Location = New System.Drawing.Point(103, 179)
        Me.TxtHistorico.Name = "TxtHistorico"
        Me.TxtHistorico.Size = New System.Drawing.Size(535, 20)
        Me.TxtHistorico.TabIndex = 19
        '
        'MskDocumento
        '
        Me.MskDocumento.Location = New System.Drawing.Point(103, 153)
        Me.MskDocumento.Mask = "00000000000000"
        Me.MskDocumento.Name = "MskDocumento"
        Me.MskDocumento.Size = New System.Drawing.Size(118, 20)
        Me.MskDocumento.TabIndex = 18
        Me.MskDocumento.ValidatingType = GetType(Date)
        '
        'MskAssinatura
        '
        Me.MskAssinatura.Location = New System.Drawing.Point(102, 101)
        Me.MskAssinatura.Mask = "00/00/0000"
        Me.MskAssinatura.Name = "MskAssinatura"
        Me.MskAssinatura.Size = New System.Drawing.Size(118, 20)
        Me.MskAssinatura.TabIndex = 17
        Me.MskAssinatura.ValidatingType = GetType(Date)
        '
        'MskEmissao
        '
        Me.MskEmissao.Location = New System.Drawing.Point(102, 75)
        Me.MskEmissao.Mask = "00/00/0000"
        Me.MskEmissao.Name = "MskEmissao"
        Me.MskEmissao.Size = New System.Drawing.Size(118, 20)
        Me.MskEmissao.TabIndex = 16
        Me.MskEmissao.ValidatingType = GetType(Date)
        '
        'TxtFavorecido
        '
        Me.TxtFavorecido.Location = New System.Drawing.Point(103, 16)
        Me.TxtFavorecido.Name = "TxtFavorecido"
        Me.TxtFavorecido.Size = New System.Drawing.Size(536, 20)
        Me.TxtFavorecido.TabIndex = 15
        '
        'MskNumero
        '
        Me.MskNumero.Location = New System.Drawing.Point(103, 42)
        Me.MskNumero.Mask = "0000.00.0000"
        Me.MskNumero.Name = "MskNumero"
        Me.MskNumero.Size = New System.Drawing.Size(118, 20)
        Me.MskNumero.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Documento--->"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Histórico-------->"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor-------------->"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Assinatura----->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Emissão-------->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Favorecido---->"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N° ---------------->"
        '
        'FrmReciboConformidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 632)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReciboConformidade"
        Me.Text = "R E C I B O - C O N T R O L E  D E  C O N F O R M I D A D E"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnTermina As Button
    Friend WithEvents BtnImprimeResumo As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtHistorico As TextBox
    Friend WithEvents MskDocumento As MaskedTextBox
    Friend WithEvents MskAssinatura As MaskedTextBox
    Friend WithEvents MskEmissao As MaskedTextBox
    Friend WithEvents TxtFavorecido As TextBox
    Friend WithEvents MskNumero As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
