Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class ConsAlimentacionController
        Inherits ApiController
        <HttpGet>
        <Route("ConsAlimentacion/ListaProductores/{idUs}")>
        Public Function ListaProductores(ByVal idUs As Integer) As String
            Try
                Dim Prod As List(Of mdlProductor) = verProductorUs.Ver(idUs)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Prod.Count > 0 Then
                    For Each Item In Prod
                        Resp = Resp & Item.IdProductor
                        Resp = Resp & "|#$*|" & Item.RazonSocial
                        Resp = Resp & "|#$*|" & Item.Direccion
                        Resp = Resp & "|#$*|" & Item.Localidad
                        Resp = Resp & "|#$*|" & Item.CodPostal
                        Resp = Resp & "|#$*|" & Item.CUIT

                        I = I + 1
                        If I < Prod.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Productores cargados, ingrese Productor para poder Operar !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/ListaTropa/{idUs}")>
        Public Function ListaTropa(ByVal idUs As Integer) As String
            Try
                Dim Trp As List(Of mdlTropa) = verTropaUs.Ver(idUs)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Trp.Count > 0 Then
                    For Each Item In Trp
                        Resp = Resp & Item.IdTropa
                        Resp = Resp & "|#$*|" & Item.NombreTropa
                        Resp = Resp & "|#$*|" & Item.Origen
                        Resp = Resp & "|#$*|" & Item.Fecha
                        Resp = Resp & "|#$*|" & Item.Cabezas
                        Resp = Resp & "|#$*|" & Item.Muertes
                        Resp = Resp & "|#$*|" & Item.Ventas
                        Resp = Resp & "|#$*|" & Item.Stock
                        Resp = Resp & "|#$*|" & Item.PesoIngreso
                        Resp = Resp & "|#$*|" & Item.KgTropa
                        Resp = Resp & "|#$*|" & Item.Observaciones
                        Resp = Resp & "|#$*|" & Item.IdProductor
                        Resp = Resp & "|#$*|" & Item.idCampo
                        Resp = Resp & "|#$*|" & Item.IdProveedor

                        I = I + 1
                        If I < Trp.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Tropas cargadas, ingrese Tropas para poder Operar !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/ListaCorrales/{idUs}")>
        Public Function ListaCorrales(ByVal idUs As Integer) As String
            Try
                Dim Corr As List(Of mdlCorrales) = verCorralesUs.Ver(idUs)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Corr.Count > 0 Then
                    For Each Item In Corr
                        Resp = Resp & Item.IdCorral
                        Resp = Resp & "|#$*|" & Item.Nombre
                        Resp = Resp & "|#$*|" & Item.Superficie
                        Resp = Resp & "|#$*|" & Item.Cabezas
                        Resp = Resp & "|#$*|" & Item.Cabezas
                        Resp = Resp & "|#$*|" & Item.IdCampo

                        I = I + 1
                        If I < Corr.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Corrales cargados, ingrese Corrales para poder Operar !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/ListaCaravanas/{idUs}")>
        Public Function ListaCaravanas(ByVal idUs As Integer) As String
            Try
                Dim DetTr As List(Of mdlDetalleTropa) = verDetalleTropaUs.Ver(idUs)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If DetTr.Count > 0 Then
                    For Each Item In DetTr
                        Resp = Resp & Item.IdDetalleTropa
                        Resp = Resp & "|#$*|" & Item.Caravana
                        Resp = Resp & "|#$*|" & Item.Descripcion
                        Resp = Resp & "|#$*|" & Item.Estado
                        Resp = Resp & "|#$*|" & Item.IdTropa
                        Resp = Resp & "|#$*|" & Item.IdCategoria
                        Resp = Resp & "|#$*|" & Item.IdCorrales
                        Resp = Resp & "|#$*|" & Item.CaravanaRFID

                        I = I + 1
                        If I < DetTr.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Tropas cargadas, ingrese Tropas para poder Operar !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/FiltroAlimFecha/{FecD}/{FecH}/{IdUs}")>
        Public Function FiltroAlimFecha(ByVal FecD As Date, ByVal FecH As Date, ByVal IdUs As Integer) As String
            Try
                Dim Trp As List(Of mdlTropa) = verTropaUs.Ver(IdUs)
                Dim Alm As New mdlAlimentacionProrateo
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Trp.Count > 0 Then
                    For Each Item In Trp
                        Alm = consAlimTropasYFechas.Ver(Item.IdTropa, FecD, FecH)
                        If Alm.KgRacion > 0 Then
                            Resp = Resp & Alm.KgRacion
                            Resp = Resp & "|#$*|" & Alm.KgGrano
                            Resp = Resp & "|#$*|" & Alm.KgConc
                            Resp = Resp & "|#$*|" & Alm.KgFibra
                            Resp = Resp & "|#$*|" & Alm.KgOtros
                            Resp = Resp & "|#$*|" & Alm.ImpGrano
                            Resp = Resp & "|#$*|" & Alm.ImpConc
                            Resp = Resp & "|#$*|" & Alm.ImpFibra
                            Resp = Resp & "|#$*|" & Alm.ImpOtros
                            Resp = Resp & "|#$*|" & Alm.ImpTotal
                            Resp = Resp & "|#$*|" & Alm.PorcGrano
                            Resp = Resp & "|#$*|" & Alm.PorcConc
                            Resp = Resp & "|#$*|" & Alm.PorcFibra
                            Resp = Resp & "|#$*|" & Alm.PorcOtros
                            Resp = Resp & "|#$*|" & Alm.Err

                            I = I + 1
                            If I < Trp.Count Then
                                Resp = Resp & "|%@!|"
                            End If
                        End If
                    Next
                    If Resp = "" Then
                        Return "Error: No hay Datos para los parámetros consultados !"
                    Else
                        Return "OK&%&%" & Resp
                    End If
                Else
                    Return "Error: No hay Datos para los parámetros consultados !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/FiltroAlimProd/{FecD}/{FecH}/{idPr}")>
        Public Function FiltroAlimProd(ByVal FecD As Date, ByVal FecH As Date, ByVal idPr As Integer) As String
            Try
                Dim Trp As List(Of mdlTropa) = consTropasPorProdYFecha.Ver(idPr)
                Dim Alm As New mdlAlimentacionProrateo
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Trp.Count > 0 Then
                    For Each Item In Trp
                        Alm = consAlimTropasYFechas.Ver(Item.IdTropa, FecD, FecH)
                        If Alm.KgRacion > 0 Then
                            Resp = Resp & Alm.KgRacion
                            Resp = Resp & "|#$*|" & Alm.KgGrano
                            Resp = Resp & "|#$*|" & Alm.KgConc
                            Resp = Resp & "|#$*|" & Alm.KgFibra
                            Resp = Resp & "|#$*|" & Alm.KgOtros
                            Resp = Resp & "|#$*|" & Alm.ImpGrano
                            Resp = Resp & "|#$*|" & Alm.ImpConc
                            Resp = Resp & "|#$*|" & Alm.ImpFibra
                            Resp = Resp & "|#$*|" & Alm.ImpOtros
                            Resp = Resp & "|#$*|" & Alm.ImpTotal
                            Resp = Resp & "|#$*|" & Alm.PorcGrano
                            Resp = Resp & "|#$*|" & Alm.PorcConc
                            Resp = Resp & "|#$*|" & Alm.PorcFibra
                            Resp = Resp & "|#$*|" & Alm.PorcOtros
                            Resp = Resp & "|#$*|" & Alm.Err

                            I = I + 1
                            If I < Trp.Count Then
                                Resp = Resp & "|%@!|"
                            End If
                        End If
                    Next
                    If Resp = "" Then
                        Return "Error: No hay Datos para los parámetros consultados !"
                    Else
                        Return "OK&%&%" & Resp
                    End If
                Else
                    Return "Error: No hay Datos para los parámetros consultados !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/FiltroAlimTropa/{FecD}/{FecH}/{idTr}")>
        Public Function FiltroAlimTropa(ByVal FecD As Date, ByVal FecH As Date, ByVal idTr As Integer) As String
            Try
                Dim Alm As New mdlAlimentacionProrateo
                Dim Resp As String = ""
                Dim I As Integer = 0

                Alm = consAlimTropasYFechas.Ver(idTr, FecD, FecH)
                If Alm.KgRacion > 0 Then
                    Resp = Resp & Alm.KgRacion
                    Resp = Resp & "|#$*|" & Alm.KgGrano
                    Resp = Resp & "|#$*|" & Alm.KgConc
                    Resp = Resp & "|#$*|" & Alm.KgFibra
                    Resp = Resp & "|#$*|" & Alm.KgOtros
                    Resp = Resp & "|#$*|" & Alm.ImpGrano
                    Resp = Resp & "|#$*|" & Alm.ImpConc
                    Resp = Resp & "|#$*|" & Alm.ImpFibra
                    Resp = Resp & "|#$*|" & Alm.ImpOtros
                    Resp = Resp & "|#$*|" & Alm.ImpTotal
                    Resp = Resp & "|#$*|" & Alm.PorcGrano
                    Resp = Resp & "|#$*|" & Alm.PorcConc
                    Resp = Resp & "|#$*|" & Alm.PorcFibra
                    Resp = Resp & "|#$*|" & Alm.PorcOtros
                    Resp = Resp & "|#$*|" & Alm.Err

                    Resp = Resp & "|%@!|"
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Datos para los parámetros consultados !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/FiltroAlimCorral/{FecD}/{FecH}/{idCrr}")>
        Public Function FiltroAlimCorral(ByVal FecD As Date, ByVal FecH As Date, ByVal idCrr As Integer) As String
            Try
                Dim Crr As List(Of mdlCorrales) = consTropasPorCorralYFecha.Ver(idCrr)
                Dim Alm As New mdlAlimentacionProrateo
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Crr.Count > 0 Then
                    For Each Item In Crr
                        Alm = consAlimTropasYFechas.Ver(Item.Err, FecD, FecH)
                        If Alm.KgRacion > 0 Then
                            Resp = Resp & Alm.KgRacion
                            Resp = Resp & "|#$*|" & Alm.KgGrano
                            Resp = Resp & "|#$*|" & Alm.KgConc
                            Resp = Resp & "|#$*|" & Alm.KgFibra
                            Resp = Resp & "|#$*|" & Alm.KgOtros
                            Resp = Resp & "|#$*|" & Alm.ImpGrano
                            Resp = Resp & "|#$*|" & Alm.ImpConc
                            Resp = Resp & "|#$*|" & Alm.ImpFibra
                            Resp = Resp & "|#$*|" & Alm.ImpOtros
                            Resp = Resp & "|#$*|" & Alm.ImpTotal
                            Resp = Resp & "|#$*|" & Alm.PorcGrano
                            Resp = Resp & "|#$*|" & Alm.PorcConc
                            Resp = Resp & "|#$*|" & Alm.PorcFibra
                            Resp = Resp & "|#$*|" & Alm.PorcOtros
                            Resp = Resp & "|#$*|" & Alm.Err

                            I = I + 1
                            If I < Crr.Count Then
                                Resp = Resp & "|%@!|"
                            End If
                        End If
                    Next
                    If Resp = "" Then
                        Return "Error: No hay Datos para los parámetros consultados !"
                    Else
                        Return "OK&%&%" & Resp
                    End If
                Else
                    Return "Error: No hay Datos para los parámetros consultados !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("ConsAlimentacion/FiltroAlimCaravana/{FecD}/{FecH}/{idCv}")>
        Public Function FiltroAlimCaravana(ByVal FecD As Date, ByVal FecH As Date, ByVal idCv As String) As String
            Try
                Dim Alm As New mdlAlimentacionProrateo
                Dim Resp As String = ""
                Dim I As Integer = 0

                Alm = consCaravRFIDYFecha.Ver(idCv, FecD, FecH)
                If Alm.KgRacion > 0 Then
                    Resp = Resp & Alm.KgRacion
                    Resp = Resp & "|#$*|" & Alm.KgGrano
                    Resp = Resp & "|#$*|" & Alm.KgConc
                    Resp = Resp & "|#$*|" & Alm.KgFibra
                    Resp = Resp & "|#$*|" & Alm.KgOtros
                    Resp = Resp & "|#$*|" & Alm.ImpGrano
                    Resp = Resp & "|#$*|" & Alm.ImpConc
                    Resp = Resp & "|#$*|" & Alm.ImpFibra
                    Resp = Resp & "|#$*|" & Alm.ImpOtros
                    Resp = Resp & "|#$*|" & Alm.ImpTotal
                    Resp = Resp & "|#$*|" & Alm.PorcGrano
                    Resp = Resp & "|#$*|" & Alm.PorcConc
                    Resp = Resp & "|#$*|" & Alm.PorcFibra
                    Resp = Resp & "|#$*|" & Alm.PorcOtros
                    Resp = Resp & "|#$*|" & Alm.Err

                    Resp = Resp & "|%@!|"
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay Datos para los parámetros consultados !"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace