Public Class ClsEntRekamMedis
    Private idpasien As String
    Private iddokter As String
    Private idpoli As String
    Private namapasien As String
    Private keluhann As String
    Private dokter As String
    Private diagnosaa As String
    Private namapoli As String
    Private tglperiksa As Date

    Public Property ID_Pasien() As String
        Get
            Return idpasien
        End Get
        Set(value As String)
            idpasien = value
        End Set
    End Property

    Public Property ID_Dokter() As String
        Get
            Return iddokter
        End Get
        Set(value As String)
            iddokter = value
        End Set
    End Property

    Public Property ID_Poli() As String
        Get
            Return idpoli
        End Get
        Set(value As String)
            idpoli = value
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

    Public Property Keluhan() As String
        Get
            Return keluhann
        End Get
        Set(value As String)
            keluhann = value
        End Set
    End Property

    Public Property Nama_Dokter() As String
        Get
            Return dokter
        End Get
        Set(value As String)
            dokter = value
        End Set
    End Property

    Public Property Diagnosa() As String
        Get
            Return diagnosaa
        End Get
        Set(value As String)
            diagnosaa = value
        End Set
    End Property

    Public Property Nama_Poliklinik() As String
        Get
            Return namapoli
        End Get
        Set(value As String)
            namapoli = value
        End Set
    End Property

    Public Property Tanggal_Periksa() As Date
        Get
            Return tglperiksa
        End Get
        Set(value As Date)
            tglperiksa = value
        End Set
    End Property
End Class
