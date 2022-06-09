Funcionario f1 = new Funcionario("123", "pedro", "caetano", 5);

Console.Clear();
Console.WriteLine(f1.ToString());

f1.AumentarSalario(50);
Console.WriteLine($"\nApós o aumento, o salário ficou de: {f1.GetSalario():F2}");
