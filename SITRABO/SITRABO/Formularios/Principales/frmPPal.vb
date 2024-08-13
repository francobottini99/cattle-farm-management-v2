Imports MySql.Data.MySqlClient

Public Class frmPPal

    Private Sub pbxAltas_GotFocus(sender As Object, e As EventArgs) Handles pbxAltas.GotFocus
        If (gbxPanelAltas.Visible = False) Then
            pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasSi
        End If
    End Sub

    Private Sub pbxAltas_LostFocus(sender As Object, e As EventArgs) Handles pbxAltas.LostFocus
        If (gbxPanelAltas.Visible = False) Then
            pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasNo2
        End If
    End Sub

    Private Sub pbxAltas_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltas.MouseEnter
        If (gbxPanelAltas.Visible = False) Then
            pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasSi
        End If
    End Sub

    Private Sub pbxAltas_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltas.MouseLeave
        If (gbxPanelAltas.Visible = False) Then
            pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasNo2
        End If
    End Sub

    Private Sub pbxManejo_GotFocus(sender As Object, e As EventArgs) Handles pbxManejo.GotFocus
        If (gbxPanelManejo.Visible = False) Then
            pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoSi
        End If
    End Sub

    Private Sub pbxManejo_LostFocus(sender As Object, e As EventArgs) Handles pbxManejo.LostFocus
        If (gbxPanelManejo.Visible = False) Then
            pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoNo
        End If
    End Sub

    Private Sub pbxManejo_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejo.MouseEnter
        If (gbxPanelManejo.Visible = False) Then
            pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoSi
        End If
    End Sub

    Private Sub pbxManejo_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejo.MouseLeave
        If (gbxPanelManejo.Visible = False) Then
            pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoNo
        End If
    End Sub

    Private Sub pbxComer_GotFocus(sender As Object, e As EventArgs) Handles pbxComer.GotFocus
        If (gbxPanelComer.Visible = False) Then
            pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerSi
        End If
    End Sub

    Private Sub pbxComer_LostFocus(sender As Object, e As EventArgs) Handles pbxComer.LostFocus
        If (gbxPanelComer.Visible = False) Then
            pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerNo
        End If
    End Sub

    Private Sub pbxComer_MouseEnter(sender As Object, e As EventArgs) Handles pbxComer.MouseEnter
        If (gbxPanelComer.Visible = False) Then
            pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerSi
        End If
    End Sub

    Private Sub pbxComer_MouseLeave(sender As Object, e As EventArgs) Handles pbxComer.MouseLeave
        If (gbxPanelComer.Visible = False) Then
            pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerNo
        End If
    End Sub

    Private Sub pbxConsultas_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultas.GotFocus
        If (gbxConsultas.Visible = False) Then
            pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasSi
        End If
    End Sub

    Private Sub pbxConsultas_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultas.LostFocus
        If (gbxConsultas.Visible = False) Then
            pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasNo
        End If
    End Sub

    Private Sub pbxConsultas_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultas.MouseEnter
        If (gbxConsultas.Visible = False) Then
            pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasSi
        End If
    End Sub

    Private Sub pbxConsultas_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultas.MouseLeave
        If (gbxConsultas.Visible = False) Then
            pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasNo
        End If
    End Sub

    Private Sub pbxSalir_GotFocus(sender As Object, e As EventArgs) Handles pbxSalir.GotFocus
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalir_LostFocus(sender As Object, e As EventArgs) Handles pbxSalir.LostFocus
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub pbxSalir_MouseEnter(sender As Object, e As EventArgs) Handles pbxSalir.MouseEnter
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalir_MouseLeave(sender As Object, e As EventArgs) Handles pbxSalir.MouseLeave
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub pbxAltasProductor_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasProductor.GotFocus
        pbxAltasProductor.BackgroundImage = SITRABO.My.Resources.btnProductorSi
    End Sub

    Private Sub pbxAltasProductor_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasProductor.LostFocus
        pbxAltasProductor.BackgroundImage = SITRABO.My.Resources.btnProductorNo
    End Sub

    Private Sub pbxAltasProductor_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasProductor.MouseEnter
        pbxAltasProductor.BackgroundImage = SITRABO.My.Resources.btnProductorSi
    End Sub

    Private Sub pbxAltasProductor_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasProductor.MouseLeave
        pbxAltasProductor.BackgroundImage = SITRABO.My.Resources.btnProductorNo
    End Sub

    Private Sub pbxAltasProveedor_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasProveedor.GotFocus
        pbxAltasProveedor.BackgroundImage = SITRABO.My.Resources.btnProveedorSi2
    End Sub

    Private Sub pbxAltasProveedor_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasProveedor.LostFocus
        pbxAltasProveedor.BackgroundImage = SITRABO.My.Resources.btnProveedorNo2
    End Sub

    Private Sub pbxAltasProveedor_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasProveedor.MouseEnter
        pbxAltasProveedor.BackgroundImage = SITRABO.My.Resources.btnProveedorSi2
    End Sub

    Private Sub pbxAltasProveedor_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasProveedor.MouseLeave
        pbxAltasProveedor.BackgroundImage = SITRABO.My.Resources.btnProveedorNo2
    End Sub

    Private Sub pbxAltasCampo_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasCampo.GotFocus
        pbxAltasCampo.BackgroundImage = SITRABO.My.Resources.btnCampoSi
    End Sub

    Private Sub pbxAltasCampo_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasCampo.LostFocus
        pbxAltasCampo.BackgroundImage = SITRABO.My.Resources.btnCampoNo
    End Sub

    Private Sub pbxAltasCampo_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasCampo.MouseEnter
        pbxAltasCampo.BackgroundImage = SITRABO.My.Resources.btnCampoSi
    End Sub

    Private Sub pbxAltasCampo_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasCampo.MouseLeave
        pbxAltasCampo.BackgroundImage = SITRABO.My.Resources.btnCampoNo
    End Sub

    Private Sub pbxAltasCorrales_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasCorrales.GotFocus
        pbxAltasCorrales.BackgroundImage = SITRABO.My.Resources.btnCorralSi
    End Sub

    Private Sub pbxAltasCorrales_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasCorrales.LostFocus
        pbxAltasCorrales.BackgroundImage = SITRABO.My.Resources.btnCorralNo
    End Sub

    Private Sub pbxAltasCorrales_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasCorrales.MouseEnter
        pbxAltasCorrales.BackgroundImage = SITRABO.My.Resources.btnCorralSi
    End Sub

    Private Sub pbxAltasCorrales_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasCorrales.MouseLeave
        pbxAltasCorrales.BackgroundImage = SITRABO.My.Resources.btnCorralNo
    End Sub

    Private Sub pbxAltasTropa_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasTropa.GotFocus
        pbxAltasTropa.BackgroundImage = SITRABO.My.Resources.btnTropaSi
    End Sub

    Private Sub pbxAltasTropa_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasTropa.LostFocus
        pbxAltasTropa.BackgroundImage = SITRABO.My.Resources.btnTropaNo
    End Sub

    Private Sub pbxAltasTropa_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasTropa.MouseEnter
        pbxAltasTropa.BackgroundImage = SITRABO.My.Resources.btnTropaSi
    End Sub

    Private Sub pbxAltasTropa_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasTropa.MouseLeave
        pbxAltasTropa.BackgroundImage = SITRABO.My.Resources.btnTropaNo
    End Sub

    Private Sub pbxAltasRaciones_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasRaciones.GotFocus
        pbxAltasRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesSi
    End Sub

    Private Sub pbxAltasRaciones_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasRaciones.LostFocus
        pbxAltasRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesNo
    End Sub

    Private Sub pbxAltasRaciones_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasRaciones.MouseEnter
        pbxAltasRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesSi
    End Sub

    Private Sub pbxAltasRaciones_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasRaciones.MouseLeave
        pbxAltasRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesNo
    End Sub

    Private Sub pbxAltasCategorias_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasCategorias.GotFocus
        pbxAltasCategorias.BackgroundImage = SITRABO.My.Resources.btnCategoriasSi
    End Sub

    Private Sub pbxAltasCategorias_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasCategorias.LostFocus
        pbxAltasCategorias.BackgroundImage = SITRABO.My.Resources.btnCategoriasNo
    End Sub

    Private Sub pbxAltasCategorias_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasCategorias.MouseEnter
        pbxAltasCategorias.BackgroundImage = SITRABO.My.Resources.btnCategoriasSi
    End Sub

    Private Sub pbxAltasCategorias_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasCategorias.MouseLeave
        pbxAltasCategorias.BackgroundImage = SITRABO.My.Resources.btnCategoriasNo
    End Sub

    Private Sub pbxAltasVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasVolver.GotFocus
        pbxAltasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxAltasVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasVolver.LostFocus
        pbxAltasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxAltasVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasVolver.MouseEnter
        pbxAltasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxAltasVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasVolver.MouseLeave
        pbxAltasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxParametros_GotFocus(sender As Object, e As EventArgs) Handles pbxParametros.GotFocus
        pbxParametros.BackgroundImage = SITRABO.My.Resources.btnParamentrosSi
    End Sub

    Private Sub pbxParametros_LostFocus(sender As Object, e As EventArgs) Handles pbxParametros.LostFocus
        pbxParametros.BackgroundImage = SITRABO.My.Resources.btnParamentrosNo
    End Sub

    Private Sub pbxParametros_MouseEnter(sender As Object, e As EventArgs) Handles pbxParametros.MouseEnter
        pbxParametros.BackgroundImage = SITRABO.My.Resources.btnParamentrosSi
    End Sub

    Private Sub pbxParametros_MouseLeave(sender As Object, e As EventArgs) Handles pbxParametros.MouseLeave
        pbxParametros.BackgroundImage = SITRABO.My.Resources.btnParamentrosNo
    End Sub

    Private Sub pbxManejoMovTropa_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoMovTropa.GotFocus
        pbxManejoMovTropa.BackgroundImage = SITRABO.My.Resources.btnMovimientosSi
    End Sub

    Private Sub pbxManejoMovTropa_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoMovTropa.LostFocus
        pbxManejoMovTropa.BackgroundImage = SITRABO.My.Resources.btnMovimientosNo
    End Sub

    Private Sub pbxManejoMovTropa_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoMovTropa.MouseEnter
        pbxManejoMovTropa.BackgroundImage = SITRABO.My.Resources.btnMovimientosSi
    End Sub

    Private Sub pbxManejoMovTropa_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoMovTropa.MouseLeave
        pbxManejoMovTropa.BackgroundImage = SITRABO.My.Resources.btnMovimientosNo
    End Sub

    Private Sub pbxManejoAlimentacion_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoAlimentacion.GotFocus
        pbxManejoAlimentacion.BackgroundImage = SITRABO.My.Resources.btnAlimentacionSi
    End Sub

    Private Sub pbxManejoAlimentacion_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoAlimentacion.LostFocus
        pbxManejoAlimentacion.BackgroundImage = SITRABO.My.Resources.btnAlimentacionNo
    End Sub

    Private Sub pbxManejoAlimentacion_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoAlimentacion.MouseEnter
        pbxManejoAlimentacion.BackgroundImage = SITRABO.My.Resources.btnAlimentacionSi
    End Sub

    Private Sub pbxManejoAlimentacion_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoAlimentacion.MouseLeave
        pbxManejoAlimentacion.BackgroundImage = SITRABO.My.Resources.btnAlimentacionNo
    End Sub

    Private Sub pbxManejoSanidad_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoSanidad.GotFocus
        pbxManejoSanidad.BackgroundImage = SITRABO.My.Resources.btnSanidadSi
    End Sub

    Private Sub pbxManejoSanidad_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoSanidad.LostFocus
        pbxManejoSanidad.BackgroundImage = SITRABO.My.Resources.btnSanidadNo
    End Sub

    Private Sub pbxManejoSanidad_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoSanidad.MouseEnter
        pbxManejoSanidad.BackgroundImage = SITRABO.My.Resources.btnSanidadSi
    End Sub

    Private Sub pbxManejoSanidad_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoSanidad.MouseLeave
        pbxManejoSanidad.BackgroundImage = SITRABO.My.Resources.btnSanidadNo
    End Sub

    Private Sub pbxManejoPesajes_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoPesajes.GotFocus
        pbxManejoPesajes.BackgroundImage = SITRABO.My.Resources.btnPesajesSi
    End Sub

    Private Sub pbxManejoPesajes_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoPesajes.LostFocus
        pbxManejoPesajes.BackgroundImage = SITRABO.My.Resources.btnPesajesNo
    End Sub

    Private Sub pbxManejoPesajes_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoPesajes.MouseEnter
        pbxManejoPesajes.BackgroundImage = SITRABO.My.Resources.btnPesajesSi
    End Sub

    Private Sub pbxManejoPesajes_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoPesajes.MouseLeave
        pbxManejoPesajes.BackgroundImage = SITRABO.My.Resources.btnPesajesNo
    End Sub

    Private Sub pbxManejoVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoVolver.GotFocus
        pbxManejoVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxManejoVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoVolver.LostFocus
        pbxManejoVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxManejoVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoVolver.MouseEnter
        pbxManejoVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxManejoVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoVolver.MouseLeave
        pbxManejoVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxComerVentas_GotFocus(sender As Object, e As EventArgs) Handles pbxComerVentas.GotFocus
        pbxComerVentas.BackgroundImage = SITRABO.My.Resources.btnVentasSi
    End Sub

    Private Sub pbxComerVentas_LostFocus(sender As Object, e As EventArgs) Handles pbxComerVentas.LostFocus
        pbxComerVentas.BackgroundImage = SITRABO.My.Resources.btnVentasNo
    End Sub

    Private Sub pbxComerVentas_MouseEnter(sender As Object, e As EventArgs) Handles pbxComerVentas.MouseEnter
        pbxComerVentas.BackgroundImage = SITRABO.My.Resources.btnVentasSi
    End Sub

    Private Sub pbxComerVentas_MouseLeave(sender As Object, e As EventArgs) Handles pbxComerVentas.MouseLeave
        pbxComerVentas.BackgroundImage = SITRABO.My.Resources.btnVentasNo
    End Sub

    Private Sub pbxComerCompras_GotFocus(sender As Object, e As EventArgs) Handles pbxComerCompras.GotFocus
        pbxComerCompras.BackgroundImage = SITRABO.My.Resources.btnComprasSi
    End Sub

    Private Sub pbxComerCompras_LostFocus(sender As Object, e As EventArgs) Handles pbxComerCompras.LostFocus
        pbxComerCompras.BackgroundImage = SITRABO.My.Resources.btnComprasNo
    End Sub

    Private Sub pbxComerCompras_MouseEnter(sender As Object, e As EventArgs) Handles pbxComerCompras.MouseEnter
        pbxComerCompras.BackgroundImage = SITRABO.My.Resources.btnComprasSi
    End Sub

    Private Sub pbxComerCompras_MouseLeave(sender As Object, e As EventArgs) Handles pbxComerCompras.MouseLeave
        pbxComerCompras.BackgroundImage = SITRABO.My.Resources.btnComprasNo
    End Sub

    Private Sub pbxComerVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxComerVolver.GotFocus
        pbxComerVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxComerVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxComerVolver.LostFocus
        pbxComerVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxComerVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxComerVolver.MouseEnter
        pbxComerVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxComerVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxComerVolver.MouseLeave
        pbxComerVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxConsultasAlimentacion_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultasAlimentacion.GotFocus
        pbxConsultasAlimentacion.BackgroundImage = SITRABO.My.Resources.btnConsultaAlimentacionSi
    End Sub

    Private Sub pbxConsultasAlimentacion_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultasAlimentacion.LostFocus
        pbxConsultasAlimentacion.BackgroundImage = SITRABO.My.Resources.btnConsultaAlimentacionNo
    End Sub

    Private Sub pbxConsultasAlimentacion_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultasAlimentacion.MouseEnter
        pbxConsultasAlimentacion.BackgroundImage = SITRABO.My.Resources.btnConsultaAlimentacionSi
    End Sub

    Private Sub pbxConsultasAlimentacion_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultasAlimentacion.MouseLeave
        pbxConsultasAlimentacion.BackgroundImage = SITRABO.My.Resources.btnConsultaAlimentacionNo
    End Sub

    Private Sub pbxConsultasTropas_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultasTropas.GotFocus
        pbxConsultasTropas.BackgroundImage = SITRABO.My.Resources.btnConsultaTropaSi
    End Sub

    Private Sub pbxConsultasTropas_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultasTropas.LostFocus
        pbxConsultasTropas.BackgroundImage = SITRABO.My.Resources.btnConsultaTropaNo
    End Sub

    Private Sub pbxConsultasTropas_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultasTropas.MouseEnter
        pbxConsultasTropas.BackgroundImage = SITRABO.My.Resources.btnConsultaTropaSi
    End Sub

    Private Sub pbxConsultasTropas_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultasTropas.MouseLeave
        pbxConsultasTropas.BackgroundImage = SITRABO.My.Resources.btnConsultaTropaNo
    End Sub

    Private Sub pbxConsStock_GotFocus(sender As Object, e As EventArgs) Handles pbxConsStock.GotFocus
        pbxConsStock.BackgroundImage = SITRABO.My.Resources.btnStockSi
    End Sub

    Private Sub pbxConsStock_LostFocus(sender As Object, e As EventArgs) Handles pbxConsStock.LostFocus
        pbxConsStock.BackgroundImage = SITRABO.My.Resources.btnStockNo
    End Sub

    Private Sub pbxConsStock_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsStock.MouseEnter
        pbxConsStock.BackgroundImage = SITRABO.My.Resources.btnStockSi
    End Sub

    Private Sub pbxConsStock_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsStock.MouseLeave
        pbxConsStock.BackgroundImage = SITRABO.My.Resources.btnStockNo
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        End
    End Sub

    Private Sub pbxConsultasVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultasVolver.GotFocus
        pbxConsultasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxConsultasVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultasVolver.LostFocus
        pbxConsultasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxConsultasVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultasVolver.MouseEnter
        pbxConsultasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxConsultasVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultasVolver.MouseLeave
        pbxConsultasVolver.BackgroundImage = SITRABO.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxRaciones_GotFocus(sender As Object, e As EventArgs) Handles pbxRaciones.GotFocus
        pbxRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesSi
    End Sub

    Private Sub pbxRaciones_LostFocus(sender As Object, e As EventArgs) Handles pbxRaciones.LostFocus
        pbxRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesNo
    End Sub

    Private Sub pbxRaciones_MouseEnter(sender As Object, e As EventArgs) Handles pbxRaciones.MouseEnter
        pbxRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesSi
    End Sub

    Private Sub pbxRaciones_MouseLeave(sender As Object, e As EventArgs) Handles pbxRaciones.MouseLeave
        pbxRaciones.BackgroundImage = SITRABO.My.Resources.btnRacionesNo
    End Sub

    Private Sub pbxAnalisisDatos_GotFocus(sender As Object, e As EventArgs) Handles pbxAnalisisDatos.GotFocus
        pbxAnalisisDatos.BackgroundImage = SITRABO.My.Resources.btnExportarDatosSi1
    End Sub

    Private Sub pbxAnalisisDatos_LostFocus(sender As Object, e As EventArgs) Handles pbxAnalisisDatos.LostFocus
        pbxAnalisisDatos.BackgroundImage = SITRABO.My.Resources.btnExportarDatosNo1
    End Sub

    Private Sub pbxAnalisisDatos_MouseEnter(sender As Object, e As EventArgs) Handles pbxAnalisisDatos.MouseEnter
        pbxAnalisisDatos.BackgroundImage = SITRABO.My.Resources.btnExportarDatosSi1
    End Sub

    Private Sub pbxAnalisisDatos_MouseLeave(sender As Object, e As EventArgs) Handles pbxAnalisisDatos.MouseLeave
        pbxAnalisisDatos.BackgroundImage = SITRABO.My.Resources.btnExportarDatosNo1
    End Sub

    Private Sub pbxConsPesaje_GotFocus(sender As Object, e As EventArgs) Handles pbxConsPesaje.GotFocus
        pbxConsPesaje.BackgroundImage = SITRABO.My.Resources.btnPesajesSi
    End Sub

    Private Sub pbxConsPesaje_LostFocus(sender As Object, e As EventArgs) Handles pbxConsPesaje.LostFocus
        pbxConsPesaje.BackgroundImage = SITRABO.My.Resources.btnPesajesNo
    End Sub

    Private Sub pbxConsPesaje_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsPesaje.MouseEnter
        pbxConsPesaje.BackgroundImage = SITRABO.My.Resources.btnPesajesSi
    End Sub

    Private Sub pbxConsPesaje_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsPesaje.MouseLeave
        pbxConsPesaje.BackgroundImage = SITRABO.My.Resources.btnPesajesNo
    End Sub

    Private Sub LimpiarElementos()
        pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasNo2
        pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoNo
        pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasNo
        pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerNo
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirNo

        gbxPanel0.Visible = False
        gbxPanelManejo.Visible = False
        gbxPanelAltas.Visible = False
        gbxPanelComer.Visible = False
        gbxConsultas.Visible = False
    End Sub

    Private Sub pbxAltas_Click(sender As Object, e As EventArgs) Handles pbxAltas.Click
        LimpiarElementos()

        pbxAltas.BackgroundImage = SITRABO.My.Resources.btnAltasSi
        gbxPanelAltas.Visible = True
    End Sub

    Private Sub pbxManejo_Click(sender As Object, e As EventArgs) Handles pbxManejo.Click
        LimpiarElementos()

        pbxManejo.BackgroundImage = SITRABO.My.Resources.btnManejoSi
        gbxPanelManejo.Visible = True
    End Sub

    Private Sub pbxAltasVolver_Click(sender As Object, e As EventArgs) Handles pbxAltasVolver.Click, pbxManejoVolver.Click, pbxComerVolver.Click
        LimpiarElementos()

        gbxPanel0.Visible = True
    End Sub

    Private Sub frmPPal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt, _DtM, _Dt2, _Dt3, _Dt4 As New DataTable
        Dim G As New GrabaDatos
        Dim _Ver, _VerM, _Ver2, _Ver3, _Ver4 As New Mostrar
        Dim _Stk As New Stock
        Dim StkDia As Boolean = False

        Dim Ancho, Alto As Double

        Ancho = 1616 / Me.Width
        Alto = 876 / Me.Height

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            pbxParametros.Visible = True
        Else
            pbxParametros.Visible = False
        End If

        Resolucion(Ancho, Alto)

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"
    End Sub

    Private Sub Resolucion(Ancho As Double, Alto As Double)

        'AJUSTAR TAMAÑO AVISOS PPAL
        gbxCompras.Height = gbxCompras.Height / Alto
        gbxCompras.Width = gbxCompras.Width / Ancho
        gbxVentas.Height = gbxVentas.Height / Alto
        gbxVentas.Width = gbxVentas.Width / Ancho
        lblCompras.Height = lblCompras.Height / Alto
        lblCompras.Width = lblCompras.Width / Ancho
        lblVentas.Height = lblVentas.Height / Alto
        lblVentas.Width = lblVentas.Width / Ancho

        'AJUSTAR TAMAÑO BOTONES PANEL PPAL Y LOGO
        pbxLogo.Height = pbxLogo.Height / Alto
        pbxLogo.Width = pbxLogo.Width / Ancho
        pbxAltas.Width = pbxAltas.Width / Ancho
        pbxAltas.Height = pbxAltas.Height / Alto
        pbxManejo.Width = pbxManejo.Width / Ancho
        pbxManejo.Height = pbxManejo.Height / Alto
        pbxComer.Width = pbxComer.Width / Ancho
        pbxComer.Height = pbxComer.Height / Alto
        pbxConsultas.Width = pbxConsultas.Width / Ancho
        pbxConsultas.Height = pbxConsultas.Height / Alto
        pbxSalir.Width = pbxSalir.Width / Ancho
        pbxSalir.Height = pbxSalir.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL ALTAS
        pbxAltasProductor.Width = pbxAltasProductor.Width / Ancho
        pbxAltasProductor.Height = pbxAltasProductor.Height / Alto
        pbxAltasProveedor.Width = pbxAltasProveedor.Width / Ancho
        pbxAltasProveedor.Height = pbxAltasProveedor.Height / Alto
        pbxAltasCampo.Width = pbxAltasCampo.Width / Ancho
        pbxAltasCampo.Height = pbxAltasCampo.Height / Alto
        pbxAltasCorrales.Width = pbxAltasCorrales.Width / Ancho
        pbxAltasCorrales.Height = pbxAltasCorrales.Height / Alto
        pbxAltasTropa.Width = pbxAltasTropa.Width / Ancho
        pbxAltasTropa.Height = pbxAltasTropa.Height / Alto
        pbxAltasRaciones.Width = pbxAltasRaciones.Width / Ancho
        pbxAltasRaciones.Height = pbxAltasRaciones.Height / Alto
        pbxAltasCategorias.Width = pbxAltasCategorias.Width / Ancho
        pbxAltasCategorias.Height = pbxAltasCategorias.Height / Alto
        pbxParametros.Width = pbxParametros.Width / Ancho
        pbxParametros.Height = pbxParametros.Height / Alto
        pbxAltasVolver.Width = pbxAltasVolver.Width / Ancho
        pbxAltasVolver.Height = pbxAltasVolver.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL MANEJO
        pbxManejoMovTropa.Width = pbxManejoMovTropa.Width / Ancho
        pbxManejoMovTropa.Height = pbxManejoMovTropa.Height / Alto
        pbxManejoAlimentacion.Width = pbxManejoAlimentacion.Width / Ancho
        pbxManejoAlimentacion.Height = pbxManejoAlimentacion.Height / Alto
        pbxManejoSanidad.Width = pbxManejoSanidad.Width / Ancho
        pbxManejoSanidad.Height = pbxManejoSanidad.Height / Alto
        pbxManejoPesajes.Width = pbxManejoPesajes.Width / Ancho
        pbxManejoPesajes.Height = pbxManejoPesajes.Height / Alto
        pbxManejoVolver.Width = pbxManejoVolver.Width / Ancho
        pbxManejoVolver.Height = pbxManejoVolver.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL COMERCIALIZACION
        pbxComerVentas.Width = pbxComerVentas.Width / Ancho
        pbxComerVentas.Height = pbxComerVentas.Height / Alto
        pbxComerCompras.Width = pbxComerCompras.Width / Ancho
        pbxComerCompras.Height = pbxComerCompras.Height / Alto
        pbxComerVolver.Width = pbxComerVolver.Width / Ancho
        pbxComerVolver.Height = pbxComerVolver.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL CONSULTAS
        pbxConsultasAlimentacion.Width = pbxConsultasAlimentacion.Width / Ancho
        pbxConsultasAlimentacion.Height = pbxConsultasAlimentacion.Height / Alto
        pbxConsultasTropas.Width = pbxConsultasTropas.Width / Ancho
        pbxConsultasTropas.Height = pbxConsultasTropas.Height / Alto
        pbxConsStock.Width = pbxConsStock.Width / Ancho
        pbxConsStock.Height = pbxConsStock.Height / Alto
        pbxConsultasVolver.Width = pbxConsultasVolver.Width / Ancho
        pbxConsultasVolver.Height = pbxConsultasVolver.Height / Alto

        'CENTRAR BOTONES ANCHO PANEL PPAL
        pbxAltas.Left = (gbxPanel1.Width - pbxAltas.Width) / 2
        pbxManejo.Left = (gbxPanel1.Width - pbxManejo.Width) / 2
        pbxComer.Left = (gbxPanel1.Width - pbxComer.Width) / 2
        pbxConsultas.Left = (gbxPanel1.Width - pbxConsultas.Width) / 2
        pbxSalir.Left = (gbxPanel1.Width - pbxSalir.Width) / 2

        'CENTRAR BOTONES ALTO PANEL PPAL
        Dim seParador As Double
        Dim seParador1 As Double

        seParador = gbxPanel1.Height - (pbxAltas.Height * 5)
        seParador = seParador / 8

        pbxAltas.Top = seParador + 5
        pbxManejo.Top = pbxAltas.Top + pbxAltas.Height + seParador
        pbxComer.Top = pbxManejo.Top + pbxManejo.Height + seParador
        pbxConsultas.Top = pbxComer.Top + pbxComer.Height + seParador
        pbxSalir.Top = pbxConsultas.Top + pbxConsultas.Height + seParador

        'CENTRAR LOGO SITRABO
        pbxLogo.Top = (gbxPanel0.Height - pbxLogo.Height) / 2
        pbxLogo.Left = (gbxPanel0.Width - pbxLogo.Width) / 2

        'CENTRAR BOTONES A LO ANCHO PANEL ALTAS
        seParador = gbxPanelAltas.Height - (pbxAltasProductor.Height * 3)
        seParador = seParador / 5
        seParador1 = gbxPanelAltas.Width - (pbxAltasProductor.Width * 3)
        seParador1 = seParador1 / 5

        pbxAltasProductor.Top = seParador + 10
        pbxAltasProductor.Left = seParador1 + 15

        pbxAltasProveedor.Left = pbxAltasProductor.Left + pbxAltasProductor.Width + seParador1
        pbxAltasProveedor.Top = seParador + 10

        pbxAltasCampo.Left = pbxAltasProveedor.Left + pbxAltasProveedor.Width + seParador1
        pbxAltasCampo.Top = seParador + 10
        '-----------------------------------------------------------------------------------
        pbxAltasCorrales.Top = pbxAltasProductor.Top + pbxAltasProductor.Height + seParador
        pbxAltasCorrales.Left = seParador1 + 15

        pbxAltasTropa.Left = pbxAltasCorrales.Left + pbxAltasCorrales.Width + seParador1
        pbxAltasTropa.Top = pbxAltasProductor.Top + pbxAltasProductor.Height + seParador

        pbxAltasRaciones.Left = pbxAltasTropa.Left + pbxAltasTropa.Width + seParador1
        pbxAltasRaciones.Top = pbxAltasProductor.Top + pbxAltasProductor.Height + seParador
        '-----------------------------------------------------------------------------------
        pbxAltasCategorias.Top = pbxAltasCorrales.Top + pbxAltasCorrales.Height + seParador
        pbxAltasCategorias.Left = seParador1 + 15

        pbxParametros.Top = pbxAltasCorrales.Top + pbxAltasCorrales.Height + seParador
        pbxParametros.Left = pbxAltasCategorias.Left + pbxAltasCategorias.Width + seParador1

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            pbxAltasVolver.Left = pbxParametros.Left + pbxParametros.Width + seParador1
            pbxAltasVolver.Top = pbxAltasCorrales.Top + pbxAltasCorrales.Height + seParador
        Else
            pbxAltasVolver.Left = pbxAltasCategorias.Left + pbxAltasCategorias.Width + seParador1
            pbxAltasVolver.Top = pbxAltasCorrales.Top + pbxAltasCorrales.Height + seParador
        End If

        'CENTRAR BOTONES A LO ANCHO PANEL MANEJO
        pbxManejoMovTropa.Top = seParador + 10
        pbxManejoMovTropa.Left = seParador1 + 15

        pbxManejoAlimentacion.Left = pbxManejoMovTropa.Left + pbxManejoMovTropa.Width + seParador1
        pbxManejoAlimentacion.Top = seParador + 10

        pbxManejoSanidad.Left = pbxManejoAlimentacion.Left + pbxManejoAlimentacion.Width + seParador1
        pbxManejoSanidad.Top = seParador + 10

        '-----------------------------------------------------------------------------------
        pbxManejoPesajes.Top = pbxManejoMovTropa.Top + pbxManejoMovTropa.Height + seParador
        pbxManejoPesajes.Left = seParador1 + 15

        pbxRaciones.Left = pbxManejoPesajes.Left + pbxManejoPesajes.Width + seParador1
        pbxRaciones.Top = pbxManejoMovTropa.Top + pbxManejoMovTropa.Height + seParador

        pbxManejoVolver.Left = pbxRaciones.Left + pbxRaciones.Width + seParador1
        pbxManejoVolver.Top = pbxManejoMovTropa.Top + pbxManejoMovTropa.Height + seParador

        'CENTRAR BOTONES A LO ANCHO PANEL COMERCIALIZACION
        pbxComerVentas.Top = seParador + 10
        pbxComerVentas.Left = seParador1 + 15

        pbxComerCompras.Left = pbxComerVentas.Left + pbxComerVentas.Width + seParador1
        pbxComerCompras.Top = seParador + 10

        pbxComerVolver.Left = pbxComerCompras.Left + pbxComerCompras.Width + seParador1
        pbxComerVolver.Top = seParador + 10

        'CENTRAR BOTONES A LO ANCHO PANEL CONSULTAS
        pbxConsultasAlimentacion.Top = seParador + 10
        pbxConsultasAlimentacion.Left = seParador1 + 15

        pbxConsultasTropas.Left = pbxConsultasAlimentacion.Left + pbxConsultasAlimentacion.Width + seParador1
        pbxConsultasTropas.Top = seParador + 10

        pbxConsStock.Left = pbxConsultasTropas.Left + pbxConsultasTropas.Width + seParador1
        pbxConsStock.Top = seParador + 10
        '-----------------------------------------------------------------------------------
        pbxConsPesaje.Top = pbxConsultasAlimentacion.Top + pbxConsultasAlimentacion.Height + seParador
        pbxConsPesaje.Left = seParador1 + 15

        pbxAnalisisDatos.Left = pbxConsPesaje.Left + pbxConsPesaje.Width + seParador1
        pbxAnalisisDatos.Top = pbxConsultasAlimentacion.Top + pbxConsultasAlimentacion.Height + seParador

        pbxConsultasVolver.Left = pbxAnalisisDatos.Left + pbxAnalisisDatos.Width + seParador1
        pbxConsultasVolver.Top = pbxConsultasAlimentacion.Top + pbxConsultasAlimentacion.Height + seParador

        gbxCompras.Left = gbxPanel0.Width - gbxCompras.Width - 15
        gbxCompras.Top = gbxPanel0.Height - gbxCompras.Height - 15

        gbxVentas.Left = gbxPanel0.Width - gbxVentas.Width - gbxCompras.Width - 25
        gbxVentas.Top = gbxPanel0.Height - gbxVentas.Height - 15
    End Sub

    Private Sub pbxComer_Click(sender As Object, e As EventArgs) Handles pbxComer.Click
        LimpiarElementos()

        pbxComer.BackgroundImage = SITRABO.My.Resources.btnComerSi
        gbxPanelComer.Visible = True
    End Sub

    Private Sub pbxAltasProductor_Click(sender As Object, e As EventArgs) Handles pbxAltasProductor.Click
        frmAltaProductor.Show()
    End Sub

    Private Sub pbxAltasProveedor_Click(sender As Object, e As EventArgs) Handles pbxAltasProveedor.Click
        frmAltaProveedor.Show()
    End Sub

    Private Sub pbxAltasCampo_Click(sender As Object, e As EventArgs) Handles pbxAltasCampo.Click
        frmAltaCampo.Show()
    End Sub

    Private Sub pbxAltasCorrales_Click(sender As Object, e As EventArgs) Handles pbxAltasCorrales.Click
        frmAltasCorrales.Show()
    End Sub

    Private Sub pbxAltasTropa_Click(sender As Object, e As EventArgs) Handles pbxAltasTropa.Click
        frmAltasTropa.Show()
    End Sub

    Private Sub pbxAltasCategorias_Click(sender As Object, e As EventArgs) Handles pbxAltasCategorias.Click
        frmAltasCategorias.Show()
    End Sub

    Private Sub pbxAltasRaciones_Click(sender As Object, e As EventArgs) Handles pbxAltasRaciones.Click
        frmAltasRaciones.Show()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim G As New GrabaDatos
    '    Dim resP As DialogResult
    '    Dim _Ver As New Mostrar
    '    Dim _Dt As New DataTable
    '    Dim kgG, kgC, kgF, kgO, imG, imC, imF, imO, imT, porG, porC, porF, porO As Double
    '    Try
    '        For x = 1 To 850
    '            _Dt = _Ver.verPrueba(x)
    '            For Each _Dr As DataRow In _Dt.Rows
    '                kgG = _Dr("KgGrano")
    '                kgC = _Dr("KgConcentrado")
    '                kgF = _Dr("KgFibra")
    '                kgO = _Dr("KgOtros")
    '                imG = _Dr("ImporteGrano")
    '                imC = _Dr("ImporteConcentrado")
    '                imF = _Dr("ImporteFibra")
    '                imO = _Dr("ImporteOtros")
    '                imT = _Dr("ImporteTotal")
    '                porG = _Dr("PorcentajeGrano")
    '                porC = _Dr("PorcentajeConc")
    '                porF = _Dr("PorcentajeFibra")
    '                porO = _Dr("PorcentajeOtros")
    '            Next

    '            G.Grabar("Corrales", "NoImagen", "feedlot.modDetalleAlim", kgG, kgC, kgF, kgO, imG, imC, imF, imO, imT, porG, porC, porF, porO, x)
    '        Next
    '    Catch ex As MySqlException
    '        MsgBox(ex.ToString)
    '        BDxxx()
    '    Finally
    '        BDxxx()
    '    End Try



    'End Sub

    Private Sub pbxManejoAlimentacion_Click(sender As Object, e As EventArgs) Handles pbxManejoAlimentacion.Click
        frmManejoAlimentacion.Show()
    End Sub

    Private Sub pbxParametros_Click(sender As Object, e As EventArgs) Handles pbxParametros.Click
        frmParametros.Show()
    End Sub

    Private Sub pbxManejoMovTropa_Click(sender As Object, e As EventArgs) Handles pbxManejoMovTropa.Click
        frmMovimientosTropa.Show()
    End Sub

    Private Sub pbxManejoPesajes_Click(sender As Object, e As EventArgs) Handles pbxManejoPesajes.Click
        frmPesajes.Show()
    End Sub

    Private Sub pbxConsultas_Click(sender As Object, e As EventArgs) Handles pbxConsultas.Click
        LimpiarElementos()

        pbxConsultas.BackgroundImage = SITRABO.My.Resources.btnConsultasSi
        gbxConsultas.Visible = True
    End Sub

    Private Sub pbxConsultasVolver_Click(sender As Object, e As EventArgs) Handles pbxConsultasVolver.Click
        LimpiarElementos()

        gbxPanel0.Visible = True
    End Sub

    Private Sub pbxConsultasAlimentacion_Click(sender As Object, e As EventArgs) Handles pbxConsultasAlimentacion.Click
        frmConsAlimentacion.Show()
    End Sub

    Private Sub pbxManejoSanidad_Click(sender As Object, e As EventArgs) Handles pbxManejoSanidad.Click
        frmSanidad.Show()
    End Sub

    Private Sub pbxConsultasTropas_Click(sender As Object, e As EventArgs) Handles pbxConsultasTropas.Click
        frmConsTropas.Show()
    End Sub

    Private Sub pbxComerVentas_Click(sender As Object, e As EventArgs) Handles pbxComerVentas.Click
        frmVentas.Show()
    End Sub

    Private Sub pbxConsStock_Click(sender As Object, e As EventArgs) Handles pbxConsStock.Click
        frmConsStock.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        frmConsPesajes.Show()
    End Sub

    Private Sub PbxRaciones_Click(sender As Object, e As EventArgs) Handles pbxRaciones.Click
        frmRaciones.Show()
    End Sub

    Private Sub PbxAnalisisDatos_Click(sender As Object, e As EventArgs) Handles pbxAnalisisDatos.Click
        frmAnalisisDatos.Show()
    End Sub

    Private Sub pbxAnalisisPesajes_Click(sender As Object, e As EventArgs) Handles pbxConsPesaje.Click
        frmConsPesajes.Show()
    End Sub
End Class
