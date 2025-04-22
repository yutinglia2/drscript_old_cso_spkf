Imports System.Threading
Imports System.Runtime.InteropServices
Public Class ASD

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Call Shell("regsvr32 /s" & Application.StartupPath & "\12asd41.dll", True, 50)
        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /s " & app & "\1.dll")
        ' Dim dm As dmsoft

        Me.TopMost = True

        'MsgBox("啟動程式 自動注冊DLL",, "注冊DLL")

        Try
            '要執行的動作 
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            'Catch ex As System.Net.WebException
            '擷取錯誤並顯示 
            MsgBox("錯誤訊息 ： 自動註冊DLL失敗 " & vbCrLf & "請確保壓縮檔完整解壓在同一資料夾",, "Error")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End

        End Try

        Dim ver
        dm = CreateObject("dm.dmsoft")
        ver = dm.ver()
        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
        Else
            'MsgBox("注意!" & vbCrLf & "本腳本使用低層鍵盤鉤子攔截訊號以實現可移動的極道腳本" & vbCrLf & "並沒有記錄任何鍵盤訊號" & vbCrLf & "如不信任本人請勿使用此腳本" & vbCrLf & "此程式供免費使用" & vbCrLf & "切勿轉售或作任何商業用途", , "成功")
            Form4.Show()
        End If


        Dim RandomText As Integer
        Randomize()
        RandomText = Int((Rnd() * 999999999))
        Me.Text = Str(RandomText)
        dm = CreateObject("dm.dmsoft")
        hwnd = dm.FindWindow("", "Counter-Strike Online")
        dm.SetKeypadDelay("normal", 0)
        dm.SetKeypadDelay("windows", 0)
        dm.SetKeypadDelay("dx", 0)

        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        ' 	退出登录(LogOut) url

        If hwnd = 0 Then

            If GGGGG = 1 Then
            Else
                Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
                '  这里改成自己的参数名称
                parameters.Add("StatusCode", Me._statusCode)
                parameters.Add("UserName", Me._userName)
                If (WebPost.ApiPost(url, parameters) = "1") Then
                    ' 退出成功,清除本地状态码
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                Else
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                End If
            End If

            MsgBox("CSO未開啟 !!")
            'MsgBox("程式關閉 反注冊DLL完成",, "反注冊DLL")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End

        End If

        Me.Enabled = True
        dm.BindWindow(hwnd, "normal", "normal", "windows", 4)

        Me.TopMost = False

        Me.CenterToScreen()

        Show()

        dm.SetWindowState(hwnd, 5)

        'AddKeyItem_LA(Key1)

        Thread1.Start()
        Thread2.Start()

        Key1.SelectedIndex = 0

        Text = System.Guid.NewGuid.ToString("N")

        Dim name1 = Process.GetCurrentProcess().MainModule.FileName
        Rename(name1, Text & ".exe")

    End Sub

    Dim _statusCode As String
    Dim _userName As String
    Dim checkStatus As Timer
    Dim upDateTime As Date

    Public Sub New(ByVal code As String, ByVal userName As String)
        Me._statusCode = code
        Me._userName = userName
        Me.upDateTime = DateTime.Now
        Me.InitializeComponent()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If GGGGG = 1 Then
        Else
            Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
            ' 	退出登录(LogOut) url
            Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
            '  这里改成自己的参数名称
            parameters.Add("StatusCode", Me._statusCode)
            parameters.Add("UserName", Me._userName)
            If (WebPost.ApiPost(url, parameters) = "1") Then
                ' 退出成功,清除本地状态码
                OperateIniFile.WriteIniData("root", "code", "", "config.ini")
            End If
        End If

        dm.SetWindowState(hwnd, 9)
        dm.SetWindowState(hwnd, 2)
        dm.SetWindowState(hwnd, 9)
        dm.UnBindWindow()

        Me.TopMost = True

        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /u /s " & app & "\1.dll")

        'MsgBox("反注冊DLL完成",, "反注冊DLL")

        End

    End Sub





    '>>>>>>>>>>>>>>>>>>>>KeyPress<<<<<<<<<<<<<<<<<<<<'
    Private Sub Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Key1.KeyPress
        e.Handled = True
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    Dim kkon1 As Boolean = False

    '>>>>>>>>>>>>>>>>>>>>熱鍵<<<<<<<<<<<<<<<<<<<<'
    Private Sub HotKeyPress_Tick(sender As Object, e As EventArgs) Handles HotKeyPress.Tick
        kkon1 = False
        'OnOffCheck("Press", Key1.Text, "KeyOn1")

        If rdb1.Checked Then
            If Key1.Text = "滑鼠側鍵2" Then
                kkon1 = GetAsyncKeyState(Keys.XButton2)
            ElseIf Key1.Text = "滑鼠側鍵1" Then
                kkon1 = GetAsyncKeyState(Keys.XButton1)
            ElseIf Key1.Text = "滑鼠中鍵" Then
                kkon1 = GetAsyncKeyState(Keys.MButton)
            ElseIf Key1.Text = "T" Then
                kkon1 = GetAsyncKeyState(Keys.T)
            ElseIf Key1.Text = "B" Then
                kkon1 = GetAsyncKeyState(Keys.B)
            ElseIf Key1.Text = "V" Then
                kkon1 = GetAsyncKeyState(Keys.V)
            End If
        ElseIf rdb2.Checked Then
            If Key1.Text = "滑鼠側鍵2" Then
                kkon1 = GetKeyState(Keys.XButton2)
            ElseIf Key1.Text = "滑鼠側鍵1" Then
                kkon1 = GetKeyState(Keys.XButton1)
            ElseIf Key1.Text = "滑鼠中鍵" Then
                kkon1 = GetKeyState(Keys.MButton)
            ElseIf Key1.Text = "T" Then
                kkon1 = GetKeyState(Keys.T)
            ElseIf Key1.Text = "B" Then
                kkon1 = GetKeyState(Keys.B)
            ElseIf Key1.Text = "V" Then
                kkon1 = GetKeyState(Keys.V)
            End If
        End If


        time1 = txttm1.Text
        time2 = txttm2.Text
        time3 = txttm3.Text
        time4 = txttm4.Text
        time5 = txttm5.Text

    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>OnlyNumber<<<<<<<<<<<<<<<<<<<<'
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttm1.KeyPress, txttm2.KeyPress, txttm3.KeyPress, txttm4.KeyPress, txttm5.KeyPress
        OnlyNumber_LA(e)
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    Dim kkk As Integer = 0

    Dim Thread1 As New Thread(AddressOf aa)
    Sub aa()
