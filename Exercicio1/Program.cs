Console.ReadLine();

Circulo c1 = new Circulo(10);
Circulo c2 = new Circulo(15);
Circulo c3 = new Circulo(20);

Quadrado q1 = new Quadrado(10);
Quadrado q2 = new Quadrado(15);
Quadrado q3 = new Quadrado(20);

Console.WriteLine("--------------------");
Console.WriteLine("\tMenu");
Console.WriteLine("--------------------");

Console.WriteLine($"A área do c1 é: {c1.GetArea():F2}");
Console.WriteLine($"A circunferência do c1 é: {c1.GetCircunferencia():F2}");

Console.WriteLine($"A área do c2 é: {c2.GetArea():F2}");
Console.WriteLine($"A circunferência do c2 é: {c2.GetCircunferencia():F2}");

Console.WriteLine($"A área do c3 é: {c3.GetArea():F2}");
Console.WriteLine($"A circunferência do c3 é: {c3.GetCircunferencia():F2}");

Console.WriteLine($"\nA área do q1 é: {q1.GetArea():F2}");
Console.WriteLine($"O perímetro do q1 é: {q1.GetPerimetro():F2}");

Console.WriteLine($"A área do q2 é: {q2.GetArea():F2}");
Console.WriteLine($"O perímetro do q2 é: {q2.GetPerimetro():F2}");

Console.WriteLine($"A área do q3 é: {q3.GetArea():F2}");
Console.WriteLine($"O perímetro do q3 é: {q3.GetPerimetro():F2}");