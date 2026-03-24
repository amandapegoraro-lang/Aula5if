/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, 
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente 
(A, B, C, D ou E), conforme a seguinte tabela:
A  -   nota >= 8,5  e nota <= 10
B  -   nota >= 7    e nota < 8,5
C  -   nota >= 5    e nota < 7
D  -   nota >= 3    e nota < 5
E  -   nota < 3

Nome: Amanda Pegoraro
*/

using System.Collections.Concurrent;
using System.Net.Http.Headers;

public static class Atividade4

 {
    public static void Executar()
    {
        {
           double N1, N2, media;

           Console.WriteLine($"Digite a nota N1: ");
           N1= double.Parse(Console.ReadLine()!);

           Console.WriteLine($"Digite a nota N2: ");
           N2= double.Parse(Console.ReadLine()!);

           media= (N1 + N2) / 2;

           Console.WriteLine("media: " + media);

           if (media >= 8.5 && media <= 10)
            {
            Console.WriteLine("Conceito: A");
            }
            else if (media >=7)
            {
            Console.WriteLine("Conceito: B");
            }
            else if (media >=5)
            {
            Console.WriteLine("Conceito: C");
            }
            else if (media >=3)
            {
            Console.WriteLine("Conceito: D");
            }
            else
            {
            Console.WriteLine("Conceito: E");
            }


        } 

    }
        

    }
    
