Public Class FormInfoPasien
    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCariPasien.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCariPasien.Text)
            TxtCariPasien.Focus()
        End If
    End Sub

    Private Sub FormInfoPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPasien.tampilData.ToTable
        DGPasien.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPasien.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPasien.CurrentCell = DGPasien.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Dim baris As Integer
    Dim modeProses As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPasien.Rows(br)
                TxtCariPasien.Text = .Cells(0).Value.ToString

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
End Class