Public Class FormPoliklinik
    Private Sub FormPoliklinik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPoliklinik.tampilData.ToTable
        DGPoliklinik.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPoliklinik.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPoliklinik.CurrentCell = DGPoliklinik.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnTambahPoli_Click(sender As Object, e As EventArgs) Handles BtnTambahPoli.Click
        TxtIDPoliklinik.Text = KontrolPasien.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtNamaPoli.Text = ""
        TxtGedung.Text = ""
        TxtIDPoliklinik.Text = KontrolPoliklinik.kodeBaru()
    End Sub

    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambahPoli.Enabled = st
        BtnEditPoli.Enabled = st
        BtnHapusPoli.Enabled = st
        BtnSavePoli.Enabled = Not st
        BtnBatalPoli.Enabled = Not st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPoliklinik.Rows(br)
                TxtIDPoliklinik.Text = .Cells(0).Value.ToString
                TxtNamaPoli.Text = .Cells(1).Value.ToString
                TxtGedung.Text = .Cells(2).Value.ToString
            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGPoliklinik.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPoliklinik.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPoliklinik.DataSource = DTGrid
            DGPoliklinik.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPoliklinik.CurrentCell = DGPoliklinik.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If

    End Sub

    Private Sub DGPoliklinik_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPoliklinik.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPoliklinik.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnEditPoli_Click(sender As Object, e As EventArgs) Handles BtnEditPoli.Click
        AturButton(False)
        TxtNamaPoli.Focus()
        modeProses = 2
    End Sub

    Private Sub BtnSavePoli_Click(sender As Object, e As EventArgs) Handles BtnSavePoli.Click
        With EntitasPoliklinik
            .ID_Poli = TxtIDPoliklinik.Text
            .Nama_Poliklinik = TxtNamaPoli.Text
            .Gedung_Poliklinik = TxtGedung.Text
        End With

        If modeProses = 1 Then
            KontrolPoliklinik.InsertData(EntitasPoliklinik)

        ElseIf modeProses = 2 Then
            KontrolPoliklinik.updateData(EntitasPoliklinik)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub BtnHapusPoli_Click(sender As Object, e As EventArgs) Handles BtnHapusPoli.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolPoliklinik.cekPoliklinikDireferensi(TxtIDPoliklinik.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "PERINGATAN")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus" & TxtIDPoliklinik.Text & "-" & TxtNamaPoli.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolPasien.deleteData(TxtIDPoliklinik.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub BtnBatalPoli_Click(sender As Object, e As EventArgs) Handles BtnBatalPoli.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub BtnCariPoli_Click(sender As Object, e As EventArgs) Handles BtnCariPoli.Click
        If TxtCariPoli.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCariPoli.Text)
            TxtCariPoli.Focus()
        End If
    End Sub
End Class