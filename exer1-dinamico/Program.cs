int idade1, idade2;
Console.WriteLine("Digite uma idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outra idade: ");
idade2 = int.Parse(Console.ReadLine());
float media = (idade1 + idade2) / 2;

Console.WriteLine($"Média:{media}");
