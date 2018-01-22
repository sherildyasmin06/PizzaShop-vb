Imports System.Data
Imports System.Data.SqlClient
Public Class Class1
    Dim cn As New SqlConnection("server=(local);initial catalog=Pizzeria;user id=sa;pwd=soporte@123")
    Dim ds As DataSet
    Public Function listado_clientes() As DataSet
        Try
            ds = New DataSet
            Dim dalistado As New SqlDataAdapter
            dalistado.SelectCommand = New SqlCommand
            With dalistado.SelectCommand
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_LISTADO_CLIENTES"
            End With
            cn.Open()
            dalistado.Fill(ds, "listara")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function
    Public Sub ingreso_clientes(ByVal vcod As String, ByVal vape As String, ByVal vnom As String, ByVal vedad As Integer, ByVal vsexo As String, ByVal vnomv As String, ByVal vtipo As String, ByVal vcombo As String, ByVal vtam As String, ByVal vfecha As Date)
        Try
            Dim daingreso As New SqlDataAdapter
            daingreso.SelectCommand = New SqlCommand
            With daingreso.SelectCommand
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_INGRESO_CLIENTES"
                .Parameters.Add(New SqlParameter("@XCODCLI", SqlDbType.Char, 7, ParameterDirection.Input)).Value = vcod
                .Parameters.Add(New SqlParameter("@XAPECLI", SqlDbType.VarChar, 40, ParameterDirection.Input)).Value = vape
                .Parameters.Add(New SqlParameter("@XNOMCLI", SqlDbType.VarChar, 60, ParameterDirection.Input)).Value = vnom
                .Parameters.Add(New SqlParameter("@XEDADCLI", SqlDbType.Int, 4, ParameterDirection.Input)).Value = vedad
                .Parameters.Add(New SqlParameter("@SEXO_CLI", SqlDbType.Char, 1, ParameterDirection.Input)).Value = vsexo
                .Parameters.Add(New SqlParameter("@NOM_VEND", SqlDbType.VarChar, 40, ParameterDirection.Input)).Value = vnomv
                .Parameters.Add(New SqlParameter("@TIPO_PIZZA", SqlDbType.VarChar, 40, ParameterDirection.Input)).Value = vtipo
                .Parameters.Add(New SqlParameter("@COMBO_EXTRAS", SqlDbType.VarChar, 60, ParameterDirection.Input)).Value = vcombo
                .Parameters.Add(New SqlParameter("@TAMAÑO_PIZZA", SqlDbType.VarChar, 40, ParameterDirection.Input)).Value = vtam
                .Parameters.Add(New SqlParameter("@FECHA", SqlDbType.Date, ParameterDirection.Input)).Value = vfecha

            End With
            cn.Open()
            daingreso.SelectCommand.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Function busqueda_clientes(ByVal vcod As String) As DataSet
        Try
            ds = New DataSet
            Dim dabusqueda As New SqlDataAdapter
            dabusqueda.SelectCommand = New SqlCommand
            With dabusqueda.SelectCommand
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_BUSQUEDA_CLIENTES"
                .Parameters.Add(New SqlParameter("@XCODCLI", SqlDbType.Char, 7, ParameterDirection.Input)).Value = vcod

            End With
            cn.Open()
            dabusqueda.Fill(ds, "buscara")
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function busqueda_codigo(ByVal mcod As String) As DataSet
        Try
            ds = New DataSet
            Dim dabuscodigo As New SqlDataAdapter
            dabuscodigo.SelectCommand = New SqlCommand
            With dabuscodigo.SelectCommand
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_BUS_COD"
                .Parameters.Add(New SqlParameter("@XCODCLI", SqlDbType.Char, 7, ParameterDirection.Input)).Value = mcod
            End With
            cn.Open()
            dabuscodigo.Fill(ds, "buscodigo")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function
End Class
