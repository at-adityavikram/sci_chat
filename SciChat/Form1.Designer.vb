<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ChatsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chname = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Mtebox1 = New SciChat.mtebox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChatsPanel
        '
        Me.ChatsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ChatsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChatsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChatsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ChatsPanel.Location = New System.Drawing.Point(304, 100)
        Me.ChatsPanel.Name = "ChatsPanel"
        Me.ChatsPanel.Padding = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.ChatsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChatsPanel.Size = New System.Drawing.Size(426, 603)
        Me.ChatsPanel.TabIndex = 3
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainPanel.Location = New System.Drawing.Point(0, 100)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.MainPanel.Size = New System.Drawing.Size(304, 654)
        Me.MainPanel.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.chname)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 100)
        Me.Panel3.TabIndex = 4
        '
        'chname
        '
        Me.chname.Dock = System.Windows.Forms.DockStyle.Left
        Me.chname.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.chname.FlatAppearance.BorderSize = 0
        Me.chname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.chname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.chname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chname.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.chname.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.chname.Location = New System.Drawing.Point(304, 38)
        Me.chname.Name = "chname"
        Me.chname.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chname.Size = New System.Drawing.Size(180, 62)
        Me.chname.TabIndex = 17
        Me.chname.Text = "Chat Name"
        Me.chname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chname.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 62)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.FlatAppearance.BorderSize = 0
        Me.Label1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 62)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "My Chats"
        Me.Label1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(730, 38)
        Me.Panel5.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SendBtn)
        Me.Panel1.Controls.Add(Me.Mtebox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(304, 703)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 51)
        Me.Panel1.TabIndex = 0
        '
        'SendBtn
        '
        Me.SendBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SendBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SendBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.SendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendBtn.Font = New System.Drawing.Font("Segoe UI", 16.8!)
        Me.SendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SendBtn.Location = New System.Drawing.Point(375, 6)
        Me.SendBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.SendBtn.Size = New System.Drawing.Size(40, 40)
        Me.SendBtn.TabIndex = 20
        Me.SendBtn.Text = "⌲"
        Me.SendBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SendBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(40, 38)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = ""
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(690, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(40, 38)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "✕"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Mtebox1
        '
        Me.Mtebox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mtebox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Mtebox1.Location = New System.Drawing.Point(6, 6)
        Me.Mtebox1.Name = "Mtebox1"
        Me.Mtebox1.Padding = New System.Windows.Forms.Padding(20)
        Me.Mtebox1.Size = New System.Drawing.Size(359, 40)
        Me.Mtebox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 754)
        Me.Controls.Add(Me.ChatsPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChatsPanel As FlowLayoutPanel
    Friend WithEvents MainPanel As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chname As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Mtebox1 As mtebox
    Friend WithEvents SendBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
