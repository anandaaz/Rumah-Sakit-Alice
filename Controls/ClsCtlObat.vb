Imports System.Data.OleDb

Public Class ClsCtlObat : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        'Throw New NotImplementedException()
        Dim data As New ClsEntObat
        data = Ob
        CMD = New OleDbCommand("insert into TB_OBAT values('" & data.ID_Obat & "','" _
                                & data.Nama_Obat & "','" & data.Keterangan_Obat &
                                "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        'Throw New NotImplementedException()
        Dim data As New ClsEntObat
        data = Ob
        CMD = New OleDbCommand("update TB_OBAT set nama_obat = '" _
                            & data.Nama_Obat & "', keterangan_obat='" & data.Keterangan_Obat _
                            & " 'where id_obat ='" & data.ID_Obat & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from TB_OBAT " _
                             & " where id_obat='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from TB_OBAT", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Tabel_Obat")
            Dim grid As New DataView(DTS.Tables("Tabel_Obat"))
            Return grid
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from TB_OBAT where nama_obat " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Obat")
            Dim grid As New DataView(DTS.Tables("Cari_Obat"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try

    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_obat ,1)) from TB_OBAT", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "O" & Strings.Right(kodeakhir + 1, 1)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekObatDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_obat) from TB_REKAMMEDIS " _
                                       & "where id_obat='" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            'Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function
End Class
