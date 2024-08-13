<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaProveedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaProveedor))
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblDetR = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbxD = New System.Windows.Forms.GroupBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        Me.gbxD.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedor.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvProveedor.ColumnHeadersVisible = False
        Me.dgvProveedor.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedor.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProveedor.Location = New System.Drawing.Point(6, 85)
        Me.dgvProveedor.MultiSelect = False
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.RowHeadersVisible = False
        Me.dgvProveedor.RowHeadersWidth = 100
        Me.dgvProveedor.Size = New System.Drawing.Size(831, 154)
        Me.dgvProveedor.TabIndex = 0
        '
        'gbxDatos
        '
        Me.gbxDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxDatos.Controls.Add(Me.lblDetR)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.gbxD)
        Me.gbxDatos.Controls.Add(Me.dgvProveedor)
        Me.gbxDatos.Controls.Add(Me.txtID)
        Me.gbxDatos.Controls.Add(Me.txtOrigen)
        Me.gbxDatos.Controls.Add(Me.lblMsg)
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(225, 12)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(844, 636)
        Me.gbxDatos.TabIndex = 18
        Me.gbxDatos.TabStop = False
        '
        'lblDetR
        '
        Me.lblDetR.AutoSize = True
        Me.lblDetR.ForeColor = System.Drawing.Color.Moccasin
        Me.lblDetR.Location = New System.Drawing.Point(27, 66)
        Me.lblDetR.Name = "lblDetR"
        Me.lblDetR.Size = New System.Drawing.Size(257, 16)
        Me.lblDetR.TabIndex = 48
        Me.lblDetR.Text = " Listado De Proveedores Cargados "
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Moccasin
        Me.Label16.Location = New System.Drawing.Point(12, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(825, 5)
        Me.Label16.TabIndex = 49
        '
        'gbxD
        '
        Me.gbxD.Controls.Add(Me.txtProvincia)
        Me.gbxD.Controls.Add(Me.label)
        Me.gbxD.Controls.Add(Me.txtTelefono)
        Me.gbxD.Controls.Add(Me.txtMail)
        Me.gbxD.Controls.Add(Me.Label6)
        Me.gbxD.Controls.Add(Me.Label8)
        Me.gbxD.Controls.Add(Me.Label7)
        Me.gbxD.Controls.Add(Me.Label1)
        Me.gbxD.Controls.Add(Me.txtNombre)
        Me.gbxD.Controls.Add(Me.Label5)
        Me.gbxD.Controls.Add(Me.txtDir)
        Me.gbxD.Controls.Add(Me.Label4)
        Me.gbxD.Controls.Add(Me.txtLoc)
        Me.gbxD.Controls.Add(Me.Label3)
        Me.gbxD.Controls.Add(Me.txtCP)
        Me.gbxD.Controls.Add(Me.Label2)
        Me.gbxD.Controls.Add(Me.txtCuit)
        Me.gbxD.Enabled = False
        Me.gbxD.Location = New System.Drawing.Point(6, 245)
        Me.gbxD.Name = "gbxD"
        Me.gbxD.Size = New System.Drawing.Size(832, 385)
        Me.gbxD.TabIndex = 26
        Me.gbxD.TabStop = False
        '
        'txtProvincia
        '
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtProvincia.Location = New System.Drawing.Point(50, 165)
        Me.txtProvincia.MaxLength = 250
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(735, 22)
        Me.txtProvincia.TabIndex = 47
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.ForeColor = System.Drawing.Color.Moccasin
        Me.label.Location = New System.Drawing.Point(47, 146)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(73, 16)
        Me.label.TabIndex = 48
        Me.label.Text = "Provincia"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTelefono.Location = New System.Drawing.Point(50, 304)
        Me.txtTelefono.MaxLength = 250
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(735, 22)
        Me.txtTelefono.TabIndex = 43
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtMail.Location = New System.Drawing.Point(50, 349)
        Me.txtMail.MaxLength = 250
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(735, 22)
        Me.txtMail.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(47, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Moccasin
        Me.Label8.Location = New System.Drawing.Point(47, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Teléfono"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Moccasin
        Me.Label7.Location = New System.Drawing.Point(222, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Sin guiones"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(47, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Razón Social"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtNombre.Location = New System.Drawing.Point(50, 31)
        Me.txtNombre.MaxLength = 250
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(735, 22)
        Me.txtNombre.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(47, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "CUIT"
        '
        'txtDir
        '
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtDir.Location = New System.Drawing.Point(50, 76)
        Me.txtDir.MaxLength = 250
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(735, 22)
        Me.txtDir.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(47, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Código Postal"
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtLoc.Location = New System.Drawing.Point(50, 121)
        Me.txtLoc.MaxLength = 250
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(735, 22)
        Me.txtLoc.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(47, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Localidad"
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCP.Location = New System.Drawing.Point(50, 209)
        Me.txtCP.MaxLength = 45
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(156, 22)
        Me.txtCP.TabIndex = 38
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(47, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Dirección"
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuit.Location = New System.Drawing.Point(50, 255)
        Me.txtCuit.MaxLength = 45
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(156, 22)
        Me.txtCuit.TabIndex = 40
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightCoral
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(691, 33)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(45, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(744, 33)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(47, 20)
        Me.txtOrigen.TabIndex = 24
        Me.txtOrigen.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(6, 18)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(832, 38)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "PROVEEDOR"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 636)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnNuevoNo
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Location = New System.Drawing.Point(23, 18)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(160, 116)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 8
        Me.pbxNuevo.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Location = New System.Drawing.Point(23, 384)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(160, 116)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 10
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Location = New System.Drawing.Point(23, 262)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(160, 116)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 9
        Me.pbxGuardar.TabStop = False
        '
        'pbxModificar
        '
        Me.pbxModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbxModificar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnModificarNo
        Me.pbxModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxModificar.Location = New System.Drawing.Point(23, 140)
        Me.pbxModificar.Name = "pbxModificar"
        Me.pbxModificar.Size = New System.Drawing.Size(160, 116)
        Me.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxModificar.TabIndex = 7
        Me.pbxModificar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(23, 506)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(160, 116)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 6
        Me.pbxSalir.TabStop = False
        '
        'frmAltaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAltaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltaProveedor"
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.gbxD.ResumeLayout(False)
        Me.gbxD.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxD As System.Windows.Forms.GroupBox
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblDetR As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
