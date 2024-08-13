Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaTropaController
        Inherits ApiController

        <HttpGet>
        <Route("AltaTropa/grabarTropa/{nT}/{pT}/{Fec}/{cabT}/{kgCab}/{kgTot}/{obT}/{idPr}/{idCa}/{idPv}/{idcrr}/{idUs}")>
        Public Function grabarTropa(ByVal nT As String, ByVal pT As String, ByVal Fec As Date, ByVal cabT As Integer, ByVal kgCab As Double,
                                  ByVal kgTot As Integer, ByVal obT As String, ByVal idPr As Integer, ByVal idCa As Integer,
                                  ByVal idPv As Integer, ByVal idcrr As Integer, ByVal idUs As Integer) As String

            Dim Stk As New List(Of mdlStock)
            Dim Tropa As New mdlTropa
            Dim TropaBloqueoMod As New mdlTropaBloqueo
            Dim DetTr As New mdlDetalleTropa
            Dim Compra As New mdlCompras
            Dim ulTid As String

            Try
                Dim Fecha As Date

                Stk = verStock.Ver()
                If Stk.Count < 1 Then
                    Fecha = Format(CDate("01/01/1777"), "dd/MM/yyyy")
                Else
                    Fecha = Stk.Item(Stk.Count - 1).Fecha
                End If

                If Format(CDate(Fec), "dd/MM/yyyy") < Fecha Then
                    Return "Error No puede ingresar un tropa con fecha anterior al ultimo movimienro de stock"
                End If

                Tropa.NombreTropa = nT
                Tropa.Origen = pT
                Tropa.Fecha = Fec
                Tropa.Cabezas = cabT
                Tropa.Muertes = 0
                Tropa.Ventas = 0
                Tropa.Stock = cabT
                Tropa.PesoIngreso = kgCab
                Tropa.KgTropa = kgTot
                Tropa.Observaciones = obT
                Tropa.IdProductor = idPr
                Tropa.idCampo = idCa
                Tropa.IdProveedor = idPr
                Tropa.IdUsuario = idUs

                Dim Resp As String = insTropa.Insertar(Tropa)

                If Resp = "Registro insertado" Then
                    ulTid = verMaxIdTropa.Ver
                    If ulTid = "" Then
                        ulTid = "0"
                    End If

                    TropaBloqueoMod.IdTropa = ulTid

                    Resp = insEstadoMod.Insertar(TropaBloqueoMod)

                    For i As Integer = 1 To cabT
                        DetTr.Caravana = "***"
                        DetTr.Descripcion = "-"
                        DetTr.Estado = "Engorde"
                        DetTr.IdTropa = CInt(ulTid)
                        DetTr.IdCategoria = 7
                        DetTr.IdCorrales = idcrr
                        DetTr.IdUsuario = idUs
                        DetTr.CaravanaRFID = "00 00 00 00 00 00 00"

                        insDetalleTropa.Insertar(DetTr)

                        Compra.Fecha = Fec
                        Compra.CostoSinIvaKg = 0
                        Compra.CostoSinIvaCabeza = 0
                        Compra.AlicuotaIVA = 0
                        Compra.CostoConIvaKg = 0
                        Compra.CostoConIvaCabeza = 0
                        Compra.CostoConIvaFlete = 0
                        Compra.OtrosCostos = 0
                        Compra.CostoFinalKg = 0
                        Compra.CostoFinalCabeza = 0
                        Compra.CostoTotalTropa = 0
                        Compra.FormaPago = "-"
                        Compra.IdTropa = CInt(ulTid)
                        Compra.IdProveedor = idPv
                        Compra.IdProductor = idPr
                        Compra.IdUsuario = idUs

                        insIngreso.Insertar(Compra)
                    Next

                    ManejoSTK.Modificar(Fec, idUs)

                    Return "Tropa Ingresada !"
                Else
                    Return "Error al guardar Tropa"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("AltaTropa/Proveedores/{idUs}")>
        Public Function Proveedores(ByVal idUs As Integer) As String
            Try
                Dim Prov As New List(Of mdlProveedor)
                Dim Resp As String = ""
                Dim i As Integer = 0

                Prov = verProveedorUs.Ver(idUs)

                If Prov.Item(0).Err = "OK" Then
                    For Each Item In Prov
                        Resp = Resp & Item.IdProvedor
                        Resp = Resp & "|#$*|" & Item.RazonSocial
                        Resp = Resp & "|#$*|" & Item.Direccion
                        Resp = Resp & "|#$*|" & Item.Localidad
                        Resp = Resp & "|#$*|" & Item.Provincia
                        Resp = Resp & "|#$*|" & Item.CodPostal
                        Resp = Resp & "|#$*|" & Item.CUIT
                        Resp = Resp & "|#$*|" & Item.Telefono
                        Resp = Resp & "|#$*|" & Item.eMail

                        i = i + 1

                        If i < Prov.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return Prov.Item(0).Err
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("AltaTropa/Productores/{idUs}")>
        Public Function Productores(ByVal idUs As Integer) As String
            Try
                Dim Prod As New List(Of mdlProductor)
                Dim Resp As String = ""
                Dim i As Integer = 0

                Prod = verProductorUs.Ver(idUs)

                If Prod.Item(0).Err = "OK" Then
                    For Each Item In Prod
                        Resp = Resp & Item.IdProductor
                        Resp = Resp & "|#$*|" & Item.RazonSocial
                        Resp = Resp & "|#$*|" & Item.Direccion
                        Resp = Resp & "|#$*|" & Item.Localidad
                        Resp = Resp & "|#$*|" & Item.CodPostal
                        Resp = Resp & "|#$*|" & Item.CUIT

                        i = i + 1

                        If i < Prod.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return Prod.Item(0).Err
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("AltaTropa/Campos/{idUs}")>
        Public Function Campos(ByVal idUs As Integer) As String
            Try
                Dim Camp As New List(Of mdlCampo)
                Dim Resp As String = ""
                Dim i As Integer = 0

                Camp = verCamposUs.Ver(idUs)

                If Camp.Item(0).Err = "OK" Then
                    For Each Item In Camp
                        Resp = Resp & Item.IdCampo
                        Resp = Resp & "|#$*|" & Item.Nombre
                        Resp = Resp & "|#$*|" & Item.Propietario
                        Resp = Resp & "|#$*|" & Item.Localidad
                        Resp = Resp & "|#$*|" & Item.Provincia
                        Resp = Resp & "|#$*|" & Item.Superficie

                        i = i + 1

                        If i < Camp.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return Camp.Item(0).Err
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("AltaTropa/Corrales/{idCampo}/{idUs}")>
        Public Function Corrales(ByVal idCampo As Integer, ByVal idUs As Integer) As String
            Try
                Dim Crr As New List(Of mdlCorrales)
                Dim Resp As String = ""
                Dim i As Integer = 0

                Crr = verCorralesCampoUs.Ver(idCampo, idUs)

                If Crr.Item(0).Err = "OK" Then
                    For Each Item In Crr
                        Resp = Resp & Item.IdCorral
                        Resp = Resp & "|#$*|" & Item.Nombre
                        Resp = Resp & "|#$*|" & Item.Superficie
                        Resp = Resp & "|#$*|" & Item.Cabezas
                        Resp = Resp & "|#$*|" & Item.IdCampo

                        i = i + 1

                        If i < Crr.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next

                    Return "OK&%&%" & Resp
                Else
                    Return Crr.Item(0).Err
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace