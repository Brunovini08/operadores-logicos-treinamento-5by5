Console.WriteLine();
float N1, N2, N3;
Console.WriteLine("Digite o nota 1");
N1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2");
N2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3");
N3 = float.Parse(Console.ReadLine());

float Media = (N1 + N2 + N3) / 3;

if(Media >= 7)
{
    Console.WriteLine("Aprovado");
} else
{
    Console.WriteLine("Reprovado");
}


