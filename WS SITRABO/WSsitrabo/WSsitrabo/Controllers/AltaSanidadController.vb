Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaSanidadController
        Inherits ApiController

        <HttpGet>
        <Route("AltaSanidad/grabarSanidad/{sFec}/{sTrat}/{sImp}/{sObs}/{sidDT}/{sIdU}")>
        Public Function grabarRacion(ByVal sFec As Date, ByVal sTrat As String, ByVal sImp As Double, ByVal sObs As String,
                                     ByVal sidDT As String, ByVal sIdU As String) As String

            Dim Sanid As New mdlSanidad

            Try
                Sanid.Fecha = sFec
                Sanid.Tratamiento = sTrat
                Sanid.Importe = sImp
                Sanid.Observaciones = sObs
                Sanid.IdDetalleTropa = sidDT
                Sanid.IdUsuario = sIdU

                Dim Resp As String = insSanidad.Insertar(Sanid)

                If Resp = "Registro insertado" Then
                    Return "Sanidad Ingresada !"
                Else
                    Return "Error al guardar Sanidad"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace