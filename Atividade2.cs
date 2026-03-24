/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.

Nome: Amanda Pegoraro
*/

public static class Atividade2
{
    public static void Executar ()
    {
       string letra;
      
      
       Console.WriteLine("Digite a letra para ser verificada: ");
       letra = Console.ReadLine()!.ToLower();

       if(letra == "a" || letra == "i" || letra == "o" || letra == "u")
        {
            Console.WriteLine($"A letra {letra} é uma vogal");
        }
        else
        {
            Console.WriteLine($"A letra {letra} é uma consoante");
        }

       
    }
}
