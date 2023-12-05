<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVACControllerForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialSettingsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSerialSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectSerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SelectBaudRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaudRateComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThermostatGroupBox = New System.Windows.Forms.GroupBox()
        Me.HeatSetTempTextBox = New System.Windows.Forms.TextBox()
        Me.ColdSetTempTextBox = New System.Windows.Forms.TextBox()
        Me.TempDownButton = New System.Windows.Forms.Button()
        Me.TempUpButton = New System.Windows.Forms.Button()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.HeatSetTempLabel = New System.Windows.Forms.Label()
        Me.ColdSetTempLabel = New System.Windows.Forms.Label()
        Me.CurrentTempLabel = New System.Windows.Forms.Label()
        Me.SystemTempLabel = New System.Windows.Forms.Label()
        Me.HeaterStatusLabel = New System.Windows.Forms.Label()
        Me.PressureIndicatorLabel = New System.Windows.Forms.Label()
        Me.FanIndicatorLabel = New System.Windows.Forms.Label()
        Me.ACIndicatorLabel = New System.Windows.Forms.Label()
        Me.HeaterIndicatorLabel = New System.Windows.Forms.Label()
        Me.ACStatusLabel = New System.Windows.Forms.Label()
        Me.FanStatusLabel = New System.Windows.Forms.Label()
        Me.PressureStatusLabel = New System.Windows.Forms.Label()
        Me.TestGroupBox = New System.Windows.Forms.GroupBox()
        Me.BaudRateLabel = New System.Windows.Forms.Label()
        Me.DigOut1Label = New System.Windows.Forms.Label()
        Me.DigOut2Label = New System.Windows.Forms.Label()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.DigOut3Label = New System.Windows.Forms.Label()
        Me.DigOutLabel = New System.Windows.Forms.Label()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.AnIn1Label = New System.Windows.Forms.Label()
        Me.AnIn2Label = New System.Windows.Forms.Label()
        Me.DigIn1Label = New System.Windows.Forms.Label()
        Me.DigIn2Label = New System.Windows.Forms.Label()
        Me.DigIn3Label = New System.Windows.Forms.Label()
        Me.DigIn4Label = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.AnIn1CheckBox = New System.Windows.Forms.CheckBox()
        Me.SerialSettingsMenuStrip.SuspendLayout()
        Me.ThermostatGroupBox.SuspendLayout()
        Me.TestGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialSettingsMenuStrip
        '
        Me.SerialSettingsMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.SerialSettingsMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SerialSettingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetSettingsToolStripMenuItem})
        Me.SerialSettingsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SerialSettingsMenuStrip.Name = "SerialSettingsMenuStrip"
        Me.SerialSettingsMenuStrip.Size = New System.Drawing.Size(1074, 33)
        Me.SerialSettingsMenuStrip.TabIndex = 1
        Me.SerialSettingsMenuStrip.Text = "Serial Settings"
        '
        'SetSettingsToolStripMenuItem
        '
        Me.SetSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetSerialSettingsToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SetSettingsToolStripMenuItem.Name = "SetSettingsToolStripMenuItem"
        Me.SetSettingsToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.SetSettingsToolStripMenuItem.Text = "Settings"
        '
        'SetSerialSettingsToolStripMenuItem
        '
        Me.SetSerialSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectSerialPortToolStripMenuItem, Me.SelectBaudRateToolStripMenuItem})
        Me.SetSerialSettingsToolStripMenuItem.Name = "SetSerialSettingsToolStripMenuItem"
        Me.SetSerialSettingsToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.SetSerialSettingsToolStripMenuItem.Text = "Set Serial Settings"
        '
        'SelectSerialPortToolStripMenuItem
        '
        Me.SelectSerialPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortComboBox})
        Me.SelectSerialPortToolStripMenuItem.Name = "SelectSerialPortToolStripMenuItem"
        Me.SelectSerialPortToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.SelectSerialPortToolStripMenuItem.Text = "Select Serial Port"
        '
        'SerialPortComboBox
        '
        Me.SerialPortComboBox.Name = "SerialPortComboBox"
        Me.SerialPortComboBox.Size = New System.Drawing.Size(121, 33)
        Me.SerialPortComboBox.Text = "Serial Port"
        '
        'SelectBaudRateToolStripMenuItem
        '
        Me.SelectBaudRateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaudRateComboBox})
        Me.SelectBaudRateToolStripMenuItem.Name = "SelectBaudRateToolStripMenuItem"
        Me.SelectBaudRateToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.SelectBaudRateToolStripMenuItem.Text = "Select Baud Rate"
        '
        'BaudRateComboBox
        '
        Me.BaudRateComboBox.Name = "BaudRateComboBox"
        Me.BaudRateComboBox.Size = New System.Drawing.Size(121, 33)
        Me.BaudRateComboBox.Text = "Baud Rate"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ThermostatGroupBox
        '
        Me.ThermostatGroupBox.Controls.Add(Me.HeatSetTempTextBox)
        Me.ThermostatGroupBox.Controls.Add(Me.ColdSetTempTextBox)
        Me.ThermostatGroupBox.Controls.Add(Me.TempDownButton)
        Me.ThermostatGroupBox.Controls.Add(Me.TempUpButton)
        Me.ThermostatGroupBox.Controls.Add(Me.DayLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.TimeLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.HeatSetTempLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.ColdSetTempLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.CurrentTempLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.SystemTempLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.HeaterStatusLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.PressureIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.FanIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.ACIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.HeaterIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.ACStatusLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.FanStatusLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.PressureStatusLabel)
        Me.ThermostatGroupBox.Location = New System.Drawing.Point(12, 59)
        Me.ThermostatGroupBox.Name = "ThermostatGroupBox"
        Me.ThermostatGroupBox.Size = New System.Drawing.Size(855, 259)
        Me.ThermostatGroupBox.TabIndex = 2
        Me.ThermostatGroupBox.TabStop = False
        Me.ThermostatGroupBox.Text = "Thermostat GroupBox"
        '
        'HeatSetTempTextBox
        '
        Me.HeatSetTempTextBox.Location = New System.Drawing.Point(453, 98)
        Me.HeatSetTempTextBox.Name = "HeatSetTempTextBox"
        Me.HeatSetTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HeatSetTempTextBox.TabIndex = 3
        '
        'ColdSetTempTextBox
        '
        Me.ColdSetTempTextBox.Location = New System.Drawing.Point(453, 51)
        Me.ColdSetTempTextBox.Name = "ColdSetTempTextBox"
        Me.ColdSetTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ColdSetTempTextBox.TabIndex = 2
        '
        'TempDownButton
        '
        Me.TempDownButton.Location = New System.Drawing.Point(559, 87)
        Me.TempDownButton.Name = "TempDownButton"
        Me.TempDownButton.Size = New System.Drawing.Size(161, 37)
        Me.TempDownButton.TabIndex = 1
        Me.TempDownButton.Text = "Decrease temp"
        Me.TempDownButton.UseVisualStyleBackColor = True
        '
        'TempUpButton
        '
        Me.TempUpButton.Location = New System.Drawing.Point(559, 51)
        Me.TempUpButton.Name = "TempUpButton"
        Me.TempUpButton.Size = New System.Drawing.Size(151, 30)
        Me.TempUpButton.TabIndex = 0
        Me.TempUpButton.Text = "Increase temp"
        Me.TempUpButton.UseVisualStyleBackColor = True
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Location = New System.Drawing.Point(6, 70)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(37, 20)
        Me.DayLabel.TabIndex = 6
        Me.DayLabel.Text = "Day"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(203, 70)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(43, 20)
        Me.TimeLabel.TabIndex = 7
        Me.TimeLabel.Text = "Time"
        '
        'HeatSetTempLabel
        '
        Me.HeatSetTempLabel.AutoSize = True
        Me.HeatSetTempLabel.Location = New System.Drawing.Point(726, 98)
        Me.HeatSetTempLabel.Name = "HeatSetTempLabel"
        Me.HeatSetTempLabel.Size = New System.Drawing.Size(117, 20)
        Me.HeatSetTempLabel.TabIndex = 9
        Me.HeatSetTempLabel.Text = "Heat Set Temp"
        '
        'ColdSetTempLabel
        '
        Me.ColdSetTempLabel.AutoSize = True
        Me.ColdSetTempLabel.Location = New System.Drawing.Point(729, 61)
        Me.ColdSetTempLabel.Name = "ColdSetTempLabel"
        Me.ColdSetTempLabel.Size = New System.Drawing.Size(114, 20)
        Me.ColdSetTempLabel.TabIndex = 8
        Me.ColdSetTempLabel.Text = "Cold Set Temp"
        '
        'CurrentTempLabel
        '
        Me.CurrentTempLabel.AutoSize = True
        Me.CurrentTempLabel.Location = New System.Drawing.Point(75, 70)
        Me.CurrentTempLabel.Name = "CurrentTempLabel"
        Me.CurrentTempLabel.Size = New System.Drawing.Size(106, 20)
        Me.CurrentTempLabel.TabIndex = 10
        Me.CurrentTempLabel.Text = "Current Temp"
        '
        'SystemTempLabel
        '
        Me.SystemTempLabel.AutoSize = True
        Me.SystemTempLabel.Location = New System.Drawing.Point(286, 70)
        Me.SystemTempLabel.Name = "SystemTempLabel"
        Me.SystemTempLabel.Size = New System.Drawing.Size(106, 20)
        Me.SystemTempLabel.TabIndex = 11
        Me.SystemTempLabel.Text = "System Temp"
        '
        'HeaterStatusLabel
        '
        Me.HeaterStatusLabel.AutoSize = True
        Me.HeaterStatusLabel.Location = New System.Drawing.Point(6, 118)
        Me.HeaterStatusLabel.Name = "HeaterStatusLabel"
        Me.HeaterStatusLabel.Size = New System.Drawing.Size(107, 20)
        Me.HeaterStatusLabel.TabIndex = 12
        Me.HeaterStatusLabel.Text = "Heater on/ off"
        '
        'PressureIndicatorLabel
        '
        Me.PressureIndicatorLabel.AutoSize = True
        Me.PressureIndicatorLabel.Location = New System.Drawing.Point(222, 218)
        Me.PressureIndicatorLabel.Name = "PressureIndicatorLabel"
        Me.PressureIndicatorLabel.Size = New System.Drawing.Size(138, 20)
        Me.PressureIndicatorLabel.TabIndex = 18
        Me.PressureIndicatorLabel.Text = "Pressure Indicator"
        '
        'FanIndicatorLabel
        '
        Me.FanIndicatorLabel.AutoSize = True
        Me.FanIndicatorLabel.Location = New System.Drawing.Point(222, 188)
        Me.FanIndicatorLabel.Name = "FanIndicatorLabel"
        Me.FanIndicatorLabel.Size = New System.Drawing.Size(103, 20)
        Me.FanIndicatorLabel.TabIndex = 19
        Me.FanIndicatorLabel.Text = "Fan Indicator"
        '
        'ACIndicatorLabel
        '
        Me.ACIndicatorLabel.AutoSize = True
        Me.ACIndicatorLabel.Location = New System.Drawing.Point(218, 150)
        Me.ACIndicatorLabel.Name = "ACIndicatorLabel"
        Me.ACIndicatorLabel.Size = New System.Drawing.Size(101, 20)
        Me.ACIndicatorLabel.TabIndex = 20
        Me.ACIndicatorLabel.Text = "AC Indicator "
        '
        'HeaterIndicatorLabel
        '
        Me.HeaterIndicatorLabel.AutoSize = True
        Me.HeaterIndicatorLabel.Location = New System.Drawing.Point(218, 118)
        Me.HeaterIndicatorLabel.Name = "HeaterIndicatorLabel"
        Me.HeaterIndicatorLabel.Size = New System.Drawing.Size(124, 20)
        Me.HeaterIndicatorLabel.TabIndex = 21
        Me.HeaterIndicatorLabel.Text = "Heater Indicator"
        '
        'ACStatusLabel
        '
        Me.ACStatusLabel.AutoSize = True
        Me.ACStatusLabel.Location = New System.Drawing.Point(6, 150)
        Me.ACStatusLabel.Name = "ACStatusLabel"
        Me.ACStatusLabel.Size = New System.Drawing.Size(80, 20)
        Me.ACStatusLabel.TabIndex = 15
        Me.ACStatusLabel.Text = "AC on/ off"
        '
        'FanStatusLabel
        '
        Me.FanStatusLabel.AutoSize = True
        Me.FanStatusLabel.Location = New System.Drawing.Point(6, 188)
        Me.FanStatusLabel.Name = "FanStatusLabel"
        Me.FanStatusLabel.Size = New System.Drawing.Size(86, 20)
        Me.FanStatusLabel.TabIndex = 14
        Me.FanStatusLabel.Text = "Fan on/ off"
        '
        'PressureStatusLabel
        '
        Me.PressureStatusLabel.AutoSize = True
        Me.PressureStatusLabel.Location = New System.Drawing.Point(4, 218)
        Me.PressureStatusLabel.Name = "PressureStatusLabel"
        Me.PressureStatusLabel.Size = New System.Drawing.Size(177, 20)
        Me.PressureStatusLabel.TabIndex = 13
        Me.PressureStatusLabel.Text = "Pressure System status"
        '
        'TestGroupBox
        '
        Me.TestGroupBox.Controls.Add(Me.AnIn1CheckBox)
        Me.TestGroupBox.Controls.Add(Me.BaudRateLabel)
        Me.TestGroupBox.Controls.Add(Me.DigOut1Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut2Label)
        Me.TestGroupBox.Controls.Add(Me.ComPortLabel)
        Me.TestGroupBox.Controls.Add(Me.DigOut3Label)
        Me.TestGroupBox.Controls.Add(Me.DigOutLabel)
        Me.TestGroupBox.Controls.Add(Me.TXLabel)
        Me.TestGroupBox.Controls.Add(Me.RXLabel)
        Me.TestGroupBox.Controls.Add(Me.AnIn1Label)
        Me.TestGroupBox.Controls.Add(Me.AnIn2Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn1Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn2Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn3Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn4Label)
        Me.TestGroupBox.Location = New System.Drawing.Point(12, 333)
        Me.TestGroupBox.Name = "TestGroupBox"
        Me.TestGroupBox.Size = New System.Drawing.Size(615, 182)
        Me.TestGroupBox.TabIndex = 3
        Me.TestGroupBox.TabStop = False
        Me.TestGroupBox.Text = "Testing GroupBox"
        '
        'BaudRateLabel
        '
        Me.BaudRateLabel.AutoSize = True
        Me.BaudRateLabel.Location = New System.Drawing.Point(124, 25)
        Me.BaudRateLabel.Name = "BaudRateLabel"
        Me.BaudRateLabel.Size = New System.Drawing.Size(86, 20)
        Me.BaudRateLabel.TabIndex = 27
        Me.BaudRateLabel.Text = "Baud Rate"
        '
        'DigOut1Label
        '
        Me.DigOut1Label.AutoSize = True
        Me.DigOut1Label.Location = New System.Drawing.Point(508, 28)
        Me.DigOut1Label.Name = "DigOut1Label"
        Me.DigOut1Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut1Label.TabIndex = 36
        Me.DigOut1Label.Text = "Digital Out 1"
        '
        'DigOut2Label
        '
        Me.DigOut2Label.AutoSize = True
        Me.DigOut2Label.Location = New System.Drawing.Point(508, 59)
        Me.DigOut2Label.Name = "DigOut2Label"
        Me.DigOut2Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut2Label.TabIndex = 35
        Me.DigOut2Label.Text = "Digital Out 2"
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = True
        Me.ComPortLabel.Location = New System.Drawing.Point(10, 25)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(82, 20)
        Me.ComPortLabel.TabIndex = 28
        Me.ComPortLabel.Text = "Serial Port"
        '
        'DigOut3Label
        '
        Me.DigOut3Label.AutoSize = True
        Me.DigOut3Label.Location = New System.Drawing.Point(508, 93)
        Me.DigOut3Label.Name = "DigOut3Label"
        Me.DigOut3Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut3Label.TabIndex = 34
        Me.DigOut3Label.Text = "Digital Out 3"
        '
        'DigOutLabel
        '
        Me.DigOutLabel.AutoSize = True
        Me.DigOutLabel.Location = New System.Drawing.Point(508, 124)
        Me.DigOutLabel.Name = "DigOutLabel"
        Me.DigOutLabel.Size = New System.Drawing.Size(96, 20)
        Me.DigOutLabel.TabIndex = 33
        Me.DigOutLabel.Text = "Digital Out 4"
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(21, 67)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(65, 20)
        Me.TXLabel.TabIndex = 32
        Me.TXLabel.Text = "TX data"
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(124, 67)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(71, 20)
        Me.RXLabel.TabIndex = 31
        Me.RXLabel.Text = "RX Data"
        '
        'AnIn1Label
        '
        Me.AnIn1Label.AutoSize = True
        Me.AnIn1Label.Location = New System.Drawing.Point(300, 33)
        Me.AnIn1Label.Name = "AnIn1Label"
        Me.AnIn1Label.Size = New System.Drawing.Size(60, 20)
        Me.AnIn1Label.TabIndex = 30
        Me.AnIn1Label.Text = "An In 1"
        '
        'AnIn2Label
        '
        Me.AnIn2Label.AutoSize = True
        Me.AnIn2Label.Location = New System.Drawing.Point(300, 67)
        Me.AnIn2Label.Name = "AnIn2Label"
        Me.AnIn2Label.Size = New System.Drawing.Size(60, 20)
        Me.AnIn2Label.TabIndex = 29
        Me.AnIn2Label.Text = "An In 2"
        '
        'DigIn1Label
        '
        Me.DigIn1Label.AutoSize = True
        Me.DigIn1Label.Location = New System.Drawing.Point(414, 28)
        Me.DigIn1Label.Name = "DigIn1Label"
        Me.DigIn1Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn1Label.TabIndex = 28
        Me.DigIn1Label.Text = "Digital In 1"
        '
        'DigIn2Label
        '
        Me.DigIn2Label.AutoSize = True
        Me.DigIn2Label.Location = New System.Drawing.Point(414, 59)
        Me.DigIn2Label.Name = "DigIn2Label"
        Me.DigIn2Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn2Label.TabIndex = 27
        Me.DigIn2Label.Text = "Digital In 2"
        '
        'DigIn3Label
        '
        Me.DigIn3Label.AutoSize = True
        Me.DigIn3Label.Location = New System.Drawing.Point(414, 93)
        Me.DigIn3Label.Name = "DigIn3Label"
        Me.DigIn3Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn3Label.TabIndex = 26
        Me.DigIn3Label.Text = "Digital In 3"
        '
        'DigIn4Label
        '
        Me.DigIn4Label.AutoSize = True
        Me.DigIn4Label.Location = New System.Drawing.Point(414, 124)
        Me.DigIn4Label.Name = "DigIn4Label"
        Me.DigIn4Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn4Label.TabIndex = 25
        Me.DigIn4Label.Text = "Digital In 4"
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 20)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 20)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(42, 124)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(42, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 20)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Label19"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(809, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 240)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(42, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 20)
        Me.label1.TabIndex = 25
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(26, 546)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(151, 30)
        Me.LoadButton.TabIndex = 22
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(203, 546)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(151, 30)
        Me.ConnectButton.TabIndex = 36
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'AnIn1CheckBox
        '
        Me.AnIn1CheckBox.AutoSize = True
        Me.AnIn1CheckBox.Location = New System.Drawing.Point(254, 127)
        Me.AnIn1CheckBox.Name = "AnIn1CheckBox"
        Me.AnIn1CheckBox.Size = New System.Drawing.Size(82, 24)
        Me.AnIn1CheckBox.TabIndex = 22
        Me.AnIn1CheckBox.Text = "AnIn1 "
        Me.AnIn1CheckBox.UseVisualStyleBackColor = True
        '
        'HVACControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 618)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TestGroupBox)
        Me.Controls.Add(Me.ThermostatGroupBox)
        Me.Controls.Add(Me.SerialSettingsMenuStrip)
        Me.MainMenuStrip = Me.SerialSettingsMenuStrip
        Me.Name = "HVACControllerForm"
        Me.Text = "HVAC Controller"
        Me.SerialSettingsMenuStrip.ResumeLayout(False)
        Me.SerialSettingsMenuStrip.PerformLayout()
        Me.ThermostatGroupBox.ResumeLayout(False)
        Me.ThermostatGroupBox.PerformLayout()
        Me.TestGroupBox.ResumeLayout(False)
        Me.TestGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialSettingsMenuStrip As MenuStrip
    Friend WithEvents ThermostatGroupBox As GroupBox
    Friend WithEvents TestGroupBox As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents HeatSetTempTextBox As TextBox
    Friend WithEvents ColdSetTempTextBox As TextBox
    Friend WithEvents TempDownButton As Button
    Friend WithEvents TempUpButton As Button
    Friend WithEvents DayLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents HeatSetTempLabel As Label
    Friend WithEvents ColdSetTempLabel As Label
    Friend WithEvents CurrentTempLabel As Label
    Friend WithEvents SystemTempLabel As Label
    Friend WithEvents HeaterStatusLabel As Label
    Friend WithEvents ACStatusLabel As Label
    Friend WithEvents FanStatusLabel As Label
    Friend WithEvents PressureStatusLabel As Label
    Friend WithEvents HeaterIndicatorLabel As Label
    Friend WithEvents ACIndicatorLabel As Label
    Friend WithEvents FanIndicatorLabel As Label
    Friend WithEvents PressureIndicatorLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DigIn4Label As Label
    Friend WithEvents DigIn3Label As Label
    Friend WithEvents DigIn2Label As Label
    Friend WithEvents DigIn1Label As Label
    Friend WithEvents AnIn2Label As Label
    Friend WithEvents AnIn1Label As Label
    Friend WithEvents RXLabel As Label
    Friend WithEvents TXLabel As Label
    Friend WithEvents SetSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetSerialSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectSerialPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectBaudRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DigOut1Label As Label
    Friend WithEvents DigOut2Label As Label
    Friend WithEvents DigOut3Label As Label
    Friend WithEvents DigOutLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents SerialPortComboBox As ToolStripComboBox
    Friend WithEvents BaudRateComboBox As ToolStripComboBox
    Friend WithEvents BaudRateLabel As Label
    Friend WithEvents ComPortLabel As Label
    Friend WithEvents LoadButton As Button
    Friend WithEvents ConnectButton As Button
    Friend WithEvents AnIn1CheckBox As CheckBox
End Class
