int FormaPag;
float Valor;

Console.WriteLine("Digite o valor do produto");
Valor = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é a forma de pagamento ? (1 - à vista, 2 - parcelado)");
FormaPag = int.Parse(Console.ReadLine());

if(FormaPag == 1)
{
    Console.WriteLine($"Você recebeu 10% de desconto, por isso você terá que pagar: {Valor - (Valor * 0.1)}");
} else if(FormaPag == 2)
{
    Console.WriteLine($"Você terá que pagar: {Valor}");
} else
{
    Console.WriteLine("Forma de pagamento inválida");
}