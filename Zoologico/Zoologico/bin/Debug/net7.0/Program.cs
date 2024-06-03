/*
Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores.
El sistema debe permitir la creación y gestión de diferentes tipos de animales, incluyendo mamíferos, aves, peces y una planta carnívora.
Cada animal debe tener un nombre, una especie y un tipo de comida asociado.
Los mamíferos deben ser capaces de amamantar, las aves deben poder volar y los peces deben poder nadar.
Además, se requiere la capacidad de crear una planta carnívora que se alimente de otros seres vivos.

Los cuidadores serán responsables de alimentar a los animales.
Cada cuidador debe tener un nombre y ser capaz de alimentar a los animales bajo su cuidado con la comida adecuada. Esto incluye tanto a los animales convencionales como a la planta carnívora.
El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores.
Esto implica la capacidad de agregar, eliminar y actualizar la información de los animales y cuidadores.
Además, el zoológico debe ser capaz de mostrar la lista de animales y cuidadores disponibles.

El sistema debe ser implementado en C# y ejecutarse por consola. Los alumnos deberán utilizar herencia, polimorfismo, interfaces y métodos virtuales
para garantizar la flexibilidad y extensibilidad del sistema. Además, se debe implementar la inyección de dependencias para permitir que los cuidadores alimenten a
cualquier tipo de animal, incluida la planta carnívora.
 */

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zoologico
{
    

    class Program
    {

        public static void Main(string[] args)
        {
            //creacion de diferentes tipos de animales
            Animal animal1 = new Animal("pichuno", "perro", "trocitos" );
            Animal animal3 = new Ave("pajarin", "Pajaro", "insectos");
            Mamifero animal2 = new Mamifero("gatuni", "gato", "bocaditos");
            Pez animal4 = new Pez("nemo", "pez", "pancito");
            PlantaCarnivora animal5 = new PlantaCarnivora("stuart", "planta carnivora", "animales", "tipo 1", "nose");
            Animal animal6 = new Animal("juan", "perro", "pan");
            Animal animal7 = new Ave("pio", "Pajaro", "bichos");
            Mamifero animal8 = new Mamifero("terri", "gato", "galletas");
            PlantaCarnivora animal9 = new PlantaCarnivora("carmen", "planta carnivora", "animales", "tipo 2", "nose");
            PlantaCarnivora animal10 = new PlantaCarnivora("paola", "planta carnivora", "animales", "tipo 2", "nose");
            PlantaCarnivora animal11 = new PlantaCarnivora("monica", "planta carnivora", "animales", "tipo 3", "nose");

            //creacion de diferentes listas de animales a cargo para los cuidadores
            List<Animal> animalesACargo1 = new List<Animal> {animal5, animal7, animal8, animal3, animal1};
            List<Animal> animalesACargo2 = new List<Animal> { animal1, animal2, animal3 };
            List<Animal> animalesACargo3 = new List<Animal> { animal1, animal2, animal3, animal10, animal5, animal8};


            //creacion de cuidadores
            Cuidador cuidador1 = new Cuidador("santi", animalesACargo1);
            Cuidador cuidador2 = new Cuidador("pedrito", animalesACargo2);
            Cuidador cuidador3 = new Cuidador("agus", animalesACargo3);

            //animales y cuidadores del zoo
            List<Animal> listaAnimales = new List<Animal> {animal1, animal2, animal3, animal4, animal5,animal6, animal7, animal8, animal9, animal10, animal11};
            List<Cuidador> listaCuidadores = new List<Cuidador> {cuidador1, cuidador2, cuidador3};

            //creacion del zoo
            Zoo zoo = new Zoo(listaAnimales, listaCuidadores);

            Console.WriteLine("\t\t\tBienvenido al zoo \n");

            //zoo.listarCuidadores();
            //zoo.listarAnimales();
            //cuidador1.listarAnimalesACargo();
            //cuidador1.alimentar();
            //zoo.agregarAnimal(new Animal ("juji", "raton", "pastillas"));
            //zoo.agregarCuidador(new Cuidador("mateo"));
            //zoo.eliminarAnimal("juji");
            //zoo.eliminarCuidador("mateo");
            //zoo.asignarCuidadorAAnimal(cuidador3, animal4);

            //menu
            int opcion;
            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar animal al zoo");
                Console.WriteLine("2. agregar cuidador al zoo");
                Console.WriteLine("3. eliminar animal al zoo");
                Console.WriteLine("4. eliminar cuidador al zoo");
                Console.WriteLine("5. listar animales del zoo");
                Console.WriteLine("6. listar cuidadores del zoo");
                Console.WriteLine("7. listar animales a cargo de un cuidador del zoo");
                Console.WriteLine("8. Que un cuidador alimente sus animales");
                Console.WriteLine("9. asignar cuidador a animal");
                Console.WriteLine("10. Salir");
                Console.Write("\n Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nHa seleccionado la opción Agregar animal al zoo");
                        Console.Write("ingrese nombre del animal:");
                        string nombre = Console.ReadLine();
                        Console.Write("ingrese especie del animal:");
                        string especie = Console.ReadLine();
                        Console.Write("ingrese comida del animal:");
                        string comida = Console.ReadLine();

                        Animal nuevoAnimal = new Animal(nombre, especie, comida);
                        zoo.agregarAnimal(nuevoAnimal);
                        zoo.listarAnimales();
                       
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado la opción agregar cuidador al zoo");
                        Console.Write("ingrese nombre del cuidador:");
                        string nombre2 = Console.ReadLine();
                        Cuidador cuidador = new Cuidador(nombre2);
                        zoo.agregarCuidador(cuidador);
                        zoo.listarCuidadores();
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado la opción eliminar animal al zoo");

                        Console.Write("ingrese nombre del animal a eliminar:");
                        string nombre3 = Console.ReadLine();
                        zoo.eliminarAnimal(nombre3);

                        break;
                    case 4:
                        Console.WriteLine("Ha seleccionado la opción eliminar cuidador al zoo");

                        Console.Write("ingrese nombre del cuidador a eliminar:");
                        string nombre4 = Console.ReadLine();
                        zoo.eliminarCuidador(nombre4);
                        break;
                    case 5:
                        Console.WriteLine("Ha seleccionado la opción listar animales del zoo");
                        zoo.listarAnimales();
                        break;
                    case 6:
                        Console.WriteLine("Ha seleccionado la opción listar cuidadores del zoo");
                        zoo.listarCuidadores();
                        break;
                    case 7:
                        Console.WriteLine("Ha seleccionado la opción listar animales a cargo de un cuidador del zoo");
                        Console.Write("ingrese nombre del cuidador a listar sus animales:");
                        string nombre5 = Console.ReadLine();
                        Cuidador cuidador4 = zoo.buscarCuidador(nombre5);
                        cuidador4.listarAnimalesACargo();

                        break;
                    case 8:
                        Console.WriteLine("Ha seleccionado la opción Que un cuidador alimente sus animales");
                        Console.Write("ingrese nombre del cuidador que tiene que alimentar sus animales:");
                        string nombre6 = Console.ReadLine();
                        Cuidador cuidador5 = zoo.buscarCuidador(nombre6);
                        cuidador5.alimentar();


                        break;
                    case 9:
                        Console.WriteLine("Ha seleccionado la opción asignar un cuidador a un animal");
                        Console.Write("ingrese nombre del animal que desea asignar:");
                        string nombre7 = Console.ReadLine();
                        Animal animal12 = zoo.buscarAnimal(nombre7);
                        Console.Write("ingrese nombre del cuidador al que le desea asignar ese animal:");
                        string nombre8 = Console.ReadLine();
                        Cuidador cuidador6 = zoo.buscarCuidador(nombre8);
                        zoo.asignarCuidadorAAnimal(cuidador6, animal12);

                        break;
                    case 10:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
                Console.WriteLine(); // Salto de línea para separar las iteraciones
            } while (opcion != 10);


        }




    }

    //clase zoo
    class Zoo
    {
        public List<Animal> listaAnimales;
        public List<Cuidador> listaCuidadores;

        public Zoo(List<Animal> animales, List<Cuidador> cuidadores)
        {
            listaAnimales = animales;
            listaCuidadores = cuidadores;
        }

        public void agregarAnimal(Animal nuevoAnimal)
        {
            listaAnimales.Add(nuevoAnimal);
            Console.WriteLine($"\n nuevo animal -{nuevoAnimal.nombre}- agregado al zoo");
        }
        public void agregarCuidador(Cuidador nuevoCuidador)
        {
            listaCuidadores.Add(nuevoCuidador);
            Console.WriteLine($"nuevo cuidador -{nuevoCuidador.nombre}- agregado al zoo");

        }
        public void eliminarAnimal(string nombre)
        {
            int cantidadAntes = listaAnimales.Count;
            listaAnimales.RemoveAll(animal => animal.nombre == nombre);

            if (cantidadAntes == listaAnimales.Count)
            {
                Console.WriteLine($"No se encontró ningún animal con el nombre '{nombre}' para eliminar.");
            }
            else
            {
                Console.WriteLine($"El animal '{nombre}' fue eliminado del zoo.");
            }
        }

        public void eliminarCuidador(string nombre)
        {
            int cantidadAntes = listaCuidadores.Count;
            listaCuidadores.RemoveAll(cuidador => cuidador.nombre == nombre);

            if (cantidadAntes == listaCuidadores.Count)
            {
                Console.WriteLine($"No se encontró ningún cuidador con el nombre '{nombre}' para eliminar.");
            }
            else
            {
                Console.WriteLine($"El cuidador '{nombre}' fue eliminado del zoo.");
            }
        }
        public Cuidador buscarCuidador(string nombre)
        {
            foreach (Cuidador cuidador in listaCuidadores)
            {
                if (cuidador.nombre==nombre)
                {
                    return cuidador;
                }
                else
                {
                    Console.WriteLine($"No se encontró ningún cuidador con el nombre '{nombre}' para mostrar sus animales.");

                }
            }
            return null;

        }
        public Animal buscarAnimal(string nombre)
        {
            foreach (Animal animal in listaAnimales)
            {
                if (animal.nombre == nombre)
                {
                    return animal;
                }
                else
                {
                    Console.WriteLine($"No se encontró ningún animal con el nombre '{nombre}' para mostrar sus animales.");

                }
            }
            return null;

        }


        public void asignarCuidadorAAnimal(Cuidador cuidador, Animal animal)
        {
            cuidador.asignarAnimal(animal);
            Console.WriteLine($"{animal.nombre} fue asignado a {cuidador.nombre}");


        }
        public void listarAnimales()
        {
            Console.WriteLine("\n - animales del zoo: ");

            foreach (Animal animal in listaAnimales)
            {
                animal.presentarse();
            }
        }
        public void listarCuidadores()
        {
            Console.WriteLine("\n - cuidadores del zoo: " );

            foreach (Cuidador cuidador in listaCuidadores)
            {
                cuidador.presentarse();
            }
        }





    }
    //clase cuidador
    class Cuidador
    {
        public string nombre { get; set; }
        public List<Animal> animalesACargo;

        public Cuidador(string nombre, List<Animal> animalesACargo)
        {
            this.nombre = nombre;
            this.animalesACargo = animalesACargo;


        }
        public Cuidador(string nombre)
        {
            this.nombre = nombre;
            this.animalesACargo = new List<Animal>(); // Inicializar la lista

        }
        public void asignarAnimal(Animal animal)
        {
            animalesACargo.Add(animal);
        }
        public void alimentar()
        {
            foreach (var animal in animalesACargo)
            {
                Console.WriteLine($"- {nombre} está alimentando a {animal.nombre}");
                animal.comer();
            }
        }
        public void listarAnimalesACargo()
        {
            Console.WriteLine($"- animales a cargo de {nombre}:");
            foreach (Animal animal in animalesACargo)
            {
                Console.WriteLine($"{animal.nombre} ");
            }
        }
        public void presentarse()
        {
            Console.WriteLine($"{nombre} ");

        }


    }
    //super clase animal
    class Animal : IAnimal
    {
        public string nombre { get; set; }
        public string especie { get; set; }
        public string comida { get; set; }

        public Animal(string nombre,string especie,string comida)
        {

            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;

        }
        
        public string getNombre()
        {
            return this.nombre;
        }
        public string getComida()
        {
            return this.comida;
        }
        public string getEspecie()
        {
            return this.especie;
        }
        virtual public void comer()
        {
            Console.WriteLine($"{nombre} está comiendo {comida}");
        }
        virtual public void presentarse()
        {
            Console.Write($"{nombre} ");

        }


    }
    //subclase planta carnivora
    class PlantaCarnivora : Animal
    {

        public string nombre { get; set; }
        public string tipo { get; set; }
        public string tipoCarnivoro { get; set; }

        public PlantaCarnivora(string nombre, string especie, string comida, string tipo, string tipoCarnivoro) : base(nombre, especie, comida) {
            tipo = tipo;
            tipoCarnivoro = tipoCarnivoro;
        }
        
        public string getNombre()
        {
            return this.nombre;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public string getTipoCarnivoro()
        {
            return this.tipoCarnivoro;
        }
        public void comer(Animal animal)
        {
            Console.WriteLine($"{nombre} está atrapando y comiendo un {animal.nombre}");
        }
        virtual public void presentarse()
        {
            Console.Write($"{nombre} ");

        }


    }
    //subclase mamifero
    class Mamifero : Animal
    {

        public Mamifero(string nombre, string especie, string comida) : base(nombre, especie, comida) { }


        public void Amamantar()
        {
            Console.WriteLine("{0} puede amamantar", this.nombre);
        }

        public override void presentarse()
        {
            this.Amamantar();
        }
    }
    //subclase ave
    class Ave : Animal
    {
        public Ave(string nombre, string especie, string comida) : base(nombre, especie, comida) { }

        public override void presentarse()
        {
            this.Volar();
        }

        public void Volar()
        {
            Console.WriteLine("{0} vuela como un ave", this.nombre);
        }
    }
    //subclase pez
    class Pez : Animal
    {
        public Pez(string nombre, string especie, string comida) : base(nombre, especie, comida) { }

        public override void presentarse()
        {
            this.Nadar();
        }
        public void Nadar()
        {
            Console.WriteLine("{0} nada como un pez", this.nombre);
        }
    }
    //interfaz animal
    interface IAnimal{

         void comer();
         void presentarse();


    }
}