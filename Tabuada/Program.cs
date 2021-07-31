using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Informe o numero para tabuada : ");
                int numero = Convert.ToInt32(Console.ReadLine());

                for (int x= 1; x <= 10; x++)
                {
                    Console.WriteLine(numero + " x " + x+ " = " + numero * x);
            }
                contador++;

            for (float x = 1; x <= 10; x++)
            {
                Console.WriteLine("Divisão : "+numero + " / " + x + " = " + numero / x);
                
            }
    
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("Soma : " + numero + " + " + x + " = " + numero + x);
            }
            Console.ReadLine();
            }
        }
    }
