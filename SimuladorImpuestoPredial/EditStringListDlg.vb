Public Class EditStringListDlg
    Public Property Valor As String
    Private _valores As List(Of Dato)

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Valor =
            String.Join("; ",
                        String.Join(";", _valores.Select(Function(x) x.Dato)).
                           Split((New String() {";", ",", " "}), StringSplitOptions.RemoveEmptyEntries)
                        )
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub EditStringListDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _valores = New List(Of Dato)(
            Valor.Split(New String() {";", " "}, StringSplitOptions.RemoveEmptyEntries).
                                        Select(Function(x) New Dato() With {.Dato = x})
            )
        DataGridView1.AutoGenerateColumns = True
        BindingSource1.DataSource = _valores
    End Sub

    Private Class Dato
        Private _dato As String

        Sub New()
            Dato = ""
        End Sub

        Property Dato As String
            Get
                Return _dato
            End Get
            Set
                _dato = LCase(Trim(Value))
            End Set
        End Property
    End Class
End Class
