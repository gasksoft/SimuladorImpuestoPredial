Namespace GUI
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
            Me.MpContainer = New MetroFramework.Controls.MetroPanel()
            Me.MtParametrosCalculo = New MetroFramework.Controls.MetroTile()
            Me.ParametrosCalculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
            Me.MpParametros = New MetroFramework.Controls.MetroPanel()
            Me.MtParametrosCalculo2 = New MetroFramework.Controls.MetroTile()
            Me.FoMetroLabel = New MetroFramework.Controls.MetroLabel()
            Me.FoMetroLabelL = New MetroFramework.Controls.MetroLabel()
            Me.UitMetroLabelL = New MetroFramework.Controls.MetroLabel()
            Me.UitMetroLabel = New MetroFramework.Controls.MetroLabel()
            Me.MtPrintHr = New MetroFramework.Controls.MetroTile()
            Me.MtSaveAsHr = New MetroFramework.Controls.MetroTile()
            Me.MtNewHr = New MetroFramework.Controls.MetroTile()
            Me.MtSaveHr = New MetroFramework.Controls.MetroTile()
            Me.MtOpenHr = New MetroFramework.Controls.MetroTile()
            Me.MlGoBack = New MetroFramework.Controls.MetroLink()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
            Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
            CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MpParametros.SuspendLayout()
            Me.MtParametrosCalculo2.SuspendLayout()
            Me.MetroPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MpContainer
            '
            Me.MpContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MpContainer.HorizontalScrollbarBarColor = True
            Me.MpContainer.HorizontalScrollbarHighlightOnWheel = False
            Me.MpContainer.HorizontalScrollbarSize = 10
            Me.MpContainer.Location = New System.Drawing.Point(23, 130)
            Me.MpContainer.Name = "MpContainer"
            Me.MpContainer.Size = New System.Drawing.Size(994, 607)
            Me.MpContainer.TabIndex = 2
            Me.MpContainer.VerticalScrollbarBarColor = True
            Me.MpContainer.VerticalScrollbarHighlightOnWheel = False
            Me.MpContainer.VerticalScrollbarSize = 10
            '
            'MtParametrosCalculo
            '
            Me.MtParametrosCalculo.ActiveControl = Nothing
            Me.MtParametrosCalculo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtParametrosCalculo.DataBindings.Add(New System.Windows.Forms.Binding("TileCount", Me.ParametrosCalculoBindingSource, "Año", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
            Me.MtParametrosCalculo.Location = New System.Drawing.Point(3, 3)
            Me.MtParametrosCalculo.Name = "MtParametrosCalculo"
            Me.MtParametrosCalculo.Size = New System.Drawing.Size(127, 79)
            Me.MtParametrosCalculo.TabIndex = 3
            Me.MtParametrosCalculo.Text = "Año de Cálculo"
            Me.MtParametrosCalculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtParametrosCalculo.TileCount = 2010
            Me.MetroToolTip1.SetToolTip(Me.MtParametrosCalculo, "Año de Calculo. Click para cambiar")
            Me.MtParametrosCalculo.UseSelectable = True
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
            'MpParametros
            '
            Me.MpParametros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MpParametros.AutoSize = True
            Me.MpParametros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.MpParametros.Controls.Add(Me.MtParametrosCalculo2)
            Me.MpParametros.Controls.Add(Me.MtParametrosCalculo)
            Me.MpParametros.HorizontalScrollbarBarColor = True
            Me.MpParametros.HorizontalScrollbarHighlightOnWheel = False
            Me.MpParametros.HorizontalScrollbarSize = 10
            Me.MpParametros.Location = New System.Drawing.Point(720, 39)
            Me.MpParametros.Name = "MpParametros"
            Me.MpParametros.Size = New System.Drawing.Size(297, 85)
            Me.MpParametros.TabIndex = 4
            Me.MpParametros.VerticalScrollbarBarColor = True
            Me.MpParametros.VerticalScrollbarHighlightOnWheel = False
            Me.MpParametros.VerticalScrollbarSize = 10
            '
            'MtParametrosCalculo2
            '
            Me.MtParametrosCalculo2.ActiveControl = Nothing
            Me.MtParametrosCalculo2.Controls.Add(Me.FoMetroLabel)
            Me.MtParametrosCalculo2.Controls.Add(Me.FoMetroLabelL)
            Me.MtParametrosCalculo2.Controls.Add(Me.UitMetroLabelL)
            Me.MtParametrosCalculo2.Controls.Add(Me.UitMetroLabel)
            Me.MtParametrosCalculo2.Location = New System.Drawing.Point(136, 3)
            Me.MtParametrosCalculo2.Name = "MtParametrosCalculo2"
            Me.MtParametrosCalculo2.Size = New System.Drawing.Size(158, 79)
            Me.MtParametrosCalculo2.TabIndex = 4
            Me.MtParametrosCalculo2.Text = "Otros Parámetros"
            Me.MtParametrosCalculo2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtParametrosCalculo2.UseSelectable = True
            '
            'FoMetroLabel
            '
            Me.FoMetroLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosCalculoBindingSource, "Fo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
            Me.FoMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.FoMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.FoMetroLabel.Location = New System.Drawing.Point(71, 29)
            Me.FoMetroLabel.Name = "FoMetroLabel"
            Me.FoMetroLabel.Size = New System.Drawing.Size(81, 25)
            Me.FoMetroLabel.TabIndex = 6
            Me.FoMetroLabel.Text = "0.99"
            Me.FoMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'FoMetroLabelL
            '
            Me.FoMetroLabelL.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.FoMetroLabelL.Location = New System.Drawing.Point(3, 29)
            Me.FoMetroLabelL.Name = "FoMetroLabelL"
            Me.FoMetroLabelL.Size = New System.Drawing.Size(62, 25)
            Me.FoMetroLabelL.TabIndex = 8
            Me.FoMetroLabelL.Text = "FO: S/"
            Me.FoMetroLabelL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'UitMetroLabelL
            '
            Me.UitMetroLabelL.AutoSize = True
            Me.UitMetroLabelL.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.UitMetroLabelL.Location = New System.Drawing.Point(3, 4)
            Me.UitMetroLabelL.Name = "UitMetroLabelL"
            Me.UitMetroLabelL.Size = New System.Drawing.Size(62, 25)
            Me.UitMetroLabelL.TabIndex = 7
            Me.UitMetroLabelL.Text = "UIT: S/"
            Me.UitMetroLabelL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'UitMetroLabel
            '
            Me.UitMetroLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosCalculoBindingSource, "Uit", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
            Me.UitMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.UitMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.UitMetroLabel.Location = New System.Drawing.Point(71, 4)
            Me.UitMetroLabel.Name = "UitMetroLabel"
            Me.UitMetroLabel.Size = New System.Drawing.Size(81, 25)
            Me.UitMetroLabel.TabIndex = 5
            Me.UitMetroLabel.Text = "4,050.99"
            Me.UitMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'MtPrintHr
            '
            Me.MtPrintHr.ActiveControl = Nothing
            Me.MtPrintHr.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtPrintHr.Location = New System.Drawing.Point(399, 3)
            Me.MtPrintHr.Name = "MtPrintHr"
            Me.MtPrintHr.Size = New System.Drawing.Size(93, 61)
            Me.MtPrintHr.TabIndex = 9
            Me.MtPrintHr.Text = "&Imprimir"
            Me.MtPrintHr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtPrintHr.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.Print
            Me.MtPrintHr.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MtPrintHr.UseSelectable = True
            Me.MtPrintHr.UseTileImage = True
            '
            'MtSaveAsHr
            '
            Me.MtSaveAsHr.ActiveControl = Nothing
            Me.MtSaveAsHr.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtSaveAsHr.Location = New System.Drawing.Point(300, 3)
            Me.MtSaveAsHr.Name = "MtSaveAsHr"
            Me.MtSaveAsHr.Size = New System.Drawing.Size(93, 61)
            Me.MtSaveAsHr.TabIndex = 7
            Me.MtSaveAsHr.Text = "Guardar &Como"
            Me.MtSaveAsHr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtSaveAsHr.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.SaveAs
            Me.MtSaveAsHr.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MtSaveAsHr.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
            Me.MtSaveAsHr.UseSelectable = True
            Me.MtSaveAsHr.UseTileImage = True
            '
            'MtNewHr
            '
            Me.MtNewHr.ActiveControl = Nothing
            Me.MtNewHr.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtNewHr.Location = New System.Drawing.Point(3, 3)
            Me.MtNewHr.Name = "MtNewHr"
            Me.MtNewHr.PaintTileCount = False
            Me.MtNewHr.Size = New System.Drawing.Size(93, 61)
            Me.MtNewHr.TabIndex = 8
            Me.MtNewHr.Text = "&Nuevo"
            Me.MtNewHr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtNewHr.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.NewHr
            Me.MtNewHr.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MtNewHr.UseSelectable = True
            Me.MtNewHr.UseTileImage = True
            '
            'MtSaveHr
            '
            Me.MtSaveHr.ActiveControl = Nothing
            Me.MtSaveHr.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtSaveHr.Location = New System.Drawing.Point(201, 3)
            Me.MtSaveHr.Name = "MtSaveHr"
            Me.MtSaveHr.Size = New System.Drawing.Size(93, 61)
            Me.MtSaveHr.TabIndex = 6
            Me.MtSaveHr.Text = "&Guardar"
            Me.MtSaveHr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtSaveHr.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.Save
            Me.MtSaveHr.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MtSaveHr.UseSelectable = True
            Me.MtSaveHr.UseTileImage = True
            '
            'MtOpenHr
            '
            Me.MtOpenHr.ActiveControl = Nothing
            Me.MtOpenHr.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MtOpenHr.Location = New System.Drawing.Point(102, 3)
            Me.MtOpenHr.Name = "MtOpenHr"
            Me.MtOpenHr.Size = New System.Drawing.Size(93, 61)
            Me.MtOpenHr.TabIndex = 5
            Me.MtOpenHr.Text = "&Abrir"
            Me.MtOpenHr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MtOpenHr.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.Open
            Me.MtOpenHr.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MtOpenHr.UseSelectable = True
            Me.MtOpenHr.UseTileImage = True
            '
            'MlGoBack
            '
            Me.MlGoBack.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MlGoBack.FontSize = MetroFramework.MetroLinkSize.Tall
            Me.MlGoBack.FontWeight = MetroFramework.MetroLinkWeight.Regular
            Me.MlGoBack.Image = Global.SimuImpPred.Gui.My.Resources.Resources.Atras
            Me.MlGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.MlGoBack.ImageSize = 32
            Me.MlGoBack.Location = New System.Drawing.Point(23, 12)
            Me.MlGoBack.Name = "MlGoBack"
            Me.MlGoBack.Size = New System.Drawing.Size(34, 39)
            Me.MlGoBack.TabIndex = 0
            Me.MlGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MlGoBack.UseSelectable = True
            '
            'MetroLabel1
            '
            Me.MetroLabel1.AutoSize = True
            Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.MetroLabel1.Location = New System.Drawing.Point(65, 16)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(146, 25)
            Me.MetroLabel1.TabIndex = 10
            Me.MetroLabel1.Text = "Impuesto Predial"
            '
            'MetroPanel1
            '
            Me.MetroPanel1.AutoSize = True
            Me.MetroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.MetroPanel1.Controls.Add(Me.MetroTile1)
            Me.MetroPanel1.Controls.Add(Me.MtPrintHr)
            Me.MetroPanel1.Controls.Add(Me.MtNewHr)
            Me.MetroPanel1.Controls.Add(Me.MtSaveAsHr)
            Me.MetroPanel1.Controls.Add(Me.MtOpenHr)
            Me.MetroPanel1.Controls.Add(Me.MtSaveHr)
            Me.MetroPanel1.HorizontalScrollbarBarColor = True
            Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.HorizontalScrollbarSize = 10
            Me.MetroPanel1.Location = New System.Drawing.Point(23, 57)
            Me.MetroPanel1.Name = "MetroPanel1"
            Me.MetroPanel1.Size = New System.Drawing.Size(594, 67)
            Me.MetroPanel1.TabIndex = 11
            Me.MetroPanel1.VerticalScrollbarBarColor = True
            Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.VerticalScrollbarSize = 10
            '
            'MetroTile1
            '
            Me.MetroTile1.ActiveControl = Nothing
            Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MetroTile1.Location = New System.Drawing.Point(498, 3)
            Me.MetroTile1.Name = "MetroTile1"
            Me.MetroTile1.Size = New System.Drawing.Size(93, 61)
            Me.MetroTile1.TabIndex = 12
            Me.MetroTile1.Text = "Ace&rca de..."
            Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MetroTile1.TileImage = Global.SimuImpPred.Gui.My.Resources.Resources.Questions
            Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.MetroTile1.UseSelectable = True
            Me.MetroTile1.UseTileImage = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1040, 760)
            Me.Controls.Add(Me.MetroPanel1)
            Me.Controls.Add(Me.MetroLabel1)
            Me.Controls.Add(Me.MpContainer)
            Me.Controls.Add(Me.MlGoBack)
            Me.Controls.Add(Me.MpParametros)
            Me.DisplayHeader = False
            Me.MinimumSize = New System.Drawing.Size(1024, 760)
            Me.Name = "MainForm"
            Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
            Me.Text = "   Impuesto Predial"
            CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MpParametros.ResumeLayout(False)
            Me.MtParametrosCalculo2.ResumeLayout(False)
            Me.MtParametrosCalculo2.PerformLayout()
            Me.MetroPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MlGoBack As MetroFramework.Controls.MetroLink
        Friend WithEvents MpContainer As MetroFramework.Controls.MetroPanel
        Friend WithEvents ParametrosCalculoBindingSource As BindingSource
        Friend WithEvents MtParametrosCalculo As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
        Friend WithEvents MpParametros As MetroFramework.Controls.MetroPanel
        Friend WithEvents MtParametrosCalculo2 As MetroFramework.Controls.MetroTile
        Friend WithEvents UitMetroLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents FoMetroLabelL As MetroFramework.Controls.MetroLabel
        Friend WithEvents UitMetroLabelL As MetroFramework.Controls.MetroLabel
        Friend WithEvents FoMetroLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents MtOpenHr As MetroFramework.Controls.MetroTile
        Friend WithEvents MtSaveHr As MetroFramework.Controls.MetroTile
        Friend WithEvents MtSaveAsHr As MetroFramework.Controls.MetroTile
        Friend WithEvents MtNewHr As MetroFramework.Controls.MetroTile
        Friend WithEvents MtPrintHr As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
        Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    End Class
End Namespace