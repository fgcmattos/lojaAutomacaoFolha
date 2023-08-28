<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolhaAdiantamentoSalarialPreliminarTodos
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
        Me.GruReferenciaPesquisa = New System.Windows.Forms.GroupBox()
        Me.MskDataPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GruvVariavelPagamento = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MskUnidadeHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.MskTipoHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.MskIRHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.MskFGTSHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.MskINSSHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.MskVariavelHolerite = New System.Windows.Forms.MaskedTextBox()
        Me.LblVariavelDescricaoHolerite = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MskUnidadePagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MskTipoPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MskIRpagamento = New System.Windows.Forms.MaskedTextBox()
        Me.MskFGTSpagamento = New System.Windows.Forms.MaskedTextBox()
        Me.MskINSSpagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MskVariavelPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.LblVariavelDescricaoPagamento = New System.Windows.Forms.Label()
        Me.lblSomaBoleean = New System.Windows.Forms.Label()
        Me.MskPorcentagemDoSalario = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.MskReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GruAdiantamentoShow = New System.Windows.Forms.GroupBox()
        Me.BtnVoltaPesquisa = New System.Windows.Forms.Button()
        Me.BtnGerarArquivo = New System.Windows.Forms.Button()
        Me.LblSomaSalario = New System.Windows.Forms.Label()
        Me.LblSomaAdiantamento = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnDesfazer = New System.Windows.Forms.Button()
        Me.BtnNovaReferencia = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GruReferenciaPesquisa.SuspendLayout()
        Me.GruvVariavelPagamento.SuspendLayout()
        Me.GruAdiantamentoShow.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruReferenciaPesquisa
        '
        Me.GruReferenciaPesquisa.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskDataPagamento)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label3)
        Me.GruReferenciaPesquisa.Controls.Add(Me.GruvVariavelPagamento)
        Me.GruReferenciaPesquisa.Controls.Add(Me.lblSomaBoleean)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskPorcentagemDoSalario)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label2)
        Me.GruReferenciaPesquisa.Controls.Add(Me.BtnPesquisa)
        Me.GruReferenciaPesquisa.Controls.Add(Me.MskReferencia)
        Me.GruReferenciaPesquisa.Controls.Add(Me.Label1)
        Me.GruReferenciaPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruReferenciaPesquisa.Location = New System.Drawing.Point(46, 12)
        Me.GruReferenciaPesquisa.Name = "GruReferenciaPesquisa"
        Me.GruReferenciaPesquisa.Size = New System.Drawing.Size(922, 147)
        Me.GruReferenciaPesquisa.TabIndex = 0
        Me.GruReferenciaPesquisa.TabStop = False
        Me.GruReferenciaPesquisa.Text = "Pesquisa de Referência - MM/AAAA"
        '
        'MskDataPagamento
        '
        Me.MskDataPagamento.Location = New System.Drawing.Point(184, 53)
        Me.MskDataPagamento.Mask = "00/00/0000"
        Me.MskDataPagamento.Name = "MskDataPagamento"
        Me.MskDataPagamento.Size = New System.Drawing.Size(100, 20)
        Me.MskDataPagamento.TabIndex = 10
        Me.MskDataPagamento.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data do Pagamento"
        '
        'GruvVariavelPagamento
        '
        Me.GruvVariavelPagamento.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruvVariavelPagamento.Controls.Add(Me.Label10)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskUnidadeHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskTipoHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskIRHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskFGTSHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskINSSHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskVariavelHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.LblVariavelDescricaoHolerite)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label9)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskUnidadePagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label8)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskTipoPagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label7)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskIRpagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskFGTSpagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskINSSpagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label6)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label5)
        Me.GruvVariavelPagamento.Controls.Add(Me.Label4)
        Me.GruvVariavelPagamento.Controls.Add(Me.MskVariavelPagamento)
        Me.GruvVariavelPagamento.Controls.Add(Me.LblVariavelDescricaoPagamento)
        Me.GruvVariavelPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GruvVariavelPagamento.Location = New System.Drawing.Point(331, 13)
        Me.GruvVariavelPagamento.Name = "GruvVariavelPagamento"
        Me.GruvVariavelPagamento.Size = New System.Drawing.Size(585, 100)
        Me.GruvVariavelPagamento.TabIndex = 8
        Me.GruvVariavelPagamento.TabStop = False
        Me.GruvVariavelPagamento.Text = "Variável de Lançamento no P A G A M E N T O"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Holerite --------->"
        '
        'MskUnidadeHolerite
        '
        Me.MskUnidadeHolerite.Location = New System.Drawing.Point(516, 62)
        Me.MskUnidadeHolerite.Name = "MskUnidadeHolerite"
        Me.MskUnidadeHolerite.Size = New System.Drawing.Size(19, 20)
        Me.MskUnidadeHolerite.TabIndex = 24
        '
        'MskTipoHolerite
        '
        Me.MskTipoHolerite.Location = New System.Drawing.Point(560, 62)
        Me.MskTipoHolerite.Mask = "A"
        Me.MskTipoHolerite.Name = "MskTipoHolerite"
        Me.MskTipoHolerite.Size = New System.Drawing.Size(19, 20)
        Me.MskTipoHolerite.TabIndex = 23
        '
        'MskIRHolerite
        '
        Me.MskIRHolerite.Location = New System.Drawing.Point(471, 62)
        Me.MskIRHolerite.Mask = "A"
        Me.MskIRHolerite.Name = "MskIRHolerite"
        Me.MskIRHolerite.Size = New System.Drawing.Size(19, 20)
        Me.MskIRHolerite.TabIndex = 21
        '
        'MskFGTSHolerite
        '
        Me.MskFGTSHolerite.Location = New System.Drawing.Point(431, 62)
        Me.MskFGTSHolerite.Mask = "A"
        Me.MskFGTSHolerite.Name = "MskFGTSHolerite"
        Me.MskFGTSHolerite.Size = New System.Drawing.Size(19, 20)
        Me.MskFGTSHolerite.TabIndex = 22
        Me.MskFGTSHolerite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MskINSSHolerite
        '
        Me.MskINSSHolerite.Location = New System.Drawing.Point(386, 62)
        Me.MskINSSHolerite.Mask = "A"
        Me.MskINSSHolerite.Name = "MskINSSHolerite"
        Me.MskINSSHolerite.Size = New System.Drawing.Size(19, 20)
        Me.MskINSSHolerite.TabIndex = 20
        Me.MskINSSHolerite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MskVariavelHolerite
        '
        Me.MskVariavelHolerite.Location = New System.Drawing.Point(100, 63)
        Me.MskVariavelHolerite.Mask = "0000"
        Me.MskVariavelHolerite.Name = "MskVariavelHolerite"
        Me.MskVariavelHolerite.Size = New System.Drawing.Size(32, 20)
        Me.MskVariavelHolerite.TabIndex = 18
        '
        'LblVariavelDescricaoHolerite
        '
        Me.LblVariavelDescricaoHolerite.AutoSize = True
        Me.LblVariavelDescricaoHolerite.Location = New System.Drawing.Point(138, 70)
        Me.LblVariavelDescricaoHolerite.Name = "LblVariavelDescricaoHolerite"
        Me.LblVariavelDescricaoHolerite.Size = New System.Drawing.Size(39, 13)
        Me.LblVariavelDescricaoHolerite.TabIndex = 19
        Me.LblVariavelDescricaoHolerite.Text = "Label4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pagamento --->"
        '
        'MskUnidadePagamento
        '
        Me.MskUnidadePagamento.Location = New System.Drawing.Point(516, 32)
        Me.MskUnidadePagamento.Name = "MskUnidadePagamento"
        Me.MskUnidadePagamento.Size = New System.Drawing.Size(19, 20)
        Me.MskUnidadePagamento.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UNID"
        '
        'MskTipoPagamento
        '
        Me.MskTipoPagamento.Location = New System.Drawing.Point(560, 32)
        Me.MskTipoPagamento.Mask = "A"
        Me.MskTipoPagamento.Name = "MskTipoPagamento"
        Me.MskTipoPagamento.Size = New System.Drawing.Size(19, 20)
        Me.MskTipoPagamento.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(547, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TIPO"
        '
        'MskIRpagamento
        '
        Me.MskIRpagamento.Location = New System.Drawing.Point(471, 32)
        Me.MskIRpagamento.Mask = "A"
        Me.MskIRpagamento.Name = "MskIRpagamento"
        Me.MskIRpagamento.Size = New System.Drawing.Size(19, 20)
        Me.MskIRpagamento.TabIndex = 12
        '
        'MskFGTSpagamento
        '
        Me.MskFGTSpagamento.Location = New System.Drawing.Point(431, 32)
        Me.MskFGTSpagamento.Mask = "A"
        Me.MskFGTSpagamento.Name = "MskFGTSpagamento"
        Me.MskFGTSpagamento.Size = New System.Drawing.Size(19, 20)
        Me.MskFGTSpagamento.TabIndex = 12
        Me.MskFGTSpagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MskINSSpagamento
        '
        Me.MskINSSpagamento.Location = New System.Drawing.Point(386, 32)
        Me.MskINSSpagamento.Mask = "A"
        Me.MskINSSpagamento.Name = "MskINSSpagamento"
        Me.MskINSSpagamento.Size = New System.Drawing.Size(19, 20)
        Me.MskINSSpagamento.TabIndex = 11
        Me.MskINSSpagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(468, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "IR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FGTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "INSS"
        '
        'MskVariavelPagamento
        '
        Me.MskVariavelPagamento.Location = New System.Drawing.Point(100, 33)
        Me.MskVariavelPagamento.Mask = "0000"
        Me.MskVariavelPagamento.Name = "MskVariavelPagamento"
        Me.MskVariavelPagamento.Size = New System.Drawing.Size(32, 20)
        Me.MskVariavelPagamento.TabIndex = 6
        '
        'LblVariavelDescricaoPagamento
        '
        Me.LblVariavelDescricaoPagamento.AutoSize = True
        Me.LblVariavelDescricaoPagamento.Location = New System.Drawing.Point(138, 40)
        Me.LblVariavelDescricaoPagamento.Name = "LblVariavelDescricaoPagamento"
        Me.LblVariavelDescricaoPagamento.Size = New System.Drawing.Size(39, 13)
        Me.LblVariavelDescricaoPagamento.TabIndex = 7
        Me.LblVariavelDescricaoPagamento.Text = "Label4"
        '
        'lblSomaBoleean
        '
        Me.lblSomaBoleean.AutoSize = True
        Me.lblSomaBoleean.Location = New System.Drawing.Point(587, -3)
        Me.lblSomaBoleean.Name = "lblSomaBoleean"
        Me.lblSomaBoleean.Size = New System.Drawing.Size(39, 13)
        Me.lblSomaBoleean.TabIndex = 2
        Me.lblSomaBoleean.Text = "Label3"
        '
        'MskPorcentagemDoSalario
        '
        Me.MskPorcentagemDoSalario.Location = New System.Drawing.Point(184, 80)
        Me.MskPorcentagemDoSalario.Mask = "00"
        Me.MskPorcentagemDoSalario.Name = "MskPorcentagemDoSalario"
        Me.MskPorcentagemDoSalario.Size = New System.Drawing.Size(100, 20)
        Me.MskPorcentagemDoSalario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porcentagem do Salário (%)"
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPesquisa.Location = New System.Drawing.Point(11, 118)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(273, 23)
        Me.BtnPesquisa.TabIndex = 2
        Me.BtnPesquisa.Text = "Pesquisa"
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'MskReferencia
        '
        Me.MskReferencia.Location = New System.Drawing.Point(184, 24)
        Me.MskReferencia.Mask = "00/0000"
        Me.MskReferencia.Name = "MskReferencia"
        Me.MskReferencia.Size = New System.Drawing.Size(100, 20)
        Me.MskReferencia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referência"
        '
        'GruAdiantamentoShow
        '
        Me.GruAdiantamentoShow.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GruAdiantamentoShow.Controls.Add(Me.BtnVoltaPesquisa)
        Me.GruAdiantamentoShow.Controls.Add(Me.BtnGerarArquivo)
        Me.GruAdiantamentoShow.Controls.Add(Me.LblSomaSalario)
        Me.GruAdiantamentoShow.Controls.Add(Me.LblSomaAdiantamento)
        Me.GruAdiantamentoShow.Controls.Add(Me.ListView1)
        Me.GruAdiantamentoShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GruAdiantamentoShow.Location = New System.Drawing.Point(46, 165)
        Me.GruAdiantamentoShow.Name = "GruAdiantamentoShow"
        Me.GruAdiantamentoShow.Size = New System.Drawing.Size(916, 273)
        Me.GruAdiantamentoShow.TabIndex = 1
        Me.GruAdiantamentoShow.TabStop = False
        Me.GruAdiantamentoShow.Text = "Pesquisa de Referência - MM/AAAA"
        '
        'BtnVoltaPesquisa
        '
        Me.BtnVoltaPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnVoltaPesquisa.Location = New System.Drawing.Point(290, 233)
        Me.BtnVoltaPesquisa.Name = "BtnVoltaPesquisa"
        Me.BtnVoltaPesquisa.Size = New System.Drawing.Size(273, 23)
        Me.BtnVoltaPesquisa.TabIndex = 4
        Me.BtnVoltaPesquisa.Text = "Volta para Pesquisa"
        Me.BtnVoltaPesquisa.UseVisualStyleBackColor = True
        '
        'BtnGerarArquivo
        '
        Me.BtnGerarArquivo.Enabled = False
        Me.BtnGerarArquivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGerarArquivo.Location = New System.Drawing.Point(11, 233)
        Me.BtnGerarArquivo.Name = "BtnGerarArquivo"
        Me.BtnGerarArquivo.Size = New System.Drawing.Size(273, 23)
        Me.BtnGerarArquivo.TabIndex = 3
        Me.BtnGerarArquivo.Text = "Gerar Arquivo"
        Me.BtnGerarArquivo.UseVisualStyleBackColor = True
        '
        'LblSomaSalario
        '
        Me.LblSomaSalario.AutoSize = True
        Me.LblSomaSalario.Location = New System.Drawing.Point(587, 204)
        Me.LblSomaSalario.Name = "LblSomaSalario"
        Me.LblSomaSalario.Size = New System.Drawing.Size(39, 13)
        Me.LblSomaSalario.TabIndex = 2
        Me.LblSomaSalario.Text = "Label3"
        '
        'LblSomaAdiantamento
        '
        Me.LblSomaAdiantamento.AutoSize = True
        Me.LblSomaAdiantamento.Location = New System.Drawing.Point(703, 204)
        Me.LblSomaAdiantamento.Name = "LblSomaAdiantamento"
        Me.LblSomaAdiantamento.Size = New System.Drawing.Size(39, 13)
        Me.LblSomaAdiantamento.TabIndex = 1
        Me.LblSomaAdiantamento.Text = "Label3"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListView1.CausesValidation = False
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(24, 34)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(877, 163)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Chave"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Colaborador"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cargo"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Dias"
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Salário"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Adiantamento"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 100
        '
        'BtnDesfazer
        '
        Me.BtnDesfazer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDesfazer.Location = New System.Drawing.Point(46, 452)
        Me.BtnDesfazer.Name = "BtnDesfazer"
        Me.BtnDesfazer.Size = New System.Drawing.Size(138, 23)
        Me.BtnDesfazer.TabIndex = 4
        Me.BtnDesfazer.Text = "Desfazer Arquivo"
        Me.BtnDesfazer.UseVisualStyleBackColor = True
        Me.BtnDesfazer.Visible = False
        '
        'BtnNovaReferencia
        '
        Me.BtnNovaReferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNovaReferencia.Location = New System.Drawing.Point(214, 452)
        Me.BtnNovaReferencia.Name = "BtnNovaReferencia"
        Me.BtnNovaReferencia.Size = New System.Drawing.Size(138, 23)
        Me.BtnNovaReferencia.TabIndex = 5
        Me.BtnNovaReferencia.Text = "Nova Referência"
        Me.BtnNovaReferencia.UseVisualStyleBackColor = True
        Me.BtnNovaReferencia.Visible = False
        '
        'BtnSair
        '
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSair.Location = New System.Drawing.Point(371, 452)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(138, 23)
        Me.BtnSair.TabIndex = 6
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        Me.BtnSair.Visible = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 1
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmFolhaAdiantamentoSalarialPreliminarTodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 487)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnNovaReferencia)
        Me.Controls.Add(Me.BtnDesfazer)
        Me.Controls.Add(Me.GruAdiantamentoShow)
        Me.Controls.Add(Me.GruReferenciaPesquisa)
        Me.Name = "FrmFolhaAdiantamentoSalarialPreliminarTodos"
        Me.Text = "FOLHA - Adiantamento Salarial Todos"
        Me.GruReferenciaPesquisa.ResumeLayout(False)
        Me.GruReferenciaPesquisa.PerformLayout()
        Me.GruvVariavelPagamento.ResumeLayout(False)
        Me.GruvVariavelPagamento.PerformLayout()
        Me.GruAdiantamentoShow.ResumeLayout(False)
        Me.GruAdiantamentoShow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruReferenciaPesquisa As GroupBox
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents MskReferencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GruAdiantamentoShow As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents MskPorcentagemDoSalario As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblSomaSalario As Label
    Friend WithEvents LblSomaAdiantamento As Label
    Friend WithEvents lblSomaBoleean As Label
    Friend WithEvents LblVariavelDescricaoPagamento As Label
    Friend WithEvents MskVariavelPagamento As MaskedTextBox
    Friend WithEvents BtnGerarArquivo As Button
    Friend WithEvents GruvVariavelPagamento As GroupBox
    Friend WithEvents MskDataPagamento As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MskIRpagamento As MaskedTextBox
    Friend WithEvents MskFGTSpagamento As MaskedTextBox
    Friend WithEvents MskINSSpagamento As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MskTipoPagamento As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MskUnidadeHolerite As MaskedTextBox
    Friend WithEvents MskTipoHolerite As MaskedTextBox
    Friend WithEvents MskIRHolerite As MaskedTextBox
    Friend WithEvents MskFGTSHolerite As MaskedTextBox
    Friend WithEvents MskINSSHolerite As MaskedTextBox
    Friend WithEvents MskVariavelHolerite As MaskedTextBox
    Friend WithEvents LblVariavelDescricaoHolerite As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MskUnidadePagamento As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnDesfazer As Button
    Friend WithEvents BtnNovaReferencia As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnVoltaPesquisa As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
