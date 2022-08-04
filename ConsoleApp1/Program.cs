using System;
//using System.Windows.Forms;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal perro = new Dog();
            Animal Cerdo = new Pig();
            Dados dados = new Dados();
            dados.Lanzar();

        }
    }
}//programa implementando suma y resta 
//atributo v1, v2 y res y metodo operar