aa:
        If rdbm1.Checked Then
            If kkon1 = True Then

                dm.LeftDown
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time1)
                dm.KeyUpChar("j")
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time2)
                dm.KeyUpChar("j")
                kkk = 1
                kkkk(1)
                dm.LeftUp
                Threading.Thread.Sleep(time3)
                kkk = 2
                Threading.Thread.Sleep(time4)
                kkk = 0
                kkkk(0)
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                Threading.Thread.Sleep(time5)

                GoTo aa
            Else
                kkk = 3
            End If
        End If

        If rdbm2.Checked Then
            kkk = 0
            If kkon1 = True Then
                dm.LeftDown
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time1)
                dm.KeyUpChar("j")
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time2)
                dm.KeyUpChar("j")
                kkk = 1
                kkkk(1)
                dm.LeftUp
                Threading.Thread.Sleep(time3)
                kkk = 2
                Threading.Thread.Sleep(time4)
                kkk = 0
                kkkk(0)
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                Threading.Thread.Sleep(time5)

                GoTo aa
            End If
        End If

        If rdbm3.Checked Then
            kkk = 0
            If kkon1 = True Then
                dm.LeftDown
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time1)
                dm.KeyUpChar("j")
                dm.KeyDownChar("j")
                Threading.Thread.Sleep(time2)
                dm.KeyUpChar("j")
                kkk = 1
                dm.LeftUp
                Threading.Thread.Sleep(time3)
                kkk = 2
                Threading.Thread.Sleep(time4)
                kkk = 0
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                dm.KeyDownChar("3")
                Threading.Thread.Sleep(10)
                dm.KeyUpChar("3")
                Threading.Thread.Sleep(time5)

                GoTo aa
            End If
        End If

        Threading.Thread.Sleep(100)
        GoTo aa

    End Sub


    Dim Thread2 As New Thread(AddressOf bb)
    Sub bb()
