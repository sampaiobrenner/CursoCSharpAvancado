using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o que você quer escrever: ");
            string frase = Console.ReadLine();



            Console.WriteLine("Nova frase: {0}", frase.InverterCaixas(false));
            Console.ReadKey();
        }
    }
}
