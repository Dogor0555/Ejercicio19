using System;

class Program
{
    // Función que recibe un número entero y determina si es par o impar
    static void DeterminarParImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un número impar.");
        }
    }

    static void Main(string[] args)
    {
        // Solicitar un número al usuario
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        // Llamar a la función para determinar si el número es par o impar
        DeterminarParImpar(numero);
    }
}
