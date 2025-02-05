
Imports Microsoft.Data.SqlClient
Imports CapaDatos
Imports System.Data.SqlClient

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

    Public Sub prueba()
        MessageBox.Show("Ejecutando la prueba")
        conn()
    End Sub


End Class
