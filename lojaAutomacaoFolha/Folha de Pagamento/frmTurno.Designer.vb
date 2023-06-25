<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurno
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
        Me.GroupControlePrincipal = New System.Windows.Forms.GroupBox()
        Me.btnTurnoCaracteristicas = New System.Windows.Forms.Button()
        Me.turnoTermina = New System.Windows.Forms.Button()
        Me.turnoLimpa = New System.Windows.Forms.Button()
        Me.turnoGrava = New System.Windows.Forms.Button()
        Me.grpTurnos = New System.Windows.Forms.GroupBox()
        Me.ListViewTurno = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpColaboradorDoTurno = New System.Windows.Forms.GroupBox()
        Me.btnTerminaColaboradorTurno = New System.Windows.Forms.Button()
        Me.btnDesfazColaboradorTurno = New System.Windows.Forms.Button()
        Me.btnGravaColaboradorTurno = New System.Windows.Forms.Button()
        Me.lblVolta = New System.Windows.Forms.Label()
        Me.lblVai = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.grpControle = New System.Windows.Forms.GroupBox()
        Me.DiasTrabalhadosNaDemana = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkDescanso = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblColaboradoresNumero = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOrdem = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.mskToleranciaEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFimTurno = New System.Windows.Forms.Button()
        Me.turnoTempo = New System.Windows.Forms.Button()
        Me.turnoFim = New System.Windows.Forms.Label()
        Me.turnoInicioTolerancia = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TurnoTempoDescanso = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.turnoDuracao = New System.Windows.Forms.MaskedTextBox()
        Me.turnoInicio = New System.Windows.Forms.MaskedTextBox()
        Me.TurnoTempoSemanal = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TurnoNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControlePrincipal.SuspendLayout()
        Me.grpTurnos.SuspendLayout()
        Me.grpColaboradorDoTurno.SuspendLayout()
        Me.grpControle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControlePrincipal
        '
        Me.GroupControlePrincipal.Controls.Add(Me.btnTurnoCaracteristicas)
        Me.GroupControlePrincipal.Controls.Add(Me.turnoTermina)
        Me.GroupControlePrincipal.Controls.Add(Me.turnoLimpa)
        Me.GroupControlePrincipal.Controls.Add(Me.turnoGrava)
        Me.GroupControlePrincipal.Location = New System.Drawing.Point(12, 432)
        Me.GroupControlePrincipal.Name = "GroupControlePrincipal"
        Me.GroupControlePrincipal.Size = New System.Drawing.Size(294, 64)
        Me.GroupControlePrincipal.TabIndex = 27
        Me.GroupControlePrincipal.TabStop = False
        Me.GroupControlePrincipal.Text = "Controles "
        '
        'btnTurnoCaracteristicas
        '
        Me.btnTurnoCaracteristicas.Location = New System.Drawing.Point(138, 22)
        Me.btnTurnoCaracteristicas.Name = "btnTurnoCaracteristicas"
        Me.btnTurnoCaracteristicas.Size = New System.Drawing.Size(84, 29)
        Me.btnTurnoCaracteristicas.TabIndex = 20
        Me.btnTurnoCaracteristicas.Text = "caracteristicas"
        Me.btnTurnoCaracteristicas.UseVisualStyleBackColor = True
        '
        'turnoTermina
        '
        Me.turnoTermina.Location = New System.Drawing.Point(228, 22)
        Me.turnoTermina.Name = "turnoTermina"
        Me.turnoTermina.Size = New System.Drawing.Size(60, 29)
        Me.turnoTermina.TabIndex = 19
        Me.turnoTermina.Text = "Termina"
        Me.turnoTermina.UseVisualStyleBackColor = True
        '
        'turnoLimpa
        '
        Me.turnoLimpa.Location = New System.Drawing.Point(72, 22)
        Me.turnoLimpa.Name = "turnoLimpa"
        Me.turnoLimpa.Size = New System.Drawing.Size(60, 29)
        Me.turnoLimpa.TabIndex = 18
        Me.turnoLimpa.Text = "Limpar"
        Me.turnoLimpa.UseVisualStyleBackColor = True
        '
        'turnoGrava
        '
        Me.turnoGrava.Location = New System.Drawing.Point(4, 22)
        Me.turnoGrava.Name = "turnoGrava"
        Me.turnoGrava.Size = New System.Drawing.Size(60, 29)
        Me.turnoGrava.TabIndex = 17
        Me.turnoGrava.Text = "Grava"
        Me.turnoGrava.UseVisualStyleBackColor = True
        '
        'grpTurnos
        '
        Me.grpTurnos.Controls.Add(Me.ListViewTurno)
        Me.grpTurnos.Location = New System.Drawing.Point(287, 12)
        Me.grpTurnos.Name = "grpTurnos"
        Me.grpTurnos.Size = New System.Drawing.Size(977, 261)
        Me.grpTurnos.TabIndex = 26
        Me.grpTurnos.TabStop = False
        Me.grpTurnos.Text = "Turnos - C A R A C T E R I S T I C A S"
        '
        'ListViewTurno
        '
        Me.ListViewTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader
        Me.ListViewTurno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader13, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListViewTurno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewTurno.FullRowSelect = True
        Me.ListViewTurno.GridLines = True
        Me.ListViewTurno.HideSelection = False
        Me.ListViewTurno.Location = New System.Drawing.Point(3, 16)
        Me.ListViewTurno.MultiSelect = False
        Me.ListViewTurno.Name = "ListViewTurno"
        Me.ListViewTurno.Size = New System.Drawing.Size(971, 242)
        Me.ListViewTurno.TabIndex = 18
        Me.ListViewTurno.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "N.Turno"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "H.Semana"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Dia/Sem"
        Me.ColumnHeader13.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Turno.H"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Inicio"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Fim"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descanso"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "E.Adiantada"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "E.Atraso"
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descanso Rem"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Colab."
        Me.ColumnHeader11.Width = 110
        '
        'grpColaboradorDoTurno
        '
        Me.grpColaboradorDoTurno.Controls.Add(Me.btnTerminaColaboradorTurno)
        Me.grpColaboradorDoTurno.Controls.Add(Me.btnDesfazColaboradorTurno)
        Me.grpColaboradorDoTurno.Controls.Add(Me.btnGravaColaboradorTurno)
        Me.grpColaboradorDoTurno.Controls.Add(Me.lblVolta)
        Me.grpColaboradorDoTurno.Controls.Add(Me.lblVai)
        Me.grpColaboradorDoTurno.Controls.Add(Me.Label9)
        Me.grpColaboradorDoTurno.Controls.Add(Me.ListBox2)
        Me.grpColaboradorDoTurno.Controls.Add(Me.Label8)
        Me.grpColaboradorDoTurno.Controls.Add(Me.ListBox1)
        Me.grpColaboradorDoTurno.Location = New System.Drawing.Point(352, 279)
        Me.grpColaboradorDoTurno.Name = "grpColaboradorDoTurno"
        Me.grpColaboradorDoTurno.Size = New System.Drawing.Size(778, 264)
        Me.grpColaboradorDoTurno.TabIndex = 25
        Me.grpColaboradorDoTurno.TabStop = False
        Me.grpColaboradorDoTurno.Text = "Turno - C O L A B O R A D O R E S"
        Me.grpColaboradorDoTurno.Visible = False
        '
        'btnTerminaColaboradorTurno
        '
        Me.btnTerminaColaboradorTurno.Location = New System.Drawing.Point(196, 237)
        Me.btnTerminaColaboradorTurno.Name = "btnTerminaColaboradorTurno"
        Me.btnTerminaColaboradorTurno.Size = New System.Drawing.Size(89, 27)
        Me.btnTerminaColaboradorTurno.TabIndex = 8
        Me.btnTerminaColaboradorTurno.Text = "Termina"
        Me.btnTerminaColaboradorTurno.UseVisualStyleBackColor = True
        '
        'btnDesfazColaboradorTurno
        '
        Me.btnDesfazColaboradorTurno.Location = New System.Drawing.Point(101, 237)
        Me.btnDesfazColaboradorTurno.Name = "btnDesfazColaboradorTurno"
        Me.btnDesfazColaboradorTurno.Size = New System.Drawing.Size(89, 27)
        Me.btnDesfazColaboradorTurno.TabIndex = 7
        Me.btnDesfazColaboradorTurno.Text = "Desfaz"
        Me.btnDesfazColaboradorTurno.UseVisualStyleBackColor = True
        '
        'btnGravaColaboradorTurno
        '
        Me.btnGravaColaboradorTurno.Location = New System.Drawing.Point(6, 237)
        Me.btnGravaColaboradorTurno.Name = "btnGravaColaboradorTurno"
        Me.btnGravaColaboradorTurno.Size = New System.Drawing.Size(89, 27)
        Me.btnGravaColaboradorTurno.TabIndex = 6
        Me.btnGravaColaboradorTurno.Text = "Grava"
        Me.btnGravaColaboradorTurno.UseVisualStyleBackColor = True
        '
        'lblVolta
        '
        Me.lblVolta.AutoSize = True
        Me.lblVolta.Location = New System.Drawing.Point(369, 128)
        Me.lblVolta.Name = "lblVolta"
        Me.lblVolta.Size = New System.Drawing.Size(25, 13)
        Me.lblVolta.TabIndex = 5
        Me.lblVolta.Text = "<=="
        '
        'lblVai
        '
        Me.lblVai.AutoSize = True
        Me.lblVai.Location = New System.Drawing.Point(369, 82)
        Me.lblVai.Name = "lblVai"
        Me.lblVai.Size = New System.Drawing.Size(25, 13)
        Me.lblVai.TabIndex = 4
        Me.lblVai.Text = "==>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(643, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "S E M   V I N C U L O"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(401, 44)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(352, 173)
        Me.ListBox2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "V I N C U L A D O S"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 44)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(352, 173)
        Me.ListBox1.TabIndex = 0
        '
        'grpControle
        '
        Me.grpControle.Controls.Add(Me.DiasTrabalhadosNaDemana)
        Me.grpControle.Controls.Add(Me.Label12)
        Me.grpControle.Controls.Add(Me.chkDescanso)
        Me.grpControle.Controls.Add(Me.Label11)
        Me.grpControle.Controls.Add(Me.Label10)
        Me.grpControle.Controls.Add(Me.lblColaboradoresNumero)
        Me.grpControle.Controls.Add(Me.Label7)
        Me.grpControle.Controls.Add(Me.lblOrdem)
        Me.grpControle.Controls.Add(Me.lblTipo)
        Me.grpControle.Controls.Add(Me.mskToleranciaEntrada)
        Me.grpControle.Controls.Add(Me.Label4)
        Me.grpControle.Controls.Add(Me.btnFimTurno)
        Me.grpControle.Controls.Add(Me.turnoTempo)
        Me.grpControle.Controls.Add(Me.turnoFim)
        Me.grpControle.Controls.Add(Me.turnoInicioTolerancia)
        Me.grpControle.Controls.Add(Me.Label6)
        Me.grpControle.Controls.Add(Me.TurnoTempoDescanso)
        Me.grpControle.Controls.Add(Me.Label5)
        Me.grpControle.Controls.Add(Me.turnoDuracao)
        Me.grpControle.Controls.Add(Me.turnoInicio)
        Me.grpControle.Controls.Add(Me.TurnoTempoSemanal)
        Me.grpControle.Controls.Add(Me.Label3)
        Me.grpControle.Controls.Add(Me.Label2)
        Me.grpControle.Controls.Add(Me.TurnoNome)
        Me.grpControle.Controls.Add(Me.Label1)
        Me.grpControle.Location = New System.Drawing.Point(12, 12)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Size = New System.Drawing.Size(269, 414)
        Me.grpControle.TabIndex = 24
        Me.grpControle.TabStop = False
        Me.grpControle.Text = " C A D A S T R A M E N T O"
        '
        'DiasTrabalhadosNaDemana
        '
        Me.DiasTrabalhadosNaDemana.Location = New System.Drawing.Point(171, 73)
        Me.DiasTrabalhadosNaDemana.Mask = "00"
        Me.DiasTrabalhadosNaDemana.Name = "DiasTrabalhadosNaDemana"
        Me.DiasTrabalhadosNaDemana.Size = New System.Drawing.Size(52, 20)
        Me.DiasTrabalhadosNaDemana.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Dias Trabalhados na Semana:"
        '
        'chkDescanso
        '
        Me.chkDescanso.AutoSize = True
        Me.chkDescanso.Location = New System.Drawing.Point(173, 279)
        Me.chkDescanso.Name = "chkDescanso"
        Me.chkDescanso.Size = New System.Drawing.Size(15, 14)
        Me.chkDescanso.TabIndex = 42
        Me.chkDescanso.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Descanso Remunerado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Colaboradores do Turno:"
        '
        'lblColaboradoresNumero
        '
        Me.lblColaboradoresNumero.AutoSize = True
        Me.lblColaboradoresNumero.Location = New System.Drawing.Point(185, 311)
        Me.lblColaboradoresNumero.Name = "lblColaboradoresNumero"
        Me.lblColaboradoresNumero.Size = New System.Drawing.Size(0, 13)
        Me.lblColaboradoresNumero.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Colaboradores"
        '
        'lblOrdem
        '
        Me.lblOrdem.AutoSize = True
        Me.lblOrdem.Location = New System.Drawing.Point(17, 348)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(13, 13)
        Me.lblOrdem.TabIndex = 37
        Me.lblOrdem.Text = "0"
        Me.lblOrdem.Visible = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(33, 348)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(13, 13)
        Me.lblTipo.TabIndex = 36
        Me.lblTipo.Text = "0"
        Me.lblTipo.Visible = False
        '
        'mskToleranciaEntrada
        '
        Me.mskToleranciaEntrada.Location = New System.Drawing.Point(170, 246)
        Me.mskToleranciaEntrada.Mask = "90:00"
        Me.mskToleranciaEntrada.Name = "mskToleranciaEntrada"
        Me.mskToleranciaEntrada.Size = New System.Drawing.Size(52, 20)
        Me.mskToleranciaEntrada.TabIndex = 34
        Me.mskToleranciaEntrada.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tolerância Atraso Entrada:"
        '
        'btnFimTurno
        '
        Me.btnFimTurno.Location = New System.Drawing.Point(20, 374)
        Me.btnFimTurno.Name = "btnFimTurno"
        Me.btnFimTurno.Size = New System.Drawing.Size(127, 19)
        Me.btnFimTurno.TabIndex = 29
        Me.btnFimTurno.Text = "Fim do Turno"
        Me.btnFimTurno.UseVisualStyleBackColor = True
        '
        'turnoTempo
        '
        Me.turnoTempo.Location = New System.Drawing.Point(17, 109)
        Me.turnoTempo.Name = "turnoTempo"
        Me.turnoTempo.Size = New System.Drawing.Size(127, 19)
        Me.turnoTempo.TabIndex = 24
        Me.turnoTempo.Text = "Tempo do Turno"
        Me.turnoTempo.UseVisualStyleBackColor = True
        '
        'turnoFim
        '
        Me.turnoFim.AutoSize = True
        Me.turnoFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoFim.Location = New System.Drawing.Point(170, 374)
        Me.turnoFim.Name = "turnoFim"
        Me.turnoFim.Size = New System.Drawing.Size(102, 16)
        Me.turnoFim.TabIndex = 33
        Me.turnoFim.Text = "Fim do Turno:"
        '
        'turnoInicioTolerancia
        '
        Me.turnoInicioTolerancia.Location = New System.Drawing.Point(170, 215)
        Me.turnoInicioTolerancia.Mask = "90:00"
        Me.turnoInicioTolerancia.Name = "turnoInicioTolerancia"
        Me.turnoInicioTolerancia.Size = New System.Drawing.Size(52, 20)
        Me.turnoInicioTolerancia.TabIndex = 28
        Me.turnoInicioTolerancia.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Tolerância inicio doTurno:"
        '
        'TurnoTempoDescanso
        '
        Me.TurnoTempoDescanso.Location = New System.Drawing.Point(170, 179)
        Me.TurnoTempoDescanso.Mask = "90:00"
        Me.TurnoTempoDescanso.Name = "TurnoTempoDescanso"
        Me.TurnoTempoDescanso.Size = New System.Drawing.Size(52, 20)
        Me.TurnoTempoDescanso.TabIndex = 27
        Me.TurnoTempoDescanso.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Descanso Tempo:"
        '
        'turnoDuracao
        '
        Me.turnoDuracao.Location = New System.Drawing.Point(170, 109)
        Me.turnoDuracao.Mask = "00:00"
        Me.turnoDuracao.Name = "turnoDuracao"
        Me.turnoDuracao.Size = New System.Drawing.Size(52, 20)
        Me.turnoDuracao.TabIndex = 30
        '
        'turnoInicio
        '
        Me.turnoInicio.Location = New System.Drawing.Point(170, 148)
        Me.turnoInicio.Mask = "90:00"
        Me.turnoInicio.Name = "turnoInicio"
        Me.turnoInicio.Size = New System.Drawing.Size(52, 20)
        Me.turnoInicio.TabIndex = 26
        Me.turnoInicio.ValidatingType = GetType(Date)
        '
        'TurnoTempoSemanal
        '
        Me.TurnoTempoSemanal.Location = New System.Drawing.Point(170, 46)
        Me.TurnoTempoSemanal.Mask = "00"
        Me.TurnoTempoSemanal.Name = "TurnoTempoSemanal"
        Me.TurnoTempoSemanal.Size = New System.Drawing.Size(52, 20)
        Me.TurnoTempoSemanal.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Horas Semanais:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Inicio do Turno:"
        '
        'TurnoNome
        '
        Me.TurnoNome.Location = New System.Drawing.Point(170, 18)
        Me.TurnoNome.Name = "TurnoNome"
        Me.TurnoNome.Size = New System.Drawing.Size(92, 20)
        Me.TurnoNome.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nome do Turno:"
        '
        'frmTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 546)
        Me.Controls.Add(Me.GroupControlePrincipal)
        Me.Controls.Add(Me.grpTurnos)
        Me.Controls.Add(Me.grpColaboradorDoTurno)
        Me.Controls.Add(Me.grpControle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTurno"
        Me.Text = "frmTurno"
        Me.GroupControlePrincipal.ResumeLayout(False)
        Me.grpTurnos.ResumeLayout(False)
        Me.grpColaboradorDoTurno.ResumeLayout(False)
        Me.grpColaboradorDoTurno.PerformLayout()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControlePrincipal As GroupBox
    Friend WithEvents btnTurnoCaracteristicas As Button
    Friend WithEvents turnoTermina As Button
    Friend WithEvents turnoLimpa As Button
    Friend WithEvents turnoGrava As Button
    Friend WithEvents grpTurnos As GroupBox
    Friend WithEvents ListViewTurno As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents grpColaboradorDoTurno As GroupBox
    Friend WithEvents btnTerminaColaboradorTurno As Button
    Friend WithEvents btnDesfazColaboradorTurno As Button
    Friend WithEvents btnGravaColaboradorTurno As Button
    Friend WithEvents lblVolta As Label
    Friend WithEvents lblVai As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents grpControle As GroupBox
    Friend WithEvents lblColaboradoresNumero As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOrdem As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents mskToleranciaEntrada As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFimTurno As Button
    Friend WithEvents turnoTempo As Button
    Friend WithEvents turnoFim As Label
    Friend WithEvents turnoInicioTolerancia As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TurnoTempoDescanso As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents turnoDuracao As MaskedTextBox
    Friend WithEvents turnoInicio As MaskedTextBox
    Friend WithEvents TurnoTempoSemanal As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TurnoNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents chkDescanso As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DiasTrabalhadosNaDemana As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
