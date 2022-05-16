
float C, F;
Console.WriteLine("Digite a temperatura em Celsius: ");
C = float.Parse(Console.ReadLine());
F = (9 * C + 160) / 5;
Console.WriteLine($"Temperatura em Fahrenheit: {F}");