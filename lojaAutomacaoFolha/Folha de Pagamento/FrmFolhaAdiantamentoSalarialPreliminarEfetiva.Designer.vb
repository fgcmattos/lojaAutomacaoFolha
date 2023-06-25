<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaAdiantamentoSalarialPreliminarEfetiva
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
        Me.GruReferenciaPesquisa = New System.Windows.Forms.GroupBox()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BntCancelaAdiantamento = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MskTotalAdiantamento = New System.Windows.Forms.MaskedTextBox()
        Me.MskColaboradores = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GruvVariavelPagamento = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MskPorcentagemDoSalario = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEfetiva = New System.Windows.Forms.Button()
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GruReferenciaPesquisa.SuspendLayout()
        Me.GruvVariavelPagamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruReferenciaPesquisa
        '
        Me.GruReferenciaPesquisa.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruReferenciaPesquisa.Controls.Add(Me.BtnSai)
        Me.GruReferenciaPesquisa.Controls.Add(Me.BntCancelaAdiantamento)
        Me.GruReferenciaPesquisa.Controls.Add(Me.DateTimePicker1)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskTotalAdiantamento)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskColaboradores)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label5)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label4)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label3)
        Me.GruReferenciaPesquisa.Controls.Add(Me.GruvVariavelPagamento)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskPorcentagemDoSalario)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label2)
        Me.GruReferenciaPesquisa.Controls.Add(Me.BtnEfetiva)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskReferencia)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label1)
        Me.GruReferenciaPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruReferenciaPesquisa.Location = New System.Drawing.Point(2, 2)
        Me.GruReferenciaPesquisa.Name = "GruReferenciaPesquisa"
        Me.GruReferenciaPesquisa.Size = New System.Drawing.Size(922, 207)
        Me.GruReferenciaPesquisa.TabIndex = 1
        Me.GruReferenciaPesquisa.TabStop = False
        Me.GruReferenciaPesquisa.Text = "Pesquisa de Referência - MM/AAAA"
        '
        'BtnSai
        '
        Me.BtnSai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSai.Location = New System.Drawing.Point(569, 178)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(273, 23)
        Me.BtnSai.TabIndex = 25
        Me.BtnSai.Text = "Sair da Tela"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BntCancelaAdiantamento
        '
        Me.BntCancelaAdiantamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BntCancelaAdiantamento.Location = New System.Drawing.Point(290, 178)
        Me.BntCancelaAdiantamento.Name = "BntCancelaAdiantamento"
        Me.BntCancelaAdiantamento.Size = New System.Drawing.Size(273, 23)
        Me.BntCancelaAdiantamento.TabIndex = 24
        Me.BntCancelaAdiantamento.Text = "Cancela Adiantamento"
        Me.BntCancelaAdiantamento.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(184, 132)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(223, 20)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Visible = False
        '
        'MskTotalAdiantamento
        '
        Me.MskTotalAdiantamento.Enabled = False
        Me.MskTotalAdiantamento.Location = New System.Drawing.Point(184, 100)
        Me.MskTotalAdiantamento.Name = "MskTotalAdiantamento"
        Me.MskTotalAdiantamento.Size = New System.Drawing.Size(100, 20)
        Me.MskTotalAdiantamento.TabIndex = 23
        '
        'MskColaboradores
        '
        Me.MskColaboradores.Enabled = False
        Me.MskColaboradores.Location = New System.Drawing.Point(184, 72)
        Me.MskColaboradores.Mask = "00000"
        Me.MskColaboradores.Name = "MskColaboradores"
        Me.MskColaboradores.Size = New System.Drawing.Size(100, 20)
        Me.MskColaboradores.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Número de Colaboradores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Valor Total do Adiantamento R$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data do Pagamento"
        '
        'GruvVariavelPagamento
        '
        Me.GruvVariavelPagamento.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruvVariavelPagamento.Controls.Add(Me.ListBox1)
        Me.GruvVariavelPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruvVariavelPagamento.Location = New System.Drawing.Point(420, 13)
        Me.GruvVariavelPagamento.Name = "GruvVariavelPagamento"
        Me.GruvVariavelPagamento.Size = New System.Drawing.Size(496, 151)
        Me.GruvVariavelPagamento.TabIndex = 8
        Me.GruvVariavelPagamento.TabStop = False
        Me.GruvVariavelPagamento.Text = "Adiantamentos Pendentes de Efetivação"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(484, 121)
        Me.ListBox1.TabIndex = 0
        '
        'MskPorcentagemDoSalario
        '
        Me.MskPorcentagemDoSalario.Enabled = False
        Me.MskPorcentagemDoSalario.Location = New System.Drawing.Point(184, 48)
        Me.MskPorcentagemDoSalario.Mask = "00.00"
        Me.MskPorcentagemDoSalario.Name = "MskPorcentagemDoSalario"
        Me.MskPorcentagemDoSalario.Size = New System.Drawing.Size(100, 20)
        Me.MskPorcentagemDoSalario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porcentagem do Salário (%)"
        '
        'BtnEfetiva
        '
        Me.BtnEfetiva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEfetiva.Location = New System.Drawing.Point(11, 178)
        Me.BtnEfetiva.Name = "BtnEfetiva"
        Me.BtnEfetiva.Size = New System.Drawing.Size(273, 23)
        Me.BtnEfetiva.TabIndex = 2
        Me.BtnEfetiva.Text = "Efetivar"
        Me.BtnEfetiva.UseVisualStyleBackColor = True
        '
        'MskReferencia
        '
        Me.MskReferencia.Enabled = False
        Me.MskReferencia.Location = New System.Drawing.Point(184, 24)
        Me.MskReferencia.Mask = "00/0000"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(100, 20)
        Me.MskReferencia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referência"
        '
        'FrmFolhaAdiantamentoSalarialPreliminarEfetiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 450)
        Me.Controls.Add(Me.GruReferenciaPesquisa)
        Me.Name = "FrmFolhaAdiantamentoSalarialPreliminarEfetiva"
        Me.Text = "Folha - Efetiva Adiantamento Salarial"
        Me.GruReferenciaPesquisa.ResumeLayout(False)
        Me.GruReferenciaPesquisa.PerformLayout()
        Me.GruvVariavelPagamento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruReferenciaPesquisa As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GruvVariavelPagamento As GroupBox
    Friend WithEvents MskPorcentagemDoSalario As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEfetiva As Button
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MskTotalAdiantamento As MaskedTextBox
    Friend WithEvents MskColaboradores As MaskedTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnSai As Button
    Friend WithEvents BntCancelaAdiantamento As Button
End Class
