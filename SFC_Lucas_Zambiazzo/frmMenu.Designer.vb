<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarEnCascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUsuarioStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFechaHoraStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.VentanasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.MenuToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClientesToolStripMenuItem, Me.AltaMedicamentosToolStripMenuItem, Me.AltaUsuariosToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ListadoClientesToolStripMenuItem, Me.ListadoMedicamentosToolStripMenuItem, Me.ListadoUsuariosToolStripMenuItem, Me.ListadoVentasToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AltaClientesToolStripMenuItem
        '
        Me.AltaClientesToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.agregar_usuario
        Me.AltaClientesToolStripMenuItem.Name = "AltaClientesToolStripMenuItem"
        Me.AltaClientesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AltaClientesToolStripMenuItem.Text = "Alta Clientes"
        '
        'AltaMedicamentosToolStripMenuItem
        '
        Me.AltaMedicamentosToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.medicamento
        Me.AltaMedicamentosToolStripMenuItem.Name = "AltaMedicamentosToolStripMenuItem"
        Me.AltaMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AltaMedicamentosToolStripMenuItem.Text = "Alta Medicamentos"
        '
        'AltaUsuariosToolStripMenuItem
        '
        Me.AltaUsuariosToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.agregar_usuario
        Me.AltaUsuariosToolStripMenuItem.Name = "AltaUsuariosToolStripMenuItem"
        Me.AltaUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AltaUsuariosToolStripMenuItem.Text = "Alta Usuarios"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.carro
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.proveedor
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ListadoClientesToolStripMenuItem
        '
        Me.ListadoClientesToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.cliente
        Me.ListadoClientesToolStripMenuItem.Name = "ListadoClientesToolStripMenuItem"
        Me.ListadoClientesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListadoClientesToolStripMenuItem.Text = "Listado Clientes"
        '
        'ListadoMedicamentosToolStripMenuItem
        '
        Me.ListadoMedicamentosToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.lista_de_verificacion
        Me.ListadoMedicamentosToolStripMenuItem.Name = "ListadoMedicamentosToolStripMenuItem"
        Me.ListadoMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListadoMedicamentosToolStripMenuItem.Text = "Listado Medicamentos"
        '
        'ListadoUsuariosToolStripMenuItem
        '
        Me.ListadoUsuariosToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.cliente
        Me.ListadoUsuariosToolStripMenuItem.Name = "ListadoUsuariosToolStripMenuItem"
        Me.ListadoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListadoUsuariosToolStripMenuItem.Text = "Listado Usuarios"
        '
        'ListadoVentasToolStripMenuItem
        '
        Me.ListadoVentasToolStripMenuItem.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.plan_de_negocios
        Me.ListadoVentasToolStripMenuItem.Name = "ListadoVentasToolStripMenuItem"
        Me.ListadoVentasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListadoVentasToolStripMenuItem.Text = "Listado Ventas"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarEnCascadaToolStripMenuItem, Me.MosaicoHorizontalToolStripMenuItem, Me.MosaicoVerticalToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'OrganizarEnCascadaToolStripMenuItem
        '
        Me.OrganizarEnCascadaToolStripMenuItem.Name = "OrganizarEnCascadaToolStripMenuItem"
        Me.OrganizarEnCascadaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.OrganizarEnCascadaToolStripMenuItem.Text = "Organizar en Cascada"
        '
        'MosaicoHorizontalToolStripMenuItem
        '
        Me.MosaicoHorizontalToolStripMenuItem.Name = "MosaicoHorizontalToolStripMenuItem"
        Me.MosaicoHorizontalToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MosaicoHorizontalToolStripMenuItem.Text = "Mosaico Horizontal"
        '
        'MosaicoVerticalToolStripMenuItem
        '
        Me.MosaicoVerticalToolStripMenuItem.Name = "MosaicoVerticalToolStripMenuItem"
        Me.MosaicoVerticalToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuarioStatus, Me.lblFechaHoraStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUsuarioStatus
        '
        Me.lblUsuarioStatus.Name = "lblUsuarioStatus"
        Me.lblUsuarioStatus.Size = New System.Drawing.Size(120, 17)
        Me.lblUsuarioStatus.Text = "ToolStripStatusLabel1"
        '
        'lblFechaHoraStatus
        '
        Me.lblFechaHoraStatus.Name = "lblFechaHoraStatus"
        Me.lblFechaHoraStatus.Size = New System.Drawing.Size(120, 17)
        Me.lblFechaHoraStatus.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Sistema de Farmacia - Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUsuarioStatus As ToolStripStatusLabel
    Friend WithEvents lblFechaHoraStatus As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarEnCascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoVentasToolStripMenuItem As ToolStripMenuItem
End Class
