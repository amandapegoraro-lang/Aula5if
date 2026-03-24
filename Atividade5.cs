/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número 
de maçãs compradas, calcule e escreva o valor total da compra.

Nome: Amanda Pegoraro
*/

public static class Atividade5

{
    public static void Executar()
{
    {
        int quantidade;
        double preco, total;

        Console.WriteLine("Digite a quantidade de macas: ");
        quantidade = int.Parse(Console.ReadLine()!);

        if (quantidade< 12)
        preco= 0.30;

        else
        {
            preco= 0.25;
        }
        total = quantidade * preco;

        Console.WriteLine("total da compra: R$ " + total);

    }
}
}