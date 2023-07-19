<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaINSS_TabelaPesquisa
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
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.MskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LblDataAtivacao = New System.Windows.Forms.Label()
        Me.LblDataDesativacao = New System.Windows.Forms.Label()
        Me.LblTabelaAnterior = New System.Windows.Forms.Label()
        Me.LblTabelaPosterior = New System.Windows.Forms.Label()
        Me.LblDigitacaoData = New System.Windows.Forms.Label()
        Me.LblDigitacaoOperadorChave = New System.Windows.Forms.Label()
        Me.LblDigitacaoOperadorTipo = New System.Windows.Forms.Label()
        Me.LblConferenciaAnalistaTipo = New System.Windows.Forms.Label()
        Me.LblConferenciaAnalistaChave = New System.Windows.Forms.Label()
        Me.LblConferenciaData = New System.Windows.Forms.Label()
        Me.LblLiberacaoResponsavelTipo = New System.Windows.Forms.Label()
        Me.LblLiberacaoResponsavelChave = New System.Windows.Forms.Label()
        Me.LblLiberacaoData = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MskNumero)
        Me.GroupBox1.Controls.Add(Me.MskReferencia)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Painel de Pesquisa"
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(83, 32)
        Me.MskReferencia.Mask = "####/##"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(98, 20)
        Me.MskReferencia.TabIndex = 0
        '
        'MskNumero
        '
        Me.MskNumero.Location = New System.Drawing.Point(83, 79)
        Me.MskNumero.Mask = "####.##"
        Me.MskNumero.Name = "MskNumero"
        Me.MskNumero.Size = New System.Drawing.Size(98, 20)
        Me.MskNumero.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Referência"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(852, 233)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificação da Tabela"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Location = New System.Drawing.Point(9, 114)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(172, 19)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoOperadorTipo)
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoOperadorChave)
        Me.GroupBox3.Controls.Add(Me.LblDigitacaoData)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Digitação"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Operador Chave :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Operador Tipo :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblConferenciaAnalistaTipo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LblConferenciaAnalistaChave)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.LblConferenciaData)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(317, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Conferência"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Analista Tipo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Analista Chave :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Data :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoResponsavelTipo)
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoResponsavelChave)
        Me.GroupBox5.Controls.Add(Me.LblLiberacaoData)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(580, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 106)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Liberação"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Responsável Tipo :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Responsável Chave :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Data :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Tabela Número:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(213, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 25)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "2023.02"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblTabelaPosterior)
        Me.GroupBox6.Controls.Add(Me.LblTabelaAnterior)
        Me.GroupBox6.Controls.Add(Me.LblDataDesativacao)
        Me.GroupBox6.Controls.Add(Me.LblDataAtivacao)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(316, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(530, 63)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OPERAÇÃO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Data da Ativação:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Data da Desativação:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(351, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Tabela Anterior:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(351, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Tabela Posterior:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(12, 432)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(852, 130)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tabela"
        '
        'LblDataAtivacao
        '
        Me.LblDataAtivacao.AutoSize = True
        Me.LblDataAtivacao.Location = New System.Drawing.Point(147, 16)
        Me.LblDataAtivacao.Name = "LblDataAtivacao"
        Me.LblDataAtivacao.Size = New System.Drawing.Size(44, 13)
        Me.LblDataAtivacao.TabIndex = 8
        Me.LblDataAtivacao.Text = "Número"
        '
        'LblDataDesativacao
        '
        Me.LblDataDesativacao.AutoSize = True
        Me.LblDataDesativacao.Location = New System.Drawing.Point(147, 37)
        Me.LblDataDesativacao.Name = "LblDataDesativacao"
        Me.LblDataDesativacao.Size = New System.Drawing.Size(44, 13)
        Me.LblDataDesativacao.TabIndex = 9
        Me.LblDataDesativacao.Text = "Número"
        '
        'LblTabelaAnterior
        '
        Me.LblTabelaAnterior.AutoSize = True
        Me.LblTabelaAnterior.Location = New System.Drawing.Point(454, 20)
        Me.LblTabelaAnterior.Name = "LblTabelaAnterior"
        Me.LblTabelaAnterior.Size = New System.Drawing.Size(44, 13)
        Me.LblTabelaAnterior.TabIndex = 10
        Me.LblTabelaAnterior.Text = "Número"
        '
        'LblTabelaPosterior
        '
        Me.LblTabelaPosterior.AutoSize = True
        Me.LblTabelaPosterior.Location = New System.Drawing.Point(454, 41)
        Me.LblTabelaPosterior.Name = "LblTabelaPosterior"
        Me.LblTabelaPosterior.Size = New System.Drawing.Size(44, 13)
        Me.LblTabelaPosterior.TabIndex = 11
        Me.LblTabelaPosterior.Text = "Número"
        '
        'LblDigitacaoData
        '
        Me.LblDigitacaoData.AutoSize = True
        Me.LblDigitacaoData.Location = New System.Drawing.Point(104, 26)
        Me.LblDigitacaoData.Name = "LblDigitacaoData"
        Me.LblDigitacaoData.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoData.TabIndex = 6
        Me.LblDigitacaoData.Text = "Número"
        '
        'LblDigitacaoOperadorChave
        '
        Me.LblDigitacaoOperadorChave.AutoSize = True
        Me.LblDigitacaoOperadorChave.Location = New System.Drawing.Point(104, 51)
        Me.LblDigitacaoOperadorChave.Name = "LblDigitacaoOperadorChave"
        Me.LblDigitacaoOperadorChave.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoOperadorChave.TabIndex = 7
        Me.LblDigitacaoOperadorChave.Text = "Número"
        '
        'LblDigitacaoOperadorTipo
        '
        Me.LblDigitacaoOperadorTipo.AutoSize = True
        Me.LblDigitacaoOperadorTipo.Location = New System.Drawing.Point(104, 79)
        Me.LblDigitacaoOperadorTipo.Name = "LblDigitacaoOperadorTipo"
        Me.LblDigitacaoOperadorTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblDigitacaoOperadorTipo.TabIndex = 8
        Me.LblDigitacaoOperadorTipo.Text = "Número"
        '
        'LblConferenciaAnalistaTipo
        '
        Me.LblConferenciaAnalistaTipo.AutoSize = True
        Me.LblConferenciaAnalistaTipo.Location = New System.Drawing.Point(96, 83)
        Me.LblConferenciaAnalistaTipo.Name = "LblConferenciaAnalistaTipo"
        Me.LblConferenciaAnalistaTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaAnalistaTipo.TabIndex = 11
        Me.LblConferenciaAnalistaTipo.Text = "Número"
        '
        'LblConferenciaAnalistaChave
        '
        Me.LblConferenciaAnalistaChave.AutoSize = True
        Me.LblConferenciaAnalistaChave.Location = New System.Drawing.Point(96, 55)
        Me.LblConferenciaAnalistaChave.Name = "LblConferenciaAnalistaChave"
        Me.LblConferenciaAnalistaChave.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaAnalistaChave.TabIndex = 10
        Me.LblConferenciaAnalistaChave.Text = "Número"
        '
        'LblConferenciaData
        '
        Me.LblConferenciaData.AutoSize = True
        Me.LblConferenciaData.Location = New System.Drawing.Point(96, 26)
        Me.LblConferenciaData.Name = "LblConferenciaData"
        Me.LblConferenciaData.Size = New System.Drawing.Size(44, 13)
        Me.LblConferenciaData.TabIndex = 9
        Me.LblConferenciaData.Text = "Número"
        '
        'LblLiberacaoResponsavelTipo
        '
        Me.LblLiberacaoResponsavelTipo.AutoSize = True
        Me.LblLiberacaoResponsavelTipo.Location = New System.Drawing.Point(130, 83)
        Me.LblLiberacaoResponsavelTipo.Name = "LblLiberacaoResponsavelTipo"
        Me.LblLiberacaoResponsavelTipo.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoResponsavelTipo.TabIndex = 11
        Me.LblLiberacaoResponsavelTipo.Text = "Número"
        '
        'LblLiberacaoResponsavelChave
        '
        Me.LblLiberacaoResponsavelChave.AutoSize = True
        Me.LblLiberacaoResponsavelChave.Location = New System.Drawing.Point(130, 55)
        Me.LblLiberacaoResponsavelChave.Name = "LblLiberacaoResponsavelChave"
        Me.LblLiberacaoResponsavelChave.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoResponsavelChave.TabIndex = 10
        Me.LblLiberacaoResponsavelChave.Text = "Número"
        '
        'LblLiberacaoData
        '
        Me.LblLiberacaoData.AutoSize = True
        Me.LblLiberacaoData.Location = New System.Drawing.Point(130, 26)
        Me.LblLiberacaoData.Name = "LblLiberacaoData"
        Me.LblLiberacaoData.Size = New System.Drawing.Size(44, 13)
        Me.LblLiberacaoData.TabIndex = 9
        Me.LblLiberacaoData.Text = "Número"
        '
        'FrmFolhaINSS_TabelaPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 626)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFolhaINSS_TabelaPesquisa"
        Me.Text = "FOLHA - Tabela INSS   -  P E S Q U I S A"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MskNumero As MaskedTextBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LblTabelaPosterior As Label
    Friend WithEvents LblTabelaAnterior As Label
    Friend WithEvents LblDataDesativacao As Label
    Friend WithEvents LblDataAtivacao As Label
    Friend WithEvents LblLiberacaoResponsavelTipo As Label
    Friend WithEvents LblLiberacaoResponsavelChave As Label
    Friend WithEvents LblLiberacaoData As Label
    Friend WithEvents LblConferenciaAnalistaTipo As Label
    Friend WithEvents LblConferenciaAnalistaChave As Label
    Friend WithEvents LblConferenciaData As Label
    Friend WithEvents LblDigitacaoOperadorTipo As Label
    Friend WithEvents LblDigitacaoOperadorChave As Label
    Friend WithEvents LblDigitacaoData As Label
End Class
