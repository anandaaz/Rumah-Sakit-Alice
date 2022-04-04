Imports System.Data.OleDb

Public Class ClsCtlRekamMedis : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntRekamMedis
        data = Ob
        CMD = New OleDbCommand("insert into tb_rekammedis values('" & data.ID_Pasien & "','" & data.ID_Dokter _
                               & "','" & data.ID_Poli & "','" & data.Nama_Pasien & "','" & data.Keluhan _
                               & "','" & data.Nama_Dokter & "','" & data.Diagnosa & "','" & data.Nama_Poliklinik _
                               & "','" & data.Tanggal_Periksa & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntRekamMedis
        data = Ob
        CMD = New OleDbCommand("update tb_rekammedis set tgl_periksa ='" & data.Tanggal_Periksa _
                               & "', id_pasien = '" & data.ID_Pasien & "', id_dokter = '" & data.ID_Dokter _
                               & "', id_poli = '" & data.ID_Poli & "', nama_pasien = '" & data.Nama_Pasien _
                               & "', dokter = '" & data.Nama_Dokter & "', nama_poli = '" & data.Nama_Poliklinik _
                               & "', keluhan = '" & data.Keluhan & "', diagnosa = '" & data.Diagnosa _
                               & "' where id_pasien ='" & data.ID_Pasien & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from tb_rekammedis" _
                             & " where id_pasien='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from tb_rekammedis", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Tabel_Rekammedis")
            Dim grid As New DataView(DTS.Tables("Tabel_Rekammedis"))
            Return grid
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from TB_REKAMMEDIS where nama_pasien " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Rekammedis")
            Dim grid As New DataView(DTS.Tables("Cari_Rekammedis"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_pasien ,1)) from TB_REKAMMEDIS", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P" & Strings.Right(kodeakhir + 1, 1)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekRMDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_pasien) from TB_PASIEN " _
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
