DateTime fecha1 = DateTime.Now;
Console.WriteLine(fecha1);

DateTime fecha2 = new DateTime(2025, 10, 10);
Console.WriteLine(fecha2);

obtenerCantidadDias(fecha1, fecha2);

List<DayOfWeek> diasNoLaborables = new List<DayOfWeek> { DayOfWeek.Saturday, DayOfWeek.Sunday };


int cantDiasLaborales = ObtenerCantidadDiasLaborales2(fecha1, fecha2, diasNoLaborables);

Console.WriteLine($"\nEntre {fecha1.ToShortDateString()} y {fecha2.ToShortDateString()} hay {cantDiasLaborales} días laborales");

int cantDias = 4;
DateTime fechaResultante = sumarDiasLaborables(fecha1, cantDias, diasNoLaborables);
//Console.WriteLine($"\nFecha inicial: {fecha1.ToLongDateString()} + \"{cantDias}\" dias es: {fechaResultante.ToLongDateString()}.");


List<DateTime> feriados = new List<DateTime> { new DateTime(2024, 7, 9) }; // Ejemplo de feriado: 9 de julio

DateTime fechaInicial = new DateTime(2024, 7, 1);
int diasASumar = 10;

DateTime fechaResultante2 = SumarDiasLaborables2(fechaInicial, diasASumar, diasNoLaborables, feriados);

Console.WriteLine($"La fecha resultante es: {fechaResultante2.ToShortDateString()}");

//Metodo para obtener cantidad de dias entre dos fechas
static void obtenerCantidadDias(DateTime fechaInicio, DateTime fechaFin)
{
    TimeSpan diasDiferencia = fechaFin - fechaInicio;
    int cantDias = diasDiferencia.Days;

    Console.WriteLine($"\nEntre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()} hay {cantDias} dias");

}



//metodo para obtener cantidad de dias laborables entre dos fechas. Version 1
static int ObtenerCantidadDiasLaborales2(DateTime fechaInicio, DateTime fechaFin, List<DayOfWeek> diasNoLaborables)
{
    int cantDiasLaborables = 0;
    DateTime fechaRef = fechaInicio;

    while (fechaRef <= fechaFin)
    {
        if (!diasNoLaborables.Contains(fechaRef.DayOfWeek))
        {
            cantDiasLaborables++;
        }

        fechaRef = fechaRef.AddDays(1);
    }


    return cantDiasLaborables;
}
static DateTime SumarDiasLaborables2(DateTime fecha, int dias, List<DayOfWeek> diasNoLaborables, List<DateTime> feriados)
{
    DateTime fechaRef = fecha;
    DateTime fechaFinal = fecha;
    int diasSumados = 0;

    while (diasSumados < dias)
    {
        fechaRef = fechaRef.AddDays(1);

        if (diasNoLaborables.Contains(fechaRef.DayOfWeek) || feriados.Contains(fechaRef.Date))
        {
            continue;
        }

        fechaFinal = fechaRef;
        diasSumados++;
    }

    return fechaFinal;
}



static DateTime sumarDiasLaborables(DateTime fecha, int dias, List<DayOfWeek> diasNoLaborables)
{
    DateTime fechaRef = fecha;
    DateTime fecha2 = fecha.AddDays(dias);

    int cantDiasNoLaborables = 0;

    while (fechaRef <= fecha2)
    {
        if (diasNoLaborables.Contains(fechaRef.DayOfWeek))
        {
            cantDiasNoLaborables++;
        }
        

        fechaRef = fechaRef.AddDays(1);
    }

    DateTime fechaResultante = fecha.AddDays(dias + cantDiasNoLaborables);

    if (fechaResultante.DayOfWeek == DayOfWeek.Saturday)
    {
        fechaResultante=fechaResultante.AddDays(2);

    }
    else if (fechaResultante.DayOfWeek == DayOfWeek.Sunday)
    {
        fechaResultante = fechaResultante.AddDays(1);

    }
    return fechaResultante;


}


/*
 //metodo para obtener cantidad de dias laborables entre dos fechas. Version 1
static void obtenerCantidadDiasLaborales(DateTime fechaInicio, DateTime fechaFin)
{
    TimeSpan diasDiferencia = fechaFin - fechaInicio;
    int cantDias = diasDiferencia.Days;
    int cantDiasNoLaborales = 0;
    DateTime fechaRef = fechaInicio;

    for (int i = 0; i < cantDias; i++)
    {
        if (fechaRef.DayOfWeek == DayOfWeek.Saturday || fechaRef.DayOfWeek == DayOfWeek.Sunday)
        {
            cantDiasNoLaborales++;
        }


        fechaRef = fechaRef.AddDays(1);

    }


    int cantDiasLaborales = cantDias - cantDiasNoLaborales;


    Console.WriteLine($"\nEntre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()} hay {cantDiasLaborales} dias laborales");

}*/