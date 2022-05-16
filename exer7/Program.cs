float nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite a n1: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a n2: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a n3: ");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a n4: ");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Media: {media}");
if (media >= 7)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
}

