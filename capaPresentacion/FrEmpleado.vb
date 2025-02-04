Imports capaEntidad
Imports capaNegocio

Public Class FrEmpleado

    Dim Negocio As New CNEmpleado()

    Private Sub FrEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        nudId.Value = 0
        pcFoto.Image = Nothing
    End Sub

    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFoto.LinkClicked
        OpenFoto.ShowDialog()

        If OpenFoto.FileName <> "" Then
            pcFoto.Image = Image.FromFile(OpenFoto.FileName)
        End If

        OpenFoto.FileName = ""

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim empleado As New CEEMpleado()
        Dim validar As Boolean

        empleado.IdEmpleado = nudId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto1 = pcFoto.ImageLocation

        validar = Negocio.ValidadDatos(empleado)
        If validar = False Then
            Exit Sub
        End If

        MessageBox.Show("Datos guardados correctamente")
    End Sub

    Private Sub pcFoto_Click(sender As Object, e As EventArgs) Handles pcFoto.Click

    End Sub
End Class