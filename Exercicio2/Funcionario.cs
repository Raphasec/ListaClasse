class Funcionario
{
    string cpf;
    string nome;
    string sobrenome;
    double salario;
    double percentual;

    public Funcionario(string cpf, string nome, string sobrenome, double salario, double percentual)
    {
        this.cpf = cpf;
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salario = salario;
        this.percentual = percentual;
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
        double aument = this.salario + (this.salario * (percentual/100));

        this.salario = aument;
    }

    public override string ToString()
    {    
        return ($"CPF: {this.cpf}\nNome: {this.nome}\nSobrenome: {this.sobrenome}\nCom o aumento, o Salário ficou: {this.salario:F2}\nO salário anual é de: {GetSalarioAnual():F2}");
    }
}
