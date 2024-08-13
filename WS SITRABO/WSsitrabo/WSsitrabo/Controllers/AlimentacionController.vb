Imports System.Web.Http

Namespace Controllers
    Public Class AlimentacionController
        Inherits ApiController

        <HttpGet>
        <Route("Alimentacion/grabarAlimentacion/{Fec}/{idCrr}/{IdUs}/{idR}/{kgG}/{kgC}/{kgF}/{kgO}")>
        Public Function grabarAlimentacion(ByVal Fec As Date, ByVal idCrr As Integer, ByVal IdUs As Integer, ByVal idR As Integer,
                                           ByVal kgG As Double, ByVal kgC As Double, ByVal kgF As Double, ByVal kgO As Double) As String


            Dim Fecha As Date
            Dim CostG, CostF, CostC, CostO, PGr, PCo, PFb, POt, Peso, ConsumoT, TotalConsT, PorCons, TotalRac As Double
            Dim Dias, x As Integer
            Dim Consumo(1, 2) As Double
            Dim Resp As String = ""
            Dim Alimentacion As New mdlAlimentacion
            Dim TropaBloqueoMod As New mdlTropaBloqueo
            Dim ListaStkCorralesUs As New List(Of mdlDetalleTropa)
            Dim RacionesUsId As New mdlRaciones
            Dim PesoEstimado As New mdlPesosEstimados
            Dim MaxIdAlimentacion As String
            Dim ListaStkDia As New List(Of mdlStock)
            Dim ListaStkCorralFec As New List(Of mdlStock)
            Dim PesajeDetalleTropa As New mdlPesaje
            Dim TropaPesoIngresoUS As New mdlTropa
            Dim AlimentacionProrrateo As New mdlAlimentacionProrateo

            Try
                ListaStkCorralesUs = verStocCorralesUs.Ver(IdUs, "Engorde")

                If ListaStkCorralesUs.Item(0).Err = "OK" Then
                    ReDim Consumo(ListaStkCorralesUs.Count, 2)
                    x = 0

                    RacionesUsId = verRacionUsId.Ver(IdUs, idR)

                    If RacionesUsId.Err = "OK" Then
                        TotalRac = kgG + kgC + kgF + kgO

                        CostG = kgG * RacionesUsId.CostoGrano
                        CostC = kgC * RacionesUsId.CostoConc
                        CostF = kgF * RacionesUsId.CostoFibra
                        CostO = kgO * RacionesUsId.CostoOtros

                        PGr = kgG / TotalRac * 100
                        PCo = kgC / TotalRac * 100
                        PFb = kgF / TotalRac * 100
                        POt = kgO / TotalRac * 100

                        Alimentacion.Fecha = Fec
                        Alimentacion.KgRacion = TotalRac
                        Alimentacion.Turno = "-"
                        Alimentacion.KgGrano = kgG
                        Alimentacion.KgConc = kgC
                        Alimentacion.KgFibra = kgF
                        Alimentacion.KgOtros = kgO
                        Alimentacion.ImpGrano = CostG
                        Alimentacion.ImpConc = CostC
                        Alimentacion.ImpFibra = CostF
                        Alimentacion.ImpOtros = CostO
                        Alimentacion.ImpTotal = CostG + CostC + CostF + CostO
                        Alimentacion.PorcGrano = PGr
                        Alimentacion.PorcConc = PCo
                        Alimentacion.PorcFibra = PFb
                        Alimentacion.PorcOtros = POt
                        Alimentacion.Observaciones = "-"
                        Alimentacion.IdCorral = idCrr
                        Alimentacion.IdRacion = idR
                        Alimentacion.IdUsuario = IdUs

                        Dim ResInsert As String = insAlimentacion.Insertar(Alimentacion)

                        If ResInsert = "Registro insertado" Then
                            MaxIdAlimentacion = verMaxIdAlimentacion.Ver()

                            If MaxIdAlimentacion <> "" Then
                                Fecha = FechaStock(Fec, IdUs)

                                ListaStkCorralFec = verStkCorralFec.Ver(IdUs, idCrr, Fecha)

                                If ListaStkCorralFec.Item(0).Err = "OK" Then
                                    For Each item In ListaStkCorralFec
                                        PesajeDetalleTropa = verPesajeDtalleTropa.Ver(IdUs, item.IdDetalleTropa)
                                        TropaPesoIngresoUS = verTropaPesoIngresoUS.Ver(IdUs, item.IdTropa)

                                        TropaBloqueoMod.IdTropa = item.IdTropa

                                        ResInsert = modEstadoMod.Modificar(TropaBloqueoMod)

                                        If ResInsert = "Registro modificado" Then
                                            If PesajeDetalleTropa.Err = "OK" Then
                                                Peso = PesajeDetalleTropa.Peso
                                                Dias = DateDiff(DateInterval.Day, PesajeDetalleTropa.Fecha, Fec)
                                            Else
                                                Peso = TropaPesoIngresoUS.PesoIngreso
                                                Dias = DateDiff(DateInterval.Day, TropaPesoIngresoUS.Fecha, Fec)
                                            End If

                                            'For j As Integer = 0 To Dias
                                            '    Peso = Peso + (Peso * 0.03 / (5 + (15.35 - 5) * (Peso / 800)))
                                            'Next

                                            Peso += ((0.03 - 0.02 / (1 + (Dias ^ 3))) * Peso * Dias) / (15.35 - 10.35 / (1 + (Peso / 600)))

                                            TotalConsT = TotalConsT + (Peso * 0.03)
                                            Consumo(x, 1) = item.IdDetalleTropa
                                            Consumo(x, 2) = Peso * 0.03

                                            x = x + 1
                                        Else
                                            Return ResInsert
                                        End If
                                    Next

                                    For j As Integer = 0 To x - 1
                                        PorCons = Consumo(j, 2) / TotalConsT

                                        AlimentacionProrrateo.Fecha = Fec
                                        AlimentacionProrrateo.KgRacion = TotalRac * PorCons
                                        AlimentacionProrrateo.KgGrano = kgG * PorCons
                                        AlimentacionProrrateo.KgConc = kgC * PorCons
                                        AlimentacionProrrateo.KgFibra = kgF * PorCons
                                        AlimentacionProrrateo.KgOtros = kgO * PorCons
                                        AlimentacionProrrateo.ImpGrano = CostG * PorCons
                                        AlimentacionProrrateo.ImpConc = CostC * PorCons
                                        AlimentacionProrrateo.ImpFibra = CostF * PorCons
                                        AlimentacionProrrateo.ImpOtros = CostO * PorCons
                                        AlimentacionProrrateo.ImpTotal = (CostC + CostG + CostF + CostO) * PorCons
                                        AlimentacionProrrateo.PorcGrano = PGr
                                        AlimentacionProrrateo.PorcConc = PCo
                                        AlimentacionProrrateo.PorcFibra = PFb
                                        AlimentacionProrrateo.PorcOtros = POt
                                        AlimentacionProrrateo.IdRacion = idR
                                        AlimentacionProrrateo.IdDetalleTropa = CInt(Consumo(j, 1))
                                        AlimentacionProrrateo.IdUsuario = IdUs
                                        AlimentacionProrrateo.IdAlimentacion = CInt(MaxIdAlimentacion)

                                        Resp = insAlimentacionProrrateo.Insertar(AlimentacionProrrateo)

                                    Next

                                    TotalConsT = 0
                                    x = 0

                                    Return "Alimentación Guardada !"
                                Else
                                    Return "6 " + ListaStkCorralFec.Item(0).Err
                                End If

                            Else
                                Return "5 " + MaxIdAlimentacion
                            End If

                        Else
                            Return "4 " + ResInsert
                        End If

                    Else
                        Return "3 " + RacionesUsId.Err
                    End If
                Else
                    Return "2 " + ListaStkCorralesUs.Item(0).Err
                End If
            Catch ex As Exception
                Return "1 " + ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("Alimentacion/Raciones/{idU}")>
        Public Function Raciones(ByVal idU As Integer) As String
            Try
                Dim Rac As New List(Of mdlRaciones)
                Dim i As Integer = 0
                Dim Resp As String = ""

                Rac = verRacionUs.Ver(idU)

                If Rac.Item(0).Err = "OK" Then
                    For Each Item In Rac
                        Resp = Resp & Item.IdRacion
                        Resp = Resp & "|#$*|" & Item.Nombre
                        Resp = Resp & "|#$*|" & Item.Grano
                        Resp = Resp & "|#$*|" & Item.Concentrado
                        Resp = Resp & "|#$*|" & Item.Fibra
                        Resp = Resp & "|#$*|" & Item.Otros
                        Resp = Resp & "|#$*|" & Item.CostoGrano
                        Resp = Resp & "|#$*|" & Item.CostoConc
                        Resp = Resp & "|#$*|" & Item.CostoFibra
                        Resp = Resp & "|#$*|" & Item.CostoOtros

                        i = i + 1

                        If i < Rac.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return Rac.Item(0).Err
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("Alimentacion/Corrales/{Fec}/{idU}")>
        Public Function Corrales(ByVal Fec As Date, ByVal idU As Integer) As String
            Try
                Dim ListaStockUs As New List(Of mdlStock)
                Dim ListaStockDia As New List(Of mdlStock)
                Dim ListaStockCorralFecha As New List(Of mdlStock)
                Dim ListaCorralesUs As New List(Of mdlCorrales)
                Dim Resp As String = ""
                Dim i As Integer = 0

                ListaStockUs = verStockUs.Ver(idU)

                If ListaStockUs.Item(0).Err = "OK" Then
                    ListaStockDia = verStkDia.Ver(Fec, idU)

                    If ListaStockDia.Item(0).Err <> "OK" Then
                        Fec = FechaStock(Fec, idU)
                    End If

                    ListaCorralesUs = verCorralesUs.Ver(idU)

                    Dim rows As Integer = ListaCorralesUs.Count - 1

                    For j As Integer = rows To 0 Step -1
                        ListaStockCorralFecha = verStkCorralFec.Ver(idU, ListaCorralesUs.Item(j).IdCorral, Fec)

                        If ListaStockCorralFecha.Item(0).Err <> "OK" Then
                            ListaCorralesUs.Remove(ListaCorralesUs.Item(j))
                        End If
                    Next

                    If ListaCorralesUs.Count > 0 Then
                        For Each Item In ListaCorralesUs
                            Resp = Resp & Item.IdCorral
                            Resp = Resp & "|#$*|" & Item.Nombre
                            Resp = Resp & "|#$*|" & Item.Superficie
                            Resp = Resp & "|#$*|" & Item.Cabezas
                            Resp = Resp & "|#$*|" & Item.IdCampo

                            i = i + 1

                            If i < ListaCorralesUs.Count Then
                                Resp = Resp & "|%@!|"
                            End If
                        Next

                        Return "OK&%&%" & Resp
                    Else
                        Return "Error: No hay corrales con Stock"
                    End If
                Else
                    Return "Error: No hay registro de Stock !"
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <NonAction()>
        Function FechaStock(ByVal Fecha As Date, ByVal idUsuario As Integer) As Date
            Dim ListaStkDia As New List(Of mdlStock)

            While True
                ListaStkDia = verStkDia.Ver(Fecha, idUsuario)

                If ListaStkDia.Item(0).Err = "OK" Then
                    Fecha = ListaStkDia.Item(0).Fecha
                    Exit While
                Else
                    Fecha = DateAdd(DateInterval.Day, -1, Fecha)
                End If
            End While

            Return Fecha
        End Function

        <NonAction()>
        Function PesoConsumo(ByVal D As Integer, ByVal P As Integer) As Integer
            Dim PesoEstimado As New mdlPesosEstimados
            Dim Peso As Integer

            PesoEstimado = verPesoEstimadoPorAnimal.Ver(P)

            Select Case D
                Case 1
                    Peso = PesoEstimado.Dia001
                Case 2
                    Peso = PesoEstimado.Dia002
                Case 3
                    Peso = PesoEstimado.Dia003
                Case 4
                    Peso = PesoEstimado.Dia004
                Case 5
                    Peso = PesoEstimado.Dia005
                Case 6
                    Peso = PesoEstimado.Dia006
                Case 7
                    Peso = PesoEstimado.Dia007
                Case 8
                    Peso = PesoEstimado.Dia008
                Case 9
                    Peso = PesoEstimado.Dia009
                Case 10
                    Peso = PesoEstimado.Dia010
                Case 11
                    Peso = PesoEstimado.Dia011
                Case 12
                    Peso = PesoEstimado.Dia012
                Case 13
                    Peso = PesoEstimado.Dia013
                Case 14
                    Peso = PesoEstimado.Dia014
                Case 15
                    Peso = PesoEstimado.Dia015
                Case 16
                    Peso = PesoEstimado.Dia016
                Case 17
                    Peso = PesoEstimado.Dia017
                Case 18
                    Peso = PesoEstimado.Dia018
                Case 19
                    Peso = PesoEstimado.Dia019
                Case 20
                    Peso = PesoEstimado.Dia020
                Case 21
                    Peso = PesoEstimado.Dia021
                Case 22
                    Peso = PesoEstimado.Dia022
                Case 23
                    Peso = PesoEstimado.Dia023
                Case 24
                    Peso = PesoEstimado.Dia024
                Case 25
                    Peso = PesoEstimado.Dia025
                Case 26
                    Peso = PesoEstimado.Dia026
                Case 27
                    Peso = PesoEstimado.Dia027
                Case 28
                    Peso = PesoEstimado.Dia028
                Case 29
                    Peso = PesoEstimado.Dia029
                Case 30
                    Peso = PesoEstimado.Dia030
                Case 31
                    Peso = PesoEstimado.Dia031
                Case 32
                    Peso = PesoEstimado.Dia032
                Case 33
                    Peso = PesoEstimado.Dia033
                Case 34
                    Peso = PesoEstimado.Dia034
                Case 35
                    Peso = PesoEstimado.Dia035
                Case 36
                    Peso = PesoEstimado.Dia036
                Case 37
                    Peso = PesoEstimado.Dia037
                Case 38
                    Peso = PesoEstimado.Dia038
                Case 39
                    Peso = PesoEstimado.Dia039
                Case 40
                    Peso = PesoEstimado.Dia040
                Case 41
                    Peso = PesoEstimado.Dia041
                Case 42
                    Peso = PesoEstimado.Dia042
                Case 43
                    Peso = PesoEstimado.Dia043
                Case 44
                    Peso = PesoEstimado.Dia044
                Case 45
                    Peso = PesoEstimado.Dia045
                Case 46
                    Peso = PesoEstimado.Dia046
                Case 47
                    Peso = PesoEstimado.Dia047
                Case 48
                    Peso = PesoEstimado.Dia048
                Case 49
                    Peso = PesoEstimado.Dia049
                Case 50
                    Peso = PesoEstimado.Dia050
                Case 51
                    Peso = PesoEstimado.Dia051
                Case 52
                    Peso = PesoEstimado.Dia052
                Case 53
                    Peso = PesoEstimado.Dia053
                Case 54
                    Peso = PesoEstimado.Dia054
                Case 55
                    Peso = PesoEstimado.Dia055
                Case 56
                    Peso = PesoEstimado.Dia056
                Case 57
                    Peso = PesoEstimado.Dia057
                Case 58
                    Peso = PesoEstimado.Dia058
                Case 59
                    Peso = PesoEstimado.Dia059
                Case 60
                    Peso = PesoEstimado.Dia060
                Case 61
                    Peso = PesoEstimado.Dia061
                Case 62
                    Peso = PesoEstimado.Dia062
                Case 63
                    Peso = PesoEstimado.Dia063
                Case 64
                    Peso = PesoEstimado.Dia064
                Case 65
                    Peso = PesoEstimado.Dia065
                Case 66
                    Peso = PesoEstimado.Dia066
                Case 67
                    Peso = PesoEstimado.Dia067
                Case 68
                    Peso = PesoEstimado.Dia068
                Case 69
                    Peso = PesoEstimado.Dia069
                Case 70
                    Peso = PesoEstimado.Dia070
                Case 71
                    Peso = PesoEstimado.Dia071
                Case 72
                    Peso = PesoEstimado.Dia072
                Case 73
                    Peso = PesoEstimado.Dia073
                Case 74
                    Peso = PesoEstimado.Dia074
                Case 75
                    Peso = PesoEstimado.Dia075
                Case 76
                    Peso = PesoEstimado.Dia076
                Case 77
                    Peso = PesoEstimado.Dia077
                Case 78
                    Peso = PesoEstimado.Dia078
                Case 79
                    Peso = PesoEstimado.Dia079
                Case 80
                    Peso = PesoEstimado.Dia080
                Case 81
                    Peso = PesoEstimado.Dia081
                Case 82
                    Peso = PesoEstimado.Dia082
                Case 83
                    Peso = PesoEstimado.Dia083
                Case 84
                    Peso = PesoEstimado.Dia084
                Case 85
                    Peso = PesoEstimado.Dia085
                Case 86
                    Peso = PesoEstimado.Dia086
                Case 87
                    Peso = PesoEstimado.Dia087
                Case 88
                    Peso = PesoEstimado.Dia088
                Case 89
                    Peso = PesoEstimado.Dia089
                Case 90
                    Peso = PesoEstimado.Dia090
                Case 91
                    Peso = PesoEstimado.Dia091
                Case 92
                    Peso = PesoEstimado.Dia092
                Case 93
                    Peso = PesoEstimado.Dia093
                Case 94
                    Peso = PesoEstimado.Dia094
                Case 95
                    Peso = PesoEstimado.Dia095
                Case 96
                    Peso = PesoEstimado.Dia096
                Case 97
                    Peso = PesoEstimado.Dia097
                Case 98
                    Peso = PesoEstimado.Dia098
                Case 99
                    Peso = PesoEstimado.Dia099
                Case 100
                    Peso = PesoEstimado.Dia100
            End Select
            Return Peso
        End Function

    End Class
End Namespace