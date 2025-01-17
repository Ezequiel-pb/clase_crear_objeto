using System;

public class Persona
{

    public string Nombre;
    public int Edad;

        public void Saludar()
    {

        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }

    
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.Nombre = "carlos";
        persona1.Edad = 30;
        persona1.Saludar();


    }
    
}