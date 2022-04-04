Public Class FormPasien
    Private Sub FormPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPasien.tampilData.ToTable
        DGPasien.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPasien.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPasien.CurrentCell = DGPasien.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnTambahPasien_Click(sender As Object, e As EventArgs) Handles BtnTambahPasien.Click
        TxtIDPasien.Text = KontrolPasien.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtNomorPasien.Text = ""
        TxtNamaPasien.Text = ""
        TxtJenisPasien.Text = ""
        TxtAlamatPasien.Text = ""
        TxtNoTelp.Text = ""
        TxtIDPasien.Text = KontrolPasien.kodeBaru()

    End Sub

    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambahPasien.Enabled = st
        BtnEditPasien.Enabled = st
        BtnHapusPasien.Enabled = st
        BtnSavePasien.Enabled = Not st
        BtnBatalPasien.Enabled = Not st

    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPasien.Rows(br)
                TxtIDPasien.Text = .Cells(0).Value.ToString
                TxtNomorPasien.Text = .Cells(1).Value.ToString
                TxtNamaPasien.Text = .Cells(2).Value.ToString
                TxtJenisPasien.Text = .Cells(3).Value.ToString
                TxtAlamatPasien.Text = .Cells(4).Value.ToString
                TxtNoTelp.Text = .Cells(5).Value.ToString
            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGPasien.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPasien.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPasien.DataSource = DTGrid
            DGPasien.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPasien.CurrentCell = DGPasien.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If

    End Sub

    Private Sub DGPasien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPasien.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPasien.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnEditPasien_Click(sender As Object, e As EventArgs) Handles BtnEditPasien.Click
        AturButton(False)
        TxtNamaPasien.Focus()
        modeProses = 2
    End Sub

    Private Sub BtnSavePasien_Click(sender As Object, e As EventArgs) Handles BtnSavePasien.Click
        With EntitasPasien
            .ID_Pasien = TxtIDPasien.Text
            .Nomor_Identitas = TxtNomorPasien.Text
            .Nama_Pasien = TxtNamaPasien.Text
            .Jenis_Kelamin = TxtJenisPasien.Text
            .Alamat_Pasien = TxtAlamatPasien.Text
            .Nomor_Telepon = TxtNoTelp.Text
        End With

        If modeProses = 1 Then
            KontrolPasien.InsertData(EntitasPasien)

        ElseIf modeProses = 2 Then
            KontrolPasien.updateData(EntitasPasien)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub BtnHapusPasien_Click(sender As Object, e As EventArgs) Handles BtnHapusPasien.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolPasien.cekPasienDireferensi(TxtIDPasien.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "PERINGATAN")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus" & TxtIDPasien.Text & "-" & TxtNamaPasien.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolPasien.deleteData(TxtIDPasien.Text)
        End If
        RefreshGrid()

    End Sub

    Private Sub BtnBatalPasien_Click(sender As Object, e As EventArgs) Handles BtnBatalPasien.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub


End Class