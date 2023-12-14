<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HVACControllerForm
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
        Me.SerialSettingsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSerialSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectSerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SelectBaudRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaudRateComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThermostatGroupBox = New System.Windows.Forms.GroupBox()
        Me.Load2Label = New System.Windows.Forms.Label()
        Me.Load1Label = New System.Windows.Forms.Label()
        Me.HeTempDownButton = New System.Windows.Forms.Button()
        Me.HeTempUpButton = New System.Windows.Forms.Button()
        Me.ConnectLabel = New System.Windows.Forms.Label()
        Me.SafetyIndicatorLabel = New System.Windows.Forms.Label()
        Me.HeatSetTempTextBox = New System.Windows.Forms.TextBox()
        Me.ColdSetTempTextBox = New System.Windows.Forms.TextBox()
        Me.ACTempDownButton = New System.Windows.Forms.Button()
        Me.ACTempUpButton = New System.Windows.Forms.Button()
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
        Me.DOutGroupBox = New System.Windows.Forms.GroupBox()
        Me.DO5CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO6CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO7CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO8CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO4CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO3CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO2CheckBox = New System.Windows.Forms.CheckBox()
        Me.DO1CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigOut8Label = New System.Windows.Forms.Label()
        Me.DigOut7Label = New System.Windows.Forms.Label()
        Me.DigIn8Label = New System.Windows.Forms.Label()
        Me.DigIn5Label = New System.Windows.Forms.Label()
        Me.BaudRateLabel = New System.Windows.Forms.Label()
        Me.DigIn7Label = New System.Windows.Forms.Label()
        Me.DigOut1Label = New System.Windows.Forms.Label()
        Me.DigIn6Label = New System.Windows.Forms.Label()
        Me.DigOut2Label = New System.Windows.Forms.Label()
        Me.DigOut6Label = New System.Windows.Forms.Label()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.DigOut5Label = New System.Windows.Forms.Label()
        Me.DigOut3Label = New System.Windows.Forms.Label()
        Me.DigOut4Label = New System.Windows.Forms.Label()
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
        Me.label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Test1Button = New System.Windows.Forms.Button()
        Me.Test2Button = New System.Windows.Forms.Button()
        Me.Test3Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.SerialSettingsMenuStrip.SuspendLayout()
        Me.ThermostatGroupBox.SuspendLayout()
        Me.TestGroupBox.SuspendLayout()
        Me.DOutGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialSettingsMenuStrip
        '
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
        Me.SetSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetSerialSettingsToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ConnectSystemToolStripMenuItem, Me.ExitToolStripMenuItem})
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
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.LoadToolStripMenuItem.Text = " Load Settings"
        '
        'ConnectSystemToolStripMenuItem
        '
        Me.ConnectSystemToolStripMenuItem.Name = "ConnectSystemToolStripMenuItem"
        Me.ConnectSystemToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.ConnectSystemToolStripMenuItem.Text = "Connect System"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(255, 34)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ThermostatGroupBox
        '
        Me.ThermostatGroupBox.Controls.Add(Me.Load2Label)
        Me.ThermostatGroupBox.Controls.Add(Me.Load1Label)
        Me.ThermostatGroupBox.Controls.Add(Me.HeTempDownButton)
        Me.ThermostatGroupBox.Controls.Add(Me.HeTempUpButton)
        Me.ThermostatGroupBox.Controls.Add(Me.ConnectLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.SafetyIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.HeatSetTempTextBox)
        Me.ThermostatGroupBox.Controls.Add(Me.ColdSetTempTextBox)
        Me.ThermostatGroupBox.Controls.Add(Me.ACTempDownButton)
        Me.ThermostatGroupBox.Controls.Add(Me.ACTempUpButton)
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
        'Load2Label
        '
        Me.Load2Label.AutoSize = True
        Me.Load2Label.Location = New System.Drawing.Point(583, 15)
        Me.Load2Label.Name = "Load2Label"
        Me.Load2Label.Size = New System.Drawing.Size(82, 20)
        Me.Load2Label.TabIndex = 57
        Me.Load2Label.Text = "Serial Port"
        '
        'Load1Label
        '
        Me.Load1Label.AutoSize = True
        Me.Load1Label.Location = New System.Drawing.Point(671, 20)
        Me.Load1Label.Name = "Load1Label"
        Me.Load1Label.Size = New System.Drawing.Size(86, 20)
        Me.Load1Label.TabIndex = 57
        Me.Load1Label.Text = "Baud Rate"
        '
        'HeTempDownButton
        '
        Me.HeTempDownButton.Location = New System.Drawing.Point(626, 141)
        Me.HeTempDownButton.Name = "HeTempDownButton"
        Me.HeTempDownButton.Size = New System.Drawing.Size(82, 67)
        Me.HeTempDownButton.TabIndex = 44
        Me.HeTempDownButton.Text = "Heater Down"
        Me.HeTempDownButton.UseVisualStyleBackColor = True
        '
        'HeTempUpButton
        '
        Me.HeTempUpButton.Location = New System.Drawing.Point(626, 65)
        Me.HeTempUpButton.Name = "HeTempUpButton"
        Me.HeTempUpButton.Size = New System.Drawing.Size(82, 57)
        Me.HeTempUpButton.TabIndex = 43
        Me.HeTempUpButton.Text = "Heater Up"
        Me.HeTempUpButton.UseVisualStyleBackColor = True
        '
        'ConnectLabel
        '
        Me.ConnectLabel.AutoSize = True
        Me.ConnectLabel.Location = New System.Drawing.Point(775, 25)
        Me.ConnectLabel.Name = "ConnectLabel"
        Me.ConnectLabel.Size = New System.Drawing.Size(60, 20)
        Me.ConnectLabel.TabIndex = 41
        Me.ConnectLabel.Text = "Consta"
        '
        'SafetyIndicatorLabel
        '
        Me.SafetyIndicatorLabel.AutoSize = True
        Me.SafetyIndicatorLabel.Location = New System.Drawing.Point(429, 218)
        Me.SafetyIndicatorLabel.Name = "SafetyIndicatorLabel"
        Me.SafetyIndicatorLabel.Size = New System.Drawing.Size(121, 20)
        Me.SafetyIndicatorLabel.TabIndex = 22
        Me.SafetyIndicatorLabel.Text = "Saftey Indicator"
        '
        'HeatSetTempTextBox
        '
        Me.HeatSetTempTextBox.Location = New System.Drawing.Point(739, 95)
        Me.HeatSetTempTextBox.Name = "HeatSetTempTextBox"
        Me.HeatSetTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HeatSetTempTextBox.TabIndex = 3
        '
        'ColdSetTempTextBox
        '
        Me.ColdSetTempTextBox.Location = New System.Drawing.Point(401, 95)
        Me.ColdSetTempTextBox.Name = "ColdSetTempTextBox"
        Me.ColdSetTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ColdSetTempTextBox.TabIndex = 2
        '
        'ACTempDownButton
        '
        Me.ACTempDownButton.Location = New System.Drawing.Point(517, 118)
        Me.ACTempDownButton.Name = "ACTempDownButton"
        Me.ACTempDownButton.Size = New System.Drawing.Size(82, 37)
        Me.ACTempDownButton.TabIndex = 1
        Me.ACTempDownButton.Text = "AC Down"
        Me.ACTempDownButton.UseVisualStyleBackColor = True
        '
        'ACTempUpButton
        '
        Me.ACTempUpButton.Location = New System.Drawing.Point(517, 65)
        Me.ACTempUpButton.Name = "ACTempUpButton"
        Me.ACTempUpButton.Size = New System.Drawing.Size(82, 35)
        Me.ACTempUpButton.TabIndex = 0
        Me.ACTempUpButton.Text = "AC Up"
        Me.ACTempUpButton.UseVisualStyleBackColor = True
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
        Me.HeatSetTempLabel.Location = New System.Drawing.Point(729, 55)
        Me.HeatSetTempLabel.Name = "HeatSetTempLabel"
        Me.HeatSetTempLabel.Size = New System.Drawing.Size(106, 20)
        Me.HeatSetTempLabel.TabIndex = 9
        Me.HeatSetTempLabel.Text = "Heater set to:"
        '
        'ColdSetTempLabel
        '
        Me.ColdSetTempLabel.AutoSize = True
        Me.ColdSetTempLabel.Location = New System.Drawing.Point(397, 38)
        Me.ColdSetTempLabel.Name = "ColdSetTempLabel"
        Me.ColdSetTempLabel.Size = New System.Drawing.Size(79, 20)
        Me.ColdSetTempLabel.TabIndex = 8
        Me.ColdSetTempLabel.Text = "AC set to:"
        '
        'CurrentTempLabel
        '
        Me.CurrentTempLabel.AutoSize = True
        Me.CurrentTempLabel.Location = New System.Drawing.Point(104, 38)
        Me.CurrentTempLabel.Name = "CurrentTempLabel"
        Me.CurrentTempLabel.Size = New System.Drawing.Size(106, 20)
        Me.CurrentTempLabel.TabIndex = 10
        Me.CurrentTempLabel.Text = "Current Temp"
        '
        'SystemTempLabel
        '
        Me.SystemTempLabel.AutoSize = True
        Me.SystemTempLabel.Location = New System.Drawing.Point(275, 70)
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
        Me.TestGroupBox.Controls.Add(Me.DOutGroupBox)
        Me.TestGroupBox.Controls.Add(Me.DigOut8Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut7Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn8Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn5Label)
        Me.TestGroupBox.Controls.Add(Me.BaudRateLabel)
        Me.TestGroupBox.Controls.Add(Me.DigIn7Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut1Label)
        Me.TestGroupBox.Controls.Add(Me.DigIn6Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut2Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut6Label)
        Me.TestGroupBox.Controls.Add(Me.ComPortLabel)
        Me.TestGroupBox.Controls.Add(Me.DigOut5Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut3Label)
        Me.TestGroupBox.Controls.Add(Me.DigOut4Label)
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
        Me.TestGroupBox.Size = New System.Drawing.Size(651, 283)
        Me.TestGroupBox.TabIndex = 3
        Me.TestGroupBox.TabStop = False
        Me.TestGroupBox.Text = "Testing GroupBox"
        '
        'DOutGroupBox
        '
        Me.DOutGroupBox.Controls.Add(Me.DO5CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO6CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO7CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO8CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO4CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO3CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO2CheckBox)
        Me.DOutGroupBox.Controls.Add(Me.DO1CheckBox)
        Me.DOutGroupBox.Location = New System.Drawing.Point(559, 16)
        Me.DOutGroupBox.Name = "DOutGroupBox"
        Me.DOutGroupBox.Size = New System.Drawing.Size(78, 261)
        Me.DOutGroupBox.TabIndex = 56
        Me.DOutGroupBox.TabStop = False
        Me.DOutGroupBox.Text = "Dig Out"
        '
        'DO5CheckBox
        '
        Me.DO5CheckBox.AutoSize = True
        Me.DO5CheckBox.Location = New System.Drawing.Point(18, 148)
        Me.DO5CheckBox.Name = "DO5CheckBox"
        Me.DO5CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO5CheckBox.TabIndex = 62
        Me.DO5CheckBox.UseVisualStyleBackColor = True
        '
        'DO6CheckBox
        '
        Me.DO6CheckBox.AutoSize = True
        Me.DO6CheckBox.Location = New System.Drawing.Point(18, 178)
        Me.DO6CheckBox.Name = "DO6CheckBox"
        Me.DO6CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO6CheckBox.TabIndex = 61
        Me.DO6CheckBox.UseVisualStyleBackColor = True
        '
        'DO7CheckBox
        '
        Me.DO7CheckBox.AutoSize = True
        Me.DO7CheckBox.Location = New System.Drawing.Point(18, 208)
        Me.DO7CheckBox.Name = "DO7CheckBox"
        Me.DO7CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO7CheckBox.TabIndex = 60
        Me.DO7CheckBox.UseVisualStyleBackColor = True
        '
        'DO8CheckBox
        '
        Me.DO8CheckBox.AutoSize = True
        Me.DO8CheckBox.Location = New System.Drawing.Point(18, 238)
        Me.DO8CheckBox.Name = "DO8CheckBox"
        Me.DO8CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO8CheckBox.TabIndex = 59
        Me.DO8CheckBox.UseVisualStyleBackColor = True
        '
        'DO4CheckBox
        '
        Me.DO4CheckBox.AutoSize = True
        Me.DO4CheckBox.Location = New System.Drawing.Point(18, 118)
        Me.DO4CheckBox.Name = "DO4CheckBox"
        Me.DO4CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO4CheckBox.TabIndex = 58
        Me.DO4CheckBox.UseVisualStyleBackColor = True
        '
        'DO3CheckBox
        '
        Me.DO3CheckBox.AutoSize = True
        Me.DO3CheckBox.Location = New System.Drawing.Point(18, 94)
        Me.DO3CheckBox.Name = "DO3CheckBox"
        Me.DO3CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO3CheckBox.TabIndex = 57
        Me.DO3CheckBox.UseVisualStyleBackColor = True
        '
        'DO2CheckBox
        '
        Me.DO2CheckBox.AutoSize = True
        Me.DO2CheckBox.Location = New System.Drawing.Point(18, 69)
        Me.DO2CheckBox.Name = "DO2CheckBox"
        Me.DO2CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO2CheckBox.TabIndex = 56
        Me.DO2CheckBox.UseVisualStyleBackColor = True
        '
        'DO1CheckBox
        '
        Me.DO1CheckBox.AutoSize = True
        Me.DO1CheckBox.Location = New System.Drawing.Point(18, 42)
        Me.DO1CheckBox.Name = "DO1CheckBox"
        Me.DO1CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.DO1CheckBox.TabIndex = 55
        Me.DO1CheckBox.UseVisualStyleBackColor = True
        '
        'DigOut8Label
        '
        Me.DigOut8Label.AutoSize = True
        Me.DigOut8Label.Location = New System.Drawing.Point(455, 247)
        Me.DigOut8Label.Name = "DigOut8Label"
        Me.DigOut8Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut8Label.TabIndex = 39
        Me.DigOut8Label.Text = "Digital Out 8"
        '
        'DigOut7Label
        '
        Me.DigOut7Label.AutoSize = True
        Me.DigOut7Label.Location = New System.Drawing.Point(455, 214)
        Me.DigOut7Label.Name = "DigOut7Label"
        Me.DigOut7Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut7Label.TabIndex = 38
        Me.DigOut7Label.Text = "Digital Out 7"
        '
        'DigIn8Label
        '
        Me.DigIn8Label.AutoSize = True
        Me.DigIn8Label.Location = New System.Drawing.Point(365, 244)
        Me.DigIn8Label.Name = "DigIn8Label"
        Me.DigIn8Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn8Label.TabIndex = 37
        Me.DigIn8Label.Text = "Digital In 8"
        '
        'DigIn5Label
        '
        Me.DigIn5Label.AutoSize = True
        Me.DigIn5Label.Location = New System.Drawing.Point(365, 151)
        Me.DigIn5Label.Name = "DigIn5Label"
        Me.DigIn5Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn5Label.TabIndex = 26
        Me.DigIn5Label.Text = "Digital In 5"
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
        'DigIn7Label
        '
        Me.DigIn7Label.AutoSize = True
        Me.DigIn7Label.Location = New System.Drawing.Point(365, 217)
        Me.DigIn7Label.Name = "DigIn7Label"
        Me.DigIn7Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn7Label.TabIndex = 24
        Me.DigIn7Label.Text = "Digital In 7"
        '
        'DigOut1Label
        '
        Me.DigOut1Label.AutoSize = True
        Me.DigOut1Label.Location = New System.Drawing.Point(455, 25)
        Me.DigOut1Label.Name = "DigOut1Label"
        Me.DigOut1Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut1Label.TabIndex = 36
        Me.DigOut1Label.Text = "Digital Out 1"
        '
        'DigIn6Label
        '
        Me.DigIn6Label.AutoSize = True
        Me.DigIn6Label.Location = New System.Drawing.Point(365, 183)
        Me.DigIn6Label.Name = "DigIn6Label"
        Me.DigIn6Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn6Label.TabIndex = 23
        Me.DigIn6Label.Text = "Digital In 6"
        '
        'DigOut2Label
        '
        Me.DigOut2Label.AutoSize = True
        Me.DigOut2Label.Location = New System.Drawing.Point(455, 56)
        Me.DigOut2Label.Name = "DigOut2Label"
        Me.DigOut2Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut2Label.TabIndex = 35
        Me.DigOut2Label.Text = "Digital Out 2"
        '
        'DigOut6Label
        '
        Me.DigOut6Label.AutoSize = True
        Me.DigOut6Label.Location = New System.Drawing.Point(455, 186)
        Me.DigOut6Label.Name = "DigOut6Label"
        Me.DigOut6Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut6Label.TabIndex = 22
        Me.DigOut6Label.Text = "Digital Out 6"
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
        'DigOut5Label
        '
        Me.DigOut5Label.AutoSize = True
        Me.DigOut5Label.Location = New System.Drawing.Point(455, 154)
        Me.DigOut5Label.Name = "DigOut5Label"
        Me.DigOut5Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut5Label.TabIndex = 16
        Me.DigOut5Label.Text = "Digital Out 5"
        '
        'DigOut3Label
        '
        Me.DigOut3Label.AutoSize = True
        Me.DigOut3Label.Location = New System.Drawing.Point(455, 90)
        Me.DigOut3Label.Name = "DigOut3Label"
        Me.DigOut3Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut3Label.TabIndex = 34
        Me.DigOut3Label.Text = "Digital Out 3"
        '
        'DigOut4Label
        '
        Me.DigOut4Label.AutoSize = True
        Me.DigOut4Label.Location = New System.Drawing.Point(455, 121)
        Me.DigOut4Label.Name = "DigOut4Label"
        Me.DigOut4Label.Size = New System.Drawing.Size(96, 20)
        Me.DigOut4Label.TabIndex = 33
        Me.DigOut4Label.Text = "Digital Out 4"
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
        Me.AnIn1Label.Location = New System.Drawing.Point(295, 25)
        Me.AnIn1Label.Name = "AnIn1Label"
        Me.AnIn1Label.Size = New System.Drawing.Size(60, 20)
        Me.AnIn1Label.TabIndex = 30
        Me.AnIn1Label.Text = "An In 1"
        '
        'AnIn2Label
        '
        Me.AnIn2Label.AutoSize = True
        Me.AnIn2Label.Location = New System.Drawing.Point(295, 59)
        Me.AnIn2Label.Name = "AnIn2Label"
        Me.AnIn2Label.Size = New System.Drawing.Size(60, 20)
        Me.AnIn2Label.TabIndex = 29
        Me.AnIn2Label.Text = "An In 2"
        '
        'DigIn1Label
        '
        Me.DigIn1Label.AutoSize = True
        Me.DigIn1Label.Location = New System.Drawing.Point(365, 22)
        Me.DigIn1Label.Name = "DigIn1Label"
        Me.DigIn1Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn1Label.TabIndex = 28
        Me.DigIn1Label.Text = "Digital In 1"
        '
        'DigIn2Label
        '
        Me.DigIn2Label.AutoSize = True
        Me.DigIn2Label.Location = New System.Drawing.Point(365, 53)
        Me.DigIn2Label.Name = "DigIn2Label"
        Me.DigIn2Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn2Label.TabIndex = 27
        Me.DigIn2Label.Text = "Digital In 2"
        '
        'DigIn3Label
        '
        Me.DigIn3Label.AutoSize = True
        Me.DigIn3Label.Location = New System.Drawing.Point(365, 87)
        Me.DigIn3Label.Name = "DigIn3Label"
        Me.DigIn3Label.Size = New System.Drawing.Size(84, 20)
        Me.DigIn3Label.TabIndex = 26
        Me.DigIn3Label.Text = "Digital In 3"
        '
        'DigIn4Label
        '
        Me.DigIn4Label.AutoSize = True
        Me.DigIn4Label.Location = New System.Drawing.Point(365, 118)
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
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(31, 22)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(109, 20)
        Me.label15.TabIndex = 17
        Me.label15.Text = "Date and time"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoadButton)
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.Controls.Add(Me.Test1Button)
        Me.GroupBox1.Controls.Add(Me.Test2Button)
        Me.GroupBox1.Controls.Add(Me.Test3Button)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.label15)
        Me.GroupBox1.Location = New System.Drawing.Point(669, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 245)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Test1Button
        '
        Me.Test1Button.Location = New System.Drawing.Point(17, 143)
        Me.Test1Button.Name = "Test1Button"
        Me.Test1Button.Size = New System.Drawing.Size(151, 30)
        Me.Test1Button.TabIndex = 40
        Me.Test1Button.Text = "Test Button 1"
        Me.Test1Button.UseVisualStyleBackColor = True
        '
        'Test2Button
        '
        Me.Test2Button.Location = New System.Drawing.Point(17, 98)
        Me.Test2Button.Name = "Test2Button"
        Me.Test2Button.Size = New System.Drawing.Size(151, 30)
        Me.Test2Button.TabIndex = 39
        Me.Test2Button.Text = "Test Button 2"
        Me.Test2Button.UseVisualStyleBackColor = True
        '
        'Test3Button
        '
        Me.Test3Button.Location = New System.Drawing.Point(17, 51)
        Me.Test3Button.Name = "Test3Button"
        Me.Test3Button.Size = New System.Drawing.Size(151, 30)
        Me.Test3Button.TabIndex = 38
        Me.Test3Button.Text = " Delay "
        Me.Test3Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(193, 149)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(151, 30)
        Me.ExitButton.TabIndex = 37
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
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
        Me.LoadButton.Location = New System.Drawing.Point(193, 43)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(151, 30)
        Me.LoadButton.TabIndex = 22
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(193, 98)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(151, 30)
        Me.ConnectButton.TabIndex = 36
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'HVACControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 618)
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
        Me.DOutGroupBox.ResumeLayout(False)
        Me.DOutGroupBox.PerformLayout()
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
    Friend WithEvents ACTempDownButton As Button
    Friend WithEvents ACTempUpButton As Button
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
    Friend WithEvents label15 As Label
    Friend WithEvents DigOut5Label As Label
    Friend WithEvents DigOut6Label As Label
    Friend WithEvents DigIn6Label As Label
    Friend WithEvents DigIn7Label As Label
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
    Friend WithEvents DigOut4Label As Label
    Friend WithEvents DigIn5Label As Label
    Friend WithEvents label1 As Label
    Friend WithEvents SerialPortComboBox As ToolStripComboBox
    Friend WithEvents BaudRateComboBox As ToolStripComboBox
    Friend WithEvents BaudRateLabel As Label
    Friend WithEvents ComPortLabel As Label
    Friend WithEvents LoadButton As Button
    Friend WithEvents ConnectButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DigIn8Label As Label
    Friend WithEvents DigOut8Label As Label
    Friend WithEvents DigOut7Label As Label
    Friend WithEvents DOutGroupBox As GroupBox
    Friend WithEvents DO5CheckBox As CheckBox
    Friend WithEvents DO6CheckBox As CheckBox
    Friend WithEvents DO7CheckBox As CheckBox
    Friend WithEvents DO8CheckBox As CheckBox
    Friend WithEvents DO4CheckBox As CheckBox
    Friend WithEvents DO3CheckBox As CheckBox
    Friend WithEvents DO2CheckBox As CheckBox
    Friend WithEvents DO1CheckBox As CheckBox
    Friend WithEvents Test1Button As Button
    Friend WithEvents Test2Button As Button
    Friend WithEvents Test3Button As Button
    Friend WithEvents SafetyIndicatorLabel As Label
    Friend WithEvents ConnectLabel As Label
    Friend WithEvents Load2Label As Label
    Friend WithEvents Load1Label As Label
    Friend WithEvents HeTempDownButton As Button
    Friend WithEvents HeTempUpButton As Button
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectSystemToolStripMenuItem As ToolStripMenuItem
End Class
