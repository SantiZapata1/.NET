using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAdoNet
{
    internal class peopleBD
    {

        //string de coneccion
        public string connectionString =
            "Data Source =DESKTOP-IDOQ938;" +
            "Initial Catalog=crudWindFoms;" +
            "Integrated Security=True;"
            ;

        //metodo para verificar conecicon
        public bool Ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }

        //metodo para obtener lista de personas de la BD
        public List<People> Get()
        {
            
            List<People> people = new List<People>();

            string query = "select id,name,age from people2";

            //objeto conexion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //objeto comando
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();

                    //objeto reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //leemos linea por linea el reader y vamos agregando las personas a la lista
                        while (reader.Read())
                        {
                            People newPeople = new People();

                            newPeople.Id = reader.GetInt32(0);
                            newPeople.Name = reader.GetString(1);
                            newPeople.Age = reader.GetInt32(2);

                            people.Add(newPeople);

                        }
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }

            }

            return people;

        }

        //metodos para agregar una nueva persona
        public void Add(string name, int age)
        {

            string query =
                "insert into people2(name,age) values" +
                "(@name,@age)";

            //objeto conexion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //objeto comando
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }

            }

        }

        //metodo que retorna la persona encontrada con el id  indicado
        public People Get(int id)
        {

            string query = "select id,name,age from people2 where id=@id";

            //objeto conexion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //objeto comando
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id",id);

                try
                {
                    connection.Open();

                    //objeto reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //leemos linea por linea el reader y vamos agregando las personas a la lista
                        reader.Read();

                        People newPeople = new People();

                        newPeople.Id = reader.GetInt32(0);
                        newPeople.Name = reader.GetString(1);
                        newPeople.Age = reader.GetInt32(2);

                        return newPeople;


                    
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;

                }

            }


        }

        //metodo que actualiza los datos de una fila indicada con el id

        public void Update(int id, string name, int age)
        {

            string query =
                "update people2 set name=@name, age=@age  where id=@id";

            //objeto conexion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //objeto comando
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }

            }

        }

        //metodo que elimina el elemento indicado con el id
        public void Delete(int id)
        {

            string query =
                "delete from people2 where id=@id";

            //objeto conexion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //objeto comando
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }

            }




        }


    }


    //clase persona
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
 
    }

}
