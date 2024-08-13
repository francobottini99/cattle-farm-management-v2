<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsPesajes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsPesajes))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbxConsPesaje = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProm = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblDetalleConsulta = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblTotPmDes = New System.Windows.Forms.Label()
        Me.lblTotPmCab = New System.Windows.Forms.Label()
        Me.lblTotCab = New System.Windows.Forms.Label()
        Me.lblTotDes = New System.Windows.Forms.Label()
        Me.lblTotBal = New System.Windows.Forms.Label()
        Me.lblTotNet = New System.Windows.Forms.Label()
        Me.lblVtaPmDes = New System.Windows.Forms.Label()
        Me.lblVtaPmCab = New System.Windows.Forms.Label()
        Me.lblVtaCab = New System.Windows.Forms.Label()
        Me.lblVtaDes = New System.Windows.Forms.Label()
        Me.lblVtaBal = New System.Windows.Forms.Label()
        Me.lblVtaNet = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblContPmDes = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblContPmCab = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblContCab = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblContDes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContBal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblContNet = New System.Windows.Forms.Label()
        Me.dgvPesos = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdP = New System.Windows.Forms.TextBox()
        Me.txtIdCar = New System.Windows.Forms.TextBox()
        Me.txtIdCrr = New System.Windows.Forms.TextBox()
        Me.txtIdT = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtCaravana = New System.Windows.Forms.TextBox()
        Me.chbCorral = New System.Windows.Forms.CheckBox()
        Me.chbTropa = New System.Windows.Forms.CheckBox()
        Me.gbxInicial = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.chbCarav = New System.Windows.Forms.CheckBox()
        Me.chbProd = New System.Windows.Forms.CheckBox()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.chbFhasta = New System.Windows.Forms.CheckBox()
        Me.chbFdesde = New System.Windows.Forms.CheckBox()
        Me.rdbImp = New System.Windows.Forms.RadioButton()
        Me.rdbKg = New System.Windows.Forms.RadioButton()
        Me.cbxCorral = New System.Windows.Forms.ComboBox()
        Me.cbxTropa = New System.Windows.Forms.ComboBox()
        Me.cbxProductor = New System.Windows.Forms.ComboBox()
        Me.dtmFhasta = New System.Windows.Forms.DateTimePicker()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.dtmFdesde = New System.Windows.Forms.DateTimePicker()
        Me.pbxEncabezado = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxConsPesaje.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInicial.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(953, 30)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'gbxConsPesaje
        '
        Me.gbxConsPesaje.BackColor = System.Drawing.Color.Transparent
        Me.gbxConsPesaje.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxConsPesaje.Controls.Add(Me.Label5)
        Me.gbxConsPesaje.Controls.Add(Me.lblProm)
        Me.gbxConsPesaje.Controls.Add(Me.Label2)
        Me.gbxConsPesaje.Controls.Add(Me.lblSuma)
        Me.gbxConsPesaje.Controls.Add(Me.Label3)
        Me.gbxConsPesaje.Controls.Add(Me.lblCant)
        Me.gbxConsPesaje.Controls.Add(Me.lblDetalleConsulta)
        Me.gbxConsPesaje.Controls.Add(Me.GroupBox2)
        Me.gbxConsPesaje.Controls.Add(Me.dgvPesos)
        Me.gbxConsPesaje.Controls.Add(Me.Label15)
        Me.gbxConsPesaje.Controls.Add(Me.PictureBox2)
        Me.gbxConsPesaje.Enabled = False
        Me.gbxConsPesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConsPesaje.ForeColor = System.Drawing.Color.White
        Me.gbxConsPesaje.Location = New System.Drawing.Point(231, 50)
        Me.gbxConsPesaje.Name = "gbxConsPesaje"
        Me.gbxConsPesaje.Size = New System.Drawing.Size(968, 620)
        Me.gbxConsPesaje.TabIndex = 127
        Me.gbxConsPesaje.TabStop = False
        Me.gbxConsPesaje.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(685, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Promedio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProm
        '
        Me.lblProm.BackColor = System.Drawing.Color.DimGray
        Me.lblProm.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProm.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblProm.Location = New System.Drawing.Point(784, 462)
        Me.lblProm.Name = "lblProm"
        Me.lblProm.Size = New System.Drawing.Size(135, 22)
        Me.lblProm.TabIndex = 201
        Me.lblProm.Text = "0"
        Me.lblProm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(383, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Suma"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSuma
        '
        Me.lblSuma.BackColor = System.Drawing.Color.DimGray
        Me.lblSuma.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuma.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblSuma.Location = New System.Drawing.Point(435, 462)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(135, 22)
        Me.lblSuma.TabIndex = 199
        Me.lblSuma.Text = "0"
        Me.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 198
        Me.Label3.Text = "Cantidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCant
        '
        Me.lblCant.BackColor = System.Drawing.Color.DimGray
        Me.lblCant.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblCant.Location = New System.Drawing.Point(118, 462)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(135, 22)
        Me.lblCant.TabIndex = 197
        Me.lblCant.Text = "0"
        Me.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDetalleConsulta
        '
        Me.lblDetalleConsulta.BackColor = System.Drawing.Color.Black
        Me.lblDetalleConsulta.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleConsulta.ForeColor = System.Drawing.Color.White
        Me.lblDetalleConsulta.Location = New System.Drawing.Point(171, 16)
        Me.lblDetalleConsulta.Name = "lblDetalleConsulta"
        Me.lblDetalleConsulta.Size = New System.Drawing.Size(777, 21)
        Me.lblDetalleConsulta.TabIndex = 112
        Me.lblDetalleConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.lblTotPmDes)
        Me.GroupBox2.Controls.Add(Me.lblTotPmCab)
        Me.GroupBox2.Controls.Add(Me.lblTotCab)
        Me.GroupBox2.Controls.Add(Me.lblTotDes)
        Me.GroupBox2.Controls.Add(Me.lblTotBal)
        Me.GroupBox2.Controls.Add(Me.lblTotNet)
        Me.GroupBox2.Controls.Add(Me.lblVtaPmDes)
        Me.GroupBox2.Controls.Add(Me.lblVtaPmCab)
        Me.GroupBox2.Controls.Add(Me.lblVtaCab)
        Me.GroupBox2.Controls.Add(Me.lblVtaDes)
        Me.GroupBox2.Controls.Add(Me.lblVtaBal)
        Me.GroupBox2.Controls.Add(Me.lblVtaNet)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.lblContPmDes)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblContPmCab)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblContCab)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblContDes)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblContBal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblContNet)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 484)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(952, 129)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.DimGray
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Transparent
        Me.Label46.Location = New System.Drawing.Point(6, 98)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(123, 22)
        Me.Label46.TabIndex = 216
        Me.Label46.Text = "TOTAL"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotPmDes
        '
        Me.lblTotPmDes.BackColor = System.Drawing.Color.DimGray
        Me.lblTotPmDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotPmDes.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotPmDes.Location = New System.Drawing.Point(811, 98)
        Me.lblTotPmDes.Name = "lblTotPmDes"
        Me.lblTotPmDes.Size = New System.Drawing.Size(130, 22)
        Me.lblTotPmDes.TabIndex = 215
        Me.lblTotPmDes.Text = "0"
        Me.lblTotPmDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotPmCab
        '
        Me.lblTotPmCab.BackColor = System.Drawing.Color.DimGray
        Me.lblTotPmCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotPmCab.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotPmCab.Location = New System.Drawing.Point(678, 98)
        Me.lblTotPmCab.Name = "lblTotPmCab"
        Me.lblTotPmCab.Size = New System.Drawing.Size(130, 22)
        Me.lblTotPmCab.TabIndex = 214
        Me.lblTotPmCab.Text = "0"
        Me.lblTotPmCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotCab
        '
        Me.lblTotCab.BackColor = System.Drawing.Color.DimGray
        Me.lblTotCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCab.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotCab.Location = New System.Drawing.Point(144, 98)
        Me.lblTotCab.Name = "lblTotCab"
        Me.lblTotCab.Size = New System.Drawing.Size(135, 22)
        Me.lblTotCab.TabIndex = 213
        Me.lblTotCab.Text = "0"
        Me.lblTotCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotDes
        '
        Me.lblTotDes.BackColor = System.Drawing.Color.DimGray
        Me.lblTotDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDes.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotDes.Location = New System.Drawing.Point(412, 98)
        Me.lblTotDes.Name = "lblTotDes"
        Me.lblTotDes.Size = New System.Drawing.Size(130, 22)
        Me.lblTotDes.TabIndex = 212
        Me.lblTotDes.Text = "0"
        Me.lblTotDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotBal
        '
        Me.lblTotBal.BackColor = System.Drawing.Color.DimGray
        Me.lblTotBal.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotBal.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotBal.Location = New System.Drawing.Point(282, 98)
        Me.lblTotBal.Name = "lblTotBal"
        Me.lblTotBal.Size = New System.Drawing.Size(127, 22)
        Me.lblTotBal.TabIndex = 211
        Me.lblTotBal.Text = "0"
        Me.lblTotBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotNet
        '
        Me.lblTotNet.BackColor = System.Drawing.Color.DimGray
        Me.lblTotNet.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotNet.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotNet.Location = New System.Drawing.Point(545, 98)
        Me.lblTotNet.Name = "lblTotNet"
        Me.lblTotNet.Size = New System.Drawing.Size(130, 22)
        Me.lblTotNet.TabIndex = 210
        Me.lblTotNet.Text = "0"
        Me.lblTotNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaPmDes
        '
        Me.lblVtaPmDes.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaPmDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaPmDes.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaPmDes.Location = New System.Drawing.Point(811, 67)
        Me.lblVtaPmDes.Name = "lblVtaPmDes"
        Me.lblVtaPmDes.Size = New System.Drawing.Size(130, 22)
        Me.lblVtaPmDes.TabIndex = 209
        Me.lblVtaPmDes.Text = "0"
        Me.lblVtaPmDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaPmCab
        '
        Me.lblVtaPmCab.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaPmCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaPmCab.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaPmCab.Location = New System.Drawing.Point(678, 67)
        Me.lblVtaPmCab.Name = "lblVtaPmCab"
        Me.lblVtaPmCab.Size = New System.Drawing.Size(130, 22)
        Me.lblVtaPmCab.TabIndex = 208
        Me.lblVtaPmCab.Text = "0"
        Me.lblVtaPmCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaCab
        '
        Me.lblVtaCab.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaCab.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaCab.Location = New System.Drawing.Point(144, 67)
        Me.lblVtaCab.Name = "lblVtaCab"
        Me.lblVtaCab.Size = New System.Drawing.Size(135, 22)
        Me.lblVtaCab.TabIndex = 207
        Me.lblVtaCab.Text = "0"
        Me.lblVtaCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaDes
        '
        Me.lblVtaDes.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaDes.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaDes.Location = New System.Drawing.Point(412, 67)
        Me.lblVtaDes.Name = "lblVtaDes"
        Me.lblVtaDes.Size = New System.Drawing.Size(130, 22)
        Me.lblVtaDes.TabIndex = 206
        Me.lblVtaDes.Text = "0"
        Me.lblVtaDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaBal
        '
        Me.lblVtaBal.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaBal.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaBal.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaBal.Location = New System.Drawing.Point(282, 67)
        Me.lblVtaBal.Name = "lblVtaBal"
        Me.lblVtaBal.Size = New System.Drawing.Size(127, 22)
        Me.lblVtaBal.TabIndex = 205
        Me.lblVtaBal.Text = "0"
        Me.lblVtaBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVtaNet
        '
        Me.lblVtaNet.BackColor = System.Drawing.Color.DimGray
        Me.lblVtaNet.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtaNet.ForeColor = System.Drawing.Color.Gold
        Me.lblVtaNet.Location = New System.Drawing.Point(545, 67)
        Me.lblVtaNet.Name = "lblVtaNet"
        Me.lblVtaNet.Size = New System.Drawing.Size(130, 22)
        Me.lblVtaNet.TabIndex = 204
        Me.lblVtaNet.Text = "0"
        Me.lblVtaNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.DimGray
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Transparent
        Me.Label34.Location = New System.Drawing.Point(6, 68)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(123, 22)
        Me.Label34.TabIndex = 203
        Me.Label34.Text = "VENTA"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.DimGray
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(6, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 22)
        Me.Label32.TabIndex = 202
        Me.Label32.Text = "CONTROL"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(808, 13)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(133, 18)
        Me.Label31.TabIndex = 201
        Me.Label31.Text = "X /C/Des"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContPmDes
        '
        Me.lblContPmDes.BackColor = System.Drawing.Color.DimGray
        Me.lblContPmDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContPmDes.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContPmDes.Location = New System.Drawing.Point(811, 36)
        Me.lblContPmDes.Name = "lblContPmDes"
        Me.lblContPmDes.Size = New System.Drawing.Size(130, 22)
        Me.lblContPmDes.TabIndex = 200
        Me.lblContPmDes.Text = "0"
        Me.lblContPmDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(678, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(130, 16)
        Me.Label25.TabIndex = 199
        Me.Label25.Text = "X / Cab"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContPmCab
        '
        Me.lblContPmCab.BackColor = System.Drawing.Color.DimGray
        Me.lblContPmCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContPmCab.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContPmCab.Location = New System.Drawing.Point(678, 36)
        Me.lblContPmCab.Name = "lblContPmCab"
        Me.lblContPmCab.Size = New System.Drawing.Size(130, 22)
        Me.lblContPmCab.TabIndex = 198
        Me.lblContPmCab.Text = "0"
        Me.lblContPmCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(144, 11)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 23)
        Me.Label21.TabIndex = 197
        Me.Label21.Text = "Cabezas"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContCab
        '
        Me.lblContCab.BackColor = System.Drawing.Color.DimGray
        Me.lblContCab.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContCab.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContCab.Location = New System.Drawing.Point(144, 36)
        Me.lblContCab.Name = "lblContCab"
        Me.lblContCab.Size = New System.Drawing.Size(135, 22)
        Me.lblContCab.TabIndex = 196
        Me.lblContCab.Text = "0"
        Me.lblContCab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(289, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 195
        Me.Label17.Text = "Kg Balanz"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContDes
        '
        Me.lblContDes.BackColor = System.Drawing.Color.DimGray
        Me.lblContDes.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContDes.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContDes.Location = New System.Drawing.Point(412, 36)
        Me.lblContDes.Name = "lblContDes"
        Me.lblContDes.Size = New System.Drawing.Size(130, 22)
        Me.lblContDes.TabIndex = 194
        Me.lblContDes.Text = "0"
        Me.lblContDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(415, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "Kg Desb."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContBal
        '
        Me.lblContBal.BackColor = System.Drawing.Color.DimGray
        Me.lblContBal.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContBal.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContBal.Location = New System.Drawing.Point(282, 36)
        Me.lblContBal.Name = "lblContBal"
        Me.lblContBal.Size = New System.Drawing.Size(127, 22)
        Me.lblContBal.TabIndex = 192
        Me.lblContBal.Text = "0"
        Me.lblContBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(545, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 16)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Kg Netos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContNet
        '
        Me.lblContNet.BackColor = System.Drawing.Color.DimGray
        Me.lblContNet.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContNet.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblContNet.Location = New System.Drawing.Point(545, 36)
        Me.lblContNet.Name = "lblContNet"
        Me.lblContNet.Size = New System.Drawing.Size(130, 22)
        Me.lblContNet.TabIndex = 190
        Me.lblContNet.Text = "0"
        Me.lblContNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvPesos
        '
        Me.dgvPesos.AllowUserToAddRows = False
        Me.dgvPesos.AllowUserToDeleteRows = False
        Me.dgvPesos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPesos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPesos.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPesos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPesos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPesos.Location = New System.Drawing.Point(6, 47)
        Me.dgvPesos.Name = "dgvPesos"
        Me.dgvPesos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPesos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPesos.RowHeadersVisible = False
        Me.dgvPesos.RowHeadersWidth = 100
        Me.dgvPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPesos.Size = New System.Drawing.Size(953, 402)
        Me.dgvPesos.TabIndex = 162
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label15.Location = New System.Drawing.Point(13, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 20)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "DETALLE DE CONSULTA:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdP
        '
        Me.txtIdP.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdP.Location = New System.Drawing.Point(136, 446)
        Me.txtIdP.MaxLength = 10
        Me.txtIdP.Name = "txtIdP"
        Me.txtIdP.Size = New System.Drawing.Size(44, 20)
        Me.txtIdP.TabIndex = 102
        Me.txtIdP.Visible = False
        '
        'txtIdCar
        '
        Me.txtIdCar.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCar.Location = New System.Drawing.Point(157, 273)
        Me.txtIdCar.MaxLength = 10
        Me.txtIdCar.Name = "txtIdCar"
        Me.txtIdCar.Size = New System.Drawing.Size(44, 20)
        Me.txtIdCar.TabIndex = 101
        Me.txtIdCar.Visible = False
        '
        'txtIdCrr
        '
        Me.txtIdCrr.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCrr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCrr.Location = New System.Drawing.Point(157, 224)
        Me.txtIdCrr.MaxLength = 10
        Me.txtIdCrr.Name = "txtIdCrr"
        Me.txtIdCrr.Size = New System.Drawing.Size(44, 20)
        Me.txtIdCrr.TabIndex = 100
        Me.txtIdCrr.Visible = False
        '
        'txtIdT
        '
        Me.txtIdT.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdT.Location = New System.Drawing.Point(157, 174)
        Me.txtIdT.MaxLength = 10
        Me.txtIdT.Name = "txtIdT"
        Me.txtIdT.Size = New System.Drawing.Size(44, 20)
        Me.txtIdT.TabIndex = 99
        Me.txtIdT.Visible = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.SlateGray
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.btnFiltrar.FlatAppearance.BorderSize = 3
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.ForeColor = System.Drawing.Color.BurlyWood
        Me.btnFiltrar.Location = New System.Drawing.Point(3, 383)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(200, 35)
        Me.btnFiltrar.TabIndex = 98
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtCaravana
        '
        Me.txtCaravana.BackColor = System.Drawing.Color.White
        Me.txtCaravana.Enabled = False
        Me.txtCaravana.ForeColor = System.Drawing.Color.Moccasin
        Me.txtCaravana.Location = New System.Drawing.Point(3, 271)
        Me.txtCaravana.Name = "txtCaravana"
        Me.txtCaravana.Size = New System.Drawing.Size(200, 22)
        Me.txtCaravana.TabIndex = 92
        '
        'chbCorral
        '
        Me.chbCorral.AutoSize = True
        Me.chbCorral.ForeColor = System.Drawing.Color.Moccasin
        Me.chbCorral.Location = New System.Drawing.Point(11, 202)
        Me.chbCorral.Name = "chbCorral"
        Me.chbCorral.Size = New System.Drawing.Size(69, 20)
        Me.chbCorral.TabIndex = 96
        Me.chbCorral.Text = "Corral"
        Me.chbCorral.UseVisualStyleBackColor = True
        '
        'chbTropa
        '
        Me.chbTropa.AutoSize = True
        Me.chbTropa.ForeColor = System.Drawing.Color.Moccasin
        Me.chbTropa.Location = New System.Drawing.Point(11, 152)
        Me.chbTropa.Name = "chbTropa"
        Me.chbTropa.Size = New System.Drawing.Size(69, 20)
        Me.chbTropa.TabIndex = 95
        Me.chbTropa.Text = "Tropa"
        Me.chbTropa.UseVisualStyleBackColor = True
        '
        'gbxInicial
        '
        Me.gbxInicial.BackColor = System.Drawing.Color.Transparent
        Me.gbxInicial.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxInicial.Controls.Add(Me.Label44)
        Me.gbxInicial.Controls.Add(Me.pbxLogo)
        Me.gbxInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInicial.Location = New System.Drawing.Point(232, 50)
        Me.gbxInicial.Name = "gbxInicial"
        Me.gbxInicial.Size = New System.Drawing.Size(967, 613)
        Me.gbxInicial.TabIndex = 126
        Me.gbxInicial.TabStop = False
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Gray
        Me.Label44.Location = New System.Drawing.Point(237, 452)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(516, 32)
        Me.Label44.TabIndex = 73
        Me.Label44.Text = "* Selecciona una o varias casillas de verificación según lo que quieras consultar" &
    "."
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxLogo.Image = Global.SITRABO.My.Resources.Resources.Logo1
        Me.pbxLogo.Location = New System.Drawing.Point(120, 206)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(751, 172)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'chbCarav
        '
        Me.chbCarav.AutoSize = True
        Me.chbCarav.ForeColor = System.Drawing.Color.Moccasin
        Me.chbCarav.Location = New System.Drawing.Point(11, 252)
        Me.chbCarav.Name = "chbCarav"
        Me.chbCarav.Size = New System.Drawing.Size(94, 20)
        Me.chbCarav.TabIndex = 97
        Me.chbCarav.Text = "Caravana"
        Me.chbCarav.UseVisualStyleBackColor = True
        '
        'chbProd
        '
        Me.chbProd.AutoSize = True
        Me.chbProd.ForeColor = System.Drawing.Color.Moccasin
        Me.chbProd.Location = New System.Drawing.Point(7, 424)
        Me.chbProd.Name = "chbProd"
        Me.chbProd.Size = New System.Drawing.Size(94, 20)
        Me.chbProd.TabIndex = 94
        Me.chbProd.Text = "Productor"
        Me.chbProd.UseVisualStyleBackColor = True
        Me.chbProd.Visible = False
        '
        'lblConsulta
        '
        Me.lblConsulta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblConsulta.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsulta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblConsulta.Location = New System.Drawing.Point(22, 20)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(1173, 20)
        Me.lblConsulta.TabIndex = 129
        Me.lblConsulta.Text = "CONSULTA DE PESAJES"
        Me.lblConsulta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chbFhasta
        '
        Me.chbFhasta.AutoSize = True
        Me.chbFhasta.ForeColor = System.Drawing.Color.Moccasin
        Me.chbFhasta.Location = New System.Drawing.Point(11, 76)
        Me.chbFhasta.Name = "chbFhasta"
        Me.chbFhasta.Size = New System.Drawing.Size(115, 20)
        Me.chbFhasta.TabIndex = 93
        Me.chbFhasta.Text = "Fecha Hasta"
        Me.chbFhasta.UseVisualStyleBackColor = True
        '
        'chbFdesde
        '
        Me.chbFdesde.AutoSize = True
        Me.chbFdesde.ForeColor = System.Drawing.Color.Moccasin
        Me.chbFdesde.Location = New System.Drawing.Point(11, 21)
        Me.chbFdesde.Name = "chbFdesde"
        Me.chbFdesde.Size = New System.Drawing.Size(120, 20)
        Me.chbFdesde.TabIndex = 92
        Me.chbFdesde.Text = "Fecha Desde"
        Me.chbFdesde.UseVisualStyleBackColor = True
        '
        'rdbImp
        '
        Me.rdbImp.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbImp.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbImp.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.rdbImp.FlatAppearance.BorderSize = 3
        Me.rdbImp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Sienna
        Me.rdbImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbImp.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbImp.Location = New System.Drawing.Point(107, 334)
        Me.rdbImp.Name = "rdbImp"
        Me.rdbImp.Size = New System.Drawing.Size(90, 32)
        Me.rdbImp.TabIndex = 65
        Me.rdbImp.Text = "Importe"
        Me.rdbImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbImp.UseVisualStyleBackColor = False
        '
        'rdbKg
        '
        Me.rdbKg.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbKg.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbKg.Checked = True
        Me.rdbKg.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.rdbKg.FlatAppearance.BorderSize = 3
        Me.rdbKg.FlatAppearance.CheckedBackColor = System.Drawing.Color.Sienna
        Me.rdbKg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbKg.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbKg.Location = New System.Drawing.Point(11, 334)
        Me.rdbKg.Name = "rdbKg"
        Me.rdbKg.Size = New System.Drawing.Size(90, 32)
        Me.rdbKg.TabIndex = 64
        Me.rdbKg.TabStop = True
        Me.rdbKg.Text = "Kilogramos"
        Me.rdbKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbKg.UseVisualStyleBackColor = False
        '
        'cbxCorral
        '
        Me.cbxCorral.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxCorral.Enabled = False
        Me.cbxCorral.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxCorral.FormattingEnabled = True
        Me.cbxCorral.Location = New System.Drawing.Point(3, 222)
        Me.cbxCorral.Name = "cbxCorral"
        Me.cbxCorral.Size = New System.Drawing.Size(200, 24)
        Me.cbxCorral.TabIndex = 35
        '
        'cbxTropa
        '
        Me.cbxTropa.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxTropa.Enabled = False
        Me.cbxTropa.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxTropa.FormattingEnabled = True
        Me.cbxTropa.Location = New System.Drawing.Point(3, 172)
        Me.cbxTropa.Name = "cbxTropa"
        Me.cbxTropa.Size = New System.Drawing.Size(200, 24)
        Me.cbxTropa.TabIndex = 34
        '
        'cbxProductor
        '
        Me.cbxProductor.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxProductor.Enabled = False
        Me.cbxProductor.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxProductor.FormattingEnabled = True
        Me.cbxProductor.Location = New System.Drawing.Point(-1, 444)
        Me.cbxProductor.Name = "cbxProductor"
        Me.cbxProductor.Size = New System.Drawing.Size(200, 24)
        Me.cbxProductor.TabIndex = 0
        Me.cbxProductor.Visible = False
        '
        'dtmFhasta
        '
        Me.dtmFhasta.CustomFormat = "dd/MM/yyyy"
        Me.dtmFhasta.Enabled = False
        Me.dtmFhasta.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmFhasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFhasta.Location = New System.Drawing.Point(3, 98)
        Me.dtmFhasta.MaximumSize = New System.Drawing.Size(200, 22)
        Me.dtmFhasta.Name = "dtmFhasta"
        Me.dtmFhasta.Size = New System.Drawing.Size(200, 22)
        Me.dtmFhasta.TabIndex = 28
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(11, 479)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(188, 129)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 6
        Me.pbxSalir.TabStop = False
        '
        'dtmFdesde
        '
        Me.dtmFdesde.CustomFormat = "dd/MM/yyyy"
        Me.dtmFdesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtmFdesde.Enabled = False
        Me.dtmFdesde.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmFdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFdesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtmFdesde.Location = New System.Drawing.Point(3, 44)
        Me.dtmFdesde.MaximumSize = New System.Drawing.Size(200, 22)
        Me.dtmFdesde.Name = "dtmFdesde"
        Me.dtmFdesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtmFdesde.Size = New System.Drawing.Size(200, 22)
        Me.dtmFdesde.TabIndex = 25
        Me.dtmFdesde.Value = New Date(2018, 4, 30, 17, 41, 0, 0)
        '
        'pbxEncabezado
        '
        Me.pbxEncabezado.BackColor = System.Drawing.Color.Gainsboro
        Me.pbxEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxEncabezado.Location = New System.Drawing.Point(15, 6)
        Me.pbxEncabezado.Name = "pbxEncabezado"
        Me.pbxEncabezado.Size = New System.Drawing.Size(1184, 43)
        Me.pbxEncabezado.TabIndex = 128
        Me.pbxEncabezado.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.txtIdP)
        Me.GroupBox1.Controls.Add(Me.txtIdCar)
        Me.GroupBox1.Controls.Add(Me.txtIdCrr)
        Me.GroupBox1.Controls.Add(Me.txtIdT)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.txtCaravana)
        Me.GroupBox1.Controls.Add(Me.chbCarav)
        Me.GroupBox1.Controls.Add(Me.chbCorral)
        Me.GroupBox1.Controls.Add(Me.chbTropa)
        Me.GroupBox1.Controls.Add(Me.chbProd)
        Me.GroupBox1.Controls.Add(Me.chbFhasta)
        Me.GroupBox1.Controls.Add(Me.chbFdesde)
        Me.GroupBox1.Controls.Add(Me.rdbImp)
        Me.GroupBox1.Controls.Add(Me.rdbKg)
        Me.GroupBox1.Controls.Add(Me.cbxCorral)
        Me.GroupBox1.Controls.Add(Me.cbxTropa)
        Me.GroupBox1.Controls.Add(Me.cbxProductor)
        Me.GroupBox1.Controls.Add(Me.dtmFhasta)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Controls.Add(Me.dtmFdesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 630)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        '
        'frmConsPesajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 670)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.pbxEncabezado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxConsPesaje)
        Me.Controls.Add(Me.gbxInicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsPesajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsPesajes"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxConsPesaje.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInicial.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbxConsPesaje As GroupBox
    Friend WithEvents lblDetalleConsulta As Label
    Friend WithEvents txtIdP As TextBox
    Friend WithEvents txtIdCar As TextBox
    Friend WithEvents txtIdCrr As TextBox
    Friend WithEvents txtIdT As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents txtCaravana As TextBox
    Friend WithEvents chbCorral As CheckBox
    Friend WithEvents chbTropa As CheckBox
    Friend WithEvents gbxInicial As GroupBox
    Friend WithEvents Label44 As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents chbCarav As CheckBox
    Friend WithEvents chbProd As CheckBox
    Friend WithEvents lblConsulta As Label
    Friend WithEvents chbFhasta As CheckBox
    Friend WithEvents chbFdesde As CheckBox
    Friend WithEvents rdbImp As RadioButton
    Friend WithEvents rdbKg As RadioButton
    Friend WithEvents cbxCorral As ComboBox
    Friend WithEvents cbxTropa As ComboBox
    Friend WithEvents cbxProductor As ComboBox
    Friend WithEvents dtmFhasta As DateTimePicker
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents dtmFdesde As DateTimePicker
    Friend WithEvents pbxEncabezado As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvPesos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label46 As Label
    Friend WithEvents lblTotPmDes As Label
    Friend WithEvents lblTotPmCab As Label
    Friend WithEvents lblTotCab As Label
    Friend WithEvents lblTotDes As Label
    Friend WithEvents lblTotBal As Label
    Friend WithEvents lblTotNet As Label
    Friend WithEvents lblVtaPmDes As Label
    Friend WithEvents lblVtaPmCab As Label
    Friend WithEvents lblVtaCab As Label
    Friend WithEvents lblVtaDes As Label
    Friend WithEvents lblVtaBal As Label
    Friend WithEvents lblVtaNet As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblContPmDes As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblContPmCab As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblContCab As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblContDes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblContBal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblContNet As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblProm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSuma As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCant As Label
End Class
