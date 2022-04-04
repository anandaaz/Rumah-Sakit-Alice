<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRekamMedis
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNamaPasien = New System.Windows.Forms.TextBox()
        Me.TxtKeluhan = New System.Windows.Forms.TextBox()
        Me.TxtDokter = New System.Windows.Forms.TextBox()
        Me.TxtDiagnosa = New System.Windows.Forms.TextBox()
        Me.TxtNamaPoli = New System.Windows.Forms.TextBox()
        Me.DGRM = New System.Windows.Forms.DataGridView()
        Me.BtnBatalRM = New System.Windows.Forms.Button()
        Me.BtnSaveRM = New System.Windows.Forms.Button()
        Me.BtnHapusRM = New System.Windows.Forms.Button()
        Me.BtnEditRM = New System.Windows.Forms.Button()
        Me.BtnTambahRM = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbBaris = New System.Windows.Forms.Label()
        Me.CBDokter = New System.Windows.Forms.ComboBox()
        Me.CBPoli = New System.Windows.Forms.ComboBox()
        Me.TxtIDPasien = New System.Windows.Forms.TextBox()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.DGRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(358, 8)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(460, 65)
        Me.LabelJudul.TabIndex = 5
        Me.LabelJudul.Text = "Form Rekam Medis"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelJudul)
        Me.Panel1.Location = New System.Drawing.Point(1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 79)
        Me.Panel1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ID Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(532, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Diagnosa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(532, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Nama Poli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(532, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Tanggal Periksa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(721, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 24)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Nama Pasien"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(721, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Keluhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(721, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Dokter"
        '
        'TxtNamaPasien
        '
        Me.TxtNamaPasien.Location = New System.Drawing.Point(848, 105)
        Me.TxtNamaPasien.Name = "TxtNamaPasien"
        Me.TxtNamaPasien.Size = New System.Drawing.Size(251, 22)
        Me.TxtNamaPasien.TabIndex = 56
        '
        'TxtKeluhan
        '
        Me.TxtKeluhan.Location = New System.Drawing.Point(848, 146)
        Me.TxtKeluhan.Name = "TxtKeluhan"
        Me.TxtKeluhan.Size = New System.Drawing.Size(251, 22)
        Me.TxtKeluhan.TabIndex = 57
        '
        'TxtDokter
        '
        Me.TxtDokter.Location = New System.Drawing.Point(848, 186)
        Me.TxtDokter.Name = "TxtDokter"
        Me.TxtDokter.Size = New System.Drawing.Size(251, 22)
        Me.TxtDokter.TabIndex = 58
        '
        'TxtDiagnosa
        '
        Me.TxtDiagnosa.Location = New System.Drawing.Point(705, 251)
        Me.TxtDiagnosa.Name = "TxtDiagnosa"
        Me.TxtDiagnosa.Size = New System.Drawing.Size(187, 22)
        Me.TxtDiagnosa.TabIndex = 59
        '
        'TxtNamaPoli
        '
        Me.TxtNamaPoli.Location = New System.Drawing.Point(705, 290)
        Me.TxtNamaPoli.Name = "TxtNamaPoli"
        Me.TxtNamaPoli.Size = New System.Drawing.Size(187, 22)
        Me.TxtNamaPoli.TabIndex = 60
        '
        'DGRM
        '
        Me.DGRM.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRM.Location = New System.Drawing.Point(552, 419)
        Me.DGRM.Name = "DGRM"
        Me.DGRM.RowHeadersWidth = 51
        Me.DGRM.RowTemplate.Height = 24
        Me.DGRM.Size = New System.Drawing.Size(561, 290)
        Me.DGRM.TabIndex = 62
        '
        'BtnBatalRM
        '
        Me.BtnBatalRM.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.close
        Me.BtnBatalRM.Location = New System.Drawing.Point(848, 366)
        Me.BtnBatalRM.Name = "BtnBatalRM"
        Me.BtnBatalRM.Size = New System.Drawing.Size(125, 47)
        Me.BtnBatalRM.TabIndex = 67
        Me.BtnBatalRM.Text = "Batal"
        Me.BtnBatalRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatalRM.UseVisualStyleBackColor = True
        '
        'BtnSaveRM
        '
        Me.BtnSaveRM.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.save
        Me.BtnSaveRM.Location = New System.Drawing.Point(705, 366)
        Me.BtnSaveRM.Name = "BtnSaveRM"
        Me.BtnSaveRM.Size = New System.Drawing.Size(137, 47)
        Me.BtnSaveRM.TabIndex = 66
        Me.BtnSaveRM.Text = "Simpan"
        Me.BtnSaveRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSaveRM.UseVisualStyleBackColor = True
        '
        'BtnHapusRM
        '
        Me.BtnHapusRM.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.trash
        Me.BtnHapusRM.Location = New System.Drawing.Point(979, 364)
        Me.BtnHapusRM.Name = "BtnHapusRM"
        Me.BtnHapusRM.Size = New System.Drawing.Size(134, 49)
        Me.BtnHapusRM.TabIndex = 65
        Me.BtnHapusRM.Text = "Hapus"
        Me.BtnHapusRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapusRM.UseVisualStyleBackColor = True
        '
        'BtnEditRM
        '
        Me.BtnEditRM.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.pencil
        Me.BtnEditRM.Location = New System.Drawing.Point(579, 366)
        Me.BtnEditRM.Name = "BtnEditRM"
        Me.BtnEditRM.Size = New System.Drawing.Size(120, 47)
        Me.BtnEditRM.TabIndex = 64
        Me.BtnEditRM.Text = "Edit"
        Me.BtnEditRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditRM.UseVisualStyleBackColor = True
        '
        'BtnTambahRM
        '
        Me.BtnTambahRM.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahRM.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.plus
        Me.BtnTambahRM.Location = New System.Drawing.Point(432, 366)
        Me.BtnTambahRM.Name = "BtnTambahRM"
        Me.BtnTambahRM.Size = New System.Drawing.Size(141, 47)
        Me.BtnTambahRM.TabIndex = 63
        Me.BtnTambahRM.Text = "Tambah"
        Me.BtnTambahRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambahRM.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "ID Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "ID Poli"
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Location = New System.Drawing.Point(794, 712)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(141, 17)
        Me.LbBaris.TabIndex = 75
        Me.LbBaris.Text = "Data ke 0 dari 0 data"
        '
        'CBDokter
        '
        Me.CBDokter.FormattingEnabled = True
        Me.CBDokter.Location = New System.Drawing.Point(579, 144)
        Me.CBDokter.Name = "CBDokter"
        Me.CBDokter.Size = New System.Drawing.Size(121, 24)
        Me.CBDokter.TabIndex = 77
        '
        'CBPoli
        '
        Me.CBPoli.FormattingEnabled = True
        Me.CBPoli.Location = New System.Drawing.Point(579, 182)
        Me.CBPoli.Name = "CBPoli"
        Me.CBPoli.Size = New System.Drawing.Size(121, 24)
        Me.CBPoli.TabIndex = 78
        '
        'TxtIDPasien
        '
        Me.TxtIDPasien.Location = New System.Drawing.Point(579, 104)
        Me.TxtIDPasien.Name = "TxtIDPasien"
        Me.TxtIDPasien.Size = New System.Drawing.Size(121, 22)
        Me.TxtIDPasien.TabIndex = 79
        '
        'DateTime
        '
        Me.DateTime.Location = New System.Drawing.Point(705, 324)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(200, 22)
        Me.DateTime.TabIndex = 80
        '
        'FormRekamMedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.background__1_
        Me.ClientSize = New System.Drawing.Size(1117, 736)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.TxtIDPasien)
        Me.Controls.Add(Me.CBPoli)
        Me.Controls.Add(Me.CBDokter)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBatalRM)
        Me.Controls.Add(Me.BtnSaveRM)
        Me.Controls.Add(Me.BtnHapusRM)
        Me.Controls.Add(Me.BtnEditRM)
        Me.Controls.Add(Me.BtnTambahRM)
        Me.Controls.Add(Me.DGRM)
        Me.Controls.Add(Me.TxtNamaPoli)
        Me.Controls.Add(Me.TxtDiagnosa)
        Me.Controls.Add(Me.TxtDokter)
        Me.Controls.Add(Me.TxtKeluhan)
        Me.Controls.Add(Me.TxtNamaPasien)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRekamMedis"
        Me.Text = "FormRekamMedis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNamaPasien As TextBox
    Friend WithEvents TxtKeluhan As TextBox
    Friend WithEvents TxtDokter As TextBox
    Friend WithEvents TxtDiagnosa As TextBox
    Friend WithEvents TxtNamaPoli As TextBox
    Friend WithEvents DGRM As DataGridView
    Friend WithEvents BtnBatalRM As Button
    Friend WithEvents BtnSaveRM As Button
    Friend WithEvents BtnHapusRM As Button
    Friend WithEvents BtnEditRM As Button
    Friend WithEvents BtnTambahRM As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LbBaris As Label
    Friend WithEvents CBDokter As ComboBox
    Friend WithEvents CBPoli As ComboBox
    Friend WithEvents TxtIDPasien As TextBox
    Friend WithEvents DateTime As DateTimePicker
End Class
