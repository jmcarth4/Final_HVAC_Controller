Option Strict On
Option Explicit On

'TODO



' set temp 


'7) Pressure


'10) font
'11) indicators ????

Public Class HVACControllerForm
    Dim portState As Boolean                    'Enables serial communication
    Dim receiveByte(18) As Byte                 'Receive Data Bytes
    Public TXdata(3) As Byte                    'Byte array to transmit data to Qy@ board
    Dim newData As Integer                      'Received data
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer  'Processes data in
    Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer
    Dim drivePath As String                     'Path to file
    Dim fileName As String                      'Names file for saved setting
    Dim port As String                          'Set port name
    Dim baud As String                          'Set baud rate
    Dim txCount As Integer
    Dim vOut, Tempstr As String                          'Calculated voltage in for input
    Dim readDigIn As Integer
    Dim currentTemp, systemTemp As Double
    Dim coldSetTemp, heatSetTemp As Double
    Dim safetyLockOn, heatOn, heatOff, acOn, acOff, heating, cooling As Boolean
    Dim logSafetyLock, logFanError As Boolean

    '===========================================================================
    Private Sub Test3Button_Click(sender As Object, e As EventArgs) Handles Test3Button.Click
        DisableUnit()
        Delay()
    End Sub

    Private Sub Test2Button_Click(sender As Object, e As EventArgs) Handles Test2Button.Click
        'Interlock()

    End Sub

    Private Sub Test1Button_Click(sender As Object, e As EventArgs) Handles Test1Button.Click



    End Sub



    'Sub - Pauses program for 5 seconds
    Sub Delay()
        ' Threading.Thread.Sleep(5000)
        TXdata(0) = 32                     'test input  see if read code          
        TXdata(1) = 255
        TXdata(2) = 0
        SendData()
        Threading.Thread.Sleep(1000)
    End Sub

    '==============================================================================


    'TODO 1) file / error report???
    'Sub-
    Sub Heater()

        If HeaterIndicatorLabel.Visible = True Then
            HeaterStatusLabel.Text = "Heater On"
            If heating = True Then
                If heatOn = True Then
                    SetFan()
                    'airpressure
                    'Pressure()

                    heatOn = False

                End If

                HeaterIndicatorLabel.Text = "Heating"
                HeaterIndicatorLabel.BackColor = Color.FromArgb(255, 0, 10)
                'FanIndicatorLabel.BackColor = Color.FromArgb(150, 230, 10)  'no work
                'Turns on fan and heater (2+8)
                TXdata(0) = 32                                 'Command byte 1 for digital outputs
                TXdata(1) = 10                              'Command byte 2 for digital output 1
                TXdata(2) = 0
                SendData()
                heatOff = True
            ElseIf heating = False Then
                HeaterIndicatorLabel.Text = " "
                HeaterIndicatorLabel.BackColor = Color.FromArgb(50, 50, 50)
                If heatOff = True Then
                    SetFan()

                    heatOff = False
                End If
                heatOn = True


            End If


        ElseIf HeaterIndicatorLabel.Visible = False Then
                HeaterStatusLabel.Text = "Heater Off"
            If heatOff = True Then
                SetFan()

                heatOff = False
            End If
            heatOn = True
            End If
    End Sub

    Sub AC()
        If ACIndicatorLabel.Visible = True Then
            ACStatusLabel.Text = "AC On"
            If cooling = True Then
                If acOn = True Then
                    SetFan()
                    'air pressure
                    'Pressure()

                    acOn = False
                End If

                ACIndicatorLabel.Text = "Cooling"
                'Turns on fan and heater (2+8)
                ACIndicatorLabel.BackColor = Color.FromArgb(100, 100, 255)
                'FanIndicatorLabel.BackColor = Color.FromArgb(150, 230, 10)  'no work
                TXdata(0) = 32                                 'Command byte 1 for digital outputs
                TXdata(1) = 12                              'Command byte 2 for digital output 1
                TXdata(2) = 0
                SendData()
                acOff = True

            ElseIf cooling = False Then
                ACIndicatorLabel.Text = " "
                ACIndicatorLabel.BackColor = Color.FromArgb(10, 10, 10)
                If acOff = True Then
                    SetFan()

                    acOff = False
                End If
                acOn = True
            End If



        ElseIf ACIndicatorLabel.Visible = False Then
            ACStatusLabel.Text = "AC Off"
            If acOff = True Then
                SetFan()

                acOff = False
            End If
            acOn = True
        End If
    End Sub

    'Sub -
    Sub FanOnly()
        If FanIndicatorLabel.Visible = True Then
            FanStatusLabel.Text = "Fan On"

            FanIndicatorLabel.Text = "Fanning"
            FanIndicatorLabel.BackColor = Color.FromArgb(150, 230, 10)
            TXdata(0) = 32                                 'Command byte 1 for digital outputs
            TXdata(1) = 8                              'Command byte 2 for digital output 1
            TXdata(2) = 0
            SendData()
        ElseIf FanIndicatorLabel.Visible = False Then
            FanStatusLabel.Text = "Fan Off"
        End If
    End Sub

    'DOTO???FAN ?????????????
    'no indicator????????????????
    'not work well with other programs
    'Sub -
    Sub Pressure()
        '?????? fan stuff
        If PressureIndicatorLabel.Visible = True Then
            PressureStatusLabel.Text = "Reading Pressure "
            Exit Sub
        ElseIf PressureIndicatorLabel.Visible = False Then
            PressureIndicatorLabel.Text = "Error"
            PressureIndicatorLabel.BackColor = Color.FromArgb(190, 50, 190)
            'TXdata(0) = 32                                 'Command byte 1 for digital outputs
            'TXdata(1) = 128                              'Command byte 2 for digital output 1
            'TXdata(2) = 0
            'SendData()

            PressureStatusLabel.Text = "Pressure Error"
            logFanError = True
            FileLog()  'write error to system file when sense (button not pressed)
        End If
    End Sub

    'Sub - 'Disable all functions until interlock is reset
    Sub Interlock()
        If SafetyIndicatorLabel.Visible = True Then
            If safetyLockOn = True Then
                SafetyIndicatorLabel.BackColor = Color.FromArgb(200, 150, 10)
                logSafetyLock = True ' for file stuff
                FileLog()                           'Logs safety lock in system log
                DisableUnit()                       'Disable all functions until interlock is reset
                MsgBox("WARNING!!!!!!! Safety Tripped! All systems disabled")
                logSafetyLock = True ' for file stuff
                safetyLockOn = False
            End If
            SafetyIndicatorLabel.BackColor = Color.FromArgb(200, 150, 10)
            'Displays Safty lock on
            TXdata(0) = 32                              'Command byte 1 for digital outputs
            TXdata(1) = 1                              'Command byte 2 for digital output 1
            TXdata(2) = 0
            SendData()
        ElseIf SafetyIndicatorLabel.Visible = False Then
            safetyLockOn = True
        End If
    End Sub

    Sub ActivateSystem()
        If currentTemp < heatSetTemp + 2 Then  ' Sets heater temperature
            heating = True
        ElseIf currentTemp > heatSetTemp - 2 Then

            heating = False
        End If

        If currentTemp > coldSetTemp + 2 Then
            cooling = True
        ElseIf currentTemp < coldSetTemp - 2 Then 'Sets AC temperature
            cooling = False
        End If

    End Sub




    'Sub - Turns on fan (Digital out 4) adn pauses program for 5 seconds.
    Sub SetFan()
        TXdata(0) = 32                                 'Command byte 1 for digital outputs
        TXdata(1) = 8                              'Command byte 2 for digital output 1
        TXdata(2) = 0
        SendData()
        Threading.Thread.Sleep(1000)    ' set short for working 
    End Sub

    'Sub - Logs error to system file
    Sub FileLog()
        Dim dateStamp As String

        dateStamp = CStr(Now)
        drivePath = CurDir()
        fileName = drivePath & "\HVACSystemLog.txt"

        Try
            FileOpen(2, fileName, OpenMode.Append)                                'Open file for write
        Catch ex As Exception
            MsgBox("File failed to open")
            Exit Sub
        End Try

        If logSafetyLock = True Then
            WriteLine(2, "Interlock Set" & " " & dateStamp) 'Write file
            logSafetyLock = False
        ElseIf logFanError = True Then
            WriteLine(2, "Fan Error" & " " & dateStamp) 'Write file
            logFanError = False
        End If

        FileClose(2)
    End Sub

    Sub DisableUnit()
        HeaterIndicatorLabel.Visible = False
        ACIndicatorLabel.Visible = False
        FanIndicatorLabel.Visible = False
        Timer1.Enabled = False
    End Sub

    Sub FunctionLoad()

        Load1Label.Text = " "
        Load2Label.Text = " "
        Load1Label.BackColor = Color.FromArgb(150, 0, 0)
        Load2Label.BackColor = Color.FromArgb(150, 0, 0)
        ConnectLabel.Text = " "
        ConnectLabel.BackColor = Color.FromArgb(150, 0, 0)
        SafetyIndicatorLabel.Visible = False
        HeaterIndicatorLabel.Visible = False
        ACIndicatorLabel.Visible = False
        FanIndicatorLabel.Visible = False
        PressureIndicatorLabel.Visible = False
        heatSetTemp = 50
        HeatSetTempTextBox.Text = CStr(heatSetTemp) '& Chr(176) & "F"
        coldSetTemp = 90
        ColdSetTempTextBox.Text = CStr(coldSetTemp) ' & Chr(176) & "F"
    End Sub

    Sub DigitalSelect()
        If readDigIn > 128 Then
            readDigIn -= 128
        End If

        If readDigIn > 64 Then
            readDigIn -= 64
        End If
        If readDigIn > 32 Then
            readDigIn -= 32
        End If
        If readDigIn > 16 Then
            ACIndicatorLabel.Visible = False
            readDigIn -= 16
        End If
        If readDigIn > 8 Then
            PressureIndicatorLabel.Visible = False
            readDigIn -= 8
        End If
        If readDigIn > 4 Then
            FanIndicatorLabel.Visible = False
            readDigIn -= 4
        End If
        If readDigIn > 2 Then
            HeaterIndicatorLabel.Visible = False
            readDigIn -= 2
        End If

        If readDigIn > 1 Then
            SafetyIndicatorLabel.Visible = False
            readDigIn -= 1
        End If

    End Sub
    '============================================================================

    'Timer - Draws input in picture box, communicates with the Qy@ board and processes recieved data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        'Calls functions to communicate with Qy@ board, analog input 1 when serial communication is present
        If portState = True Then
            txCount += 1
            If txCount = 1 Then
                'Transmit and receive data from Qy@ analog input 1 
                AnalogIn()
            ElseIf txCount = 2 Then

                AnalogIn()


            ElseIf txCount = 3 Then
                DigitalIn()
                'readDigIn = CInt(RXLabel.Text)
                readDigIn = inPut1 + inPut2 + inPut2 + inPut3 + inPut4 + inPut5 + inPut6 + inPut7 + inPut8
            ElseIf txCount = 4 Then
                DigitalOut()
                txCount = 0
            End If
            'Transmit and receive data from Qy@ analog input 1 

            DigitalSelect()  '??????????????

            Interlock()
            ActivateSystem()
            Heater()
            AC()
            FanOnly()

        End If

        ReceiveData()
    End Sub

    Private Sub HeTempUpButton_Click(sender As Object, e As EventArgs) Handles HeTempUpButton.Click

        If heatSetTemp < 90 Then
            heatSetTemp += 0.5
            HeatSetTempTextBox.Text = CStr(heatSetTemp) '& Chr(176) & "F"
        End If
    End Sub

    Private Sub HeTempDownButton_Click(sender As Object, e As EventArgs) Handles HeTempDownButton.Click
        If heatSetTemp > 50 Then
            heatSetTemp -= 0.5
            HeatSetTempTextBox.Text = CStr(heatSetTemp) ' & Chr(176) & "F"
        End If
    End Sub

    Private Sub ACTempUpButton_Click(sender As Object, e As EventArgs) Handles ACTempUpButton.Click
        If coldSetTemp < 90 Then
            coldSetTemp += 0.5
            ColdSetTempTextBox.Text = CStr(coldSetTemp) ' & Chr(176) & "F"
        End If
    End Sub

    Private Sub ACTempDownButton_Click(sender As Object, e As EventArgs) Handles ACTempDownButton.Click
        If coldSetTemp > 50 Then
            coldSetTemp -= 0.5
            ColdSetTempTextBox.Text = CStr(coldSetTemp) ' & Chr(176) & "F"
        End If
    End Sub


    '======================Sub Routines data to and from Qy@ board===============

    'Sub -  Receive data from serial port - async
    Sub ReceiveData()
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer

        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select
            RXLabel.Text = inPut1 & inPut2 & inPut2 & inPut3 & inPut4 & inPut5 & inPut6 & inPut7 & inPut8
        End If

    End Sub



    'Function - Sends byte array to serial port
    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXdata, 0, 3)                    'Write byte array to serial port
            TXLabel.Text = TXdata(0) & TXdata(1) & TXdata(2)   'Value of byte array displayed for user to see
        Else
            MsgBox("Please configure and open serial port to procede")   'Send user message box if no port connected
        End If
        Timer1.Enabled = True                                   'Enable timer when done
    End Function



    'Sub - Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        SerialPort1.Read(receiveByte, 0, 4)                         'Reads serial buffer value
        Select Case newData                                         'Test case to determine where to place info
            Case = 0
                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)
            Case Else
                newData = 0                                             'Possible over flow, reset newData
                Exit Sub
        End Select
        newData += 1                                                    'Increment newData once loop is complete
    End Sub

    'Sub - Establishs communication and displays received data from Qy@ board, analog input1
    Sub AnalogIn()
        If txCount = 1 Then
            TXdata(0) = 81                          'Send command for analog input 1
            TXdata(1) = 0
            TXdata(2) = 0
            SendData()                              'Calls function to send serial data
            AnVoltage()                             'Calls function to calcuate input voltage and temperature
            AnIn1Label.Text = vOut & " V"             'Display input voltage
            CurrentTempLabel.Text = Tempstr & Chr(176) & "F"
            currentTemp = CInt(Tempstr)
        End If

        If txCount = 2 Then
            TXdata(0) = 82                          'Send command for analog in 2
            TXdata(1) = 0
            TXdata(2) = 0
            SendData()
            AnVoltage()
            AnIn2Label.Text = vOut                    'Display input voltage
            SystemTempLabel.Text = Tempstr & Chr(176) & Chr(70)
            systemTemp = CInt(Tempstr)
        End If
    End Sub

    'Sub - Converts received byte 1 and 2 to binary value (0 to 1024) and voltage (0 to 3.3)
    'Calculates temperature from sensor input (voltage)   
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double
        Dim vTemp As Double             'Sets temperature from received data
        n1 = dataIn1 * 4
        n2 = dataIn2 / 64
        n3 = Fix(n1 + n2)               'Calcuated number of bits recieved
        n4 = 3.3 / 1023
        vPort = n4 * n3                 'Calculated voltage at input
        vTemp = vPort * 100             'Calculates temperature from calculated voltage in (LM34 Temp = Vin * 100)
        vOut = Format(vPort, "n")       'Calculated voltage at input in normal format (x.xx)
        Tempstr = Format(vTemp, "n")
    End Sub

    'Sends command for Digital input and processes received data
    Sub DigitalIn()
        TXdata(0) = 48                               'Command for digital input
        TXdata(1) = 0
        TXdata(2) = 0
        SendData()

        If dataIn1 = 254 Then                        'recived byte for digital input 1
            'DI1CheckBox.Checked = True
            DigIn1Label.Text = "Pressed"
            SafetyIndicatorLabel.Visible = True
        Else
            'DI1CheckBox.Checked = False
            DigIn1Label.Text = "Digital In 1"
            SafetyIndicatorLabel.Visible = False
        End If

        If dataIn1 = 253 Then                         'recived byte for digital input 2
            'DI2CheckBox.Checked = True
            DigIn2Label.Text = "Pressed"
            HeaterIndicatorLabel.Visible = True
        Else
            'DI2CheckBox.Checked = False
            DigIn2Label.Text = "Digital In 2"
            HeaterIndicatorLabel.Visible = False
        End If

        If dataIn1 = 251 Then                          'recived byte for digital input 3
            'DI3CheckBox.Checked = True
            DigIn3Label.Text = "Pressed"
            FanIndicatorLabel.Visible = True
        Else
            'DI3CheckBox.Checked = False
            DigIn3Label.Text = "Digital In 3"
            FanIndicatorLabel.Visible = False
        End If

        If dataIn1 = 247 Then                          'recived byte for digital input 4
            'DI4CheckBox.Checked = True
            DigIn4Label.Text = "Pressed"
            PressureIndicatorLabel.Visible = True
        Else
            'DI4CheckBox.Checked = False
            DigIn4Label.Text = "Digital In 4"
            PressureIndicatorLabel.Visible = False
        End If

        If dataIn1 = 239 Then                          'recived byte for digital input 5
            'DI5CheckBox.Checked = True
            DigIn5Label.Text = "Pressed"
            ACIndicatorLabel.Visible = True
        Else
            'DI5CheckBox.Checked = False
            DigIn5Label.Text = "Digital In 5"
            ACIndicatorLabel.Visible = False
        End If


        If dataIn1 = 223 Then                           'recived byte for digital input 6
            'DI6CheckBox.Checked = True
            DigIn6Label.Text = "Pressed"
        Else
            ' DI6CheckBox.Checked = False
            DigIn6Label.Text = "Digital In 6"
        End If


        If dataIn1 = 191 Then                           'recived byte for digital input 7
            ' DI7CheckBox.Checked = True
            DigIn7Label.Text = "Pressed"
        Else
            ' DI7CheckBox.Checked = False
            DigIn7Label.Text = "Digital In 7"
        End If


        If dataIn1 = 127 Then                           'recived byte for digital input 8
            'DI8CheckBox.Checked = True
            DigIn8Label.Text = "Pressed"
        Else
            'DI8CheckBox.Checked = False
            DigIn8Label.Text = "Digital In 8"
        End If
    End Sub

    'NOT Need......testing only

    'Sends command To active digital outputs
    'Priorty display - highest checked box is output displayed
    Sub DigitalOut()
        If txCount = 4 Then                                'Enables Digital out puts
            TXdata(0) = 32                                 'Command byte 1 for digital outputs
            If DO1CheckBox.Checked = True Then
                TXdata(1) = 1                              'Command byte 2 for digital output 1
                TXdata(2) = 0
            End If

            If DO2CheckBox.Checked = True Then
                TXdata(1) = 2                              'Command byte 2 for digital output 2
                TXdata(2) = 0
            End If

            If DO3CheckBox.Checked = True Then
                TXdata(1) = 4                               'Command byte 2 for digital output 3
                TXdata(2) = 0
            End If

            If DO4CheckBox.Checked = True Then
                TXdata(1) = 8                               'Command byte 2 for digital output 4
                TXdata(2) = 0
            End If

            If DO5CheckBox.Checked = True Then
                TXdata(1) = 16                              'Command byte 2 for digital output 5
                TXdata(2) = 0
            End If

            If DO6CheckBox.Checked = True Then
                TXdata(1) = 32                              'Command byte 2 for digital output 6
                TXdata(2) = 0
            End If

            If DO7CheckBox.Checked = True Then
                TXdata(1) = 64                              'Command byte 2 for digital output 7
                TXdata(2) = 0
            End If

            If DO8CheckBox.Checked = True Then
                TXdata(1) = 128                             'Command byte 2 for digital output 8
                TXdata(2) = 0
            End If

            SendData()                                       'Send command to for digital output
        End If
    End Sub


    ' ====================Sub Routines Set up Serial Port=============================
    ' Sub - Sets current date and time
    Sub DateDisplay()
        Dim dayTemp As Date
        dayTemp = DateTime.Now
        TimeLabel.Text = dayTemp.ToShortTimeString
        DayLabel.Text = dayTemp.ToString("dddd")

        label15.Text = CStr(Now)   'not need
    End Sub

    'Sub - Sets com port and baud rate 
    Sub ReadComPorts()
        portState = False
        Try
            SerialPort1.BaudRate = CInt(SerialPortComboBox.SelectedItem) 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = CStr(SerialPortComboBox.SelectedItem) 'Bot baud rate, save port name
        End Try
    End Sub

    'Sub - Loads and reads com port settings file
    Public Sub Load_setting()
        drivePath = CurDir()
        fileName = drivePath & "\HVACSettings.txt"               'File found in debug folder of project
        Try
            FileOpen(1, fileName, OpenMode.Input)                 'Open file for read
        Catch ex As Exception
            MsgBox("Settings file not found, please go to settings menu") 'Alerts user if no file found
            Exit Sub
        End Try

        Input(1, port)                                              'Load port name
        Input(1, baud)                                              'Load baud rate
        'Input(1, heatSetTemp)                                       'Load low temperature set point
        'Input(1, coldSetTemp)                                       'Load low temperature set point
        FileClose(1)                                                'Closes file

        ComPortLabel.Text = port                                    'Displays com port and baud rate
        BaudRateLabel.Text = baud
        Load2Label.BackColor = Color.FromArgb(0, 150, 0)
        Load1Label.BackColor = Color.FromArgb(0, 150, 0)
    End Sub

    'Sub - Saves set com port and baud rate to file
    Sub Save_Settings()
        Try
            FileOpen(1, fileName, OpenMode.Output)                                'Open file for write
        Catch ex As Exception

        End Try

        WriteLine(1, SerialPortComboBox.SelectedItem, BaudRateComboBox.SelectedItem) 'Write file
        'WriteLine(1, Val(HeatSetTempTextBox.Text), Val(ColdSetTempTextBox.Text))
        FileClose(1)
    End Sub



    'Sub - Set baud rate of com port
    Sub BaudRate()
        BaudRateComboBox.Items.Clear()               'Clear combo box and load baud rate values
        BaudRateComboBox.Items.Add(1200)
        BaudRateComboBox.Items.Add(2400)
        BaudRateComboBox.Items.Add(4800)
        BaudRateComboBox.Items.Add(9600)
        BaudRateComboBox.Items.Add(19200)
        BaudRateComboBox.Items.Add(38400)
        BaudRateComboBox.Items.Add(57600)
        BaudRateComboBox.Items.Add(115200)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(460800)
        BaudRateComboBox.Items.Add(921600)
    End Sub

    'Sub - 
    Sub Load_Port()
        portState = False                              'Disables serial port
        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity
        ' SerialPort1.PortName = 
    End Sub



    'Sub - 
    Sub OpenPort()
        SerialPortComboBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            SerialPortComboBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
        Try
            SerialPort1.Close()                             'Trys to close port before change
        Catch ex As Exception

        End Try
    End Sub

    'Sub - 
    Sub ClosePort()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try

    End Sub


    '=====================Actions to connect serial port =======================================
    'Combo box item select - Selects baud rate when selected 
    Private Sub BaudRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaudRateComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub
    'Combo box item select - Selects com port when selected
    Private Sub SerialPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SerialPortComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub

    'Menu item click - Saves set com port and baud rate to file
    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        Save_Settings()
    End Sub


    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Load_setting()                                      'Reads file
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try
        ConnectSystemToolStripMenuItem.Text = "Connect"
        portState = False

        SerialPort1.BaudRate = CInt(baud)                         'See if baud rate data is in the list box
        SerialPort1.PortName = port
    End Sub


    Private Sub ConnectSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectSystemToolStripMenuItem.Click
        If ConnectSystemToolStripMenuItem.Text = "Connect" Then           'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                ConnectSystemToolStripMenuItem.Text = "Disconnect"        'Displays that com port is connected
                ConnectLabel.Text = "Power"
                ConnectLabel.BackColor = Color.FromArgb(0, 150, 0)
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                ConnectSystemToolStripMenuItem.Text = "Connect"
                ConnectLabel.Text = "No Power"
                ConnectLabel.BackColor = Color.FromArgb(150, 0, 0)
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            ConnectSystemToolStripMenuItem.Text = "Connect"
        End If
    End Sub

    'not use?????
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Load_setting()                                      'Reads file
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try
        ConnectButton.Text = "Connect"
        portState = False

        SerialPort1.BaudRate = CInt(baud)                         'See if baud rate data is in the list box
        SerialPort1.PortName = port                         'Bot baud rate, save port name
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If ConnectButton.Text = "Connect" Then           'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                ConnectButton.Text = "Disconnect"        'Displays that com port is connected
                ConnectLabel.Text = "Power"
                ConnectLabel.BackColor = Color.FromArgb(0, 150, 0)
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                ConnectButton.Text = "Connect"
                ConnectLabel.Text = "No Power"
                ConnectLabel.BackColor = Color.FromArgb(150, 0, 0)
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            ConnectButton.Text = "Connect"
        End If
    End Sub


    '=====================Actions set up form===================================
    'Timer - Shows day and time (saves current time and date in varible 
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DateDisplay()
    End Sub

    Private Sub HVACControllerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Form  - Loads form with file and serial port settings
        Load_Port()



        drivePath = CurDir()                            'Generate file to save com port setting
        fileName = drivePath & "\HVACSettings.txt"     'File found in debug folder of project


        'Loads all baud rate to form
        BaudRate()

        OpenPort()

        FunctionLoad()




        ' Timer1.Enabled = False                          'Timer disabled
        ' AnIn1CheckBox.Checked = False                   'Input disabled


        'DateDisplay()                                       'Loads current date and time
        ' drivePath2 = CurDir()                               'Generate file to save data input
        ' Me.fileName2 = CurDir() & "\TemperatureData" & dateTemp & ".txt" 'File found in project debug file
    End Sub

    'Button - 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Closes serial port
    Private Sub HVACControllerForm_UnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ClosePort()
    End Sub


    '===============================Trouble shooting stuff ========
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
