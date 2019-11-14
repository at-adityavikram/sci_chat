Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Shell32
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp
Imports IWshRuntimeLibrary
Imports Microsoft.Win32
Imports FireSharp.Response

Public Class Form1
    Dim objShell = CreateObject("Shell.Application")
    Declare Function GetUserName Lib "advapi32.dll" Alias _
       "GetUserNameA" (ByVal lpBuffer As String,
       ByRef nSize As Integer) As Integer
    Dim colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
    Dim colorAccent As System.Drawing.Color = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)

    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#95")>
    Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#96")>
    Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#98")>
    Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As UInteger
    End Function

    Private Sub roundthethingy(oj As Object, rad As Integer)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, rad, rad), 180, 90)
        p.AddLine(rad, 0, oj.Width - rad, 0)
        p.AddArc(New Rectangle(oj.Width - rad, 0, rad, rad), -90, 90)
        p.AddLine(oj.Width, rad, oj.Width, oj.Height - rad)
        p.AddArc(New Rectangle(oj.Width - rad, oj.Height - rad, rad, rad), 0, 90)
        p.AddLine(oj.Width - rad, oj.Height, rad, oj.Height)
        p.AddArc(New Rectangle(0, oj.Height - rad, rad, rad), 90, 90)
        p.CloseFigure()
        oj.Region = New Region(p)
    End Sub
    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function

    Dim config As IFirebaseConfig = New FirebaseConfig With {
    .AuthSecret = "Tommy.json",
    .BasePath = "https://scichat-xiscience.firebaseio.com"
}
    Dim client As IFirebaseClient = New FirebaseClient(config)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoginForm.Show()
        LoginForm.TopMost = True
        roundthethingy(Me, 20)
        roundthethingy(SendBtn, 40)
        Dim a As New usermsg

        a.msgtxt.Text = "This is a test message"
        ChatsPanel.Controls.Add(a)

        Dim b As New recievemsg
        b.msgtxt.Text = "This is a test recieved message, also supporst multiline and stuff"
        b.Width = b.msgtxt.Width
        ChatsPanel.Controls.Add(b)
    End Sub

    Private Async Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        If Mtebox1.TextBox1.Text <> "" And Mtebox1.TextBox1.Text <> "Enter message" Then

        End If
    End Sub

End Class
