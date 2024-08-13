Imports System.Net
Imports System.Web.Http
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class CaravaneoController
        Inherits ApiController

        <HttpGet>
        <Route("Caravaneo/TropasSinRFID/{idU}")>
        Public Function TropasSinRFID(ByVal idU As Integer) As String
            Try
                Dim Trop As List(Of mdlTropa) = consTropasSinRFIDUS.Ver(idU)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If Trop.Count > 0 Then
                    For Each Item In Trop
                        Resp = Resp & Item.IdTropa
                        Resp = Resp & "|#$*|" & Item.NombreTropa
                        Resp = Resp & "|#$*|" & Item.Origen
                        Resp = Resp & "|#$*|" & Item.Fecha
                        Resp = Resp & "|#$*|" & Item.Cabezas
                        Resp = Resp & "|#$*|" & Item.Muertes
                        Resp = Resp & "|#$*|" & Item.Ventas
                        Resp = Resp & "|#$*|" & Item.Stock
                        Resp = Resp & "|#$*|" & Item.PesoIngreso
                        Resp = Resp & "|#$*|" & Item.KgTropa
                        Resp = Resp & "|#$*|" & Item.Observaciones
                        Resp = Resp & "|#$*|" & Item.IdProductor
                        Resp = Resp & "|#$*|" & Item.idCampo
                        Resp = Resp & "|#$*|" & Item.IdProveedor

                        I = I + 1
                        If I < Trop.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay tropas sin RFID asignado !"
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("Caravaneo/DetalleTropaSinRFID/{idT}")>
        Public Function DetalleTropaSinRFID(ByVal idT As Integer) As String
            Try
                Dim SinRFID As List(Of mdlDetalleTropa) = verDetalleTropaSinRFID.Ver(idT)
                Dim Resp As String = ""
                Dim I As Integer = 0

                If SinRFID.Count > 0 Then
                    For Each Item In SinRFID
                        Resp = Resp & Item.IdDetalleTropa
                        Resp = Resp & "|#$*|" & Item.Caravana
                        Resp = Resp & "|#$*|" & Item.Descripcion
                        Resp = Resp & "|#$*|" & Item.Estado
                        Resp = Resp & "|#$*|" & Item.IdTropa
                        Resp = Resp & "|#$*|" & Item.IdCategoria
                        Resp = Resp & "|#$*|" & Item.IdCorrales
                        Resp = Resp & "|#$*|" & Item.CaravanaRFID

                        I = I + 1
                        If I < SinRFID.Count Then
                            Resp = Resp & "|%@!|"
                        End If
                    Next
                    Return "OK&%&%" & Resp
                Else
                    Return "Error: No hay tropas sin RFID asignado !"
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function

        <HttpGet>
        <Route("Caravaneo/ModificaCaravana/{idTr}/{Carav}/{Rfid}")>
        Public Function ModificaCaravana(ByVal idTr As Integer, ByVal Carav As String, ByVal Rfid As String) As String
            Dim Cmd As New MySqlCommand
            Try
                Dim RFrep As New mdlDetalleTropa

                RFrep = verRFIDrepetidos.Ver(Rfid)

                If RFrep.IdDetalleTropa = 0 Then
                    Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                        Cmd = New MySqlCommand("feedlot.modDetalleTropaCaravanaRFID")
                        Cmd.CommandType = CommandType.StoredProcedure
                        Cmd.Connection = Conn

                        Cmd.Parameters.AddWithValue("@idDt", idTr)
                        Cmd.Parameters.AddWithValue("@Carav", Carav)
                        Cmd.Parameters.AddWithValue("@Rfid", Rfid)

                        Conn.Open()
                        Cmd.ExecuteNonQuery()
                    End Using
                    Return "Registro modificado"
                Else
                    Return "La caravana RFID ya está asignada a otro animal"
                End If
            Catch ex As Exception
                Return "Error: " & ex.Message.ToString
            End Try
        End Function
    End Class
End Namespace