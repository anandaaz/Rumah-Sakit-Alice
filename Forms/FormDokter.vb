Public Class FormDokter
    Private Sub FormDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TxtIDDokter.Enabled = False
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolDokter.tampilData.ToTable
        DGDokterAlice.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDokterAlice.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDokterAlice.CurrentCell = DGDokterAlice.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If

    End Sub

    Private Sub BtnTambahDokter_Click(sender As Object, e As EventArgs) Handles BtnTambahDokter.Click
        TxtIDDokter.Text = KontrolDokter.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtNamaDokter.Text = ""
        TxtSpesialis.Text = ""
        TxtAlamatDokter.Text = ""
        TxtNoTelpon.Text = ""
        TxtIDDokter.Text = KontrolDokter.kodeBaru()

    End Sub

    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambahDokter.Enabled = st
        BtnEditDokter.Enabled = st
        BtnHapusDokter.Enabled = st
        BtnSaveDokter.Enabled = Not st
        BtnBatalDokter.Enabled = Not st

        'GroupBox1.Enabled = Not st
        'GroupBox3.Enabled = st
        'GroupBox4.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDokterAlice.Rows(br)
                TxtIDDokter.Text = .Cells(0).Value.ToString
                TxtNamaDokter.Text = .Cells(1).Value.ToString
                TxtSpesialis.Text = .Cells(2).Value.ToString
                TxtAlamatDokter.Text = .Cells(3).Value.ToString
                TxtNoTelpon.Text = .Cells(4).Value.ToString
            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGDokterAlice.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolDokter.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDokterAlice.DataSource = DTGrid
            DGDokterAlice.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDokterAlice.CurrentCell = DGDokterAlice.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If

    End Sub

    Private Sub DGDokterAlice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDokterAlice.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGDokterAlice.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCariDokter_Click(sender As Object, e As EventArgs) Handles BtnCariDokter.Click
        If TxtCariDokter.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCariDokter.Text)
            TxtCariDokter.Focus()
        End If

    End Sub

    Private Sub BtnEditDokter_Click(sender As Object, e As EventArgs) Handles BtnEditDokter.Click
        AturButton(False)
        TxtNamaDokter.Focus()
        modeProses = 2

    End Sub

    Private Sub BtnBatalDokter_Click(sender As Object, e As EventArgs) Handles BtnBatalDokter.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0

    End Sub

    Private Sub BtnSaveDokter_Click(sender As Object, e As EventArgs) Handles BtnSaveDokter.Click
        With EntitasDokter
            .ID_Dokter = TxtIDDokter.Text
            .Nama_Dokter = TxtNamaDokter.Text
            .Spesialis_Dokter = TxtSpesialis.Text
            .Alamat_Dokter = TxtAlamatDokter.Text
            .No_Telepon = TxtNoTelpon.Text
        End With

        If modeProses = 1 Then
            KontrolDokter.InsertData(EntitasDokter)

        ElseIf modeProses = 2 Then
            KontrolDokter.updateData(EntitasDokter)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0

    End Sub

    Private Sub BtnHapusDokter_Click(sender As Object, e As EventArgs) Handles BtnHapusDokter.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolDokter.cekDokterDireferensi(TxtIDDokter.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "PERINGATAN")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus" & TxtIDDokter.Text & "-" & TxtNamaDokter.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolDokter.deleteData(TxtIDDokter.Text)
        End If
        RefreshGrid()

    End Sub
End Class