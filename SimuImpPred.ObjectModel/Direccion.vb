Imports SimuImpPred.Common.Codificadores

<Serializable>
Public Class Direccion
    Public Property TipoHabilitacion As Integer = 18
    Public Property Habilitacion As String
    Public Property TipoVia As Integer = 1
    Public Property Via As String
    Public Property Numero As String
    Public Property Dpto As String
    Public Property Block As String
    Public Property Interior As String
    Public Property Mz As String
    Public Property Lote As String

    Public Overrides Function ToString() As String
        Dim strings As New List(Of String)
        If Trim(Via) <> "" Then
            strings.Add($"{TipoViaDic(TipoVia)} {Via}")
            If Trim(Numero) <> "" Then
                strings.Add($"Nro: {Numero}")
            End If
            If Trim(Dpto) <> "" Then
                strings.Add($"Dpto: {Dpto}")
            End If
            If Trim(Block) <> "" Then
                strings.Add($"Block: {Block}")
            End If
            If Trim(Interior) <> "" Then
                strings.Add($"Interior: {Interior}")
            End If
        End If
        If Trim(Mz) <> "" Then
            strings.Add($"Mz: {Mz}")
            If Trim(Lote) <> "" Then
                strings.Add($"Lt: {Lote}")
            End If
        End If
        If Trim(Habilitacion) <> "" Then
            strings.Add($"{TipoHabilitacionDic(TipoHabilitacion)} {Habilitacion}")
        End If
        Dim str = String.Join(" ", strings)
        If str <> "" Then
            Return str
        Else
            Return "Sin dirección"
        End If
    End Function
End Class