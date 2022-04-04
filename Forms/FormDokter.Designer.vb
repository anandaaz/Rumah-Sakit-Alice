<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDokter
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
        Me.LabelIde = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelSpesialis = New System.Windows.Forms.Label()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.TxtIDDokter = New System.Windows.Forms.TextBox()
        Me.TxtNamaDokter = New System.Windows.Forms.TextBox()
        Me.TxtSpesialis = New System.Windows.Forms.TextBox()
        Me.TxtAlamatDokter = New System.Windows.Forms.TextBox()
        Me.Labelcari = New System.Windows.Forms.Label()
        Me.TxtCariDokter = New System.Windows.Forms.TextBox()
        Me.BtnCariDokter = New System.Windows.Forms.Button()
        Me.BtnSaveDokter = New System.Windows.Forms.Button()
        Me.BtnHapusDokter = New System.Windows.Forms.Button()
        Me.BtnEditDokter = New System.Windows.Forms.Button()
        Me.BtnTambahDokter = New System.Windows.Forms.Button()
        Me.BtnBatalDokter = New System.Windows.Forms.Button()
        Me.DGDokterAlice = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbBaris = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNoTelpon = New System.Windows.Forms.TextBox()
        CType(Me.DGDokterAlice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(382, 4)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(311, 65)
        Me.LabelJudul.TabIndex = 2
        Me.LabelJudul.Text = "Form Dokter"
        '
        'LabelIde
        '
        Me.LabelIde.AutoSize = True
        Me.LabelIde.BackColor = System.Drawing.Color.Transparent
        Me.LabelIde.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIde.Location = New System.Drawing.Point(75, 107)
        Me.LabelIde.Name = "LabelIde"
        Me.LabelIde.Size = New System.Drawing.Size(96, 24)
        Me.LabelIde.TabIndex = 13
        Me.LabelIde.Text = "ID Dokter"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.BackColor = System.Drawing.Color.Transparent
        Me.LabelNama.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(73, 142)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(121, 24)
        Me.LabelNama.TabIndex = 14
        Me.LabelNama.Text = "Nama Dokter"
        '
        'LabelSpesialis
        '
        Me.LabelSpesialis.AutoSize = True
        Me.LabelSpesialis.BackColor = System.Drawing.Color.Transparent
        Me.LabelSpesialis.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpesialis.Location = New System.Drawing.Point(75, 179)
        Me.LabelSpesialis.Name = "LabelSpesialis"
        Me.LabelSpesialis.Size = New System.Drawing.Size(81, 24)
        Me.LabelSpesialis.TabIndex = 15
        Me.LabelSpesialis.Text = "Spesialis"
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.BackColor = System.Drawing.Color.Transparent
        Me.LabelAlamat.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlamat.Location = New System.Drawing.Point(75, 219)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(70, 24)
        Me.LabelAlamat.TabIndex = 16
        Me.LabelAlamat.Text = "Alamat"
        '
        'TxtIDDokter
        '
        Me.TxtIDDokter.Location = New System.Drawing.Point(216, 110)
        Me.TxtIDDokter.Name = "TxtIDDokter"
        Me.TxtIDDokter.Size = New System.Drawing.Size(295, 22)
        Me.TxtIDDokter.TabIndex = 18
        '
        'TxtNamaDokter
        '
        Me.TxtNamaDokter.Location = New System.Drawing.Point(216, 145)
        Me.TxtNamaDokter.Name = "TxtNamaDokter"
        Me.TxtNamaDokter.Size = New System.Drawing.Size(295, 22)
        Me.TxtNamaDokter.TabIndex = 19
        '
        'TxtSpesialis
        '
        Me.TxtSpesialis.Location = New System.Drawing.Point(216, 182)
        Me.TxtSpesialis.Name = "TxtSpesialis"
        Me.TxtSpesialis.Size = New System.Drawing.Size(295, 22)
        Me.TxtSpesialis.TabIndex = 20
        '
        'TxtAlamatDokter
        '
        Me.TxtAlamatDokter.Location = New System.Drawing.Point(216, 222)
        Me.TxtAlamatDokter.Name = "TxtAlamatDokter"
        Me.TxtAlamatDokter.Size = New System.Drawing.Size(295, 22)
        Me.TxtAlamatDokter.TabIndex = 21
        '
        'Labelcari
        '
        Me.Labelcari.AutoSize = True
        Me.Labelcari.BackColor = System.Drawing.Color.Transparent
        Me.Labelcari.Font = New System.Drawing.Font("Script MT Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcari.Location = New System.Drawing.Point(106, 433)
        Me.Labelcari.Name = "Labelcari"
        Me.Labelcari.Size = New System.Drawing.Size(196, 29)
        Me.Labelcari.TabIndex = 27
        Me.Labelcari.Text = "Cari Nama Dokter"
        '
        'TxtCariDokter
        '
        Me.TxtCariDokter.Location = New System.Drawing.Point(77, 476)
        Me.TxtCariDokter.Name = "TxtCariDokter"
        Me.TxtCariDokter.Size = New System.Drawing.Size(258, 22)
        Me.TxtCariDokter.TabIndex = 28
        '
        'BtnCariDokter
        '
        Me.BtnCariDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.search
        Me.BtnCariDokter.Location = New System.Drawing.Point(220, 504)
        Me.BtnCariDokter.Name = "BtnCariDokter"
        Me.BtnCariDokter.Size = New System.Drawing.Size(115, 51)
        Me.BtnCariDokter.TabIndex = 29
        Me.BtnCariDokter.Text = "Cari"
        Me.BtnCariDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCariDokter.UseVisualStyleBackColor = True
        '
        'BtnSaveDokter
        '
        Me.BtnSaveDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.save
        Me.BtnSaveDokter.Location = New System.Drawing.Point(378, 304)
        Me.BtnSaveDokter.Name = "BtnSaveDokter"
        Me.BtnSaveDokter.Size = New System.Drawing.Size(138, 52)
        Me.BtnSaveDokter.TabIndex = 26
        Me.BtnSaveDokter.Text = "Simpan"
        Me.BtnSaveDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSaveDokter.UseVisualStyleBackColor = True
        '
        'BtnHapusDokter
        '
        Me.BtnHapusDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.trash
        Me.BtnHapusDokter.Location = New System.Drawing.Point(522, 304)
        Me.BtnHapusDokter.Name = "BtnHapusDokter"
        Me.BtnHapusDokter.Size = New System.Drawing.Size(130, 52)
        Me.BtnHapusDokter.TabIndex = 25
        Me.BtnHapusDokter.Text = "Hapus"
        Me.BtnHapusDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapusDokter.UseVisualStyleBackColor = True
        '
        'BtnEditDokter
        '
        Me.BtnEditDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.pencil
        Me.BtnEditDokter.Location = New System.Drawing.Point(252, 304)
        Me.BtnEditDokter.Name = "BtnEditDokter"
        Me.BtnEditDokter.Size = New System.Drawing.Size(120, 52)
        Me.BtnEditDokter.TabIndex = 24
        Me.BtnEditDokter.Text = "Edit"
        Me.BtnEditDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditDokter.UseVisualStyleBackColor = True
        '
        'BtnTambahDokter
        '
        Me.BtnTambahDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.plus
        Me.BtnTambahDokter.Location = New System.Drawing.Point(97, 304)
        Me.BtnTambahDokter.Name = "BtnTambahDokter"
        Me.BtnTambahDokter.Size = New System.Drawing.Size(149, 52)
        Me.BtnTambahDokter.TabIndex = 23
        Me.BtnTambahDokter.Text = "Tambah"
        Me.BtnTambahDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambahDokter.UseVisualStyleBackColor = True
        '
        'BtnBatalDokter
        '
        Me.BtnBatalDokter.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalDokter.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.close
        Me.BtnBatalDokter.Location = New System.Drawing.Point(658, 304)
        Me.BtnBatalDokter.Name = "BtnBatalDokter"
        Me.BtnBatalDokter.Size = New System.Drawing.Size(125, 52)
        Me.BtnBatalDokter.TabIndex = 31
        Me.BtnBatalDokter.Text = "Batal"
        Me.BtnBatalDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatalDokter.UseVisualStyleBackColor = True
        '
        'DGDokterAlice
        '
        Me.DGDokterAlice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDokterAlice.Location = New System.Drawing.Point(371, 362)
        Me.DGDokterAlice.Name = "DGDokterAlice"
        Me.DGDokterAlice.RowHeadersWidth = 51
        Me.DGDokterAlice.RowTemplate.Height = 24
        Me.DGDokterAlice.Size = New System.Drawing.Size(521, 215)
        Me.DGDokterAlice.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelJudul)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 75)
        Me.Panel1.TabIndex = 33
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Location = New System.Drawing.Point(570, 580)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(143, 17)
        Me.LbBaris.TabIndex = 34
        Me.LbBaris.Text = "Data ke 0 dari 0 Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "No Telepon"
        '
        'TxtNoTelpon
        '
        Me.TxtNoTelpon.Location = New System.Drawing.Point(216, 259)
        Me.TxtNoTelpon.Name = "TxtNoTelpon"
        Me.TxtNoTelpon.Size = New System.Drawing.Size(295, 22)
        Me.TxtNoTelpon.TabIndex = 36
        '
        'FormDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.bg_dokter__1_
        Me.ClientSize = New System.Drawing.Size(1044, 600)
        Me.Controls.Add(Me.TxtNoTelpon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGDokterAlice)
        Me.Controls.Add(Me.BtnBatalDokter)
        Me.Controls.Add(Me.BtnCariDokter)
        Me.Controls.Add(Me.TxtCariDokter)
        Me.Controls.Add(Me.Labelcari)
        Me.Controls.Add(Me.BtnSaveDokter)
        Me.Controls.Add(Me.BtnHapusDokter)
        Me.Controls.Add(Me.BtnEditDokter)
        Me.Controls.Add(Me.BtnTambahDokter)
        Me.Controls.Add(Me.TxtAlamatDokter)
        Me.Controls.Add(Me.TxtSpesialis)
        Me.Controls.Add(Me.TxtNamaDokter)
        Me.Controls.Add(Me.TxtIDDokter)
        Me.Controls.Add(Me.LabelAlamat)
        Me.Controls.Add(Me.LabelSpesialis)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelIde)
        Me.Name = "FormDokter"
        Me.Text = "FormDokter"
        CType(Me.DGDokterAlice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelIde As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelSpesialis As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents TxtIDDokter As TextBox
    Friend WithEvents TxtNamaDokter As TextBox
    Friend WithEvents TxtSpesialis As TextBox
    Friend WithEvents TxtAlamatDokter As TextBox
    Friend WithEvents BtnSaveDokter As Button
    Friend WithEvents BtnHapusDokter As Button
    Friend WithEvents BtnEditDokter As Button
    Friend WithEvents BtnTambahDokter As Button
    Friend WithEvents Labelcari As Label
    Friend WithEvents TxtCariDokter As TextBox
    Friend WithEvents BtnCariDokter As Button
    Friend WithEvents BtnBatalDokter As Button
    Friend WithEvents DGDokterAlice As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbBaris As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNoTelpon As TextBox
End Class
