public class Clinica  //Definición de la clase para gestionar pacientes y turnos.
{
    private const int PacientesMax = 5;  //Definir el número máximo de pacientes que se pueden registrar.
    private Paciente[] pacientes = new Paciente[PacientesMax]; //Almacena los pacientes registrados.
    private int pacienteCount = 0;  //Contador para dar a conocer los pacientes agregados.

    private Turno[,] agenda = new Turno[5, 5]; // Matriz para representar la agenda de turnos: [días, horarios]5 días, 5 horarios.

    private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };  //Días de atención.
    public string[] horarios = { "08 a.m.", "09 a.m.", "10 a.m.", "11 a.m.", "12 p.m."};  //Horarios disponibles para consulta.

    public void AgregarPaciente(Paciente p) //Agregar nuevo paciente.
    {
        if (pacienteCount < PacientesMax) //Verificar si hay turnos disponibles.
        {
            pacientes[pacienteCount++] = p;
            Console.WriteLine("Paciente registrado.");
        }
        else
        {
            Console.WriteLine("Turnos agotados.");
        }
    }

    public Paciente BuscarPacientePorDNI(string dni) //Buscar paciente por DNI (cédula de identidad).
    {
        for (int i = 0; i < pacienteCount; i++)
        {
            if (pacientes[i].DNI == dni)
                return pacientes[i];
        }
        return null;
    }

    public void AsignarTurno(string dni, int dia, int hora) //Método para asignar turno a un paciente.
    {
        Paciente paciente = BuscarPacientePorDNI(dni);
        if (paciente != null && !agenda[dia, hora].ocupado)
        {
            agenda[dia, hora] = new Turno(paciente, horarios[hora]);
            Console.WriteLine($"Turno asignado a {paciente.Nombre} el {dias[dia]} a las {horarios[hora]}");
        }
        else
        {
            Console.WriteLine("Turno no disponible o paciente no encontrado.");
        }
    }

    public void MostrarPacientes()  //Método para mostrar los pacientes registrados.
    {
        Console.WriteLine("Pacientes Registrados:");
        for (int i = 0; i < pacienteCount; i++)
        {
            Console.WriteLine($"{pacientes[i].Nombre} - DNI: {pacientes[i].DNI} - Edad: {pacientes[i].Edad}");
        }
    }


public void MostrarAgenda()  //Muestra turnos agendados.
{
    Console.WriteLine("Turnos Asignados:");
    bool hayTurnos = false;

    for (int d = 0; d < 5; d++)
    {
        for (int h = 0; h < 8; h++)
        {
            if (agenda[d, h].ocupado)
            {
                var turno = agenda[d, h];
                Console.WriteLine($"Día: {dias[d]}, Hora: {horarios[h]}, Paciente: {turno.paciente.Nombre} (DNI: {turno.paciente.DNI})");
                hayTurnos = true;
            }
        }
    }

    if (!hayTurnos)
    {
        Console.WriteLine("No hay turnos asignados.");
    }
}

    public void GuardarPacientesEnArchivo(string ruta) //Método para guardar lista de pacientes en un archivo de texto.
    {
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            for (int i = 0; i < pacienteCount; i++)
            {
                sw.WriteLine($"{pacientes[i].Nombre}|{pacientes[i].Edad}|{pacientes[i].DNI}");
            }
        }
    }

    public void CargarPacientesDesdeArchivo(string ruta) //Método para cargar pacientes desde un archivo de texto.
    {
        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                var datos = linea.Split('|');
                if (datos.Length == 3)
                {
                    Paciente p = new Paciente(datos[0], int.Parse(datos[1]), datos[2]);
                    AgregarPaciente(p);
                }
            }
        }
    }

    public void GuardarAgendaEnArchivo(string ruta) //Método para guardar los turnos agendados en un archivo de texto.
    {
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            for (int d = 0; d < 5; d++)
            {
                for (int h = 0; h < 5; h++)  //Referencia a los 5 horarios para consulta.
                {
                    if (agenda[d, h].ocupado)
                    {
                        var p = agenda[d, h].paciente;
                        sw.WriteLine($"{d}|{h}|{p.Nombre}|{p.Edad}|{p.DNI}");
                    }
                }
            }
        }
    }

    public void CargarAgendaDesdeArchivo(string ruta)  //Método para cargar agenda desde un archivo con los turnos asignados.
    {
        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                var datos = linea.Split('|');
                if (datos.Length == 5)
                {
                    int d = int.Parse(datos[0]);
                    int h = int.Parse(datos[1]);
                    Paciente p = new Paciente(datos[2], int.Parse(datos[3]), datos[4]);
                    agenda[d, h] = new Turno(p, horarios[h]);
                }
            }
        }
    }
}
