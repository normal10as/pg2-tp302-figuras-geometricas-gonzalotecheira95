Public Class Triangulo
    Inherits Figuras

    Private _base As UShort
    Private _altura As UShort

    Public Sub New(nombre As String)
        MyBase.New(nombre)
    End Sub

    Public Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property
    Public Property Altura As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single
        Return Base * Altura / 2
    End Function
End Class