Public Class FormUtama
    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        FormDokter.Show()
        Panel1.Hide()
        Panel2.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        Panel1.Show()
        Panel2.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub PoliklinikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliklinikToolStripMenuItem.Click
        FormPoliklinik.Show()
        Panel1.Hide()
        Panel2.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub


    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        FormObat.Show()
        Panel1.Hide()
        Panel2.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub RekamMedisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamMedisToolStripMenuItem.Click
        FormRekamMedis.Hide()
        Panel1.Hide()
        Panel2.Show()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub BtnPasien_Click(sender As Object, e As EventArgs) Handles BtnPasien.Click
        FormPasien.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
        Panel2.Hide()
        Label1.Show()
        Label2.Show()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        FormInfoPasien.Show()
    End Sub

    Private Sub BtnRM_Click(sender As Object, e As EventArgs) Handles BtnRM.Click
        FormRekamMedis.Show()
    End Sub

    Private Sub BtnCariRM_Click(sender As Object, e As EventArgs) Handles BtnCariRM.Click
        FormInfoRekamMedis.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class