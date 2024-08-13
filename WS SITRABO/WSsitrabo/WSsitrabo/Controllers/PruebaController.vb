Imports System.Net
Imports System.Web.Http
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class PruebaController
        Inherits ApiController
        <HttpGet>
        <Route("Prueba/Ver/{Est}/{idCrr}/{IdUs}")>
        Public Function Ver(ByVal Est As String, ByVal idCrr As Integer, ByVal idUs As Integer) As List(Of mdlDetalleTropa)
            Dim Cmd As New MySqlCommand
            Dim Lista As New List(Of mdlDetalleTropa)
            Dim E As New mdlDetalleTropa
            Dim Sdr As MySqlDataReader

            Try
                Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                    Cmd = New MySqlCommand("feedlot.verStocDiariokUs")
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Connection = Conn

                    Cmd.Parameters.AddWithValue("@sMod", Est)
                    Cmd.Parameters.AddWithValue("@sCorr", idCrr)
                    Cmd.Parameters.AddWithValue("@sUs", idUs)

                    Conn.Open()
                    Sdr = Cmd.ExecuteReader

                    Lista.Clear()
                    While Sdr.Read
                        Lista.Add(New mdlDetalleTropa(
                            Sdr("idDetTropa"),
                            Sdr("Caravana"),
                            Sdr("Descripcion"),
                            Sdr("Estado"),
                            Sdr("TROPA_idTropa"),
                            Sdr("CATEGORIAS_idCategorias"),
                            Sdr("CORRALES_idCorrales"),
                            Sdr("USUARIOS_idUsuario"),
                            Sdr("CaravanaRFID"),
                            "OK"))
                    End While

                    If Lista.Count = 0 Then
                        E.Err = "No hay Stock para ese corral y usuario !"
                        Lista.Insert(0, E)
                    Else
                        Return Lista
                    End If

                    Sdr.Close()
                End Using

                Return Lista
            Catch ex As Exception
                E.Err = "Error: " & ex.Message.ToString
                Lista.Insert(0, E)
                Return Lista
            End Try
        End Function
    End Class
End Namespace