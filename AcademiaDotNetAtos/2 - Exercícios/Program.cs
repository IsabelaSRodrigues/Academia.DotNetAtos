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
             */
            
            Console.WriteLine("Digite o primeiro número:");
            double  number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double average = (number1 + number2) / 2;
            Console.WriteLine("A média é: " +average);
            
            */

            /* EXERCÍCIO 2
            
            2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            */
                
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
            */
                
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
           */

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
            */
            
            double distance, fuel, consumption;

            Console.WriteLine("Digite a distancia em quilometros:");
            distance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade litros utilizada:");
            fuel = Double.Parse(Console.ReadLine());

            consumption = distance / fuel;

            Console.WriteLine("O consumo é: " + consumption.ToString("C") + "km/l");
         
           
            */

            /* EXERCÍCIO 6
            
            6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            de IPI (única) a ser acrescentada.
            */
            
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
            double calcIpiA = calcTOtalA + (calcTotalA * (ipiA / 100));
            double calcIpiB = calcTOtalB + (calcTotalB * (ipiB / 100));

            Console.WriteLine("================================================");

            Console.WriteLine("O parafuso A possui o código:" + codeA);   
            Console.WriteLine("A quantidade de peças totais de:" + amountA);
            Console.WriteLine("O valor unitário do parafuso é de R$" + valueA);
            Console.WriteLine("O valor total do parafuso é de R$" + calcTotalA);

            Console.WriteLine("================================================");

            Console.WriteLine("O parafuso B possui o código:" + codeB);
            Console.WriteLine("A quantidade de peças totais de:" + amountB);
            Console.WriteLine("O valor unitário do parafuso é de R$" + valueB);
            Console.WriteLine("O valor total do parafuso é de R$" + calcTotalB);
           
            */
            
            /* EXERCÍCIO 7
            
           7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
           o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
           Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
           */
            
            Console.Write("Digite o numero do funcionario:");
            string number = Console.ReadLine();

            Console.Write("Digite o salario: R$");
            double wage = Double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas: R$");
            double sales = Double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de vendas (%):");
            double percent = Double.Parse(Console.ReadLine());

            double percentf  = (sales / 100) * percent;
            double wagef = wage + percentf;

            Console.WriteLine("================================================");

            Console.WriteLine("O numero do vendedor é: "+number);   
            Console.WriteLine("O salário total do vendedor é: R$"+wagef);
         
           
            */
            
            /*
            
            8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            A fórmula da conversão é F=(9*C+160)/5.
            */
            Console.Write("Digite a temperatura em graus Celsius:");
            double tempC = Double.Parse(Console.ReadLine());

            double tempF = (9 * tempC + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é:" +tempF+" graus");
            
            /*
            
            9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
            Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
            se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
            Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            da entrada e das duas prestações, de acordo com as regras acima. 
            Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
            conseqüente pagamento dos boletos das duas prestações.
            
           */
            Console.Write("Digite o valor do produto: R$");
            double product = Double.Parse(Console.ReadLine());

            double resto = product % 3;
            product = product - resto;

            double parcela = product / 3;

            double entrada = parcela + resto;
            
            Console.WriteLine("A entrada será de: R$" + entrada);
            Console.WriteLine("A primeira parcela será de: R$" + parcela);
            Console.WriteLine("A segunda parcela será de: R$" + parcela);
            
            /*
            /*
            10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.
            */
            
            /*
            11) Escreva um algoritmo para ler o número de eleitores de um município, 
            o número de votos brancos, nulos e válidos. 
            Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            */
            
            int voters = 10000;
            int valid = 6500;
            int voteB = 1200;
            int nulos = 2000;

            double  percentV, percentVB, percentN;

            percentV = (valid * 100) / voters;
            percentVB = (voteB * 100) / voters;
            percentN = (nulos * 100) / voters;

            Console.Write("Total de eleitores: " +voters+ ",votos válidos: "+valid+ ",votos em branco: "+voteB+ " e votos nulos: "+nulos+".");
            Console.Write("\r\n");

            Console.Write("O valor percentual de votos válidos é: " + percentV + "%");
            Console.Write("\r\n");

            Console.Write("O valor percentual de votos em branco é: " + percentVB + "%");
            Console.Write("\r\n");
            
            Console.Write("O valor percentual de votos nulos é: " + percentN + "%");
            

            
            /*
            12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
            dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

            Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

            Média do consumo = Total quilometragem/ quantidade de combustível gasto

            Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
            */
            
             double odoI, odoF, quilometragemT, media,combustivel,valorT,lucro;

            Console.WriteLine("Digite o valor do odômetro inicial (KM):");
            odoI = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do odômetro final (KM):");
            odoF = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de combustível utilizado (L):");
            combustivel = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total recebido R$:");
            valorT = Double.Parse(Console.ReadLine());



            quilometragemT = odoF - odoI;
            media = quilometragemT / combustivel;
            lucro = valorT - (combustivel * 6.90);
            

            Console.WriteLine("A média de consumo por dia: "+media +"Km/L");

            Console.WriteLine("O lucro líquido por dia é: " + lucro.ToString("C"));

            
            
            /*
            

            13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            vendidas pelo vendedor, calcule e mostre: o salário do empregado

        }
    }
}



