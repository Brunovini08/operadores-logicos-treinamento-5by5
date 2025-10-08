float H;
double Imc, P;
Console.WriteLine("Digite seu peso: ");
P = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
H = float.Parse(Console.ReadLine());

Imc = P / (H * H);

if(Imc < 18.5)
{
    Console.WriteLine($"Abaixo do peso");
} else if(Imc >= 18.5 && Imc <= 24.9)
{
    Console.WriteLine("Peso normal");
} else if(Imc >= 25 && Imc <= 29.9)
{
    Console.WriteLine("Sobrepeso");
} else if(Imc >= 30)  
{
    Console.WriteLine("Obesidade");
} else
{
    Console.WriteLine("Valor inválido");
}