float cotacao, valor_reais;
Console.WriteLine("Digite a cotação do Euro:");
cotacao = float.Parse(Console.ReadLine());

valor_reais = cotacao * 750;
Console.WriteLine($"Valor convertido para Reais: R${valor_reais}");