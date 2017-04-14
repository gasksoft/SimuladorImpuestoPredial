Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashBoardFrm
    Inherits MetroForm

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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SetupMl = New MetroFramework.Controls.MetroLink()
        Me.SalirMl = New MetroFramework.Controls.MetroLink()
        Me.AcercaDeMl = New MetroFramework.Controls.MetroLink()
        Me.MetroLink4 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.SimularHrMl = New MetroFramework.Controls.MetroLink()
        Me.NuevoHrMl = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 131)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(567, 563)
        Me.MetroTabControl1.TabIndex = 9
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(559, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contribuyente"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(559, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Predios"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(559, 521)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Determinación del Impuesto"
        '
        'SetupMl
        '
        Me.SetupMl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SetupMl.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.configurar
        Me.SetupMl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SetupMl.ImageSize = 32
        Me.SetupMl.Location = New System.Drawing.Point(400, 63)
        Me.SetupMl.Name = "SetupMl"
        Me.SetupMl.Size = New System.Drawing.Size(66, 48)
        Me.SetupMl.TabIndex = 8
        Me.SetupMl.Text = "Con&figurar"
        Me.SetupMl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SetupMl.UseSelectable = True
        '
        'SalirMl
        '
        Me.SalirMl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirMl.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.cerrar
        Me.SalirMl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SalirMl.ImageSize = 32
        Me.SalirMl.Location = New System.Drawing.Point(534, 63)
        Me.SalirMl.Name = "SalirMl"
        Me.SalirMl.Size = New System.Drawing.Size(56, 48)
        Me.SalirMl.TabIndex = 7
        Me.SalirMl.Text = "Sali&r"
        Me.SalirMl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalirMl.UseSelectable = True
        '
        'AcercaDeMl
        '
        Me.AcercaDeMl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AcercaDeMl.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.ayuda
        Me.AcercaDeMl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AcercaDeMl.ImageSize = 32
        Me.AcercaDeMl.Location = New System.Drawing.Point(472, 63)
        Me.AcercaDeMl.Name = "AcercaDeMl"
        Me.AcercaDeMl.Size = New System.Drawing.Size(56, 48)
        Me.AcercaDeMl.TabIndex = 6
        Me.AcercaDeMl.Text = "Acerca &de..."
        Me.AcercaDeMl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AcercaDeMl.UseSelectable = True
        '
        'MetroLink4
        '
        Me.MetroLink4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink4.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.imprimir
        Me.MetroLink4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLink4.ImageSize = 32
        Me.MetroLink4.Location = New System.Drawing.Point(317, 63)
        Me.MetroLink4.Name = "MetroLink4"
        Me.MetroLink4.Size = New System.Drawing.Size(56, 48)
        Me.MetroLink4.TabIndex = 5
        Me.MetroLink4.Text = "&Imprimir"
        Me.MetroLink4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroLink4.UseSelectable = True
        '
        'MetroLink3
        '
        Me.MetroLink3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink3.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.guardarComo
        Me.MetroLink3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLink3.ImageSize = 32
        Me.MetroLink3.Location = New System.Drawing.Point(261, 63)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(56, 62)
        Me.MetroLink3.TabIndex = 4
        Me.MetroLink3.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Como"
        Me.MetroLink3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroLink3.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.guardar
        Me.MetroLink2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLink2.ImageSize = 32
        Me.MetroLink2.Location = New System.Drawing.Point(205, 63)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(56, 48)
        Me.MetroLink2.TabIndex = 3
        Me.MetroLink2.Text = "&Guardar"
        Me.MetroLink2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroLink2.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.abrir
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLink1.ImageSize = 32
        Me.MetroLink1.Location = New System.Drawing.Point(149, 63)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(56, 48)
        Me.MetroLink1.TabIndex = 2
        Me.MetroLink1.Text = "&Abrir"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroLink1.UseSelectable = True
        '
        'SimularHrMl
        '
        Me.SimularHrMl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimularHrMl.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.monedas
        Me.SimularHrMl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimularHrMl.ImageSize = 32
        Me.SimularHrMl.Location = New System.Drawing.Point(23, 63)
        Me.SimularHrMl.Name = "SimularHrMl"
        Me.SimularHrMl.Size = New System.Drawing.Size(56, 48)
        Me.SimularHrMl.TabIndex = 1
        Me.SimularHrMl.Text = "&Simular"
        Me.SimularHrMl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimularHrMl.UseSelectable = True
        '
        'NuevoHrMl
        '
        Me.NuevoHrMl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoHrMl.Image = Global.SimuImpPred.Gui.WinForm.My.Resources.Resources.newHr
        Me.NuevoHrMl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NuevoHrMl.ImageSize = 32
        Me.NuevoHrMl.Location = New System.Drawing.Point(93, 63)
        Me.NuevoHrMl.Name = "NuevoHrMl"
        Me.NuevoHrMl.Size = New System.Drawing.Size(56, 48)
        Me.NuevoHrMl.TabIndex = 0
        Me.NuevoHrMl.Text = "&Nuevo"
        Me.NuevoHrMl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NuevoHrMl.UseSelectable = True
        '
        'DashBoardFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 717)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.SetupMl)
        Me.Controls.Add(Me.SalirMl)
        Me.Controls.Add(Me.AcercaDeMl)
        Me.Controls.Add(Me.MetroLink4)
        Me.Controls.Add(Me.MetroLink3)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.SimularHrMl)
        Me.Controls.Add(Me.NuevoHrMl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DashBoardFrm"
        Me.Resizable = False
        Me.Text = "Impuesto Predial 2017"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NuevoHrMl As MetroFramework.Controls.MetroLink
    Friend WithEvents SimularHrMl As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink4 As MetroFramework.Controls.MetroLink
    Friend WithEvents AcercaDeMl As MetroFramework.Controls.MetroLink
    Friend WithEvents SalirMl As MetroFramework.Controls.MetroLink
    Friend WithEvents SetupMl As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
