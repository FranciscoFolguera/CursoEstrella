using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario dos n�meros
        Console.Write("Introduce el primer n�mero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo n�mero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones
        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;
        double division;

        // Evitar la divisi�n por cero
        if (numero2 != 0)
        {
            division = numero1 / numero2;
            Console.WriteLine($"Divisi�n: {division}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }

        // Mostrar los resultados
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicaci�n: {multiplicacion}");
    }
}
