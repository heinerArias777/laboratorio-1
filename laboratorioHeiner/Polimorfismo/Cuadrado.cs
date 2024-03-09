public class Cuadrado : Figura
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

