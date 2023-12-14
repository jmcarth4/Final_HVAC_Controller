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
        Me.FanIndicatorLabel = New System.Windows.Forms.Label()
        Me.ACIndicatorLabel = New System.Windows.Forms.Label()
        Me.HeaterIndicatorLabel = New System.Windows.Forms.Label()
        Me.ACStatusLabel = New System.Windows.Forms.Label()
        Me.FanStatusLabel = New System.Windows.Forms.Label()
        Me.PressureStatusLabel = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PressureIndicatorLabel = New System.Windows.Forms.Label()
        Me.SerialSettingsMenuStrip.SuspendLayout()
        Me.ThermostatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialSettingsMenuStrip
        '
        Me.SerialSettingsMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.SerialSettingsMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SerialSettingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetSettingsToolStripMenuItem})
        Me.SerialSettingsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SerialSettingsMenuStrip.Name = "SerialSettingsMenuStrip"
        Me.SerialSettingsMenuStrip.Size = New System.Drawing.Size(971, 36)
        Me.SerialSettingsMenuStrip.TabIndex = 1
        Me.SerialSettingsMenuStrip.Text = "Serial Settings"
        '
        'SetSettingsToolStripMenuItem
        '
        Me.SetSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetSerialSettingsToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ConnectSystemToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SetSettingsToolStripMenuItem.Name = "SetSettingsToolStripMenuItem"
        Me.SetSettingsToolStripMenuItem.Size = New System.Drawing.Size(92, 30)
        Me.SetSettingsToolStripMenuItem.Text = "Settings"
        '
        'SetSerialSettingsToolStripMenuItem
        '
        Me.SetSerialSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectSerialPortToolStripMenuItem, Me.SelectBaudRateToolStripMenuItem})
        Me.SetSerialSettingsToolStripMenuItem.Name = "SetSerialSettingsToolStripMenuItem"
        Me.SetSerialSettingsToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
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
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LoadToolStripMenuItem.Text = " Load Settings"
        '
        'ConnectSystemToolStripMenuItem
        '
        Me.ConnectSystemToolStripMenuItem.Name = "ConnectSystemToolStripMenuItem"
        Me.ConnectSystemToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ConnectSystemToolStripMenuItem.Text = "Connect System"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ThermostatGroupBox
        '
        Me.ThermostatGroupBox.BackColor = System.Drawing.Color.White
        Me.ThermostatGroupBox.Controls.Add(Me.PressureIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.Label1)
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
        Me.ThermostatGroupBox.Controls.Add(Me.FanIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.ACIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.HeaterIndicatorLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.ACStatusLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.FanStatusLabel)
        Me.ThermostatGroupBox.Controls.Add(Me.PressureStatusLabel)
        Me.ThermostatGroupBox.Location = New System.Drawing.Point(12, 36)
        Me.ThermostatGroupBox.Name = "ThermostatGroupBox"
        Me.ThermostatGroupBox.Size = New System.Drawing.Size(959, 375)
        Me.ThermostatGroupBox.TabIndex = 2
        Me.ThermostatGroupBox.TabStop = False
        Me.ThermostatGroupBox.Text = "Thermostat GroupBox"
        '
        'Load2Label
        '
        Me.Load2Label.AutoSize = True
        Me.Load2Label.Location = New System.Drawing.Point(861, 18)
        Me.Load2Label.Name = "Load2Label"
        Me.Load2Label.Size = New System.Drawing.Size(82, 20)
        Me.Load2Label.TabIndex = 57
        Me.Load2Label.Text = "Serial Port"
        '
        'Load1Label
        '
        Me.Load1Label.AutoSize = True
        Me.Load1Label.Location = New System.Drawing.Point(861, 38)
        Me.Load1Label.Name = "Load1Label"
        Me.Load1Label.Size = New System.Drawing.Size(86, 20)
        Me.Load1Label.TabIndex = 57
        Me.Load1Label.Text = "Baud Rate"
        '
        'HeTempDownButton
        '
        Me.HeTempDownButton.Location = New System.Drawing.Point(639, 116)
        Me.HeTempDownButton.Name = "HeTempDownButton"
        Me.HeTempDownButton.Size = New System.Drawing.Size(82, 67)
        Me.HeTempDownButton.TabIndex = 44
        Me.HeTempDownButton.Text = "Heater Down"
        Me.HeTempDownButton.UseVisualStyleBackColor = True
        '
        'HeTempUpButton
        '
        Me.HeTempUpButton.Location = New System.Drawing.Point(639, 47)
        Me.HeTempUpButton.Name = "HeTempUpButton"
        Me.HeTempUpButton.Size = New System.Drawing.Size(82, 57)
        Me.HeTempUpButton.TabIndex = 43
        Me.HeTempUpButton.Text = "Heater Up"
        Me.HeTempUpButton.UseVisualStyleBackColor = True
        '
        'ConnectLabel
        '
        Me.ConnectLabel.AutoSize = True
        Me.ConnectLabel.Location = New System.Drawing.Point(861, 58)
        Me.ConnectLabel.Name = "ConnectLabel"
        Me.ConnectLabel.Size = New System.Drawing.Size(60, 20)
        Me.ConnectLabel.TabIndex = 41
        Me.ConnectLabel.Text = "Consta"
        '
        'SafetyIndicatorLabel
        '
        Me.SafetyIndicatorLabel.AutoSize = True
        Me.SafetyIndicatorLabel.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold)
        Me.SafetyIndicatorLabel.Location = New System.Drawing.Point(3, 316)
        Me.SafetyIndicatorLabel.Name = "SafetyIndicatorLabel"
        Me.SafetyIndicatorLabel.Size = New System.Drawing.Size(377, 56)
        Me.SafetyIndicatorLabel.TabIndex = 22
        Me.SafetyIndicatorLabel.Text = "Saftey Indicator"
        '
        'HeatSetTempTextBox
        '
        Me.HeatSetTempTextBox.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatSetTempTextBox.Location = New System.Drawing.Point(733, 90)
        Me.HeatSetTempTextBox.Name = "HeatSetTempTextBox"
        Me.HeatSetTempTextBox.Size = New System.Drawing.Size(56, 40)
        Me.HeatSetTempTextBox.TabIndex = 3
        '
        'ColdSetTempTextBox
        '
        Me.ColdSetTempTextBox.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColdSetTempTextBox.Location = New System.Drawing.Point(325, 90)
        Me.ColdSetTempTextBox.Name = "ColdSetTempTextBox"
        Me.ColdSetTempTextBox.Size = New System.Drawing.Size(51, 40)
        Me.ColdSetTempTextBox.TabIndex = 2
        '
        'ACTempDownButton
        '
        Me.ACTempDownButton.Location = New System.Drawing.Point(413, 116)
        Me.ACTempDownButton.Name = "ACTempDownButton"
        Me.ACTempDownButton.Size = New System.Drawing.Size(82, 37)
        Me.ACTempDownButton.TabIndex = 1
        Me.ACTempDownButton.Text = "AC Down"
        Me.ACTempDownButton.UseVisualStyleBackColor = True
        '
        'ACTempUpButton
        '
        Me.ACTempUpButton.Location = New System.Drawing.Point(413, 63)
        Me.ACTempUpButton.Name = "ACTempUpButton"
        Me.ACTempUpButton.Size = New System.Drawing.Size(82, 35)
        Me.ACTempUpButton.TabIndex = 0
        Me.ACTempUpButton.Text = "AC Up"
        Me.ACTempUpButton.UseVisualStyleBackColor = True
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.DayLabel.Location = New System.Drawing.Point(6, 171)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(78, 46)
        Me.DayLabel.TabIndex = 6
        Me.DayLabel.Text = "Day"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.TimeLabel.Location = New System.Drawing.Point(213, 171)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(92, 46)
        Me.TimeLabel.TabIndex = 7
        Me.TimeLabel.Text = "Time"
        '
        'HeatSetTempLabel
        '
        Me.HeatSetTempLabel.AutoSize = True
        Me.HeatSetTempLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.HeatSetTempLabel.Location = New System.Drawing.Point(729, 63)
        Me.HeatSetTempLabel.Name = "HeatSetTempLabel"
        Me.HeatSetTempLabel.Size = New System.Drawing.Size(129, 29)
        Me.HeatSetTempLabel.TabIndex = 9
        Me.HeatSetTempLabel.Text = "Heater set to:"
        '
        'ColdSetTempLabel
        '
        Me.ColdSetTempLabel.AutoSize = True
        Me.ColdSetTempLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.ColdSetTempLabel.Location = New System.Drawing.Point(310, 58)
        Me.ColdSetTempLabel.Name = "ColdSetTempLabel"
        Me.ColdSetTempLabel.Size = New System.Drawing.Size(97, 29)
        Me.ColdSetTempLabel.TabIndex = 8
        Me.ColdSetTempLabel.Text = "AC set to:"
        '
        'CurrentTempLabel
        '
        Me.CurrentTempLabel.AutoSize = True
        Me.CurrentTempLabel.Font = New System.Drawing.Font("Arial Narrow", 30.0!)
        Me.CurrentTempLabel.Location = New System.Drawing.Point(65, 67)
        Me.CurrentTempLabel.Name = "CurrentTempLabel"
        Me.CurrentTempLabel.Size = New System.Drawing.Size(191, 69)
        Me.CurrentTempLabel.TabIndex = 10
        Me.CurrentTempLabel.Text = "CTemp"
        '
        'SystemTempLabel
        '
        Me.SystemTempLabel.AutoSize = True
        Me.SystemTempLabel.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTempLabel.Location = New System.Drawing.Point(511, 90)
        Me.SystemTempLabel.Name = "SystemTempLabel"
        Me.SystemTempLabel.Size = New System.Drawing.Size(103, 37)
        Me.SystemTempLabel.TabIndex = 11
        Me.SystemTempLabel.Text = "STemp"
        '
        'HeaterStatusLabel
        '
        Me.HeaterStatusLabel.AutoSize = True
        Me.HeaterStatusLabel.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.HeaterStatusLabel.Location = New System.Drawing.Point(756, 267)
        Me.HeaterStatusLabel.Name = "HeaterStatusLabel"
        Me.HeaterStatusLabel.Size = New System.Drawing.Size(187, 37)
        Me.HeaterStatusLabel.TabIndex = 12
        Me.HeaterStatusLabel.Text = "Heater on/ off"
        '
        'FanIndicatorLabel
        '
        Me.FanIndicatorLabel.AutoSize = True
        Me.FanIndicatorLabel.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.FanIndicatorLabel.Location = New System.Drawing.Point(514, 215)
        Me.FanIndicatorLabel.Name = "FanIndicatorLabel"
        Me.FanIndicatorLabel.Size = New System.Drawing.Size(172, 37)
        Me.FanIndicatorLabel.TabIndex = 19
        Me.FanIndicatorLabel.Text = "Fan Indicator"
        '
        'ACIndicatorLabel
        '
        Me.ACIndicatorLabel.AutoSize = True
        Me.ACIndicatorLabel.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ACIndicatorLabel.Location = New System.Drawing.Point(318, 215)
        Me.ACIndicatorLabel.Name = "ACIndicatorLabel"
        Me.ACIndicatorLabel.Size = New System.Drawing.Size(170, 37)
        Me.ACIndicatorLabel.TabIndex = 20
        Me.ACIndicatorLabel.Text = "AC Indicator "
        '
        'HeaterIndicatorLabel
        '
        Me.HeaterIndicatorLabel.AutoSize = True
        Me.HeaterIndicatorLabel.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.HeaterIndicatorLabel.Location = New System.Drawing.Point(747, 215)
        Me.HeaterIndicatorLabel.Name = "HeaterIndicatorLabel"
        Me.HeaterIndicatorLabel.Size = New System.Drawing.Size(206, 37)
        Me.HeaterIndicatorLabel.TabIndex = 21
        Me.HeaterIndicatorLabel.Text = "Heater Indicator"
        '
        'ACStatusLabel
        '
        Me.ACStatusLabel.AutoSize = True
        Me.ACStatusLabel.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ACStatusLabel.Location = New System.Drawing.Point(318, 267)
        Me.ACStatusLabel.Name = "ACStatusLabel"
        Me.ACStatusLabel.Size = New System.Drawing.Size(169, 37)
        Me.ACStatusLabel.TabIndex = 15
        Me.ACStatusLabel.Text = "AC on/ off"
        '
        'FanStatusLabel
        '
        Me.FanStatusLabel.AutoSize = True
        Me.FanStatusLabel.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.FanStatusLabel.Location = New System.Drawing.Point(512, 267)
        Me.FanStatusLabel.Name = "FanStatusLabel"
        Me.FanStatusLabel.Size = New System.Drawing.Size(180, 37)
        Me.FanStatusLabel.TabIndex = 14
        Me.FanStatusLabel.Text = "Fan on/ off"
        '
        'PressureStatusLabel
        '
        Me.PressureStatusLabel.AutoSize = True
        Me.PressureStatusLabel.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.PressureStatusLabel.Location = New System.Drawing.Point(515, 304)
        Me.PressureStatusLabel.Name = "PressureStatusLabel"
        Me.PressureStatusLabel.Size = New System.Drawing.Size(254, 33)
        Me.PressureStatusLabel.TabIndex = 13
        Me.PressureStatusLabel.Text = "Pressure System status"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(501, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "System Temp"
        '
        'PressureIndicatorLabel
        '
        Me.PressureIndicatorLabel.AutoSize = True
        Me.PressureIndicatorLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureIndicatorLabel.Location = New System.Drawing.Point(514, 337)
        Me.PressureIndicatorLabel.Name = "PressureIndicatorLabel"
        Me.PressureIndicatorLabel.Size = New System.Drawing.Size(91, 29)
        Me.PressureIndicatorLabel.TabIndex = 59
        Me.PressureIndicatorLabel.Text = "pressure"
        '
        'HVACControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 423)
        Me.Controls.Add(Me.ThermostatGroupBox)
        Me.Controls.Add(Me.SerialSettingsMenuStrip)
        Me.MainMenuStrip = Me.SerialSettingsMenuStrip
        Me.Name = "HVACControllerForm"
        Me.Text = "HVAC Controller"
        Me.SerialSettingsMenuStrip.ResumeLayout(False)
        Me.SerialSettingsMenuStrip.PerformLayout()
        Me.ThermostatGroupBox.ResumeLayout(False)
        Me.ThermostatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialSettingsMenuStrip As MenuStrip
    Friend WithEvents ThermostatGroupBox As GroupBox
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
    Friend WithEvents SetSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetSerialSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectSerialPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectBaudRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPortComboBox As ToolStripComboBox
    Friend WithEvents BaudRateComboBox As ToolStripComboBox
    Friend WithEvents SafetyIndicatorLabel As Label
    Friend WithEvents ConnectLabel As Label
    Friend WithEvents Load2Label As Label
    Friend WithEvents Load1Label As Label
    Friend WithEvents HeTempDownButton As Button
    Friend WithEvents HeTempUpButton As Button
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PressureIndicatorLabel As Label
End Class
