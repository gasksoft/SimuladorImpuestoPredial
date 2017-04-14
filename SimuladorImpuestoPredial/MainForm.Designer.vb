<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.ParametrosCalculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParametrosCalculoBindingSource
        '
        Me.ParametrosCalculoBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.ParametrosCalculo)
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MainForm
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 640)
        Me.ControlBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.Text = "Impuesto Predial"
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ParametrosCalculoBindingSource As BindingSource
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class