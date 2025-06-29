//Escribir un programa que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.

class Ejercicio_4
{
    public static void Ejecutar()
    {
        // Pedir al usuario que ingrese una palabra.
        Console.Write("Introduzca una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertir a minúsculas.

        // Inicializar contadores de vocales.
        int contadorA = 0;
        int contadorE = 0;
        int contadorI = 0;
        int contadorO = 0;
        int contadorU = 0;

        // Contar las vocales.
        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a': contadorA++; break;
                case 'e': contadorE++; break;
                case 'i': contadorI++; break;
                case 'o': contadorO++; break;
                case 'u': contadorU++; break;
            }
        }

        // Visualizar el resultado.
        Console.WriteLine("\nCantidad de vocales:");
        Console.WriteLine("a: " + contadorA);
        Console.WriteLine("e: " + contadorE);
        Console.WriteLine("i: " + contadorI);
        Console.WriteLine("o: " + contadorO);
        Console.WriteLine("u: " + contadorU);
    }
}
