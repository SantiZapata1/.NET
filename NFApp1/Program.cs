using System;
using System.Threading;
using Windows.Devices.Gpio;

public class Program
{
    // Definir pines
    private const int LedPin = 2;

    public static void Main()
    {
        // Configurar el pin del LED
        GpioController gpioController = GpioController.GetDefault();
        GpioPin led = gpioController.OpenPin(LedPin);
        led.SetDriveMode(GpioPinDriveMode.Output);

        // Bucle principal
        while (true)
        {
            // Alternar LED
            led.Write(led.Read() == GpioPinValue.High ? GpioPinValue.Low : GpioPinValue.High);

            // Esperar 2 segundos
            Thread.Sleep(2000);
        }
    }
}
