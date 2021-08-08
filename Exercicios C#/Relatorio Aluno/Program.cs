using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Program
    {

        static void Main(string[] args)
        {
            int quantidade;
            Console.WriteLine("Quantos Alunos serão inseridos ? ");
            quantidade = int.Parse(Console.ReadLine());

            var alunos = new List<Alunos>();
            int contador = 0;

            while (contador < quantidade)
            {

                Alunos obj = new Alunos();
                String entrada;
                Console.WriteLine("\nCalcula a média do aluno");
                Console.Write("Aluno: ");
                entrada = Console.ReadLine();
                obj.nome = entrada;

             

                

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Nota " + i + ": ");
                    entrada = Console.ReadLine();

                    if (i == 1)
                    {
                        obj.nota1 = Convert.ToDouble(entrada);
                    }
                    if (i == 2)
                    {
                        obj.nota2 = Convert.ToDouble(entrada);
                    }
                    if (i == 3)
                    {
                        obj.nota3 = Convert.ToDouble(entrada);
                    }
                    else
                    {
                        obj.nota4 = Convert.ToDouble(entrada);
                    }

                }

                Console.Write("Matricula : ");
                entrada = Console.ReadLine();
                obj.matricula = entrada;


                /* Console.Write("Nota 1 : ");
                 entrada = Console.ReadLine();
                 obj.nota1 = Convert.ToDouble(entrada);
                 Console.Write("Nota 2 : ");
                 entrada = Console.ReadLine();
                 obj.nota2 = Convert.ToDouble(entrada);
                 Console.Write("Nota 3 : ");
                 entrada = Console.ReadLine();
                 obj.nota3 = Convert.ToDouble(entrada);
                 Console.Write("Nota 4 : ");
                 entrada = Console.ReadLine();
                 obj.nota4 = Convert.ToDouble(entrada);
                  */

                obj.calculaMedia();
                obj.calculaStatus();

                alunos.Add(obj);

                contador++;
            }

            Console.WriteLine("\nRelatório: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine("----------------------------" + "\nNome: " + aluno.nome + "\nMedia: " + aluno.media + "\nMatricula : " + aluno.matricula + "\nTodas as notas : " + aluno.nota1 + "," + aluno.nota2 + "," + aluno.nota3 + "," + aluno.nota4 + "\nStatus :" + aluno.status);

                /* Salvando em arquivo txt  */
                StreamWriter sw = new StreamWriter("c:\\Temp\\meutxt.txt");
                sw.Write("----------------------------" + "\nNome: " + aluno.nome + "\nMedia: " + aluno.media + "\nMatricula : " + aluno.matricula + "\nTodas as notas : " + aluno.nota1 + "," + aluno.nota2 + "," + aluno.nota3 + "," + aluno.nota4 + "\nStatus :" + aluno.status);

                sw.Close();
            } 
               

            Console.WriteLine("----------------------------");
            Console.ReadKey();

            
           

            
        }
    }
}
