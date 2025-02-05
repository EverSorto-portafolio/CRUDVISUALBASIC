
Imports CapaDatos
Imports capaEntidad
Public Class CNEmpleado

    Dim conexion As New CDEmpleado()
    Public Function ValidadDatos(ByVal empleado As CEEMpleado) As Boolean
        Dim Resultado As Boolean = True

        If empleado.Nombre = "" Then
            Resultado = False
            MessageBox.Show("El campo Nombre es obligatorio", "Mensaje")
        End If

        If empleado.Apellido = "" Then
            Resultado = False
            MessageBox.Show("El campo apellido es obligatorio", "Mensaje")
        End If

        Return Resultado
    End Function


    Public Sub pruebaConexion()
        conexion.prueba()
    End Sub

End Class
