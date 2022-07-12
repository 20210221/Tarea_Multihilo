using System;
using System.Threading;

namespace TareaMultihilo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("**Programación Multihilo**");

            Thread FirstHilo = new Thread(PrimerHilo);

            FirstHilo.Start();

            Thread SecondHilo = new Thread(SegundoHilo);

            SecondHilo.Start();

        }

        static void PrimerHilo()
        {
            Console.WriteLine("\n --Conoce Tu Año De Nacimiento--");
           
        }

        static void SegundoHilo()
        {
            Console.WriteLine(" \n Introduzca Su Edad: ");

            int Date = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Celebró Su Cumpleaños Este Año? S o N");

            String BD = Console.ReadLine();

            int DataWBD = 2022 - Date;

            int DataNBD = 2022 - Date - 1;


            if (BD == "S" || BD == "s")
            {
                Console.WriteLine("\n Su Año De Nacimiento Es: " + DataWBD);
            }

            else
            {
                Console.WriteLine("\n Su Año De Nacimiento Es: " + DataNBD);
            }

            Console.WriteLine("\n Presione Cualquier Tecla Para Finalizar...");

            Console.ReadLine();
        }


    }
}
