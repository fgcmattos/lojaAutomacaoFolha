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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.Cmbcredor = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbFerramenta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CmbFerramenta)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.Cmbcredor)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "L A N Ç A M E N T O"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(678, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Incrementa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Histórico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data Ocorrencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(753, 219)
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
        Me.BtnTermina.Location = New System.Drawing.Point(17, 492)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(150, 28)
        Me.BtnTermina.TabIndex = 3
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'Cmbcredor
        '
        Me.Cmbcredor.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.Cmbcredor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcredor.FormattingEnabled = True
        Me.Cmbcredor.Items.AddRange(New Object() {"Fornecedor", "Colaborador", "Pessoa Fisica"})
        Me.Cmbcredor.Location = New System.Drawing.Point(69, 29)
        Me.Cmbcredor.Name = "Cmbcredor"
        Me.Cmbcredor.Size = New System.Drawing.Size(137, 21)
        Me.Cmbcredor.TabIndex = 6
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(125, 63)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(81, 20)
        Me.MaskedTextBox2.TabIndex = 7
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(343, 66)
        Me.MaskedTextBox3.Mask = "00/00/0000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(81, 20)
        Me.MaskedTextBox3.TabIndex = 9
        Me.MaskedTextBox3.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data Vencimento"
        '
        'CmbFerramenta
        '
        Me.CmbFerramenta.AutoCompleteCustomSource.AddRange(New String() {"Forecedor", "Colaborador"})
        Me.CmbFerramenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFerramenta.FormattingEnabled = True
        Me.CmbFerramenta.Items.AddRange(New Object() {"Boleto", "Fatura", "Cartão de Crédito", "Nota Fiscal", "Recibo"})
        Me.CmbFerramenta.Location = New System.Drawing.Point(151, 103)
        Me.CmbFerramenta.Name = "CmbFerramenta"
        Me.CmbFerramenta.Size = New System.Drawing.Size(137, 21)
        Me.CmbFerramenta.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Ferramenta de Pagamento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(360, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 134)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(682, 20)
        Me.TextBox2.TabIndex = 13
        '
        'FmrCPlancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.BtnTermina)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FmrCPlancamento"
        Me.Text = "C O N T A S   A   P A G A R   -  Lançamento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnTermina As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CmbFerramenta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Cmbcredor As ComboBox
End Class
