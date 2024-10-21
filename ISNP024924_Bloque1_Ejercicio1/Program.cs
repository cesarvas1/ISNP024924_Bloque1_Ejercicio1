using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }

        } while (numero != 0);

        Console.WriteLine("Programa terminado.");
    }
}