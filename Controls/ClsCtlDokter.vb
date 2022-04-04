Imports System.Data.OleDb

Public Class ClsCtlDokter : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        'Throw New NotImplementedException()
        Dim data As New ClsEntDokter
        data = Ob
        CMD = New OleDbCommand("insert into TB_DOKTER values('" & data.ID_Dokter & "','" _
                                & data.Nama_Dokter & "','" & data.Spesialis_Dokter & "','" _
                                & data.Alamat_Dokter & "','" & data.No_Telepon & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        'Throw New NotImplementedException()
        Dim data As New ClsEntDokter
        data = Ob
        CMD = New OleDbCommand("update TB_DOKTER set nama_dokter = '" _
                            & data.Nama_Dokter & "', spesialis='" & data.Spesialis_Dokter _
                            & "', alamat='" & data.Alamat_Dokter & "', no_tlpn='" & data.No_Telepon _
                            & " 'where id_dokter ='" & data.ID_Dokter & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function


    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from TB_DOKTER " _
                             & " where id_dokter='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from TB_DOKTER", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Tabel_Dokter")
            Dim grid As New DataView(DTS.Tables("Tabel_Dokter"))
            Return grid
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from TB_DOKTER where nama_dokter " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Dokter")
            Dim grid As New DataView(DTS.Tables("Cari_Dokter"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try

    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_dokter ,1)) from TB_DOKTER", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "C" & Strings.Right(kodeakhir + 1, 1)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekDokterDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_dokter) from TB_DOKTER " _
                                       & "where id_dokter='" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function

End Class
