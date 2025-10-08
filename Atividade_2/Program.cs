int Numero;
Console.WriteLine("Digite um número");
Numero = int.Parse(Console.ReadLine());

if(Numero % 2 == 0)
{
    Console.WriteLine("O número é par");
} else
{
    Console.WriteLine("O número é ímpar");
}