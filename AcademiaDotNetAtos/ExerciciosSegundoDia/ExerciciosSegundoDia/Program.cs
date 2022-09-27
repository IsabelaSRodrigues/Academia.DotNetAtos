using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ExerciciosSegundoDia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Insira um número inteiro:");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("Número é par.");
            }
            else
            {
                Console.WriteLine("Número é impar.");
            }
            */

            /*

            Console.Write("Insira um número inteiro:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Insira um número inteiro:");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Insira um número inteiro:");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write("Insira um número inteiro:");
            int number4 = int.Parse(Console.ReadLine());

            int average = (number1 + number2 + number3 + number4) / 4;
            

            if(number1 > average)
            {
                Console.WriteLine("Maior que a média:" + number1);
            }
            if (number2 > average)
            {
                Console.WriteLine("Maior que a média:" + number2);
            }
            if (number3 > average)
            {
                Console.WriteLine("Maior que a média:" + number3);
            }
            if (number4 > average)
            {
                Console.WriteLine("Maior que a média:" + number4);
            }

            */

            /*

            Console.Write("Digite a quantidade de horas do primeiro professor:");
            int hour1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor por cada hora de aula do primeiro professor R$");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de horas do segundo professor:");
            int hour2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor por cada hora de aula do segundo professor R$");
            int value2 = int.Parse(Console.ReadLine());

            int calc1 = hour1 * value1;
            int calc2 = hour2 * value2;

            if(calc1 > calc2)
            {
                Console.WriteLine("O primeiro professor tem o maior salário de R$"+calc1);
            }
            else
            {
                Console.WriteLine("O segundo professor tem o maior salário de R$" +calc2);
            }

            */
            /*
            5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            se a média das duas notas for maior ou igual a 7, 0.
                */
            /*
            Console.Write("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            double average = (nota1 + nota2) / 2;

            if(average >= 7)
            {
                Console.Write("Aluno Aprovado!");
            }
            else if (average <7)
            {
                double averagef = average 
            }

            */
            /*

            6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
            O cálculo do imc = peso / (altura * altura)

            IMC 
            menor que 18                -> baixo peso
            maior que 18 e menor que 25 -> peso normal
            maior que 25 e menor que 30 -> sobrepeso
            maior que 30 e menor que 35 -> obesidade
            maior que 35                -> obesidade grau sério

            */

            /*

            Console.Write("Digite o nome:");
            string name = string.ToUpper(Console.ReadLine());

            /*

            7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

            */

            /*

            string frase = "";
            string palavra = "";

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra:");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase.");
            }
            else
            {
                Console.WriteLine("A palavra não encontra-se na frase.");
            }


            */

            /*
            8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            total de vendas.
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
           


            



        }
    }
}