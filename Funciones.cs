
class Funciones
{
    /* - Pide al usuario su fecha de nacimiento (Formato `yyyy-MM-dd`).
    Conviértela a `DateTime` con `DateTime.Parse()`.
    - Resta esa fecha a `DateTime.Now`.
    - Muestra: "Tienes X días de vida". */
    public static void CalcularEdadExacta(string fecha_Nacimiento){
    
    DateTime nuevaFecha = DateTime.Parse(fecha_Nacimiento);
    DateTime Hoy = DateTime.Now;
    TimeSpan DiasRestantes = Hoy - nuevaFecha;

    System.Console.WriteLine($"Tienes {DiasRestantes.Days} días de vida. \n");
    }


    /* - Pide un nombre completo al usuario (ej: " gARY pimentel ").
    - Límpialo: Quita espacios (`Trim`), ponlo todo en mayúsculas (`ToUpper`).
    - Muestra: "BIENVENIDO, GARY PIMENTEL". */
    public static void Corrector_Nombres(string nombre)
    {
        nombre = nombre.Trim();
        nombre = nombre.ToUpper();

        Console.WriteLine($"BIENVENIDO, {nombre}. \n");
    }


    /* - Pide un correo (ej: "alumno@itla.edu.do").
    - Usa `Substring` o `Split` para extraer solo el **dominio** (lo que va después del @).
    - Imprime: "El dominio es: itla.edu.do". */
    public static void Analizador_Correos(string correo)
    {
        string[] nuevocorreo = correo.Split("@");

        Console.WriteLine($"El dominio es: {nuevocorreo[1]}");
    }

}