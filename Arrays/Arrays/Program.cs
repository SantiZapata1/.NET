// Declaración e inicialización de un array de enteros con 5 elementos
int[] numeros = new int[5];

// Asignación de valores a los elementos del array
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Acceso a los elementos del array y uso en una operación
int suma = numeros[0] + numeros[2] + numeros[4];

//Length: Propiedad que devuelve el número total de elementos en el array.
int[] numeros2 = new int[5];

//CopyTo(Array arrayDestino, int indice): Copia todos los elementos
//del array actual en otro array, comenzando en el índice especificado.

int[] numeros3 = { 1, 2, 3, 4, 5 };
int[] copia = new int[5];
numeros.CopyTo(copia, 0); // Copiar todos los elementos de 'numeros' en 'copia' desde el índice 0

//Sort(Array array): Ordena los elementos en un array.
int[] numeros4 = { 5, 3, 1, 4, 2 };
Array.Sort(numeros); // Ordenar los elementos de 'numeros' de menor a mayor

//IndexOf(Array array, object valor): Devuelve el índice de la primera aparición de un valor en un array, o -1 si no se encuentra.
int[] numeros5 = { 10, 20, 30, 40, 50 };
int indice = Array.IndexOf(numeros, 30); // Devuelve 2

int[] prueba = {};
Console.WriteLine(prueba.Length);