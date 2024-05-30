using System.Reflection.Metadata.Ecma335;

string original = "Hello World";

string upper = original.ToUpper();
string lower = original.ToLower();

string[] split = original.Split(' ');

string join = string.Join(" ", split);

bool contains = original.ToLower().Contains("hello");

string replace = original.Replace("World", "people");

string insert="xd";

int indice=0;
bool hayError = true;
do
{
    Console.Write("ingrese la posicion que desea ingresa el texto: ");

    try
    {
        int.TryParse(Console.ReadLine(), out indice);

        insert = original.Insert(indice, " jaja ");//esto lanza a exception

        if (indice!=0)
        {
            hayError = false;

        }
        else
        {
            Console.WriteLine("errorrrr");
        }


    }
    catch (Exception e)
    {
        Console.WriteLine("ocurrio un error, intente otra vez.");
    }


} while (hayError);


Console.WriteLine(insert);




static void recorrerString(string[] arreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.Write(arreglo[i]);
    }
    Console.WriteLine(" ");

}