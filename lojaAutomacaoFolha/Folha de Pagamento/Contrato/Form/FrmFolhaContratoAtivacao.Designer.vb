<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaContratoAtivacao
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
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.TxtNome_Pesq = New System.Windows.Forms.TextBox()
        Me.MskCPF_Pesq = New System.Windows.Forms.MaskedTextBox()
        Me.MskChave_Pesq = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnLiberacao = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.TxtNome_Pesq)
        Me.GroupBox1.Controls.Add(Me.MskCPF_Pesq)
        Me.GroupBox1.Controls.Add(Me.MskChave_Pesq)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Painel de Pesquisa"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(447, 63)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(191, 30)
        Me.BtnPesquisa.TabIndex = 5
        Me.BtnPesquisa.Text = "P E S Q U I S A"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'TxtNome_Pesq
        '
        Me.TxtNome_Pesq.Location = New System.Drawing.Point(108, 104)
        Me.TxtNome_Pesq.MaxLength = 40
        Me.TxtNome_Pesq.Name = "TxtNome_Pesq"
        Me.TxtNome_Pesq.Size = New System.Drawing.Size(530, 20)
        Me.TxtNome_Pesq.TabIndex = 4
        '
        'MskCPF_Pesq
        '
        Me.MskCPF_Pesq.Location = New System.Drawing.Point(108, 73)
        Me.MskCPF_Pesq.Mask = "###.###.###-##"
        Me.MskCPF_Pesq.Name = "MskCPF_Pesq"
        Me.MskCPF_Pesq.Size = New System.Drawing.Size(192, 20)
        Me.MskCPF_Pesq.TabIndex = 3
        '
        'MskChave_Pesq
        '
        Me.MskChave_Pesq.Location = New System.Drawing.Point(108, 39)
        Me.MskChave_Pesq.Mask = ">L0000"
        Me.MskChave_Pesq.Name = "MskChave_Pesq"
        Me.MskChave_Pesq.Size = New System.Drawing.Size(110, 20)
        Me.MskChave_Pesq.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chave"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(938, 327)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Colaboradores com Inatividade Para Contrato de Trabalho"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(923, 292)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Chave"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Colaborador"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CPF"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTO Contratos"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fim Ult.Contrato"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "OBS "
        Me.ColumnHeader6.Width = 250
        '
        'BtnLiberacao
        '
        Me.BtnLiberacao.Location = New System.Drawing.Point(25, 507)
        Me.BtnLiberacao.Name = "BtnLiberacao"
        Me.BtnLiberacao.Size = New System.Drawing.Size(191, 30)
        Me.BtnLiberacao.TabIndex = 6
        Me.BtnLiberacao.Text = "Libera para contrato"
        Me.BtnLiberacao.UseVisualStyleBackColor = True
        '
        'FrmFolhaContratoAtivacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 542)
        Me.Controls.Add(Me.BtnLiberacao)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaContratoAtivacao"
        Me.Text = "Folha de Pagamento - Ativação de cadastro para atução em Contrato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TxtNome_Pesq As TextBox
    Friend WithEvents MskCPF_Pesq As MaskedTextBox
    Friend WithEvents MskChave_Pesq As MaskedTextBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents BtnLiberacao As Button
End Class
