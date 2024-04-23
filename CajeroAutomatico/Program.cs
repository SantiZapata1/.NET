/*Desarrolle una aplicación en C#, para un cajero automático:
 * 
 * La aplicación permitirá crear cuentas para jubilados y personas en actividad. 
 * Los usuarios del cajero podrán depositar en su cuenta y realizar extracciones de la misma. 
 * Si el usuario es una persona en actividad laboral podrá retirar hasta, 20000 pesos en concepto de adelanto de sueldo. 
 * Si el usuario es una persona jubilada podrá retirar en concepto de adelanto solo 10000. 
 * Cada operación de ingreso o extracción deberá registrar la fecha, el cajero y el monto de la operación. 
 * Los cajeros se identifican por su dirección y número de cajeros. 
 * Si durante dos meses de operación un usuario tubo un saldo positivo superior a 20000 pesos, se le ofrecerá un crédito pre acordado de 80000 pesos. 
 * Con lo cual, su nuevo límite de extracción en negativo será de, 80000 pesos.*/

using System;
using System.Collections.Generic;
using System.Threading;

namespace CajeroAutomatico
{
    class Program
    {
        //metodo principal
        static void Main(string[] args)
        {

            Cajero nuevoCajero = new Cajero("Sarmiento 110", 5);
            bool salir = true;

            Console.WriteLine("------------ Bienvenido al cajero automático! ------------\n");


            while (salir)
            {
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Extraer dinero");
                Console.WriteLine("3. depositar dinero");

                Console.WriteLine("5. Salir");

                Console.Write("\n Ingrese su opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //pedimos los datos al usuario para crear un nuevo usuario y nueva cuenta bancaria
                        Console.Write("\nIngrese su nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese su dirección: ");
                        string direccion = Console.ReadLine();

                        Console.Write("Elija el tipo de usuario 1(jubi) o 2(en actividad): ");
                        int tipoUS = int.Parse(Console.ReadLine());
                        string a="";
                        if (tipoUS==2) {
                             a = "actividad";
                        }
                        else if (tipoUS==1)
                        {
                            a = "jubilado";

                        }


                        Console.Write("Ingrese su saldo actual:");
                        int saldoActual = int.Parse(Console.ReadLine());

                        Usuario nuevoUsuario = new Usuario(nombre, direccion, a);
                        nuevoCajero.CrearCuenta(saldoActual, nuevoUsuario);
                        nuevoCajero.MostrarCuentas();
                        break;
                    case "2":

                        Console.WriteLine("Ingrese el número de cuenta:");
                        int numeroCuenta = int.Parse(Console.ReadLine());

                        // Buscar la cuenta en la lista
                        CuentaBancaria cuentaEncontrada = nuevoCajero.BuscarCuenta(numeroCuenta);

                        if (cuentaEncontrada != null)
                        {
                            Console.WriteLine($"Cuenta encontrada: {cuentaEncontrada.NroCuenta}");
                            // Realizar operaciones con la cuenta

                            if (cuentaEncontrada.Usuario.TipoUs == "actividad")
                            {
                                Console.WriteLine("\nUsted tiene una cuenta en actividad, ingrese cuanto desea retirar por adelantado (max 20000):");
                                int montoRetirar = int.Parse(Console.ReadLine());
                                cuentaEncontrada.Extraccion(montoRetirar);
                                cuentaEncontrada.MostrarOperaciones();


                            }
                            else if(cuentaEncontrada.Usuario.TipoUs == "jubilado")
                            {
                                Console.WriteLine("\nUsted tiene una cuenta de jubilado, ingrese cuanto desea retirar por adelantado (max 10000):");
                                int montoRetirar = int.Parse(Console.ReadLine());
                                cuentaEncontrada.Extraccion(montoRetirar);
                                cuentaEncontrada.MostrarOperaciones();

                            }



                        }
                        else
                        {
                            Console.WriteLine("No se encontró la cuenta.");
                        }




                        break;
                        case "3":

                        Console.WriteLine("Ingrese el número de cuenta:");
                        int numeroCuenta2 = int.Parse(Console.ReadLine());

                        // Buscar la cuenta en la lista
                        CuentaBancaria cuentaEncontrada2 = nuevoCajero.BuscarCuenta(numeroCuenta2);

                        if (cuentaEncontrada2 != null)
                        {
                            Console.WriteLine($"Cuenta encontrada: {cuentaEncontrada2.NroCuenta}");
                            // Realizar operaciones con la cuenta

                            Console.WriteLine("\ningrese monto a depositar:");
                            int montoDepositar = int.Parse(Console.ReadLine());
                            cuentaEncontrada2.Deposito(montoDepositar);
                            cuentaEncontrada2.MostrarOperaciones();

                        }


                        else
                        {
                            Console.WriteLine("No se encontró la cuenta.");
                        }


                        break;

                    case "5":
                        Console.WriteLine("Gracias por utilizar el cajero automático. ¡Hasta luego!");
                        salir = false; // Salir del bucle while
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }

    //clase cajero
    class Cajero
    {
        public string Direccion { get; set; }
        public int NroCajero { get; set; }
        public List<CuentaBancaria> ListaCuentas { get; set; }

        public Cajero(string direccion, int nroCajero)
        {
            Direccion = direccion;
            NroCajero = nroCajero;
            ListaCuentas = new List<CuentaBancaria>();
        }

        public void CrearCuenta(int saldoActual, Usuario usuario)
        {
            CuentaBancaria nuevaCuenta = new CuentaBancaria(saldoActual, usuario);
            ListaCuentas.Add(nuevaCuenta);
        }

        public void MostrarCuentas()
        {
            Console.WriteLine("\nCuentas bancarias en el cajero:");
            foreach (var cuenta in ListaCuentas)
            {
                Console.WriteLine($"Número de cuenta: {cuenta.NroCuenta}");
                Console.WriteLine($"Saldo actual: {cuenta.SaldoActual}");
                Console.WriteLine($"Usuario: {cuenta.Usuario.Nombre}");
                Console.WriteLine($"Tipo de usuario: {cuenta.Usuario.TipoUs}");

                Console.WriteLine("------------------------");
            }
        }
        public CuentaBancaria BuscarCuenta(int numeroCuenta)
        {
            foreach (var cuenta in ListaCuentas)
            {
                if (cuenta.NroCuenta == numeroCuenta)
                {
                    return cuenta;
                }
            }
            return null;
        }

    }

    class CuentaBancaria
    {
        private static int _nroCuenta = 1;

        public int NroCuenta { get; set; }
        public int SaldoActual { get; set; }
        public DateTime FechaApertura { get; set; }
        public Usuario Usuario { get; set; }
        public List<Operacion> ListaOperaciones { get; set; }

        public CuentaBancaria(int saldoActual, Usuario usuario)
        {
            NroCuenta = _nroCuenta++;
            SaldoActual = saldoActual;
            FechaApertura = DateTime.Now;
            Usuario = usuario;
            ListaOperaciones = new List<Operacion>();
        }

        public void Deposito(int monto)
        {
            SaldoActual += monto;
            RegistrarOperacion("Depósito", monto);
        }

        public void Extraccion(int monto)
        {
            if (Usuario.TipoUs == "jubilado" && monto > 10000)
            {
                Console.WriteLine("Los jubilados solo pueden extraer hasta 10000 pesos.");
                return;
            }
            if (Usuario.TipoUs == "actividad" && monto > 20000)
            {
                Console.WriteLine("Las personas en actividad solo pueden extraer hasta 20000 pesos.");
                return;
            }

            //a esto le falta que calcule si pasaron los 2 meses
            if (SaldoActual - monto < -80000)
            {
                Console.WriteLine("Su límite de extracción en negativo es de 80000 pesos.");
                return;
            }

            SaldoActual -= monto;
            RegistrarOperacion("Extracción", monto);
        }

        private void RegistrarOperacion(string tipoOperacion, int monto)
        {
            Operacion nuevaOperacion = new Operacion(DateTime.Now, tipoOperacion, monto);
            ListaOperaciones.Add(nuevaOperacion);
        }
        public void MostrarOperaciones()
        {
            Console.WriteLine("\nOperaciones en esta cuenta bancaria:");
            foreach (var operacion in ListaOperaciones)
            {
                Console.WriteLine($"fecha operacion: {operacion.Fecha}");
                Console.WriteLine($"tipo de operacion: {operacion.TipoOperacion}");
                Console.WriteLine($"monto: {operacion.Monto}");
                Console.WriteLine("------------------------");
            }
        }
    }

    class Usuario
    {
        private static int _id = 1;

        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TipoUs { get; set; } // jubilado o en actividad

        public Usuario(string nombre, string direccion, string tipoUs)
        {
            Id = _id++;
            Nombre = nombre;
            Direccion = direccion;
            TipoUs = tipoUs;
        }
    }

    class Operacion
    {
        public DateTime Fecha { get; set; }
        public string TipoOperacion { get; set; } // depósito, extracción
        public int Monto { get; set; }

        public Operacion(DateTime fecha, string tipoOperacion, int monto)
        {
            Fecha = fecha;
            TipoOperacion = tipoOperacion;
            Monto = monto;
        }
    }
}



