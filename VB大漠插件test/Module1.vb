﻿Module Module1


    Public dm As Object

    Public hwnd As Object

    Public GGGGG As Object = 1

    Public KeySet As Object

    Public OnSet, kkkk As Object

    Public KeyOn1, KeyOn2 As Object

    Public time1, time2, time3, time4, time5 As String

    Public timerv As Integer = 20

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short
    Public Declare Function GetKeyState Lib "user32" (ByVal vKey As Integer) As Short

    '>>>>>>>>>>>>>>>>>>>>按鍵資料<<<<<<<<<<<<<<<<<<<<'
    Dim strKey() As String = {"None", "Shift", "Ctrl", "Alt", "Space", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}
    Private Const WM_KEYDOWN As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>KeyCode<<<<<<<<<<<<<<<<<<<<'
    Private Function toKeyValue(ByVal KeyCode As String) As Integer
        Dim intKey() As Integer = {0, &H10, &H11, &H12, &H20, &H21, &H2E, &H24, &H23, &H25, &H26, &H27, &H28, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H1B, &H4, &H5, &H6}
        For i = 0 To strKey.Length - 1
            If strKey(i) = KeyCode Then Return intKey(i)
        Next
        Return False
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>熱鍵判定<<<<<<<<<<<<<<<<<<<<'
    Public Function GetKey(ByVal KeyType As String, ByVal KeyCode As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        Dim onoff As String = 0
        Select Case KeyType
            Case "Press"
                If GetAsyncKeyState(code) <> 0 Then
                    Return 1
                End If
                If GetAsyncKeyState(code) = 0 Then
                    Return 0
                End If
            Case Else
                Return 0
        End Select
    End Function

    Public Function GetKeyOff(ByVal KeyCode As String, ByVal vvvKey As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        If vvvKey = 0 Then
            If GetAsyncKeyState(code) <> 0 Then
                Return 0
            End If
        End If

    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp As String
    Dim canoff As String = 0
    Public Function OnOffCheck(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp = 0
                End If

        End Select
        Select Case vvKey
            Case "KeyOn1"
                KeyOn1 = kp
            Case "KeyOn2"
                KeyOn2 = kp
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey.Length - 1
            cbo.Items.Add(strKey(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>僅能輸入數字<<<<<<<<<<<<<<<<<<<<'
    Public Sub OnlyNumber_LA(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57, 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'











End Module
