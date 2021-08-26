Public Class Form1
    Private Sub btnExibirAluno_Click(sender As Object, e As EventArgs) Handles btnExibirAluno.Click
        Dim obj_aluno As New Aluno("Fulano de Tal", "666666")
        txbNomeAluno.Text = obj_aluno.PNome
        txbRgmAluno.Text = obj_aluno.pRgm
    End Sub

    Private Sub btnExibirProf_Click(sender As Object, e As EventArgs) Handles btnExibirProf.Click
        Dim obj_aluno As New Professor("Fulano de Tal", "666666")
        txbTitulo.Text = obj_aluno.PNome
        txbRgmProf.Text = obj_aluno.pRgm
    End Sub
End Class
