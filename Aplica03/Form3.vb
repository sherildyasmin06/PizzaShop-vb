Public Class Form3
    Dim objingreso As New ClassLibrary1.Class1
#Region "Procedimientos"
    Public Sub listado_datos()
        DGVLISTA.DataSource = objingreso.listado_clientes.Tables("listara")
    End Sub

    Public Sub ingreso_datos()
        If (objingreso.busqueda_codigo((TXTCOD.Text).ToUpper).Tables("buscodigo").Rows.Count - 1 >= 0) Then
            MessageBox.Show("Codigo del Cliente Ya Registrado", "Pulse clic en aceptar")
            Call limpiar()
        Else
            objingreso.ingreso_clientes((TXTCOD.Text).ToUpper, (TXTAPE.Text).ToUpper, (TXTNOM.Text).ToUpper, Integer.Parse(TXTEDAD.Text), (CBOSEXO.SelectedItem), (TXTNOMVEND.Text).ToUpper, (CBOTIPO.SelectedItem), (CBOCOMBO.SelectedItem), (CBOTAMAÑO.SelectedItem), (DateTimePicker1.Text))
            Call listado_datos()
            MessageBox.Show("Cliente Registrado", "Pulse clic en aceptar")
        End If
    End Sub
    Public Sub limpiar()
        TXTCOD.Text = ""
        TXTAPE.Text = ""
        TXTNOM.Text = ""
        TXTEDAD.Text = ""
        CBOSEXO.SelectedIndex = 0
        TXTNOMVEND.Text = ""
        DateTimePicker1.Text = Today
        CBOTIPO.SelectedIndex = 0
        CBOCOMBO.SelectedIndex = 0
        CBOTAMAÑO.SelectedIndex = 0
        TXTCOD.Focus()
    End Sub

#End Region
    Private Sub Frmingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call listado_datos()
        CBOSEXO.SelectedIndex = 0
        CBOCOMBO.SelectedItem = 0
        CBOTAMAÑO.SelectedItem = 0
    End Sub

    Private Sub BTNGRABAR_Click(sender As Object, e As EventArgs) Handles BTNGRABAR.Click
        Call ingreso_datos()
    End Sub

    Private Sub BTNCERRAR_Click(sender As Object, e As EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNUEVO_Click(sender As Object, e As EventArgs) Handles BTNUEVO.Click
        Call limpiar()
    End Sub

    Private Sub TXTCOD_GotFocus(sender As Object, e As EventArgs) Handles TXTCOD.GotFocus
        TXTCOD.BackColor = Color.Black
        TXTCOD.ForeColor = Color.Yellow
    End Sub

    Private Sub TXTCOD_LostFocus(sender As Object, e As EventArgs) Handles TXTCOD.LostFocus

        TXTCOD.BackColor = Color.White
        TXTCOD.ForeColor = Color.Black
    End Sub

    Private Sub TXTAPE_GotFocus(sender As Object, e As EventArgs) Handles TXTAPE.GotFocus
        TXTAPE.BackColor = Color.Black
        TXTAPE.ForeColor = Color.Yellow
    End Sub

    Private Sub TXTAPE_LostFocus(sender As Object, e As EventArgs) Handles TXTAPE.LostFocus
        TXTAPE.BackColor = Color.White
        TXTAPE.ForeColor = Color.Black
    End Sub

    Private Sub TXTNOM_GotFocus(sender As Object, e As EventArgs) Handles TXTNOM.GotFocus
        TXTNOM.BackColor = Color.Black
        TXTNOM.ForeColor = Color.Yellow
    End Sub

    Private Sub TXTNOM_LostFocus(sender As Object, e As EventArgs) Handles TXTNOM.LostFocus
        TXTNOM.BackColor = Color.White
        TXTNOM.ForeColor = Color.Black
    End Sub

    Private Sub CBOSEXO_GotFocus(sender As Object, e As EventArgs) Handles CBOSEXO.GotFocus
        CBOSEXO.BackColor = Color.Black
        CBOSEXO.ForeColor = Color.Yellow
    End Sub

    Private Sub CBOSEXO_LostFocus(sender As Object, e As EventArgs) Handles CBOSEXO.LostFocus
        CBOSEXO.BackColor = Color.White
        CBOSEXO.ForeColor = Color.Black
    End Sub

    Private Sub TXTEDAD_GotFocus(sender As Object, e As EventArgs) Handles TXTEDAD.GotFocus
        TXTEDAD.BackColor = Color.Black
        TXTEDAD.ForeColor = Color.Yellow
    End Sub

    Private Sub TXTEDAD_LostFocus(sender As Object, e As EventArgs) Handles TXTEDAD.LostFocus
        TXTEDAD.BackColor = Color.White
        TXTEDAD.ForeColor = Color.Black
    End Sub

    Private Sub TXTNOMVEND_GotFocus(sender As Object, e As EventArgs) Handles TXTNOMVEND.GotFocus
        TXTNOMVEND.BackColor = Color.Black
        TXTNOMVEND.ForeColor = Color.Yellow
    End Sub

    Private Sub TXTNOMVEND_LostFocus(sender As Object, e As EventArgs) Handles TXTNOMVEND.LostFocus
        TXTNOMVEND.BackColor = Color.White
        TXTNOMVEND.ForeColor = Color.Black
    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.GotFocus
        DateTimePicker1.BackColor = Color.Black
        DateTimePicker1.ForeColor = Color.Yellow
    End Sub

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        DateTimePicker1.BackColor = Color.White
        DateTimePicker1.ForeColor = Color.Black
    End Sub

    Private Sub CBOTIPO_GotFocus(sender As Object, e As EventArgs) Handles CBOTIPO.GotFocus
        CBOTIPO.BackColor = Color.Black
        CBOTIPO.ForeColor = Color.Yellow
    End Sub

    Private Sub CBOTIPO_LostFocus(sender As Object, e As EventArgs) Handles CBOTIPO.LostFocus
        CBOTIPO.BackColor = Color.White
        CBOTIPO.ForeColor = Color.Black
    End Sub

    Private Sub CBOCOMBO_GotFocus(sender As Object, e As EventArgs) Handles CBOCOMBO.GotFocus
        CBOCOMBO.BackColor = Color.Black
        CBOCOMBO.ForeColor = Color.Yellow
    End Sub

    Private Sub CBOCOMBO_LostFocus(sender As Object, e As EventArgs) Handles CBOCOMBO.LostFocus
        CBOCOMBO.BackColor = Color.White
        CBOCOMBO.ForeColor = Color.Black
    End Sub

    Private Sub CBOTAMAÑO_GotFocus(sender As Object, e As EventArgs) Handles CBOTAMAÑO.GotFocus
        CBOTAMAÑO.BackColor = Color.Black
        CBOTAMAÑO.ForeColor = Color.Yellow
    End Sub

    Private Sub CBOTAMAÑO_LostFocus(sender As Object, e As EventArgs) Handles CBOTAMAÑO.LostFocus
        CBOTAMAÑO.BackColor = Color.White
        CBOTAMAÑO.ForeColor = Color.Black
    End Sub
End Class