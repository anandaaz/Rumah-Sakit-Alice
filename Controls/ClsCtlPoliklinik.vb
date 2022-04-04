Imports System.Data.OleDb

Public Class ClsCtlPoliklinik : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        'Throw New NotImplementedException()
        Dim data As New ClsEntPoliklinik
        data = Ob
        CMD = New OleDbCommand("insert into TB_POLIKLINIK values('" & data.ID_Poli & "','" _
                                & data.Nama_Poliklinik & "','" & data.Gedung_Poliklinik & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        'Throw New NotImplementedException()
        Dim data As New ClsEntPoliklinik
        data = Ob
        CMD = New OleDbCommand("update TB_POLIKLINIK set nama_poli = '" _
                            & data.Nama_Poliklinik & "', gedung='" & data.Gedung_Poliklinik _
                            & " 'where id_poli ='" & data.ID_Poli & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from TB_POLIKLINIK " _
                             & " where id_poli='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from TB_POLIKLINIK", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Tabel_Poliklinik")
            Dim grid As New DataView(DTS.Tables("Tabel_Poliklinik"))
            Return grid
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from TB_POLIKLINIK where nama_poli " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Poliklinik")
            Dim grid As New DataView(DTS.Tables("Cari_Poliklinik"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_poli ,1)) from TB_POLIKLINIK", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K" & Strings.Right(kodeakhir + 1, 1)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekPoliklinikDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_poli) from TB_REKAMMEDIS " _
                                       & "where id_poli='" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            'Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function
End Class
