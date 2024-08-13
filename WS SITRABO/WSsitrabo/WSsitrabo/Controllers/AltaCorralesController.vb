Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaCorralesController
        Inherits ApiController
        <HttpGet>
        <Route("AltaCorrales/grabarCorral/{nC}/{Sup}/{Cab}/{idCam}/{idUs}")>
        Public Function grabarCorral(ByVal nC As String, ByVal Sup As Double, ByVal Cab As Integer, ByVal idCam As Integer, ByVal idUs As Integer) As String

            Dim Corr As New mdlCorrales

            Try
                Corr.Nombre = nC
                Corr.Superficie = Sup
                Corr.Cabezas = Cab
                Corr.IdCampo = idCam
                Corr.IdUsuario = idUs

                Dim Resp As String = insCorrales.Insertar(Corr)

                If Resp = "Registro insertado" Then
                    Return "Corral Ingresado !"
                Else
                    Return "Error al guardar Corral"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace