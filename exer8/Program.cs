int a, b, total;

Console.WriteLine("Digite um valor: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor: ");
b = int.Parse(Console.ReadLine());

total = a - b;

Console.WriteLine($"Resultado: {total}");
if (total > 0)
{
    Console.WriteLine("TOTAL POSITIVO");
}
else
{
    Console.WriteLine("TOTAL NEGATIVO");
}