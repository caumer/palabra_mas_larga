using System;

namespace palabra_mas_larga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera palabra a comparar");
            string primeraPalabra = Console.ReadLine();
            Console.WriteLine("\nIngrese la segunda palabra a comparar");
            string segundaPalabra = Console.ReadLine();

            int cantidadPrimera = primeraPalabra.Length;
            int cantidadSegunda = segundaPalabra.Length;

            int diferencia = cantidadPrimera - cantidadSegunda;

            if (diferencia == 0)
            {
                Console.WriteLine("\nLa palabra {0} tiene el mimo largo que {1}", segundaPalabra, primeraPalabra);
            }
            else
            {
                if (diferencia < 0)
                {
                    diferencia = diferencia * -1;
                    Console.WriteLine("\nLa palabra {0} tiene {1} letras mas que {2}", segundaPalabra, diferencia, primeraPalabra);
                }
                else
                {
                    Console.WriteLine("\nLa palabra {0} tiene {1} letras mas que {2}", primeraPalabra, diferencia, segundaPalabra);
                }
            }


           
        }
    }
}
