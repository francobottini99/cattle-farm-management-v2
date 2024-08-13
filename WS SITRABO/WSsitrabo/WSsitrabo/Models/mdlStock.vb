Public Class mdlStock

    Dim Id, IdTr, IdDetTr, IdCrr, IdCat, IdUs, Cab As Integer
    Dim Fec As Date
    Dim Carav, Desc, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdStock()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Fecha()
        Get
            Return Fec
        End Get
        Set(ByVal Valor)
            Fec = Valor
        End Set
    End Property

    Public Property Caravana()
        Get
            Return Carav
        End Get
        Set(ByVal Valor)
            Carav = Valor
        End Set
    End Property

    Public Property Descripcion()
        Get
            Return Desc
        End Get
        Set(ByVal Valor)
            Desc = Valor
        End Set
    End Property

    Public Property Cabezas()
        Get
            Return Cab
        End Get
        Set(ByVal Valor)
            Cab = Valor
        End Set
    End Property

    Public Property IdTropa()
        Get
            Return IdTr
        End Get
        Set(ByVal Valor)
            IdTr = Valor
        End Set
    End Property

    Public Property IdDetalleTropa()
        Get
            Return IdDetTr
        End Get
        Set(ByVal Valor)
            IdDetTr = Valor
        End Set
    End Property

    Public Property IdCorrales()
        Get
            Return IdCrr
        End Get
        Set(ByVal Valor)
            IdCrr = Valor
        End Set
    End Property

    Public Property IdCategorias()
        Get
            Return IdCat
        End Get
        Set(ByVal Valor)
            IdCat = Valor
        End Set
    End Property

    Public Property IdUsuario()
        Get
            Return IdUs
        End Get
        Set(ByVal Valor)
            IdUs = Valor
        End Set
    End Property

    Public Property Err()
        Get
            Return E
        End Get
        Set(ByVal Valor)
            E = Valor
        End Set
    End Property


    'CONSTRUCTORES
    '---------------------------------------------------------------------------------------------

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal Carav As String, ByVal Desc As String, ByVal Cab As Integer,
                   ByVal IdTr As Integer, ByVal IdDetTr As Integer, ByVal IdCrr As Integer, ByVal IdCat As Integer, ByVal IdUs As Integer, ByVal E As String)

        IdStock = Id
        Fecha = Fec
        Caravana = Carav
        Descripcion = Desc
        Cabezas = Cab
        IdTropa = IdTr
        IdDetalleTropa = IdDetTr
        IdCorrales = IdCrr
        IdCategorias = IdCat
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
