Option Strict On
Option Explicit On

'TODO

'DONE ----2)Serial port connect and file save - hw graph temp 
'2.5) Serial setting load automatcally?????? 
'3)talk to qy@ board - hw qy@ board
'4) Heater  - input, outputs, indicators, mode on, timer(s)
'5) AC
'6) fan
'7) Pressure
'8) stop botton
'9) Error file
'10) font
'11) indicators ????

Public Class HVACControllerForm
    Dim portState As Boolean                    'Enables serial communication
    Dim receiveByte(18) As Byte                 'Receive Data Bytes
    Public TXdata(3) As Byte                    'Byte array to transmit data to Qy@ board
    Dim newData As Integer                      'Received data
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer  'Processes data in
    Dim drivePath As String                     'Path to file
    Dim fileName As String                      'Names file for saved setting
    Dim port As String                          'Set port name
    Dim baud As String                          'Set baud rate
    Dim vOut As String                          'Calculated voltage in for input
    Private Sub TempUpButton_Click(sender As Object, e As EventArgs) Handles TempUpButton.Click

    End Sub

    Private Sub TempDownButton_Click(sender As Object, e As EventArgs) Handles TempDownButton.Click

    End Sub

    'Timer - Draws input in picture box, communicates with the Qy@ board and processes recieved data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim dataIn As String
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer

        'Qy@ board, analog input 1 used in place of sensor
        'Enable input from Qy@ board when check box is checked
        If AnIn1CheckBox.Checked = True Then
            'Calls functions to communicate with Qy@ board, analog input 1 when serial communication is present
            If portState = True Then
                'Transmit and receive data from Qy@ analog input 1 
                AnalogIn()

            End If

        End If

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



    'Sub - Establishs communication and displays received data from Qy@ board, analog input1
    Sub AnalogIn()
        TXdata(0) = 81                          'Send command for analog input 1
        TXdata(1) = 0
        TXdata(2) = 0
        SendData()                              'Calls function to send serial data
        AnVoltage()                             'Calls function to calcuate input voltage and temperature
        AnIn1Label.Text = vOut & " V"             'Display input voltage
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

    '-----------------Sub Routines Set up Serial Port-------------------------

    'Sub - Sets current date and time
    Sub DateDisplay()
        Dim timeTemp As String
        Dim dayTemp As Date

        timeTemp = TimeString     'not need?
        dayTemp = DateTime.Now
        TimeLabel.Text = dayTemp.ToShortTimeString
        DayLabel.Text = dayTemp.ToString("dddd")

        Label15.Text = CStr(Now)
        'Label16.Text = CStr(TimeOfDay)
        'Label17.Text = dayTemp.ToShortDateString
        ' Label18.Text = DateTime.Now.ToLongDateString
        'Label19.Text = DateString
        ' Label1.Text = DateTime.Now.ToString("hh:mm:ss:tt")
        'Label2.Text = DateTime.Now.ToString("hh:mm:tt")
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
        fileName = drivePath & "\ScopeSettings.txt"               'File found in debug folder of project
        Try
            FileOpen(1, fileName, OpenMode.Input)                 'Open file for read
        Catch ex As Exception
            MsgBox("Settings file not found, please go to settings menu") 'Alerts user if no file found
            Exit Sub
        End Try

        Input(1, port)                                              'Load port name
        Input(1, baud)                                              'Load baud rate
        FileClose(1)                                                'Closes file

        ComPortLabel.Text = port                                    'Displays com port and baud rate
        BaudRateLabel.Text = baud
    End Sub

    'Sub - Saves set com port and baud rate to file
    Sub Save_Settings()
        Try
            FileOpen(1, fileName, OpenMode.Output)                                'Open file for write
        Catch ex As Exception

        End Try

        WriteLine(1, SerialPortComboBox.SelectedItem, BaudRateComboBox.SelectedItem) 'Write file
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


    '-------------Actions to connect serial port ----------------------------------------------------
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
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                ConnectButton.Text = "Connect"
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


    '-------------Actions set up form-----------------------------
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



        ' Timer1.Enabled = False                          'Timer disabled
        ' AnIn1CheckBox.Checked = False                   'Input disabled


        'DateDisplay()                                       'Loads current date and time
        ' drivePath2 = CurDir()                               'Generate file to save data input
        ' Me.fileName2 = CurDir() & "\TemperatureData" & dateTemp & ".txt" 'File found in project debug file
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Closes serial port
    Private Sub HVACControllerForm_UnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ClosePort()
    End Sub



End Class
