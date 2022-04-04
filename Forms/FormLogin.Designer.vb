<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(277, 57)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(441, 65)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "ALICE HOSPITAL"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.BackColor = System.Drawing.Color.Transparent
        Me.LabelUser.Font = New System.Drawing.Font("Script MT Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(315, 226)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(109, 29)
        Me.LabelUser.TabIndex = 1
        Me.LabelUser.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(446, 232)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(213, 22)
        Me.TxtUsername.TabIndex = 3
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(446, 281)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(213, 22)
        Me.TxtPass.TabIndex = 4
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(354, 329)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(97, 40)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(475, 329)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(109, 40)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.build1
        Me.ClientSize = New System.Drawing.Size(991, 669)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.LabelJudul)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
End Class
