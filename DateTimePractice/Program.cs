
DateTime fechaActual = DateTime.Now;
//Console.WriteLine(fechaActual);

DateTime fecha2 = new DateTime(2025, 10, 10);
//Console.WriteLine(fecha2);

//lista de enumeracion "dayOfWeek" para los dias de la semana no laborables
List<DayOfWeek> diasNoLaborables = new List<DayOfWeek> { DayOfWeek.Saturday, DayOfWeek.Sunday };

//lista de dateTime para los feriados o dias aleatorios que no se trabaja
DateTime nueveDeJulio = new DateTime(2024,7,9);
DateTime veinteDeOctubre = new DateTime(2024, 10, 20);
DateTime veinteDeJunio = new DateTime(2024, 6, 20);

List<DateTime> feriados = new List<DateTime> { nueveDeJulio, veinteDeJunio, veinteDeOctubre }; 


//primer metodo
int cantDias=obtenerCantidadDias(fechaActual, fecha2);
Console.WriteLine($"\nEntre {fechaActual.ToShortDateString()} y {fecha2.ToShortDateString()} hay {cantDias} dias");


//segundo metodo
int cantDiasLaborales = ObtenerCantidadDiasLaborales(fechaActual, fecha2, diasNoLaborables, feriados);
Console.WriteLine($"\nEntre {fechaActual.ToShortDateString()} y {fecha2.ToShortDateString()} hay {cantDiasLaborales} días laborales");

//tercer metodo
DateTime fechaResultante = SumarDiasLaborables(fechaActual, 10, diasNoLaborables, feriados);
Console.WriteLine($"La fecha resultante es: {fechaResultante.ToShortDateString()}");



//Metodo 1: Obtener cantidad de dias entre dos fechas
static int obtenerCantidadDias(DateTime fechaInicio, DateTime fechaFin)
{
    TimeSpan diasDiferencia = fechaFin - fechaInicio;
    int cantDias = diasDiferencia.Days;

    return cantDias;

}


//metodo 2: Obtener cantidad de dias laborables entre dos fechas. Version 1
static int ObtenerCantidadDiasLaborales(DateTime fechaInicio, DateTime fechaFin, List<DayOfWeek> diasNoLaborables, List<DateTime> feriados)
{
    int cantDiasLaborables = 0;
    DateTime fechaRef = fechaInicio;

    while (fechaRef <= fechaFin)
    {
        if (!diasNoLaborables.Contains(fechaRef.DayOfWeek) && !feriados.Contains(fechaRef.Date))
        {
            cantDiasLaborables++;
        }

        fechaRef = fechaRef.AddDays(1);
    }


    return cantDiasLaborables;
}
//metodo 3: sumar dias laborables a una fecha dada
static DateTime SumarDiasLaborables(DateTime fecha, int dias, List<DayOfWeek> diasNoLaborables, List<DateTime> feriados)
{
    //se inicializan dos fechas con la ingresada, una para recorrer cada dia y otra para guardar la fecha final
    DateTime fechaRef = fecha;
    DateTime fechaFinal = fecha;

    //este contador solo suma cuando es un dia laboral
    int diasSumados = 0;

    while (diasSumados < dias)
    {
        fechaRef = fechaRef.AddDays(1);

        //si es un dia no laborable sale en este punto y no se ejecuta el final
        if (diasNoLaborables.Contains(fechaRef.DayOfWeek) || feriados.Contains(fechaRef.Date))
        {
            continue;
        }

        //asi, esta fecha final resultara ser la cantidad de dias habiles indicados
        fechaFinal = fechaRef;
        diasSumados++;
    }

    return fechaFinal;
}


