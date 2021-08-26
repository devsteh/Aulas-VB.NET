Public Class Form1
    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        'Criando variáveis que serão utilizadas no processo'
        Dim idade1, idade2 As Integer
        'Inserindo os valores nas variáveis, recuperando dos objetos TextBox'
        'Convertendo o conteúdo do TextBox que é uma string para números inteiros com a função Cint'
        idade1 = CInt(tbtIdade1.Text)
        idade2 = CInt(tbtIdade2.Text)

        'Comparando os valores'
        If idade1 > idade2 Then
            MessageBox.Show("A idade " & idade1 & " anos, é maior que " & idade2 & " anos")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade " & idade2 & " anos, é maior que " & idade1 & " anos")
        Else
            MessageBox.Show("A idade " & idade1 & " anos, é igual a idade que são " & idade2 & " anos")
        End If

        LimparCampos()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        tbtIdade1.Clear()
        tbtIdade2.Clear()
    End Sub
End Class
