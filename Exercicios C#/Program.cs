using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNetframework
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Alunos>();
            int contador = 0;
            while (contador <= 3)


            {

                Alunos obj = new Alunos();
                String entrada = " ";
                Console.WriteLine("Calcula a média do aluno");
                Console.Write("Aluno: ");
                entrada = Console.ReadLine();
                obj.nome = entrada;
                Console.Write("Nota 1 : ");
                entrada = Console.ReadLine();
                obj.nota1 = Convert.ToDouble(entrada);
                Console.Write("Nota 2 : ");
                entrada = Console.ReadLine();
                obj.nota2 = Convert.ToDouble(entrada);
                Console.Write("Nota 3 : ");
                entrada = Console.ReadLine();
                obj.nota3 = Convert.ToDouble(entrada);

                obj.calculaMedia();

                obj.mediaNotas();
                alunos.Add(obj);
                contador++;
            }

            Console.WriteLine("\n -------------------------------------------\n");
            foreach (var aluno in alunos) Console.WriteLine( "\n Nome: " +aluno.nome + " | Media: " + aluno.media);

        }
    }
}
