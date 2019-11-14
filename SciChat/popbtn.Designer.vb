<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popbtn
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
        Me.Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn.Location = New System.Drawing.Point(0, 3)
        Me.Btn.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Btn.Name = "Btn"
        Me.Btn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn.Size = New System.Drawing.Size(295, 41)
        Me.Btn.TabIndex = 1
        Me.Btn.Text = "UserName"
        Me.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn.UseVisualStyleBackColor = False
        '
        'popbtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Btn)
        Me.Name = "popbtn"
        Me.Size = New System.Drawing.Size(295, 47)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn As Button
End Class
