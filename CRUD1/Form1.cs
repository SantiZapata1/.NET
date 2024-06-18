using CrudAdoNet;
using System.Data.SqlClient;

namespace CRUD1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //metodo para actualizar la base de datos
        private void refresh()
        {
            peopleBD peopleBD = new peopleBD();
            dataGridView1.DataSource = peopleBD.Get();

        }

        //al hacer click en agregar, desplegamos el form para eso
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            refresh();

        }

        #region HELPER
        public int? GetID()
        {

            try
            {   //retorna el primer valor de la fila que este seleccionada (ID)
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }


        }
        #endregion

        /*
         Tanto en el boton editar y eliminar se invoca al metodo que accede al id de la fila seleccionada y realiza sus procesos
         */


        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = GetID();

            if (id != null)
            {
                Form2 formEdit = new Form2(id);
                formEdit.ShowDialog();
                refresh();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            try
            {
                if (id != null)
                {
                    peopleBD peopleBD = new peopleBD();
                    peopleBD.Delete((int)id);
                    refresh();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }

            
        }
    }


}
