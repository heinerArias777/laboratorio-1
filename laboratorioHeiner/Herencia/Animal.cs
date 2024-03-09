using System;

class Animal
{
    protected string nombre;
    protected int edad;

    public Animal(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
    }
}


