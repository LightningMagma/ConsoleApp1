using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dados:Metodos
    {        
        public void Lanzar()
        {
            string i = "1";
            do
            {
                aleatorio();
                imprimirValores();
                imprimirResultado();
                i = Console.ReadLine();
            } while (i == "");
            Console.Read();
        }
        
    }
}
