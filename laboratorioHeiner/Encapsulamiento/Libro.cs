using System;

class Libro                           //Encapsulamiento
{
    private string titulo;
    private string autor;
    private int añoPublicacion;

    public Libro(string titulo, string autor, int añoPublicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.añoPublicacion = añoPublicacion;
    }

    public string ObtenerTitulo()
    {
        return titulo;
    }

    public string ObtenerAutor()
    {
        return autor;
    }

    public int ObtenerAñoPublicacion()
    {
        return añoPublicacion;
    }
}
















/*class Program
{
    static void Main(string[] args)
    {
        Libro miLibro = new Libro("El señor de los anillos", "J.R.R. Tolkien", 1954);

        Console.WriteLine("Información del libro:");
        Console.WriteLine("Título: " + miLibro.ObtenerTitulo());
        Console.WriteLine("Autor: " + miLibro.ObtenerAutor());
        Console.WriteLine("Año de publicación: " + miLibro.ObtenerAñoPublicacion());

        Console.ReadLine();
    }
}
