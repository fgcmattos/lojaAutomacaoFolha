<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFolhaRefDescanso
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
        Me.GruEdicaoGeral = New System.Windows.Forms.GroupBox()
        Me.GruEdicao = New System.Windows.Forms.GroupBox()
        Me.BtnSaiDaEdicao = New System.Windows.Forms.Button()
        Me.LblEdicaoTipo = New System.Windows.Forms.Label()
        Me.BtnRetira = New System.Windows.Forms.Button()
        Me.LblEdicaoSemana = New System.Windows.Forms.Label()
        Me.BtnEdita = New System.Windows.Forms.Button()
        Me.CmbTitulo = New System.Windows.Forms.ComboBox()
        Me.LbDiaSemanal = New System.Windows.Forms.Label()
        Me.TxtEdicaoHistorico = New System.Windows.Forms.TextBox()
        Me.MskEdicaoDia = New System.Windows.Forms.MaskedTextBox()
        Me.LblHistorico = New System.Windows.Forms.Label()
        Me.LblSemana = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblDia = New System.Windows.Forms.Label()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.LvwShow = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GruReferencia = New System.Windows.Forms.GroupBox()
        Me.BtnAbreEdicao = New System.Windows.Forms.Button()
        Me.BtnReinicializa = New System.Windows.Forms.Button()
        Me.LblkeyCab = New System.Windows.Forms.Label()
        Me.GruParamentrosReferencia = New System.Windows.Forms.GroupBox()
        Me.LblSemanaFinal = New System.Windows.Forms.Label()
        Me.LblSemanaInicial = New System.Windows.Forms.Label()
        Me.Lblferiados = New System.Windows.Forms.Label()
        Me.LblDomingos = New System.Windows.Forms.Label()
        Me.LblDiasDescanso = New System.Windows.Forms.Label()
        Me.LblDiasUteis = New System.Windows.Forms.Label()
        Me.LblDiasCorridos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAviso = New System.Windows.Forms.Label()
        Me.LblReferenciaDescricao = New System.Windows.Forms.Label()
        Me.MskMesAno = New System.Windows.Forms.MaskedTextBox()
        Me.GruEdicaoGeral.SuspendLayout()
        Me.GruEdicao.SuspendLayout()
        Me.GruReferencia.SuspendLayout()
        Me.GruParamentrosReferencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'GruEdicaoGeral
        '
        Me.GruEdicaoGeral.Controls.Add(Me.GruEdicao)
        Me.GruEdicaoGeral.Controls.Add(Me.BtnGravar)
        Me.GruEdicaoGeral.Controls.Add(Me.LvwShow)
        Me.GruEdicaoGeral.Enabled = False
        Me.GruEdicaoGeral.Location = New System.Drawing.Point(1, 145)
        Me.GruEdicaoGeral.Name = "GruEdicaoGeral"
        Me.GruEdicaoGeral.Size = New System.Drawing.Size(787, 436)
        Me.GruEdicaoGeral.TabIndex = 3
        Me.GruEdicaoGeral.TabStop = False
        Me.GruEdicaoGeral.Text = "Apontamento na Referência"
        '
        'GruEdicao
        '
        Me.GruEdicao.Controls.Add(Me.BtnSaiDaEdicao)
        Me.GruEdicao.Controls.Add(Me.LblEdicaoTipo)
        Me.GruEdicao.Controls.Add(Me.BtnRetira)
        Me.GruEdicao.Controls.Add(Me.LblEdicaoSemana)
        Me.GruEdicao.Controls.Add(Me.BtnEdita)
        Me.GruEdicao.Controls.Add(Me.CmbTitulo)
        Me.GruEdicao.Controls.Add(Me.LbDiaSemanal)
        Me.GruEdicao.Controls.Add(Me.TxtEdicaoHistorico)
        Me.GruEdicao.Controls.Add(Me.MskEdicaoDia)
        Me.GruEdicao.Controls.Add(Me.LblHistorico)
        Me.GruEdicao.Controls.Add(Me.LblSemana)
        Me.GruEdicao.Controls.Add(Me.LblTitulo)
        Me.GruEdicao.Controls.Add(Me.LblNome)
        Me.GruEdicao.Controls.Add(Me.LblDia)
        Me.GruEdicao.Location = New System.Drawing.Point(11, 206)
        Me.GruEdicao.Name = "GruEdicao"
        Me.GruEdicao.Size = New System.Drawing.Size(411, 224)
        Me.GruEdicao.TabIndex = 3
        Me.GruEdicao.TabStop = False
        Me.GruEdicao.Text = "Edição de Referência"
        '
        'BtnSaiDaEdicao
        '
        Me.BtnSaiDaEdicao.Location = New System.Drawing.Point(271, 192)
        Me.BtnSaiDaEdicao.Name = "BtnSaiDaEdicao"
        Me.BtnSaiDaEdicao.Size = New System.Drawing.Size(119, 19)
        Me.BtnSaiDaEdicao.TabIndex = 15
        Me.BtnSaiDaEdicao.Text = "Sair da Edição"
        Me.BtnSaiDaEdicao.UseVisualStyleBackColor = True
        '
        'LblEdicaoTipo
        '
        Me.LblEdicaoTipo.AutoSize = True
        Me.LblEdicaoTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblEdicaoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdicaoTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblEdicaoTipo.Location = New System.Drawing.Point(7, 27)
        Me.LblEdicaoTipo.Name = "LblEdicaoTipo"
        Me.LblEdicaoTipo.Size = New System.Drawing.Size(57, 20)
        Me.LblEdicaoTipo.TabIndex = 14
        Me.LblEdicaoTipo.Text = "Label1"
        Me.LblEdicaoTipo.Visible = False
        '
        'BtnRetira
        '
        Me.BtnRetira.Location = New System.Drawing.Point(146, 192)
        Me.BtnRetira.Name = "BtnRetira"
        Me.BtnRetira.Size = New System.Drawing.Size(119, 19)
        Me.BtnRetira.TabIndex = 13
        Me.BtnRetira.Text = "Retira"
        Me.BtnRetira.UseVisualStyleBackColor = True
        Me.BtnRetira.Visible = False
        '
        'LblEdicaoSemana
        '
        Me.LblEdicaoSemana.AutoSize = True
        Me.LblEdicaoSemana.Location = New System.Drawing.Point(221, 63)
        Me.LblEdicaoSemana.Name = "LblEdicaoSemana"
        Me.LblEdicaoSemana.Size = New System.Drawing.Size(0, 13)
        Me.LblEdicaoSemana.TabIndex = 12
        '
        'BtnEdita
        '
        Me.BtnEdita.Location = New System.Drawing.Point(12, 192)
        Me.BtnEdita.Name = "BtnEdita"
        Me.BtnEdita.Size = New System.Drawing.Size(119, 19)
        Me.BtnEdita.TabIndex = 11
        Me.BtnEdita.Text = "Edita"
        Me.BtnEdita.UseVisualStyleBackColor = True
        Me.BtnEdita.Visible = False
        '
        'CmbTitulo
        '
        Me.CmbTitulo.Enabled = False
        Me.CmbTitulo.FormattingEnabled = True
        Me.CmbTitulo.Items.AddRange(New Object() {"Feriado Nacional", "Feriado Estadual", "Feriado Municipal", "Ponto Facultativo Nacional", "Ponto Facultativo Estadual", "Ponto Facutativo Municipal", "CARNAVAL"})
        Me.CmbTitulo.Location = New System.Drawing.Point(63, 118)
        Me.CmbTitulo.Name = "CmbTitulo"
        Me.CmbTitulo.Size = New System.Drawing.Size(170, 21)
        Me.CmbTitulo.TabIndex = 10
        '
        'LbDiaSemanal
        '
        Me.LbDiaSemanal.AutoSize = True
        Me.LbDiaSemanal.Location = New System.Drawing.Point(60, 91)
        Me.LbDiaSemanal.Name = "LbDiaSemanal"
        Me.LbDiaSemanal.Size = New System.Drawing.Size(39, 13)
        Me.LbDiaSemanal.TabIndex = 9
        Me.LbDiaSemanal.Text = "Label8"
        '
        'TxtEdicaoHistorico
        '
        Me.TxtEdicaoHistorico.Enabled = False
        Me.TxtEdicaoHistorico.Location = New System.Drawing.Point(63, 158)
        Me.TxtEdicaoHistorico.Name = "TxtEdicaoHistorico"
        Me.TxtEdicaoHistorico.Size = New System.Drawing.Size(260, 20)
        Me.TxtEdicaoHistorico.TabIndex = 8
        '
        'MskEdicaoDia
        '
        Me.MskEdicaoDia.Location = New System.Drawing.Point(63, 56)
        Me.MskEdicaoDia.Mask = "00"
        Me.MskEdicaoDia.Name = "MskEdicaoDia"
        Me.MskEdicaoDia.Size = New System.Drawing.Size(27, 20)
        Me.MskEdicaoDia.TabIndex = 5
        '
        'LblHistorico
        '
        Me.LblHistorico.AutoSize = True
        Me.LblHistorico.Location = New System.Drawing.Point(9, 165)
        Me.LblHistorico.Name = "LblHistorico"
        Me.LblHistorico.Size = New System.Drawing.Size(48, 13)
        Me.LblHistorico.TabIndex = 4
        Me.LblHistorico.Text = "Histórico"
        '
        'LblSemana
        '
        Me.LblSemana.AutoSize = True
        Me.LblSemana.Location = New System.Drawing.Point(123, 63)
        Me.LblSemana.Name = "LblSemana"
        Me.LblSemana.Size = New System.Drawing.Size(60, 13)
        Me.LblSemana.TabIndex = 3
        Me.LblSemana.Text = "Semana N."
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(8, 131)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.LblTitulo.TabIndex = 2
        Me.LblTitulo.Text = "Titulo"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(6, 91)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 1
        Me.LblNome.Text = "Nome"
        '
        'LblDia
        '
        Me.LblDia.AutoSize = True
        Me.LblDia.Location = New System.Drawing.Point(6, 63)
        Me.LblDia.Name = "LblDia"
        Me.LblDia.Size = New System.Drawing.Size(23, 13)
        Me.LblDia.TabIndex = 0
        Me.LblDia.Text = "Dia"
        '
        'BtnGravar
        '
        Me.BtnGravar.Location = New System.Drawing.Point(447, 229)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(119, 24)
        Me.BtnGravar.TabIndex = 2
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'LvwShow
        '
        Me.LvwShow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LvwShow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvwShow.FullRowSelect = True
        Me.LvwShow.GridLines = True
        Me.LvwShow.HideSelection = False
        Me.LvwShow.Location = New System.Drawing.Point(11, 19)
        Me.LvwShow.Name = "LvwShow"
        Me.LvwShow.Size = New System.Drawing.Size(770, 181)
        Me.LvwShow.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LvwShow.TabIndex = 0
        Me.LvwShow.UseCompatibleStateImageBehavior = False
        Me.LvwShow.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Dia"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 3
        Me.ColumnHeader3.Text = "Titulo"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 4
        Me.ColumnHeader4.Text = "Semana"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 5
        Me.ColumnHeader5.Text = "Histórico"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 1
        Me.ColumnHeader6.Text = "ST"
        Me.ColumnHeader6.Width = 40
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "KeyCab"
        '
        'GruReferencia
        '
        Me.GruReferencia.BackColor = System.Drawing.SystemColors.Highlight
        Me.GruReferencia.Controls.Add(Me.BtnAbreEdicao)
        Me.GruReferencia.Controls.Add(Me.BtnReinicializa)
        Me.GruReferencia.Controls.Add(Me.LblkeyCab)
        Me.GruReferencia.Controls.Add(Me.GruParamentrosReferencia)
        Me.GruReferencia.Controls.Add(Me.LblAviso)
        Me.GruReferencia.Controls.Add(Me.LblReferenciaDescricao)
        Me.GruReferencia.Controls.Add(Me.MskMesAno)
        Me.GruReferencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GruReferencia.Location = New System.Drawing.Point(1, 0)
        Me.GruReferencia.Name = "GruReferencia"
        Me.GruReferencia.Size = New System.Drawing.Size(787, 139)
        Me.GruReferencia.TabIndex = 2
        Me.GruReferencia.TabStop = False
        Me.GruReferencia.Text = "R E F E R Ê N C I A"
        '
        'BtnAbreEdicao
        '
        Me.BtnAbreEdicao.Enabled = False
        Me.BtnAbreEdicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAbreEdicao.Location = New System.Drawing.Point(237, 112)
        Me.BtnAbreEdicao.Name = "BtnAbreEdicao"
        Me.BtnAbreEdicao.Size = New System.Drawing.Size(215, 20)
        Me.BtnAbreEdicao.TabIndex = 7
        Me.BtnAbreEdicao.Text = "Abre edição"
        Me.BtnAbreEdicao.UseVisualStyleBackColor = True
        '
        'BtnReinicializa
        '
        Me.BtnReinicializa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnReinicializa.Location = New System.Drawing.Point(16, 112)
        Me.BtnReinicializa.Name = "BtnReinicializa"
        Me.BtnReinicializa.Size = New System.Drawing.Size(215, 20)
        Me.BtnReinicializa.TabIndex = 6
        Me.BtnReinicializa.Text = "Reinicializar Referência"
        Me.BtnReinicializa.UseVisualStyleBackColor = True
        Me.BtnReinicializa.Visible = False
        '
        'LblkeyCab
        '
        Me.LblkeyCab.AutoSize = True
        Me.LblkeyCab.Location = New System.Drawing.Point(405, 21)
        Me.LblkeyCab.Name = "LblkeyCab"
        Me.LblkeyCab.Size = New System.Drawing.Size(39, 13)
        Me.LblkeyCab.TabIndex = 5
        Me.LblkeyCab.Text = "Label8"
        Me.LblkeyCab.Visible = False
        '
        'GruParamentrosReferencia
        '
        Me.GruParamentrosReferencia.Controls.Add(Me.LblSemanaFinal)
        Me.GruParamentrosReferencia.Controls.Add(Me.LblSemanaInicial)
        Me.GruParamentrosReferencia.Controls.Add(Me.Lblferiados)
        Me.GruParamentrosReferencia.Controls.Add(Me.LblDomingos)
        Me.GruParamentrosReferencia.Controls.Add(Me.LblDiasDescanso)
        Me.GruParamentrosReferencia.Controls.Add(Me.LblDiasUteis)
        Me.GruParamentrosReferencia.Controls.Add(Me.LblDiasCorridos)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label7)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label6)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label5)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label4)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label3)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label2)
        Me.GruParamentrosReferencia.Controls.Add(Me.Label1)
        Me.GruParamentrosReferencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GruParamentrosReferencia.Location = New System.Drawing.Point(464, 16)
        Me.GruParamentrosReferencia.Name = "GruParamentrosReferencia"
        Me.GruParamentrosReferencia.Size = New System.Drawing.Size(317, 117)
        Me.GruParamentrosReferencia.TabIndex = 4
        Me.GruParamentrosReferencia.TabStop = False
        Me.GruParamentrosReferencia.Text = "Parametros da referência"
        Me.GruParamentrosReferencia.Visible = False
        '
        'LblSemanaFinal
        '
        Me.LblSemanaFinal.AutoSize = True
        Me.LblSemanaFinal.Location = New System.Drawing.Point(291, 63)
        Me.LblSemanaFinal.Name = "LblSemanaFinal"
        Me.LblSemanaFinal.Size = New System.Drawing.Size(13, 13)
        Me.LblSemanaFinal.TabIndex = 13
        Me.LblSemanaFinal.Text = "1"
        '
        'LblSemanaInicial
        '
        Me.LblSemanaInicial.AutoSize = True
        Me.LblSemanaInicial.Location = New System.Drawing.Point(291, 41)
        Me.LblSemanaInicial.Name = "LblSemanaInicial"
        Me.LblSemanaInicial.Size = New System.Drawing.Size(13, 13)
        Me.LblSemanaInicial.TabIndex = 12
        Me.LblSemanaInicial.Text = "1"
        '
        'Lblferiados
        '
        Me.Lblferiados.AutoSize = True
        Me.Lblferiados.Location = New System.Drawing.Point(291, 20)
        Me.Lblferiados.Name = "Lblferiados"
        Me.Lblferiados.Size = New System.Drawing.Size(13, 13)
        Me.Lblferiados.TabIndex = 11
        Me.Lblferiados.Text = "1"
        '
        'LblDomingos
        '
        Me.LblDomingos.AutoSize = True
        Me.LblDomingos.Location = New System.Drawing.Point(140, 90)
        Me.LblDomingos.Name = "LblDomingos"
        Me.LblDomingos.Size = New System.Drawing.Size(13, 13)
        Me.LblDomingos.TabIndex = 10
        Me.LblDomingos.Text = "1"
        '
        'LblDiasDescanso
        '
        Me.LblDiasDescanso.AutoSize = True
        Me.LblDiasDescanso.Location = New System.Drawing.Point(140, 63)
        Me.LblDiasDescanso.Name = "LblDiasDescanso"
        Me.LblDiasDescanso.Size = New System.Drawing.Size(13, 13)
        Me.LblDiasDescanso.TabIndex = 9
        Me.LblDiasDescanso.Text = "1"
        '
        'LblDiasUteis
        '
        Me.LblDiasUteis.AutoSize = True
        Me.LblDiasUteis.Location = New System.Drawing.Point(140, 41)
        Me.LblDiasUteis.Name = "LblDiasUteis"
        Me.LblDiasUteis.Size = New System.Drawing.Size(13, 13)
        Me.LblDiasUteis.TabIndex = 8
        Me.LblDiasUteis.Text = "1"
        '
        'LblDiasCorridos
        '
        Me.LblDiasCorridos.AutoSize = True
        Me.LblDiasCorridos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDiasCorridos.Location = New System.Drawing.Point(140, 20)
        Me.LblDiasCorridos.Name = "LblDiasCorridos"
        Me.LblDiasCorridos.Size = New System.Drawing.Size(13, 13)
        Me.LblDiasCorridos.TabIndex = 7
        Me.LblDiasCorridos.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Semana Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Semana Inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "feriados da Referência"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Domingos da Referência"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dias de descanso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dias Uteis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dias Corridos"
        '
        'LblAviso
        '
        Me.LblAviso.AutoSize = True
        Me.LblAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAviso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblAviso.Location = New System.Drawing.Point(18, 57)
        Me.LblAviso.Name = "LblAviso"
        Me.LblAviso.Size = New System.Drawing.Size(57, 20)
        Me.LblAviso.TabIndex = 3
        Me.LblAviso.Text = "Label1"
        Me.LblAviso.Visible = False
        '
        'LblReferenciaDescricao
        '
        Me.LblReferenciaDescricao.AutoSize = True
        Me.LblReferenciaDescricao.BackColor = System.Drawing.Color.Maroon
        Me.LblReferenciaDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReferenciaDescricao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblReferenciaDescricao.Location = New System.Drawing.Point(110, 25)
        Me.LblReferenciaDescricao.Name = "LblReferenciaDescricao"
        Me.LblReferenciaDescricao.Size = New System.Drawing.Size(0, 16)
        Me.LblReferenciaDescricao.TabIndex = 2
        '
        'MskMesAno
        '
        Me.MskMesAno.Location = New System.Drawing.Point(12, 21)
        Me.MskMesAno.Mask = "00/0000"
        Me.MskMesAno.Name = "MskMesAno"
        Me.MskMesAno.Size = New System.Drawing.Size(77, 20)
        Me.MskMesAno.TabIndex = 0
        '
        'FrmFolhaRefDescanso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 584)
        Me.Controls.Add(Me.GruEdicaoGeral)
        Me.Controls.Add(Me.GruReferencia)
        Me.Name = "FrmFolhaRefDescanso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFolhaRefDescanso"
        Me.GruEdicaoGeral.ResumeLayout(False)
        Me.GruEdicao.ResumeLayout(False)
        Me.GruEdicao.PerformLayout()
        Me.GruReferencia.ResumeLayout(False)
        Me.GruReferencia.PerformLayout()
        Me.GruParamentrosReferencia.ResumeLayout(False)
        Me.GruParamentrosReferencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GruEdicaoGeral As GroupBox
    Friend WithEvents LvwShow As ListView
    Friend WithEvents GruReferencia As GroupBox
    Friend WithEvents LblReferenciaDescricao As Label
    Friend WithEvents MskMesAno As MaskedTextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents LblAviso As Label
    Friend WithEvents BtnGravar As Button
    Friend WithEvents GruParamentrosReferencia As GroupBox
    Friend WithEvents LblSemanaFinal As Label
    Friend WithEvents LblSemanaInicial As Label
    Friend WithEvents Lblferiados As Label
    Friend WithEvents LblDomingos As Label
    Friend WithEvents LblDiasDescanso As Label
    Friend WithEvents LblDiasUteis As Label
    Friend WithEvents LblDiasCorridos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GruEdicao As GroupBox
    Friend WithEvents CmbTitulo As ComboBox
    Friend WithEvents LbDiaSemanal As Label
    Friend WithEvents TxtEdicaoHistorico As TextBox
    Friend WithEvents MskEdicaoDia As MaskedTextBox
    Friend WithEvents LblHistorico As Label
    Friend WithEvents LblSemana As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblDia As Label
    Friend WithEvents BtnEdita As Button
    Friend WithEvents LblEdicaoSemana As Label
    Friend WithEvents LblEdicaoTipo As Label
    Friend WithEvents BtnRetira As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents LblkeyCab As Label
    Friend WithEvents BtnReinicializa As Button
    Friend WithEvents BtnAbreEdicao As Button
    Friend WithEvents BtnSaiDaEdicao As Button
End Class
