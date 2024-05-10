//aleatoriamente se elije una cuenta
//durante 100 iteraciones se elige aleatoriamente entre extraer y depositar
//aleatoriamente se elige el monto

//cuentas de ahorro
CuentaAhorro cuentaAhorro1 = new CuentaAhorro("Santi", 45044392, 10000);
Console.WriteLine(cuentaAhorro1);

CuentaAhorro  cuentaAhorro2= new CuentaAhorro("pepo", 45045318, 2000);
Console.WriteLine(cuentaAhorro2);

CuentaAhorro cuentaAhorro3 = new CuentaAhorro("luli", 45044392, 20000);
Console.WriteLine(cuentaAhorro3);

//cuentas corriente
CuentaCorriente cuentaCorriente1 = new CuentaCorriente("juana", 23044392, 5000, 1000);
Console.WriteLine(cuentaCorriente1);

CuentaCorriente cuentaCorriente2 = new CuentaCorriente("pedro", 23044392, 10000, 7000);
Console.WriteLine(cuentaCorriente2);

CuentaCorriente cuentaCorriente3 = new CuentaCorriente("laura", 23044392, 2000, 3000);
Console.WriteLine(cuentaCorriente3);


cuentaAhorro1.depositarDinero(10);
cuentaAhorro2.depositarDinero(30);

cuentaAhorro2.retirarDinero(2050);
cuentaCorriente1.retirarDinero(4000);

Cuenta[] listaCuentas = { cuentaAhorro1, cuentaAhorro2, cuentaAhorro3, cuentaCorriente1, cuentaCorriente2, cuentaCorriente3 };

Cajero cajero1 = new Cajero("nacion", listaCuentas);

cajero1.listarCuentas();

Cuenta cuentaAleatoria = cajero1.elegirCuenta();

Console.WriteLine($"\ncuenta elegida aleatoriamente: {cuentaAleatoria}");

cajero1.realizarTransaccionesAleatorias(cuentaAleatoria);

abstract class Cuenta
{
    static int contador = 0;
    int id;
    string nombre;
    int dni;
    public int saldo { get; set; }

    public Cuenta(string nombre, int dni, int saldo){
        this.nombre = nombre;
        this.dni = dni;
        this.saldo = saldo;
        this.id = ++contador;
    }
    public override string ToString()
    {
        return $"\nid:{id}, nombre:\"{nombre}\", dni:{dni}, saldo: ${saldo}";
    }

    public abstract void retirarDinero(int cantidad);
    public void depositarDinero(int cantidad){
        saldo += cantidad;
        Console.WriteLine($"\nnuevo saldo: ${saldo}");
    }



}

//si se extrae por adelantado se cobran descuentos sobre el extra.
//tiene un tope de extraccion
class CuentaCorriente:Cuenta
{
    int interes = 10;
    int topeDescubierto;

    public CuentaCorriente(string nombre, int dni, int saldo, int topeDescubierto):base(nombre, dni, saldo)
    {
        this.topeDescubierto = topeDescubierto;
    }
    public override void retirarDinero(int cantidad)
    {
        //si la cantidad a extraer esta bajo el tope
        if (cantidad<=topeDescubierto)
        {

            //si hay saldo
            if (saldo-cantidad>=0)
            {
                saldo -= cantidad;
                Console.WriteLine($"\nnuevo saldo ${saldo}");
            }
            else
            {
                //nose que tan eficiente sea esto
                Console.Write($"\nsaldo insuficiente, se desea retirar ${cantidad} y solo hay ${saldo}");
                int resto = cantidad - saldo;
                int recargo = resto * interes / 100;
                Console.WriteLine($", por los ${resto} faltantes, se aplica el interes de %{interes} resultando ${resto + recargo}.");
                int nuevaCantidad = saldo + resto + recargo;
                Console.WriteLine($"-total cobrado: ${nuevaCantidad}");
                saldo -= nuevaCantidad;
                Console.WriteLine($"-nuevo saldo: ${saldo}");
            }

        }
        else
        {
            Console.WriteLine($"\nel monto a retirar supera el tope descubierto que es de ${topeDescubierto}");
        }
        
    }


}


//no se puede extraer saldo negativo
class CuentaAhorro : Cuenta
{
   



    public CuentaAhorro(string nombre, int dni, int saldo) : base(nombre, dni, saldo)
    {

    }
    public override void retirarDinero(int cantidad)
    {
        if (saldo - cantidad < 0)
        {
            Console.WriteLine("\nno se puede retirar más dinero del disponible en una cuenta de ahorro.");
        }
        else
        {
            saldo -= cantidad;
            Console.WriteLine($"\nnuevo saldo ${saldo}");
        }


    }
}

class Cajero
{
    int id;
    static int contador = 0;
    string nombre;
    Cuenta[] listaCuentas;

    public Cajero(string nombre, Cuenta[] listaCuentas){
        id = ++contador;
        this.nombre = nombre;
        this.listaCuentas = listaCuentas;

    }
    public void listarCuentas()
    {
        Console.WriteLine("\nLista de cuentas:");

        foreach (Cuenta cuenta in listaCuentas)
        {
            Console.WriteLine(cuenta);
        }
    }

    public Cuenta elegirCuenta() {


        Random rnd = new Random();
        int indiceAleatorio = rnd.Next(0, listaCuentas.Length);

        return listaCuentas[indiceAleatorio];

    }

    public void realizarTransaccionesAleatorias(Cuenta cuenta)
    {
        Random rnd = new Random();
        int accionAleatoria;
        int montoAleatorio;

        for (int i = 0; i < 100; i++)
        {
            accionAleatoria = rnd.Next(0, 2);
            montoAleatorio = rnd.Next(0, 2001);

            if (accionAleatoria==0)
            {
                Console.Write($"\nDepositar ${montoAleatorio}");
                cuenta.depositarDinero(montoAleatorio);
            }
            else if (accionAleatoria==1)
            {
                Console.Write($"\nRetirar ${montoAleatorio}");
                cuenta.retirarDinero(montoAleatorio);
            }


        }


    }






}