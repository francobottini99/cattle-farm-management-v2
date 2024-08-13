Public Class mdlRaciones

    Dim Id, IdUs As Integer
    Dim Nom, Gr, Conc, Fib, Otr, E As String
    Dim CoGr, CoConc, CoFib, CoOtr As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdRacion()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Nombre()
        Get
            Return Nom
        End Get
        Set(ByVal Valor)
            Nom = Valor
        End Set
    End Property

    Public Property Grano()
        Get
            Return Gr
        End Get
        Set(ByVal Valor)
            Gr = Valor
        End Set
    End Property

    Public Property Concentrado()
        Get
            Return Conc
        End Get
        Set(ByVal Valor)
            Conc = Valor
        End Set
    End Property

    Public Property Fibra()
        Get
            Return Fib
        End Get
        Set(ByVal Valor)
            Fib = Valor
        End Set
    End Property

    Public Property Otros()
        Get
            Return Otr
        End Get
        Set(ByVal Valor)
            Otr = Valor
        End Set
    End Property

    Public Property CostoGrano()
        Get
            Return CoGr
        End Get
        Set(ByVal Valor)
            CoGr = Valor
        End Set
    End Property

    Public Property CostoConc()
        Get
            Return CoConc
        End Get
        Set(ByVal Valor)
            CoConc = Valor
        End Set
    End Property

    Public Property CostoFibra()
        Get
            Return CoFib
        End Get
        Set(ByVal Valor)
            CoFib = Valor
        End Set
    End Property

    Public Property CostoOtros()
        Get
            Return CoOtr
        End Get
        Set(ByVal Valor)
            CoOtr = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Nom As String, ByVal Gr As String, ByVal Conc As String, ByVal Fib As String,
                   ByVal Otr As String, ByVal CoGr As Double, ByVal CoConc As Double, ByVal CoFib As Double, ByVal CoOtr As Double,
                   ByVal IdUs As Integer, ByVal E As String)

        IdRacion = Id
        Nombre = Nom
        Grano = Gr
        Concentrado = Conc
        Fibra = Fib
        Otros = Otr
        CostoGrano = CoGr
        CostoConc = CoConc
        CostoFibra = CoFib
        CostoOtros = CoOtr
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
