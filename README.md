# El Manipulador 🕵️‍♂️
Este proyecto fue desarrollado en C# utilizando una estructura modular compuesta por dos archivos principales:


## 📌 Descripción

### Program.cs → Contiene el método Main, encargado de la interacción con el usuario.
### Un archivo adicional (por ejemplo Funciones.cs) → Contiene las funciones auxiliares donde se desarrolla la lógica de cada ejercicio.

El objetivo del programa es trabajar con tipos de datos como DateTime y string, aplicando métodos propios del lenguaje para manipular fechas y textos.


## 1. Calculadora de Edad Exacta
- El programa solicita al usuario su fecha de nacimiento en formato yyyy-MM-dd.
- La fecha ingresada es convertida a tipo DateTime utilizando DateTime.Parse().
- Se calcula la diferencia entre la fecha actual (DateTime.Now) y la fecha de nacimiento.
- Finalmente, se muestra al usuario la cantidad exacta de días vividos.


## 2. Corrector de Nombres
- El sistema pide al usuario que introduzca su nombre completo, incluso si contiene espacios innecesarios o letras en minúsculas.
- Elimina los espacios al inicio y al final usando Trim().
- Convierte todo el texto a mayúsculas usando ToUpper().
- Muestra un mensaje formateado con el nombre limpio.


## 3. Analizador de Correos (Reto)
- El usuario introduce un correo electrónico.
- Separa el texto utilizando Split() (o alternativamente Substring()).
- Extrae únicamente el dominio, es decir, la parte del correo que se encuentra después del símbolo @.
- Muestra el dominio al usuario.
