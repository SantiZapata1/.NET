using System;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Simon : Form
    {
        // Importa la función de la API de Windows para asignar una consola
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        // Importa la función de la API de Windows para liberar la consola
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();


        private void Form1_Load(object sender, EventArgs e) { }


        //constructor
        public Simon()
        {
            //inicializamos componentes graficos
            InitializeComponent();

            // Asigna una consola a la aplicación
            AllocConsole();

        }



        //enum para manejar ls diferentes momentos del juego con estados
        enum estadoJuego
        {
            iniciandoJuego,
            creandoSecuencia,
            mostrandoSecuencia,
            jugando,
            juegoTerminado
        }

        //el juego comienza en el estado de crear la primer secuencia de colores
        estadoJuego estadoActual = estadoJuego.iniciandoJuego;



        //variables
        static int nivelMax = 20;
        bool juegoOn = false;
        int nivelLogrado = 0;
        int seg = 0;
        int indexBotonActual = 0;
        int indice = 0;
        Button[] secuenciaBotones = new Button[nivelMax];


        //metodo principal para ejecutar los 3 estados posibles del simon
        void jugar()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"estado actual: {estadoActual}");

            if (estadoActual==estadoJuego.iniciandoJuego)
            {

                seg = 0;
                indexBotonActual = 0;
                nivelLogrado = 0;
                indice = 0;
                borrarSecuencia();
                Console.WriteLine("---------- INICIANDO JUEGO");
                estadoActual=estadoJuego.creandoSecuencia;
            }
            else if (estadoActual == estadoJuego.creandoSecuencia)
            {
                //en este estado, agregamos un color a la secuenia
                crearSecuencia();
            }
            else if (estadoActual == estadoJuego.mostrandoSecuencia)
            {
                //luego de crear la secuencia, la mostramos por consola y graficamente

                label5.Text = "mostrando secuencia";

                mostrarSecuenciaTerminal();

                mostrarSecuenciaGrafica();


            }
            else if (estadoActual == estadoJuego.jugando)
            {
                label5.Text = "hora de jugar";

                Console.WriteLine($"ingrese el {indexBotonActual} boton de la secuencia");


            }
            else if (estadoActual == estadoJuego.juegoTerminado)
            {
                label5.Text = "fin del juego";

            }

        }

        void borrarSecuencia()
        {
            for (int i = 0; i < secuenciaBotones.Length; i++)
            {
                secuenciaBotones[i] = null;
            }
        }

        //metodo para recorrer la secuencia de botones por consola
        void mostrarSecuenciaTerminal()
        {
            if (secuenciaBotones.Length <= 0)
            {
                Console.WriteLine("esta secuencia no tiene elementos");
            }
            else
            {
                Console.WriteLine("secuencia de botonces: ");
                for (int i = 0; i < secuenciaBotones.Length; i++)
                {
                    if (secuenciaBotones[i] == null)
                        Console.WriteLine($"{i}- null ");
                    else
                        Console.WriteLine($"{i}- {secuenciaBotones[i].BackColor} ");
                }
                Console.WriteLine();
            }
        }



        //metodo para asignar un nuevo boton aleatorio a la secuencia
        void crearSecuencia()
        {

            int i = 0;

            try
            {
                while (secuenciaBotones[i] != null)
                {
                    i++;
                }
                secuenciaBotones[i] = elegirBotonRandom();
                estadoActual = estadoJuego.mostrandoSecuencia;
            }
            catch (Exception e) { Application.Exit(); }

        }


        //metodo para retornar un boton de forma aleatoria
        private Button elegirBotonRandom()
        {
            int randomNumber = new Random().Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    return button1;
                    break;
                case 2:
                    return button2;
                    break;
                case 3:
                    return button3;
                    break;
                case 4:
                    return button4;
                    break;
                default:
                    break;
            }
            return null;
        }



        void mostrarSecuenciaGrafica()
        {

            if (secuenciaBotones[indice] != null && indice < secuenciaBotones.Length - 1)
            {
                //segun que boton sea el actual, se cambia de tono
                if (secuenciaBotones[indice].Name == "button1")
                {
                    button1.BackColor = Color.Green;
                }

                else if (secuenciaBotones[indice].Name == "button2")
                {
                    button2.BackColor = Color.Red;
                }

                else if (secuenciaBotones[indice].Name == "button3")
                {
                    button3.BackColor = Color.Yellow;
                }

                else if (secuenciaBotones[indice].Name == "button4")
                {
                    button4.BackColor = Color.Blue;
                }

                if (seg % 2 != 0)
                {
                    
                        if (secuenciaBotones[indice].Name == "button1")
                        {
                            button1.BackColor = Color.DarkGreen;
                        }

                        else if (secuenciaBotones[indice].Name == "button2")
                        {
                            button2.BackColor = Color.DarkRed;
                        }

                        else if (secuenciaBotones[indice].Name == "button3")
                        {
                            button3.BackColor = Color.Orange;
                        }

                        else if (secuenciaBotones[indice].Name == "button4")
                        {
                            button4.BackColor = Color.DarkBlue;
                        }

                    indice++;
                    

                }
         

            }
            else
            {
                estadoActual = estadoJuego.jugando;

            }




        }




        //eventos al cumplirse cada tick del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            string tiempoTranscurrido = $"{seg.ToString()} segs";
            label3.Text = tiempoTranscurrido;

            //ejecutamos el metodo para jugar al Simon

            if (juegoOn == true)jugar();
            else label5.Text = "inicie el juego";

        }

        void chequearClick(Button botonActual)
        {
            //si el juego esta en modo jugando
            if (estadoActual == estadoJuego.jugando)
            {
                //si acierta continua o gana
                if (secuenciaBotones[indexBotonActual] == botonActual)
                {
                    Console.WriteLine("acertaste!");

                    if (secuenciaBotones[indexBotonActual + 1] == null)
                    {
                        Console.WriteLine("creando nueva secuencia");

                        nivelLogrado++;
                        label2.Text = nivelLogrado.ToString();
                        estadoActual = estadoJuego.creandoSecuencia;
                        indexBotonActual = 0;
                        indice = 0;

                    }
                    else
                    {
                        indexBotonActual++;

                    }

                }
                else
                {
                    Console.WriteLine("erraste");
                    estadoActual = estadoJuego.juegoTerminado;
                    MessageBox.Show($"Perdiste, nivel logrado: {nivelLogrado}");

                }

            }
        }

        //eventos al hacer click en los botones
        private void button1_Click(object sender, EventArgs e){chequearClick(button1);}

        private void button2_Click(object sender, EventArgs e){chequearClick(button2);}

        private void button3_Click(object sender, EventArgs e){chequearClick(button3);}

        private void button4_Click(object sender, EventArgs e){chequearClick(button4);}
        

        private void button5_Click(object sender, EventArgs e)
        {
            juegoOn = true;
            estadoActual = estadoJuego.iniciandoJuego;
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

    }
}
