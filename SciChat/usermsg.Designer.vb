<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usermsg
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usermsg))
        Me.msgtxt = New System.Windows.Forms.Label()
        Me.triangle = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'msgtxt
        '
        Me.msgtxt.AutoSize = True
        Me.msgtxt.BackColor = System.Drawing.Color.SteelBlue
        Me.msgtxt.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.msgtxt.ForeColor = System.Drawing.Color.White
        Me.msgtxt.Location = New System.Drawing.Point(3, 0)
        Me.msgtxt.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.msgtxt.MaximumSize = New System.Drawing.Size(250, 0)
        Me.msgtxt.Name = "msgtxt"
        Me.msgtxt.Padding = New System.Windows.Forms.Padding(10)
        Me.msgtxt.Size = New System.Drawing.Size(20, 39)
        Me.msgtxt.TabIndex = 0
        '
        'triangle
        '
        Me.triangle.BackColor = System.Drawing.Color.Transparent
        Me.triangle.BackgroundImage = CType(resources.GetObject("triangle.BackgroundImage"), System.Drawing.Image)
        Me.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.triangle.Location = New System.Drawing.Point(15, 0)
        Me.triangle.Margin = New System.Windows.Forms.Padding(0)
        Me.triangle.Name = "triangle"
        Me.triangle.Size = New System.Drawing.Size(23, 18)
        Me.triangle.TabIndex = 1
        '
        'usermsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.triangle)
        Me.Controls.Add(Me.msgtxt)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "usermsg"
        Me.Size = New System.Drawing.Size(38, 39)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msgtxt As Label
    Friend WithEvents triangle As Panel
End Class
