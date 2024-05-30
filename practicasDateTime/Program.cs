
Console.WriteLine("Practica dateTime!");

DateTime fecha1 = DateTime.Now;
Console.WriteLine(fecha1);//8 / 5 / 2024

DateTime fecha2 = new DateTime(2024,6,15);
Console.WriteLine(fecha2);//10 / 5 / 2024

obtenerDiasCaledario(fecha1, fecha2);
obtenerDiasLaborales(fecha1, fecha2);


static void obtenerDiasCaledario(DateTime fechaInicio, DateTime fechaFin)
{
    TimeSpan diferecia = fechaFin - fechaInicio;
    int cantDias= diferecia.Days;

    Console.WriteLine($"Entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()} hay {cantDias} dias");
}

static void obtenerDiasLaborales(DateTime fechaInicio, DateTime fechaFin)
{
    TimeSpan diferecia = fechaFin - fechaInicio;
    int cantDias = diferecia.Days;
    int diasEnd = 0;

    DateTime fechaI = fechaInicio;

    for (int i = 0; i<cantDias;i++)
    {
        if (fechaI.DayOfWeek == DayOfWeek.Saturday || fechaI.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine($"la fecha {fechaI} SI fin de semana, es {fechaI.DayOfWeek}");
            diasEnd++;
        }
        else
        {
            //Console.WriteLine($"la fecha {fechaI} NO fin de semana, es {fechaI.DayOfWeek}");

        }

        fechaI=fechaI.AddDays(1);
        Console.WriteLine(fechaI);
    }


    Console.WriteLine($"Entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()} hay {cantDias-diasEnd} dias laborales");



}