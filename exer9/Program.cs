int a, b, resto;
Console.WriteLine("Digite um valor para dividir: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um divisor: ");
b = int.Parse(Console.ReadLine());
if (b == 0)
{
    Console.WriteLine("Não é possível dividir por 0");
}
else
{
    resto = a % b;
    Console.WriteLine($"Resto da divisao: {resto}");
}