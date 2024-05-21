using System;

int[] arregloInt = {1,4,2,6,3,7,4};
recorrer(arregloInt);
agregar(ref arregloInt, 5);
recorrer(arregloInt);
eliminar(ref arregloInt, 2);
recorrer(arregloInt);




Console.WriteLine();
//si el metodo es estatico y pasamos el arreglo como parametro debe ser por referencia
//si es un metodo del objeto no hace falta que sea estatico ni pasar el arreglo por referencia
static void agregar(ref int[] arreglo, int elemento)
{

    int[] nuevoArreglo = new int[arreglo.Length+1];
    arreglo.CopyTo(nuevoArreglo, 0);
    nuevoArreglo[nuevoArreglo.Length-1] = elemento;
    arreglo = nuevoArreglo;

}
static void eliminar(ref int[] arreglo, int indice)
{

    int[] nuevoArreglo = new int[arreglo.Length - 1];

    int k = 0;
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (i == indice) continue;
        nuevoArreglo[k++] = arreglo[i];
    }
    arreglo = nuevoArreglo;



}


static void recorrer(int[] arreglo)
{
    Console.Write($"{arreglo.Length} elementos: ");

    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.Write($"{arreglo[i]} ");
    }
    Console.WriteLine("");

}