<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCPLibera_lancamento
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
        Me.LabelTotalLiberado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelTotalLiberar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTotalLiberado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelTotalLiberar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 440)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "S E L E C I O N E   OS   L A N Ç A M E N T O S   A  S E R E M   L I B E R A D O S" &
    ""
        '
        'LabelTotalLiberado
        '
        Me.LabelTotalLiberado.AutoSize = True
        Me.LabelTotalLiberado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalLiberado.Location = New System.Drawing.Point(944, 397)
        Me.LabelTotalLiberado.Name = "LabelTotalLiberado"
        Me.LabelTotalLiberado.Size = New System.Drawing.Size(49, 24)
        Me.LabelTotalLiberado.TabIndex = 9
        Me.LabelTotalLiberado.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(761, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "T O T A L   L I B E R A D O ---------->"
        '
        'LabelTotalLiberar
        '
        Me.LabelTotalLiberar.AutoSize = True
        Me.LabelTotalLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalLiberar.Location = New System.Drawing.Point(944, 361)
        Me.LabelTotalLiberar.Name = "LabelTotalLiberar"
        Me.LabelTotalLiberar.Size = New System.Drawing.Size(49, 24)
        Me.LabelTotalLiberar.TabIndex = 7
        Me.LabelTotalLiberar.Text = "0,00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(759, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "T O T A L     A     L I B E R A R ----->"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Liberar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(14, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1086, 327)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DT FATO"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DT PAG."
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Prazo"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CNPJ/CPF"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NOME"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TEL"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TIPO COBRANÇA"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "N.DOC"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "VALOR"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Historico"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Cod CC"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CC"
        '
        'FrmCPLibera_lancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 540)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCPLibera_lancamento"
        Me.Text = "C O N T A S   A   P A G A R   -  Lançamento Liberação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelTotalLiberado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelTotalLiberar As Label
    Friend WithEvents Label1 As Label
End Class
