Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaProveedoresController
        Inherits ApiController

        <HttpGet>
        <Route("AltaProveedores/grabarProveedor/{pNom}/{pDir}/{pLoc}/{pRov}/{pCP}/{pCuit}/{Te}/{Mail}/{pUs}")>
        Public Function grabarProveedor(ByVal pNom As String, ByVal pDir As String, ByVal pLoc As String, ByVal pRov As String, ByVal pCP As String,
                                        ByVal pCuit As String, ByVal Te As String, ByVal Mail As String, ByVal pUs As Integer) As String

            Dim Proveed As New mdlProveedor

            Try
                Proveed.RazonSocial = pNom
                Proveed.Direccion = pDir
                Proveed.Localidad = pLoc
                Proveed.Provincia = pRov
                Proveed.CodPostal = pCP
                Proveed.CUIT = pCuit
                Proveed.Telefono = Te
                Proveed.eMail = Mail
                Proveed.IdUsuario = pUs

                Dim Resp As String = insProveedor.Insertar(Proveed)

                If Resp = "Registro insertado" Then
                    Return "Proveedor Ingresado !"
                Else
                    Return "Error al guardar Proveedor"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace