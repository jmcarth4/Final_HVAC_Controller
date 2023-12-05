Option Strict On
Option Explicit On

'TODO

'2)Serial port connect and file save - hw graph temp
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

    'Saves set com port and baud rate to file
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

    Sub Load_Port()
        portState = False                              'Disables serial port
        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity
        ' SerialPort1.PortName = 
    End Sub


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

    Sub ClosePort()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try

    End Sub

    'Combo box item select - Selects baud rate when selected 
    Private Sub BaudRateComboBox_Click(sender As Object, e As EventArgs) Handles BaudRateComboBox.Click
        ReadComPorts()
    End Sub

    'Combo box item select - Selects com port when selected
    Private Sub SerialPortComboBox_Click(sender As Object, e As EventArgs) Handles SerialPortComboBox.Click
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



    Private Sub HVACControllerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Form  - Loads form with file and serial port settings
        ' Load_Port()
        portState = False                              'Disables serial port
        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity
        'SerialPort1.PortName = port


        drivePath = CurDir()                            'Generate file to save com port setting
        fileName = drivePath & "\ScopeSettings.txt"     'File found in debug folder of project

        OpenPort()


        BaudRate()                                      'Loads all baud rate to form

        Timer1.Enabled = False                          'Timer disabled
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

    'Shows day and time (saves current time and date in varible 
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DateDisplay()
    End Sub



End Class
