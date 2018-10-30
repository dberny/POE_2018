﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GrblGui
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrblGui))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPgInterface = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.XYchart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.UVchart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.gbState = New System.Windows.Forms.GroupBox()
        Me.tbStateTool = New System.Windows.Forms.TextBox()
        Me.cbxStateDistance = New System.Windows.Forms.ComboBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Lalbel49 = New System.Windows.Forms.Label()
        Me.cbxStateSpindle = New System.Windows.Forms.ComboBox()
        Me.cbxStateUnits = New System.Windows.Forms.ComboBox()
        Me.tbStateFeedRate = New System.Windows.Forms.TextBox()
        Me.cbxStatePlane = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbxStateFeedMode = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.tbStateSpindleRPM = New System.Windows.Forms.TextBox()
        Me.cbxStateCoolant = New System.Windows.Forms.ComboBox()
        Me.cbxStateOffset = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPositionCurrentOffset = New System.Windows.Forms.Label()
        Me.gbDistance = New System.Windows.Forms.GroupBox()
        Me.rbDistance1 = New System.Windows.Forms.RadioButton()
        Me.rbDistance2 = New System.Windows.Forms.RadioButton()
        Me.rbDistance3 = New System.Windows.Forms.RadioButton()
        Me.rbDistance4 = New System.Windows.Forms.RadioButton()
        Me.gbFeedRate = New System.Windows.Forms.GroupBox()
        Me.rbFeedRate1 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate2 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate3 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate4 = New System.Windows.Forms.RadioButton()
        Me.cbUnits = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.inputvoltagetb = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.hotwirelabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.spindlescroll = New System.Windows.Forms.HScrollBar()
        Me.spindleONbtn = New System.Windows.Forms.Button()
        Me.spindleOFFbtn = New System.Windows.Forms.Button()
        Me.gbJogging = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnHomeUZ = New System.Windows.Forms.Button()
        Me.btnWork1 = New System.Windows.Forms.Button()
        Me.btnZMinus = New RepeatButton.RepeatButton()
        Me.btnZPlus = New RepeatButton.RepeatButton()
        Me.btnUMinus = New RepeatButton.RepeatButton()
        Me.btnUPlus = New RepeatButton.RepeatButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnHomeAll = New System.Windows.Forms.Button()
        Me.btnUP = New RepeatButton.RepeatButton()
        Me.btnWorkXYZ0 = New System.Windows.Forms.Button()
        Me.btnFORWARD = New RepeatButton.RepeatButton()
        Me.btnDOWN = New RepeatButton.RepeatButton()
        Me.btnBACK = New RepeatButton.RepeatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHomeXY = New System.Windows.Forms.Button()
        Me.btnXPlus = New RepeatButton.RepeatButton()
        Me.btnXMinus = New RepeatButton.RepeatButton()
        Me.btnWork0 = New System.Windows.Forms.Button()
        Me.btnYMinus = New RepeatButton.RepeatButton()
        Me.btnYPlus = New RepeatButton.RepeatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbGCodeMessage = New System.Windows.Forms.TextBox()
        Me.tbMachX = New System.Windows.Forms.TextBox()
        Me.tbWorkX = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnWorkU0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWorkX0 = New System.Windows.Forms.Button()
        Me.btnWorkZ0 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWorkY0 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbWorkU = New System.Windows.Forms.TextBox()
        Me.tbMachU = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbWorkZ = New System.Windows.Forms.TextBox()
        Me.tbMachZ = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbWorkY = New System.Windows.Forms.TextBox()
        Me.tbMachY = New System.Windows.Forms.TextBox()
        Me.gbMDI = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbSendData = New System.Windows.Forms.TextBox()
        Me.gbControl = New System.Windows.Forms.GroupBox()
        Me.btnCheckMode = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnStartResume = New System.Windows.Forms.Button()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbCurrentStatus = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.prgbRxBuf = New System.Windows.Forms.ProgressBar()
        Me.prgBarQ = New System.Windows.Forms.ProgressBar()
        Me.cbVerbose = New System.Windows.Forms.CheckBox()
        Me.lbResponses = New System.Windows.Forms.ListBox()
        Me.gbGcode = New System.Windows.Forms.GroupBox()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.btnFileStep = New System.Windows.Forms.Button()
        Me.cbMonitorEnable = New System.Windows.Forms.CheckBox()
        Me.state1 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lblCurrentLine = New System.Windows.Forms.Label()
        Me.dgvGcode = New System.Windows.Forms.DataGridView()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFileReload = New System.Windows.Forms.Button()
        Me.lblTotalLines = New System.Windows.Forms.Label()
        Me.btnFilePause = New System.Windows.Forms.Button()
        Me.tbGcodeFile = New System.Windows.Forms.TextBox()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.btnFileSend = New System.Windows.Forms.Button()
        Me.btnFileStop = New System.Windows.Forms.Button()
        Me.gbGrbl = New System.Windows.Forms.GroupBox()
        Me.tcConnection = New System.Windows.Forms.TabControl()
        Me.tbGrblCOM = New System.Windows.Forms.TabPage()
        Me.btnRescanPorts = New System.Windows.Forms.Button()
        Me.cbPorts = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cbBaud = New System.Windows.Forms.ComboBox()
        Me.tbGrblIP = New System.Windows.Forms.TabPage()
        Me.btnIPConnect = New System.Windows.Forms.Button()
        Me.tbIPAddress = New System.Windows.Forms.TextBox()
        Me.tabPgSettings = New System.Windows.Forms.TabPage()
        Me.gbMiscInfo = New System.Windows.Forms.GroupBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.tbGrblOptions = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.tbGrblVersion = New System.Windows.Forms.TextBox()
        Me.gbGrblSettings = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSettingsGrblLastParam = New System.Windows.Forms.TextBox()
        Me.dgGrblSettings = New System.Windows.Forms.DataGridView()
        Me.btnSettingsGrbl = New System.Windows.Forms.Button()
        Me.gbSettingsOffsets = New System.Windows.Forms.GroupBox()
        Me.btnOffsetsG28Set = New System.Windows.Forms.Button()
        Me.btnSettingsRetrieveLocations = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbOffsetsG30Y = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG30X = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG30Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG28X = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG30Set = New System.Windows.Forms.Button()
        Me.tbOffsetsG28Y = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.tbOffsetsG28Z = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.gbSettingsMisc = New System.Windows.Forms.GroupBox()
        Me.tbSettingsDefaultExt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSettingsStartupDelay = New System.Windows.Forms.TextBox()
        Me.cbSettingsLeftHanded = New System.Windows.Forms.CheckBox()
        Me.cbSettingsConnectOnLoad = New System.Windows.Forms.CheckBox()
        Me.cbSettingsPauseOnError = New System.Windows.Forms.CheckBox()
        Me.cbStatusPollEnable = New System.Windows.Forms.CheckBox()
        Me.btnSettingsRefreshMisc = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbSettingsRBuffSize = New System.Windows.Forms.TextBox()
        Me.tbSettingsQSize = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbSettingsPollRate = New System.Windows.Forms.TextBox()
        Me.gbSettingsPosition = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbSettingsSpclPosition3 = New System.Windows.Forms.TextBox()
        Me.tbWorkU0Cmd = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbSettingsSpclPosition2 = New System.Windows.Forms.TextBox()
        Me.btnSettingsRefreshPosition = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbWorkZ0Cmd = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbWorkY0Cmd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbWorkX0Cmd = New System.Windows.Forms.TextBox()
        Me.tbSettingsZeroXYZCmd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbSettingsSpclPosition1 = New System.Windows.Forms.TextBox()
        Me.gbSettingsJogging = New System.Windows.Forms.GroupBox()
        Me.cbSettingsKeyboardJogging = New System.Windows.Forms.CheckBox()
        Me.btnSettingsRefreshJogging = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.tbSettingsZRepeat = New System.Windows.Forms.TextBox()
        Me.tbSettingsYRepeat = New System.Windows.Forms.TextBox()
        Me.tbSettingsXRepeat = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbSettingsFRMetric = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbSettingsFIMetric = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbSettingsFRImperial = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbSettingsMetric = New System.Windows.Forms.CheckBox()
        Me.tbSettingsFIImperial = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbEditor = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblGCode = New System.Windows.Forms.Label()
        Me.tbGCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dgMacros = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.btnDeleteMacro = New System.Windows.Forms.Button()
        Me.ofdGcodeFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfdOffsets = New System.Windows.Forms.SaveFileDialog()
        Me.ofdOffsets = New System.Windows.Forms.OpenFileDialog()
        Me.GrblSettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPgInterface.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.XYchart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.UVchart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbState.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDistance.SuspendLayout()
        Me.gbFeedRate.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbJogging.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbMDI.SuspendLayout()
        Me.gbControl.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        Me.gbGcode.SuspendLayout()
        CType(Me.dgvGcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrbl.SuspendLayout()
        Me.tcConnection.SuspendLayout()
        Me.tbGrblCOM.SuspendLayout()
        Me.tbGrblIP.SuspendLayout()
        Me.tabPgSettings.SuspendLayout()
        Me.gbMiscInfo.SuspendLayout()
        Me.gbGrblSettings.SuspendLayout()
        CType(Me.dgGrblSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettingsOffsets.SuspendLayout()
        Me.gbSettingsMisc.SuspendLayout()
        Me.gbSettingsPosition.SuspendLayout()
        Me.gbSettingsJogging.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbEditor.SuspendLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrblSettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.tabPgInterface)
        Me.TabControl1.Controls.Add(Me.tabPgSettings)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        '
        'tabPgInterface
        '
        Me.tabPgInterface.Controls.Add(Me.SplitContainer1)
        Me.tabPgInterface.Controls.Add(Me.gbState)
        Me.tabPgInterface.Controls.Add(Me.GroupBox2)
        Me.tabPgInterface.Controls.Add(Me.GroupBox4)
        Me.tabPgInterface.Controls.Add(Me.gbJogging)
        Me.tabPgInterface.Controls.Add(Me.gbMDI)
        Me.tabPgInterface.Controls.Add(Me.gbControl)
        Me.tabPgInterface.Controls.Add(Me.gbStatus)
        Me.tabPgInterface.Controls.Add(Me.gbGcode)
        Me.tabPgInterface.Controls.Add(Me.gbGrbl)
        resources.ApplyResources(Me.tabPgInterface, "tabPgInterface")
        Me.tabPgInterface.Name = "tabPgInterface"
        Me.tabPgInterface.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox8)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.XYchart)
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'XYchart
        '
        ChartArea1.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 100.0!
        ChartArea1.Position.Width = 100.0!
        Me.XYchart.ChartAreas.Add(ChartArea1)
        resources.ApplyResources(Me.XYchart, "XYchart")
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.XYchart.Legends.Add(Legend1)
        Me.XYchart.Name = "XYchart"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.Navy
        Series1.Legend = "Legend1"
        Series1.Name = "Series2"
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.Red
        Series2.CustomProperties = "IsXAxisQuantitative=True"
        Series2.IsVisibleInLegend = False
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.XYchart.Series.Add(Series1)
        Me.XYchart.Series.Add(Series2)
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.UVchart)
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'UVchart
        '
        ChartArea2.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.Name = "ChartArea1"
        ChartArea2.Position.Auto = False
        ChartArea2.Position.Height = 100.0!
        ChartArea2.Position.Width = 100.0!
        Me.UVchart.ChartAreas.Add(ChartArea2)
        resources.ApplyResources(Me.UVchart, "UVchart")
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.UVchart.Legends.Add(Legend2)
        Me.UVchart.Name = "UVchart"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series3.Color = System.Drawing.Color.Navy
        Series3.Legend = "Legend1"
        Series3.Name = "Series2"
        Series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series4.Color = System.Drawing.Color.Red
        Series4.CustomProperties = "IsXAxisQuantitative=True"
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.UVchart.Series.Add(Series3)
        Me.UVchart.Series.Add(Series4)
        '
        'gbState
        '
        Me.gbState.Controls.Add(Me.tbStateTool)
        Me.gbState.Controls.Add(Me.cbxStateDistance)
        Me.gbState.Controls.Add(Me.Label123)
        Me.gbState.Controls.Add(Me.Label53)
        Me.gbState.Controls.Add(Me.Lalbel49)
        Me.gbState.Controls.Add(Me.cbxStateSpindle)
        Me.gbState.Controls.Add(Me.cbxStateUnits)
        Me.gbState.Controls.Add(Me.tbStateFeedRate)
        Me.gbState.Controls.Add(Me.cbxStatePlane)
        Me.gbState.Controls.Add(Me.Label17)
        Me.gbState.Controls.Add(Me.Label16)
        Me.gbState.Controls.Add(Me.cbxStateFeedMode)
        Me.gbState.Controls.Add(Me.Label47)
        Me.gbState.Controls.Add(Me.Label45)
        Me.gbState.Controls.Add(Me.Label15)
        Me.gbState.Controls.Add(Me.Label50)
        Me.gbState.Controls.Add(Me.tbStateSpindleRPM)
        Me.gbState.Controls.Add(Me.cbxStateCoolant)
        Me.gbState.Controls.Add(Me.cbxStateOffset)
        Me.gbState.Controls.Add(Me.Label14)
        resources.ApplyResources(Me.gbState, "gbState")
        Me.gbState.Name = "gbState"
        Me.gbState.TabStop = False
        '
        'tbStateTool
        '
        resources.ApplyResources(Me.tbStateTool, "tbStateTool")
        Me.tbStateTool.Name = "tbStateTool"
        '
        'cbxStateDistance
        '
        Me.cbxStateDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateDistance.FormattingEnabled = True
        Me.cbxStateDistance.Items.AddRange(New Object() {resources.GetString("cbxStateDistance.Items"), resources.GetString("cbxStateDistance.Items1"), resources.GetString("cbxStateDistance.Items2")})
        resources.ApplyResources(Me.cbxStateDistance, "cbxStateDistance")
        Me.cbxStateDistance.Name = "cbxStateDistance"
        '
        'Label123
        '
        resources.ApplyResources(Me.Label123, "Label123")
        Me.Label123.Name = "Label123"
        '
        'Label53
        '
        resources.ApplyResources(Me.Label53, "Label53")
        Me.Label53.Name = "Label53"
        '
        'Lalbel49
        '
        resources.ApplyResources(Me.Lalbel49, "Lalbel49")
        Me.Lalbel49.Name = "Lalbel49"
        '
        'cbxStateSpindle
        '
        Me.cbxStateSpindle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateSpindle.FormattingEnabled = True
        Me.cbxStateSpindle.Items.AddRange(New Object() {resources.GetString("cbxStateSpindle.Items"), resources.GetString("cbxStateSpindle.Items1"), resources.GetString("cbxStateSpindle.Items2")})
        resources.ApplyResources(Me.cbxStateSpindle, "cbxStateSpindle")
        Me.cbxStateSpindle.Name = "cbxStateSpindle"
        '
        'cbxStateUnits
        '
        Me.cbxStateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateUnits.FormattingEnabled = True
        Me.cbxStateUnits.Items.AddRange(New Object() {resources.GetString("cbxStateUnits.Items"), resources.GetString("cbxStateUnits.Items1"), resources.GetString("cbxStateUnits.Items2")})
        resources.ApplyResources(Me.cbxStateUnits, "cbxStateUnits")
        Me.cbxStateUnits.Name = "cbxStateUnits"
        '
        'tbStateFeedRate
        '
        resources.ApplyResources(Me.tbStateFeedRate, "tbStateFeedRate")
        Me.tbStateFeedRate.Name = "tbStateFeedRate"
        '
        'cbxStatePlane
        '
        Me.cbxStatePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatePlane.FormattingEnabled = True
        Me.cbxStatePlane.Items.AddRange(New Object() {resources.GetString("cbxStatePlane.Items"), resources.GetString("cbxStatePlane.Items1"), resources.GetString("cbxStatePlane.Items2"), resources.GetString("cbxStatePlane.Items3")})
        resources.ApplyResources(Me.cbxStatePlane, "cbxStatePlane")
        Me.cbxStatePlane.Name = "cbxStatePlane"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'cbxStateFeedMode
        '
        Me.cbxStateFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateFeedMode.FormattingEnabled = True
        Me.cbxStateFeedMode.Items.AddRange(New Object() {resources.GetString("cbxStateFeedMode.Items"), resources.GetString("cbxStateFeedMode.Items1"), resources.GetString("cbxStateFeedMode.Items2")})
        resources.ApplyResources(Me.cbxStateFeedMode, "cbxStateFeedMode")
        Me.cbxStateFeedMode.Name = "cbxStateFeedMode"
        '
        'Label47
        '
        resources.ApplyResources(Me.Label47, "Label47")
        Me.Label47.Name = "Label47"
        '
        'Label45
        '
        resources.ApplyResources(Me.Label45, "Label45")
        Me.Label45.Name = "Label45"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label50
        '
        resources.ApplyResources(Me.Label50, "Label50")
        Me.Label50.Name = "Label50"
        '
        'tbStateSpindleRPM
        '
        resources.ApplyResources(Me.tbStateSpindleRPM, "tbStateSpindleRPM")
        Me.tbStateSpindleRPM.Name = "tbStateSpindleRPM"
        '
        'cbxStateCoolant
        '
        Me.cbxStateCoolant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateCoolant.FormattingEnabled = True
        Me.cbxStateCoolant.Items.AddRange(New Object() {resources.GetString("cbxStateCoolant.Items"), resources.GetString("cbxStateCoolant.Items1"), resources.GetString("cbxStateCoolant.Items2")})
        resources.ApplyResources(Me.cbxStateCoolant, "cbxStateCoolant")
        Me.cbxStateCoolant.Name = "cbxStateCoolant"
        '
        'cbxStateOffset
        '
        Me.cbxStateOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateOffset.FormattingEnabled = True
        Me.cbxStateOffset.Items.AddRange(New Object() {resources.GetString("cbxStateOffset.Items"), resources.GetString("cbxStateOffset.Items1"), resources.GetString("cbxStateOffset.Items2"), resources.GetString("cbxStateOffset.Items3"), resources.GetString("cbxStateOffset.Items4"), resources.GetString("cbxStateOffset.Items5"), resources.GetString("cbxStateOffset.Items6")})
        resources.ApplyResources(Me.cbxStateOffset, "cbxStateOffset")
        Me.cbxStateOffset.Name = "cbxStateOffset"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.gbDistance)
        Me.GroupBox2.Controls.Add(Me.gbFeedRate)
        Me.GroupBox2.Controls.Add(Me.cbUnits)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPositionCurrentOffset)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblPositionCurrentOffset
        '
        resources.ApplyResources(Me.lblPositionCurrentOffset, "lblPositionCurrentOffset")
        Me.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset"
        '
        'gbDistance
        '
        Me.gbDistance.Controls.Add(Me.rbDistance1)
        Me.gbDistance.Controls.Add(Me.rbDistance2)
        Me.gbDistance.Controls.Add(Me.rbDistance3)
        Me.gbDistance.Controls.Add(Me.rbDistance4)
        resources.ApplyResources(Me.gbDistance, "gbDistance")
        Me.gbDistance.Name = "gbDistance"
        Me.gbDistance.TabStop = False
        '
        'rbDistance1
        '
        resources.ApplyResources(Me.rbDistance1, "rbDistance1")
        Me.rbDistance1.Name = "rbDistance1"
        Me.rbDistance1.TabStop = True
        Me.rbDistance1.Tag = "I1"
        Me.rbDistance1.UseVisualStyleBackColor = True
        '
        'rbDistance2
        '
        resources.ApplyResources(Me.rbDistance2, "rbDistance2")
        Me.rbDistance2.Name = "rbDistance2"
        Me.rbDistance2.TabStop = True
        Me.rbDistance2.Tag = "I2"
        Me.rbDistance2.UseVisualStyleBackColor = True
        '
        'rbDistance3
        '
        resources.ApplyResources(Me.rbDistance3, "rbDistance3")
        Me.rbDistance3.Name = "rbDistance3"
        Me.rbDistance3.TabStop = True
        Me.rbDistance3.Tag = "I3"
        Me.rbDistance3.UseVisualStyleBackColor = True
        '
        'rbDistance4
        '
        resources.ApplyResources(Me.rbDistance4, "rbDistance4")
        Me.rbDistance4.Name = "rbDistance4"
        Me.rbDistance4.TabStop = True
        Me.rbDistance4.Tag = "I4"
        Me.rbDistance4.UseVisualStyleBackColor = True
        '
        'gbFeedRate
        '
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate1)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate2)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate3)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate4)
        resources.ApplyResources(Me.gbFeedRate, "gbFeedRate")
        Me.gbFeedRate.Name = "gbFeedRate"
        Me.gbFeedRate.TabStop = False
        '
        'rbFeedRate1
        '
        resources.ApplyResources(Me.rbFeedRate1, "rbFeedRate1")
        Me.rbFeedRate1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbFeedRate1.Name = "rbFeedRate1"
        Me.rbFeedRate1.TabStop = True
        Me.rbFeedRate1.Tag = "F1"
        Me.rbFeedRate1.UseVisualStyleBackColor = True
        '
        'rbFeedRate2
        '
        resources.ApplyResources(Me.rbFeedRate2, "rbFeedRate2")
        Me.rbFeedRate2.Name = "rbFeedRate2"
        Me.rbFeedRate2.TabStop = True
        Me.rbFeedRate2.Tag = "F2"
        Me.rbFeedRate2.UseVisualStyleBackColor = True
        '
        'rbFeedRate3
        '
        resources.ApplyResources(Me.rbFeedRate3, "rbFeedRate3")
        Me.rbFeedRate3.Name = "rbFeedRate3"
        Me.rbFeedRate3.TabStop = True
        Me.rbFeedRate3.Tag = "F3"
        Me.rbFeedRate3.UseVisualStyleBackColor = True
        '
        'rbFeedRate4
        '
        resources.ApplyResources(Me.rbFeedRate4, "rbFeedRate4")
        Me.rbFeedRate4.Name = "rbFeedRate4"
        Me.rbFeedRate4.TabStop = True
        Me.rbFeedRate4.Tag = "F4"
        Me.rbFeedRate4.UseVisualStyleBackColor = True
        '
        'cbUnits
        '
        resources.ApplyResources(Me.cbUnits, "cbUnits")
        Me.cbUnits.Name = "cbUnits"
        Me.cbUnits.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.inputvoltagetb)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.hotwirelabel)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.spindlescroll)
        Me.GroupBox4.Controls.Add(Me.spindleONbtn)
        Me.GroupBox4.Controls.Add(Me.spindleOFFbtn)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'inputvoltagetb
        '
        resources.ApplyResources(Me.inputvoltagetb, "inputvoltagetb")
        Me.inputvoltagetb.Name = "inputvoltagetb"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'hotwirelabel
        '
        resources.ApplyResources(Me.hotwirelabel, "hotwirelabel")
        Me.hotwirelabel.Name = "hotwirelabel"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'spindlescroll
        '
        resources.ApplyResources(Me.spindlescroll, "spindlescroll")
        Me.spindlescroll.LargeChange = 100
        Me.spindlescroll.Maximum = 12009
        Me.spindlescroll.Name = "spindlescroll"
        Me.spindlescroll.SmallChange = 100
        '
        'spindleONbtn
        '
        resources.ApplyResources(Me.spindleONbtn, "spindleONbtn")
        Me.spindleONbtn.Name = "spindleONbtn"
        Me.spindleONbtn.Tag = "ON"
        Me.spindleONbtn.UseVisualStyleBackColor = True
        '
        'spindleOFFbtn
        '
        resources.ApplyResources(Me.spindleOFFbtn, "spindleOFFbtn")
        Me.spindleOFFbtn.Name = "spindleOFFbtn"
        Me.spindleOFFbtn.Tag = "OFF"
        Me.spindleOFFbtn.UseVisualStyleBackColor = True
        '
        'gbJogging
        '
        Me.gbJogging.Controls.Add(Me.GroupBox6)
        Me.gbJogging.Controls.Add(Me.GroupBox5)
        Me.gbJogging.Controls.Add(Me.GroupBox3)
        Me.gbJogging.Controls.Add(Me.Panel3)
        Me.gbJogging.Controls.Add(Me.Label19)
        Me.gbJogging.Controls.Add(Me.btnWorkU0)
        Me.gbJogging.Controls.Add(Me.Label1)
        Me.gbJogging.Controls.Add(Me.btnWorkX0)
        Me.gbJogging.Controls.Add(Me.btnWorkZ0)
        Me.gbJogging.Controls.Add(Me.Label3)
        Me.gbJogging.Controls.Add(Me.btnWorkY0)
        Me.gbJogging.Controls.Add(Me.Label2)
        Me.gbJogging.Controls.Add(Me.Panel1)
        Me.gbJogging.Controls.Add(Me.Panel5)
        Me.gbJogging.Controls.Add(Me.Panel4)
        resources.ApplyResources(Me.gbJogging, "gbJogging")
        Me.gbJogging.Name = "gbJogging"
        Me.gbJogging.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnHomeUZ)
        Me.GroupBox6.Controls.Add(Me.btnWork1)
        Me.GroupBox6.Controls.Add(Me.btnZMinus)
        Me.GroupBox6.Controls.Add(Me.btnZPlus)
        Me.GroupBox6.Controls.Add(Me.btnUMinus)
        Me.GroupBox6.Controls.Add(Me.btnUPlus)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'btnHomeUZ
        '
        resources.ApplyResources(Me.btnHomeUZ, "btnHomeUZ")
        Me.btnHomeUZ.Name = "btnHomeUZ"
        Me.btnHomeUZ.Tag = "HomeUZ"
        Me.ToolTip1.SetToolTip(Me.btnHomeUZ, resources.GetString("btnHomeUZ.ToolTip"))
        Me.btnHomeUZ.UseVisualStyleBackColor = True
        '
        'btnWork1
        '
        resources.ApplyResources(Me.btnWork1, "btnWork1")
        Me.btnWork1.Name = "btnWork1"
        Me.btnWork1.Tag = "ZeroUZ"
        Me.ToolTip1.SetToolTip(Me.btnWork1, resources.GetString("btnWork1.ToolTip"))
        Me.btnWork1.UseVisualStyleBackColor = True
        '
        'btnZMinus
        '
        resources.ApplyResources(Me.btnZMinus, "btnZMinus")
        Me.btnZMinus.Interval = 100
        Me.btnZMinus.Name = "btnZMinus"
        Me.btnZMinus.Tag = "Z-"
        Me.btnZMinus.UseVisualStyleBackColor = True
        '
        'btnZPlus
        '
        resources.ApplyResources(Me.btnZPlus, "btnZPlus")
        Me.btnZPlus.Interval = 100
        Me.btnZPlus.Name = "btnZPlus"
        Me.btnZPlus.Tag = "Z+"
        Me.btnZPlus.UseVisualStyleBackColor = True
        '
        'btnUMinus
        '
        resources.ApplyResources(Me.btnUMinus, "btnUMinus")
        Me.btnUMinus.Interval = 100
        Me.btnUMinus.Name = "btnUMinus"
        Me.btnUMinus.Tag = "U-"
        Me.btnUMinus.UseVisualStyleBackColor = True
        '
        'btnUPlus
        '
        resources.ApplyResources(Me.btnUPlus, "btnUPlus")
        Me.btnUPlus.Interval = 100
        Me.btnUPlus.Name = "btnUPlus"
        Me.btnUPlus.Tag = "U+"
        Me.btnUPlus.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnHomeAll)
        Me.GroupBox5.Controls.Add(Me.btnUP)
        Me.GroupBox5.Controls.Add(Me.btnWorkXYZ0)
        Me.GroupBox5.Controls.Add(Me.btnFORWARD)
        Me.GroupBox5.Controls.Add(Me.btnDOWN)
        Me.GroupBox5.Controls.Add(Me.btnBACK)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'btnHomeAll
        '
        resources.ApplyResources(Me.btnHomeAll, "btnHomeAll")
        Me.btnHomeAll.Name = "btnHomeAll"
        Me.btnHomeAll.Tag = "HomeAll"
        Me.ToolTip1.SetToolTip(Me.btnHomeAll, resources.GetString("btnHomeAll.ToolTip"))
        Me.btnHomeAll.UseVisualStyleBackColor = True
        '
        'btnUP
        '
        resources.ApplyResources(Me.btnUP, "btnUP")
        Me.btnUP.Interval = 100
        Me.btnUP.Name = "btnUP"
        Me.btnUP.Tag = "UP"
        Me.btnUP.UseVisualStyleBackColor = True
        '
        'btnWorkXYZ0
        '
        resources.ApplyResources(Me.btnWorkXYZ0, "btnWorkXYZ0")
        Me.btnWorkXYZ0.Name = "btnWorkXYZ0"
        Me.btnWorkXYZ0.Tag = "ZeroAll"
        Me.ToolTip1.SetToolTip(Me.btnWorkXYZ0, resources.GetString("btnWorkXYZ0.ToolTip"))
        Me.btnWorkXYZ0.UseVisualStyleBackColor = True
        '
        'btnFORWARD
        '
        resources.ApplyResources(Me.btnFORWARD, "btnFORWARD")
        Me.btnFORWARD.Interval = 100
        Me.btnFORWARD.Name = "btnFORWARD"
        Me.btnFORWARD.Tag = "FORWARD"
        Me.btnFORWARD.UseVisualStyleBackColor = True
        '
        'btnDOWN
        '
        resources.ApplyResources(Me.btnDOWN, "btnDOWN")
        Me.btnDOWN.Interval = 100
        Me.btnDOWN.Name = "btnDOWN"
        Me.btnDOWN.Tag = "DOWN"
        Me.btnDOWN.UseVisualStyleBackColor = True
        '
        'btnBACK
        '
        resources.ApplyResources(Me.btnBACK, "btnBACK")
        Me.btnBACK.Interval = 100
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Tag = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHomeXY)
        Me.GroupBox3.Controls.Add(Me.btnXPlus)
        Me.GroupBox3.Controls.Add(Me.btnXMinus)
        Me.GroupBox3.Controls.Add(Me.btnWork0)
        Me.GroupBox3.Controls.Add(Me.btnYMinus)
        Me.GroupBox3.Controls.Add(Me.btnYPlus)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'btnHomeXY
        '
        resources.ApplyResources(Me.btnHomeXY, "btnHomeXY")
        Me.btnHomeXY.Name = "btnHomeXY"
        Me.btnHomeXY.Tag = "HomeXY"
        Me.ToolTip1.SetToolTip(Me.btnHomeXY, resources.GetString("btnHomeXY.ToolTip"))
        Me.btnHomeXY.UseVisualStyleBackColor = True
        '
        'btnXPlus
        '
        resources.ApplyResources(Me.btnXPlus, "btnXPlus")
        Me.btnXPlus.Interval = 100
        Me.btnXPlus.Name = "btnXPlus"
        Me.btnXPlus.Tag = "X+"
        Me.btnXPlus.UseVisualStyleBackColor = True
        '
        'btnXMinus
        '
        resources.ApplyResources(Me.btnXMinus, "btnXMinus")
        Me.btnXMinus.Interval = 100
        Me.btnXMinus.Name = "btnXMinus"
        Me.btnXMinus.Tag = "X-"
        Me.btnXMinus.UseVisualStyleBackColor = True
        '
        'btnWork0
        '
        resources.ApplyResources(Me.btnWork0, "btnWork0")
        Me.btnWork0.Name = "btnWork0"
        Me.btnWork0.Tag = "ZeroXY"
        Me.ToolTip1.SetToolTip(Me.btnWork0, resources.GetString("btnWork0.ToolTip"))
        Me.btnWork0.UseVisualStyleBackColor = True
        '
        'btnYMinus
        '
        resources.ApplyResources(Me.btnYMinus, "btnYMinus")
        Me.btnYMinus.Interval = 100
        Me.btnYMinus.Name = "btnYMinus"
        Me.btnYMinus.Tag = "Y-"
        Me.btnYMinus.UseVisualStyleBackColor = True
        '
        'btnYPlus
        '
        resources.ApplyResources(Me.btnYPlus, "btnYPlus")
        Me.btnYPlus.Interval = 100
        Me.btnYPlus.Name = "btnYPlus"
        Me.btnYPlus.Tag = "Y+"
        Me.btnYPlus.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbGCodeMessage)
        Me.Panel3.Controls.Add(Me.tbMachX)
        Me.Panel3.Controls.Add(Me.tbWorkX)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'tbGCodeMessage
        '
        Me.tbGCodeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbGCodeMessage, "tbGCodeMessage")
        Me.tbGCodeMessage.Name = "tbGCodeMessage"
        '
        'tbMachX
        '
        Me.tbMachX.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachX, "tbMachX")
        Me.tbMachX.Name = "tbMachX"
        Me.ToolTip1.SetToolTip(Me.tbMachX, resources.GetString("tbMachX.ToolTip"))
        '
        'tbWorkX
        '
        Me.tbWorkX.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkX, "tbWorkX")
        Me.tbWorkX.Name = "tbWorkX"
        Me.ToolTip1.SetToolTip(Me.tbWorkX, resources.GetString("tbWorkX.ToolTip"))
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'btnWorkU0
        '
        resources.ApplyResources(Me.btnWorkU0, "btnWorkU0")
        Me.btnWorkU0.Name = "btnWorkU0"
        Me.btnWorkU0.Tag = "U"
        Me.ToolTip1.SetToolTip(Me.btnWorkU0, resources.GetString("btnWorkU0.ToolTip"))
        Me.btnWorkU0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnWorkX0
        '
        resources.ApplyResources(Me.btnWorkX0, "btnWorkX0")
        Me.btnWorkX0.Name = "btnWorkX0"
        Me.btnWorkX0.Tag = "X"
        Me.ToolTip1.SetToolTip(Me.btnWorkX0, resources.GetString("btnWorkX0.ToolTip"))
        Me.btnWorkX0.UseVisualStyleBackColor = True
        '
        'btnWorkZ0
        '
        resources.ApplyResources(Me.btnWorkZ0, "btnWorkZ0")
        Me.btnWorkZ0.Name = "btnWorkZ0"
        Me.btnWorkZ0.Tag = "Z"
        Me.ToolTip1.SetToolTip(Me.btnWorkZ0, resources.GetString("btnWorkZ0.ToolTip"))
        Me.btnWorkZ0.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnWorkY0
        '
        resources.ApplyResources(Me.btnWorkY0, "btnWorkY0")
        Me.btnWorkY0.Name = "btnWorkY0"
        Me.btnWorkY0.Tag = "Y"
        Me.ToolTip1.SetToolTip(Me.btnWorkY0, resources.GetString("btnWorkY0.ToolTip"))
        Me.btnWorkY0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbWorkU)
        Me.Panel1.Controls.Add(Me.tbMachU)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'tbWorkU
        '
        Me.tbWorkU.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkU, "tbWorkU")
        Me.tbWorkU.Name = "tbWorkU"
        Me.ToolTip1.SetToolTip(Me.tbWorkU, resources.GetString("tbWorkU.ToolTip"))
        '
        'tbMachU
        '
        Me.tbMachU.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachU, "tbMachU")
        Me.tbMachU.Name = "tbMachU"
        Me.ToolTip1.SetToolTip(Me.tbMachU, resources.GetString("tbMachU.ToolTip"))
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tbWorkZ)
        Me.Panel5.Controls.Add(Me.tbMachZ)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'tbWorkZ
        '
        Me.tbWorkZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkZ, "tbWorkZ")
        Me.tbWorkZ.Name = "tbWorkZ"
        Me.ToolTip1.SetToolTip(Me.tbWorkZ, resources.GetString("tbWorkZ.ToolTip"))
        '
        'tbMachZ
        '
        Me.tbMachZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachZ, "tbMachZ")
        Me.tbMachZ.Name = "tbMachZ"
        Me.ToolTip1.SetToolTip(Me.tbMachZ, resources.GetString("tbMachZ.ToolTip"))
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.tbWorkY)
        Me.Panel4.Controls.Add(Me.tbMachY)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'tbWorkY
        '
        Me.tbWorkY.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkY, "tbWorkY")
        Me.tbWorkY.Name = "tbWorkY"
        Me.ToolTip1.SetToolTip(Me.tbWorkY, resources.GetString("tbWorkY.ToolTip"))
        '
        'tbMachY
        '
        Me.tbMachY.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachY, "tbMachY")
        Me.tbMachY.Name = "tbMachY"
        Me.ToolTip1.SetToolTip(Me.tbMachY, resources.GetString("tbMachY.ToolTip"))
        '
        'gbMDI
        '
        Me.gbMDI.Controls.Add(Me.Label9)
        Me.gbMDI.Controls.Add(Me.btnSend)
        Me.gbMDI.Controls.Add(Me.tbSendData)
        resources.ApplyResources(Me.gbMDI, "gbMDI")
        Me.gbMDI.Name = "gbMDI"
        Me.gbMDI.TabStop = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'btnSend
        '
        resources.ApplyResources(Me.btnSend, "btnSend")
        Me.btnSend.Name = "btnSend"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbSendData
        '
        Me.tbSendData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.tbSendData, "tbSendData")
        Me.tbSendData.Name = "tbSendData"
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.btnCheckMode)
        Me.gbControl.Controls.Add(Me.btnReset)
        Me.gbControl.Controls.Add(Me.btnHold)
        Me.gbControl.Controls.Add(Me.btnStartResume)
        Me.gbControl.Controls.Add(Me.btnUnlock)
        resources.ApplyResources(Me.gbControl, "gbControl")
        Me.gbControl.Name = "gbControl"
        Me.gbControl.TabStop = False
        '
        'btnCheckMode
        '
        resources.ApplyResources(Me.btnCheckMode, "btnCheckMode")
        Me.btnCheckMode.Name = "btnCheckMode"
        Me.btnCheckMode.UseCompatibleTextRendering = True
        Me.btnCheckMode.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseCompatibleTextRendering = True
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnHold
        '
        resources.ApplyResources(Me.btnHold, "btnHold")
        Me.btnHold.BackColor = System.Drawing.Color.Transparent
        Me.btnHold.Name = "btnHold"
        Me.btnHold.UseCompatibleTextRendering = True
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btnStartResume
        '
        resources.ApplyResources(Me.btnStartResume, "btnStartResume")
        Me.btnStartResume.Name = "btnStartResume"
        Me.btnStartResume.UseCompatibleTextRendering = True
        Me.btnStartResume.UseVisualStyleBackColor = True
        '
        'btnUnlock
        '
        resources.ApplyResources(Me.btnUnlock, "btnUnlock")
        Me.btnUnlock.BackColor = System.Drawing.Color.Transparent
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.UseCompatibleTextRendering = True
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'gbStatus
        '
        Me.gbStatus.Controls.Add(Me.Label25)
        Me.gbStatus.Controls.Add(Me.tbCurrentStatus)
        Me.gbStatus.Controls.Add(Me.Label24)
        Me.gbStatus.Controls.Add(Me.prgbRxBuf)
        Me.gbStatus.Controls.Add(Me.prgBarQ)
        Me.gbStatus.Controls.Add(Me.cbVerbose)
        Me.gbStatus.Controls.Add(Me.lbResponses)
        resources.ApplyResources(Me.gbStatus, "gbStatus")
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.TabStop = False
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'tbCurrentStatus
        '
        resources.ApplyResources(Me.tbCurrentStatus, "tbCurrentStatus")
        Me.tbCurrentStatus.Name = "tbCurrentStatus"
        Me.ToolTip1.SetToolTip(Me.tbCurrentStatus, resources.GetString("tbCurrentStatus.ToolTip"))
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'prgbRxBuf
        '
        resources.ApplyResources(Me.prgbRxBuf, "prgbRxBuf")
        Me.prgbRxBuf.Maximum = 127
        Me.prgbRxBuf.Name = "prgbRxBuf"
        Me.prgbRxBuf.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'prgBarQ
        '
        resources.ApplyResources(Me.prgBarQ, "prgBarQ")
        Me.prgBarQ.Maximum = 25
        Me.prgBarQ.Name = "prgBarQ"
        Me.prgBarQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'cbVerbose
        '
        resources.ApplyResources(Me.cbVerbose, "cbVerbose")
        Me.cbVerbose.Checked = Global.GrblPanel.My.MySettings.Default.StatusVerbose
        Me.cbVerbose.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "statusVerbose", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbVerbose.Name = "cbVerbose"
        Me.cbVerbose.UseVisualStyleBackColor = True
        '
        'lbResponses
        '
        resources.ApplyResources(Me.lbResponses, "lbResponses")
        Me.lbResponses.FormattingEnabled = True
        Me.lbResponses.Name = "lbResponses"
        '
        'gbGcode
        '
        resources.ApplyResources(Me.gbGcode, "gbGcode")
        Me.gbGcode.Controls.Add(Me.lblElapsedTime)
        Me.gbGcode.Controls.Add(Me.btnFileStep)
        Me.gbGcode.Controls.Add(Me.cbMonitorEnable)
        Me.gbGcode.Controls.Add(Me.state1)
        Me.gbGcode.Controls.Add(Me.Label51)
        Me.gbGcode.Controls.Add(Me.lblCurrentLine)
        Me.gbGcode.Controls.Add(Me.dgvGcode)
        Me.gbGcode.Controls.Add(Me.btnFileReload)
        Me.gbGcode.Controls.Add(Me.lblTotalLines)
        Me.gbGcode.Controls.Add(Me.btnFilePause)
        Me.gbGcode.Controls.Add(Me.tbGcodeFile)
        Me.gbGcode.Controls.Add(Me.btnFileSelect)
        Me.gbGcode.Controls.Add(Me.btnFileSend)
        Me.gbGcode.Controls.Add(Me.btnFileStop)
        Me.gbGcode.Name = "gbGcode"
        Me.gbGcode.TabStop = False
        '
        'lblElapsedTime
        '
        resources.ApplyResources(Me.lblElapsedTime, "lblElapsedTime")
        Me.lblElapsedTime.Name = "lblElapsedTime"
        '
        'btnFileStep
        '
        resources.ApplyResources(Me.btnFileStep, "btnFileStep")
        Me.btnFileStep.Name = "btnFileStep"
        Me.btnFileStep.Tag = "Step"
        Me.ToolTip1.SetToolTip(Me.btnFileStep, resources.GetString("btnFileStep.ToolTip"))
        Me.btnFileStep.UseVisualStyleBackColor = True
        '
        'cbMonitorEnable
        '
        resources.ApplyResources(Me.cbMonitorEnable, "cbMonitorEnable")
        Me.cbMonitorEnable.Checked = True
        Me.cbMonitorEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMonitorEnable.Name = "cbMonitorEnable"
        Me.cbMonitorEnable.UseVisualStyleBackColor = True
        '
        'state1
        '
        resources.ApplyResources(Me.state1, "state1")
        Me.state1.Name = "state1"
        '
        'Label51
        '
        resources.ApplyResources(Me.Label51, "Label51")
        Me.Label51.Name = "Label51"
        '
        'lblCurrentLine
        '
        resources.ApplyResources(Me.lblCurrentLine, "lblCurrentLine")
        Me.lblCurrentLine.Name = "lblCurrentLine"
        '
        'dgvGcode
        '
        Me.dgvGcode.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvGcode.AllowUserToAddRows = False
        Me.dgvGcode.AllowUserToDeleteRows = False
        Me.dgvGcode.AllowUserToResizeRows = False
        resources.ApplyResources(Me.dgvGcode, "dgvGcode")
        Me.dgvGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stat, Me.lineNum, Me.data})
        Me.dgvGcode.MultiSelect = False
        Me.dgvGcode.Name = "dgvGcode"
        Me.dgvGcode.ReadOnly = True
        Me.dgvGcode.RowHeadersVisible = False
        Me.dgvGcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGcode.StandardTab = True
        Me.dgvGcode.VirtualMode = True
        '
        'stat
        '
        Me.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.stat.Frozen = True
        resources.ApplyResources(Me.stat, "stat")
        Me.stat.Name = "stat"
        Me.stat.ReadOnly = True
        Me.stat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lineNum
        '
        Me.lineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.lineNum, "lineNum")
        Me.lineNum.Name = "lineNum"
        Me.lineNum.ReadOnly = True
        Me.lineNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'data
        '
        Me.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.data, "data")
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnFileReload
        '
        resources.ApplyResources(Me.btnFileReload, "btnFileReload")
        Me.btnFileReload.Name = "btnFileReload"
        Me.btnFileReload.Tag = "Reload"
        Me.ToolTip1.SetToolTip(Me.btnFileReload, resources.GetString("btnFileReload.ToolTip"))
        Me.btnFileReload.UseVisualStyleBackColor = True
        '
        'lblTotalLines
        '
        resources.ApplyResources(Me.lblTotalLines, "lblTotalLines")
        Me.lblTotalLines.Name = "lblTotalLines"
        '
        'btnFilePause
        '
        resources.ApplyResources(Me.btnFilePause, "btnFilePause")
        Me.btnFilePause.Name = "btnFilePause"
        Me.btnFilePause.Tag = "Pause"
        Me.ToolTip1.SetToolTip(Me.btnFilePause, resources.GetString("btnFilePause.ToolTip"))
        Me.btnFilePause.UseVisualStyleBackColor = True
        '
        'tbGcodeFile
        '
        resources.ApplyResources(Me.tbGcodeFile, "tbGcodeFile")
        Me.tbGcodeFile.Name = "tbGcodeFile"
        '
        'btnFileSelect
        '
        resources.ApplyResources(Me.btnFileSelect, "btnFileSelect")
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Tag = "File"
        Me.ToolTip1.SetToolTip(Me.btnFileSelect, resources.GetString("btnFileSelect.ToolTip"))
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'btnFileSend
        '
        resources.ApplyResources(Me.btnFileSend, "btnFileSend")
        Me.btnFileSend.Name = "btnFileSend"
        Me.btnFileSend.Tag = "Send"
        Me.ToolTip1.SetToolTip(Me.btnFileSend, resources.GetString("btnFileSend.ToolTip"))
        Me.btnFileSend.UseVisualStyleBackColor = True
        '
        'btnFileStop
        '
        resources.ApplyResources(Me.btnFileStop, "btnFileStop")
        Me.btnFileStop.Name = "btnFileStop"
        Me.btnFileStop.Tag = "Stop"
        Me.ToolTip1.SetToolTip(Me.btnFileStop, resources.GetString("btnFileStop.ToolTip"))
        Me.btnFileStop.UseVisualStyleBackColor = True
        '
        'gbGrbl
        '
        resources.ApplyResources(Me.gbGrbl, "gbGrbl")
        Me.gbGrbl.Controls.Add(Me.tcConnection)
        Me.gbGrbl.Name = "gbGrbl"
        Me.gbGrbl.TabStop = False
        '
        'tcConnection
        '
        Me.tcConnection.Controls.Add(Me.tbGrblCOM)
        Me.tcConnection.Controls.Add(Me.tbGrblIP)
        resources.ApplyResources(Me.tcConnection, "tcConnection")
        Me.tcConnection.Name = "tcConnection"
        Me.tcConnection.SelectedIndex = 0
        '
        'tbGrblCOM
        '
        Me.tbGrblCOM.Controls.Add(Me.btnRescanPorts)
        Me.tbGrblCOM.Controls.Add(Me.cbPorts)
        Me.tbGrblCOM.Controls.Add(Me.btnConnect)
        Me.tbGrblCOM.Controls.Add(Me.cbBaud)
        resources.ApplyResources(Me.tbGrblCOM, "tbGrblCOM")
        Me.tbGrblCOM.Name = "tbGrblCOM"
        Me.tbGrblCOM.UseVisualStyleBackColor = True
        '
        'btnRescanPorts
        '
        resources.ApplyResources(Me.btnRescanPorts, "btnRescanPorts")
        Me.btnRescanPorts.Name = "btnRescanPorts"
        Me.btnRescanPorts.UseVisualStyleBackColor = True
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = True
        resources.ApplyResources(Me.cbPorts, "cbPorts")
        Me.cbPorts.Name = "cbPorts"
        '
        'btnConnect
        '
        resources.ApplyResources(Me.btnConnect, "btnConnect")
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Tag = "COM"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cbBaud
        '
        Me.cbBaud.FormattingEnabled = True
        Me.cbBaud.Items.AddRange(New Object() {resources.GetString("cbBaud.Items"), resources.GetString("cbBaud.Items1")})
        resources.ApplyResources(Me.cbBaud, "cbBaud")
        Me.cbBaud.Name = "cbBaud"
        '
        'tbGrblIP
        '
        Me.tbGrblIP.Controls.Add(Me.btnIPConnect)
        Me.tbGrblIP.Controls.Add(Me.tbIPAddress)
        resources.ApplyResources(Me.tbGrblIP, "tbGrblIP")
        Me.tbGrblIP.Name = "tbGrblIP"
        Me.tbGrblIP.UseVisualStyleBackColor = True
        '
        'btnIPConnect
        '
        resources.ApplyResources(Me.btnIPConnect, "btnIPConnect")
        Me.btnIPConnect.Name = "btnIPConnect"
        Me.btnIPConnect.Tag = "IP"
        Me.btnIPConnect.UseVisualStyleBackColor = True
        '
        'tbIPAddress
        '
        resources.ApplyResources(Me.tbIPAddress, "tbIPAddress")
        Me.tbIPAddress.Name = "tbIPAddress"
        Me.ToolTip1.SetToolTip(Me.tbIPAddress, resources.GetString("tbIPAddress.ToolTip"))
        '
        'tabPgSettings
        '
        Me.tabPgSettings.Controls.Add(Me.gbMiscInfo)
        Me.tabPgSettings.Controls.Add(Me.gbGrblSettings)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsOffsets)
        Me.tabPgSettings.Controls.Add(Me.Label42)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsMisc)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsPosition)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsJogging)
        resources.ApplyResources(Me.tabPgSettings, "tabPgSettings")
        Me.tabPgSettings.Name = "tabPgSettings"
        Me.tabPgSettings.UseVisualStyleBackColor = True
        '
        'gbMiscInfo
        '
        Me.gbMiscInfo.Controls.Add(Me.Label49)
        Me.gbMiscInfo.Controls.Add(Me.tbGrblOptions)
        Me.gbMiscInfo.Controls.Add(Me.Label48)
        Me.gbMiscInfo.Controls.Add(Me.tbGrblVersion)
        resources.ApplyResources(Me.gbMiscInfo, "gbMiscInfo")
        Me.gbMiscInfo.Name = "gbMiscInfo"
        Me.gbMiscInfo.TabStop = False
        '
        'Label49
        '
        resources.ApplyResources(Me.Label49, "Label49")
        Me.Label49.Name = "Label49"
        '
        'tbGrblOptions
        '
        resources.ApplyResources(Me.tbGrblOptions, "tbGrblOptions")
        Me.tbGrblOptions.Name = "tbGrblOptions"
        '
        'Label48
        '
        resources.ApplyResources(Me.Label48, "Label48")
        Me.Label48.Name = "Label48"
        '
        'tbGrblVersion
        '
        resources.ApplyResources(Me.tbGrblVersion, "tbGrblVersion")
        Me.tbGrblVersion.Name = "tbGrblVersion"
        '
        'gbGrblSettings
        '
        Me.gbGrblSettings.Controls.Add(Me.Label4)
        Me.gbGrblSettings.Controls.Add(Me.tbSettingsGrblLastParam)
        Me.gbGrblSettings.Controls.Add(Me.dgGrblSettings)
        Me.gbGrblSettings.Controls.Add(Me.btnSettingsGrbl)
        resources.ApplyResources(Me.gbGrblSettings, "gbGrblSettings")
        Me.gbGrblSettings.Name = "gbGrblSettings"
        Me.gbGrblSettings.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'tbSettingsGrblLastParam
        '
        Me.tbSettingsGrblLastParam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "GrblLastParamID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsGrblLastParam, "tbSettingsGrblLastParam")
        Me.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam"
        Me.tbSettingsGrblLastParam.Text = Global.GrblPanel.My.MySettings.Default.GrblLastParamID
        Me.ToolTip1.SetToolTip(Me.tbSettingsGrblLastParam, resources.GetString("tbSettingsGrblLastParam.ToolTip"))
        '
        'dgGrblSettings
        '
        Me.dgGrblSettings.AllowUserToAddRows = False
        Me.dgGrblSettings.AllowUserToDeleteRows = False
        Me.dgGrblSettings.AllowUserToResizeColumns = False
        Me.dgGrblSettings.AllowUserToResizeRows = False
        Me.dgGrblSettings.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgGrblSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgGrblSettings, "dgGrblSettings")
        Me.dgGrblSettings.MultiSelect = False
        Me.dgGrblSettings.Name = "dgGrblSettings"
        Me.dgGrblSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ToolTip1.SetToolTip(Me.dgGrblSettings, resources.GetString("dgGrblSettings.ToolTip"))
        '
        'btnSettingsGrbl
        '
        resources.ApplyResources(Me.btnSettingsGrbl, "btnSettingsGrbl")
        Me.btnSettingsGrbl.Name = "btnSettingsGrbl"
        Me.btnSettingsGrbl.UseVisualStyleBackColor = True
        '
        'gbSettingsOffsets
        '
        Me.gbSettingsOffsets.Controls.Add(Me.btnOffsetsG28Set)
        Me.gbSettingsOffsets.Controls.Add(Me.btnSettingsRetrieveLocations)
        Me.gbSettingsOffsets.Controls.Add(Me.Label7)
        Me.gbSettingsOffsets.Controls.Add(Me.Label18)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30Y)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30X)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30Z)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28X)
        Me.gbSettingsOffsets.Controls.Add(Me.btnOffsetsG30Set)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28Y)
        Me.gbSettingsOffsets.Controls.Add(Me.Label68)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28Z)
        Me.gbSettingsOffsets.Controls.Add(Me.Label69)
        resources.ApplyResources(Me.gbSettingsOffsets, "gbSettingsOffsets")
        Me.gbSettingsOffsets.Name = "gbSettingsOffsets"
        Me.gbSettingsOffsets.TabStop = False
        '
        'btnOffsetsG28Set
        '
        resources.ApplyResources(Me.btnOffsetsG28Set, "btnOffsetsG28Set")
        Me.btnOffsetsG28Set.Name = "btnOffsetsG28Set"
        Me.btnOffsetsG28Set.Tag = "G28Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG28Set, resources.GetString("btnOffsetsG28Set.ToolTip"))
        Me.btnOffsetsG28Set.UseVisualStyleBackColor = True
        '
        'btnSettingsRetrieveLocations
        '
        resources.ApplyResources(Me.btnSettingsRetrieveLocations, "btnSettingsRetrieveLocations")
        Me.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations"
        Me.ToolTip1.SetToolTip(Me.btnSettingsRetrieveLocations, resources.GetString("btnSettingsRetrieveLocations.ToolTip"))
        Me.btnSettingsRetrieveLocations.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'tbOffsetsG30Y
        '
        resources.ApplyResources(Me.tbOffsetsG30Y, "tbOffsetsG30Y")
        Me.tbOffsetsG30Y.Name = "tbOffsetsG30Y"
        Me.tbOffsetsG30Y.Tag = "G30Y"
        '
        'tbOffsetsG30X
        '
        resources.ApplyResources(Me.tbOffsetsG30X, "tbOffsetsG30X")
        Me.tbOffsetsG30X.Name = "tbOffsetsG30X"
        Me.tbOffsetsG30X.Tag = "G30X"
        '
        'tbOffsetsG30Z
        '
        resources.ApplyResources(Me.tbOffsetsG30Z, "tbOffsetsG30Z")
        Me.tbOffsetsG30Z.Name = "tbOffsetsG30Z"
        Me.tbOffsetsG30Z.Tag = "G30Z"
        '
        'tbOffsetsG28X
        '
        resources.ApplyResources(Me.tbOffsetsG28X, "tbOffsetsG28X")
        Me.tbOffsetsG28X.Name = "tbOffsetsG28X"
        Me.tbOffsetsG28X.Tag = "G28X"
        '
        'btnOffsetsG30Set
        '
        resources.ApplyResources(Me.btnOffsetsG30Set, "btnOffsetsG30Set")
        Me.btnOffsetsG30Set.Name = "btnOffsetsG30Set"
        Me.btnOffsetsG30Set.Tag = "G30Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG30Set, resources.GetString("btnOffsetsG30Set.ToolTip"))
        Me.btnOffsetsG30Set.UseVisualStyleBackColor = True
        '
        'tbOffsetsG28Y
        '
        resources.ApplyResources(Me.tbOffsetsG28Y, "tbOffsetsG28Y")
        Me.tbOffsetsG28Y.Name = "tbOffsetsG28Y"
        Me.tbOffsetsG28Y.Tag = "G28Y"
        '
        'Label68
        '
        resources.ApplyResources(Me.Label68, "Label68")
        Me.Label68.Name = "Label68"
        '
        'tbOffsetsG28Z
        '
        resources.ApplyResources(Me.tbOffsetsG28Z, "tbOffsetsG28Z")
        Me.tbOffsetsG28Z.Name = "tbOffsetsG28Z"
        Me.tbOffsetsG28Z.Tag = "G28Z"
        '
        'Label69
        '
        resources.ApplyResources(Me.Label69, "Label69")
        Me.Label69.Name = "Label69"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.Name = "Label42"
        '
        'gbSettingsMisc
        '
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsDefaultExt)
        Me.gbSettingsMisc.Controls.Add(Me.Label5)
        Me.gbSettingsMisc.Controls.Add(Me.Label6)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsStartupDelay)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsLeftHanded)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsConnectOnLoad)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsPauseOnError)
        Me.gbSettingsMisc.Controls.Add(Me.cbStatusPollEnable)
        Me.gbSettingsMisc.Controls.Add(Me.btnSettingsRefreshMisc)
        Me.gbSettingsMisc.Controls.Add(Me.Label37)
        Me.gbSettingsMisc.Controls.Add(Me.Label36)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsRBuffSize)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsQSize)
        Me.gbSettingsMisc.Controls.Add(Me.Label26)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsPollRate)
        resources.ApplyResources(Me.gbSettingsMisc, "gbSettingsMisc")
        Me.gbSettingsMisc.Name = "gbSettingsMisc"
        Me.gbSettingsMisc.TabStop = False
        '
        'tbSettingsDefaultExt
        '
        Me.tbSettingsDefaultExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "DefaultFileExt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsDefaultExt, "tbSettingsDefaultExt")
        Me.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt"
        Me.tbSettingsDefaultExt.Text = Global.GrblPanel.My.MySettings.Default.DefaultFileExt
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tbSettingsStartupDelay
        '
        Me.tbSettingsStartupDelay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "StartupDelay", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsStartupDelay, "tbSettingsStartupDelay")
        Me.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay"
        Me.tbSettingsStartupDelay.Text = Global.GrblPanel.My.MySettings.Default.StartupDelay
        '
        'cbSettingsLeftHanded
        '
        resources.ApplyResources(Me.cbSettingsLeftHanded, "cbSettingsLeftHanded")
        Me.cbSettingsLeftHanded.Checked = Global.GrblPanel.My.MySettings.Default.LeftHandedGUI
        Me.cbSettingsLeftHanded.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "LeftHandedGUI", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded"
        Me.cbSettingsLeftHanded.UseVisualStyleBackColor = True
        '
        'cbSettingsConnectOnLoad
        '
        resources.ApplyResources(Me.cbSettingsConnectOnLoad, "cbSettingsConnectOnLoad")
        Me.cbSettingsConnectOnLoad.Checked = Global.GrblPanel.My.MySettings.Default.GrblConnectOnLoad
        Me.cbSettingsConnectOnLoad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GrblConnectOnLoad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad"
        Me.ToolTip1.SetToolTip(Me.cbSettingsConnectOnLoad, resources.GetString("cbSettingsConnectOnLoad.ToolTip"))
        Me.cbSettingsConnectOnLoad.UseVisualStyleBackColor = True
        '
        'cbSettingsPauseOnError
        '
        resources.ApplyResources(Me.cbSettingsPauseOnError, "cbSettingsPauseOnError")
        Me.cbSettingsPauseOnError.Checked = Global.GrblPanel.My.MySettings.Default.GCodePauseOnError
        Me.cbSettingsPauseOnError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsPauseOnError.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GCodePauseOnError", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError"
        Me.cbSettingsPauseOnError.UseVisualStyleBackColor = True
        '
        'cbStatusPollEnable
        '
        resources.ApplyResources(Me.cbStatusPollEnable, "cbStatusPollEnable")
        Me.cbStatusPollEnable.Checked = Global.GrblPanel.My.MySettings.Default.StatusPollEnabled
        Me.cbStatusPollEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusPollEnable.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "StatusPollEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbStatusPollEnable.Name = "cbStatusPollEnable"
        Me.cbStatusPollEnable.UseVisualStyleBackColor = True
        '
        'btnSettingsRefreshMisc
        '
        resources.ApplyResources(Me.btnSettingsRefreshMisc, "btnSettingsRefreshMisc")
        Me.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc"
        Me.btnSettingsRefreshMisc.Tag = "Misc"
        Me.btnSettingsRefreshMisc.UseVisualStyleBackColor = True
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.Name = "Label37"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.Name = "Label36"
        '
        'tbSettingsRBuffSize
        '
        Me.tbSettingsRBuffSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "RBuffMaxSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsRBuffSize, "tbSettingsRBuffSize")
        Me.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize"
        Me.tbSettingsRBuffSize.Text = Global.GrblPanel.My.MySettings.Default.RBuffMaxSize
        '
        'tbSettingsQSize
        '
        Me.tbSettingsQSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "QBuffMaxSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsQSize, "tbSettingsQSize")
        Me.tbSettingsQSize.Name = "tbSettingsQSize"
        Me.tbSettingsQSize.Text = Global.GrblPanel.My.MySettings.Default.QBuffMaxSize
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'tbSettingsPollRate
        '
        Me.tbSettingsPollRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "statusPollInterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsPollRate, "tbSettingsPollRate")
        Me.tbSettingsPollRate.Name = "tbSettingsPollRate"
        Me.tbSettingsPollRate.Text = Global.GrblPanel.My.MySettings.Default.StatusPollInterval
        '
        'gbSettingsPosition
        '
        Me.gbSettingsPosition.Controls.Add(Me.Label22)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsSpclPosition3)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkU0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label20)
        Me.gbSettingsPosition.Controls.Add(Me.Label8)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsSpclPosition2)
        Me.gbSettingsPosition.Controls.Add(Me.btnSettingsRefreshPosition)
        Me.gbSettingsPosition.Controls.Add(Me.Label29)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkZ0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label28)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkY0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label13)
        Me.gbSettingsPosition.Controls.Add(Me.Label12)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkX0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsZeroXYZCmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label11)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsSpclPosition1)
        resources.ApplyResources(Me.gbSettingsPosition, "gbSettingsPosition")
        Me.gbSettingsPosition.Name = "gbSettingsPosition"
        Me.gbSettingsPosition.TabStop = False
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'tbSettingsSpclPosition3
        '
        Me.tbSettingsSpclPosition3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsSpclPosition3, "tbSettingsSpclPosition3")
        Me.tbSettingsSpclPosition3.Name = "tbSettingsSpclPosition3"
        Me.tbSettingsSpclPosition3.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition2
        '
        'tbWorkU0Cmd
        '
        resources.ApplyResources(Me.tbWorkU0Cmd, "tbWorkU0Cmd")
        Me.tbWorkU0Cmd.Name = "tbWorkU0Cmd"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'tbSettingsSpclPosition2
        '
        Me.tbSettingsSpclPosition2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsSpclPosition2, "tbSettingsSpclPosition2")
        Me.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2"
        Me.tbSettingsSpclPosition2.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition2
        '
        'btnSettingsRefreshPosition
        '
        resources.ApplyResources(Me.btnSettingsRefreshPosition, "btnSettingsRefreshPosition")
        Me.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition"
        Me.btnSettingsRefreshPosition.Tag = "Position"
        Me.btnSettingsRefreshPosition.UseVisualStyleBackColor = True
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'tbWorkZ0Cmd
        '
        Me.tbWorkZ0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkZ0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkZ0Cmd, "tbWorkZ0Cmd")
        Me.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd"
        Me.tbWorkZ0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkZ0Cmd
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'tbWorkY0Cmd
        '
        Me.tbWorkY0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkY0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkY0Cmd, "tbWorkY0Cmd")
        Me.tbWorkY0Cmd.Name = "tbWorkY0Cmd"
        Me.tbWorkY0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkY0Cmd
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'tbWorkX0Cmd
        '
        Me.tbWorkX0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkX0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkX0Cmd, "tbWorkX0Cmd")
        Me.tbWorkX0Cmd.Name = "tbWorkX0Cmd"
        Me.tbWorkX0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkX0Cmd
        '
        'tbSettingsZeroXYZCmd
        '
        Me.tbSettingsZeroXYZCmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "Work0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsZeroXYZCmd, "tbSettingsZeroXYZCmd")
        Me.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd"
        Me.tbSettingsZeroXYZCmd.Text = Global.GrblPanel.My.MySettings.Default.Work0Cmd
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        '
        'tbSettingsSpclPosition1
        '
        Me.tbSettingsSpclPosition1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsSpclPosition1, "tbSettingsSpclPosition1")
        Me.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1"
        Me.tbSettingsSpclPosition1.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition1
        '
        'gbSettingsJogging
        '
        Me.gbSettingsJogging.Controls.Add(Me.cbSettingsKeyboardJogging)
        Me.gbSettingsJogging.Controls.Add(Me.btnSettingsRefreshJogging)
        Me.gbSettingsJogging.Controls.Add(Me.Label41)
        Me.gbSettingsJogging.Controls.Add(Me.Label40)
        Me.gbSettingsJogging.Controls.Add(Me.Label39)
        Me.gbSettingsJogging.Controls.Add(Me.Label38)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsZRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsYRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsXRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.Label35)
        Me.gbSettingsJogging.Controls.Add(Me.Label34)
        Me.gbSettingsJogging.Controls.Add(Me.Label32)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFRMetric)
        Me.gbSettingsJogging.Controls.Add(Me.Label33)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFIMetric)
        Me.gbSettingsJogging.Controls.Add(Me.Label31)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFRImperial)
        Me.gbSettingsJogging.Controls.Add(Me.Label30)
        Me.gbSettingsJogging.Controls.Add(Me.cbSettingsMetric)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFIImperial)
        resources.ApplyResources(Me.gbSettingsJogging, "gbSettingsJogging")
        Me.gbSettingsJogging.Name = "gbSettingsJogging"
        Me.gbSettingsJogging.TabStop = False
        '
        'cbSettingsKeyboardJogging
        '
        resources.ApplyResources(Me.cbSettingsKeyboardJogging, "cbSettingsKeyboardJogging")
        Me.cbSettingsKeyboardJogging.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUseKeyboard
        Me.cbSettingsKeyboardJogging.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "JoggingUseKeyboard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging"
        Me.ToolTip1.SetToolTip(Me.cbSettingsKeyboardJogging, resources.GetString("cbSettingsKeyboardJogging.ToolTip"))
        Me.cbSettingsKeyboardJogging.UseVisualStyleBackColor = True
        '
        'btnSettingsRefreshJogging
        '
        resources.ApplyResources(Me.btnSettingsRefreshJogging, "btnSettingsRefreshJogging")
        Me.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging"
        Me.btnSettingsRefreshJogging.Tag = "Jogging"
        Me.btnSettingsRefreshJogging.UseVisualStyleBackColor = True
        '
        'Label41
        '
        resources.ApplyResources(Me.Label41, "Label41")
        Me.Label41.Name = "Label41"
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.Name = "Label40"
        '
        'Label39
        '
        resources.ApplyResources(Me.Label39, "Label39")
        Me.Label39.Name = "Label39"
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.Name = "Label38"
        '
        'tbSettingsZRepeat
        '
        Me.tbSettingsZRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingZRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsZRepeat, "tbSettingsZRepeat")
        Me.tbSettingsZRepeat.Name = "tbSettingsZRepeat"
        Me.tbSettingsZRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingZRepeat
        '
        'tbSettingsYRepeat
        '
        Me.tbSettingsYRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingYRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsYRepeat, "tbSettingsYRepeat")
        Me.tbSettingsYRepeat.Name = "tbSettingsYRepeat"
        Me.tbSettingsYRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingYRepeat
        '
        'tbSettingsXRepeat
        '
        Me.tbSettingsXRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingXRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsXRepeat, "tbSettingsXRepeat")
        Me.tbSettingsXRepeat.Name = "tbSettingsXRepeat"
        Me.tbSettingsXRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingXRepeat
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'tbSettingsFRMetric
        '
        Me.tbSettingsFRMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRMetric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFRMetric, "tbSettingsFRMetric")
        Me.tbSettingsFRMetric.Name = "tbSettingsFRMetric"
        Me.tbSettingsFRMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRMetric
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'tbSettingsFIMetric
        '
        Me.tbSettingsFIMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIMEtric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFIMetric, "tbSettingsFIMetric")
        Me.tbSettingsFIMetric.Name = "tbSettingsFIMetric"
        Me.tbSettingsFIMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFIMEtric
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'tbSettingsFRImperial
        '
        Me.tbSettingsFRImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRImperial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFRImperial, "tbSettingsFRImperial")
        Me.tbSettingsFRImperial.Name = "tbSettingsFRImperial"
        Me.tbSettingsFRImperial.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRImperial
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'cbSettingsMetric
        '
        resources.ApplyResources(Me.cbSettingsMetric, "cbSettingsMetric")
        Me.cbSettingsMetric.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUnitsMetric
        Me.cbSettingsMetric.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsMetric.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "joggingUnitsMetric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsMetric.Name = "cbSettingsMetric"
        Me.cbSettingsMetric.UseVisualStyleBackColor = True
        '
        'tbSettingsFIImperial
        '
        Me.tbSettingsFIImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIImperial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFIImperial, "tbSettingsFIImperial")
        Me.tbSettingsFIImperial.Name = "tbSettingsFIImperial"
        Me.tbSettingsFIImperial.Text = Global.GrblPanel.My.MySettings.Default.JoggingFIImperial
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbEditor)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.dgMacros)
        Me.TabPage1.Controls.Add(Me.lblStatusLabel)
        Me.TabPage1.Controls.Add(Me.btnDeleteMacro)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbEditor
        '
        Me.gbEditor.Controls.Add(Me.btnAdd)
        Me.gbEditor.Controls.Add(Me.lblGCode)
        Me.gbEditor.Controls.Add(Me.tbGCode)
        Me.gbEditor.Controls.Add(Me.lblName)
        Me.gbEditor.Controls.Add(Me.tbName)
        resources.ApplyResources(Me.gbEditor, "gbEditor")
        Me.gbEditor.Name = "gbEditor"
        Me.gbEditor.TabStop = False
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblGCode
        '
        resources.ApplyResources(Me.lblGCode, "lblGCode")
        Me.lblGCode.Name = "lblGCode"
        '
        'tbGCode
        '
        Me.tbGCode.AcceptsReturn = True
        resources.ApplyResources(Me.tbGCode, "tbGCode")
        Me.tbGCode.Name = "tbGCode"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'tbName
        '
        resources.ApplyResources(Me.tbName, "tbName")
        Me.tbName.Name = "tbName"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'dgMacros
        '
        Me.dgMacros.AllowUserToAddRows = False
        Me.dgMacros.AllowUserToDeleteRows = False
        Me.dgMacros.AllowUserToResizeColumns = False
        Me.dgMacros.AllowUserToResizeRows = False
        Me.dgMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgMacros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.dgMacros, "dgMacros")
        Me.dgMacros.Name = "dgMacros"
        Me.dgMacros.ReadOnly = True
        Me.dgMacros.RowHeadersVisible = False
        Me.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'lblStatusLabel
        '
        resources.ApplyResources(Me.lblStatusLabel, "lblStatusLabel")
        Me.lblStatusLabel.Name = "lblStatusLabel"
        '
        'btnDeleteMacro
        '
        resources.ApplyResources(Me.btnDeleteMacro, "btnDeleteMacro")
        Me.btnDeleteMacro.Name = "btnDeleteMacro"
        Me.btnDeleteMacro.UseVisualStyleBackColor = True
        '
        'ofdGcodeFile
        '
        Me.ofdGcodeFile.DefaultExt = "ngc"
        Me.ofdGcodeFile.FileName = "*.*"
        resources.ApplyResources(Me.ofdGcodeFile, "ofdGcodeFile")
        '
        'sfdOffsets
        '
        Me.sfdOffsets.DefaultExt = "xml"
        resources.ApplyResources(Me.sfdOffsets, "sfdOffsets")
        '
        'ofdOffsets
        '
        Me.ofdOffsets.DefaultExt = "xml"
        Me.ofdOffsets.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.ofdOffsets, "ofdOffsets")
        '
        'GrblGui
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GrblGui"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPgInterface.ResumeLayout(False)
        Me.tabPgInterface.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.XYchart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.UVchart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbState.ResumeLayout(False)
        Me.gbState.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDistance.ResumeLayout(False)
        Me.gbDistance.PerformLayout()
        Me.gbFeedRate.ResumeLayout(False)
        Me.gbFeedRate.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbJogging.ResumeLayout(False)
        Me.gbJogging.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gbMDI.ResumeLayout(False)
        Me.gbMDI.PerformLayout()
        Me.gbControl.ResumeLayout(False)
        Me.gbControl.PerformLayout()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.gbGcode.ResumeLayout(False)
        Me.gbGcode.PerformLayout()
        CType(Me.dgvGcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrbl.ResumeLayout(False)
        Me.tcConnection.ResumeLayout(False)
        Me.tbGrblCOM.ResumeLayout(False)
        Me.tbGrblIP.ResumeLayout(False)
        Me.tbGrblIP.PerformLayout()
        Me.tabPgSettings.ResumeLayout(False)
        Me.tabPgSettings.PerformLayout()
        Me.gbMiscInfo.ResumeLayout(False)
        Me.gbMiscInfo.PerformLayout()
        Me.gbGrblSettings.ResumeLayout(False)
        Me.gbGrblSettings.PerformLayout()
        CType(Me.dgGrblSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettingsOffsets.ResumeLayout(False)
        Me.gbSettingsOffsets.PerformLayout()
        Me.gbSettingsMisc.ResumeLayout(False)
        Me.gbSettingsMisc.PerformLayout()
        Me.gbSettingsPosition.ResumeLayout(False)
        Me.gbSettingsPosition.PerformLayout()
        Me.gbSettingsJogging.ResumeLayout(False)
        Me.gbSettingsJogging.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.gbEditor.ResumeLayout(False)
        Me.gbEditor.PerformLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrblSettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPgInterface As System.Windows.Forms.TabPage
    Friend WithEvents rbFeedRate4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance1 As System.Windows.Forms.RadioButton
    Friend WithEvents tabPgSettings As System.Windows.Forms.TabPage
    Friend WithEvents gbGrbl As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbPorts As System.Windows.Forms.ComboBox
    Friend WithEvents cbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents lbResponses As System.Windows.Forms.ListBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbSendData As System.Windows.Forms.TextBox
    Friend WithEvents tbMachX As System.Windows.Forms.TextBox
    Friend WithEvents tbMachY As System.Windows.Forms.TextBox
    Friend WithEvents tbMachZ As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkZ As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkY As System.Windows.Forms.TextBox
    Friend WithEvents btnWorkZ0 As System.Windows.Forms.Button
    Friend WithEvents btnWorkY0 As System.Windows.Forms.Button
    Friend WithEvents btnWorkX0 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnWork0 As System.Windows.Forms.Button
    Public WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cbVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents cbUnits As System.Windows.Forms.CheckBox
    Friend WithEvents gbFeedRate As System.Windows.Forms.GroupBox
    Friend WithEvents gbDistance As System.Windows.Forms.GroupBox
    Friend WithEvents gbSettingsJogging As System.Windows.Forms.GroupBox
    Friend WithEvents cbSettingsMetric As System.Windows.Forms.CheckBox
    Friend WithEvents btnFileSend As System.Windows.Forms.Button
    Friend WithEvents btnFileSelect As System.Windows.Forms.Button
    Friend WithEvents btnFilePause As System.Windows.Forms.Button
    Friend WithEvents btnFileStop As System.Windows.Forms.Button
    Private WithEvents ofdGcodeFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbGcodeFile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbSettingsPosition As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbWorkX0Cmd As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsZeroXYZCmd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsSpclPosition1 As System.Windows.Forms.TextBox
    Public WithEvents btnUnlock As System.Windows.Forms.Button
    Friend WithEvents gbGcode As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalLines As System.Windows.Forms.Label
    Friend WithEvents cbStatusPollEnable As System.Windows.Forms.CheckBox
    Friend WithEvents prgBarQ As System.Windows.Forms.ProgressBar
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents prgbRxBuf As System.Windows.Forms.ProgressBar
    Friend WithEvents gbSettingsMisc As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsPollRate As System.Windows.Forms.TextBox
    Friend WithEvents tbGCodeMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbWorkZ0Cmd As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tbWorkY0Cmd As System.Windows.Forms.TextBox
    Public WithEvents btnHold As System.Windows.Forms.Button
    Public WithEvents btnStartResume As System.Windows.Forms.Button
    Friend WithEvents btnRescanPorts As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFRMetric As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFIMetric As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFRImperial As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFIImperial As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsRBuffSize As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsQSize As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsZRepeat As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsYRepeat As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsXRepeat As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnSettingsRefreshMisc As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRefreshPosition As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRefreshJogging As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbSettingsPauseOnError As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSettingsGrbl As System.Windows.Forms.Button
    Friend WithEvents dgGrblSettings As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnOffsetsG30Set As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG30Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG30Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG30X As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28X As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents sfdOffsets As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdOffsets As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbControl As System.Windows.Forms.GroupBox
    Friend WithEvents tbCurrentStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnZMinus As RepeatButton.RepeatButton
    Friend WithEvents btnZPlus As RepeatButton.RepeatButton
    Friend WithEvents btnXPlus As RepeatButton.RepeatButton
    Friend WithEvents btnYMinus As RepeatButton.RepeatButton
    Friend WithEvents btnXMinus As RepeatButton.RepeatButton
    Friend WithEvents btnYPlus As RepeatButton.RepeatButton
    Friend WithEvents cbSettingsConnectOnLoad As System.Windows.Forms.CheckBox
    Friend WithEvents gbSettingsOffsets As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbWorkX As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsSpclPosition2 As System.Windows.Forms.TextBox
    Friend WithEvents cbSettingsKeyboardJogging As System.Windows.Forms.CheckBox
    Public WithEvents btnCheckMode As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRetrieveLocations As System.Windows.Forms.Button
    Friend WithEvents cbSettingsLeftHanded As System.Windows.Forms.CheckBox
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Lalbel49 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbxStateUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateDistance As System.Windows.Forms.ComboBox
    Friend WithEvents tbStateFeedRate As System.Windows.Forms.TextBox
    Friend WithEvents cbxStateFeedMode As System.Windows.Forms.ComboBox
    Friend WithEvents tbStateTool As System.Windows.Forms.TextBox
    Friend WithEvents tbStateSpindleRPM As System.Windows.Forms.TextBox
    Friend WithEvents cbxStatePlane As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateCoolant As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateSpindle As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateOffset As System.Windows.Forms.ComboBox
    Friend WithEvents btnOffsetsG28Set As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPositionCurrentOffset As System.Windows.Forms.Label
    Friend WithEvents gbGrblSettings As System.Windows.Forms.GroupBox
    Friend WithEvents GrblSettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gbStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsGrblLastParam As System.Windows.Forms.TextBox
    Friend WithEvents btnFileReload As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsStartupDelay As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsDefaultExt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tcConnection As System.Windows.Forms.TabControl
    Friend WithEvents tbGrblCOM As System.Windows.Forms.TabPage
    Friend WithEvents tbGrblIP As System.Windows.Forms.TabPage
    Friend WithEvents btnIPConnect As System.Windows.Forms.Button
    Friend WithEvents tbIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents gbEditor As GroupBox
    Private WithEvents btnAdd As Button
    Private WithEvents lblGCode As Label
    Public WithEvents tbGCode As TextBox
    Private WithEvents lblName As Label
    Public WithEvents tbName As TextBox
    Private WithEvents btnCancel As Button
    Private WithEvents btnOK As Button
    Private WithEvents dgMacros As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents lblStatusLabel As Label
    Private WithEvents btnDeleteMacro As Button
    Friend WithEvents dgvGcode As DataGridView
    Friend WithEvents Label51 As Label
    Friend WithEvents lblCurrentLine As Label
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents lineNum As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents cbMonitorEnable As CheckBox
    Friend WithEvents gbMiscInfo As GroupBox
    Friend WithEvents Label48 As Label
    Friend WithEvents tbGrblVersion As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents tbGrblOptions As TextBox
    Friend WithEvents btnFileStep As Button
    Friend WithEvents gbMDI As GroupBox
    Friend WithEvents spindlescroll As HScrollBar
    Friend WithEvents spindleOFFbtn As Button
    Friend WithEvents spindleONbtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbWorkU As TextBox
    Friend WithEvents tbMachU As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnWorkU0 As Button
    Friend WithEvents btnUPlus As RepeatButton.RepeatButton
    Friend WithEvents btnUMinus As RepeatButton.RepeatButton
    Friend WithEvents btnWork1 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents tbWorkU0Cmd As TextBox
    Friend WithEvents gbState As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbJogging As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUP As RepeatButton.RepeatButton
    Friend WithEvents btnWorkXYZ0 As Button
    Friend WithEvents btnFORWARD As RepeatButton.RepeatButton
    Friend WithEvents btnDOWN As RepeatButton.RepeatButton
    Friend WithEvents btnBACK As RepeatButton.RepeatButton
    Friend WithEvents hotwirelabel As Label
    Friend WithEvents inputvoltagetb As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents state1 As Label
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Public WithEvents XYchart As DataVisualization.Charting.Chart
    Public WithEvents UVchart As DataVisualization.Charting.Chart
    Friend WithEvents Label22 As Label
    Friend WithEvents tbSettingsSpclPosition3 As TextBox
    Friend WithEvents btnHomeUZ As Button
    Friend WithEvents btnHomeAll As Button
    Friend WithEvents btnHomeXY As Button
End Class
