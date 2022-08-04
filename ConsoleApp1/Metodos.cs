using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Metodos
    {
        int d1, d2, d3;
        public void imprimirResultado()
        {
            if (d1 == d2 && d2 == d3)
            {
                Console.WriteLine("Has ganado, agárrame el premio");
                Console.WriteLine("8======D");
            }
            else
            {
                Console.WriteLine("Perdiste wey");
            }

        }
        public void imprimirValores()
        {
            Console.WriteLine("Dado 1 :" + d1);
            Console.WriteLine("Dado 2 :" + d2);
            Console.WriteLine("Dado 3 :" + d3);
        }
        public void aleatorio()
        {
            Random rand = new Random();
            d1 = rand.Next(1, 7);
            d2 = rand.Next(1, 7);
            d3 = rand.Next(1, 7);
        }
    }
}
