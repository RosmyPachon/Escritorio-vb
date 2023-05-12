<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        MenuStrip1 = New MenuStrip()
        AdministrarToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        RolesToolStripMenuItem = New ToolStripMenuItem()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        PermisosToolStripMenuItem = New ToolStripMenuItem()
        ParametrosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdministrarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdministrarToolStripMenuItem
        ' 
        AdministrarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UsuariosToolStripMenuItem, RolesToolStripMenuItem, AccionesToolStripMenuItem, PermisosToolStripMenuItem, ParametrosToolStripMenuItem, SalirToolStripMenuItem})
        AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        AdministrarToolStripMenuItem.Size = New Size(81, 20)
        AdministrarToolStripMenuItem.Text = "Administrar"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(134, 22)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' RolesToolStripMenuItem
        ' 
        RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        RolesToolStripMenuItem.Size = New Size(134, 22)
        RolesToolStripMenuItem.Text = "Roles"
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(134, 22)
        AccionesToolStripMenuItem.Text = "Acciones"
        ' 
        ' PermisosToolStripMenuItem
        ' 
        PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        PermisosToolStripMenuItem.Size = New Size(134, 22)
        PermisosToolStripMenuItem.Text = "Permisos"
        ' 
        ' ParametrosToolStripMenuItem
        ' 
        ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        ParametrosToolStripMenuItem.Size = New Size(134, 22)
        ParametrosToolStripMenuItem.Text = "Parametros"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(134, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' frm_principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frm_principal"
        Text = "frm_principal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
