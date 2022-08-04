using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("El animal hace sonidos");
        }
    }
    
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("El cerdo hace : Oink , Oink ");
        }
    }
    
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("El perro hace :bow bow");
        }
    }
}
