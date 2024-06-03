namespace Dado
{
    class Program
    {
        //metodo principal
        static void Main(string[] args)
        {

            Dadoo dado = new Dadoo();


            Console.WriteLine("------------ Bienvenido al casino! ------------\n");

            bool salir = true;

            while (salir)
            {
                Console.Write("Ingrese a que numero del dado le desea apostar (1/6): ");
                int rdo = dado.lanzarDado();


                int numeroElegido = int.Parse(Console.ReadLine());

                if (numeroElegido>=1 && numeroElegido <=6)
                {

                    if (numeroElegido == rdo)
                    {
                        Console.WriteLine("\n\n ------------------------------ ");

                        Console.WriteLine("GANASTEEEEEEEEEE! ");
                        Console.WriteLine($"eleccion: {numeroElegido} \n resultado: {rdo}");


                        salir = false;
                    }
                    else
                    {
                        Console.WriteLine("\nperdiste :/ ");
                        Console.WriteLine($"eleccion: {numeroElegido} \n resultado: {rdo}");
                        Console.WriteLine("------------------------------ ");



                    }



                }
                else {
                    Console.WriteLine("entrada invalida, intente devuelta ");

                }

               
            }
        }


    }
}

    class Dadoo
    {
        

        public int lanzarDado()
        {
            // Creamos una instancia de la clase Random
            Random rnd = new Random();

            // Generamos un número aleatorio entre 0 y 99
            int numeroAleatorio = rnd.Next(1, 7);

            return numeroAleatorio;

        }

    }
