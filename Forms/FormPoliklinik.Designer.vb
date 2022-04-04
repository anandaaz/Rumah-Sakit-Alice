<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPoliklinik
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
        Me.LabelPoli = New System.Windows.Forms.Label()
        Me.Labelgedung = New System.Windows.Forms.Label()
        Me.TxtIDPoliklinik = New System.Windows.Forms.TextBox()
        Me.TxtNamaPoli = New System.Windows.Forms.TextBox()
        Me.TxtGedung = New System.Windows.Forms.TextBox()
        Me.Labelcari = New System.Windows.Forms.Label()
        Me.TxtCariPoli = New System.Windows.Forms.TextBox()
        Me.BtnCariPoli = New System.Windows.Forms.Button()
        Me.BtnSavePoli = New System.Windows.Forms.Button()
        Me.BtnHapusPoli = New System.Windows.Forms.Button()
        Me.BtnEditPoli = New System.Windows.Forms.Button()
        Me.BtnTambahPoli = New System.Windows.Forms.Button()
        Me.DGPoliklinik = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBatalPoli = New System.Windows.Forms.Button()
        Me.LbBaris = New System.Windows.Forms.Label()
        CType(Me.DGPoliklinik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(346, 15)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(379, 65)
        Me.LabelJudul.TabIndex = 4
        Me.LabelJudul.Text = "Form Poliklinik"
        '
        'LabelIde
        '
        Me.LabelIde.AutoSize = True
        Me.LabelIde.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIde.Location = New System.Drawing.Point(323, 135)
        Me.LabelIde.Name = "LabelIde"
        Me.LabelIde.Size = New System.Drawing.Size(122, 24)
        Me.LabelIde.TabIndex = 15
        Me.LabelIde.Text = "ID Poliklinik"
        '
        'LabelPoli
        '
        Me.LabelPoli.AutoSize = True
        Me.LabelPoli.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoli.Location = New System.Drawing.Point(323, 193)
        Me.LabelPoli.Name = "LabelPoli"
        Me.LabelPoli.Size = New System.Drawing.Size(147, 24)
        Me.LabelPoli.TabIndex = 16
        Me.LabelPoli.Text = "Nama Poliklinik"
        '
        'Labelgedung
        '
        Me.Labelgedung.AutoSize = True
        Me.Labelgedung.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelgedung.Location = New System.Drawing.Point(323, 248)
        Me.Labelgedung.Name = "Labelgedung"
        Me.Labelgedung.Size = New System.Drawing.Size(70, 24)
        Me.Labelgedung.TabIndex = 17
        Me.Labelgedung.Text = "Gedung"
        '
        'TxtIDPoliklinik
        '
        Me.TxtIDPoliklinik.Location = New System.Drawing.Point(503, 138)
        Me.TxtIDPoliklinik.Name = "TxtIDPoliklinik"
        Me.TxtIDPoliklinik.Size = New System.Drawing.Size(176, 22)
        Me.TxtIDPoliklinik.TabIndex = 18
        '
        'TxtNamaPoli
        '
        Me.TxtNamaPoli.Location = New System.Drawing.Point(503, 193)
        Me.TxtNamaPoli.Name = "TxtNamaPoli"
        Me.TxtNamaPoli.Size = New System.Drawing.Size(176, 22)
        Me.TxtNamaPoli.TabIndex = 19
        '
        'TxtGedung
        '
        Me.TxtGedung.Location = New System.Drawing.Point(503, 248)
        Me.TxtGedung.Name = "TxtGedung"
        Me.TxtGedung.Size = New System.Drawing.Size(176, 22)
        Me.TxtGedung.TabIndex = 20
        '
        'Labelcari
        '
        Me.Labelcari.AutoSize = True
        Me.Labelcari.Font = New System.Drawing.Font("Script MT Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcari.Location = New System.Drawing.Point(315, 380)
        Me.Labelcari.Name = "Labelcari"
        Me.Labelcari.Size = New System.Drawing.Size(155, 29)
        Me.Labelcari.TabIndex = 39
        Me.Labelcari.Text = "Cari Poliklinik"
        '
        'TxtCariPoli
        '
        Me.TxtCariPoli.Location = New System.Drawing.Point(486, 386)
        Me.TxtCariPoli.Name = "TxtCariPoli"
        Me.TxtCariPoli.Size = New System.Drawing.Size(176, 22)
        Me.TxtCariPoli.TabIndex = 40
        '
        'BtnCariPoli
        '
        Me.BtnCariPoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariPoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.search
        Me.BtnCariPoli.Location = New System.Drawing.Point(679, 371)
        Me.BtnCariPoli.Name = "BtnCariPoli"
        Me.BtnCariPoli.Size = New System.Drawing.Size(115, 51)
        Me.BtnCariPoli.TabIndex = 41
        Me.BtnCariPoli.Text = "Cari"
        Me.BtnCariPoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCariPoli.UseVisualStyleBackColor = True
        '
        'BtnSavePoli
        '
        Me.BtnSavePoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.save
        Me.BtnSavePoli.Location = New System.Drawing.Point(461, 309)
        Me.BtnSavePoli.Name = "BtnSavePoli"
        Me.BtnSavePoli.Size = New System.Drawing.Size(143, 47)
        Me.BtnSavePoli.TabIndex = 38
        Me.BtnSavePoli.Text = "Simpan"
        Me.BtnSavePoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSavePoli.UseVisualStyleBackColor = True
        '
        'BtnHapusPoli
        '
        Me.BtnHapusPoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusPoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.trash
        Me.BtnHapusPoli.Location = New System.Drawing.Point(610, 309)
        Me.BtnHapusPoli.Name = "BtnHapusPoli"
        Me.BtnHapusPoli.Size = New System.Drawing.Size(132, 47)
        Me.BtnHapusPoli.TabIndex = 37
        Me.BtnHapusPoli.Text = "Hapus"
        Me.BtnHapusPoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapusPoli.UseVisualStyleBackColor = True
        '
        'BtnEditPoli
        '
        Me.BtnEditPoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditPoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.pencil
        Me.BtnEditPoli.Location = New System.Drawing.Point(341, 309)
        Me.BtnEditPoli.Name = "BtnEditPoli"
        Me.BtnEditPoli.Size = New System.Drawing.Size(114, 47)
        Me.BtnEditPoli.TabIndex = 36
        Me.BtnEditPoli.Text = "Edit"
        Me.BtnEditPoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditPoli.UseVisualStyleBackColor = True
        '
        'BtnTambahPoli
        '
        Me.BtnTambahPoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahPoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.plus
        Me.BtnTambahPoli.Location = New System.Drawing.Point(183, 309)
        Me.BtnTambahPoli.Name = "BtnTambahPoli"
        Me.BtnTambahPoli.Size = New System.Drawing.Size(152, 47)
        Me.BtnTambahPoli.TabIndex = 35
        Me.BtnTambahPoli.Text = "Tambah"
        Me.BtnTambahPoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambahPoli.UseVisualStyleBackColor = True
        '
        'DGPoliklinik
        '
        Me.DGPoliklinik.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGPoliklinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPoliklinik.Location = New System.Drawing.Point(261, 434)
        Me.DGPoliklinik.Name = "DGPoliklinik"
        Me.DGPoliklinik.RowHeadersWidth = 51
        Me.DGPoliklinik.RowTemplate.Height = 24
        Me.DGPoliklinik.Size = New System.Drawing.Size(566, 186)
        Me.DGPoliklinik.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelJudul)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 91)
        Me.Panel1.TabIndex = 43
        '
        'BtnBatalPoli
        '
        Me.BtnBatalPoli.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalPoli.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.close
        Me.BtnBatalPoli.Location = New System.Drawing.Point(748, 309)
        Me.BtnBatalPoli.Name = "BtnBatalPoli"
        Me.BtnBatalPoli.Size = New System.Drawing.Size(121, 47)
        Me.BtnBatalPoli.TabIndex = 44
        Me.BtnBatalPoli.Text = "Batal"
        Me.BtnBatalPoli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatalPoli.UseVisualStyleBackColor = True
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Location = New System.Drawing.Point(477, 623)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(143, 17)
        Me.LbBaris.TabIndex = 45
        Me.LbBaris.Text = "Data ke 0 dari 0 Data"
        '
        'FormPoliklinik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.poli__1_
        Me.ClientSize = New System.Drawing.Size(1037, 674)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.BtnBatalPoli)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGPoliklinik)
        Me.Controls.Add(Me.BtnCariPoli)
        Me.Controls.Add(Me.TxtCariPoli)
        Me.Controls.Add(Me.Labelcari)
        Me.Controls.Add(Me.BtnSavePoli)
        Me.Controls.Add(Me.BtnHapusPoli)
        Me.Controls.Add(Me.BtnEditPoli)
        Me.Controls.Add(Me.BtnTambahPoli)
        Me.Controls.Add(Me.TxtGedung)
        Me.Controls.Add(Me.TxtNamaPoli)
        Me.Controls.Add(Me.TxtIDPoliklinik)
        Me.Controls.Add(Me.Labelgedung)
        Me.Controls.Add(Me.LabelPoli)
        Me.Controls.Add(Me.LabelIde)
        Me.Name = "FormPoliklinik"
        Me.Text = "FormPoliklinik"
        CType(Me.DGPoliklinik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelIde As Label
    Friend WithEvents LabelPoli As Label
    Friend WithEvents Labelgedung As Label
    Friend WithEvents TxtIDPoliklinik As TextBox
    Friend WithEvents TxtNamaPoli As TextBox
    Friend WithEvents TxtGedung As TextBox
    Friend WithEvents BtnSavePoli As Button
    Friend WithEvents BtnHapusPoli As Button
    Friend WithEvents BtnEditPoli As Button
    Friend WithEvents BtnTambahPoli As Button
    Friend WithEvents Labelcari As Label
    Friend WithEvents TxtCariPoli As TextBox
    Friend WithEvents BtnCariPoli As Button
    Friend WithEvents DGPoliklinik As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBatalPoli As Button
    Friend WithEvents LbBaris As Label
End Class
