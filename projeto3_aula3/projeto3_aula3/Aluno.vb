Public Class Aluno
    'Comando que possibilita a classe aluno herdar as características da classe Pessoa'
    Inherits Pessoa
    Private rgm As String

    Public Sub New(nome As String, rgm As String)
        'Como a classe herda características da classe Pessoa é necessário informar na linha de baixo
        MyBase.New(nome)
        'MyBase informa que essa informação é da classe PAI'
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
