class Funcionario
{
    string cpf;
    string nome;
    string sobrenome;
    double salario;

    public Funcionario(string cpf, string nome, string sobrenome, double salario)
    {
        this.cpf = cpf;
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salario = salario;
    }

    public string GetCpf()
    {
       return this.cpf;
    }

    public string GetNome()
    {
       return this.nome;
    }
    public string GetSobrenome()
    {
       return this.sobrenome;
    }
    public double GetSalario()
    {
       return this.salario;
    }

    public double GetSalarioAnual()
    {
        return this.salario * 12;
    }

    public void SetSalario(double salario)
    {
        this.salario = salario;
    } 

    public void AumentarSalario(double percentual)
    {
        this.salario = this.salario + (this.salario * (percentual/100));
    }

    public override string ToString()
    {    
        return ($"CPF: {this.cpf}\nNome: {this.nome}\nSobrenome: {this.sobrenome}\nSalario: {this.salario}\nO salário anual é de: {GetSalarioAnual()}".Trim());
    }
}
