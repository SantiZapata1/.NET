using CRUD1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAdoNet
{
    public partial class Form2 : Form
    {
        int? id;

        //cuando se crea el form 2 puede o no tener el parametro id segun la funcion
        public Form2(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if(id != null)
            {
                loadData();
            }
        }

        //carga en el formulario la informacion de la persona seleccionada
        private void loadData()
        {
            peopleBD peopleBD = new peopleBD();
            People people = peopleBD.Get((int)id);
            textBox1.Text = people.Name;
            textBox2.Text = people.Age.ToString();
        }


        //si el formulario se cargo con un id se ejecuta editar, sino se ejecuta agregar
        private void button1_Click(object sender, EventArgs e)
        {
            peopleBD peopleBD = new peopleBD();

            try
            {

                if (id==null)
                {
                    peopleBD.Add(textBox1.Text, int.Parse(textBox2.Text));
                }
                else
                {
                    peopleBD.Update((int)id, textBox1.Text, int.Parse(textBox2.Text));
                }


                this.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }



        }
    }
}
