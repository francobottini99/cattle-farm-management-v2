Public Class mdlProductor

    Dim Id, IdUs As Integer
    Dim RazSoc, Dir, Loc, CP, Cu, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdProductor()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property RazonSocial()
        Get
            Return RazSoc
        End Get
        Set(ByVal Valor)
            RazSoc = Valor
        End Set
    End Property

    Public Property Direccion()
        Get
            Return Dir
        End Get
        Set(ByVal Valor)
            Dir = Valor
        End Set
    End Property

    Public Property Localidad()
        Get
            Return Loc
        End Get
        Set(ByVal Valor)
            Loc = Valor
        End Set
    End Property

    Public Property CodPostal()
        Get
            Return CP
        End Get
        Set(ByVal Valor)
            CP = Valor
        End Set
    End Property

    Public Property CUIT()
        Get
            Return Cu
        End Get
        Set(ByVal Valor)
            Cu = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal RazSoc As String, ByVal Dir As String, ByVal Loc As String, ByVal CP As String,
                   ByVal Cu As String, ByVal IdUs As Integer, ByVal E As String)

        IdProductor = Id
        RazonSocial = RazSoc
        Direccion = Dir
        Localidad = Loc
        CodPostal = CP
        CUIT = Cu
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
