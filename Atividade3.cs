/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem 
crescente.

Nome: Amanda Pegoraro
*/

using System.Runtime.InteropServices;

public static class Atividade3
{
    public static void Executar ()
    {
       int N1;
       int N2;
       int N3;
       int Maior = 0;
       int intermediario = 0;
       int menor = 0;
    
       Console.Write("Digite o primeiro numero: ");
       N1 = int.Parse(Console.ReadLine()!);

       Console.Write("Digite o segundo numero: ");
       N2 = int.Parse(Console.ReadLine()!);

       Console.Write("Digite o terceiro numero: ");
       N3 = int.Parse(Console.ReadLine()!);

       if( N1 > N2 && N1 > N3)
        {
         Maior= N1;

           if( (N2 > N3))
            {
              intermediario= N2;
              menor= N3;  
            }
            else
            {
              intermediario= N3;
              menor= N2;
              
            }
        }
        if( N2 > N1 && N2 > N3)
        {
         Maior= N2;

           if( (N1 > N3))
            {
              intermediario= N1;
              menor= N3;  
            }
            else
            {
              intermediario= N3;
              menor= N1;
              
            }
        }
        if( N3 > N1 && N3 > N2)
        {
         Maior= N3;

           if( (N1 > N2))
            {
              intermediario= N1;
              menor= N2;  
            }
            else
            {
              intermediario= N2;
              menor= N1;
              
            }
        }

        Console.WriteLine($"{menor}, {intermediario}, {Maior}");
  

    }

}