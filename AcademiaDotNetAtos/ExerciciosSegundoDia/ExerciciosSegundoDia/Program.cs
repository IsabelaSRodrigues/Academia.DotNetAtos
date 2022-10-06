using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ExerciciosSegundoDia
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2;
            Teste se a base ou a altura digitada não foi igual a zero.
            */
            
            int baseT, alturaT, areaT;

            Console.WriteLine("Digite o valor da base do triangulo:");
            baseT = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da altura do triangulo:");
            alturaT = int.Parse(Console.ReadLine());

            if (baseT == 0 || alturaT == 0)
            {
                Console.WriteLine("Um dos valores informados é igual a zero.");
            }
            else
            {
                areaT = (baseT * alturaT) / 2;
                Console.WriteLine("A área do triangulo é: "+areaT);
            }



            /*
            2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.
            */

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
            

            /*
            3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
            */
            

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

           

            /*
             
            4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            Mostrar na tela qual dos professores tem o maior salário total.
            */

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

            
            /*
            5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            se a média das duas notas for maior ou igual a 7, 0.

            Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            é a média entre a nota do exame e a média das 2 notas. 
            Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
            escrever “Reprovado”.
            */
            
            double nota1, nota2, media, mediaF;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            

            if(media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                mediaF = (media + media) / 2;
                if(mediaF >= 5)
                {
                    Console.WriteLine("Aprovado!");
                }
                else
                {
                    Console.WriteLine("Reprovado!");
                }
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

            
            /*
            
            
            
            
            
            7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
            */

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

            /*
            8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            total de vendas.
            */
            
            
            
            /*
            9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.

            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for
            menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            */
            
            
            double gli1, gli2,gli3, calc, media;

            Console.Write("Informe o primeiro valor da glicemia:");
            gli1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor da glicemia:");
            gli2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor da glicemia:");
            gli3 = double.Parse(Console.ReadLine());

            calc = gli1 + gli2+ gli3;
            media = (gli1 + gli2 + gli3) / 3;

            if (calc < 65)
            {
                Console.Write("Cuidado! Risco de hipoglicemia.");
            }
            if(calc > 250)
            {
                Console.Write("Cuidado! Risco de hiperglicemia.");
            }
            if (media < 80)
            {
                Console.Write("É preciso diminuir 2 unidades de insulina.");
            }
            if (media > 150)
            {
                Console.Write("É preciso adicionar 2 unidades de insulina.");
            }


            /*

            10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            O programa deve mostrar os dados do atleta mais novo e mais alto.
            */

            
            string nome1, nome2;
            int idade1, idade2;
            double altura1, altura2;

            Console.Write("Digite o nome do primeiro atleta:");
            nome1 = (Console.ReadLine());

            Console.Write("Digite a idade do primeiro atleta:");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do primeiro atleta:");
            altura1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo atleta:");
            nome2 = (Console.ReadLine());

            Console.Write("Digite a idade do segundo atleta:");
            idade2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do segundo atleta:");
            altura2 = double.Parse(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.Write(nome1+" é o atleta mais novo com "+idade1+" anos.");
            }
            else
            {
                Console.Write(nome2+ " é o atleta mais novo com " + idade2+" anos.");
            }
            if (altura1 > altura2)
            {
                Console.Write(nome1 + " é o atleta mais alto com " + altura1.ToString("N2") + " de altura.");
            }
            else
            {
                Console.Write(nome2 + " é o atleta mais alto com  " + altura2.ToString("N2") + " de altura.");
            }
            

            /*
            11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
            O programa deve exibir se a hora digitada está ou não válida. 
            Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
            */

            
            int hora, minuto;

            Console.Write("Digite a hora: ");
            hora = int.Parse(Console.ReadLine());

            Console.Write("Digite o minuto: ");
            minuto = int.Parse(Console.ReadLine());

            if (hora<0 || hora>23 || minuto<0 || minuto>60)
            {
                Console.Write("Hora inválida.");
            }
            else
            {
                Console.Write("Hora válida.");
            }
            


            /*

            12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
            número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            No final do processamento, exibir o salário total e o salário excedente do operário.
            */

            

            double codigo, numeroHoras, salario, extra;

            Console.Write("Digite o código do operário: ");
            codigo = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas do operário: ");
            numeroHoras = double.Parse(Console.ReadLine());

            salario = numeroHoras * 10;

            if(numeroHoras > 50)
            {
                extra = numeroHoras * 20;
            }
            else
            {
                extra = 0;
            }
            Console.WriteLine("\r\n");
            Console.Write("O salario total = "+salario.ToString("C"));
            Console.WriteLine("\r\n");
            Console.Write("O salario excedente = " +extra.ToString("C"));

            


            /*

            13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            seu peso ideal, utilizando as seguintes fórmulas:
                        Para homens: (72.7 * h) - 58
            Para mulheres: (62.1 * h) - 44.7

            */
            
            double h,calc;
            string sexo;

            Console.Write("Digite a altura: ");
            h = double.Parse(Console.ReadLine());

  

            if(h >=1.65 )
            {
                h= (72.7 * h) - 58;
            }
            else
            {
                h = (62.1 * h) - 44.7;
            }

            Console.Write("Seu pesso ideal é: "+h.ToString("N2")+"Kg");



            

            /*
            14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
            link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            do arquivo usando este link(em minutos).

            */







            /*

            15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
            da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
            Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            */

           





            /*

            16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            enfrentar novamente em um novo jogo.
            ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
            */

            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro valor:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            n3 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.Write("O maior valor é: " + n1);
            }
            else if(n2 > n3 && n2 > n1)
            {
                Console.Write("O maior valor é: " + n2);
            }
            else
            {
                Console.Write("O maior valor é: " + n3);
            }
            
            /*
            19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            plus: você pode gerar o número de forma randomica(função random c#).
            */




          
           


            



        }
    }
}
