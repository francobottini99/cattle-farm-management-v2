Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class AltaCategoriasController
        Inherits ApiController

        <HttpGet>
        <Route("AltaCategorias/grabarCategoria/{Cat}/{idUs}")>
        Public Function grabarCategoria(ByVal Cat As String, ByVal idUs As Integer) As String

            Dim Categ As New mdlCategorias

            Try
                Categ.Categoria = Cat
                Categ.IdUsuario = idUs

                Dim Resp As String = insCategorias.Insertar(Categ)

                If Resp = "Registro insertado" Then
                    Return "Categoría Ingresada !"
                Else
                    Return "Error al guardar Categoría"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace