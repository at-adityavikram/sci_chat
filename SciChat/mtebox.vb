Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Shell32
Imports IWshRuntimeLibrary
Imports Microsoft.Win32
Public Class mtebox
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
    Private Sub Mtebox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundthethingy(Me, 40)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
