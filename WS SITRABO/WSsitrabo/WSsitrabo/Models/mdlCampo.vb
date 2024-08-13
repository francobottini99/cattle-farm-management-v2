Public Class mdlCampo

    Dim Id, Sup, IdUs As Integer
    Dim Nomb, Prop, Loc, Prov, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdCampo()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Nombre()
        Get
            Return Nomb
        End Get
        Set(ByVal Valor)
            Nomb = Valor
        End Set
    End Property

    Public Property Propietario()
        Get
            Return Prop
        End Get
        Set(ByVal Valor)
            Prop = Valor
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

    Public Property Provincia()
        Get
            Return Prov
        End Get
        Set(ByVal Valor)
            Prov = Valor
        End Set
    End Property

    Public Property Superficie()
        Get
            Return Sup
        End Get
        Set(ByVal Valor)
            Sup = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Nomb As String, ByVal Prop As String, ByVal Loc As String, ByVal Prov As String,
                   ByVal Sup As Integer, ByVal IdUs As Integer, ByVal E As String)

        IdCampo = Id
        Nombre = Nomb
        Propietario = Prop
        Localidad = Loc
        Provincia = Prov
        Superficie = Sup
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
