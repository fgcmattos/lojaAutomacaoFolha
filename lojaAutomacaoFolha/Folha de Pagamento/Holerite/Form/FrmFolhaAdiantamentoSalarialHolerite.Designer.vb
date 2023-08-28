<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaAdiantamentoSalarialHolerite
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
        Me.GruReferencia = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtMens3 = New System.Windows.Forms.TextBox()
        Me.TxtMens2 = New System.Windows.Forms.TextBox()
        Me.TxtMens1 = New System.Windows.Forms.TextBox()
        Me.BtnImprime = New System.Windows.Forms.Button()
        Me.GruReferencia.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruReferencia
        '
        Me.GruReferencia.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruReferencia.Controls.Add(Me.BtnPesquisa)
        Me.GruReferencia.Controls.Add(Me.MskReferencia)
        Me.GruReferencia.Controls.Add(Me.Label1)
        Me.GruReferencia.Location = New System.Drawing.Point(1, 3)
        Me.GruReferencia.Name = "GruReferencia"
        Me.GruReferencia.Size = New System.Drawing.Size(305, 131)
        Me.GruReferencia.TabIndex = 0
        Me.GruReferencia.TabStop = False
        Me.GruReferencia.Text = "GroupBox1"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(211, 31)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(75, 23)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(93, 32)
        Me.MskReferencia.Mask = "00/0000"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(100, 20)
        Me.MskReferencia.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Referência"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.TxtMens3)
        Me.GroupBox1.Controls.Add(Me.TxtMens2)
        Me.GroupBox1.Controls.Add(Me.TxtMens1)
        Me.GroupBox1.Location = New System.Drawing.Point(338, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Texto Para Holerite"
        '
        'TxtMens3
        '
        Me.TxtMens3.Location = New System.Drawing.Point(6, 81)
        Me.TxtMens3.MaxLength = 60
        Me.TxtMens3.Name = "TxtMens3"
        Me.TxtMens3.Size = New System.Drawing.Size(438, 20)
        Me.TxtMens3.TabIndex = 5
        '
        'TxtMens2
        '
        Me.TxtMens2.Location = New System.Drawing.Point(6, 55)
        Me.TxtMens2.MaxLength = 60
        Me.TxtMens2.Name = "TxtMens2"
        Me.TxtMens2.Size = New System.Drawing.Size(438, 20)
        Me.TxtMens2.TabIndex = 4
        '
        'TxtMens1
        '
        Me.TxtMens1.Location = New System.Drawing.Point(6, 31)
        Me.TxtMens1.MaxLength = 60
        Me.TxtMens1.Name = "TxtMens1"
        Me.TxtMens1.Size = New System.Drawing.Size(438, 20)
        Me.TxtMens1.TabIndex = 3
        '
        'BtnImprime
        '
        Me.BtnImprime.Location = New System.Drawing.Point(32, 152)
        Me.BtnImprime.Name = "BtnImprime"
        Me.BtnImprime.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprime.TabIndex = 4
        Me.BtnImprime.Text = "Imprime"
        Me.BtnImprime.UseVisualStyleBackColor = True
        Me.BtnImprime.Visible = False
        '
        'FrmFolhaAdiantamentoSalarialHolerite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnImprime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GruReferencia)
        Me.Name = "FrmFolhaAdiantamentoSalarialHolerite"
        Me.Text = "FOLHA - Adiantamento Salarial Holerite"
        Me.GruReferencia.ResumeLayout(False)
        Me.GruReferencia.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruReferencia As GroupBox
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnImprime As Button
    Friend WithEvents TxtMens1 As TextBox
    Friend WithEvents TxtMens3 As TextBox
    Friend WithEvents TxtMens2 As TextBox
End Class
