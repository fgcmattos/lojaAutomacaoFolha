<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaINSS_TabelaCadastroTeste
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblTotal_b5 = New System.Windows.Forms.Label()
        Me.LblTotal_b4 = New System.Windows.Forms.Label()
        Me.LblTotal_b3 = New System.Windows.Forms.Label()
        Me.LblTotal_b2 = New System.Windows.Forms.Label()
        Me.LblTotal_b1 = New System.Windows.Forms.Label()
        Me.LblFaixa4_b5 = New System.Windows.Forms.Label()
        Me.LblFaixa4_b4 = New System.Windows.Forms.Label()
        Me.LblFaixa4_b3 = New System.Windows.Forms.Label()
        Me.LblFaixa4_b2 = New System.Windows.Forms.Label()
        Me.LblFaixa4_b1 = New System.Windows.Forms.Label()
        Me.LblFaixa3_b5 = New System.Windows.Forms.Label()
        Me.LblFaixa3_b4 = New System.Windows.Forms.Label()
        Me.LblFaixa3_b3 = New System.Windows.Forms.Label()
        Me.LblFaixa3_b2 = New System.Windows.Forms.Label()
        Me.LblFaixa3_b1 = New System.Windows.Forms.Label()
        Me.LblFaixa2_b5 = New System.Windows.Forms.Label()
        Me.LblFaixa2_b4 = New System.Windows.Forms.Label()
        Me.LblFaixa2_b3 = New System.Windows.Forms.Label()
        Me.LblFaixa2_b2 = New System.Windows.Forms.Label()
        Me.LblFaixa2_b1 = New System.Windows.Forms.Label()
        Me.LblFaixa1_b5 = New System.Windows.Forms.Label()
        Me.LblFaixa1_b4 = New System.Windows.Forms.Label()
        Me.LblFaixa1_b3 = New System.Windows.Forms.Label()
        Me.LblFaixa1_b2 = New System.Windows.Forms.Label()
        Me.LblFaixa1_b1 = New System.Windows.Forms.Label()
        Me.CheckBoxOK5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOK4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOK3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOK2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOK1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblBase5 = New System.Windows.Forms.Label()
        Me.LblBase4 = New System.Windows.Forms.Label()
        Me.LblBase3 = New System.Windows.Forms.Label()
        Me.LblBase2 = New System.Windows.Forms.Label()
        Me.LblBase1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblDataCriacao = New System.Windows.Forms.Label()
        Me.LblCriadoPor = New System.Windows.Forms.Label()
        Me.LblReferencia = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(34, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(540, 233)
        Me.ListView1.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Referência AAAA/MM"
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(131, 19)
        Me.MskReferencia.Mask = "0000/00"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(87, 20)
        Me.MskReferencia.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblReferencia)
        Me.GroupBox1.Controls.Add(Me.LblCriadoPor)
        Me.GroupBox1.Controls.Add(Me.LblDataCriacao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 358)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "I N S S  - T A B E L A   E M  C O N F E R Ê N C I A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Criada em:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblTotal_b5)
        Me.GroupBox2.Controls.Add(Me.LblTotal_b4)
        Me.GroupBox2.Controls.Add(Me.LblTotal_b3)
        Me.GroupBox2.Controls.Add(Me.LblTotal_b2)
        Me.GroupBox2.Controls.Add(Me.LblTotal_b1)
        Me.GroupBox2.Controls.Add(Me.LblFaixa4_b5)
        Me.GroupBox2.Controls.Add(Me.LblFaixa4_b4)
        Me.GroupBox2.Controls.Add(Me.LblFaixa4_b3)
        Me.GroupBox2.Controls.Add(Me.LblFaixa4_b2)
        Me.GroupBox2.Controls.Add(Me.LblFaixa4_b1)
        Me.GroupBox2.Controls.Add(Me.LblFaixa3_b5)
        Me.GroupBox2.Controls.Add(Me.LblFaixa3_b4)
        Me.GroupBox2.Controls.Add(Me.LblFaixa3_b3)
        Me.GroupBox2.Controls.Add(Me.LblFaixa3_b2)
        Me.GroupBox2.Controls.Add(Me.LblFaixa3_b1)
        Me.GroupBox2.Controls.Add(Me.LblFaixa2_b5)
        Me.GroupBox2.Controls.Add(Me.LblFaixa2_b4)
        Me.GroupBox2.Controls.Add(Me.LblFaixa2_b3)
        Me.GroupBox2.Controls.Add(Me.LblFaixa2_b2)
        Me.GroupBox2.Controls.Add(Me.LblFaixa2_b1)
        Me.GroupBox2.Controls.Add(Me.LblFaixa1_b5)
        Me.GroupBox2.Controls.Add(Me.LblFaixa1_b4)
        Me.GroupBox2.Controls.Add(Me.LblFaixa1_b3)
        Me.GroupBox2.Controls.Add(Me.LblFaixa1_b2)
        Me.GroupBox2.Controls.Add(Me.LblFaixa1_b1)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOK5)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOK4)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOK3)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOK2)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOK1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblBase5)
        Me.GroupBox2.Controls.Add(Me.LblBase4)
        Me.GroupBox2.Controls.Add(Me.LblBase3)
        Me.GroupBox2.Controls.Add(Me.LblBase2)
        Me.GroupBox2.Controls.Add(Me.LblBase1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(603, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 267)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TESTES AUTOMATIZADOS"
        '
        'LblTotal_b5
        '
        Me.LblTotal_b5.AutoSize = True
        Me.LblTotal_b5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal_b5.ForeColor = System.Drawing.Color.Red
        Me.LblTotal_b5.Location = New System.Drawing.Point(355, 220)
        Me.LblTotal_b5.Name = "LblTotal_b5"
        Me.LblTotal_b5.Size = New System.Drawing.Size(57, 16)
        Me.LblTotal_b5.TabIndex = 44
        Me.LblTotal_b5.Text = "Faixa 1"
        '
        'LblTotal_b4
        '
        Me.LblTotal_b4.AutoSize = True
        Me.LblTotal_b4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal_b4.ForeColor = System.Drawing.Color.Red
        Me.LblTotal_b4.Location = New System.Drawing.Point(355, 176)
        Me.LblTotal_b4.Name = "LblTotal_b4"
        Me.LblTotal_b4.Size = New System.Drawing.Size(57, 16)
        Me.LblTotal_b4.TabIndex = 43
        Me.LblTotal_b4.Text = "Faixa 1"
        '
        'LblTotal_b3
        '
        Me.LblTotal_b3.AutoSize = True
        Me.LblTotal_b3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal_b3.ForeColor = System.Drawing.Color.Red
        Me.LblTotal_b3.Location = New System.Drawing.Point(355, 141)
        Me.LblTotal_b3.Name = "LblTotal_b3"
        Me.LblTotal_b3.Size = New System.Drawing.Size(57, 16)
        Me.LblTotal_b3.TabIndex = 42
        Me.LblTotal_b3.Text = "Faixa 1"
        '
        'LblTotal_b2
        '
        Me.LblTotal_b2.AutoSize = True
        Me.LblTotal_b2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal_b2.ForeColor = System.Drawing.Color.Red
        Me.LblTotal_b2.Location = New System.Drawing.Point(355, 102)
        Me.LblTotal_b2.Name = "LblTotal_b2"
        Me.LblTotal_b2.Size = New System.Drawing.Size(57, 16)
        Me.LblTotal_b2.TabIndex = 41
        Me.LblTotal_b2.Text = "Faixa 1"
        '
        'LblTotal_b1
        '
        Me.LblTotal_b1.AutoSize = True
        Me.LblTotal_b1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal_b1.ForeColor = System.Drawing.Color.Red
        Me.LblTotal_b1.Location = New System.Drawing.Point(355, 66)
        Me.LblTotal_b1.Name = "LblTotal_b1"
        Me.LblTotal_b1.Size = New System.Drawing.Size(57, 16)
        Me.LblTotal_b1.TabIndex = 40
        Me.LblTotal_b1.Text = "Faixa 1"
        '
        'LblFaixa4_b5
        '
        Me.LblFaixa4_b5.AutoSize = True
        Me.LblFaixa4_b5.Location = New System.Drawing.Point(283, 223)
        Me.LblFaixa4_b5.Name = "LblFaixa4_b5"
        Me.LblFaixa4_b5.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa4_b5.TabIndex = 39
        Me.LblFaixa4_b5.Text = "Faixa 1"
        '
        'LblFaixa4_b4
        '
        Me.LblFaixa4_b4.AutoSize = True
        Me.LblFaixa4_b4.Location = New System.Drawing.Point(283, 181)
        Me.LblFaixa4_b4.Name = "LblFaixa4_b4"
        Me.LblFaixa4_b4.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa4_b4.TabIndex = 38
        Me.LblFaixa4_b4.Text = "Faixa 1"
        '
        'LblFaixa4_b3
        '
        Me.LblFaixa4_b3.AutoSize = True
        Me.LblFaixa4_b3.Location = New System.Drawing.Point(283, 146)
        Me.LblFaixa4_b3.Name = "LblFaixa4_b3"
        Me.LblFaixa4_b3.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa4_b3.TabIndex = 37
        Me.LblFaixa4_b3.Text = "Faixa 1"
        '
        'LblFaixa4_b2
        '
        Me.LblFaixa4_b2.AutoSize = True
        Me.LblFaixa4_b2.Location = New System.Drawing.Point(283, 107)
        Me.LblFaixa4_b2.Name = "LblFaixa4_b2"
        Me.LblFaixa4_b2.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa4_b2.TabIndex = 36
        Me.LblFaixa4_b2.Text = "Faixa 1"
        '
        'LblFaixa4_b1
        '
        Me.LblFaixa4_b1.AutoSize = True
        Me.LblFaixa4_b1.Location = New System.Drawing.Point(283, 69)
        Me.LblFaixa4_b1.Name = "LblFaixa4_b1"
        Me.LblFaixa4_b1.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa4_b1.TabIndex = 35
        Me.LblFaixa4_b1.Text = "Faixa 1"
        '
        'LblFaixa3_b5
        '
        Me.LblFaixa3_b5.AutoSize = True
        Me.LblFaixa3_b5.Location = New System.Drawing.Point(214, 223)
        Me.LblFaixa3_b5.Name = "LblFaixa3_b5"
        Me.LblFaixa3_b5.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa3_b5.TabIndex = 34
        Me.LblFaixa3_b5.Text = "Faixa 1"
        '
        'LblFaixa3_b4
        '
        Me.LblFaixa3_b4.AutoSize = True
        Me.LblFaixa3_b4.Location = New System.Drawing.Point(214, 181)
        Me.LblFaixa3_b4.Name = "LblFaixa3_b4"
        Me.LblFaixa3_b4.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa3_b4.TabIndex = 33
        Me.LblFaixa3_b4.Text = "Faixa 1"
        '
        'LblFaixa3_b3
        '
        Me.LblFaixa3_b3.AutoSize = True
        Me.LblFaixa3_b3.Location = New System.Drawing.Point(214, 146)
        Me.LblFaixa3_b3.Name = "LblFaixa3_b3"
        Me.LblFaixa3_b3.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa3_b3.TabIndex = 32
        Me.LblFaixa3_b3.Text = "Faixa 1"
        '
        'LblFaixa3_b2
        '
        Me.LblFaixa3_b2.AutoSize = True
        Me.LblFaixa3_b2.Location = New System.Drawing.Point(214, 107)
        Me.LblFaixa3_b2.Name = "LblFaixa3_b2"
        Me.LblFaixa3_b2.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa3_b2.TabIndex = 31
        Me.LblFaixa3_b2.Text = "Faixa 1"
        '
        'LblFaixa3_b1
        '
        Me.LblFaixa3_b1.AutoSize = True
        Me.LblFaixa3_b1.Location = New System.Drawing.Point(214, 69)
        Me.LblFaixa3_b1.Name = "LblFaixa3_b1"
        Me.LblFaixa3_b1.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa3_b1.TabIndex = 30
        Me.LblFaixa3_b1.Text = "Faixa 1"
        '
        'LblFaixa2_b5
        '
        Me.LblFaixa2_b5.AutoSize = True
        Me.LblFaixa2_b5.Location = New System.Drawing.Point(152, 222)
        Me.LblFaixa2_b5.Name = "LblFaixa2_b5"
        Me.LblFaixa2_b5.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa2_b5.TabIndex = 29
        Me.LblFaixa2_b5.Text = "Faixa 1"
        '
        'LblFaixa2_b4
        '
        Me.LblFaixa2_b4.AutoSize = True
        Me.LblFaixa2_b4.Location = New System.Drawing.Point(152, 181)
        Me.LblFaixa2_b4.Name = "LblFaixa2_b4"
        Me.LblFaixa2_b4.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa2_b4.TabIndex = 28
        Me.LblFaixa2_b4.Text = "Faixa 1"
        '
        'LblFaixa2_b3
        '
        Me.LblFaixa2_b3.AutoSize = True
        Me.LblFaixa2_b3.Location = New System.Drawing.Point(152, 146)
        Me.LblFaixa2_b3.Name = "LblFaixa2_b3"
        Me.LblFaixa2_b3.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa2_b3.TabIndex = 27
        Me.LblFaixa2_b3.Text = "Faixa 1"
        '
        'LblFaixa2_b2
        '
        Me.LblFaixa2_b2.AutoSize = True
        Me.LblFaixa2_b2.Location = New System.Drawing.Point(152, 107)
        Me.LblFaixa2_b2.Name = "LblFaixa2_b2"
        Me.LblFaixa2_b2.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa2_b2.TabIndex = 26
        Me.LblFaixa2_b2.Text = "Faixa 1"
        '
        'LblFaixa2_b1
        '
        Me.LblFaixa2_b1.AutoSize = True
        Me.LblFaixa2_b1.Location = New System.Drawing.Point(152, 69)
        Me.LblFaixa2_b1.Name = "LblFaixa2_b1"
        Me.LblFaixa2_b1.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa2_b1.TabIndex = 25
        Me.LblFaixa2_b1.Text = "Faixa 1"
        '
        'LblFaixa1_b5
        '
        Me.LblFaixa1_b5.AutoSize = True
        Me.LblFaixa1_b5.Location = New System.Drawing.Point(91, 223)
        Me.LblFaixa1_b5.Name = "LblFaixa1_b5"
        Me.LblFaixa1_b5.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa1_b5.TabIndex = 24
        Me.LblFaixa1_b5.Text = "Faixa 1"
        '
        'LblFaixa1_b4
        '
        Me.LblFaixa1_b4.AutoSize = True
        Me.LblFaixa1_b4.Location = New System.Drawing.Point(91, 181)
        Me.LblFaixa1_b4.Name = "LblFaixa1_b4"
        Me.LblFaixa1_b4.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa1_b4.TabIndex = 23
        Me.LblFaixa1_b4.Text = "Faixa 1"
        '
        'LblFaixa1_b3
        '
        Me.LblFaixa1_b3.AutoSize = True
        Me.LblFaixa1_b3.Location = New System.Drawing.Point(91, 146)
        Me.LblFaixa1_b3.Name = "LblFaixa1_b3"
        Me.LblFaixa1_b3.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa1_b3.TabIndex = 22
        Me.LblFaixa1_b3.Text = "Faixa 1"
        '
        'LblFaixa1_b2
        '
        Me.LblFaixa1_b2.AutoSize = True
        Me.LblFaixa1_b2.Location = New System.Drawing.Point(91, 107)
        Me.LblFaixa1_b2.Name = "LblFaixa1_b2"
        Me.LblFaixa1_b2.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa1_b2.TabIndex = 21
        Me.LblFaixa1_b2.Text = "Faixa 1"
        '
        'LblFaixa1_b1
        '
        Me.LblFaixa1_b1.AutoSize = True
        Me.LblFaixa1_b1.Location = New System.Drawing.Point(91, 69)
        Me.LblFaixa1_b1.Name = "LblFaixa1_b1"
        Me.LblFaixa1_b1.Size = New System.Drawing.Size(48, 13)
        Me.LblFaixa1_b1.TabIndex = 20
        Me.LblFaixa1_b1.Text = "Faixa 1"
        '
        'CheckBoxOK5
        '
        Me.CheckBoxOK5.AutoSize = True
        Me.CheckBoxOK5.Location = New System.Drawing.Point(462, 221)
        Me.CheckBoxOK5.Name = "CheckBoxOK5"
        Me.CheckBoxOK5.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxOK5.TabIndex = 19
        Me.CheckBoxOK5.Text = "OK"
        Me.CheckBoxOK5.UseVisualStyleBackColor = True
        '
        'CheckBoxOK4
        '
        Me.CheckBoxOK4.AutoSize = True
        Me.CheckBoxOK4.Location = New System.Drawing.Point(462, 177)
        Me.CheckBoxOK4.Name = "CheckBoxOK4"
        Me.CheckBoxOK4.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxOK4.TabIndex = 18
        Me.CheckBoxOK4.Text = "OK"
        Me.CheckBoxOK4.UseVisualStyleBackColor = True
        '
        'CheckBoxOK3
        '
        Me.CheckBoxOK3.AutoSize = True
        Me.CheckBoxOK3.Location = New System.Drawing.Point(462, 142)
        Me.CheckBoxOK3.Name = "CheckBoxOK3"
        Me.CheckBoxOK3.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxOK3.TabIndex = 17
        Me.CheckBoxOK3.Text = "OK"
        Me.CheckBoxOK3.UseVisualStyleBackColor = True
        '
        'CheckBoxOK2
        '
        Me.CheckBoxOK2.AutoSize = True
        Me.CheckBoxOK2.Location = New System.Drawing.Point(462, 103)
        Me.CheckBoxOK2.Name = "CheckBoxOK2"
        Me.CheckBoxOK2.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxOK2.TabIndex = 16
        Me.CheckBoxOK2.Text = "OK"
        Me.CheckBoxOK2.UseVisualStyleBackColor = True
        '
        'CheckBoxOK1
        '
        Me.CheckBoxOK1.AutoSize = True
        Me.CheckBoxOK1.Location = New System.Drawing.Point(462, 65)
        Me.CheckBoxOK1.Name = "CheckBoxOK1"
        Me.CheckBoxOK1.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxOK1.TabIndex = 15
        Me.CheckBoxOK1.Text = "OK"
        Me.CheckBoxOK1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(355, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "T O T A L"
        '
        'LblBase5
        '
        Me.LblBase5.AutoSize = True
        Me.LblBase5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase5.ForeColor = System.Drawing.Color.Black
        Me.LblBase5.Location = New System.Drawing.Point(15, 223)
        Me.LblBase5.Name = "LblBase5"
        Me.LblBase5.Size = New System.Drawing.Size(51, 13)
        Me.LblBase5.TabIndex = 13
        Me.LblBase5.Text = "B A S E"
        '
        'LblBase4
        '
        Me.LblBase4.AutoSize = True
        Me.LblBase4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase4.ForeColor = System.Drawing.Color.Black
        Me.LblBase4.Location = New System.Drawing.Point(15, 181)
        Me.LblBase4.Name = "LblBase4"
        Me.LblBase4.Size = New System.Drawing.Size(51, 13)
        Me.LblBase4.TabIndex = 12
        Me.LblBase4.Text = "B A S E"
        '
        'LblBase3
        '
        Me.LblBase3.AutoSize = True
        Me.LblBase3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase3.ForeColor = System.Drawing.Color.Black
        Me.LblBase3.Location = New System.Drawing.Point(15, 143)
        Me.LblBase3.Name = "LblBase3"
        Me.LblBase3.Size = New System.Drawing.Size(51, 13)
        Me.LblBase3.TabIndex = 11
        Me.LblBase3.Text = "B A S E"
        '
        'LblBase2
        '
        Me.LblBase2.AutoSize = True
        Me.LblBase2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase2.ForeColor = System.Drawing.Color.Black
        Me.LblBase2.Location = New System.Drawing.Point(15, 107)
        Me.LblBase2.Name = "LblBase2"
        Me.LblBase2.Size = New System.Drawing.Size(51, 13)
        Me.LblBase2.TabIndex = 10
        Me.LblBase2.Text = "B A S E"
        '
        'LblBase1
        '
        Me.LblBase1.AutoSize = True
        Me.LblBase1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase1.ForeColor = System.Drawing.Color.Black
        Me.LblBase1.Location = New System.Drawing.Point(15, 69)
        Me.LblBase1.Name = "LblBase1"
        Me.LblBase1.Size = New System.Drawing.Size(51, 13)
        Me.LblBase1.TabIndex = 9
        Me.LblBase1.Text = "B A S E"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Faixa 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Faixa 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Faixa 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Faixa 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "B A S E"
        '
        'LblDataCriacao
        '
        Me.LblDataCriacao.AutoSize = True
        Me.LblDataCriacao.Location = New System.Drawing.Point(204, 285)
        Me.LblDataCriacao.Name = "LblDataCriacao"
        Me.LblDataCriacao.Size = New System.Drawing.Size(57, 13)
        Me.LblDataCriacao.TabIndex = 5
        Me.LblDataCriacao.Text = "Criada em:"
        '
        'LblCriadoPor
        '
        Me.LblCriadoPor.AutoSize = True
        Me.LblCriadoPor.Location = New System.Drawing.Point(204, 308)
        Me.LblCriadoPor.Name = "LblCriadoPor"
        Me.LblCriadoPor.Size = New System.Drawing.Size(57, 13)
        Me.LblCriadoPor.TabIndex = 6
        Me.LblCriadoPor.Text = "Criada em:"
        '
        'LblReferencia
        '
        Me.LblReferencia.AutoSize = True
        Me.LblReferencia.Location = New System.Drawing.Point(204, 330)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(57, 13)
        Me.LblReferencia.TabIndex = 7
        Me.LblReferencia.Text = "Criada em:"
        '
        'FrmFolhaINSS_TabelaCadastroTeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 565)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MskReferencia)
        Me.ForeColor = System.Drawing.Color.Red
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaINSS_TabelaCadastroTeste"
        Me.Text = "FOLHA - Tabela INSS   -  C O N F E R Ê N C I A"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblBase5 As Label
    Friend WithEvents LblBase4 As Label
    Friend WithEvents LblBase3 As Label
    Friend WithEvents LblBase2 As Label
    Friend WithEvents LblBase1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxOK1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBoxOK5 As CheckBox
    Friend WithEvents CheckBoxOK4 As CheckBox
    Friend WithEvents CheckBoxOK3 As CheckBox
    Friend WithEvents CheckBoxOK2 As CheckBox
    Friend WithEvents LblFaixa2_b5 As Label
    Friend WithEvents LblFaixa2_b4 As Label
    Friend WithEvents LblFaixa2_b3 As Label
    Friend WithEvents LblFaixa2_b2 As Label
    Friend WithEvents LblFaixa2_b1 As Label
    Friend WithEvents LblFaixa1_b5 As Label
    Friend WithEvents LblFaixa1_b4 As Label
    Friend WithEvents LblFaixa1_b3 As Label
    Friend WithEvents LblFaixa1_b2 As Label
    Friend WithEvents LblFaixa1_b1 As Label
    Friend WithEvents LblFaixa3_b5 As Label
    Friend WithEvents LblFaixa3_b4 As Label
    Friend WithEvents LblFaixa3_b3 As Label
    Friend WithEvents LblFaixa3_b2 As Label
    Friend WithEvents LblFaixa3_b1 As Label
    Friend WithEvents LblFaixa4_b5 As Label
    Friend WithEvents LblFaixa4_b4 As Label
    Friend WithEvents LblFaixa4_b3 As Label
    Friend WithEvents LblFaixa4_b2 As Label
    Friend WithEvents LblFaixa4_b1 As Label
    Friend WithEvents LblTotal_b5 As Label
    Friend WithEvents LblTotal_b4 As Label
    Friend WithEvents LblTotal_b3 As Label
    Friend WithEvents LblTotal_b2 As Label
    Friend WithEvents LblTotal_b1 As Label
    Friend WithEvents LblReferencia As Label
    Friend WithEvents LblCriadoPor As Label
    Friend WithEvents LblDataCriacao As Label
End Class
