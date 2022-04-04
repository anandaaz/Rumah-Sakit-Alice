<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoPasien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCariPasien = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.DGPasien = New System.Windows.Forms.DataGridView()
        Me.LbBaris = New System.Windows.Forms.Label()
        CType(Me.DGPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Nama Pasien"
        '
        'TxtCariPasien
        '
        Me.TxtCariPasien.Location = New System.Drawing.Point(336, 132)
        Me.TxtCariPasien.Name = "TxtCariPasien"
        Me.TxtCariPasien.Size = New System.Drawing.Size(200, 22)
        Me.TxtCariPasien.TabIndex = 1
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.Location = New System.Drawing.Point(564, 125)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 37)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'DGPasien
        '
        Me.DGPasien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPasien.Location = New System.Drawing.Point(72, 201)
        Me.DGPasien.Name = "DGPasien"
        Me.DGPasien.RowHeadersWidth = 51
        Me.DGPasien.RowTemplate.Height = 24
        Me.DGPasien.Size = New System.Drawing.Size(734, 258)
        Me.DGPasien.TabIndex = 3
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBaris.Location = New System.Drawing.Point(332, 474)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(178, 21)
        Me.LbBaris.TabIndex = 4
        Me.LbBaris.Text = "Data ke 0 dari 0 data"
        '
        'FormInfoPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.Palm_leafs_blue_wallpaper_by_HokkaidoCo
        Me.ClientSize = New System.Drawing.Size(1035, 633)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.DGPasien)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.TxtCariPasien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInfoPasien"
        Me.Text = "FormInfoPasien"
        CType(Me.DGPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCariPasien As TextBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents DGPasien As DataGridView
    Friend WithEvents LbBaris As Label
End Class
