<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.gbxBotonesIngresar = New System.Windows.Forms.GroupBox()
        Me.pbxRegistro = New System.Windows.Forms.PictureBox()
        Me.pbxIngresar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxLogin = New System.Windows.Forms.GroupBox()
        Me.txtTipUs = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.gbxRegistro = New System.Windows.Forms.GroupBox()
        Me.cbxTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbxConexion = New System.Windows.Forms.GroupBox()
        Me.rbtServidor = New System.Windows.Forms.RadioButton()
        Me.rbtLocal = New System.Windows.Forms.RadioButton()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.gbxBotonesRegistro = New System.Windows.Forms.GroupBox()
        Me.pbxSalirRegistro = New System.Windows.Forms.PictureBox()
        Me.gbxBotonesIngresar.SuspendLayout()
        CType(Me.pbxRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLogin.SuspendLayout()
        Me.gbxRegistro.SuspendLayout()
        Me.gbxConexion.SuspendLayout()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotonesRegistro.SuspendLayout()
        CType(Me.pbxSalirRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxBotonesIngresar
        '
        Me.gbxBotonesIngresar.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotonesIngresar.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxBotonesIngresar.Controls.Add(Me.pbxRegistro)
        Me.gbxBotonesIngresar.Controls.Add(Me.pbxIngresar)
        Me.gbxBotonesIngresar.Controls.Add(Me.pbxSalir)
        Me.gbxBotonesIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBotonesIngresar.ForeColor = System.Drawing.Color.White
        Me.gbxBotonesIngresar.Location = New System.Drawing.Point(12, 12)
        Me.gbxBotonesIngresar.Name = "gbxBotonesIngresar"
        Me.gbxBotonesIngresar.Size = New System.Drawing.Size(148, 367)
        Me.gbxBotonesIngresar.TabIndex = 15
        Me.gbxBotonesIngresar.TabStop = False
        '
        'pbxRegistro
        '
        Me.pbxRegistro.BackColor = System.Drawing.Color.Transparent
        Me.pbxRegistro.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnRegistrarNo1
        Me.pbxRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxRegistro.Location = New System.Drawing.Point(6, 117)
        Me.pbxRegistro.Name = "pbxRegistro"
        Me.pbxRegistro.Size = New System.Drawing.Size(136, 91)
        Me.pbxRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxRegistro.TabIndex = 8
        Me.pbxRegistro.TabStop = False
        '
        'pbxIngresar
        '
        Me.pbxIngresar.BackColor = System.Drawing.Color.Transparent
        Me.pbxIngresar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnIngresarNo1
        Me.pbxIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxIngresar.Location = New System.Drawing.Point(6, 15)
        Me.pbxIngresar.Name = "pbxIngresar"
        Me.pbxIngresar.Size = New System.Drawing.Size(136, 91)
        Me.pbxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIngresar.TabIndex = 9
        Me.pbxIngresar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(6, 268)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(136, 91)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 10
        Me.pbxSalir.TabStop = False
        '
        'gbxLogin
        '
        Me.gbxLogin.BackColor = System.Drawing.Color.Transparent
        Me.gbxLogin.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxLogin.Controls.Add(Me.txtTipUs)
        Me.gbxLogin.Controls.Add(Me.txtID)
        Me.gbxLogin.Controls.Add(Me.txtNom)
        Me.gbxLogin.Controls.Add(Me.txtAp)
        Me.gbxLogin.Controls.Add(Me.lblContraseña)
        Me.gbxLogin.Controls.Add(Me.lblUsuario)
        Me.gbxLogin.Controls.Add(Me.txtUsuario)
        Me.gbxLogin.Controls.Add(Me.txtContraseña)
        Me.gbxLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLogin.ForeColor = System.Drawing.Color.White
        Me.gbxLogin.Location = New System.Drawing.Point(166, 12)
        Me.gbxLogin.Name = "gbxLogin"
        Me.gbxLogin.Size = New System.Drawing.Size(476, 289)
        Me.gbxLogin.TabIndex = 7
        Me.gbxLogin.TabStop = False
        Me.gbxLogin.Text = " Login "
        '
        'txtTipUs
        '
        Me.txtTipUs.BackColor = System.Drawing.Color.LightCoral
        Me.txtTipUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTipUs.Location = New System.Drawing.Point(353, 21)
        Me.txtTipUs.MaxLength = 10
        Me.txtTipUs.Name = "txtTipUs"
        Me.txtTipUs.Size = New System.Drawing.Size(99, 20)
        Me.txtTipUs.TabIndex = 14
        Me.txtTipUs.Visible = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightCoral
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(248, 21)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(99, 20)
        Me.txtID.TabIndex = 13
        Me.txtID.Visible = False
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.LightCoral
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNom.Location = New System.Drawing.Point(143, 21)
        Me.txtNom.MaxLength = 10
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(99, 20)
        Me.txtNom.TabIndex = 12
        Me.txtNom.Visible = False
        '
        'txtAp
        '
        Me.txtAp.BackColor = System.Drawing.Color.LightCoral
        Me.txtAp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAp.Location = New System.Drawing.Point(38, 21)
        Me.txtAp.MaxLength = 10
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(99, 20)
        Me.txtAp.TabIndex = 11
        Me.txtAp.Visible = False
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.Moccasin
        Me.lblContraseña.Location = New System.Drawing.Point(27, 165)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(124, 25)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Moccasin
        Me.lblUsuario.Location = New System.Drawing.Point(27, 109)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(144, 25)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario (DNI)"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Moccasin
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtUsuario.Location = New System.Drawing.Point(177, 109)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(274, 30)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.Moccasin
        Me.txtContraseña.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtContraseña.Location = New System.Drawing.Point(177, 162)
        Me.txtContraseña.MaxLength = 255
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(274, 34)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxRegistro
        '
        Me.gbxRegistro.BackColor = System.Drawing.Color.Transparent
        Me.gbxRegistro.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxRegistro.Controls.Add(Me.cbxTipoUsuario)
        Me.gbxRegistro.Controls.Add(Me.Label6)
        Me.gbxRegistro.Controls.Add(Me.Label5)
        Me.gbxRegistro.Controls.Add(Me.txtRePassword)
        Me.gbxRegistro.Controls.Add(Me.Label4)
        Me.gbxRegistro.Controls.Add(Me.txtPassword)
        Me.gbxRegistro.Controls.Add(Me.Label3)
        Me.gbxRegistro.Controls.Add(Me.txtDni)
        Me.gbxRegistro.Controls.Add(Me.Label1)
        Me.gbxRegistro.Controls.Add(Me.Label2)
        Me.gbxRegistro.Controls.Add(Me.txtApellido)
        Me.gbxRegistro.Controls.Add(Me.txtNombre)
        Me.gbxRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRegistro.ForeColor = System.Drawing.Color.White
        Me.gbxRegistro.Location = New System.Drawing.Point(166, 12)
        Me.gbxRegistro.Name = "gbxRegistro"
        Me.gbxRegistro.Size = New System.Drawing.Size(476, 289)
        Me.gbxRegistro.TabIndex = 8
        Me.gbxRegistro.TabStop = False
        Me.gbxRegistro.Text = " Registro "
        Me.gbxRegistro.Visible = False
        '
        'cbxTipoUsuario
        '
        Me.cbxTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoUsuario.FormattingEnabled = True
        Me.cbxTipoUsuario.Items.AddRange(New Object() {"Super Usuario", "Usuario", "Invitado"})
        Me.cbxTipoUsuario.Location = New System.Drawing.Point(172, 316)
        Me.cbxTipoUsuario.Name = "cbxTipoUsuario"
        Me.cbxTipoUsuario.Size = New System.Drawing.Size(293, 33)
        Me.cbxTipoUsuario.TabIndex = 18
        Me.cbxTipoUsuario.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(6, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tipo de Usuario"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(11, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Rep. Contraseña"
        '
        'txtRePassword
        '
        Me.txtRePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtRePassword.Location = New System.Drawing.Point(162, 223)
        Me.txtRePassword.MaxLength = 255
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(293, 32)
        Me.txtRePassword.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(11, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPassword.Location = New System.Drawing.Point(162, 176)
        Me.txtPassword.MaxLength = 255
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(293, 32)
        Me.txtPassword.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DNI"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDni.Location = New System.Drawing.Point(162, 128)
        Me.txtDni.MaxLength = 255
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(293, 32)
        Me.txtDni.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(11, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtApellido.Location = New System.Drawing.Point(162, 34)
        Me.txtApellido.MaxLength = 10
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(293, 32)
        Me.txtApellido.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtNombre.Location = New System.Drawing.Point(161, 80)
        Me.txtNombre.MaxLength = 255
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(294, 32)
        Me.txtNombre.TabIndex = 1
        '
        'gbxConexion
        '
        Me.gbxConexion.BackColor = System.Drawing.Color.Transparent
        Me.gbxConexion.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxConexion.Controls.Add(Me.rbtServidor)
        Me.gbxConexion.Controls.Add(Me.rbtLocal)
        Me.gbxConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConexion.ForeColor = System.Drawing.Color.White
        Me.gbxConexion.Location = New System.Drawing.Point(166, 307)
        Me.gbxConexion.Name = "gbxConexion"
        Me.gbxConexion.Size = New System.Drawing.Size(476, 72)
        Me.gbxConexion.TabIndex = 17
        Me.gbxConexion.TabStop = False
        Me.gbxConexion.Text = " Conexión "
        '
        'rbtServidor
        '
        Me.rbtServidor.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtServidor.BackColor = System.Drawing.Color.Peru
        Me.rbtServidor.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtServidor.Location = New System.Drawing.Point(246, 21)
        Me.rbtServidor.Name = "rbtServidor"
        Me.rbtServidor.Size = New System.Drawing.Size(219, 37)
        Me.rbtServidor.TabIndex = 17
        Me.rbtServidor.TabStop = True
        Me.rbtServidor.Text = "Servidor"
        Me.rbtServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtServidor.UseVisualStyleBackColor = False
        '
        'rbtLocal
        '
        Me.rbtLocal.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtLocal.BackColor = System.Drawing.Color.Peru
        Me.rbtLocal.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtLocal.Location = New System.Drawing.Point(11, 21)
        Me.rbtLocal.Name = "rbtLocal"
        Me.rbtLocal.Size = New System.Drawing.Size(219, 37)
        Me.rbtLocal.TabIndex = 16
        Me.rbtLocal.TabStop = True
        Me.rbtLocal.Text = "Local"
        Me.rbtLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtLocal.UseVisualStyleBackColor = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Location = New System.Drawing.Point(6, 117)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(136, 91)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 9
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxGuardar.Location = New System.Drawing.Point(6, 15)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(136, 91)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 8
        Me.pbxGuardar.TabStop = False
        '
        'gbxBotonesRegistro
        '
        Me.gbxBotonesRegistro.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotonesRegistro.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxBotonesRegistro.Controls.Add(Me.pbxSalirRegistro)
        Me.gbxBotonesRegistro.Controls.Add(Me.pbxCancelar)
        Me.gbxBotonesRegistro.Controls.Add(Me.pbxGuardar)
        Me.gbxBotonesRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBotonesRegistro.ForeColor = System.Drawing.Color.White
        Me.gbxBotonesRegistro.Location = New System.Drawing.Point(12, 12)
        Me.gbxBotonesRegistro.Name = "gbxBotonesRegistro"
        Me.gbxBotonesRegistro.Size = New System.Drawing.Size(148, 367)
        Me.gbxBotonesRegistro.TabIndex = 16
        Me.gbxBotonesRegistro.TabStop = False
        '
        'pbxSalirRegistro
        '
        Me.pbxSalirRegistro.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalirRegistro.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalirRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalirRegistro.Location = New System.Drawing.Point(6, 268)
        Me.pbxSalirRegistro.Name = "pbxSalirRegistro"
        Me.pbxSalirRegistro.Size = New System.Drawing.Size(136, 91)
        Me.pbxSalirRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalirRegistro.TabIndex = 10
        Me.pbxSalirRegistro.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.gbxBotonesIngresar)
        Me.Controls.Add(Me.gbxBotonesRegistro)
        Me.Controls.Add(Me.gbxLogin)
        Me.Controls.Add(Me.gbxConexion)
        Me.Controls.Add(Me.gbxRegistro)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.gbxBotonesIngresar.ResumeLayout(False)
        CType(Me.pbxRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLogin.ResumeLayout(False)
        Me.gbxLogin.PerformLayout()
        Me.gbxRegistro.ResumeLayout(False)
        Me.gbxRegistro.PerformLayout()
        Me.gbxConexion.ResumeLayout(False)
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotonesRegistro.ResumeLayout(False)
        CType(Me.pbxSalirRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents gbxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents pbxIngresar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxRegistro As System.Windows.Forms.PictureBox
    Friend WithEvents gbxRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents cbxTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRePassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtAp As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtTipUs As System.Windows.Forms.TextBox
    Friend WithEvents rbtLocal As RadioButton
    Friend WithEvents gbxConexion As GroupBox
    Friend WithEvents rbtServidor As RadioButton
    Friend WithEvents gbxBotonesIngresar As GroupBox
    Friend WithEvents gbxBotonesRegistro As GroupBox
    Friend WithEvents pbxSalirRegistro As PictureBox
End Class
