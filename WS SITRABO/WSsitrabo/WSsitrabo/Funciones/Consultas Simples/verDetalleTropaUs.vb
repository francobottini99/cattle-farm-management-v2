Imports MySql.Data.MySqlClient

Module verDetalleTropaUs
    Public Function Ver(ByVal idUs As Integer) As List(Of mdlDetalleTropa)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlDetalleTropa)
        Dim E As New mdlDetalleTropa
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verDetalleTropaUs")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtUs", idUs)

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
                    E.Err = "No hay Tropas cargadas, ingrese Tropas para poder Operar !"
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
End Module
