/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime. 
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no 
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser 
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". 
Caso contrário, ela será classificada como "Inocente".

Aluno: Amanda 
*/

using System.Reflection;

public static class Atividade8
{
    public static void Executar()
    {
        int pontos = 0;
        string resp;

        Console.WriteLine("Telefone para a vtima? (s/n): ");
        resp = Console.ReadLine()!;
        if (resp =="s") pontos++;

        Console.WriteLine("Esteve no local do crime? (s/n): ");
        resp = Console.ReadLine()!;
        if (resp =="s") pontos++;

        Console.WriteLine("Mora perto da vtima? (s/n): ");
        resp = Console.ReadLine()!;
        if (resp =="s") pontos++;

        Console.WriteLine("Devia para a vtima? (s/n): ");
        resp = Console.ReadLine()!;
        if (resp =="s") pontos++;

        Console.WriteLine("ja trabalhou com a vtima? (s/n): ");
        resp = Console.ReadLine()!;
        if (resp =="s") pontos++;

        if (pontos == 2 )
        Console.WriteLine("Suspeita");
        else if (pontos == 3 || pontos == 4)
        Console.WriteLine("Cumplice");
        else if (pontos == 5)
        Console.WriteLine("assasino");
        else 
        Console.WriteLine("Inocente");
    

    }


}