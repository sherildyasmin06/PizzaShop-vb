<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNGRABAR = New System.Windows.Forms.Button()
        Me.BTNUEVO = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVLISTA = New System.Windows.Forms.DataGridView()
        Me.CBOSEXO = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBOTAMAÑO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOCOMBO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOTIPO = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTEDAD = New System.Windows.Forms.TextBox()
        Me.TXTNOM = New System.Windows.Forms.TextBox()
        Me.TXTAPE = New System.Windows.Forms.TextBox()
        Me.TXTCOD = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTNOMVEND = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVLISTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(122, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 33)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pizza George's"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox4.Controls.Add(Me.BTNGRABAR)
        Me.GroupBox4.Controls.Add(Me.BTNUEVO)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(160, 634)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(350, 74)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNCERRAR.Location = New System.Drawing.Point(230, 28)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(103, 32)
        Me.BTNCERRAR.TabIndex = 2
        Me.BTNCERRAR.Text = "Cerrar"
        Me.BTNCERRAR.UseVisualStyleBackColor = True
        '
        'BTNGRABAR
        '
        Me.BTNGRABAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNGRABAR.Location = New System.Drawing.Point(121, 28)
        Me.BTNGRABAR.Name = "BTNGRABAR"
        Me.BTNGRABAR.Size = New System.Drawing.Size(103, 32)
        Me.BTNGRABAR.TabIndex = 1
        Me.BTNGRABAR.Text = "Grabar"
        Me.BTNGRABAR.UseVisualStyleBackColor = True
        '
        'BTNUEVO
        '
        Me.BTNUEVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNUEVO.Location = New System.Drawing.Point(12, 28)
        Me.BTNUEVO.Name = "BTNUEVO"
        Me.BTNUEVO.Size = New System.Drawing.Size(103, 32)
        Me.BTNUEVO.TabIndex = 0
        Me.BTNUEVO.Text = "Nuevo"
        Me.BTNUEVO.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVLISTA)
        Me.GroupBox1.Controls.Add(Me.CBOSEXO)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TXTEDAD)
        Me.GroupBox1.Controls.Add(Me.TXTNOM)
        Me.GroupBox1.Controls.Add(Me.TXTAPE)
        Me.GroupBox1.Controls.Add(Me.TXTCOD)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 477)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Cliente"
        '
        'DGVLISTA
        '
        Me.DGVLISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLISTA.Location = New System.Drawing.Point(11, 374)
        Me.DGVLISTA.Name = "DGVLISTA"
        Me.DGVLISTA.Size = New System.Drawing.Size(520, 87)
        Me.DGVLISTA.TabIndex = 12
        '
        'CBOSEXO
        '
        Me.CBOSEXO.FormattingEnabled = True
        Me.CBOSEXO.Items.AddRange(New Object() {"Seleccione", "Femenino", "Masculino"})
        Me.CBOSEXO.Location = New System.Drawing.Point(97, 151)
        Me.CBOSEXO.Name = "CBOSEXO"
        Me.CBOSEXO.Size = New System.Drawing.Size(121, 27)
        Me.CBOSEXO.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.CBOTAMAÑO)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CBOCOMBO)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CBOTIPO)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pizza"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(333, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'CBOTAMAÑO
        '
        Me.CBOTAMAÑO.FormattingEnabled = True
        Me.CBOTAMAÑO.Items.AddRange(New Object() {"Seleccione", "Familiar", "Extra Grande", "Pequeña", "Economica"})
        Me.CBOTAMAÑO.Location = New System.Drawing.Point(138, 115)
        Me.CBOTAMAÑO.Name = "CBOTAMAÑO"
        Me.CBOTAMAÑO.Size = New System.Drawing.Size(180, 27)
        Me.CBOTAMAÑO.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tamaño de Pizza:"
        '
        'CBOCOMBO
        '
        Me.CBOCOMBO.FormattingEnabled = True
        Me.CBOCOMBO.Items.AddRange(New Object() {"Seleccione", "Alitas de Pollo", "Twister mexicano", "Tacos"})
        Me.CBOCOMBO.Location = New System.Drawing.Point(138, 82)
        Me.CBOCOMBO.Name = "CBOCOMBO"
        Me.CBOCOMBO.Size = New System.Drawing.Size(180, 27)
        Me.CBOCOMBO.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Combos Extras:"
        '
        'CBOTIPO
        '
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Items.AddRange(New Object() {"Seleccione", "Pizza Italiana ", "Pizza Hawaiana", "Pizza BBQ", "Pizza Pepperoni", "Barbaco", "Margarita", "Pizza Vegetariana", "Pecado Carnal", "Pizza Americana", "Deluxe Mexicana", "Carbonara", "Deluxe", "Tony Pepperoni", "Campiña", "Cheese", "Hawaiana Plus", "Tropical"})
        Me.CBOTIPO.Location = New System.Drawing.Point(138, 49)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(180, 27)
        Me.CBOTIPO.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(31, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo de Pizza:"
        '
        'TXTEDAD
        '
        Me.TXTEDAD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTEDAD.Location = New System.Drawing.Point(97, 119)
        Me.TXTEDAD.Name = "TXTEDAD"
        Me.TXTEDAD.Size = New System.Drawing.Size(100, 26)
        Me.TXTEDAD.TabIndex = 10
        '
        'TXTNOM
        '
        Me.TXTNOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTNOM.Location = New System.Drawing.Point(97, 89)
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(194, 26)
        Me.TXTNOM.TabIndex = 9
        '
        'TXTAPE
        '
        Me.TXTAPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTAPE.Location = New System.Drawing.Point(97, 57)
        Me.TXTAPE.Name = "TXTAPE"
        Me.TXTAPE.Size = New System.Drawing.Size(194, 26)
        Me.TXTAPE.TabIndex = 8
        '
        'TXTCOD
        '
        Me.TXTCOD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTCOD.Location = New System.Drawing.Point(97, 25)
        Me.TXTCOD.Name = "TXTCOD"
        Me.TXTCOD.Size = New System.Drawing.Size(100, 26)
        Me.TXTCOD.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXTNOMVEND)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(327, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 145)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encargado"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(69, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 26)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Fecha:"
        '
        'TXTNOMVEND
        '
        Me.TXTNOMVEND.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTNOMVEND.Location = New System.Drawing.Point(6, 62)
        Me.TXTNOMVEND.Name = "TXTNOMVEND"
        Me.TXTNOMVEND.Size = New System.Drawing.Size(183, 26)
        Me.TXTNOMVEND.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nombre del vendedor :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(33, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aplica03.My.Resources.Resources.FB_IMG_1474322786448
        Me.PictureBox2.Location = New System.Drawing.Point(395, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 710)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVLISTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNGRABAR As System.Windows.Forms.Button
    Friend WithEvents BTNUEVO As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVLISTA As System.Windows.Forms.DataGridView
    Friend WithEvents CBOSEXO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CBOTAMAÑO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBOCOMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBOTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTEDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPE As System.Windows.Forms.TextBox
    Friend WithEvents TXTCOD As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMVEND As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
