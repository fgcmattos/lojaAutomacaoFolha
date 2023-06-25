<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFolhaDiarioRelatorio
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
        Me.btnTermina = New System.Windows.Forms.Button()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.folhaDiarioData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnImprimePeriodo = New System.Windows.Forms.Button()
        Me.mskDataFim = New System.Windows.Forms.MaskedTextBox()
        Me.mskDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTurnoFim = New System.Windows.Forms.Label()
        Me.lblturnoInico = New System.Windows.Forms.Label()
        Me.lblTurnoDuracao = New System.Windows.Forms.Label()
        Me.LblRG = New System.Windows.Forms.Label()
        Me.LblCPF = New System.Windows.Forms.Label()
        Me.LblDescanso = New System.Windows.Forms.Label()
        Me.LabHorario = New System.Windows.Forms.Label()
        Me.LblTurno = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.folhaDiarioColaborador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblChave = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTermina
        '
        Me.btnTermina.Location = New System.Drawing.Point(58, 479)
        Me.btnTermina.Name = "btnTermina"
        Me.btnTermina.Size = New System.Drawing.Size(721, 22)
        Me.btnTermina.TabIndex = 23
        Me.btnTermina.Text = "&Termina"
        Me.btnTermina.UseVisualStyleBackColor = True
        '
        'btnImprime
        '
        Me.btnImprime.Location = New System.Drawing.Point(58, 444)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(721, 24)
        Me.btnImprime.TabIndex = 22
        Me.btnImprime.Text = "&Imprime"
        Me.btnImprime.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(58, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(845, 358)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.folhaDiarioData)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnPesquisa)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(837, 332)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "(Minutos)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Saldo do Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Gerado(HH:MM)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tempo"
        '
        'folhaDiarioData
        '
        Me.folhaDiarioData.Location = New System.Drawing.Point(746, 8)
        Me.folhaDiarioData.Mask = "00/00/0000"
        Me.folhaDiarioData.Name = "folhaDiarioData"
        Me.folhaDiarioData.Size = New System.Drawing.Size(85, 20)
        Me.folhaDiarioData.TabIndex = 34
        Me.folhaDiarioData.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(694, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Data:"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(6, 304)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(701, 22)
        Me.btnPesquisa.TabIndex = 32
        Me.btnPesquisa.Text = "&Pesquisa"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(560, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "(Minutos)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(560, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "B.Horas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(277, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Horário"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(157, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Movivento"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(758, 251)
        Me.ListBox1.TabIndex = 26
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(837, 332)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Periodo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnImprimePeriodo)
        Me.GroupBox2.Controls.Add(Me.mskDataFim)
        Me.GroupBox2.Controls.Add(Me.mskDataInicio)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 166)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de Impressão"
        '
        'btnImprimePeriodo
        '
        Me.btnImprimePeriodo.Location = New System.Drawing.Point(37, 118)
        Me.btnImprimePeriodo.Name = "btnImprimePeriodo"
        Me.btnImprimePeriodo.Size = New System.Drawing.Size(168, 23)
        Me.btnImprimePeriodo.TabIndex = 9
        Me.btnImprimePeriodo.Text = "I M P R I M E"
        Me.btnImprimePeriodo.UseVisualStyleBackColor = True
        '
        'mskDataFim
        '
        Me.mskDataFim.Location = New System.Drawing.Point(99, 77)
        Me.mskDataFim.Mask = "00/00/0000"
        Me.mskDataFim.Name = "mskDataFim"
        Me.mskDataFim.Size = New System.Drawing.Size(107, 20)
        Me.mskDataFim.TabIndex = 8
        Me.mskDataFim.ValidatingType = GetType(Date)
        '
        'mskDataInicio
        '
        Me.mskDataInicio.Location = New System.Drawing.Point(99, 46)
        Me.mskDataInicio.Mask = "00/00/0000"
        Me.mskDataInicio.Name = "mskDataInicio"
        Me.mskDataInicio.Size = New System.Drawing.Size(107, 20)
        Me.mskDataInicio.TabIndex = 7
        Me.mskDataInicio.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Fim"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Início"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Controls.Add(Me.lblCargo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.lblChave)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblTurnoFim)
        Me.GroupBox1.Controls.Add(Me.lblturnoInico)
        Me.GroupBox1.Controls.Add(Me.lblTurnoDuracao)
        Me.GroupBox1.Controls.Add(Me.LblRG)
        Me.GroupBox1.Controls.Add(Me.LblCPF)
        Me.GroupBox1.Controls.Add(Me.LblDescanso)
        Me.GroupBox1.Controls.Add(Me.LabHorario)
        Me.GroupBox1.Controls.Add(Me.LblTurno)
        Me.GroupBox1.Controls.Add(Me.LblNome)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Location = New System.Drawing.Point(301, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 252)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "C A R A C T E R I S T I C A S  P A R A   A   I M P R E S S Ã O   "
        '
        'lblTurnoFim
        '
        Me.lblTurnoFim.AutoSize = True
        Me.lblTurnoFim.BackColor = System.Drawing.Color.Red
        Me.lblTurnoFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnoFim.ForeColor = System.Drawing.Color.White
        Me.lblTurnoFim.Location = New System.Drawing.Point(82, 166)
        Me.lblTurnoFim.Name = "lblTurnoFim"
        Me.lblTurnoFim.Size = New System.Drawing.Size(52, 13)
        Me.lblTurnoFim.TabIndex = 15
        Me.lblTurnoFim.Text = "Label21"
        '
        'lblturnoInico
        '
        Me.lblturnoInico.AutoSize = True
        Me.lblturnoInico.BackColor = System.Drawing.Color.Red
        Me.lblturnoInico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturnoInico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblturnoInico.Location = New System.Drawing.Point(82, 149)
        Me.lblturnoInico.Name = "lblturnoInico"
        Me.lblturnoInico.Size = New System.Drawing.Size(52, 13)
        Me.lblturnoInico.TabIndex = 14
        Me.lblturnoInico.Text = "Label21"
        '
        'lblTurnoDuracao
        '
        Me.lblTurnoDuracao.AutoSize = True
        Me.lblTurnoDuracao.BackColor = System.Drawing.Color.Red
        Me.lblTurnoDuracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnoDuracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTurnoDuracao.Location = New System.Drawing.Point(82, 191)
        Me.lblTurnoDuracao.Name = "lblTurnoDuracao"
        Me.lblTurnoDuracao.Size = New System.Drawing.Size(52, 13)
        Me.lblTurnoDuracao.TabIndex = 13
        Me.lblTurnoDuracao.Text = "Label21"
        '
        'LblRG
        '
        Me.LblRG.AutoSize = True
        Me.LblRG.BackColor = System.Drawing.Color.Red
        Me.LblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRG.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblRG.Location = New System.Drawing.Point(229, 74)
        Me.LblRG.Name = "LblRG"
        Me.LblRG.Size = New System.Drawing.Size(18, 13)
        Me.LblRG.TabIndex = 12
        Me.LblRG.Text = "rg"
        '
        'LblCPF
        '
        Me.LblCPF.AutoSize = True
        Me.LblCPF.BackColor = System.Drawing.Color.Red
        Me.LblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCPF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCPF.Location = New System.Drawing.Point(85, 74)
        Me.LblCPF.Name = "LblCPF"
        Me.LblCPF.Size = New System.Drawing.Size(25, 13)
        Me.LblCPF.TabIndex = 11
        Me.LblCPF.Text = "cpf"
        '
        'LblDescanso
        '
        Me.LblDescanso.AutoSize = True
        Me.LblDescanso.BackColor = System.Drawing.Color.Red
        Me.LblDescanso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescanso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDescanso.Location = New System.Drawing.Point(82, 122)
        Me.LblDescanso.Name = "LblDescanso"
        Me.LblDescanso.Size = New System.Drawing.Size(48, 13)
        Me.LblDescanso.TabIndex = 10
        Me.LblDescanso.Text = "Horário"
        '
        'LabHorario
        '
        Me.LabHorario.AutoSize = True
        Me.LabHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHorario.Location = New System.Drawing.Point(15, 145)
        Me.LabHorario.Name = "LabHorario"
        Me.LabHorario.Size = New System.Drawing.Size(38, 13)
        Me.LabHorario.TabIndex = 9
        Me.LabHorario.Text = "Inicio"
        '
        'LblTurno
        '
        Me.LblTurno.AutoSize = True
        Me.LblTurno.BackColor = System.Drawing.Color.Red
        Me.LblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTurno.Location = New System.Drawing.Point(82, 98)
        Me.LblTurno.Name = "LblTurno"
        Me.LblTurno.Size = New System.Drawing.Size(40, 13)
        Me.LblTurno.TabIndex = 8
        Me.LblTurno.Text = "Turno"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.BackColor = System.Drawing.Color.Red
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNome.Location = New System.Drawing.Point(82, 53)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(39, 13)
        Me.LblNome.TabIndex = 7
        Me.LblNome.Text = "Nome"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 225)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(198, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Descanso Descontado do Horário"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Descanso"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Sienna
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Aqua
        Me.Label18.Location = New System.Drawing.Point(15, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Termino"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Turno"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Aqua
        Me.Label16.Location = New System.Drawing.Point(198, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "RG"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Sienna
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Aqua
        Me.Label15.Location = New System.Drawing.Point(20, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "CPF"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Sienna
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Aqua
        Me.Label14.Location = New System.Drawing.Point(15, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nome"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnSelecionar)
        Me.GroupBox3.Controls.Add(Me.folhaDiarioColaborador)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(136, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 55)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ão de Colaborador"
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.Location = New System.Drawing.Point(523, 19)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(183, 24)
        Me.BtnSelecionar.TabIndex = 18
        Me.BtnSelecionar.Text = "S E L E C I O N A R"
        Me.BtnSelecionar.UseVisualStyleBackColor = True
        '
        'folhaDiarioColaborador
        '
        Me.folhaDiarioColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.folhaDiarioColaborador.FormattingEnabled = True
        Me.folhaDiarioColaborador.Location = New System.Drawing.Point(93, 24)
        Me.folhaDiarioColaborador.Name = "folhaDiarioColaborador"
        Me.folhaDiarioColaborador.Size = New System.Drawing.Size(369, 21)
        Me.folhaDiarioColaborador.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Colaborador:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Sienna
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Aqua
        Me.Label21.Location = New System.Drawing.Point(16, 191)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Duração"
        '
        'lblChave
        '
        Me.lblChave.AutoSize = True
        Me.lblChave.BackColor = System.Drawing.Color.Red
        Me.lblChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChave.Location = New System.Drawing.Point(83, 29)
        Me.lblChave.Name = "lblChave"
        Me.lblChave.Size = New System.Drawing.Size(43, 13)
        Me.lblChave.TabIndex = 18
        Me.lblChave.Text = "Chave"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Sienna
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Aqua
        Me.Label23.Location = New System.Drawing.Point(16, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Chave"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.BackColor = System.Drawing.Color.Red
        Me.lblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCargo.Location = New System.Drawing.Point(217, 29)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(40, 13)
        Me.lblCargo.TabIndex = 20
        Me.lblCargo.Text = "Cargo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Aqua
        Me.Label24.Location = New System.Drawing.Point(167, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Cargo"
        '
        'frmFolhaDiarioRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 502)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnTermina)
        Me.Controls.Add(Me.btnImprime)
        Me.Name = "frmFolhaDiarioRelatorio"
        Me.Text = "frmFolhaDiarioRelatorio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTermina As Button
    Friend WithEvents btnImprime As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents folhaDiarioData As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnImprimePeriodo As Button
    Friend WithEvents mskDataFim As MaskedTextBox
    Friend WithEvents mskDataInicio As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblRG As Label
    Friend WithEvents LblCPF As Label
    Friend WithEvents LblDescanso As Label
    Friend WithEvents LabHorario As Label
    Friend WithEvents LblTurno As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents folhaDiarioColaborador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents lblTurnoDuracao As Label
    Friend WithEvents lblturnoInico As Label
    Friend WithEvents lblTurnoFim As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblChave As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents Label24 As Label
End Class
