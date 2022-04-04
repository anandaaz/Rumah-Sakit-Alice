<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPasien
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
        Me.LabelNomor = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelJenis = New System.Windows.Forms.Label()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.TxtNomorPasien = New System.Windows.Forms.TextBox()
        Me.TxtNamaPasien = New System.Windows.Forms.TextBox()
        Me.TxtJenisPasien = New System.Windows.Forms.TextBox()
        Me.TxtAlamatPasien = New System.Windows.Forms.TextBox()
        Me.LabelIde = New System.Windows.Forms.Label()
        Me.TxtIDPasien = New System.Windows.Forms.TextBox()
        Me.BtnSavePasien = New System.Windows.Forms.Button()
        Me.BtnHapusPasien = New System.Windows.Forms.Button()
        Me.BtnEditPasien = New System.Windows.Forms.Button()
        Me.BtnTambahPasien = New System.Windows.Forms.Button()
        Me.BtnBatalPasien = New System.Windows.Forms.Button()
        Me.DGPasien = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbBaris = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNoTelp = New System.Windows.Forms.TextBox()
        CType(Me.DGPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(388, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(297, 65)
        Me.LabelJudul.TabIndex = 1
        Me.LabelJudul.Text = "Form Pasien"
        '
        'LabelNomor
        '
        Me.LabelNomor.AutoSize = True
        Me.LabelNomor.BackColor = System.Drawing.Color.Transparent
        Me.LabelNomor.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomor.Location = New System.Drawing.Point(59, 148)
        Me.LabelNomor.Name = "LabelNomor"
        Me.LabelNomor.Size = New System.Drawing.Size(146, 24)
        Me.LabelNomor.TabIndex = 2
        Me.LabelNomor.Text = "Nomor Identitas"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.BackColor = System.Drawing.Color.Transparent
        Me.LabelNama.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(59, 190)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(121, 24)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Nama Pasien"
        '
        'LabelJenis
        '
        Me.LabelJenis.AutoSize = True
        Me.LabelJenis.BackColor = System.Drawing.Color.Transparent
        Me.LabelJenis.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJenis.Location = New System.Drawing.Point(67, 231)
        Me.LabelJenis.Name = "LabelJenis"
        Me.LabelJenis.Size = New System.Drawing.Size(124, 24)
        Me.LabelJenis.TabIndex = 4
        Me.LabelJenis.Text = "Jenis Kelamin"
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.BackColor = System.Drawing.Color.Transparent
        Me.LabelAlamat.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlamat.Location = New System.Drawing.Point(67, 268)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(70, 24)
        Me.LabelAlamat.TabIndex = 5
        Me.LabelAlamat.Text = "Alamat"
        '
        'TxtNomorPasien
        '
        Me.TxtNomorPasien.Location = New System.Drawing.Point(224, 151)
        Me.TxtNomorPasien.Name = "TxtNomorPasien"
        Me.TxtNomorPasien.Size = New System.Drawing.Size(270, 22)
        Me.TxtNomorPasien.TabIndex = 7
        '
        'TxtNamaPasien
        '
        Me.TxtNamaPasien.Location = New System.Drawing.Point(224, 190)
        Me.TxtNamaPasien.Name = "TxtNamaPasien"
        Me.TxtNamaPasien.Size = New System.Drawing.Size(270, 22)
        Me.TxtNamaPasien.TabIndex = 8
        '
        'TxtJenisPasien
        '
        Me.TxtJenisPasien.Location = New System.Drawing.Point(224, 231)
        Me.TxtJenisPasien.Name = "TxtJenisPasien"
        Me.TxtJenisPasien.Size = New System.Drawing.Size(270, 22)
        Me.TxtJenisPasien.TabIndex = 9
        '
        'TxtAlamatPasien
        '
        Me.TxtAlamatPasien.Location = New System.Drawing.Point(224, 268)
        Me.TxtAlamatPasien.Name = "TxtAlamatPasien"
        Me.TxtAlamatPasien.Size = New System.Drawing.Size(270, 22)
        Me.TxtAlamatPasien.TabIndex = 10
        '
        'LabelIde
        '
        Me.LabelIde.AutoSize = True
        Me.LabelIde.BackColor = System.Drawing.Color.Transparent
        Me.LabelIde.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIde.Location = New System.Drawing.Point(59, 113)
        Me.LabelIde.Name = "LabelIde"
        Me.LabelIde.Size = New System.Drawing.Size(116, 24)
        Me.LabelIde.TabIndex = 12
        Me.LabelIde.Text = "ID Identitas"
        '
        'TxtIDPasien
        '
        Me.TxtIDPasien.Location = New System.Drawing.Point(224, 113)
        Me.TxtIDPasien.Name = "TxtIDPasien"
        Me.TxtIDPasien.Size = New System.Drawing.Size(270, 22)
        Me.TxtIDPasien.TabIndex = 13
        '
        'BtnSavePasien
        '
        Me.BtnSavePasien.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.save
        Me.BtnSavePasien.Location = New System.Drawing.Point(363, 351)
        Me.BtnSavePasien.Name = "BtnSavePasien"
        Me.BtnSavePasien.Size = New System.Drawing.Size(145, 49)
        Me.BtnSavePasien.TabIndex = 17
        Me.BtnSavePasien.Text = "Simpan"
        Me.BtnSavePasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSavePasien.UseVisualStyleBackColor = True
        '
        'BtnHapusPasien
        '
        Me.BtnHapusPasien.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusPasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.trash
        Me.BtnHapusPasien.Location = New System.Drawing.Point(295, 406)
        Me.BtnHapusPasien.Name = "BtnHapusPasien"
        Me.BtnHapusPasien.Size = New System.Drawing.Size(145, 49)
        Me.BtnHapusPasien.TabIndex = 16
        Me.BtnHapusPasien.Text = "Hapus"
        Me.BtnHapusPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapusPasien.UseVisualStyleBackColor = True
        '
        'BtnEditPasien
        '
        Me.BtnEditPasien.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditPasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.pencil
        Me.BtnEditPasien.Location = New System.Drawing.Point(199, 351)
        Me.BtnEditPasien.Name = "BtnEditPasien"
        Me.BtnEditPasien.Size = New System.Drawing.Size(148, 49)
        Me.BtnEditPasien.TabIndex = 15
        Me.BtnEditPasien.Text = "Edit"
        Me.BtnEditPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditPasien.UseVisualStyleBackColor = True
        '
        'BtnTambahPasien
        '
        Me.BtnTambahPasien.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahPasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.plus
        Me.BtnTambahPasien.Location = New System.Drawing.Point(32, 348)
        Me.BtnTambahPasien.Name = "BtnTambahPasien"
        Me.BtnTambahPasien.Size = New System.Drawing.Size(148, 49)
        Me.BtnTambahPasien.TabIndex = 14
        Me.BtnTambahPasien.Text = "Tambah"
        Me.BtnTambahPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambahPasien.UseVisualStyleBackColor = True
        '
        'BtnBatalPasien
        '
        Me.BtnBatalPasien.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalPasien.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.close
        Me.BtnBatalPasien.Location = New System.Drawing.Point(120, 406)
        Me.BtnBatalPasien.Name = "BtnBatalPasien"
        Me.BtnBatalPasien.Size = New System.Drawing.Size(145, 49)
        Me.BtnBatalPasien.TabIndex = 22
        Me.BtnBatalPasien.Text = "Batal"
        Me.BtnBatalPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatalPasien.UseVisualStyleBackColor = True
        '
        'DGPasien
        '
        Me.DGPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPasien.Location = New System.Drawing.Point(524, 333)
        Me.DGPasien.Name = "DGPasien"
        Me.DGPasien.RowHeadersWidth = 51
        Me.DGPasien.RowTemplate.Height = 24
        Me.DGPasien.Size = New System.Drawing.Size(497, 271)
        Me.DGPasien.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelJudul)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 71)
        Me.Panel1.TabIndex = 24
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Location = New System.Drawing.Point(732, 307)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(143, 17)
        Me.LbBaris.TabIndex = 35
        Me.LbBaris.Text = "Data ke 0 dari 0 Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nomor Telepon"
        '
        'TxtNoTelp
        '
        Me.TxtNoTelp.Location = New System.Drawing.Point(224, 304)
        Me.TxtNoTelp.Name = "TxtNoTelp"
        Me.TxtNoTelp.Size = New System.Drawing.Size(270, 22)
        Me.TxtNoTelp.TabIndex = 37
        '
        'FormPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.bg_pasien__1_
        Me.ClientSize = New System.Drawing.Size(1034, 614)
        Me.Controls.Add(Me.TxtNoTelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGPasien)
        Me.Controls.Add(Me.BtnBatalPasien)
        Me.Controls.Add(Me.BtnSavePasien)
        Me.Controls.Add(Me.BtnHapusPasien)
        Me.Controls.Add(Me.BtnEditPasien)
        Me.Controls.Add(Me.BtnTambahPasien)
        Me.Controls.Add(Me.TxtIDPasien)
        Me.Controls.Add(Me.LabelIde)
        Me.Controls.Add(Me.TxtAlamatPasien)
        Me.Controls.Add(Me.TxtJenisPasien)
        Me.Controls.Add(Me.TxtNamaPasien)
        Me.Controls.Add(Me.TxtNomorPasien)
        Me.Controls.Add(Me.LabelAlamat)
        Me.Controls.Add(Me.LabelJenis)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelNomor)
        Me.Name = "FormPasien"
        Me.Text = "FormPasien"
        CType(Me.DGPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelNomor As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelJenis As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents TxtNomorPasien As TextBox
    Friend WithEvents TxtNamaPasien As TextBox
    Friend WithEvents TxtJenisPasien As TextBox
    Friend WithEvents TxtAlamatPasien As TextBox
    Friend WithEvents LabelIde As Label
    Friend WithEvents TxtIDPasien As TextBox
    Friend WithEvents BtnTambahPasien As Button
    Friend WithEvents BtnEditPasien As Button
    Friend WithEvents BtnHapusPasien As Button
    Friend WithEvents BtnSavePasien As Button
    Friend WithEvents BtnBatalPasien As Button
    Friend WithEvents DGPasien As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbBaris As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNoTelp As TextBox
End Class
