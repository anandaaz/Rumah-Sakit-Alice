Public Class ClsEntPasien
    Private idpasien As String
    Private noidentitas As String
    Private namapasien As String
    Private jenisklmin As String
    Private alamat As String
    Private notelp As String

    Public Property ID_Pasien() As String
        Get
            Return idpasien
        End Get
        Set(value As String)
            idpasien = value
        End Set
    End Property

    Public Property Nomor_Identitas() As String
        Get
            Return noidentitas
        End Get
        Set(value As String)
            noidentitas = value
        End Set
    End Property

    Public Property Nama_Pasien() As String
        Get
            Return namapasien
        End Get
        Set(value As String)
            namapasien = value
        End Set
    End Property

    Public Property Jenis_Kelamin() As String
        Get
            Return jenisklmin
        End Get
        Set(value As String)
            jenisklmin = value
        End Set
    End Property

    Public Property Alamat_Pasien() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property Nomor_Telepon() As String
        Get
            Return notelp
        End Get
        Set(value As String)
            notelp = value
        End Set
    End Property
End Class
