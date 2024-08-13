Imports MySql.Data.MySqlClient

Module consTropasPorCorralYFecha
    Public Function Ver(ByVal IdT As Integer) As List(Of mdlCorrales)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlCorrales)
        Dim E As New mdlCorrales
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.consTropasPorCorralYFecha")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@IdCorr", IdT)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlCorrales(
                        Sdr("idCorrales"),
                        Sdr("NombreCorral"),
                        Sdr("Superficie"),
                        Sdr("CabezasTotales"),
                        Sdr("CAMPO_idCampo"),
                        Sdr("USUARIOS_idUsuario"),
                        Sdr("idTropa")))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Tropas cargadas para ese Productor !"
                    Lista.Insert(0, E)
                Else
                    Return Lista
                End If

                Sdr.Close()
            End Using

            Return Lista
        Catch ex As Exception
            E.Err = ex.Message.ToString
            Lista.Insert(0, E)
            Return E.Err
        End Try
    End Function
End Module
