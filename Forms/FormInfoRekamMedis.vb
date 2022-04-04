Public Class FormInfoRekamMedis
    Private Sub FormInfoRekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolRekammedis.tampilData.ToTable
        DGRM.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGRM.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGRM.CurrentCell = DGRM.Item(1, baris)
            IsiBox(baris)
        End If

    End Sub

    Dim baris As Integer
    Dim modeProses As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGRM.Rows(br)
                TxtCari.Text = .Cells(0).Value.ToString
            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGRM.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolRekammedis.cariData(kunci).ToTable

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

    Private Sub DGRM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRM.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGRM.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCari.Text)
            TxtCari.Focus()
        End If
    End Sub
End Class