using System.Collections;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private int v1;
        private int v2;
        private double resul;
        int operacion;
        bool modo = false;
        DateTime date1;
        DateTime date2;

        ArrayList arrayList;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("holadesdeconsola");
            arrayList = new ArrayList();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            modo = false;
            tb.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb.Text += "2";
            modo = false;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tb.Text += "3";
            modo = false;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tb.Text += "4";
            modo = false;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tb.Text += "5";
            modo = false;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tb.Text += "6";
            modo = false;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tb.Text += "7";
            modo = false;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tb.Text += "8";
            modo = false;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tb.Text += "9";
            modo = false;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tb.Text += "0";
            modo = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            tb.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        //operadores
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;

            int.TryParse(tb.Text, out v1);
            tb.Text = "";




        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;

            int.TryParse(tb.Text, out v1);

            tb.Text = "";

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            int.TryParse(tb.Text, out v1);

            tb.Text = "";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            int.TryParse(tb.Text, out v1);

            tb.Text = "";

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {


            if (modo == true)
            {

                // Obtener las fechas seleccionadas
                date1 = dateTimePicker1.Value;
                date2 = dateTimePicker2.Value;

                // Calcular la diferencia entre las dos fechas
                TimeSpan difference = date2 - date1;


                tb.Text = $"{difference.Days.ToString()} dias";

                string elemento = date1.ToShortDateString() + " - " + date2.ToShortDateString() + " = " + difference.Days.ToString() + " dias";

                Console.WriteLine(elemento);

                arrayList.Add(elemento);

            }
            else if (modo == false)
            {
                string elemento = "";
                int.TryParse(tb.Text, out v2);

                if (operacion == 1)
                {
                    resul = v1 + v2;
                    elemento = v1.ToString() + " + " + v2.ToString() + " = " + resul.ToString();


                }
                else if (operacion == 2)
                {
                    resul = v1 - v2;
                    elemento = v1.ToString() + " - " + v2.ToString() + " = " + resul.ToString();


                }
                else if (operacion == 3)
                {
                    resul = v1 * v2;
                    elemento = v1.ToString() + " * " + v2.ToString() + " = " + resul.ToString();


                }
                else if (operacion == 4)
                {
                    resul = v1 / v2;
                    elemento = v1.ToString() + " / " + v2.ToString() + " = " + resul.ToString();


                }

                Console.WriteLine(elemento);
                arrayList.Add(elemento);

                tb.Text = resul.ToString();
            }





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            modo = true;
            date1 = dateTimePicker1.Value;
            tb.Text = date1.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            modo = true;
            date2 = dateTimePicker2.Value;
            tb.Text = date2.ToString();

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Construir la cadena con los detalles de los libros
            string calculos = " ";
            
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                calculos += item.ToString() + "\n";
            }
            MessageBox.Show(calculos, "Historial de calculos");

        }
    }
}
