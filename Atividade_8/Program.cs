float N1, N2, N3, P1, P2, P3, Media;

Console.WriteLine("Digite a primeira nota: ");
N1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da nota 1: ");
P1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
N2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da nota 2: ");
P2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
N3 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da nota 3: ");
P3 = float.Parse(Console.ReadLine());


Media = ((N1 * P1) + (N2 * P2) + (N3 * P3)) / (P1 + P2 + P3);

Console.WriteLine($"A média é: {Media}");

if(Media >= 9)
{
    Console.WriteLine("Sua nota é A");
} else if(Media >= 7 && Media < 9)
{
    Console.WriteLine("Sua nota é B");
} else if(Media >= 5 && Media < 7)
{
    Console.WriteLine("Sua nota é C");
} else if(Media < 5)
{
    Console.WriteLine("Sua nota é D");
} else
{
    Console.WriteLine("Valor incorreto");
}


Console.WriteLine("Você testou o app console de cálculo de nota");