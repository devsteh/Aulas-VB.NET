Imports System

Module Program
    Sub Main(args As String())
        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do Funcionário: ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o salário atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: ")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("Novo salário do funcionário " & funcionario & " é de " & novosalario)
    End Sub
End Module
