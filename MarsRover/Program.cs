using Mars;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plato x konum sınırını giriniz: ");
            int xlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plato y konum sınırını giriniz: ");
            int ylimit = Convert.ToInt32(Console.ReadLine());
            Plato plato = new Plato(xlimit, ylimit);

            Console.ReadLine();

        }
    }
}
