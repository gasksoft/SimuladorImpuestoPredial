Imports MetroFramework.Controls

Namespace GUI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ChangeYearDlg
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.OK_Button = New MetroFramework.Controls.MetroButton()
            Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
            Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(110, 227)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'OK_Button
            '
            Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.OK_Button.Location = New System.Drawing.Point(3, 3)
            Me.OK_Button.Name = "OK_Button"
            Me.OK_Button.Size = New System.Drawing.Size(67, 23)
            Me.OK_Button.TabIndex = 0
            Me.OK_Button.Text = "Aceptar"
            Me.OK_Button.UseSelectable = True
            '
            'Cancel_Button
            '
            Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
            Me.Cancel_Button.Name = "Cancel_Button"
            Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
            Me.Cancel_Button.TabIndex = 1
            Me.Cancel_Button.Text = "Cancelar"
            Me.Cancel_Button.UseSelectable = True
            '
            'MetroComboBox1
            '
            Me.MetroComboBox1.FormattingEnabled = True
            Me.MetroComboBox1.ItemHeight = 23
            Me.MetroComboBox1.Items.AddRange(New Object() {"2017", "2016", "2015"})
            Me.MetroComboBox1.Location = New System.Drawing.Point(162, 182)
            Me.MetroComboBox1.Name = "MetroComboBox1"
            Me.MetroComboBox1.PromptText = "Año"
            Me.MetroComboBox1.Size = New System.Drawing.Size(86, 29)
            Me.MetroComboBox1.TabIndex = 0
            Me.MetroComboBox1.UseSelectable = True
            '
            'MetroLabel1
            '
            Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(225, 119)
            Me.MetroLabel1.TabIndex = 2
            Me.MetroLabel1.Text = "Seleccione el año de cálculo que desea utilizar. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En base a este se utilizarán l" &
    "as tablas de valores unitarios, depreciación y obras complementarias respectivas" &
    " para la sierra"
            Me.MetroLabel1.WrapToLine = True
            '
            'ChangeYearDlg
            '
            Me.AcceptButton = Me.OK_Button
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.Cancel_Button
            Me.ClientSize = New System.Drawing.Size(268, 268)
            Me.Controls.Add(Me.MetroLabel1)
            Me.Controls.Add(Me.MetroComboBox1)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ChangeYearDlg"
            Me.Resizable = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Año"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents OK_Button As MetroButton
        Friend WithEvents Cancel_Button As MetroButton
        Friend WithEvents MetroComboBox1 As MetroComboBox
        Friend WithEvents MetroLabel1 As MetroLabel
    End Class
End Namespace