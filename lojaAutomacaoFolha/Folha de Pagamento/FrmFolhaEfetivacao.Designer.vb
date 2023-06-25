<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaEfetivacao
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
        Me.CmbReferencia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtoCalcular = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextColaboradorKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnIprintHolerite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbReferencia
        '
        Me.CmbReferencia.FormattingEnabled = True
        Me.CmbReferencia.Items.AddRange(New Object() {"julho/2021", "agôsto/2021", "setembro/2021", "outubro/2021"})
        Me.CmbReferencia.Location = New System.Drawing.Point(108, 58)
        Me.CmbReferencia.Name = "CmbReferencia"
        Me.CmbReferencia.Size = New System.Drawing.Size(131, 21)
        Me.CmbReferencia.TabIndex = 8
        Me.CmbReferencia.Text = "julho/2021"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Referencia"
        '
        'BtoCalcular
        '
        Me.BtoCalcular.Location = New System.Drawing.Point(349, 45)
        Me.BtoCalcular.Name = "BtoCalcular"
        Me.BtoCalcular.Size = New System.Drawing.Size(93, 33)
        Me.BtoCalcular.TabIndex = 6
        Me.BtoCalcular.Text = "calcular"
        Me.BtoCalcular.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(30, 100)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(702, 410)
        Me.ListBox1.TabIndex = 9
        '
        'TextColaboradorKey
        '
        Me.TextColaboradorKey.Location = New System.Drawing.Point(108, 24)
        Me.TextColaboradorKey.Name = "TextColaboradorKey"
        Me.TextColaboradorKey.Size = New System.Drawing.Size(94, 20)
        Me.TextColaboradorKey.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Colaborador"
        '
        'BtnIprintHolerite
        '
        Me.BtnIprintHolerite.Location = New System.Drawing.Point(653, 65)
        Me.BtnIprintHolerite.Name = "BtnIprintHolerite"
        Me.BtnIprintHolerite.Size = New System.Drawing.Size(135, 33)
        Me.BtnIprintHolerite.TabIndex = 12
        Me.BtnIprintHolerite.Text = "Imprime Holerites"
        Me.BtnIprintHolerite.UseVisualStyleBackColor = True
        '
        'FrmFolhaEfetivacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.BtnIprintHolerite)
        Me.Controls.Add(Me.TextColaboradorKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CmbReferencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtoCalcular)
        Me.Name = "FrmFolhaEfetivacao"
        Me.Text = "Folha de Pagamento - Efetivação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbReferencia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtoCalcular As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextColaboradorKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnIprintHolerite As Button
End Class
