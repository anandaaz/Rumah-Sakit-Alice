Public Class FormObat
    Private Sub FormObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TxtIDObat.Enabled = False
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolObat.tampilData.ToTable
        DGObat.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGObat.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGObat.CurrentCell = DGObat.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If

    End Sub

    Private Sub BtnTambahObat_Click(sender As Object, e As EventArgs) Handles BtnTambahObat.Click
        TxtIDObat.Text = KontrolObat.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtNamaObat.Text = ""
        TxtKetObat.Text = ""
        TxtIDObat.Text = KontrolObat.kodeBaru()

    End Sub

    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambahObat.Enabled = st
        BtnEditObat.Enabled = st
        BtnHapusObat.Enabled = st
        BtnSaveObat.Enabled = Not st
        BtnBatalObat.Enabled = Not st

        'GroupBox1.Enabled = Not st
        'GroupBox3.Enabled = st
        'GroupBox4.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGObat.Rows(br)
                TxtIDObat.Text = .Cells(0).Value.ToString
                TxtNamaObat.Text = .Cells(1).Value.ToString
                TxtKetObat.Text = .Cells(2).Value.ToString


            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGObat.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolObat.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGObat.DataSource = DTGrid
            DGObat.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGObat.CurrentCell = DGObat.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If

    End Sub

    Private Sub DGObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGObat.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGObat.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCariObat_Click(sender As Object, e As EventArgs) Handles BtnCariObat.Click
        If TxtCariObat.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCariObat.Text)
            TxtCariObat.Focus()
        End If

    End Sub

    Private Sub BtnEditObat_Click(sender As Object, e As EventArgs) Handles BtnEditObat.Click
        AturButton(False)
        TxtNamaObat.Focus()
        modeProses = 2

    End Sub

    Private Sub BtnBatalObat_Click(sender As Object, e As EventArgs) Handles BtnBatalObat.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0

    End Sub

    Private Sub BtnSaveObat_Click(sender As Object, e As EventArgs) Handles BtnSaveObat.Click
        With EntitasObat
            .ID_Obat = TxtIDObat.Text
            .Nama_Obat = TxtNamaObat.Text
            .Keterangan_Obat = TxtKetObat.Text
        End With

        If modeProses = 1 Then
            KontrolObat.InsertData(EntitasObat)

        ElseIf modeProses = 2 Then
            KontrolObat.updateData(EntitasObat)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0

    End Sub

    Private Sub BtnHapusObat_Click(sender As Object, e As EventArgs) Handles BtnHapusObat.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolObat.cekObatDireferensi(TxtIDObat.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "PERINGATAN")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus" & TxtIDObat.Text & "-" & TxtNamaObat.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolObat.deleteData(TxtIDObat.Text)
        End If
        RefreshGrid()
    End Sub
End Class