<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrEmpleado
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
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        nudId = New NumericUpDown()
        pcFoto = New PictureBox()
        lnkFoto = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnNuevo = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        OpenFoto = New OpenFileDialog()
        dgvEmpleado = New DataGridView()
        CType(nudId, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmpleado, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(228, 79)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(200, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(228, 121)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(200, 23)
        txtApellido.TabIndex = 1
        ' 
        ' nudId
        ' 
        nudId.Location = New Point(228, 36)
        nudId.Name = "nudId"
        nudId.Size = New Size(120, 23)
        nudId.TabIndex = 2
        ' 
        ' pcFoto
        ' 
        pcFoto.BackColor = SystemColors.ActiveCaption
        pcFoto.Location = New Point(228, 178)
        pcFoto.Name = "pcFoto"
        pcFoto.Size = New Size(175, 108)
        pcFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pcFoto.TabIndex = 3
        pcFoto.TabStop = False
        ' 
        ' lnkFoto
        ' 
        lnkFoto.AutoSize = True
        lnkFoto.Location = New Point(285, 322)
        lnkFoto.Name = "lnkFoto"
        lnkFoto.Size = New Size(70, 15)
        lnkFoto.TabIndex = 4
        lnkFoto.TabStop = True
        lnkFoto.Text = "Seleccionar "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(146, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 5
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(146, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(146, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 15)
        Label3.TabIndex = 7
        Label3.Text = "Id"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(88, 380)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(273, 380)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Elimiar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(440, 380)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(88, 23)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' OpenFoto
        ' 
        OpenFoto.FileName = "OpenFileDialog1"
        ' 
        ' dgvEmpleado
        ' 
        dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmpleado.Location = New Point(583, 36)
        dgvEmpleado.Name = "dgvEmpleado"
        dgvEmpleado.Size = New Size(443, 367)
        dgvEmpleado.TabIndex = 11
        ' 
        ' FrEmpleado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 450)
        Controls.Add(dgvEmpleado)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lnkFoto)
        Controls.Add(pcFoto)
        Controls.Add(nudId)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Name = "FrEmpleado"
        Text = "FrEmpleado"
        CType(nudId, ComponentModel.ISupportInitialize).EndInit()
        CType(pcFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmpleado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents nudId As NumericUpDown
    Friend WithEvents pcFoto As PictureBox
    Friend WithEvents lnkFoto As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents OpenFoto As OpenFileDialog
    Friend WithEvents dgvEmpleado As DataGridView
End Class
