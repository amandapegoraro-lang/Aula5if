/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. 
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, 
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, 
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.

Nome: Amanda Pegoraro
*/


public static class Atividade6
{

    public static void Executar()
    {

int a, b, c;

Console.Write("Digite o primeiro angulo: ");
a= int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo angulo: ");
b= int.Parse(Console.ReadLine()!);

Console.Write("Digite o terceiro angulo: ");
c= int.Parse(Console.ReadLine()!);

if (a + b + c != 180)
{
    Console.WriteLine("Nao forma um triangulo.");
}
else if (a == 90 || b == 90 || c ==90)
{
    Console.WriteLine("triangulo retangulo");
}
else if ( a > 90 || b > 90 || c > 90)
{
Console.WriteLine("Triangulo obtusango.");
}
else
{
    Console.WriteLine("triangulo acutango.");
}

}
}