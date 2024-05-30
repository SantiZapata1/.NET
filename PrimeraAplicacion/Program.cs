//Objetivo: Comprender el uso de variables, asignaciones y operaciones de forma simple en C#.

//Cree una aplicación de consola
//Solicite el ingreso de dos valores por pantalla
//Al final muestre en forma descriptiva los resultados de aplicar las cuatro operaciones básicas

Console.Write("Ingrese el primer valor:");
string firtsInput = Console.ReadLine();
int firstNum = int.Parse(firtsInput);


Console.Write("Ingrese el segundo valor:");
string secondInput = Console.ReadLine();
int secondNum = int.Parse(secondInput);


int resultAdd = firstNum + secondNum;
int resultSub = firstNum - secondNum;
int resultMul = firstNum * secondNum;
int resultDiv = firstNum / secondNum;

Console.WriteLine("resultado suma: "+ resultAdd);
Console.WriteLine("resultado resta: "+resultSub);
Console.WriteLine("resultado multiplicacion: "+resultMul);
Console.WriteLine("resultado division: "+resultDiv);
Console.ReadKey();
