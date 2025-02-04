
Imports capaEntidad
Public Class CNEmpleado

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

End Class
