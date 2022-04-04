Public Class ClsEntDokter
    Private iddokter As String
    Private namadokter As String
    Private spesialis As String
    Private alamat As String
    Private notlp As String
    Public Property ID_Dokter() As String
        Get
            Return iddokter
        End Get
        Set(value As String)
            iddokter = value
        End Set
    End Property

    Public Property Nama_Dokter() As String
        Get
            Return namadokter
        End Get
        Set(value As String)
            namadokter = value
        End Set
    End Property

    Public Property Spesialis_Dokter() As String
        Get
            Return spesialis
        End Get
        Set(value As String)
            spesialis = value
        End Set
    End Property

    Public Property Alamat_Dokter() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property No_Telepon() As String
        Get
            Return notlp
        End Get
        Set(value As String)
            notlp = value
        End Set
    End Property


End Class
