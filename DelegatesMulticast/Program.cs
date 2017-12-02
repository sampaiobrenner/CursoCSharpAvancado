using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DelegatesMulticast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade del_verificacao;


        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (sexo.Equals("M"))
            {
                del_verificacao = new VerificacaoIdade(VerificarIdadeMulher);
                del_verificacao += VerificarPesoMulher;
            }
            else
            {
                del_verificacao = new VerificacaoIdade(VerificarIdadeHomem);
                del_verificacao += VerificarPesoHomem;
            }

            del_verificacao(idade);
            Console.ReadKey();


        }

        static void VerificarIdadeHomem(int idade)
        {
            if (idade > 21)
            {
                Console.WriteLine("Você já cresceu");
            }
            else
                Console.WriteLine("Você ainda não cresceu");


        }

        static void VerificarPesoHomem(int idade)
        {
            if (idade < 25)
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
            else
                Console.WriteLine("Você pode carregar bastante peso");

        }

        static void VerificarIdadeMulher(int idade)
        {
            if (idade > 18)
            {
                Console.WriteLine("Você já cresceu");
            }
            else
                Console.WriteLine("Você ainda não cresceu");


        }

        static void VerificarPesoMulher(int idade)
        {
            if (idade < 30)
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
            else
                Console.WriteLine("Você pode carregar bastante peso");

        }



    }
}
