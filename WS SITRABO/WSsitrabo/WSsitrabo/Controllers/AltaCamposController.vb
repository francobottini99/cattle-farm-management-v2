Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaCamposController
        Inherits ApiController

        <HttpGet>
        <Route("AltaCampos/grabarCampo/{nC}/{pR}/{Loc}/{Prov}/{Sup}/{idUs}")>
        Public Function grabarCampo(ByVal nC As String, ByVal pR As String, ByVal Loc As String, ByVal Prov As String, ByVal Sup As Double,
                                  ByVal idUs As Integer) As String

            Dim Cmp As New mdlCampo

            Try
                Cmp.Nombre = nC
                Cmp.Propietario = pR
                Cmp.Localidad = Loc
                Cmp.Provincia = Prov
                Cmp.Superficie = Sup
                Cmp.IdUsuario = idUs

                Dim Resp As String = insCampos.Insertar(Cmp)

                If Resp = "Registro insertado" Then
                    Return "Campo Ingresado !"
                Else
                    Return "Error al guardar Campo"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace