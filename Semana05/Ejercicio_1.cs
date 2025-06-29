// Escribir un programa que almacene las asignaturas de un curso
//(por ejemplo Matemáticas, Física, Química, Historia y Lengua)
//en una lista y la muestre por pantalla.

  class Ejercicio_1
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio #1");

        Console.Write("Ingrese el número de asignaturas ");
        int cantidad = int.Parse(Console.ReadLine());
        List<string> asignaturas = new List<string>();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Asignatura {i + 1}: ");
            asignaturas.Add(Console.ReadLine());
        }

        asignaturas.Sort();
        Console.WriteLine("Asignaturas del estudiante:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}