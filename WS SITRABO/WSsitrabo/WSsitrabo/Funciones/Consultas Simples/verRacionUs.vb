Imports MySql.Data.MySqlClient

Module verRacionUs
    Public Function Ver(ByVal uID As Integer) As List(Of mdlRaciones)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlRaciones)
        Dim E As New mdlRaciones
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verRacionUs")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@uID", uID)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read()
                    Lista.Add(New mdlRaciones(
                        Sdr("idRaciones"),
                        Sdr("NombreRacion"),
                        Sdr("Grano"),
                        Sdr("Concentrado"),
                        Sdr("Fibra"),
                        Sdr("Otros"),
                        Sdr("CostoGrano"),
                        Sdr("CostoConcentrado"),
                        Sdr("CostoFibra"),
                        Sdr("CostoOtros"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Raciones cargadas, ingrese Raciones para poder Operar !"
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
