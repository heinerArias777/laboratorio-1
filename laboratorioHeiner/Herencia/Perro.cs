class Perro : Animal
{
    private string raza;

    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        this.raza = raza;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Raza: {raza}");
    }
}
