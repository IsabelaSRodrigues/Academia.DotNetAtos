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
            /* EXERCÍCIO 1
            
            1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
             
            Console.WriteLine("Digite o primeiro número:");
            double  number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double average = (number1 + number2) / 2;
            Console.WriteLine("A média é: " +average);
            
            */

            /* EXERCÍCIO 2
            
            2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            
            Console.WriteLine("Digite o primeiro número:");
            double  number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            double number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            double number4 = Convert.ToDouble(Console.ReadLine());


            double average = (number1 + number2+ number3 + number4) / 4;
            Console.WriteLine("A média é: " +average);
            
            */

            /* EXERCÍCIO 3
            
            3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            si os valores de duas variáveis A e B.
            
            int a = 10;
            int b = 20;
            int c = 30;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("O valor de a é: " + a);
            Console.WriteLine("O valor de b é: " + b);
           
            */

            /* EXERCÍCIO 4

           4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
           forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

           int day, month, year;

           Console.WriteLine("Digite o dia: ");
           day = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite o mês: ");
           month = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite o ano: ");
           year = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("A data é "+year+"/"+month+"/"+day);

           int year2;
           year2 = year % 100;

           Console.WriteLine("A data é: " + year2 + "/" + month + "/" + day);


           */

            /* EXERCÍCIO 5
            
            5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            consumido para percorrê-la (medido em l).
            
            double distancia, combustivel, consumo;

            Console.WriteLine("Digite a distancia em quilometros:");
            distancia = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade litros utilizada:");
            combustivel = Double.Parse(Console.ReadLine());

            consumo = distancia / combustivel;

            Console.WriteLine("O consumo é: " + consumo+"km/l");
         
           
            */

            /* EXERCÍCIO 6
            
            6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            de IPI (única) a ser acrescentada.
            
            Console.Write("Digite o código do parafuso A:");
            string codeA = Console.ReadLine();

            Console.Write("Digite a quantidade de parafuso A:");
            int amountA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor unitário do parafuso A:");
            double  valueA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI do parafuso A:");
            double ipiA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o código do parafuso B:");
            string codeB = Console.ReadLine();

            Console.Write("Digite a quantidade de parafuso B:");
            int amountB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor unitário do parafuso B:");
            double valueB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI do parafuso B:");
            double ipiB = Convert.ToDouble(Console.ReadLine());



            double calcTotalA = valueA * amountA;
            double calcTotalB = valueB * amountB;
            double calcIpiA = calcTotalA * (ipiA / 100);
            double calcIpiB = calcTotalB * (ipiB / 100);

            Console.WriteLine("O parafuso A possui o código:"+codeA+", com a quantidade de peças totais de:"+amountA+", o valor total do parafuso é de R$" + calcTotalA+" e o valor de IPI é de R$" +calcIpiA);
            Console.WriteLine("O parafuso B possui o código:" + codeB + ", com a quantidade de peças totais de:" + amountB + ", o valor total do parafuso é de R$" + calcTotalB + " e o valor de IPI é de R$" + calcIpiB);
            
           
            */
            
            /* EXERCÍCIO 7
            
           7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
           o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
           Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
            
            
         
           
            */
        }
    }
}



