//Estructuras de decisión en C# (Grupal)
//Objetivo: Comprender la aplicación de las estructuras de decisión.
//Ejercicio:

//Cree una aplicación de consola.
//Solicite el ingreso de un texto y controle que no esté vacío.
//Despliegue un menú que muestre 3 opciones (Texto en mayúscula, Texto en minúscula y Texto Original).
//Capture la entrada con Console.Readkey y realice la opción solicitada.


bool i = false;
while (i == false)
{
    Console.Write("Ingrese un texto: ");
    string text = Console.ReadLine();

    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("El texto está vacío.");
    }
    else
    {
        //Console.WriteLine("\nEl texto no está vacío: " + text);

        bool x = false;

        while (x==false)
        {

            Console.WriteLine("\n1. Texto en MAYUSCULA");
            Console.WriteLine("2. Texto en minuscula");
            Console.WriteLine("3. Texto en original");

            Console.WriteLine("Presiona una tecla (1, 2 o 3)...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("\nPresionaste 1.");
                string textoEnMayusculas = text.ToUpper();
                Console.WriteLine(textoEnMayusculas);
                i = true;
                x = true;

            }
            else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nPresionaste 2.");
                string textoEnMinusculas = text.ToLower();
                Console.WriteLine(textoEnMinusculas);
                i = true;
                x = true;


            }
            else if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("\nPresionaste 3.");
                Console.WriteLine(text);
                i = true;
                x = true;

            }
            else
            {
                Console.WriteLine("\nNo presionaste 1, 2 o 3.");
            }


        }




    }



}


Console.WriteLine("\n\n\tFIN DEL PROGRAMA :)");
