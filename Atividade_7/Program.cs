float L1, L2, L3;

Console.WriteLine("Digite um valor para o primeiro lado do triângulo");
L1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor para o segundo lado do triângulo");
L2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor para o terceiro lado do triângulo");
L3 = float.Parse(Console.ReadLine());

if (L1 < (L2 + L3) && L2 < (L3 + L1) && L3 < (L1 + L2))
{
    if (L1 == L2 && L2 == L3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (L1 == L2 || L2 == L3 || L3 == L1)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
} else
{
    Console.WriteLine("Não é um triângulo ");
}
