Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaProductorController
        Inherits ApiController

        <HttpGet>
        <Route("AltaProductores/grabarProductor/{pNom}/{pDir}/{pLoc}/{pCP}/{pCuit}/{pUs}")>
        Public Function grabarProductor(ByVal pNom As String, ByVal pDir As String, ByVal pLoc As String, ByVal pCP As String, ByVal pCuit As String,
                                  ByVal pUs As Integer) As String

            Dim Prod As New mdlProductor

            Try
                Prod.RazonSocial = pNom
                Prod.Direccion = pDir
                Prod.Localidad = pLoc
                Prod.CodPostal = pCP
                Prod.CUIT = pCuit
                Prod.IdUsuario = pUs

                Dim Resp As String = insProductor.Insertar(Prod)

                If Resp = "Registro insertado" Then
                    Return "Productor Ingresado !"
                Else
                    Return "Error al guardar Productor"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace