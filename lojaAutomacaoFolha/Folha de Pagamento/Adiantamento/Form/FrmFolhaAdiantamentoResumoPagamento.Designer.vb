<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaAdiantamentoResumoPagamento
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
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblSomaParaDeposito = New System.Windows.Forms.Label()
        Me.Lblextenso = New System.Windows.Forms.Label()
        Me.BtnImprime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.MskReferencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(17, 76)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(126, 20)
        Me.BtnPesquisa.TabIndex = 2
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(79, 33)
        Me.MskReferencia.Mask = "00/0000"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(69, 20)
        Me.MskReferencia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referência"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lblextenso)
        Me.GroupBox2.Controls.Add(Me.LblSomaParaDeposito)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(18, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(926, 305)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(876, 234)
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
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Banco"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Agência"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Conta"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Dig"
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PIX"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PIX Id"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Valor"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 120
        '
        'LblSomaParaDeposito
        '
        Me.LblSomaParaDeposito.AutoSize = True
        Me.LblSomaParaDeposito.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSomaParaDeposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSomaParaDeposito.Location = New System.Drawing.Point(808, 266)
        Me.LblSomaParaDeposito.Name = "LblSomaParaDeposito"
        Me.LblSomaParaDeposito.Size = New System.Drawing.Size(61, 15)
        Me.LblSomaParaDeposito.TabIndex = 1
        Me.LblSomaParaDeposito.Text = "Referência"
        '
        'Lblextenso
        '
        Me.Lblextenso.AutoSize = True
        Me.Lblextenso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lblextenso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblextenso.Location = New System.Drawing.Point(437, 287)
        Me.Lblextenso.Name = "Lblextenso"
        Me.Lblextenso.Size = New System.Drawing.Size(61, 15)
        Me.Lblextenso.TabIndex = 2
        Me.Lblextenso.Text = "Referência"
        '
        'BtnImprime
        '
        Me.BtnImprime.Location = New System.Drawing.Point(774, 488)
        Me.BtnImprime.Name = "BtnImprime"
        Me.BtnImprime.Size = New System.Drawing.Size(126, 20)
        Me.BtnImprime.TabIndex = 3
        Me.BtnImprime.Text = "Imprimir"
        Me.BtnImprime.UseVisualStyleBackColor = True
        '
        'FrmFolhaAdiantamentoResumoPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 525)
        Me.Controls.Add(Me.BtnImprime)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFolhaAdiantamentoResumoPagamento"
        Me.Text = "Folha de Pagamento - Adiantamento Resumo de pagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents LblSomaParaDeposito As Label
    Friend WithEvents Lblextenso As Label
    Friend WithEvents BtnImprime As Button
End Class
