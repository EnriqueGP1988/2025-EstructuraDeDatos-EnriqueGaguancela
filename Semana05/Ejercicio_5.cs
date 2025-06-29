//Escribir un programa que pida al usuario una palabra y muestre por pantalla si es un palíndromo.
//Palíndromo son aquellas palabras que se leen igual de izquierda a derecha.
//Ejemplos: reconocer, ana, oso, radar, anilina.

class Ejercicio_5
{
    public static void Ejecutar()
    {
        // Pedir al usuario que ingrese una palabra.
        Console.Write("Introducir una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertimos a minúsculas para comparar.

        // Invertir la palabra
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        // Verificar si es un palíndromo.
        if (palabra == palabraInvertida)
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}
