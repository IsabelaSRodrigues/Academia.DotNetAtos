using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AcademiaDotNetAtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia, combustivel, consumo;

            Console.WriteLine("Digite a distancia em quilometros:");
            distancia = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade litros utilizada:");
            combustivel = Double.Parse(Console.ReadLine());

            consumo = distancia / combustivel;

            Console.WriteLine("O consumo é: " + consumo+"km/l");









        }
    }
}



