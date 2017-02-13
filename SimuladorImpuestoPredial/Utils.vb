Module Utils
    Function GetAntiguedad(año As Integer, mes As Integer)
        Dim añoActual = Year(Now)
        Dim mesActual = Month(Now)
        If ParametrosCalculo.Año < añoActual Then
            añoActual = ParametrosCalculo.Año
            mesActual = 12
        End If
        Return DateDiff(DateInterval.Month, New Date(año, mes, 1), New DateTime(añoActual, mesActual, 1)) / 12
    End Function
End Module
