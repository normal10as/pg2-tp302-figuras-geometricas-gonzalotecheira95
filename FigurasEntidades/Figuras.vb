Public Class Figuras
    Private _nombre As String
    Private _calculararea As Single

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overridable Function CalcularArea() As Single
        Return _calculararea
    End Function
End Class

