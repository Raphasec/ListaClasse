class Quadrado
{
    double lado;

    public Quadrado()
    {

    }

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public double GetLado()
    {
        return this.lado;
    }

    public void SetLado(double lado)
    {
        this.lado = lado;
    }

    public double GetPerimetro()
    {
        return this.lado * 4;
    }

    public double GetArea()
    {
        return this.lado * this.lado;
    }
}