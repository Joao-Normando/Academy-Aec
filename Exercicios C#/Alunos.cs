using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNetframework
{
    class Alunos
    {
        private string Nome;
        public string nome
        {
       

            get
            {
                return this.Nome ;
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
        public void calculaMedia()
        {
            Media = (this.Nota1 + this.Nota2 + this.Nota3) / 3;
            Media = Math.Round(media, 2);

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
            Console.WriteLine("Nota 1 : " + this.Nota1);
            Console.WriteLine("Nota 2 : " + this.Nota2);
            Console.WriteLine("Nota 3 : " + this.Nota3);
            Console.WriteLine("Média das três notas : " + this.Media + "\n");
        }

    }
}

