using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno(1212, 23);

            Console.WriteLine("Idade=" + a.Idade);
            Console.WriteLine("Maior=" + a.EMaiorIdade());


            //Professor pf = new Professor();

            ProfessorAdjunto pa = new ProfessorAdjunto();


            ClubeTotal cp = new ClubeTotal();
            
            Pessoa p1 = new Pessoa();
            Aluno a1 = new Aluno(1234,23);
            PessoaII p2 = new PessoaII();


            cp.GetNome(p1);
            cp.GetNome(a1);
            cp.GetNome(p2);


            Console.ReadKey();

        }
    }
}
