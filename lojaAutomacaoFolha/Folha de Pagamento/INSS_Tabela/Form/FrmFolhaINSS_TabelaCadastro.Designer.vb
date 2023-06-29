<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFolhaINSS_TabelaCadastro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblFaixa = New System.Windows.Forms.Label()
        Me.TxtImpostoFaixaAcumulado = New System.Windows.Forms.TextBox()
        Me.TxtImpostoFaixa = New System.Windows.Forms.TextBox()
        Me.TxtPorcentagemFaixa = New System.Windows.Forms.TextBox()
        Me.TxtValorFaixa = New System.Windows.Forms.TextBox()
        Me.BtnIncrementa = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnLiberaEdicao = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblFaixa)
        Me.GroupBox2.Controls.Add(Me.TxtImpostoFaixaAcumulado)
        Me.GroupBox2.Controls.Add(Me.TxtImpostoFaixa)
        Me.GroupBox2.Controls.Add(Me.TxtPorcentagemFaixa)
        Me.GroupBox2.Controls.Add(Me.TxtValorFaixa)
        Me.GroupBox2.Controls.Add(Me.BtnIncrementa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 233)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "E D I Ç Ã O"
        '
        'LblFaixa
        '
        Me.LblFaixa.AutoSize = True
        Me.LblFaixa.Location = New System.Drawing.Point(167, 42)
        Me.LblFaixa.Name = "LblFaixa"
        Me.LblFaixa.Size = New System.Drawing.Size(13, 13)
        Me.LblFaixa.TabIndex = 12
        Me.LblFaixa.Text = "1"
        '
        'TxtImpostoFaixaAcumulado
        '
        Me.TxtImpostoFaixaAcumulado.Location = New System.Drawing.Point(170, 148)
        Me.TxtImpostoFaixaAcumulado.Name = "TxtImpostoFaixaAcumulado"
        Me.TxtImpostoFaixaAcumulado.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpostoFaixaAcumulado.TabIndex = 11
        '
        'TxtImpostoFaixa
        '
        Me.TxtImpostoFaixa.Location = New System.Drawing.Point(170, 122)
        Me.TxtImpostoFaixa.Name = "TxtImpostoFaixa"
        Me.TxtImpostoFaixa.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpostoFaixa.TabIndex = 10
        '
        'TxtPorcentagemFaixa
        '
        Me.TxtPorcentagemFaixa.Location = New System.Drawing.Point(170, 91)
        Me.TxtPorcentagemFaixa.Name = "TxtPorcentagemFaixa"
        Me.TxtPorcentagemFaixa.Size = New System.Drawing.Size(100, 20)
        Me.TxtPorcentagemFaixa.TabIndex = 9
        '
        'TxtValorFaixa
        '
        Me.TxtValorFaixa.Location = New System.Drawing.Point(170, 65)
        Me.TxtValorFaixa.Name = "TxtValorFaixa"
        Me.TxtValorFaixa.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorFaixa.TabIndex = 8
        '
        'BtnIncrementa
        '
        Me.BtnIncrementa.Location = New System.Drawing.Point(21, 202)
        Me.BtnIncrementa.Name = "BtnIncrementa"
        Me.BtnIncrementa.Size = New System.Drawing.Size(104, 25)
        Me.BtnIncrementa.TabIndex = 7
        Me.BtnIncrementa.Text = "Incrementa"
        Me.BtnIncrementa.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Imposto Acumulado da Faixa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Imposto da Faixa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "% da Faixa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor daFaixa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Faixa"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(410, 90)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(540, 233)
        Me.ListView1.TabIndex = 0
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnLiberaEdicao)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Location = New System.Drawing.Point(63, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 45)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Inicio de Produção"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(271, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'BtnLiberaEdicao
        '
        Me.BtnLiberaEdicao.Location = New System.Drawing.Point(330, 16)
        Me.BtnLiberaEdicao.Name = "BtnLiberaEdicao"
        Me.BtnLiberaEdicao.Size = New System.Drawing.Size(163, 23)
        Me.BtnLiberaEdicao.TabIndex = 2
        Me.BtnLiberaEdicao.Text = "Libera Edição"
        Me.BtnLiberaEdicao.UseVisualStyleBackColor = True
        '
        'FrmFolhaINSS_TabelaCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 382)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaINSS_TabelaCadastro"
        Me.Text = "FOLHA - Tabela INSS Cadastramento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnIncrementa As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents LblFaixa As Label
    Friend WithEvents TxtImpostoFaixaAcumulado As TextBox
    Friend WithEvents TxtImpostoFaixa As TextBox
    Friend WithEvents TxtPorcentagemFaixa As TextBox
    Friend WithEvents TxtValorFaixa As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnLiberaEdicao As Button
End Class
