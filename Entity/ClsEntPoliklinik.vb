Public Class ClsEntPoliklinik
    Private idpoli As String
    Private namapoli As String
    Private gedung As String

    Public Property ID_Poli() As String
        Get
            Return idpoli
        End Get
        Set(value As String)
            idpoli = value
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

    Public Property Gedung_Poliklinik() As String
        Get
            Return gedung
        End Get
        Set(value As String)
            gedung = value
        End Set
    End Property
End Class
