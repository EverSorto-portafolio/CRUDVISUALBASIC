Imports capaEntidad
Imports capaNegocio

Public Class FrEmpleado

    Dim Negocio As New CNEmpleado()
    Dim rutaImagen As String = String.Empty
    Private Sub FrEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        nudId.Value = 0
        pcFoto.Image = Nothing
        rutaImagen = String.Empty
    End Sub

    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFoto.LinkClicked
        OpenFoto.ShowDialog()

        If OpenFoto.FileName <> "" Then
            pcFoto.Image = Image.FromFile(OpenFoto.FileName)
            rutaImagen = OpenFoto.FileName
        End If

        OpenFoto.FileName = ""

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim empleado As New CEEMpleado()
        Dim validar As Boolean

        empleado.IdEmpleado = nudId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto1 = rutaImagen
        MessageBox.Show(rutaImagen)
        validar = Negocio.ValidadDatos(empleado)
        If validar = False Then
            Exit Sub
        ElseIf Negocio.ValidadDatos(empleado) = True Then
            Negocio.Insertar(empleado)
        End If


        If (empleado.IdEmpleado = 0) Then
            Negocio.Insertar(empleado)
        Else
            Negocio.actualizar(empleado)
        End If


        cargarDatos()





    End Sub

    Private Sub pcFoto_Click(sender As Object, e As EventArgs) Handles pcFoto.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick

    End Sub

    Private Sub cargarDatos()
        Dim ds As New DataSet
        ds = Negocio.lista()

        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            dgvEmpleado.DataSource = ds.Tables("empleados")
        Else
            MessageBox.Show("No hay datos para mostrar", "Mensaje")
        End If

    End Sub

    Private Sub dgvEmpleado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellDoubleClick
        txtNombre.Text = dgvEmpleado.CurrentRow.Cells("Nombre").Value
        txtApellido.Text = dgvEmpleado.CurrentRow.Cells("Apellido").Value
        nudId.Value = dgvEmpleado.CurrentRow.Cells("id").Value
        pcFoto.Image = Nothing
        If dgvEmpleado.CurrentRow.Cells("foto").Value <> "" Then
            If System.IO.File.Exists(dgvEmpleado.CurrentRow.Cells("foto").Value) Then
                pcFoto.Load(dgvEmpleado.CurrentRow.Cells("foto").Value)
            End If
        End If

    End Sub
End Class