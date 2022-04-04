Public Class ClsEntObat
    Private idobat As String
    Private namaobat As String
    Private keterangan As String

    Public Property ID_Obat() As String
        Get
            Return idobat
        End Get
        Set(value As String)
            idobat = value
        End Set
    End Property

    Public Property Nama_Obat() As String
        Get
            Return namaobat
        End Get
        Set(value As String)
            namaobat = value
        End Set
    End Property

    Public Property Keterangan_Obat() As String
        Get
            Return keterangan
        End Get
        Set(value As String)
            keterangan = value
        End Set
    End Property
End Class
