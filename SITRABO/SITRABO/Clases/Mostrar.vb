Imports MySql.Data.MySqlClient

Public Class Mostrar
    Public Function verAlimentacionID(ByVal idA As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacionID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@iD"), MySqlParameter).Value = idA

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function verTablaAlimentos()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTablaAlimentos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Tabla de Alimentos no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function


    Public Function consVentasSinComercializar(ByVal idP As Integer, ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consVentasSinComercializar"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idP"), MySqlParameter).Value = idP
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function consSanidadDetalleTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consSanidadDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function verStockDetalleTropaFecha(ByVal idDt As Integer, ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStockDetalleTropaFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idDt"), MySqlParameter).Value = idDt
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function VerVentasSinComercializarFecha()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.VerVentasSinComercializarFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function VerVentasSinComercializarProductorPorFecha(ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.VerVentasSinComercializarProductorPorFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function VerVentasSinComercializarProductorPorFechaUs(ByVal Fec As Date, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.VerVentasSinComercializarProductorPorFechaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function VerVentasSinComercializarFechaUs(ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.VerVentasSinComercializarFechaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function consVentasSinComercializarUs(ByVal idP As Integer, ByVal Fec As Date, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consVentasSinComercializarUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idP"), MySqlParameter).Value = idP
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = idUs
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function consSanidadDetalleTropaUs(ByVal sUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consSanidadDetalleTropaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@sUs"), MySqlParameter).Value = sUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function consDetalleTropa_Corral_Tropa_Productor(ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropa_Corral_Tropa_Productor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function verAlimentacionFechaDetalleTropa(ByVal Fec As Date, ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacionFechaDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function sumaAlimentacionProrrateoTodoPorDetalleTropa(ByVal fecD As Date, ByVal fecH As Date, ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodoPorDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function sumaAlimentacionProrrateoTodoPorTropa(ByVal fecD As Date, ByVal fecH As Date, ByVal idT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodoPorTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function sumaAlimentacionProrrateoPorTropaYCorralFechaDH(ByVal fecD As Date, ByVal fecH As Date, ByVal idT As Integer, ByVal idC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoPorTropaYCorralFechaDH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idT
            CType(_cMd.Parameters("@idC"), MySqlParameter).Value = idC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function verAlimentacion_Fecha(ByVal aFec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacion_Fecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aFec"), MySqlParameter).Value = aFec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function sumaAlimentacionProrrateoPorProductorYCorralFechaDH(ByVal fecD As Date, ByVal fecH As Date, ByVal idP As Integer, ByVal idC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoPorProductorYCorralFechaDH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idP"), MySqlParameter).Value = idP
            CType(_cMd.Parameters("@idC"), MySqlParameter).Value = idC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function

    Public Function sumaAlimentacionProrrateoPorProductorFechaDH(ByVal fecD As Date, ByVal fecH As Date, ByVal idP As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoPorProductorFechaDH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idP"), MySqlParameter).Value = idP

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try

    End Function
    Public Function sumaAlimentacionProrrateoPorDetalleTropaFechaDH(ByVal fecD As Date, ByVal fecH As Date, ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoPorDetalleTropaFechaDH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionProrrateoTodoPorCorral(ByVal fecD As Date, ByVal fecH As Date, ByVal idC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodoPorCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idC"), MySqlParameter).Value = idC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionProrrateoTodoPorProductor(ByVal fecD As Date, ByVal fecH As Date, ByVal idP As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodoPorProductor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idP"), MySqlParameter).Value = idP

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionProrrateoPorTropaFechaDH(ByVal fecD As Date, ByVal fecH As Date, ByVal idT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoPorTropaFechaDH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionProrrateoTodoUs(ByVal fecD As Date, ByVal fecH As Date, ByVal idU As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodoUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH
            CType(_cMd.Parameters("@idU"), MySqlParameter).Value = idU

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionProrrateoTodo(ByVal fecD As Date, ByVal fecH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionProrrateoTodo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = fecD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fecH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Alimentacion Prottateo no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimetacionPorTropa(ByVal idTr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimetacionPorTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Ración por Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function sumaAlimentacionPorTropaUs(ByVal idTr As Integer, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.sumaAlimentacionPorTropaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr
            CType(_cMd.Parameters("@idU"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Suma de Raciión por Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consComprasTropa(ByVal idTr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consComprasTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Compra Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consComprasTropaUs(ByVal idTr As Integer, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consComprasTropaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr
            CType(_cMd.Parameters("@idU"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Compra Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxFecAlimporTropa(ByVal idTr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxFecAlimporTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Ultim Fecha Alimentación Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxFecAlimporTropaUs(ByVal idTr As Integer, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxFecAlimporTropaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr
            CType(_cMd.Parameters("@idU"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Ultim Fecha Alimentación Tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function
    Public Function consTropasDetalle(ByVal idTr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consTropasDetalle"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Detalle tropa no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consTropasDetalleUs(ByVal idTr As Integer, ByVal idUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consTropasDetalleUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idTr
            CType(_cMd.Parameters("@idU"), MySqlParameter).Value = idUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Detalle tropa por usuario no puede mostrarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropa_Engorde_Corral_Tropa_US(ByVal dtUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropa_Engorde_Corral_Tropa_US"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = dtUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropa_Engorde_Corral_Tropa_US_Todas(ByVal dtUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropa_Engorde_Corral_Tropa_US_Todas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = dtUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStock_Fecha_Tropa_Us(ByVal sFec As Date, ByVal sIdT As Integer, ByVal sUs As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStock_Fecha_Tropa_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@sFec"), MySqlParameter).Value = sFec
            CType(_cMd.Parameters("@sIdT"), MySqlParameter).Value = sIdT
            CType(_cMd.Parameters("@sUs"), MySqlParameter).Value = sUs

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlimentacionProRateo_FechaDH_Productor_Us(ByVal aUs As Integer, ByVal aFecD As Date, ByVal aFecH As Date, ByVal aIdProductor As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacionProRateo_FechaDH_Productor_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aUs"), MySqlParameter).Value = aUs
            CType(_cMd.Parameters("@aFecD"), MySqlParameter).Value = aFecD
            CType(_cMd.Parameters("@aFecH"), MySqlParameter).Value = aFecH
            CType(_cMd.Parameters("@aIdProductor"), MySqlParameter).Value = aIdProductor

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropa_Productor_Us(ByVal uID As Integer, ByVal uIDP As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropa_Productor_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uID"), MySqlParameter).Value = uID
            CType(_cMd.Parameters("@uIDP"), MySqlParameter).Value = uIDP

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function verVentas_HastaUltStk(ByVal vFech As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verVentas_HastaUltStk"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@vFech"), MySqlParameter).Value = vFech

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMuertes_HastaUltStk(ByVal mFech As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMuertes_HastaUltStk"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@mFech"), MySqlParameter).Value = mFech

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacionProrateoPorTropa(ByVal T As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacionProrateoPorTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Trp"), MySqlParameter).Value = T

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProductorPorID(ByVal ID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProductorPorID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idProd"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlimentacionProRateo_FechaDH_Tropa_Us(ByVal aUs As Integer, ByVal aFecD As Date, ByVal aFecH As Date, ByVal aIdTropa As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacionProRateo_FechaDH_Tropa_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aUs"), MySqlParameter).Value = aUs
            CType(_cMd.Parameters("@aFecD"), MySqlParameter).Value = aFecD
            CType(_cMd.Parameters("@aFecH"), MySqlParameter).Value = aFecH
            CType(_cMd.Parameters("@aIdTropa"), MySqlParameter).Value = aIdTropa

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlimentacion_Fecha_Us(ByVal aUs As Integer, ByVal aFec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacion_Fecha_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aUs"), MySqlParameter).Value = aUs
            CType(_cMd.Parameters("@aFec"), MySqlParameter).Value = aFec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlimentacion_FechaDH_Us(ByVal aUs As Integer, ByVal aFecD As Date, ByVal aFecH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verAlimentacion_FechaDH_Us"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aUs"), MySqlParameter).Value = aUs
            CType(_cMd.Parameters("@aFecD"), MySqlParameter).Value = aFecD
            CType(_cMd.Parameters("@aFecH"), MySqlParameter).Value = aFecH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consUsuariosIniciar(ByVal DNI As String, ByVal Contraseña As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consUsuarioIniciar"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uDNI"), MySqlParameter).Value = DNI
            CType(_cMd.Parameters("@uContr"), MySqlParameter).Value = Contraseña

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropa_Engorde_Corral_Tropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropa_Engorde_Corral_Tropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropa_Engorde_Corral_Tropa_Todas()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropa_Engorde_Corral_Tropa_Todas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProductor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProductor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProductorUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProductorUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@pUs"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProveedor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProveedor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProveedorUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProveedorUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@pUs"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCampos()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCampos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCamposUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCamposUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uID"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeVenta(ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verPesajeVenta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCorrales()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCorrales"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCorralesUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCorralesUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uID"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCategoriasUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCategoriaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uID"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCategorias()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCategoria"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verRaciones()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verRacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verRacionesUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verRacionUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uID"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuarios no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropas()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropaUs(ByVal uSiD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uiD"), MySqlParameter).Value = uSiD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxIdTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Tropa no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxFecAlim()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxFecAlim"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Tropa no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMinFecAlim()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMinFecAlim"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Tropa no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdAlimentacion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxIdAlimentacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Tropa no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verEstadoModTropa(ByVal tID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verEstadoModID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = tID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleTropaCorralesID(ByVal tID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verDetalleTropaCorralesID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@tID"), MySqlParameter).Value = tID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStock()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStock"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStockCorrDia(ByVal F As Date, ByVal T As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStkCorralDia"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = F
            CType(_cMd.Parameters("@Trp"), MySqlParameter).Value = T

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropaEngorde(ByVal idCrr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaEngorde"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCrr"), MySqlParameter).Value = idCrr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeFecha(ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropaMuerto()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaMuerto"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesaje()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesaje"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeTodos()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeTodos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function consDetalleTropaVendido()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaVendido"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeUS(ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUS"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consProductorDetalleTropa(ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consProductorDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropaMuertoUS(ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaMuertoUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropaEngordeUS(ByVal usID As Integer, ByVal idCrr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaEngordeUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = usID
            CType(_cMd.Parameters("@idCrr"), MySqlParameter).Value = idCrr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleTropaVendidoUS(ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaVendidoUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStocDiariokUs(ByVal crrID As Integer, ByVal usID As Integer, ByVal Est As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStocDiariokUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@sMod"), MySqlParameter).Value = Est
            CType(_cMd.Parameters("@sCorr"), MySqlParameter).Value = crrID
            CType(_cMd.Parameters("@sUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStocCorralesUs(ByVal usID As Integer, ByVal Est As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStocCorralesUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@sMod"), MySqlParameter).Value = Est
            CType(_cMd.Parameters("@sUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStocFechaUs(ByVal usID As Integer, ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStocFechaUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@sFec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@sUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeFechaUS(ByVal usID As Integer, ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUS"), MySqlParameter).Value = usID
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeDtalleTropa(ByVal dtUs As Integer, ByVal idDtcrr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verPesajeDtalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = dtUs
            CType(_cMd.Parameters("@idDtcrr"), MySqlParameter).Value = idDtcrr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropaPesoIngresoUs(ByVal dtUs As Integer, ByVal idT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropaPesoIngresoUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = dtUs
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropaPesoIngreso(ByVal idT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropaPesoIngreso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idT"), MySqlParameter).Value = idT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStockUs(ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStockUs"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@stkUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacionUS(ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacionUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacionFecha(ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacionFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStkDia(ByVal Fec As Date, ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStkDia"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacionFechaUS(ByVal Fec As Date, ByVal usID As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacionFechaUS"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@idUs"), MySqlParameter).Value = usID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesoEstimadoPorAnimal(ByVal Pes As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verPesoEstimadoPorAnimal"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Pes"), MySqlParameter).Value = Pes

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verADPV()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTablaADPV"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Aumento Diario de Peso Vivo no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Aumento Diario de Peso Vivo no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStkCorralFec(ByVal dtUs As Integer, ByVal idCrr As Integer, ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStkCorralFec"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@dtUs"), MySqlParameter).Value = dtUs
            CType(_cMd.Parameters("@idCrr"), MySqlParameter).Value = idCrr
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consStockPorFecha(ByVal Fec As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consStockPorFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@stkFec"), MySqlParameter).Value = Fec

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los datos de Stock...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consStockPorFechaMH(ByVal Fec As Date, ByVal MH As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consStockPorFechaMH"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@stkFec"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@stkSex"), MySqlParameter).Value = MH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los datos de Stock...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeFechaDesde(ByVal F As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaDesde"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = F

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeFechaHasta(ByVal F As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaHasta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Fec"), MySqlParameter).Value = F

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeTropa(ByVal Tr As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Trp"), MySqlParameter).Value = Tr

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consPesajeDinamico(ByVal Filtro As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeDinamico"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@Filtro"), MySqlParameter).Value = Filtro

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar...!" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeFecha(ByVal fD As Date, ByVal fH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@FecD"), MySqlParameter).Value = fD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeFechaTropa(ByVal fD As Date, ByVal fH As Date, ByVal iD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@FecD"), MySqlParameter).Value = fD
            CType(_cMd.Parameters("@fecH"), MySqlParameter).Value = fH
            CType(_cMd.Parameters("@idTrp"), MySqlParameter).Value = iD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeTropaInicioFin(ByVal iD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeTropaInicioaFin"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idTrp"), MySqlParameter).Value = iD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeCorral(ByVal iD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCorr"), MySqlParameter).Value = iD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeFechaCorral(ByVal fD As Date, ByVal fH As Date, ByVal iD As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fD"), MySqlParameter).Value = fD
            CType(_cMd.Parameters("@fH"), MySqlParameter).Value = fH
            CType(_cMd.Parameters("@idCorr"), MySqlParameter).Value = iD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeCaravana(ByVal Carv As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeCaravana"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@carav"), MySqlParameter).Value = Carv

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verPesajeFechaCaravana(ByVal fD As Date, ByVal fH As Date, ByVal Carv As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consPesajeFechaCaravana"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fD"), MySqlParameter).Value = fD
            CType(_cMd.Parameters("@fH"), MySqlParameter).Value = fH
            CType(_cMd.Parameters("@carav"), MySqlParameter).Value = Carv

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Datos no pudieron cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxFecPesaje()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxFecPesaje"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Fecha pesaje no encontrada" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMinFecPesaje()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMinFecPesaje"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Fecha pesaje no encontrada" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


End Class
