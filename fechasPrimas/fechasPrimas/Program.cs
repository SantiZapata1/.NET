using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fechasPrimas
{
    class program
    {
        public static void Main(string[] args)
        {
            //creo el objeto
            Periodo periodo1 = new Periodo(new DateTime(2018, 1, 10), new DateTime(2019, 09, 10),  "periodo 1");

            //muestro el objeto periodo
            Console.WriteLine(periodo1);

            DateTime p = new DateTime(2024/02/10);
            DateTime p1 = new DateTime(2024 / 03 / 10);
            DateTime p2 = new DateTime(2024 / 01 / 10);
            DateTime p3 = new DateTime(2024 / 08 / 10);
            DateTime p4 = new DateTime(2024 / 05 / 10);
            DateTime p5 = new DateTime(2024 / 04 / 10);
            DateTime p6 = new DateTime(2024 / 07 / 10);

            DateTime[] arregloDates = new DateTime[]{ p, p1, p2, p3, p4, p5, p6 };


            mostrar(arregloDates);


        }
        static void mostrar(DateTime[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine("");
        }

    }

}

class Periodo {

    //atributos
    public string nombre { get; set; }
    DateTime fechaInicio { get; set; }
    DateTime fechaFin { get; set; }
    public DateTime[] fechasPrimasHabiles { get; set; }
    public int cantDiasPrimosHabiles { get; set; }

    //constructores
    public Periodo(DateTime inicio, DateTime fin, string nombrePeriodo)
    {
        fechaInicio = inicio;
        fechaFin = fin;
        nombre = nombrePeriodo;
        TimeSpan duracion = fin - inicio;
        fechasPrimasHabiles = new DateTime[duracion.Days];
        cantDiasPrimosHabiles = 0;
    }

    //metodos
    public override string ToString()
    {
        return $"{nombre}: inicia {fechaInicio.ToShortDateString()}, finaliza {fechaFin.ToShortDateString()}";
    }

    public void mostrarDiasPedidos()
    {
        Console.WriteLine($"cantidad de dias primos y habiles: {cantDiasPrimosHabiles}");
        for (int i = 0; i < fechasPrimasHabiles.Length; i++)
        {
            if (fechasPrimasHabiles[i].Day!=1) {
                Console.WriteLine($"{fechasPrimasHabiles[i].Day} -  {fechasPrimasHabiles[i].DayOfWeek} ");

            }


        }
        Console.WriteLine(" ");
    }

    public void sacarDiasPrimosHabiles()
    {
        DateTime fechaActual = fechaInicio;
        int diaActual = fechaActual.Day;

        TimeSpan duracion = fechaFin - fechaInicio;

        int x = 0;
        for (int i = 0; i < duracion.Days; i++)
        {
            if (esPrimo(diaActual) && esDiaHabil(fechaActual))
            {
                
                fechasPrimasHabiles[x] = fechaActual;
                x++;

            }
            cantDiasPrimosHabiles = x;

            fechaActual = fechaActual.AddDays(1);
            diaActual = fechaActual.Day;

        }


    }

    static bool esPrimo(int number)
    {
        // Los números menores que 2 no son primos
        if (number < 2)
        {
            return false;
        }

        // Verificar divisores desde 2 hasta la raíz cuadrada del número
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Si se encuentra un divisor, el número no es primo
            }
        }

        return true; // Si no se encuentra ningún divisor, el número es primo
    }

    static bool esDiaHabil(DateTime date)
    {
        // Verificar si el día de la semana es sábado o domingo
        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            return false;
        }

        return true; // Si no es fin de semana, es un día hábil
    }

    public void ordenarFechas() { }




}

