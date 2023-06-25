<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaContratoDeTrabalhoPesquisa
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
        Me.GruPesquisa = New System.Windows.Forms.GroupBox()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.CmbSetor = New System.Windows.Forms.ComboBox()
        Me.TxtNomePesquisa = New System.Windows.Forms.TextBox()
        Me.TxtChavePesquisa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNomePesquisa = New System.Windows.Forms.Label()
        Me.LblChavepesquisa = New System.Windows.Forms.Label()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.lvSlecao = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GruPesquisa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruPesquisa
        '
        Me.GruPesquisa.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GruPesquisa.Controls.Add(Me.TxtSalario)
        Me.GruPesquisa.Controls.Add(Me.CmbStatus)
        Me.GruPesquisa.Controls.Add(Me.CmbCargo)
        Me.GruPesquisa.Controls.Add(Me.CmbSetor)
        Me.GruPesquisa.Controls.Add(Me.TxtNomePesquisa)
        Me.GruPesquisa.Controls.Add(Me.TxtChavePesquisa)
        Me.GruPesquisa.Controls.Add(Me.Label4)
        Me.GruPesquisa.Controls.Add(Me.Label3)
        Me.GruPesquisa.Controls.Add(Me.Label2)
        Me.GruPesquisa.Controls.Add(Me.Label1)
        Me.GruPesquisa.Controls.Add(Me.LblNomePesquisa)
        Me.GruPesquisa.Controls.Add(Me.LblChavepesquisa)
        Me.GruPesquisa.Controls.Add(Me.BtnPesquisa)
        Me.GruPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruPesquisa.Location = New System.Drawing.Point(1, 2)
        Me.GruPesquisa.Name = "GruPesquisa"
        Me.GruPesquisa.Size = New System.Drawing.Size(850, 108)
        Me.GruPesquisa.TabIndex = 1
        Me.GruPesquisa.TabStop = False
        Me.GruPesquisa.Text = "Painel de Pesquisa"
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(440, 21)
        Me.TxtSalario.MaxLength = 14
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(101, 20)
        Me.TxtSalario.TabIndex = 12
        Me.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(233, 18)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(130, 21)
        Me.CmbStatus.TabIndex = 10
        '
        'CmbCargo
        '
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(359, 70)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(182, 21)
        Me.CmbCargo.TabIndex = 8
        '
        'CmbSetor
        '
        Me.CmbSetor.FormattingEnabled = True
        Me.CmbSetor.Location = New System.Drawing.Point(59, 68)
        Me.CmbSetor.Name = "CmbSetor"
        Me.CmbSetor.Size = New System.Drawing.Size(182, 21)
        Me.CmbSetor.TabIndex = 6
        '
        'TxtNomePesquisa
        '
        Me.TxtNomePesquisa.Location = New System.Drawing.Point(59, 45)
        Me.TxtNomePesquisa.MaxLength = 45
        Me.TxtNomePesquisa.Name = "TxtNomePesquisa"
        Me.TxtNomePesquisa.Size = New System.Drawing.Size(482, 20)
        Me.TxtNomePesquisa.TabIndex = 3
        '
        'TxtChavePesquisa
        '
        Me.TxtChavePesquisa.Location = New System.Drawing.Point(59, 19)
        Me.TxtChavePesquisa.MaxLength = 14
        Me.TxtChavePesquisa.Name = "TxtChavePesquisa"
        Me.TxtChavePesquisa.Size = New System.Drawing.Size(82, 20)
        Me.TxtChavePesquisa.TabIndex = 2
        Me.TxtChavePesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(396, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Salário:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(189, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(315, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cargo:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Setor:"
        '
        'LblNomePesquisa
        '
        Me.LblNomePesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomePesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNomePesquisa.Location = New System.Drawing.Point(15, 45)
        Me.LblNomePesquisa.Name = "LblNomePesquisa"
        Me.LblNomePesquisa.Size = New System.Drawing.Size(49, 20)
        Me.LblNomePesquisa.TabIndex = 1
        Me.LblNomePesquisa.Text = "Nome:"
        '
        'LblChavepesquisa
        '
        Me.LblChavepesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblChavepesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblChavepesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblChavepesquisa.Location = New System.Drawing.Point(15, 19)
        Me.LblChavepesquisa.Name = "LblChavepesquisa"
        Me.LblChavepesquisa.Size = New System.Drawing.Size(49, 19)
        Me.LblChavepesquisa.TabIndex = 0
        Me.LblChavepesquisa.Text = "Chave:"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPesquisa.Location = New System.Drawing.Point(574, 70)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(147, 20)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'lvSlecao
        '
        Me.lvSlecao.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvSlecao.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvSlecao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lvSlecao.FullRowSelect = True
        Me.lvSlecao.GridLines = True
        Me.lvSlecao.HideSelection = False
        Me.lvSlecao.Location = New System.Drawing.Point(6, 19)
        Me.lvSlecao.Name = "lvSlecao"
        Me.lvSlecao.Size = New System.Drawing.Size(838, 232)
        Me.lvSlecao.TabIndex = 2
        Me.lvSlecao.UseCompatibleStateImageBehavior = False
        Me.lvSlecao.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Chave"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contrato"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nome"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Setor"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cargo"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Salário"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvSlecao)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 256)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleção de Contrato"
        '
        'FrmFolhaContratoDeTrabalhoPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 403)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GruPesquisa)
        Me.Name = "FrmFolhaContratoDeTrabalhoPesquisa"
        Me.Text = "Folha Pagamento - Contrato Pesquisa"
        Me.GruPesquisa.ResumeLayout(False)
        Me.GruPesquisa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruPesquisa As GroupBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents TxtNomePesquisa As TextBox
    Friend WithEvents TxtChavePesquisa As TextBox
    Friend WithEvents LblNomePesquisa As Label
    Friend WithEvents LblChavepesquisa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbSetor As ComboBox
    Friend WithEvents lvSlecao As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
