<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCampo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaCampo))
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblDetR = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbxD = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSup = New System.Windows.Forms.TextBox()
        Me.dgvCampos = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxDatos.SuspendLayout()
        Me.gbxD.SuspendLayout()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gbxDatos.Controls.Add(Me.dgvCampos)
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
        Me.lblDetR.Location = New System.Drawing.Point(21, 64)
        Me.lblDetR.Name = "lblDetR"
        Me.lblDetR.Size = New System.Drawing.Size(224, 16)
        Me.lblDetR.TabIndex = 46
        Me.lblDetR.Text = " Listado De Campos Cargados "
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Moccasin
        Me.Label16.Location = New System.Drawing.Point(6, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(830, 5)
        Me.Label16.TabIndex = 47
        '
        'gbxD
        '
        Me.gbxD.Controls.Add(Me.Label7)
        Me.gbxD.Controls.Add(Me.Label1)
        Me.gbxD.Controls.Add(Me.txtCampo)
        Me.gbxD.Controls.Add(Me.Label5)
        Me.gbxD.Controls.Add(Me.txtPropietario)
        Me.gbxD.Controls.Add(Me.Label4)
        Me.gbxD.Controls.Add(Me.txtLoc)
        Me.gbxD.Controls.Add(Me.Label3)
        Me.gbxD.Controls.Add(Me.txtProv)
        Me.gbxD.Controls.Add(Me.Label2)
        Me.gbxD.Controls.Add(Me.txtSup)
        Me.gbxD.Enabled = False
        Me.gbxD.Location = New System.Drawing.Point(6, 359)
        Me.gbxD.Name = "gbxD"
        Me.gbxD.Size = New System.Drawing.Size(832, 271)
        Me.gbxD.TabIndex = 26
        Me.gbxD.TabStop = False
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Moccasin
        Me.Label7.Location = New System.Drawing.Point(166, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Has"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre Campo"
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCampo.Location = New System.Drawing.Point(41, 41)
        Me.txtCampo.MaxLength = 250
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(753, 22)
        Me.txtCampo.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(38, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Superficie"
        '
        'txtPropietario
        '
        Me.txtPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPropietario.Location = New System.Drawing.Point(41, 86)
        Me.txtPropietario.MaxLength = 250
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(753, 22)
        Me.txtPropietario.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(38, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Provincia"
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtLoc.Location = New System.Drawing.Point(41, 131)
        Me.txtLoc.MaxLength = 250
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(753, 22)
        Me.txtLoc.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(38, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Localidad"
        '
        'txtProv
        '
        Me.txtProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProv.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtProv.Location = New System.Drawing.Point(41, 180)
        Me.txtProv.MaxLength = 45
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(753, 22)
        Me.txtProv.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(38, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Propietario"
        '
        'txtSup
        '
        Me.txtSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSup.Location = New System.Drawing.Point(41, 226)
        Me.txtSup.MaxLength = 45
        Me.txtSup.Name = "txtSup"
        Me.txtSup.Size = New System.Drawing.Size(119, 22)
        Me.txtSup.TabIndex = 31
        Me.txtSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCampos
        '
        Me.dgvCampos.AllowUserToAddRows = False
        Me.dgvCampos.AllowUserToDeleteRows = False
        Me.dgvCampos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCampos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCampos.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvCampos.ColumnHeadersVisible = False
        Me.dgvCampos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCampos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCampos.Location = New System.Drawing.Point(6, 83)
        Me.dgvCampos.MultiSelect = False
        Me.dgvCampos.Name = "dgvCampos"
        Me.dgvCampos.ReadOnly = True
        Me.dgvCampos.RowHeadersVisible = False
        Me.dgvCampos.RowHeadersWidth = 100
        Me.dgvCampos.Size = New System.Drawing.Size(832, 270)
        Me.dgvCampos.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightCoral
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(691, 33)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(65, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(762, 33)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(65, 20)
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
        Me.lblMsg.Text = "CAMPO"
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
        'frmAltaCampo
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
        Me.Name = "frmAltaCampo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCampo"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.gbxD.ResumeLayout(False)
        Me.gbxD.PerformLayout()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvCampos As System.Windows.Forms.DataGridView
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxD As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSup As System.Windows.Forms.TextBox
    Friend WithEvents lblDetR As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
