<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxUsername2 = New System.Windows.Forms.TextBox()
        Me.TextBoxUUID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUsername1 = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRandomSkin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonGetSkin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Minecraft Username: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxUsername2)
        Me.GroupBox1.Controls.Add(Me.TextBoxUUID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information:"
        '
        'TextBoxUsername2
        '
        Me.TextBoxUsername2.Location = New System.Drawing.Point(92, 19)
        Me.TextBoxUsername2.Name = "TextBoxUsername2"
        Me.TextBoxUsername2.ReadOnly = True
        Me.TextBoxUsername2.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxUsername2.TabIndex = 2
        '
        'TextBoxUUID
        '
        Me.TextBoxUUID.Location = New System.Drawing.Point(92, 48)
        Me.TextBoxUUID.Name = "TextBoxUUID"
        Me.TextBoxUUID.ReadOnly = True
        Me.TextBoxUUID.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxUUID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UUID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username: "
        '
        'TextBoxUsername1
        '
        Me.TextBoxUsername1.Location = New System.Drawing.Point(126, 6)
        Me.TextBoxUsername1.Name = "TextBoxUsername1"
        Me.TextBoxUsername1.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxUsername1.TabIndex = 2
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(710, 298)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonInfo
        '
        Me.ButtonInfo.Location = New System.Drawing.Point(629, 298)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInfo.TabIndex = 3
        Me.ButtonInfo.Text = "Info"
        Me.ButtonInfo.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(548, 298)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRandomSkin
        '
        Me.ButtonRandomSkin.Location = New System.Drawing.Point(553, 4)
        Me.ButtonRandomSkin.Name = "ButtonRandomSkin"
        Me.ButtonRandomSkin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRandomSkin.TabIndex = 3
        Me.ButtonRandomSkin.Text = "Random Skin"
        Me.ButtonRandomSkin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(446, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "jtrent238's Skin"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonGetSkin
        '
        Me.ButtonGetSkin.Location = New System.Drawing.Point(365, 4)
        Me.ButtonGetSkin.Name = "ButtonGetSkin"
        Me.ButtonGetSkin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetSkin.TabIndex = 3
        Me.ButtonGetSkin.Text = "Get Skin"
        Me.ButtonGetSkin.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 333)
        Me.Controls.Add(Me.ButtonGetSkin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRandomSkin)
        Me.Controls.Add(Me.ButtonInfo)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.TextBoxUsername1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Minecraft Skin Viewer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxUsername2 As TextBox
    Friend WithEvents TextBoxUUID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUsername1 As TextBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonInfo As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRandomSkin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonGetSkin As Button
End Class
