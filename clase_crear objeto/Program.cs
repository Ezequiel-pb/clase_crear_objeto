using System;
using System.Security.Cryptography.X509Certificates;



public class Persona
{

    public string Nombre;
    public int Edad;

    //constructor

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad; 
        

    }
    // metodo
    public void Saludar()
    {

        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }

    
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona("maria",25);
       // persona1.Nombre = "carlos";
        //persona1.Edad = 30;
        persona1.Saludar();



    }

}