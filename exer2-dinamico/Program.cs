float cotacao, valor, valor_reais;
Console.WriteLine("Digite a cotação do Euro:");
cotacao = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantos euros deseja converter:");
valor = float.Parse(Console.ReadLine());

valor_reais = cotacao * valor;
Console.WriteLine($"Valor convertido para Reais: R${valor_reais}");