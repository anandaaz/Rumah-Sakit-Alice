<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoRekamMedis
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
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.DGRM = New System.Windows.Forms.DataGridView()
        Me.LbBaris = New System.Windows.Forms.Label()
        CType(Me.DGRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Data Pasien"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(448, 152)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(229, 22)
        Me.TxtCari.TabIndex = 1
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.Location = New System.Drawing.Point(709, 147)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(89, 29)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'DGRM
        '
        Me.DGRM.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRM.Location = New System.Drawing.Point(119, 241)
        Me.DGRM.Name = "DGRM"
        Me.DGRM.RowHeadersWidth = 51
        Me.DGRM.RowTemplate.Height = 24
        Me.DGRM.Size = New System.Drawing.Size(971, 275)
        Me.DGRM.TabIndex = 3
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBaris.Location = New System.Drawing.Point(537, 530)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(178, 21)
        Me.LbBaris.TabIndex = 5
        Me.LbBaris.Text = "Data ke 0 dari 0 data"
        '
        'FormInfoRekamMedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.Palm_leafs_blue_wallpaper_by_HokkaidoCo
        Me.ClientSize = New System.Drawing.Size(1170, 720)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.DGRM)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInfoRekamMedis"
        Me.Text = "FormInfoRekamMedis"
        CType(Me.DGRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents DGRM As DataGridView
    Friend WithEvents LbBaris As Label
End Class
