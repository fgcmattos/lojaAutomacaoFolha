<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartaoManutencao
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
        Me.GpbPainel = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.MskFaturaPesq = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MskSegurancaPesq = New System.Windows.Forms.MaskedTextBox()
        Me.MskVencimentoPesq = New System.Windows.Forms.MaskedTextBox()
        Me.MskNumeroPesq = New System.Windows.Forms.MaskedTextBox()
        Me.CmbBandeiraPesq = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MskFatura = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtoLimpa = New System.Windows.Forms.Button()
        Me.BtoGrava = New System.Windows.Forms.Button()
        Me.MskSeguranca = New System.Windows.Forms.MaskedTextBox()
        Me.MskValidade = New System.Windows.Forms.MaskedTextBox()
        Me.MskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.CmbBandeira = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btotermina = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lid = New System.Windows.Forms.Label()
        Me.GpbPainel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpbPainel
        '
        Me.GpbPainel.Controls.Add(Me.BtnPesquisa)
        Me.GpbPainel.Controls.Add(Me.MskFaturaPesq)
        Me.GpbPainel.Controls.Add(Me.Label6)
        Me.GpbPainel.Controls.Add(Me.MskSegurancaPesq)
        Me.GpbPainel.Controls.Add(Me.MskVencimentoPesq)
        Me.GpbPainel.Controls.Add(Me.MskNumeroPesq)
        Me.GpbPainel.Controls.Add(Me.CmbBandeiraPesq)
        Me.GpbPainel.Controls.Add(Me.Label7)
        Me.GpbPainel.Controls.Add(Me.Label8)
        Me.GpbPainel.Controls.Add(Me.Label9)
        Me.GpbPainel.Controls.Add(Me.Label10)
        Me.GpbPainel.Location = New System.Drawing.Point(304, 14)
        Me.GpbPainel.Name = "GpbPainel"
        Me.GpbPainel.Size = New System.Drawing.Size(281, 255)
        Me.GpbPainel.TabIndex = 0
        Me.GpbPainel.TabStop = False
        Me.GpbPainel.Text = "Painel de Pesquisa"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(187, 183)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(88, 26)
        Me.BtnPesquisa.TabIndex = 27
        Me.BtnPesquisa.Text = "Pesquisar"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'MskFaturaPesq
        '
        Me.MskFaturaPesq.Location = New System.Drawing.Point(129, 187)
        Me.MskFaturaPesq.Mask = "00"
        Me.MskFaturaPesq.Name = "MskFaturaPesq"
        Me.MskFaturaPesq.Size = New System.Drawing.Size(45, 20)
        Me.MskFaturaPesq.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fatura"
        '
        'MskSegurancaPesq
        '
        Me.MskSegurancaPesq.Location = New System.Drawing.Point(129, 145)
        Me.MskSegurancaPesq.Mask = "000"
        Me.MskSegurancaPesq.Name = "MskSegurancaPesq"
        Me.MskSegurancaPesq.Size = New System.Drawing.Size(45, 20)
        Me.MskSegurancaPesq.TabIndex = 24
        '
        'MskVencimentoPesq
        '
        Me.MskVencimentoPesq.Location = New System.Drawing.Point(129, 106)
        Me.MskVencimentoPesq.Mask = "00/00"
        Me.MskVencimentoPesq.Name = "MskVencimentoPesq"
        Me.MskVencimentoPesq.Size = New System.Drawing.Size(45, 20)
        Me.MskVencimentoPesq.TabIndex = 23
        '
        'MskNumeroPesq
        '
        Me.MskNumeroPesq.Location = New System.Drawing.Point(95, 65)
        Me.MskNumeroPesq.Mask = "0000-0000-0000-0000"
        Me.MskNumeroPesq.Name = "MskNumeroPesq"
        Me.MskNumeroPesq.Size = New System.Drawing.Size(132, 20)
        Me.MskNumeroPesq.TabIndex = 22
        '
        'CmbBandeiraPesq
        '
        Me.CmbBandeiraPesq.FormattingEnabled = True
        Me.CmbBandeiraPesq.Items.AddRange(New Object() {"VISA", "MASTERCAD", "ELO"})
        Me.CmbBandeiraPesq.Location = New System.Drawing.Point(95, 25)
        Me.CmbBandeiraPesq.Name = "CmbBandeiraPesq"
        Me.CmbBandeiraPesq.Size = New System.Drawing.Size(132, 21)
        Me.CmbBandeiraPesq.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Segurança"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Vencimento MM/AA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Número"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Bandeira"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lid)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.MskFatura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtoLimpa)
        Me.GroupBox1.Controls.Add(Me.BtoGrava)
        Me.GroupBox1.Controls.Add(Me.MskSeguranca)
        Me.GroupBox1.Controls.Add(Me.MskValidade)
        Me.GroupBox1.Controls.Add(Me.MskNumero)
        Me.GroupBox1.Controls.Add(Me.CmbBandeira)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 257)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cartão de Crédito - Manutenção"
        '
        'MskFatura
        '
        Me.MskFatura.Location = New System.Drawing.Point(128, 215)
        Me.MskFatura.Mask = "00"
        Me.MskFatura.Name = "MskFatura"
        Me.MskFatura.Size = New System.Drawing.Size(45, 20)
        Me.MskFatura.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fatura"
        '
        'BtoLimpa
        '
        Me.BtoLimpa.Location = New System.Drawing.Point(189, 211)
        Me.BtoLimpa.Name = "BtoLimpa"
        Me.BtoLimpa.Size = New System.Drawing.Size(88, 26)
        Me.BtoLimpa.TabIndex = 13
        Me.BtoLimpa.Text = "Limpar"
        Me.BtoLimpa.UseVisualStyleBackColor = True
        '
        'BtoGrava
        '
        Me.BtoGrava.Location = New System.Drawing.Point(189, 178)
        Me.BtoGrava.Name = "BtoGrava"
        Me.BtoGrava.Size = New System.Drawing.Size(88, 26)
        Me.BtoGrava.TabIndex = 12
        Me.BtoGrava.Text = "Gravar"
        Me.BtoGrava.UseVisualStyleBackColor = True
        '
        'MskSeguranca
        '
        Me.MskSeguranca.Location = New System.Drawing.Point(128, 178)
        Me.MskSeguranca.Mask = "000"
        Me.MskSeguranca.Name = "MskSeguranca"
        Me.MskSeguranca.Size = New System.Drawing.Size(45, 20)
        Me.MskSeguranca.TabIndex = 11
        '
        'MskValidade
        '
        Me.MskValidade.Location = New System.Drawing.Point(128, 132)
        Me.MskValidade.Mask = "00/00"
        Me.MskValidade.Name = "MskValidade"
        Me.MskValidade.Size = New System.Drawing.Size(45, 20)
        Me.MskValidade.TabIndex = 10
        '
        'MskNumero
        '
        Me.MskNumero.Location = New System.Drawing.Point(94, 86)
        Me.MskNumero.Mask = "0000-0000-0000-0000"
        Me.MskNumero.Name = "MskNumero"
        Me.MskNumero.Size = New System.Drawing.Size(132, 20)
        Me.MskNumero.TabIndex = 9
        '
        'CmbBandeira
        '
        Me.CmbBandeira.FormattingEnabled = True
        Me.CmbBandeira.Items.AddRange(New Object() {"VISA", "MASTERCAD", "ELO"})
        Me.CmbBandeira.Location = New System.Drawing.Point(94, 53)
        Me.CmbBandeira.Name = "CmbBandeira"
        Me.CmbBandeira.Size = New System.Drawing.Size(132, 21)
        Me.CmbBandeira.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Segurança"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Validade MM/AA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bandeira"
        '
        'Btotermina
        '
        Me.Btotermina.Location = New System.Drawing.Point(5, 275)
        Me.Btotermina.Name = "Btotermina"
        Me.Btotermina.Size = New System.Drawing.Size(88, 26)
        Me.Btotermina.TabIndex = 15
        Me.Btotermina.Text = "Terminar"
        Me.Btotermina.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ID"
        '
        'Lid
        '
        Me.Lid.AutoSize = True
        Me.Lid.Location = New System.Drawing.Point(92, 30)
        Me.Lid.Name = "Lid"
        Me.Lid.Size = New System.Drawing.Size(0, 13)
        Me.Lid.TabIndex = 18
        '
        'frmCartaoManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 313)
        Me.Controls.Add(Me.Btotermina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpbPainel)
        Me.Name = "frmCartaoManutencao"
        Me.Text = "CARTÃO - Manutenção"
        Me.GpbPainel.ResumeLayout(False)
        Me.GpbPainel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GpbPainel As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MskFatura As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtoLimpa As Button
    Friend WithEvents BtoGrava As Button
    Friend WithEvents MskSeguranca As MaskedTextBox
    Friend WithEvents MskValidade As MaskedTextBox
    Friend WithEvents MskNumero As MaskedTextBox
    Friend WithEvents CmbBandeira As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents MskFaturaPesq As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MskSegurancaPesq As MaskedTextBox
    Friend WithEvents MskVencimentoPesq As MaskedTextBox
    Friend WithEvents MskNumeroPesq As MaskedTextBox
    Friend WithEvents CmbBandeiraPesq As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Btotermina As Button
    Friend WithEvents Lid As Label
    Friend WithEvents Label11 As Label
End Class
