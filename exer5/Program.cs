float C, F;
Console.WriteLine("Digite uma temperatura em Fahrenheit: ");
F = float.Parse(Console.ReadLine());
C = (F - 32) * 5 / 9;
Console.WriteLine($"Temperatura em Celsius {C}");
