using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operadores:Variables
    {
        public void Sumar()
        {
            Resultado = V1 + V2;

        }

        public void Restar()
        {
            Resultado = V1 - V2;
        }
        public void Operar()
        {
            Console.WriteLine(Resultado);
        }
    }
}
