<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicaciónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(739, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplicaciónToolStripMenuItem
        '
        Me.AplicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem, Me.BusquedaToolStripMenuItem})
        Me.AplicaciónToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AplicaciónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AplicaciónToolStripMenuItem.Name = "AplicaciónToolStripMenuItem"
        Me.AplicaciónToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.AplicaciónToolStripMenuItem.Text = "Aplicación"
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IngresoToolStripMenuItem.Text = "Ingreso"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(46, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplica03.My.Resources.Resources.p2
        Me.ClientSize = New System.Drawing.Size(739, 517)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AplicaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
