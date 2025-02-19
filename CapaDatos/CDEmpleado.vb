
Imports Microsoft.Data.SqlClient
Imports CapaDatos
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports capaEntidad

Public Class CDEmpleado

    Private ReadOnly cadena As String = "Data Source=DESKTOP-JUKRMDJ\SQLEXPRESS;Initial Catalog=registoEmpleado;Integrated Security=True;Encrypt=False"


    Public Sub conn()
        Dim conexion As New SqlConnection(cadena)
        Try
            conexion.Open()
            MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
        conexion.Close()
    End Sub

    Public Sub insertar(ByVal empleado As CEEMpleado)
        Try
            Dim conexion As New SqlConnection(cadena)
            conexion.Open()
            Dim consultaSql As String = "Insert  Into empleado (nombre,apellido,foto) 
            Values  (@nombre,@apellido,@foto) "

            Dim commando As New SqlCommand(consultaSql, conexion)
            commando.Parameters.AddWithValue("@nombre", empleado.Nombre)
            commando.Parameters.AddWithValue("@apellido", empleado.Apellido)
            commando.Parameters.AddWithValue("@foto", empleado.Foto1)
            commando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Conexión finalizada")
        Catch ex As Exception
            MessageBox.Show("Error -->" + ex.Message)
        End Try
    End Sub


    Public Sub update(ByVal empleado As CEEMpleado)
        Try
            Dim conexion As New SqlConnection(cadena)
            conexion.Open()
            Dim consultaSql As String
            consultaSql = "UPDATE empleado " &
              "SET nombre = @nombre, apellido = @apellido, foto = @foto " &
              "WHERE id = @id"

            Dim commando As New SqlCommand(consultaSql, conexion)
            commando.Parameters.AddWithValue("@nombre", empleado.Nombre)
            commando.Parameters.AddWithValue("@apellido", empleado.Apellido)
            commando.Parameters.AddWithValue("@foto", empleado.Foto1)
            commando.Parameters.AddWithValue("@id", empleado.IdEmpleado)
            commando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Conexión finalizada")
        Catch ex As Exception
            MessageBox.Show("Error -->" + ex.Message)
        End Try
    End Sub

    Public Function listar() As DataSet
        Dim dataset As New DataSet()
        Dim consultaSql As String = "SELECT * FROM empleado"


        Try
            ' Usar "Using" para garantizar el cierre adecuado de la conexión
            Using conecion As New SqlConnection(cadena)
                conecion.Open()
                Using adapter As New SqlDataAdapter(consultaSql, conecion)
                    adapter.Fill(dataset, "empleados")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al listar los datos ---> " & ex.Message)
        End Try

        Return dataset
    End Function

End Class
