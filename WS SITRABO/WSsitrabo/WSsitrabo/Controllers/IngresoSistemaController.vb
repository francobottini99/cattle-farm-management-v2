Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class IngresoSistemaController
        Inherits ApiController

        <HttpGet>
        <Route("IngresoSistema/Ingreso/{DNI}/{Contraseña}")>
        Public Function Ingreso(ByVal DNI As String, ByVal Contraseña As String) As String
            Try
                Dim Usuario As mdlUsuario = consUsuariosIniciar.Ver(DNI, Contraseña)
                Dim Resp As String = ""

                If Usuario.Err <> "Error: Usuario o Contraseña incorrectos" Then
                    Resp = Resp & Usuario.IdUsuario
                    Resp = Resp & "|#$*|" & Usuario.Apellido
                    Resp = Resp & "|#$*|" & Usuario.Nombre
                    Resp = Resp & "|#$*|" & Usuario.CategoriaUs

                    modFechUsuario.Modificar(Usuario)

                    Return Resp
                Else
                    Return "Error: Usuario o Contraseña incorrectos"
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace