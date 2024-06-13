using System.Collections;

namespace juegoMemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            leerArchivo();
            cargarBotones();
            duplicarPalabras();
            asignarPalabrasABotones();
            setearAClaro();
        }

        
        //VARIABLES
        List<String> palabras = new List<string>();
        Button[] botones = new Button[20];

        void leerArchivo()
        {
            FileInfo f = new FileInfo(@"C:\Users\Usuario\Documents\archivos\texto.txt");
            FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamReader sr = new StreamReader(fs))
            {
                string contenido = null;

                while ((contenido=sr.ReadLine())!=null)
                {
                      palabras.Add(contenido);
                }

            }
        }



        


        int movimiento = 0;
        int cantMovimientos = 4;

        private void cargarBotones()
        {
            botones[0] = button1;
            botones[1] = button2;
            botones[2] = button3;
            botones[3] = button4;
            botones[4] = button5;
            botones[5] = button6;
            botones[6] = button7;
            botones[7] = button8;
            botones[8] = button9;
            botones[9] = button10;
            botones[10] = button11;
            botones[11] = button12;
            botones[12] = button13;
            botones[13] = button14;
            botones[14] = button15;
            botones[15] = button16;
            botones[16] = button17;
            botones[17] = button18;
            botones[18] = button19;
            botones[19] = button20;
        }

        private void duplicarPalabras()
        {
            for (int i = 0; i < 10; i++)
            {
                String nuevaPalabra = palabras[i];
                palabras.Add(nuevaPalabra);
            }
        }
        //hacer que sea random
        private void asignarPalabrasABotones()
        {
            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Text = palabras[i];


            }

        }

        //SETEAR
        private void setearAClaro()
        {

            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].BackColor = Color.White;


            }
            timer3.Start();
        }


        private void setearAOscuro()
        {
            for (int i = 0; i < botones.Length; i++)
            {

                if (botones[i].Enabled==true)
                {
                    botones[i].BackColor = Color.Black;

                }



            }

        }


        //TIMERS
        private void timer1_Tick(object sender, EventArgs e)
        {
            setearAOscuro();
            timer1.Stop();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            labelCantMoviminetos.Text = cantMovimientos.ToString();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            setearAOscuro();
            timer3.Stop();
        }


        //BOTONES

        Button btn1 = new Button();
        Button btn2 = new Button();

        private void cheackearMovimiento()
        {
            if (btn1.Text == btn2.Text)
            {
                btn1.BackColor = Color.Aqua;
                btn2.BackColor = Color.Aqua;
                btn1.Enabled = false;
                btn2.Enabled = false;
                listBox1.Items.Add(btn1.Text);
            }
            
        }

        private void logicaJuego(Button boton)
        {
            if (cantMovimientos>0)
            {
                boton.BackColor = Color.White;

                if (movimiento == 0)
                {
                    timer1.Stop();
                    movimiento++;//primer movimiento
                    btn1 = boton;

                }
                else if (movimiento == 1)
                {
                    movimiento = 0;
                    timer1.Start();
                    cantMovimientos--;
                    btn2 = boton;


                }
                cheackearMovimiento();
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("No hay mas intentos", "PERDISTE", MessageBoxButtons.RetryCancel );

                if  (respuesta == DialogResult.Retry)
                {

                }
                else if (respuesta==DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            logicaJuego(button1);



        }
        private void button2_Click(object sender, EventArgs e)
        {

            logicaJuego(button2);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            logicaJuego(button3);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            logicaJuego(button4);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            logicaJuego(button5);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            logicaJuego(button6);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            logicaJuego(button7);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            logicaJuego(button8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            logicaJuego(button9);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            logicaJuego(button10);


        }

        private void button11_Click(object sender, EventArgs e)
        {
            logicaJuego(button11);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            logicaJuego(button12);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            logicaJuego(button13);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            logicaJuego(button14);


        }

        private void button15_Click(object sender, EventArgs e)
        {
            logicaJuego(button15);


        }

        private void button16_Click(object sender, EventArgs e)
        {
            logicaJuego(button16);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            logicaJuego(button17);


        }

        private void button18_Click(object sender, EventArgs e)
        {
            logicaJuego(button18);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            logicaJuego(button19);


        }

        private void button20_Click(object sender, EventArgs e)
        {
            logicaJuego(button20);


        }


    }
}
