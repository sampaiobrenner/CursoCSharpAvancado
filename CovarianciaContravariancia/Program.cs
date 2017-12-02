using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {

            ManipuladorFTP<Nivel2> FTP = new ManipuladorFTP<Nivel2>();

            IArmazenador<Nivel3> armazenador = FTP;
            armazenador.Armazenar(new Nivel3());

            IRecuperador<Nivel1> recuperador = FTP;
            Console.WriteLine(recuperador.Recuperar(0));


            FTP.Armazenar(new Nivel2());
            Console.WriteLine(FTP.Recuperar(0)); //Retornará o ToString da classe com namespace + nome da classe
            Console.ReadKey();


        }
    }
}
