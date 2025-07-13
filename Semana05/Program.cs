﻿Console.WriteLine("Tarea Semana #5");

while (true)
{
    Console.WriteLine("\nSeleccione el número de ejercicio a ejecutar (1 - 5), opción 0 para salir:");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Ejercicio_1.Ejecutar();
            break;
        case "2":
            Ejercicio_2.Ejecutar();
            break;
        case "3":
            Ejercicio_3.Ejecutar();
            break;
        case "4":
            Ejercicio_4.Ejecutar();
            break;
        case "5":
            Ejercicio_5.Ejecutar();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}