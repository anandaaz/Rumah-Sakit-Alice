Imports System.Data.OleDb

Public Class ClsCtlPasien : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        'Throw New NotImplementedException()
        Dim data As New ClsEntPasien
        data = Ob
        CMD = New OleDbCommand("insert into TB_PASIEN values('" & data.ID_Pasien & "','" _
                                & data.Nomor_Identitas & "','" & data.Nama_Pasien & "','" _
                                & data.Jenis_Kelamin & "','" & data.Alamat_Pasien & "', '" _
                               & data.Nomor_Telepon & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        'Throw New NotImplementedException()
        Dim data As New ClsEntPasien
        data = Ob
        CMD = New OleDbCommand("update TB_PASIEN set nomor_identitas = '" _
                            & data.Nomor_Identitas & "', nama_pasien='" & data.Nama_Pasien & "', 
                            jenis_kelamin='" & data.Jenis_Kelamin & "', alamat='" & data.Alamat_Pasien & "',
                            no_telp='" & data.Nomor_Telepon _
                            & " 'where id_pasien ='" & data.ID_Pasien & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from TB_PASIEN " _
                             & " where id_pasien='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from TB_PASIEN", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Tabel_Pasien")
            Dim grid As New DataView(DTS.Tables("Tabel_Pasien"))
            Return grid
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from TB_PASIEN where nama_pasien " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Pasien")
            Dim grid As New DataView(DTS.Tables("Cari_Pasien"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_pasien ,1)) from TB_PASIEN", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P" & Strings.Right(kodeakhir + 1, 1)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekPasienDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_pasien) from TB_REKAMMEDIS " _
                                       & "where id_pasien='" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            'Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function
End Class
