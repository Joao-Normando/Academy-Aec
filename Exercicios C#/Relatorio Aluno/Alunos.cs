using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{

    class Alunos
    {
        private string Nome;
        public string nome
        {
            get
            {
                return this.Nome;
            }
            set
            {
                this.Nome = value;
            }

        }
        private double Nota1;
        public double nota1
        {
            get
            {
                return this.Nota1;
            }
            set
            {
                this.Nota1 = value;
            }
        }

        private double Nota2;
        public double nota2
        {
            get
            {
                return this.Nota2;
            }
            set
            {
                this.Nota2 = value;
            }
        }

        private double Nota3;
        public double nota3
        {
            get
            {
                return this.Nota3;
            }
            set
            {
                this.Nota3 = value;
            }
        }
        private double Nota4;
        public double nota4
        {
            get
            {
                return this.Nota4;
            }
            set
            {
                this.Nota4 = value;
            }
        }
        private string Matricula;
        public string matricula
        {

            get
            {
                return this.Matricula;
            }
            set
            {
                this.Matricula=value;
            }
        }

        public void calculaMedia()
            {
                Media = (this.Nota1 + this.Nota2+ this.Nota3+ this.nota4) / 4;
                Media = Math.Round(media, 2);
            }

        public void calculaStatus()
        {
            if (Media >= 7)
            {
                status = "Aprovado !";
            }
            else
                status = " Reprovado !";
            
        }

        private string Status;
        public string status
        {

            get
            {
                return this.Status;
            }
            set
            {
                this.Status = value;
            }
        }

        private double Media;
            public double media
            {

                get
                {
                    return this.Media;
                }
                set
                {
                    this.Media = value;
                }
            }

            public void mediaNotas()
            {
                Console.WriteLine("\nNome : " + this.Nome);
                Console.WriteLine("Matricula : "+ this.Matricula);
                Console.WriteLine("Nota 1 : " + this.Nota1);
                Console.WriteLine("Nota 2 : " + this.Nota2);
                Console.WriteLine("Nota 2 : " + this.Nota3);
                Console.WriteLine("Nota 2 : " + this.Nota4);
                Console.WriteLine("Média das notas : " + this.media + "\n");
            
            }

        }
    }