aa:
        If rdbm1.Checked Then
            If kkk <> 3 Then
                If GetAsyncKeyState(Keys.W) <> 0 And kkk = 0 Then
                    dm.KeyDownChar("w")
                ElseIf GetAsyncKeyState(Keys.W) <> 0 And kkk = 1 Then
                    dm.KeyUpChar("w")
                    dm.KeyDownChar("s")
                Else
                    dm.KeyUpChar("w")
                End If

                If GetAsyncKeyState(Keys.A) <> 0 And kkk = 0 Then
                    dm.KeyDownChar("a")
                ElseIf GetAsyncKeyState(Keys.A) <> 0 And kkk = 1 Then
                    dm.KeyUpChar("a")
                    dm.KeyDownChar("d")
                Else
                    dm.KeyUpChar("a")
                End If

                If GetAsyncKeyState(Keys.S) <> 0 And kkk = 0 Then
                    dm.KeyDownChar("s")
                ElseIf GetAsyncKeyState(Keys.S) <> 0 And kkk = 1 Then
                    dm.KeyUpChar("s")
                    dm.KeyDownChar("w")
                Else
                    dm.KeyUpChar("s")
                End If

                If GetAsyncKeyState(Keys.D) <> 0 And kkk = 0 Then
                    dm.KeyDownChar("d")
                ElseIf GetAsyncKeyState(Keys.D) <> 0 And kkk = 1 Then
                    dm.KeyUpChar("d")
                    dm.KeyDownChar("a")
                Else
                    dm.KeyUpChar("d")
                End If

                GoTo aa
            Else
                Threading.Thread.Sleep(10)
                GoTo aa
            End If
        End If


        If rdbm2.Checked Then

            If GetAsyncKeyState(Keys.W) <> 0 And kkk = 0 Then
                dm.KeyDownChar("w")
            ElseIf GetAsyncKeyState(Keys.W) <> 0 And kkk = 1 Then
                dm.KeyUpChar("w")
                dm.KeyDownChar("s")
            Else
                dm.KeyUpChar("w")
            End If

            If GetAsyncKeyState(Keys.A) <> 0 And kkk = 0 Then
                dm.KeyDownChar("a")
            ElseIf GetAsyncKeyState(Keys.A) <> 0 And kkk = 1 Then
                dm.KeyUpChar("a")
                dm.KeyDownChar("d")
            Else
                dm.KeyUpChar("a")
            End If

            If GetAsyncKeyState(Keys.S) <> 0 And kkk = 0 Then
                dm.KeyDownChar("s")
            ElseIf GetAsyncKeyState(Keys.S) <> 0 And kkk = 1 Then
                dm.KeyUpChar("s")
                dm.KeyDownChar("w")
            Else
                dm.KeyUpChar("s")
            End If

            If GetAsyncKeyState(Keys.D) <> 0 And kkk = 0 Then
                dm.KeyDownChar("d")
            ElseIf GetAsyncKeyState(Keys.D) <> 0 And kkk = 1 Then
                dm.KeyUpChar("d")
                dm.KeyDownChar("a")
            Else
                dm.KeyUpChar("d")
            End If

            GoTo aa

        End If

        If rdbm3.Checked Then

            If GetAsyncKeyState(Keys.W) <> 0 And kkk = 0 Then
                dm.KeyDown(38)
            ElseIf GetAsyncKeyState(Keys.W) <> 0 And kkk = 1 Then
                dm.KeyUp(38)
                dm.KeyDown(40)
            Else
                dm.KeyUp(38)
            End If

            If GetAsyncKeyState(Keys.A) <> 0 And kkk = 0 Then
                dm.KeyDown(37)
            ElseIf GetAsyncKeyState(Keys.A) <> 0 And kkk = 1 Then
                dm.KeyUp(37)
                dm.KeyDown(39)
            Else
                dm.KeyUp(37)
            End If

            If GetAsyncKeyState(Keys.S) <> 0 And kkk = 0 Then
                dm.KeyDown(40)
            ElseIf GetAsyncKeyState(Keys.S) <> 0 And kkk = 1 Then
                dm.KeyUp(40)
                dm.KeyDown(38)
            Else
                dm.KeyUp(40)
            End If

            If GetAsyncKeyState(Keys.D) <> 0 And kkk = 0 Then
                dm.KeyDown(39)
            ElseIf GetAsyncKeyState(Keys.D) <> 0 And kkk = 1 Then
                dm.KeyUp(39)
                dm.KeyDown(37)
            Else
                dm.KeyUp(39)
            End If

            GoTo aa

        End If

    End Sub


    Private Declare Unicode Function SetWindowsHookExW Lib "user32.dll" (ByVal idHook As Integer, ByVal lpfn As HOOKPROCDelegate, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    Private Declare Unicode Function CallNextHookEx Lib "user32.dll" (ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Private Delegate Function HOOKPROCDelegate(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
    Private Declare Unicode Function GetModuleHandleW Lib "kernel32.dll" (ByVal lpModuleName As IntPtr) As IntPtr
    Private Declare Unicode Function UnhookWindowsHookEx Lib "user32.dll" (ByVal hhk As IntPtr) As UInteger
    Private HookProc As New HOOKPROCDelegate(AddressOf KeyboardHookProc)
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Int32 = &H100
    Private Const WM_KEYUP As Int32 = &H101
    Private Const HC_ACTION As Integer = 0
    Private Const KEYEVENTF_KEYUP = &H2
    Private PrevWndProc As Integer
    Private mHandle As IntPtr
    <StructLayout(LayoutKind.Sequential)> Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Keys
        Public scanCode, flags, time, dwExtraInfo As UInteger
        Public Sub New(ByVal key As Keys, ByVal scancod As UInteger, ByVal flagss As UInteger, ByVal zeit As UInteger, ByVal extra As UInteger)
            vkCode = key
            scanCode = scancod
            flags = flagss
            time = zeit
            dwExtraInfo = extra
        End Sub
    End Structure
    'Hook Ein/Ausschalten
    Private Property KeyHookEnable() As Boolean
        Get
            Return mHandle <> IntPtr.Zero
        End Get
        Set(ByVal value As Boolean)
            If KeyHookEnable = value Then Return
            If value Then
                mHandle = SetWindowsHookExW(WH_KEYBOARD_LL, HookProc,
                  GetModuleHandleW(IntPtr.Zero), 0)
            Else
                UnhookWindowsHookEx(mHandle)
                mHandle = IntPtr.Zero
            End If
        End Set
    End Property
    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
        Dim fEatKeyStroke As Boolean
        If nCode = HC_ACTION Then
            Select Case lParam.vkCode
                'Hier wird die Taste vor dem Betriebssystem abgefangen und "untergeschluckt"
                'Alt Taste wird abgefangen...
                Case Keys.W, Keys.A, Keys.S, Keys.D
                    '...und in den Müll geschmissen :P
                    fEatKeyStroke = True

            End Select
            If fEatKeyStroke Then
                Return New IntPtr(1)
                Exit Function
            End If
            Return CallNextHookEx(mHandle, nCode, wParam, lParam)
        End If
    End Function

    Function kkkk(ByVal a As Integer)
        If a = 1 Then
            dm.KeyDownChar("shift")
            KeyHookEnable = True
            dm.KeyUpChar("w")
            dm.KeyUpChar("a")
            dm.KeyUpChar("s")
            dm.KeyUpChar("d")
            dm.KeyUpChar("shift")
        Else
            KeyHookEnable = False
        End If
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txttm1.Text = 150
        txttm2.Text = 530
        txttm3.Text = 10
        txttm4.Text = 50
        txttm5.Text = 50

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Dim jj

End Class
