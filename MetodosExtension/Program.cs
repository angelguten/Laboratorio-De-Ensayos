using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosDeExtension;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string untexto = "       hola mundo    ";
            string otroTexto = null;

            untexto= untexto.SafeString();//borra los espacios antes y despues del texto
            Console.WriteLine(untexto);

            otroTexto = otroTexto.SafeString();
            
            Console.WriteLine(otroTexto);

            Console.ReadKey();
        }
    }
}
