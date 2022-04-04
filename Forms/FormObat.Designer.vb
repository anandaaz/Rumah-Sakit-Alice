<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Me.Labelket = New System.Windows.Forms.Label()
        Me.TxtIDObat = New System.Windows.Forms.TextBox()
        Me.TxtNamaObat = New System.Windows.Forms.TextBox()
        Me.TxtKetObat = New System.Windows.Forms.TextBox()
        Me.Labelcari = New System.Windows.Forms.Label()
        Me.TxtCariObat = New System.Windows.Forms.TextBox()
        Me.BtnCariObat = New System.Windows.Forms.Button()
        Me.BtnSaveObat = New System.Windows.Forms.Button()
        Me.BtnHapusObat = New System.Windows.Forms.Button()
        Me.BtnEditObat = New System.Windows.Forms.Button()
        Me.BtnTambahObat = New System.Windows.Forms.Button()
        Me.DGObat = New System.Windows.Forms.DataGridView()
        Me.BtnBatalObat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbBaris = New System.Windows.Forms.Label()
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(380, 7)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(265, 65)
        Me.LabelJudul.TabIndex = 3
        Me.LabelJudul.Text = "Form Obat"
        '
        'LabelIde
        '
        Me.LabelIde.AutoSize = True
        Me.LabelIde.BackColor = System.Drawing.Color.Transparent
        Me.LabelIde.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIde.Location = New System.Drawing.Point(76, 111)
        Me.LabelIde.Name = "LabelIde"
        Me.LabelIde.Size = New System.Drawing.Size(80, 24)
        Me.LabelIde.TabIndex = 14
        Me.LabelIde.Text = "ID Obat"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.BackColor = System.Drawing.Color.Transparent
        Me.LabelNama.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(76, 159)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(105, 24)
        Me.LabelNama.TabIndex = 15
        Me.LabelNama.Text = "Nama Obat"
        '
        'Labelket
        '
        Me.Labelket.AutoSize = True
        Me.Labelket.BackColor = System.Drawing.Color.Transparent
        Me.Labelket.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelket.Location = New System.Drawing.Point(76, 205)
        Me.Labelket.Name = "Labelket"
        Me.Labelket.Size = New System.Drawing.Size(147, 24)
        Me.Labelket.TabIndex = 16
        Me.Labelket.Text = "Keterangan Obat"
        '
        'TxtIDObat
        '
        Me.TxtIDObat.Location = New System.Drawing.Point(270, 114)
        Me.TxtIDObat.Name = "TxtIDObat"
        Me.TxtIDObat.Size = New System.Drawing.Size(329, 22)
        Me.TxtIDObat.TabIndex = 17
        '
        'TxtNamaObat
        '
        Me.TxtNamaObat.Location = New System.Drawing.Point(270, 162)
        Me.TxtNamaObat.Name = "TxtNamaObat"
        Me.TxtNamaObat.Size = New System.Drawing.Size(329, 22)
        Me.TxtNamaObat.TabIndex = 18
        '
        'TxtKetObat
        '
        Me.TxtKetObat.Location = New System.Drawing.Point(270, 205)
        Me.TxtKetObat.Name = "TxtKetObat"
        Me.TxtKetObat.Size = New System.Drawing.Size(329, 22)
        Me.TxtKetObat.TabIndex = 19
        '
        'Labelcari
        '
        Me.Labelcari.AutoSize = True
        Me.Labelcari.BackColor = System.Drawing.Color.Transparent
        Me.Labelcari.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcari.Location = New System.Drawing.Point(95, 318)
        Me.Labelcari.Name = "Labelcari"
        Me.Labelcari.Size = New System.Drawing.Size(86, 24)
        Me.Labelcari.TabIndex = 20
        Me.Labelcari.Text = "Cari Obat"
        '
        'TxtCariObat
        '
        Me.TxtCariObat.Location = New System.Drawing.Point(88, 358)
        Me.TxtCariObat.Name = "TxtCariObat"
        Me.TxtCariObat.Size = New System.Drawing.Size(171, 22)
        Me.TxtCariObat.TabIndex = 21
        '
        'BtnCariObat
        '
        Me.BtnCariObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.search
        Me.BtnCariObat.Location = New System.Drawing.Point(281, 331)
        Me.BtnCariObat.Name = "BtnCariObat"
        Me.BtnCariObat.Size = New System.Drawing.Size(107, 50)
        Me.BtnCariObat.TabIndex = 30
        Me.BtnCariObat.Text = "Cari"
        Me.BtnCariObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCariObat.UseVisualStyleBackColor = True
        '
        'BtnSaveObat
        '
        Me.BtnSaveObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.save
        Me.BtnSaveObat.Location = New System.Drawing.Point(353, 256)
        Me.BtnSaveObat.Name = "BtnSaveObat"
        Me.BtnSaveObat.Size = New System.Drawing.Size(137, 47)
        Me.BtnSaveObat.TabIndex = 34
        Me.BtnSaveObat.Text = "Simpan"
        Me.BtnSaveObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSaveObat.UseVisualStyleBackColor = True
        '
        'BtnHapusObat
        '
        Me.BtnHapusObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.trash
        Me.BtnHapusObat.Location = New System.Drawing.Point(627, 256)
        Me.BtnHapusObat.Name = "BtnHapusObat"
        Me.BtnHapusObat.Size = New System.Drawing.Size(134, 49)
        Me.BtnHapusObat.TabIndex = 33
        Me.BtnHapusObat.Text = "Hapus"
        Me.BtnHapusObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapusObat.UseVisualStyleBackColor = True
        '
        'BtnEditObat
        '
        Me.BtnEditObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.pencil
        Me.BtnEditObat.Location = New System.Drawing.Point(227, 256)
        Me.BtnEditObat.Name = "BtnEditObat"
        Me.BtnEditObat.Size = New System.Drawing.Size(120, 47)
        Me.BtnEditObat.TabIndex = 32
        Me.BtnEditObat.Text = "Edit"
        Me.BtnEditObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditObat.UseVisualStyleBackColor = True
        '
        'BtnTambahObat
        '
        Me.BtnTambahObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.plus
        Me.BtnTambahObat.Location = New System.Drawing.Point(80, 256)
        Me.BtnTambahObat.Name = "BtnTambahObat"
        Me.BtnTambahObat.Size = New System.Drawing.Size(141, 47)
        Me.BtnTambahObat.TabIndex = 31
        Me.BtnTambahObat.Text = "Tambah"
        Me.BtnTambahObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambahObat.UseVisualStyleBackColor = True
        '
        'DGObat
        '
        Me.DGObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGObat.Location = New System.Drawing.Point(88, 395)
        Me.DGObat.Name = "DGObat"
        Me.DGObat.RowHeadersWidth = 51
        Me.DGObat.RowTemplate.Height = 24
        Me.DGObat.Size = New System.Drawing.Size(497, 195)
        Me.DGObat.TabIndex = 35
        '
        'BtnBatalObat
        '
        Me.BtnBatalObat.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalObat.Image = Global.Rumah_Sakit_Alice.My.Resources.Resources.close
        Me.BtnBatalObat.Location = New System.Drawing.Point(496, 256)
        Me.BtnBatalObat.Name = "BtnBatalObat"
        Me.BtnBatalObat.Size = New System.Drawing.Size(125, 47)
        Me.BtnBatalObat.TabIndex = 36
        Me.BtnBatalObat.Text = "Batal"
        Me.BtnBatalObat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatalObat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelJudul)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 82)
        Me.Panel1.TabIndex = 37
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Location = New System.Drawing.Point(255, 593)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(143, 17)
        Me.LbBaris.TabIndex = 38
        Me.LbBaris.Text = "Data ke 0 dari 0 Data"
        '
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rumah_Sakit_Alice.My.Resources.Resources.bg_obat__1_
        Me.ClientSize = New System.Drawing.Size(1017, 613)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBatalObat)
        Me.Controls.Add(Me.DGObat)
        Me.Controls.Add(Me.BtnSaveObat)
        Me.Controls.Add(Me.BtnHapusObat)
        Me.Controls.Add(Me.BtnEditObat)
        Me.Controls.Add(Me.BtnTambahObat)
        Me.Controls.Add(Me.BtnCariObat)
        Me.Controls.Add(Me.TxtCariObat)
        Me.Controls.Add(Me.Labelcari)
        Me.Controls.Add(Me.TxtKetObat)
        Me.Controls.Add(Me.TxtNamaObat)
        Me.Controls.Add(Me.TxtIDObat)
        Me.Controls.Add(Me.Labelket)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelIde)
        Me.Name = "FormObat"
        Me.Text = "FormObat"
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelIde As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents Labelket As Label
    Friend WithEvents TxtIDObat As TextBox
    Friend WithEvents TxtNamaObat As TextBox
    Friend WithEvents TxtKetObat As TextBox
    Friend WithEvents Labelcari As Label
    Friend WithEvents TxtCariObat As TextBox
    Friend WithEvents BtnCariObat As Button
    Friend WithEvents BtnSaveObat As Button
    Friend WithEvents BtnHapusObat As Button
    Friend WithEvents BtnEditObat As Button
    Friend WithEvents BtnTambahObat As Button
    Friend WithEvents DGObat As DataGridView
    Friend WithEvents BtnBatalObat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbBaris As Label
End Class
