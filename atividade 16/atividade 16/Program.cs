int n1 = 0, n3 = 0, n4 = 0, i = 0;
Console.WriteLine("Digite um numero.");
n1 = int.Parse(Console.ReadLine()!);
i = n1-1;
n3 = n1;
if (n1 < 0)
{
    Console.WriteLine("Não existe");
}
if (n1 == 0)
{
    Console.WriteLine("1, por deifnição");
}
else if (n1 > 0)
{
    while (i > 0) {
        n3 = n3 * i;
        i--;
 
    }


        Console.WriteLine($" o fatorial de {n1} e {n3}");
}
    

