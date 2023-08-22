<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fColCadAutz
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.btnValida = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'mskCPF
        '
        Me.mskCPF.Location = New System.Drawing.Point(80, 34)
        Me.mskCPF.Mask = "000.000.000-00"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.Size = New System.Drawing.Size(98, 20)
        Me.mskCPF.TabIndex = 1
        '
        'btnValida
        '
        Me.btnValida.Location = New System.Drawing.Point(33, 68)
        Me.btnValida.Name = "btnValida"
        Me.btnValida.Size = New System.Drawing.Size(580, 27)
        Me.btnValida.TabIndex = 2
        Me.btnValida.Text = "V A L I D A R"
        Me.btnValida.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(77, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "O CPF será Validado e certifucado de que não está na Base de Dados"
        '
        'fColCadAutz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 110)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnValida)
        Me.Controls.Add(Me.mskCPF)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fColCadAutz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de CPF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mskCPF As MaskedTextBox
    Friend WithEvents btnValida As Button
    Friend WithEvents Label2 As Label
End Class
