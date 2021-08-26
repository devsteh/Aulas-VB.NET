Public Class Professor
    Inherits Pessoa
    Private rgm As String

    Public Sub New(titulo As String, rgm As String)
        MyBase.New(titulo)
        Me.rgm = rgm
    End Sub

    Public Property pRgm As String
        Get
            Return rgm
        End Get
        Set(value As String)
            rgm = value
        End Set
    End Property
End Class
