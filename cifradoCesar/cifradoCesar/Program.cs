using System;

char algoritmoCesar(char letra, int vecesAAplicar, string abecedario)
{
    if (letra == ' ')
    {
        return ' ';
    }
    //Encontrar una letra en un string y devolver su posición
    int posicion = abecedario.IndexOf(letra);
    int i = 0;
    while (i < vecesAAplicar)
    {
        if (posicion == abecedario.Length - 1)
        {
            posicion = -1;
        }
        posicion++;
        i++;
    }
    letra = abecedario[posicion];
    return letra;
}

String abecedarioCaesar = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
//El número es 12 en el segundo 0:26
int vecesAAplicar = 12;
String frase = "kd wiqd géuúi tédbbúnq kdq wiqd iúígédíqsybyuqu";
String fraseConAlgoritmo = "";


for (int j = 0; j < frase.Length; j++)
{
    char remplazo = algoritmoCesar(frase[j], vecesAAplicar, abecedarioCaesar);
    fraseConAlgoritmo += remplazo;
}

Console.WriteLine(fraseConAlgoritmo);