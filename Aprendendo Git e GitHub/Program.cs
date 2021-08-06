using Aprendendo_Git_e_GitHub.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Git_e_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Teste01 t1 = new Teste01("Ola mundo de Teste01");
            t1.MostrarMensagem();
            Teste02 t2 = new Teste02(3, 5);
            Console.ReadLine();
        }
    }
}