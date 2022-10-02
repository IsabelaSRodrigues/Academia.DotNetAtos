using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace ExerciciosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
            */
            /*
            
            int[] vetorA = new int[20];
            int[] vetorB = new int[20];
            int[] vetorC = new int[20];
            
            for(int i = 0; i < 20; i++)
            {
                Console.Write("Digite o vetor da posição " + (i+1)+":");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite o vetor da posição " + (i + 1) + ":");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                
                vetorC[i] = vetorA[i] + vetorB[i];
                Console.WriteLine("A soma do vetor A e B " +vetorA[i]+ "+" + vetorB[i]+ " na posiçao " + (i + 1) + "= " + vetorC[i]);
            }
            */

            /*
            3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            */
            /*
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o número da posição do primeiro vetor " + (i+1) + ":");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero da posição do segundo vetor " + (i +1) + ":");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {

                vetorC[i] = vetorA[i] * vetorB[i];
                Console.WriteLine("A multipicação de " + vetorA[i] + "x" + vetorB[i] +" da posição " + (i+1) + "= " + vetorC[i]);
            }

            /*
            5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
            
            int[] vetor = new int[80];
            int i, menor, posicao;

            for (i = 0; i < 80; i++)
            {
                Console.WriteLine("Digite o valor do elemento na posição " + i+":");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            menor = vetor[0]; 
            posicao = 0;

            for (i = 0; i < 80; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine("O menor elemento é " + menor + " e está na posição " + posicao);

            6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
            a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |
            */
            /*
            int[] vetor = new int[10];
            int i;

            

            for ( i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero da posição "+(i+1)+":");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i<10; i++)
            {
                Console.Write("|" + vetor[i]);

            }
            Console.WriteLine("\r\n");

            for (i = 9; i>=0; i--)
            {
                Console.Write("|" + vetor[i]);
                
            }

            /*

            7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int[] vetor = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o valor do elemento " + (i+1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.Write("|" + vetor[i]);
            }

            Console.Write("\r\n");


            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write("|"+vetor[i]);
                }
            }
            

            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write("|"+vetor[i]);
                }
            }

            8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
            a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            float[] vetor = new float[30];
            int i;



            for (i = 0; i < 30; i++)
            {
                Console.Write("Digite o numero da posição " + i + ":");
                vetor[i] = float.Parse(Console.ReadLine());

            }
            for (i = 0; i < 30; i++)
            {
                Console.Write("|" + vetor[i]);

            }
            Console.WriteLine("\r\n");

            for (i = 0; i < 30; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.Write("|" + i);
                }
            }

            9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor, substituindo os valores nulos por 2.Mostre os vetores lidos e o vetor resultado.

            11.Escreva um programa que leia valores em um vetor de 5 posições.Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int i;
            int[] b = new int[5];
            Console.WriteLine("------------Leitura dos Valores: ----------");

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o valor " + (i+1) + ":");
                b[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor índice " + (i+1) + " é igual a " + b[i]);
            }

            for (i = 5; i < 0; i--)
            {
                Console.WriteLine("Valor índice " + (i + 1) + " é igual a " + b[i]);
            }

            12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".


            13.Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.O vetor terá no máximo 100 posições.Sair do programa quando for digitado - 1 ou quando atingir o máximo de posições do vetor.

            14.Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vetor na ordem em que foi lido.Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            15.Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            int[] vetor1 = new int[20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int[] vetor2 = new int[20];



            vetor1.CopyTo(vetor2, 0);

            Console.WriteLine("Vetor 1");

            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i]);
            }
            Console.WriteLine("Vetor 2");

            for (int i = 19; i >= 0; i--)
            {
                Console.WriteLine(vetor2[i]);
            }

            16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, a seguir, um vetor para cada uma das operações:
            •	A união de X com Y
            •	A diferença entre X e Y
            •	A interseção entre X e Y
            Escreva o vetor resultado de cada uma das operações.
            Footer

            int[] x = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int[] y = new int[10] {1,6,30,4,5,60,7,9,10,11};

            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] intersecao = new int[10];

            x.CopyTo(uniao, 0);
            int auxU = 10;

            Console.WriteLine("Vetor União");

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;

                    }
                }
            }
            for (int i = 0; i < auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("Vetor Diferença");

            int auxD = 0;

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        diferenca[auxD] = x[i];
                        auxD++;

                    }
                }
            }
            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferenca[i]);
            }
            Console.WriteLine("");



            Console.WriteLine("Vetor Interseção");

            int auxI = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for(int j = 0; j < y.Length; j++)
                {
                    if(x[i] == y[j])
                    {
                        intersecao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }
            }
            for(int i = 0; i < auxI; i++)
            {
                Console.WriteLine(intersecao[i]);
            }

            */










        }
    }
}