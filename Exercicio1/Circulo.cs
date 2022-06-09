class Circulo
{
    double raio;

    public Circulo()
    {

    }

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public double GetRaio()
    {
        return this.raio;
    }

    public void GetRaio(double raio)
    {
        this.raio = raio;
    }

    public double GetCircunferencia()
    {
        return (2 * Math.PI * this.raio);
    }

    public double GetArea()
    {
        return (Math.PI * Math.Pow(this.raio, 2));
    }
}