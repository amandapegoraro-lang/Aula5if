/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.

Nome: Amanda Pegoraro
*/

public static class Atividade10
{
    public static void Executar()
    {
        Console.WriteLine("Digite um numero: ");
        int num = int.Parse(Console.ReadLine()!);

        if (num % 2 == 0)
        Console.WriteLine("Par");
        else
        Console.WriteLine("Impar");

    }

}