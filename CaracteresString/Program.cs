using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apostrofe \'");
            Console.WriteLine("Comillas \"");
            Console.WriteLine("Contrabarra \\");
            Console.WriteLine("Null \0");
            Console.WriteLine("Alerta \a");
            Console.WriteLine("Borrar \bespacio");          
            Console.WriteLine("Nueva \nlínea");
            Console.WriteLine("Retorno de carro\r");
            Console.WriteLine("Tabulador \thorizontal");
            Console.WriteLine(@"Con @ todo sale
como se 
        escribe");        
            Console.ReadKey();
        }
    }
}
