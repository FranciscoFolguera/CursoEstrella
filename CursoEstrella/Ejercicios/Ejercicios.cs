namespace CursoEstrella.Ejercicios
{
    public class Ejercicios
    {
        #region Ejercicio Salario
        /*
         
         Ejercicio 1: Cálculo de impuestos según el salario
            Escribe un programa que calcule el impuesto sobre la renta de una persona en función de su salario anual. Las tasas de impuestos son las siguientes:

            Si el salario es menor o igual a $20,000, no se paga impuestos.
            Si el salario está entre $20,001 y $40,000, se paga un 10% sobre el monto que exceda los $20,000.
            Si el salario está entre $40,001 y $60,000, se paga un 20% sobre el monto que exceda los $40,000 más el impuesto correspondiente al tramo anterior.
            Si el salario es mayor a $60,000, se paga un 30% sobre el monto que exceda los $60,000 más los impuestos correspondientes a los tramos anteriores.
         */
        public static void ImpuestoSegunSalario()
        {
            Console.Write("Introduce tu salario anual: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double impuesto = 0;

            // Calcular el impuesto según los tramos
            if (salario <= 20000)
            {
                // No se paga impuestos si el salario es menor o igual a 20000
                impuesto = 0;
            }
            else if (salario <= 40000)
            {
                // Se paga un 10% sobre el monto que exceda los 20000
                impuesto = (salario - 20000) * 0.10;
            }
            else if (salario <= 60000)
            {
                // Se paga un 20% sobre el monto que exceda los 40000
                impuesto = (40000 - 20000) * 0.10 + (salario - 40000) * 0.20;
            }
            else
            {
                // Se paga un 30% sobre el monto que exceda los 60000
                impuesto = (40000 - 20000) * 0.10 + (60000 - 40000) * 0.20 + (salario - 60000) * 0.30;
            }

            // Mostrar el resultado del impuesto
            Console.WriteLine("Impuesto a pagar: $" + impuesto);
        }
        #endregion Ejercicio Salario
        public static void BuscarMinMax(ref float[] datos, ref float min, ref float max)
        {
            max = datos[0];
            min = datos[0];

            for (int i = 1; i < datos.Length; i++)
            {
                if (datos[i] > max)
                {
                    max = datos[i];
                }
                if (datos[i] < min)
                {
                    min = datos[i];
                }
            }
        }
        //Pedir al usuario que haga un login 
        private void ControllAcceso()
        {

            int usuario, pass;
            int intentos = 0;

            do
            {
                usuario = Convert.ToInt32(Console.ReadLine());
                pass = Convert.ToInt32(Console.ReadLine());

                if ((usuario != 12) || (pass != 1234))
                {
                    Console.WriteLine("Error de inicio de sesiÃ³n");
                    intentos++;
                }
            }
            while (((usuario != 12) || (pass != 1234)) && (intentos != 3));

            if ((usuario == 12) || (pass == 1234))
                Console.WriteLine("Inicio de sesiÃ³n correcto");

        }

        #region Ejercicio Alumnos

        /**
         Pedir al usuario que ingrese el número de estudiantes.
            Solicitar al usuario que ingrese la nota de cada estudiante (de 0 a 100) y almacenar las notas en un arreglo.
            Calcular y mostrar las siguientes estadísticas usando métodos (funciones):
            La nota media de la clase.
            La nota más alta.
            La nota más baja.
            El número de estudiantes que aprobaron (nota mayor o igual a 60).
            El número de estudiantes que reprobaron (nota menor a 60).
         */
        public void EjercicioAlumnos()
        {
            // 1. Solicitar el número de estudiantes
            Console.Write("Introduce el número de estudiantes: ");
            int numEstudiantes = Convert.ToInt32(Console.ReadLine());

            // 2. Crear un arreglo para almacenar las notas
            double[] notas = new double[numEstudiantes];

            // 3. Pedir al usuario que ingrese las notas
            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.Write($"Introduce la nota del estudiante {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // 4. Llamar a los métodos para calcular estadísticas y mostrar resultados
            Console.WriteLine($"Nota media: {CalcularMedia(notas)}");
            Console.WriteLine($"Nota más alta: {CalcularMaxima(notas)}");
            Console.WriteLine($"Nota más baja: {CalcularMinima(notas)}");
            Console.WriteLine($"Número de aprobados: {ContarAprobados(notas)}");
            Console.WriteLine($"Número de reprobados: {ContarReprobados(notas)}");
        }
        // Método para calcular la nota media
        static double CalcularMedia(double[] notas)
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            return suma / notas.Length;
        }

        // Método para calcular la nota máxima
        static double CalcularMaxima(double[] notas)
        {
            double maxima = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
            }
            return maxima;
        }

        // Método para calcular la nota mínima
        static double CalcularMinima(double[] notas)
        {
            double minima = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }
            return minima;
        }

        // Método para contar los aprobados (nota >= 60)
        static int ContarAprobados(double[] notas)
        {
            int aprobados = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 60)
                {
                    aprobados++;
                }
            }
            return aprobados;
        }

        // Método para contar los reprobados (nota < 60)
        static int ContarReprobados(double[] notas)
        {
            int reprobados = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 60)
                {
                    reprobados++;
                }
            }
            return reprobados;
        }
        #endregion Ejercicio Alumnos
    }
}
