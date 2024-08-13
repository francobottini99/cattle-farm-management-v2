Imports System.Net
Imports System.Web.Http
Imports MySql.Data.MySqlClient

Namespace Funciones.Insertar
    Public Class RegistroUsuarioController
        Inherits ApiController

        <HttpGet>
        <Route("IngresoSistema/Registro/{Apellido}/{Nombres}/{DNI}/{Contraseña}")>
        Public Function Registrar(ByVal Apellido As String, ByVal Nombres As String, ByVal DNI As String, ByVal Contraseña As String) As String
            Dim Usuario As New mdlUsuario

            Try
                Dim Resp As String = consDNI.Ver(DNI)

                If Resp = "Usuario Nuevo" Then
                    Usuario.Apellido = Apellido
                    Usuario.Nombre = Nombres
                    Usuario.DNIus = DNI
                    Usuario.Contraseña = Contraseña
                    Usuario.CategoriaUs = "Usuario"
                    Usuario.FechaUltimoIng = Format(Date.Now.Date, "dd/MM/yyyy")

                    Dim ResInsert As String = insUsuario.Insertar(Usuario)
                    Return ResInsert
                Else
                    Return Resp
                End If

            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace