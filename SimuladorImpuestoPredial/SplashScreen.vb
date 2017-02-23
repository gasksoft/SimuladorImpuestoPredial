Imports System.Deployment.Application
Imports System.IO

Public NotInheritable Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Dé formato a la información de versión usando el texto establecido en el control de versiones en tiempo de diseño como
        '  cadena de formato.  Esto le permite una localización efectiva si lo desea.
        '  Se pudo incluir la información de compilación y revisión usando el siguiente código y cambiando el 
        '  texto en tiempo de diseño del control de versiones a "Versión {0}.{1:00}.{2}.{3}" o algo parecido.  Consulte
        '  String.Format() en la Ayuda para obtener más información.
        '
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        If ApplicationDeployment.IsNetworkDeployed Then
            Version.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If
        Version.Text = My.Application.Info.Version.ToString _
        ' System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class
