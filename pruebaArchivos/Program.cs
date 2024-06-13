
string path = @"C:\Users\Usuario\Documents\.NET\IoT.NET";
DirectoryInfo d = new DirectoryInfo(path);

FileInfo[] files = d.GetFiles();


FileInfo f = new FileInfo(@"C:\Users\Usuario\Documents\archivos\texto.txt");
FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);


//using (StreamWriter sw = new StreamWriter(fs))
//{

//    sw.WriteLine("holaaa");
//    sw.WriteLine("holaaa");
//    sw.WriteLine("holaaa");
//    sw.WriteLine("holaaa");
//    sw.WriteLine("holaaa");


//}

string[] palabras= new string[10];
int i = 0;

using (StreamReader sr = new StreamReader(fs))
{
    string contenido = null;
    while ((contenido = sr.ReadLine()) != null)
    {
        palabras[i] = contenido;
        i++;
    }
}


for (i = 0; i < palabras.Length; i++)
{
    Console.WriteLine(palabras[i]);
}