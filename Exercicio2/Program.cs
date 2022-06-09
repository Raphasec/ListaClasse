string cpf;
string nome;
string sobrenome;
double salario;
double percentual;
int op;

List<Funcionario> func = new List<Funcionario>();

void AdicionarFuncionario()
{
    Console.Clear();
    Console.Write("Digite o cpf do funcionário: ");
    cpf = Console.ReadLine();

    Console.Write("Digite o nome do funcionário: ");
    nome = Console.ReadLine();

    Console.Write("Digite o sobrenome do funcionário: ");
    sobrenome = Console.ReadLine();

    Console.Write("Digite salário do funcionário: ");
    salario = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a porcentagem do aumento do salário: ");
    percentual = Convert.ToDouble(Console.ReadLine());

    Funcionario f1 = new Funcionario(cpf, nome, sobrenome, salario, percentual);

    f1.AumentarSalario(percentual);

    func.Add(f1);
}

void MostrarFuncionarios()
{
    Console.Clear();
    for(int i = 0; i < func.Count(); i++)
    {
        Console.WriteLine(func[i].ToString());
        Console.WriteLine("\n");
    }
}

do
{
    Console.Clear();
    Console.WriteLine("-----------------------");
    Console.WriteLine("\tMENU");
    Console.WriteLine("1 - Adicionar Funcionário");
    Console.WriteLine("2 - Mostrar Funcionários");
    Console.WriteLine("-----------------------");

    op = Convert.ToInt32(Console.ReadLine());

    if(op == 1)
    {
        AdicionarFuncionario();
    }else if(op == 2)
    {
        MostrarFuncionarios();
    }else
    {
        Console.WriteLine("Erro!!! Tente novamente");
    }
} while(op != 2);
