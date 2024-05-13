/*
 Elabore un programa en C# que:

Tome N períodos de tiempo (según el ejemplo N=4; A,B,C y D).
Cada uno de estos períodos tiene un instante de tiempo (fecha-hora) en el que inicia, otro en el que finaliza y una duración.
Luego realice la UNIÓN de los mismos
De dos o más períodos que se solapan resultará un período nuevo (por ej. ABC, nótese que en este caso el período resultante sería la fecha-hora de inicio de A y la de finalización de B)
Si los períodos no se solapan, estos quedaran por separado (por ej. D)
Y finalmente retorne los M períodos disjuntos resultantes, es decir, que no se solapen entre sí, ordenados  de forma creciente (según el ejemplo M=2).
Consideraciones:

Los N períodos de tiempo estarán precargados en un arreglo.
Además de la funcionalidad del código se valorará su correcto diseño.
Coloque toda la solución en un archivo comprimido y súbala.
 */

using System;

namespace testParcial1
{

    public class testParcial1{


        public static void Main(string[] args)
        {

            Console.WriteLine("\n\tModelo parcial 1\n");

            
            //primer forma de declarar dateTime
            PeriodoDeTiempo periodo1 = new PeriodoDeTiempo(new DateTime(2024,04,10), new DateTime(2024,06,10));

            //segunda forma de declarar dateTime
            DateTime fechaInicio = new DateTime(2024, 5, 10);
            DateTime fechaFin = new DateTime(2024, 8, 10);
            PeriodoDeTiempo periodo2 = new PeriodoDeTiempo(fechaInicio, fechaFin);


            //arreglo con los periodos de tiempo
            PeriodoDeTiempo[] listaPeriodos = new PeriodoDeTiempo[]
            {
                periodo1,
                periodo2,
                new PeriodoDeTiempo(new DateTime(2024, 2, 1), new DateTime(2024, 3, 1)),//tercer forma de declarar DateTime
                new PeriodoDeTiempo(new DateTime(2024, 9, 1), new DateTime(2024, 10, 1)),
                new PeriodoDeTiempo(new DateTime(2024, 6, 1), new DateTime(2024, 7, 1))
            };

            //mostramos periodos cargados
            Console.WriteLine("\nPeriodos:");
            Console.WriteLine(periodo1);
            Console.WriteLine(periodo2);
            Console.WriteLine(listaPeriodos[2]);
            Console.WriteLine(listaPeriodos[3]);
            Console.WriteLine(listaPeriodos[4]);



            //primero ordenamos el array de PeriodoDeTiempo, la explicacion de la funcion "sort" esta al final
            Array.Sort(listaPeriodos, (p1, p2) => p1.fechaInicio.CompareTo(p2.fechaInicio));

            // creamos un nuevo arreglo llamado "periodosUnidos" que tiene la misma longitud que el arreglo "listaPeriodos"
            // y se utilizará para almacenar los períodos de tiempo resultantes de la unión de los períodos originales.
            PeriodoDeTiempo[] periodosUnidos = new PeriodoDeTiempo[listaPeriodos.Length];

            //En este objeto guardamos el periodo actual para analizarlo con el resto
            //SIEMPRE ESTE VA A ESTAR ANTES QUE CON EL QUE SE COMPARA.
            PeriodoDeTiempo periodoActual = listaPeriodos[0];


            int count = 0;
            for (int i = 1; i < listaPeriodos.Length; i++)
            {
                if (periodoActual.fechaFin >= listaPeriodos[i].fechaInicio)
                {
                    // Los períodos se superponen, actualizar la fecha fin del periodo actual y su duracion
                    periodoActual.fechaFin = listaPeriodos[i].fechaFin;
                    periodoActual.duracion = periodoActual.fechaFin - periodoActual.fechaInicio;
                }
                else
                {
                    // Los períodos no se superponen, agregar el periodo actual a la lista de períodos unidos
                    periodosUnidos[count++] = periodoActual;
                    periodoActual = listaPeriodos[i];
                }

            }

            // Agregar el último periodo actual
            periodosUnidos[count++] = periodoActual;


            // Mostrar los períodos unidos
            Console.WriteLine("\nPeríodos unidos:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(periodosUnidos[i]);
            }

            // Mostrar los M períodos disjuntos resultantes
            Console.WriteLine("\nPeríodos disjuntos:");
            int m = 2;
            for (int i = 0; i < Math.Min(m, count); i++)
            {
                Console.WriteLine(periodosUnidos[i]);
            }

            


        }



    }

}

//Define una clase "PeriodoDeTiempo" que representa un período de tiempo con un id,
//una fecha de inicio, una fecha de fin y su duración.
class PeriodoDeTiempo
{
    static int contador=0;
    int id;
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFin { get; set; }
    public TimeSpan duracion { get; set; }

    public PeriodoDeTiempo(DateTime fechaInicio, DateTime fechaFin)
    {
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
        this.duracion = fechaFin - fechaInicio;
        this.id = ++contador;
    }

    public override string ToString()
    {
        return $"\n{id}- {fechaInicio.ToShortDateString()} - {fechaFin.ToShortDateString()} = {duracion.Days} dias ";
    }

}

/*
 * Explicacion de ordenar array
 * 
 Array.Sort(...): Este es un método estático de la clase Array en C#. Este método se utiliza para ordenar los elementos de un arreglo en función de un criterio específico.
periodos: Es el arreglo que se va a ordenar. En este caso, periodos contiene objetos de tipo Periodo, que representan los períodos de tiempo.
(p1, p2) => p1.Inicio.CompareTo(p2.Inicio): Este es un argumento adicional que se pasa al método Sort. Es una expresión lambda que define cómo deben compararse dos elementos del arreglo para determinar su orden. En este caso, p1 y p2 representan dos elementos del arreglo periodos, es decir, dos objetos de tipo Periodo. La expresión p1.Inicio.CompareTo(p2.Inicio) compara las fechas de inicio (Inicio) de p1 y p2.
Si el resultado es menor que 0, significa que p1 debe ir antes que p2 en la secuencia ordenada.
Si el resultado es igual a 0, significa que p1 y p2 son iguales en términos de ordenamiento.
Si el resultado es mayor que 0, significa que p1 debe ir después que p2 en la secuencia ordenada.
En resumen, esta expresión lambda indica que los elementos del arreglo periodos deben ser ordenados de forma ascendente según sus fechas de inicio (Inicio).
*/