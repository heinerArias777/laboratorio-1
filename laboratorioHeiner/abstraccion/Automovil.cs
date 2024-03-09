class Automovil : Vehiculo
{
    private int velocidadMaxima;

    public Automovil(int velocidadMaxima)
    {
        this.velocidadMaxima = velocidadMaxima;
    }

    public override int ObtenerVelocidadMaxima()
    {
        return velocidadMaxima;
    }
}