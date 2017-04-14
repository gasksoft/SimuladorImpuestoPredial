Imports System.IO

Public NotInheritable Class AboutBox
    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim applicationTitle As String
        If My.Application.Info.Title <> "" Then
            applicationTitle = My.Application.Info.Title
        Else
            applicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Text = String.Format("Acerca de {0}", applicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class
