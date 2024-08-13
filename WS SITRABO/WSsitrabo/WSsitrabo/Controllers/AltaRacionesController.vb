Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaRacionesController
        Inherits ApiController

        <HttpGet>
        <Route("AltaRaciones/grabarRacion/{rNom}/{rGrano}/{rConc}/{rFib}/{rOtr}/{rCostGr}/{rCostConc}/{rCostFib}/{rCostOt}/{rIDu}")>
        Public Function grabarRacion(ByVal rNom As String, ByVal rGrano As String, ByVal rConc As String, ByVal rFib As String, ByVal rOtr As String,
                                        ByVal rCostGr As Double, ByVal rCostConc As Double, ByVal rCostFib As Double, ByVal rCostOt As Double, ByVal rIDu As Integer) As String

            Dim Rac As New mdlRaciones

            Try
                Rac.Nombre = rNom
                Rac.Grano = rGrano
                Rac.Concentrado = rConc
                Rac.Fibra = rFib
                Rac.Otros = rOtr
                Rac.CostoGrano = rCostGr
                Rac.CostoConc = rCostConc
                Rac.CostoFibra = rCostFib
                Rac.CostoOtros = rCostOt
                Rac.IdUsuario = rIDu

                Dim Resp As String = insRacion.Insertar(Rac)

                If Resp = "Registro insertado" Then
                    Return "Ración Ingresada !"
                Else
                    Return "Error al guardar Ración"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace