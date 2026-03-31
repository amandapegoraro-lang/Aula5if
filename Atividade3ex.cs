public static class Atividade3ex
{
    public static void Executar()
    {

        int n1;
        int n2;
        int n3;
        int auxiliar;

        Console.Write("Digite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o primeiro numero: ");
        n2 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o primeiro numero: ");
        n3 = int.Parse(Console.ReadLine()!);

        if (n1 > n2)
        {
            auxiliar = n1;
            n1 = n2;
            n2 = auxiliar;
        }
        if (n1 > n3)
        {
            auxiliar = n1;
            n1 = n3;
            n3 = auxiliar;
        }

        if (n2 > n3)
        {
            auxiliar = n2;
            n2 = n3;
            n3 = auxiliar;
        }

        Console.WriteLine($"Ordem crescente: {n1}; {n2} e {n3}");
    }
}
