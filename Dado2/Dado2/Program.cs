using System;
using System.Runtime.ConstrainedExecution;

//no te debe dejar apostar algo que si perdes no lo vas a poder pagar
//Manejar excepciones
//usar enum

namespace Dado2
{
    public class Dado2
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("\n\tBienvenido al juego de los dados\n");

            //dado
            Dado dado = new Dado();

            //apuesta
            Apuesta apuesta = new Apuesta();

            //jugadores
            Jugador jugador1 = new Jugador("santi");
            Jugador jugador2 = new Jugador("pepo");

            Console.WriteLine(jugador1);
            Console.WriteLine(jugador2);
            Console.WriteLine($"Pozo: ${apuesta.pozo}");

            //Flag para manejar los turnos de los jugadores
            bool turno=true;
            int resultado;

            //El juego termina cuando el pozo o el saldo de algún jugador llega a cero.
            while (apuesta.pozo>0 && jugador1.monto>0 && jugador2.monto>0)
            {

                //Turno jugador 1
                if (turno)
                {
                    Console.WriteLine("\n\tTurno jugador 1\n");

                    //ingresa numero a apostar
                    int numero=0;
                    while (!(numero>=1 && numero<=6))
                    {
                        Console.Write("Ingrese a que numero del dado le desea apostar (1/6): ");
                        int.TryParse(Console.ReadLine(), out numero);

                    }
                    apuesta.numeroApostado = numero;


                    //ingresa monto a apostar
                    int monto = 0;
                    while (!(monto>0 && monto <jugador1.monto))
                    {
                        Console.Write("Ingrese monto a postar: $");
                        int.TryParse(Console.ReadLine(), out monto);

                    }
                    apuesta.cantidadApostada = monto;

                    //ingresa modo de apuesta

                    int modo = 0;
                    while (!(modo ==1 ||modo==2||modo==3)) {
                        Console.Write("Ingrese a el modo de apuesta: cons(1) arrie(2) deses(3) ");
                        int.TryParse(Console.ReadLine(),out modo);

                    }
                    apuesta.modoApuesta = modo;

                    //mostramos apuesta
                    Console.WriteLine(apuesta);

                    //lanzamos dado
                    resultado = dado.lanzarDado();

                    apuesta.hacerApuesta(jugador1, resultado);

                    turno = !turno;

                }

                //turno jugador 2
                else
                {

                    Console.WriteLine("\n\tTurno jugador 2\n");

                    //ingresa numero a apostar
                    Console.Write("Ingrese a que numero del dado le desea apostar (1/6): ");
                    apuesta.numeroApostado = int.Parse(Console.ReadLine());//hacer con tryparse como enseno el profe

                    //ingresa monto a apostar
                    Console.Write("Ingrese monto a postar: $");
                    apuesta.cantidadApostada = int.Parse(Console.ReadLine());

                    //ingresa modo de apuesta
                    Console.Write("Ingrese a el modo de apuesta: cons(1) arrie(2) deses(3) ");
                    apuesta.modoApuesta = int.Parse(Console.ReadLine());

                    //mostramos apuesta
                    Console.WriteLine(apuesta);

                    //lanzamos dado
                    resultado = dado.lanzarDado();

                    apuesta.hacerApuesta(jugador2, resultado);

                    turno = !turno;

                }


            }

            Console.WriteLine("\nFIN DEL JUEGO ");

            if (apuesta.pozo<=0)
            {
                Console.WriteLine($"Perdio el casino, el pozo esta en: ${apuesta.pozo}");
            }else if (jugador1.monto<=0)
            {
                Console.WriteLine($"Perdio el jugador 1, tiene: ${jugador1.monto}");

            }
            else if (jugador2.monto <= 0)
            {
                Console.WriteLine($"Perdio el jugador 2, tiene: ${jugador2.monto}");

            }


        }


    }



    //clase jugador
    class Jugador
    {
        private string nombre { get; set; }
        internal int monto { get; set; }

        public Jugador(String nombreJugador)
        {
            nombre = nombreJugador;
            monto = 100;
        }
        public override string ToString()
        {
            return $"{nombre} tiene ${monto}";
        }



    }

    //clase dado
    class Dado
    {
        private Random random = new Random();

        public int lanzarDado()
        {
            int numRandom = random.Next(1,7);
            return numRandom;
        }

    }

    //clase apuestas
    class Apuesta
    {
        public int numeroApostado { get; set; }
        public int cantidadApostada { get; set; }
        public int modoApuesta { get; set; }
        public int pozo{get;set;}

        public Apuesta(int numero, int cantidad, int modo)
        {
            numeroApostado = numero;
            cantidadApostada = cantidad;
            modoApuesta = modo;
            pozo = 10000;

        }
        public Apuesta()
        {
            numeroApostado = 0;
            cantidadApostada = 0;
            modoApuesta = 0;
            pozo = 10000;

        }

        

        public void hacerApuesta(Jugador jugador, int resultado)
        {
            int cantidad;

            if (numeroApostado >= 1 && numeroApostado <= 6)
            {

                if (numeroApostado == resultado)
                {

                    Console.WriteLine($"\nGANASTE: {numeroApostado}-{resultado}");
                    if (modoApuesta == (int)modo.reservado)
                    {
                        cantidad = cantidadApostada * 2;
                        jugador.monto += cantidad;
                        pozo -= cantidad;

                    }
                    else if (modoApuesta == (int)modo.arriesgado)
                    {
                        cantidad = cantidadApostada * 5;
                        jugador.monto += cantidad;
                        pozo -= cantidad;

                    }
                    else if (modoApuesta == (int)modo.desesperado)
                    {
                        cantidad = cantidadApostada * 15;
                        jugador.monto += cantidad;
                        pozo -= cantidad;
                    }



                }
                else
                {
                    Console.WriteLine($"\nPerdiste: {numeroApostado}-{resultado}");

                    if (modoApuesta == (int)modo.reservado)
                    {
                        cantidad = cantidadApostada;
                        jugador.monto -= cantidad;
                        pozo += cantidad;

                    }
                    else if (modoApuesta == (int)modo.arriesgado)
                    {
                        cantidad = cantidadApostada * 2;
                        jugador.monto -= cantidad;
                        pozo += cantidad;

                    }
                    else if (modoApuesta == (int)modo.desesperado)
                    {
                        cantidad = cantidadApostada * 4;
                        jugador.monto -= cantidad;
                        pozo += cantidad;
                    }
                }
                Console.WriteLine(jugador);
                Console.WriteLine($"Pozo: ${pozo}");

            }
            else
            {
                Console.WriteLine("entrada invalida, intente devuelta ");
            }

        }


        public override string ToString()
        {
            return $"\nnum:{numeroApostado}, cant: ${cantidadApostada}, modo: {modoApuesta}";
        }

    }

    //enumeracion
    public enum modo
    {
        reservado,
        arriesgado,
        desesperado,
    }

}
