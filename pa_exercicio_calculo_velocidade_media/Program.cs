using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa_exercicio_calculo_velocidade_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, tempo;

            Console.WriteLine("Qual tempo de viagem em horas?: ");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual distância: ");
            km = double.Parse(Console.ReadLine());


            km = km / tempo;

            Console.WriteLine("A velocidade média é de " + Math.Round(km, 2) + " km/h!");

            Console.ReadKey();
        }
    }
}
