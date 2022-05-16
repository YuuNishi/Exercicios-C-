double comissao, vendas;
Console.WriteLine("Digite o valor das vendas: ");
vendas = double.Parse(Console.ReadLine());
comissao = vendas * 0.05;

Console.WriteLine($"A comissão é de: R${comissao}");