using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario dos números
        Console.Write("Introduce el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones
        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;
        double division;

        // Evitar la división por cero
        if (numero2 != 0)
        {
            division = numero1 / numero2;
            Console.WriteLine($"División: {division}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }

        // Mostrar los resultados
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
    }
}
