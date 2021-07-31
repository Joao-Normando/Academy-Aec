using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lentilha

// Valkiria é uma empreendedora que vende produtos naturais, ela está querendo fazer um mini programa para vender lentilha
//Faça um programa que calcule, o valor da lentilha vs o preço do peso.
//Valor do peso da lentilha: 1,50 o KG
//No final do programa, mostrar o valor total e quantos KG a pessoa selecionou,
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Lentilha = 1.5;
            double peso = 0;
            double total = 0;

            Console.Write("Digite o peso a ser escolhido : ");
            peso = double.Parse(Console.ReadLine());

            total = peso * Lentilha;

            Console.Write(" Peso desejado : " + peso);
            Console.Write(" O peso total é de : "+total);

            Console.ReadKey();

        }
    }
}
