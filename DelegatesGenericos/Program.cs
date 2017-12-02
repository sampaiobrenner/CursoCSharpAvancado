using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesGenericos
{
    class Program
    {
        delegate T CalculoMat<T>(T a, T b);


        static void Main(string[] args)
        {
            Program p = new Program();

            CalculoMat<int> cal = new CalculoMat<int>(Somar);
            CalculoMat<decimal> caldec = new CalculoMat<decimal>(p.SomarDec);

            Console.WriteLine(cal(1, 1));
            Console.WriteLine(caldec(1.5m, 1.6m));
            ExibirInformacoesDelegate(caldec);
            Console.ReadKey();
        }

        private static void ExibirInformacoesDelegate<T>(CalculoMat<T> caldec)
        {
            Console.WriteLine(caldec.Target);
            Console.WriteLine(caldec.Method);
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        decimal SomarDec(decimal a, decimal b)
        {
            return a + b;
        }



    }
}
