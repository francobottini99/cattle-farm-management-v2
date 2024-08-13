Imports MySql.Data.MySqlClient

Public Class frmLogin
    Public Event KeyPr As KeyPressEventHandler
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

    Private Sub pbxIngresar_GotFocus(sender As Object, e As EventArgs) Handles pbxIngresar.GotFocus
        pbxIngresar.BackgroundImage = SITRABO.My.Resources.btnIngresarSi1
    End Sub

    Private Sub pbxIngresar_LostFocus(sender As Object, e As EventArgs) Handles pbxIngresar.LostFocus
        pbxIngresar.BackgroundImage = SITRABO.My.Resources.btnIngresarNo1
    End Sub

    Private Sub pbxIngresar_MouseEnter(sender As Object, e As EventArgs) Handles pbxIngresar.MouseEnter
        pbxIngresar.BackgroundImage = SITRABO.My.Resources.btnIngresarSi1
    End Sub

    Private Sub pbxIngresar_MouseLeave(sender As Object, e As EventArgs) Handles pbxIngresar.MouseLeave
        pbxIngresar.BackgroundImage = SITRABO.My.Resources.btnIngresarNo1
    End Sub

    Private Sub pbxRegistro_GotFocus(sender As Object, e As EventArgs) Handles pbxRegistro.GotFocus
        pbxRegistro.BackgroundImage = SITRABO.My.Resources.btnRegistrarSi1
    End Sub

    Private Sub pbxRegistro_LostFocus(sender As Object, e As EventArgs) Handles pbxRegistro.LostFocus
        pbxRegistro.BackgroundImage = SITRABO.My.Resources.btnRegistrarNo1
    End Sub

    Private Sub pbxRegistro_MouseEnter(sender As Object, e As EventArgs) Handles pbxRegistro.MouseEnter
        pbxRegistro.BackgroundImage = SITRABO.My.Resources.btnRegistrarSi1
    End Sub

    Private Sub pbxRegistro_MouseLeave(sender As Object, e As EventArgs) Handles pbxRegistro.MouseLeave
        pbxRegistro.BackgroundImage = SITRABO.My.Resources.btnRegistrarNo1
    End Sub

    Private Sub pbxSalirRegistro_GotFocus(sender As Object, e As EventArgs) Handles pbxSalirRegistro.GotFocus
        pbxSalirRegistro.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalirRegistro_LostFocus(sender As Object, e As EventArgs) Handles pbxSalirRegistro.LostFocus
        pbxSalirRegistro.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub pbxSalirRegistro_MouseEnter(sender As Object, e As EventArgs) Handles pbxSalirRegistro.MouseEnter
        pbxSalirRegistro.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalirRegistro_MouseLeave(sender As Object, e As EventArgs) Handles pbxSalirRegistro.MouseLeave
        pbxSalirRegistro.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub pbxCancelar_GotFocus(sender As Object, e As EventArgs) Handles pbxCancelar.GotFocus
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_LostFocus(sender As Object, e As EventArgs) Handles pbxCancelar.LostFocus
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxCancelar_MouseEnter(sender As Object, e As EventArgs) Handles pbxCancelar.MouseEnter
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_MouseLeave(sender As Object, e As EventArgs) Handles pbxCancelar.MouseLeave
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxGuardar_GotFocus(sender As Object, e As EventArgs) Handles pbxGuardar.GotFocus
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_LostFocus(sender As Object, e As EventArgs) Handles pbxGuardar.LostFocus
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxGuardar_MouseEnter(sender As Object, e As EventArgs) Handles pbxGuardar.MouseEnter
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_MouseLeave(sender As Object, e As EventArgs) Handles pbxGuardar.MouseLeave
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click, pbxSalirRegistro.Click
        End
    End Sub

    Private Sub pbxIngresar_Click(sender As Object, e As EventArgs) Handles pbxIngresar.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim G As New GrabaDatos

        _Dt = _Ver.consUsuariosIniciar(txtUsuario.Text, txtContraseña.Text)

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                txtID.Text = _Dr("idUsuario")
                txtAp.Text = _Dr("Apellido")
                txtNom.Text = _Dr("Nombres")
                txtTipUs.Text = _Dr("CategoriaUsuario")
            Next

            G.Grabar("Usuarios", "NoImagen", "feedlot.modFechUsuario", CInt(txtID.Text), Format(DateTime.Now, "yyyy/MM/dd H:mm:ss"))

            frmPPal.txtTipUs.Text = txtTipUs.Text
            frmPPal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o Contraseña incorrectos !", MsgBoxStyle.Critical)
            txtUsuario.Select()
        End If
    End Sub

    Private Sub pbxRegistro_Click(sender As Object, e As EventArgs) Handles pbxRegistro.Click
        gbxLogin.Visible = False
        gbxRegistro.Visible = True
        gbxBotonesIngresar.Visible = False
        gbxBotonesRegistro.Visible = True
        txtApellido.Select()
    End Sub
    Private Sub Cancelar()
        gbxLogin.Visible = True
        gbxRegistro.Visible = False
        gbxBotonesIngresar.Visible = True
        gbxBotonesRegistro.Visible = False
        txtApellido.Text = ""
        txtDni.Text = ""
        txtNombre.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
        cbxTipoUsuario.Text = ""
        txtUsuario.Select()
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim resP As DialogResult
        Dim G As New GrabaDatos

        Try
            resP = MessageBox.Show("Registrar usuario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                If txtApellido.Text <> "" Then
                    If txtNombre.Text <> "" Then
                        If txtDni.Text <> "" Then
                            If txtPassword.Text <> "" Then
                                If txtPassword.Text = txtRePassword.Text Then

                                    If cbxTipoUsuario.Text = "" Then
                                        cbxTipoUsuario.Text = "Usuario"
                                    End If

                                    G.Grabar("Usuarios", "NoImagen", "feedlot.insUsuario", txtApellido.Text, txtNombre.Text, txtDni.Text, txtPassword.Text, _
                                    cbxTipoUsuario.Text, Format(Date.Now.Date, "yyyy/MM/dd"))

                                    MsgBox("Usuario registrado con exito !", MsgBoxStyle.Information)
                                    Cancelar()
                                Else
                                    MsgBox("Las Contraseñas no coinciden !", MsgBoxStyle.Exclamation)
                                    txtPassword.Select()
                                    txtPassword.Text = ""
                                    txtRePassword.Text = ""
                                End If
                            Else
                                MsgBox("El Campo Contraseña no puede quedar vacio !", MsgBoxStyle.Exclamation)
                                txtPassword.Select()
                            End If
                        Else
                            MsgBox("El Campo DNI no puede quedar vacio !", MsgBoxStyle.Exclamation)
                            txtDni.Select()
                        End If
                    Else
                        MsgBox("El Campo Nombre no puede quedar vacio !", MsgBoxStyle.Exclamation)
                        txtNombre.Select()
                    End If
                Else
                    MsgBox("El Campo Apellido no puede quedar vacio !", MsgBoxStyle.Exclamation)
                    txtApellido.Select()
                End If
            End If
        Catch ex As MySqlException
            MsgBox("Error: el Usuario No fue registrado...", MsgBoxStyle.Critical)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPassword.SelectionLength = Len(txtPassword.Text)
            txtPassword.Select()
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNombre.SelectionLength = Len(txtNombre.Text)
            txtNombre.Select()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDni.SelectionLength = Len(txtDni.Text)
            txtDni.Select()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtRePassword.SelectionLength = Len(txtRePassword.Text)
            txtRePassword.Select()
        End If
    End Sub

    Private Sub txtRePassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRePassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtContraseña.SelectionLength = Len(txtContraseña.Text)
            txtContraseña.Select()
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxIngresar.Select()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlIngresar As Control = DirectCast(pbxIngresar, Control)
        Dim keyprIngresar = New KeyPressEventHandler(AddressOf btnIngresar)
        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlIngresar.KeyPress, keyprIngresar
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - LOGIN -"

        rbtServidor.Checked = True
        rbtServidor.BackColor = Color.Peru
        rbtLocal.BackColor = Color.DimGray

        'Configurando mis separadores personales
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub btnIngresar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxIngresar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub rbtLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLocal.CheckedChanged
        If rbtLocal.Checked = True Then
            rbtLocal.BackColor = Color.Peru
            rbtServidor.BackColor = Color.DimGray
        Else
            rbtLocal.BackColor = Color.DimGray
            rbtServidor.BackColor = Color.Peru
        End If
    End Sub
End Class