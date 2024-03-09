public class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
    //Constante que representa el valor de PI

}



