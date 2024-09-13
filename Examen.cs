// Buenas tardes profesor, primero que nada le recuerdo que soy el estudiante de la mac
// por lo que no tengo posibilidades de hacer el form, este seria el codigo que se ejecutaria en consola. 

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int maxNotas = 1000;
        double[] notas = new double[maxNotas];
        int cantidadNotas = 0;
        double sumaNotas = 0;

        Console.WriteLine("Ingrese las notas de los estudiantes. Ingrese una nota negativa para finalizar:");

        while (cantidadNotas < maxNotas)
        {
            Console.Write("Ingrese una nota: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double nota) && nota >= 0)
            {
                notas[cantidadNotas] = nota;
                sumaNotas += nota;
                cantidadNotas++;
            }
            else if (nota < 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor numérico válido.");
            }
        }

        if (cantidadNotas == 0)
        {
            Console.WriteLine("No se ingresaron notas.");
            return;
        }

        // Calcular el promedio
        double promedio = sumaNotas / cantidadNotas;
        Console.WriteLine($"El promedio de las notas es: {promedio:F2}");

        // Obtener los tres primeros lugares
        double[] notasOrdenadas = notas.Take(cantidadNotas).OrderByDescending(n => n).ToArray();

        Console.WriteLine("Los tres primeros lugares son:");
        for (int i = 0; i < 3 && i < cantidadNotas; i++)
        {
            Console.WriteLine($"Lugar {i + 1}: {notasOrdenadas[i]}");
        }
    }
}
