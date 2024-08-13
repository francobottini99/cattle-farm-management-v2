Module ManejoSTK
    Public Function Modificar(ByVal Fecha As Date, ByVal IdUs As Integer)
        Dim StkD As New List(Of mdlStock)
        Dim StkCrrD As New List(Of mdlDetalleTropa)
        Dim StkDiaCrr As New List(Of mdlDetalleTropa)
        Dim Corr As New List(Of mdlCorrales)
        Dim STK As New mdlStock
        Dim Brr As String = ""
        Dim BorrarStk As Boolean = False
        Dim Resp As String = ""

        StkD = verStkDia.Ver(Fecha, IdUs)
        If StkD.Count < 1 Then
            BorrarStk = False
        Else
            BorrarStk = True
        End If

        If BorrarStk = True Then
            Brr = modBorrarStock.Borrar(Fecha, IdUs)
        End If

        If Brr = "Registros Borrados" Then
            StkCrrD = verStocCorralesUs.Ver(IdUs, "Engorde")
            For Each Item In StkCrrD
                STK.Fecha = Fecha
                STK.Caravana = Item.Caravana
                STK.Descripcion = Item.Descripcion
                STK.Cabezas = 1
                STK.IdTropa = Item.IdTropa
                STK.IdDetalleTropa = Item.IdDetalleTropa
                STK.IdCorrales = Item.IdCorrales
                STK.IdCategorias = Item.IdCategoria
                STK.IdUsuario = IdUs

                Resp = insStock.Insertar(STK)
            Next

            If Resp = "Registro insertado" Then
                Corr = verCorralesUs.Ver(IdUs)
                For Each Item In Corr
                    StkDiaCrr = verStocDiariokUs.Ver("Engorde", Item.IdCorral, IdUs)

                    Resp = modCorral.Modificar(Item.IdCorral, StkDiaCrr.Count)
                Next
                If Resp = "Registro Modificado" Then
                    Return "Stock Modificado"
                Else
                    Return "Error al intentar modificar Cabezas Totales Por Corral !"
                End If
            Else
                Return "Error al modificar la tabla Stock"
            End If
        Else
            Return "Error al borrar registros de la tabla Stock"
        End If
    End Function
End Module
