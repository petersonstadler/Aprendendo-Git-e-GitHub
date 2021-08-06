using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Git_e_GitHub.Classes
{
    class Teste01
    {
        private string mensagem;

        public Teste01(string msg)
        {
            mensagem = msg;
        }

        public void MostrarMensagem()
        {
            Console.WriteLine(mensagem);
        }
    }
}
