int N1, N2;

Console.WriteLine("Digite o primeiro número");
N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
N2 = int.Parse(Console.ReadLine());

if(N1 % N2 == 0)
{
    Console.WriteLine("São múltiplos");
} else
{
    Console.WriteLine("Não são múltiplos");
}