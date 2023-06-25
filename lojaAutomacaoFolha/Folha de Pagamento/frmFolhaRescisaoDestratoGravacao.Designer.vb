<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFolhaRescisaoDestratoGravacao
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblSalarioAtual = New System.Windows.Forms.Label()
        Me.LblTempoEmpresa = New System.Windows.Forms.Label()
        Me.LblDataAdmissao = New System.Windows.Forms.Label()
        Me.LblCargoAtual = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblCNPJsindical = New System.Windows.Forms.Label()
        Me.LblCodigoSindical = New System.Windows.Forms.Label()
        Me.LblTipoDoContrato = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblColaborador = New System.Windows.Forms.Label()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskKeyCod = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MskDataFatalAcerto = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MskAfastamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbTipoDeAcordo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MskDataAviso = New System.Windows.Forms.MaskedTextBox()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LblColaborador)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MskKeyCod)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 307)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblSalarioAtual)
        Me.GroupBox3.Controls.Add(Me.LblTempoEmpresa)
        Me.GroupBox3.Controls.Add(Me.LblDataAdmissao)
        Me.GroupBox3.Controls.Add(Me.LblCargoAtual)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.LblCNPJsindical)
        Me.GroupBox3.Controls.Add(Me.LblCodigoSindical)
        Me.GroupBox3.Controls.Add(Me.LblTipoDoContrato)
        Me.GroupBox3.Controls.Add(Me.LblCategoria)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(596, 203)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Característica do Contrato"
        '
        'LblSalarioAtual
        '
        Me.LblSalarioAtual.AutoSize = True
        Me.LblSalarioAtual.Location = New System.Drawing.Point(471, 39)
        Me.LblSalarioAtual.Name = "LblSalarioAtual"
        Me.LblSalarioAtual.Size = New System.Drawing.Size(66, 13)
        Me.LblSalarioAtual.TabIndex = 17
        Me.LblSalarioAtual.Text = "Salário Atual"
        '
        'LblTempoEmpresa
        '
        Me.LblTempoEmpresa.AutoSize = True
        Me.LblTempoEmpresa.Location = New System.Drawing.Point(438, 16)
        Me.LblTempoEmpresa.Name = "LblTempoEmpresa"
        Me.LblTempoEmpresa.Size = New System.Drawing.Size(99, 13)
        Me.LblTempoEmpresa.TabIndex = 16
        Me.LblTempoEmpresa.Text = "Tempo de Empresa"
        '
        'LblDataAdmissao
        '
        Me.LblDataAdmissao.AutoSize = True
        Me.LblDataAdmissao.Location = New System.Drawing.Point(152, 39)
        Me.LblDataAdmissao.Name = "LblDataAdmissao"
        Me.LblDataAdmissao.Size = New System.Drawing.Size(93, 13)
        Me.LblDataAdmissao.TabIndex = 15
        Me.LblDataAdmissao.Text = "Data de Admissão"
        '
        'LblCargoAtual
        '
        Me.LblCargoAtual.AutoSize = True
        Me.LblCargoAtual.Location = New System.Drawing.Point(152, 16)
        Me.LblCargoAtual.Name = "LblCargoAtual"
        Me.LblCargoAtual.Size = New System.Drawing.Size(62, 13)
        Me.LblCargoAtual.TabIndex = 14
        Me.LblCargoAtual.Text = "Cargo Atual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(359, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Salário Atual"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(333, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tempo de Empresa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Data de Admissão"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cargo Atual"
        '
        'LblCNPJsindical
        '
        Me.LblCNPJsindical.AutoSize = True
        Me.LblCNPJsindical.Location = New System.Drawing.Point(37, 159)
        Me.LblCNPJsindical.Name = "LblCNPJsindical"
        Me.LblCNPJsindical.Size = New System.Drawing.Size(171, 13)
        Me.LblCNPJsindical.TabIndex = 9
        Me.LblCNPJsindical.Text = "CNPJ - Nome da Entidade Sindical"
        '
        'LblCodigoSindical
        '
        Me.LblCodigoSindical.AutoSize = True
        Me.LblCodigoSindical.Location = New System.Drawing.Point(152, 110)
        Me.LblCodigoSindical.Name = "LblCodigoSindical"
        Me.LblCodigoSindical.Size = New System.Drawing.Size(86, 13)
        Me.LblCodigoSindical.TabIndex = 8
        Me.LblCodigoSindical.Text = "Tipo de Contrato"
        '
        'LblTipoDoContrato
        '
        Me.LblTipoDoContrato.AutoSize = True
        Me.LblTipoDoContrato.Location = New System.Drawing.Point(152, 85)
        Me.LblTipoDoContrato.Name = "LblTipoDoContrato"
        Me.LblTipoDoContrato.Size = New System.Drawing.Size(86, 13)
        Me.LblTipoDoContrato.TabIndex = 7
        Me.LblTipoDoContrato.Text = "Tipo de Contrato"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(150, 61)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(127, 13)
        Me.LblCategoria.TabIndex = 6
        Me.LblCategoria.Text = "Categoria do Trabalhador"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "CNPJ - Nome da Entidade Sindical"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Código Sindical"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tipo de Contrato"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Categoria do Trabalhador"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(611, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 289)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'LblColaborador
        '
        Me.LblColaborador.AutoSize = True
        Me.LblColaborador.Location = New System.Drawing.Point(153, 36)
        Me.LblColaborador.Name = "LblColaborador"
        Me.LblColaborador.Size = New System.Drawing.Size(64, 13)
        Me.LblColaborador.TabIndex = 3
        Me.LblColaborador.Text = "Colaborador"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPesquisa.Location = New System.Drawing.Point(6, 273)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(83, 28)
        Me.BtnPesquisa.TabIndex = 2
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Colaborador"
        '
        'MskKeyCod
        '
        Me.MskKeyCod.Location = New System.Drawing.Point(74, 29)
        Me.MskKeyCod.Mask = "0000"
        Me.MskKeyCod.Name = "MskKeyCod"
        Me.MskKeyCod.Size = New System.Drawing.Size(73, 20)
        Me.MskKeyCod.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnGravar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.MskDataFatalAcerto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.MskAfastamento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CmbTipoDeAcordo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.MskDataAviso)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(761, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Data  F A T A L  para acerto"
        '
        'MskDataFatalAcerto
        '
        Me.MskDataFatalAcerto.Location = New System.Drawing.Point(164, 150)
        Me.MskDataFatalAcerto.Mask = "00/00/0000"
        Me.MskDataFatalAcerto.Name = "MskDataFatalAcerto"
        Me.MskDataFatalAcerto.Size = New System.Drawing.Size(73, 20)
        Me.MskDataFatalAcerto.TabIndex = 10
        Me.MskDataFatalAcerto.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prazo de Análise - 2 Dias"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(55, 66)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Cumpre Aviso Prévio"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Data do Afastamento"
        '
        'MskAfastamento
        '
        Me.MskAfastamento.Location = New System.Drawing.Point(164, 119)
        Me.MskAfastamento.Mask = "00/00/0000"
        Me.MskAfastamento.Name = "MskAfastamento"
        Me.MskAfastamento.Size = New System.Drawing.Size(73, 20)
        Me.MskAfastamento.TabIndex = 4
        Me.MskAfastamento.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo de Acordo"
        '
        'CmbTipoDeAcordo
        '
        Me.CmbTipoDeAcordo.FormattingEnabled = True
        Me.CmbTipoDeAcordo.Location = New System.Drawing.Point(164, 29)
        Me.CmbTipoDeAcordo.Name = "CmbTipoDeAcordo"
        Me.CmbTipoDeAcordo.Size = New System.Drawing.Size(591, 21)
        Me.CmbTipoDeAcordo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data do Aviso"
        '
        'MskDataAviso
        '
        Me.MskDataAviso.Location = New System.Drawing.Point(164, 89)
        Me.MskDataAviso.Mask = "00/00/0000"
        Me.MskDataAviso.Name = "MskDataAviso"
        Me.MskDataAviso.Size = New System.Drawing.Size(73, 20)
        Me.MskDataAviso.TabIndex = 0
        Me.MskDataAviso.ValidatingType = GetType(Date)
        '
        'BtnGravar
        '
        Me.BtnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGravar.Location = New System.Drawing.Point(335, 142)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(83, 28)
        Me.BtnGravar.TabIndex = 12
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'frmFolhaRescisaoDestratoGravacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFolhaRescisaoDestratoGravacao"
        Me.Text = "R E S C I S Ã O - Destrato Gravação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MskKeyCod As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MskAfastamento As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbTipoDeAcordo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MskDataAviso As MaskedTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MskDataFatalAcerto As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents LblColaborador As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblCNPJsindical As Label
    Friend WithEvents LblCodigoSindical As Label
    Friend WithEvents LblTipoDoContrato As Label
    Friend WithEvents LblCategoria As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblSalarioAtual As Label
    Friend WithEvents LblTempoEmpresa As Label
    Friend WithEvents LblDataAdmissao As Label
    Friend WithEvents LblCargoAtual As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnGravar As Button
End Class
