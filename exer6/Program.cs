float H, peso_ideal;
Console.WriteLine("Digite uma altura");
H = float.Parse(Console.ReadLine());
peso_ideal = (72.7_2f * H) - 58;
Console.WriteLine($"O peso ideal é {peso_ideal}Kg");
