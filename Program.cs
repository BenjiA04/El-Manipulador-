using System;

class Program
{
    static void Main()
    {
        // 1. Calculadora de Edad Exacta:
        Console.Write("\nIngresa tu fecha de nacimiento (YY/MM/DD): ");
        string fecha_Nacimiento = Console.ReadLine()!;

        Funciones.CalcularEdadExacta(fecha_Nacimiento);


        // 2. El Corrector de Nombres:
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine()!;

        Funciones.Corrector_Nombres(nombre);


        // 3. Analizador de Correos (Reto):
        Console.Write("Ingresa tu correo electronico: ");
        string correo = Console.ReadLine()!;

        Funciones.Analizador_Correos(correo);
    }
}
