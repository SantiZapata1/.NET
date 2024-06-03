using System;
public class arrayPractice
{

    public static void Main()
    {

        int[] arrInt = {1,5,3,7,4,6,2,3,1};

        //length
        Console.WriteLine("Longitud del array: " + arrInt.Length);

        //copyTo
        int[] copiaInt = new int[9];
        arrInt.CopyTo(copiaInt,0);

        //sort
        Array.Sort(arrInt);

        //reverse
        Array.Reverse(arrInt);

        //clear
        Array.Clear(arrInt,1,arrInt.Length-1);
        Array.Clear(arrInt);



        Periodo[] listaPeriodos =
        {
            new Periodo(new DateTime(2024,3,10) , new DateTime(2024,5,10)),
            new Periodo(new DateTime(2024,4,10) , new DateTime(2024,6,10)),
            new Periodo(new DateTime(2024,5,10) , new DateTime(2024,7,10)),
            new Periodo(new DateTime(2024,1,10) , new DateTime(2024,2,10)),
            new Periodo(new DateTime(2024,8,10) , new DateTime(2024,10,10))
        };


        mostrarPeriodos(listaPeriodos);

        Array.Sort(listaPeriodos, (p1, p2)=> p1.inicio.CompareTo(p2.inicio));

        mostrarPeriodos(listaPeriodos);








    }

    static void mostrarPeriodos(Periodo[] listaPeriodos) {

        Console.WriteLine("\nPeriodos cargados:");

        foreach (var periodo in listaPeriodos)
        {
            Console.WriteLine(periodo);
        }


    }





}

class Periodo
{
    public DateTime inicio { get; set; }
    DateTime fin { get; set; }
    TimeSpan duracion { get; set; }

    public Periodo(DateTime fechaInicio, DateTime fechaFin)
    {
        inicio = fechaInicio;
        fin = fechaFin;
        duracion = fin - inicio;

    }

    public override string ToString()
    {
        return $"{fin.ToShortDateString()} - {inicio.ToShortDateString()} = {duracion.Days} dias";
    }



}