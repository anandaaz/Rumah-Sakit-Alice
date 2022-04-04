<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliklinikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekamMedisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnPasien = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCariRM = New System.Windows.Forms.Button()
        Me.BtnRM = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DokterToolStripMenuItem, Me.PasienToolStripMenuItem, Me.PoliklinikToolStripMenuItem, Me.ObatToolStripMenuItem, Me.RekamMedisToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1195, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.DokterToolStripMenuItem.Text = "Dokter"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'PoliklinikToolStripMenuItem
        '
        Me.PoliklinikToolStripMenuItem.Name = "PoliklinikToolStripMenuItem"
        Me.PoliklinikToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.PoliklinikToolStripMenuItem.Text = "Poliklinik"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'RekamMedisToolStripMenuItem
        '
        Me.RekamMedisToolStripMenuItem.Name = "RekamMedisToolStripMenuItem"
        Me.RekamMedisToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.RekamMedisToolStripMenuItem.Text = "Rekam Medis"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BtnCari)
        Me.Panel1.Controls.Add(Me.BtnPasien)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 64)
        Me.Panel1.TabIndex = 1
        '
        'BtnCari
        '
        Me.BtnCari.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCari.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.search
        Me.BtnCari.Location = New System.Drawing.Point(107, 0)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 61)
        Me.BtnCari.TabIndex = 1
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'BtnPasien
        '
        Me.BtnPasien.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnPasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.btnPasien
        Me.BtnPasien.Location = New System.Drawing.Point(26, 0)
        Me.BtnPasien.Name = "BtnPasien"
        Me.BtnPasien.Size = New System.Drawing.Size(75, 61)
        Me.BtnPasien.TabIndex = 0
        Me.BtnPasien.Text = "Pasien"
        Me.BtnPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPasien.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.BtnCariRM)
        Me.Panel2.Controls.Add(Me.BtnRM)
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 103)
        Me.Panel2.TabIndex = 2
        '
        'BtnCariRM
        '
        Me.BtnCariRM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCariRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.search
        Me.BtnCariRM.Location = New System.Drawing.Point(136, 1)
        Me.BtnCariRM.Name = "BtnCariRM"
        Me.BtnCariRM.Size = New System.Drawing.Size(84, 99)
        Me.BtnCariRM.TabIndex = 1
        Me.BtnCariRM.Text = "Cari"
        Me.BtnCariRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCariRM.UseVisualStyleBackColor = False
        '
        'BtnRM
        '
        Me.BtnRM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.btnRekam
        Me.BtnRM.Location = New System.Drawing.Point(26, 0)
        Me.BtnRM.Name = "BtnRM"
        Me.BtnRM.Size = New System.Drawing.Size(104, 100)
        Me.BtnRM.TabIndex = 0
        Me.BtnRM.Text = "Rekam Medis"
        Me.BtnRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRM.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat Datang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ALICE HOSPITAL"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.Palm_leafs_blue_wallpaper_by_HokkaidoCo
        Me.ClientSize = New System.Drawing.Size(1195, 716)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoliklinikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RekamMedisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnPasien As Button
    Friend WithEvents BtnCari As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCariRM As Button
    Friend WithEvents BtnRM As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
