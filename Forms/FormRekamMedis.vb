Imports System.Data.OleDb
Public Class FormRekamMedis
    Private Sub FormRekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

        CBDokter.Items.Add("A1")
        CBDokter.Items.Add("A2")
        CBDokter.Items.Add("A3")
        CBDokter.Items.Add("B1")
        CBDokter.Items.Add("B2")
        CBDokter.Items.Add("B3")
        CBDokter.Items.Add("C1")
        CBDokter.Items.Add("C2")
        CBDokter.Items.Add("C3")
        CBDokter.Items.Add("C4")
        CBDokter.Items.Add("C5")

        CBPoli.Items.Add("K0")
        CBPoli.Items.Add("K1")
        CBPoli.Items.Add("K2")
        CBPoli.Items.Add("K3")
        CBPoli.Items.Add("K4")
        CBPoli.Items.Add("K5")
        CBPoli.Items.Add("K6")
        CBPoli.Items.Add("K7")
        CBPoli.Items.Add("K8")
        CBPoli.Items.Add("K9")

    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolRekammedis.tampilData.ToTable
        DGRM.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGRM.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGRM.CurrentCell = DGRM.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If

    End Sub

    Dim baris As Integer
    Dim modeProses As Integer

    Private Sub AturButton(st As Boolean)
        BtnTambahRM.Enabled = st
        BtnEditRM.Enabled = st
        BtnHapusRM.Enabled = st
        BtnSaveRM.Enabled = Not st
        BtnBatalRM.Enabled = Not st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGRM.Rows(br)
                TxtIDPasien.Text = .Cells(0).Value.ToString
                CBDokter.Text = .Cells(1).Value.ToString
                CBPoli.Text = .Cells(2).Value.ToString
                TxtNamaPasien.Text = .Cells(3).Value.ToString
                TxtKeluhan.Text = .Cells(4).Value.ToString
                TxtDokter.Text = .Cells(5).Value.ToString
                TxtDiagnosa.Text = .Cells(6).Value.ToString
                TxtNamaPoli.Text = .Cells(7).Value.ToString
                DateTime.Text = .Cells(8).Value.ToString
            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGRM.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub DGRM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRM.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGRM.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPoliklinik.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGRM.DataSource = DTGrid
            DGRM.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGRM.CurrentCell = DGRM.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If
    End Sub

    Private Sub BtnTambahRM_Click(sender As Object, e As EventArgs) Handles BtnTambahRM.Click
        TxtIDPasien.Text = KontrolRekammedis.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtIDPasien.Text = ""
        CBDokter.Text = "PILIH"
        CBPoli.Text = "PILIH"
        DateTime.Text = ""
        TxtNamaPasien.Text = ""
        TxtDokter.Text = ""
        TxtNamaPoli.Text = ""
        TxtKeluhan.Text = ""
        TxtDiagnosa.Text = ""
        TxtIDPasien.Text = KontrolRekammedis.kodeBaru()
    End Sub

    Private Sub BtnEditRM_Click(sender As Object, e As EventArgs) Handles BtnEditRM.Click
        AturButton(False)
        TxtNamaPasien.Focus()
        modeProses = 2

    End Sub

    Private Sub BtnSaveRM_Click(sender As Object, e As EventArgs) Handles BtnSaveRM.Click
        With EntitasRekammedis
            .Tanggal_Periksa = DateTime.Text
            .ID_Pasien = TxtIDPasien.Text
            .ID_Dokter = CBDokter.Text
            .ID_Poli = CBPoli.Text
            .Nama_Pasien = TxtNamaPasien.Text
            .Nama_Dokter = TxtDokter.Text
            .Nama_Poliklinik = TxtNamaPoli.Text
            .Keluhan = TxtKeluhan.Text
            .Diagnosa = TxtDiagnosa.Text
        End With

        If modeProses = 1 Then
            KontrolRekammedis.InsertData(EntitasRekammedis)

        ElseIf modeProses = 2 Then
            KontrolRekammedis.updateData(EntitasRekammedis)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0

    End Sub

    Private Sub BtnBatalRM_Click(sender As Object, e As EventArgs) Handles BtnBatalRM.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0

    End Sub

    Private Sub BtnHapusRM_Click(sender As Object, e As EventArgs) Handles BtnHapusRM.Click
        If MsgBox("Apakah anda yakin akan menghapus rekam medis " & TxtIDPasien.Text & "-" & TxtNamaPasien.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolRekammedis.deleteData(TxtIDPasien.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTime.ValueChanged
        Me.Text = DateTime.Value.ToString
    End Sub
End Class