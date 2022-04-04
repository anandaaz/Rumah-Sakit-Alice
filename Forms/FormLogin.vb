Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "alice" And TxtPass.Text = "12345" Then
            Me.Hide()

            FormUtama.Show()
        Else
            MessageBox.Show("Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPass.Text = ""
            TxtPass.Focus()

        End If
    End Sub

    Dim konfirmasi As String
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        konfirmasi = MsgBox("Yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub
End Class