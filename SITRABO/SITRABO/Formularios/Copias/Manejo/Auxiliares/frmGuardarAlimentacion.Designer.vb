<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuardarAlimentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuardarAlimentacion))
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblAlimentacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pgbAlimentacion = New System.Windows.Forms.ProgressBar()
        Me.pgbRegistros = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblGuardado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRegistro
        '
        Me.lblRegistro.BackColor = System.Drawing.Color.Gray
        Me.lblRegistro.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.ForeColor = System.Drawing.Color.Black
        Me.lblRegistro.Location = New System.Drawing.Point(16, 153)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(607, 27)
        Me.lblRegistro.TabIndex = 49
        Me.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlimentacion
        '
        Me.lblAlimentacion.BackColor = System.Drawing.Color.Gray
        Me.lblAlimentacion.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlimentacion.ForeColor = System.Drawing.Color.Black
        Me.lblAlimentacion.Location = New System.Drawing.Point(16, 67)
        Me.lblAlimentacion.Name = "lblAlimentacion"
        Me.lblAlimentacion.Size = New System.Drawing.Size(607, 26)
        Me.lblAlimentacion.TabIndex = 48
        Me.lblAlimentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(612, 33)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "GUARDANDO ALIMENTACION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbAlimentacion
        '
        Me.pgbAlimentacion.BackColor = System.Drawing.Color.Black
        Me.pgbAlimentacion.ForeColor = System.Drawing.Color.Chocolate
        Me.pgbAlimentacion.Location = New System.Drawing.Point(12, 93)
        Me.pgbAlimentacion.MarqueeAnimationSpeed = 1
        Me.pgbAlimentacion.Name = "pgbAlimentacion"
        Me.pgbAlimentacion.Size = New System.Drawing.Size(617, 43)
        Me.pgbAlimentacion.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbAlimentacion.TabIndex = 46
        '
        'pgbRegistros
        '
        Me.pgbRegistros.Location = New System.Drawing.Point(12, 178)
        Me.pgbRegistros.MarqueeAnimationSpeed = 1
        Me.pgbRegistros.Name = "pgbRegistros"
        Me.pgbRegistros.Size = New System.Drawing.Size(617, 43)
        Me.pgbRegistros.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbRegistros.TabIndex = 50
        '
        'lblGuardado
        '
        Me.lblGuardado.BackColor = System.Drawing.Color.Gray
        Me.lblGuardado.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardado.ForeColor = System.Drawing.Color.Black
        Me.lblGuardado.Location = New System.Drawing.Point(20, 89)
        Me.lblGuardado.Name = "lblGuardado"
        Me.lblGuardado.Size = New System.Drawing.Size(603, 49)
        Me.lblGuardado.TabIndex = 51
        Me.lblGuardado.Text = "ALIMENTACION GUARDADA !"
        Me.lblGuardado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGuardado.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 215)
        Me.Label1.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(626, 5)
        Me.Label2.TabIndex = 53
        '
        'frmGuardarAlimentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(643, 233)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGuardado)
        Me.Controls.Add(Me.pgbRegistros)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.lblAlimentacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pgbAlimentacion)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuardarAlimentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGuardarAlimentacion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents lblAlimentacion As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pgbAlimentacion As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbRegistros As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblGuardado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
