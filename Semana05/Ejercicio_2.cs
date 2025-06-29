//Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua)
//en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>,
//donde<asignatura> es cada una de las asignaturas de la lista.

class Ejercicio_2
{
    public static void Ejecutar()
    {
        // Lista de asignaturas.
        List<string> asignaturas = new List<string>
        {
            "Metodología de la Investigación",
            "Administración de Sistemas Operativos",
            "Estructura de Datos",
            "Fundamentos de Sistemas Digitales",
            "Instalaciones Eléctricas y Cableado Estructurado"
        };

        // Mostrar el mensaje para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}
