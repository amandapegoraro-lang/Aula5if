/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.

Nome: Amanda Pegoraro
*/

public static class Atividade9
{

   public static void Executar()
    {

        {
          Console.Write("Digite um numero;");
          int num= int.Parse(Console.ReadLine()!);

          if(num > 0)
          Console.WriteLine("Positivo");
          else if (num < 0)
          Console.WriteLine("Negativo");
          else
          Console.WriteLine("zero");


        } 

    }


}