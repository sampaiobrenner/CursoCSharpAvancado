using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = CarregarListaPessoa();
            //consultas
            //1 pessoas com mais de 2 irmaos
           /* IEnumerable<Pessoa> PessoasMaisDoisIrmaos = from pessoa in pessoas
                                        where pessoa.QuantidadeIrmaos > 2
                                        select pessoa;

            */
            var PessoasMaisDoisIrmaos = pessoas.Where(w => w.QuantidadeIrmaos > 2);

            Console.WriteLine("Pessoas com mais de dois irmaos:");
            foreach (var p in PessoasMaisDoisIrmaos)
            {
                Console.WriteLine("{0}, {1}, {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
                
            }
            //2 Nome e idade de pessoas maiores de idade
            /*var PessoasMaioresIdade = from p in pessoas
                                      where p.Idade >= 18
                                      orderby p.Idade descending
                                     
                                      select new { p.Nome, p.Idade }; //obj anonimo para trazer propriedades selecionadas
            */
            var PessoasMaioresIdade = pessoas
                                            .Where(p => p.Idade > 17)
                                            .OrderByDescending(p => p.Nome.Length)
                                            .ThenBy(p => p.Idade)
                                            .Select(pessoa => new { pessoa.Nome, pessoa.Idade });


            Console.WriteLine("Pessoas maiores de idade:");
                
            foreach (var p in PessoasMaioresIdade)
            {
                Console.WriteLine("{0}, {1},", p.Nome, p.Idade);
                
            }


            Console.ReadKey();
        }

        static List<Pessoa> CarregarListaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa
            {
                Nome = "Gabriel",
                Idade = 22,
                QuantidadeIrmaos = 1
            });

            pessoas.Add(new Pessoa
            {
                Nome = "Maria",
                Idade = 22,
                QuantidadeIrmaos = 3
            });

            pessoas.Add(new Pessoa
            {
                Nome = "Filipe",
                Idade = 23,
                QuantidadeIrmaos = 0
            });

            return pessoas;
        }

    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }

    }
}
