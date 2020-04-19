using System;
using System.Collections.Generic;

namespace F15Vetores
{
    public class Vetores
    {
        #region Ex1
        //Solicitar dez valores e armazená-los num array. No final deverão ser apresentados os vetores para cada índice 
        //do array. 
        public static void ShowArray()
        {
            const int QUANTIDADE = 10;

            int[] numeros = new int[QUANTIDADE];

            for (var count = 0; count < QUANTIDADE; count++)
            {
                numeros[count] = ReadAndConvert();
            }
            Console.WriteLine($"Na primeira posição está {numeros[0]}");
            Console.WriteLine($"Na segunda posição está {numeros[1]}");
            Console.WriteLine($"Na terceira posição está {numeros[2]}");
            Console.WriteLine($"Na quarta posição está {numeros[3]}");
            Console.WriteLine($"Na quinta posição está {numeros[4]}");
            Console.WriteLine($"Na sexta posição está {numeros[5]}");
            Console.WriteLine($"Na sétima posição está {numeros[6]}");
            Console.WriteLine($"Na oitava posição está {numeros[7]}");
            Console.WriteLine($"Na nona posição está {numeros[8]}");
            Console.WriteLine($"Na décima posição está {numeros[9]}");

        }

        public static int ReadAndConvert()
        {
            Console.WriteLine("Número");
            var num = int.Parse(Console.ReadLine());
            return num;
        }
        #endregion

        #region Ex2
        // Solicitar dez valores e armazená-los num array. No final deverão ser apresentados os vetores para cada índice
        // do array, por ordem inversa. 

        public static void InvertOrder()
        {
            const int QUANTIDADE = 10;

            int[] numeros = new int[QUANTIDADE];

            for (var count = 0; count < QUANTIDADE; count++)
            {
                numeros[count] = ReadAndConvert();
            }

            Console.WriteLine($"Na décima posição está {numeros[9]}");
            Console.WriteLine($"Na nona posição está {numeros[8]}");
            Console.WriteLine($"Na oitava posição está {numeros[7]}");
            Console.WriteLine($"Na sétima posição está {numeros[6]}");
            Console.WriteLine($"Na sexta posição está {numeros[5]}");
            Console.WriteLine($"Na quinta posição está {numeros[4]}");
            Console.WriteLine($"Na quarta posição está {numeros[3]}");
            Console.WriteLine($"Na terceira posição está {numeros[2]}");
            Console.WriteLine($"Na segunda posição está {numeros[1]}");
            Console.WriteLine($"Na primeira posição está {numeros[0]}");
        }
        #endregion

        #region Ex3
        //Solicitar dez números e armazená-los num array. Apresentar a soma de todos os números. 
        public static void SumNumbers()
        {
            const int QUANTIDADE = 10;
            var sum = 0;

            int[] numbers = new int[QUANTIDADE];

            for (var count = 0; count < QUANTIDADE; count++)
            {
                numbers[count] = ReadAndConvert();
            }
            for (int i = 0; i < QUANTIDADE; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        #endregion

        #region Ex4
        //Criar um algoritmo que permita contar os elementos de um vetor 
        public static void HowManyElements(int[] vetor)
        {
            Console.WriteLine(vetor.Length);
        }
        #endregion

        #region Ex5
        //Criar um algoritmo que apresente a contagem de todos os elementos repetidos num array 
        public static void ShowRepeatedNumbers(int[] vetor)
        {
            int contador = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (j != i && vetor[j] == vetor[i])
                    {
                        contador++;
                        Console.WriteLine($"{vetor[j]}");
                        break;
                    }
                }
            }
            Console.WriteLine($"Números repetidos: {contador}");
        }
        #endregion

        #region Ex6
        //Criar um algoritmo que apresente todos os elementos únicos num array 
        public static void UniqueElements(int[] vector)
        {

            for (int i = 0; i < vector.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < vector.Length; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(vector[i]);
                }
            }
        }
        #endregion

        #region Ex7
        // Criar um algoritmo para encontrar o menor e o maior valor num array numérico 
        public static void FindMaxANdMinNumber(int[] vector)
        {
            int max = 0;
            int min = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (i == 0)
                {
                    min = vector[i];
                    max = vector[i];
                }
                else if (vector[i] < min)
                {
                    min = vector[i];
                }
                else if (vector[i] > max)
                {
                    max = vector[i];
                }
            }
            Console.WriteLine($"O valor mínimo é {min} e o máximo é {max}");
        }
        #endregion

        #region Ex8
        // Criar um algoritmo para separar os números ímpares dos pares num array numérico 
        public static void OddsOrEvens(int [] vector)
        {
            string odds = "";
            string evens = "";


            for (int i = 0; i < vector.Length; i++)
            {
                if ( vector[i] % 2 == 0)
                {
                    evens += $"{vector[i]} ";
                }
                else
                {
                    odds += $"{vector[i]} ";
                }
            }
            Console.WriteLine($"Os números pares são: {evens} \n Os números ímpares são: {odds}");
        }
        #endregion

        #region Ex9
        //Criar um algoritmo que verifique se um elemento se encontra num array
        public static void CheckElement(int[] vector, int elemento)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                if(elemento == vector[i])
                {
                    Console.WriteLine($"O {elemento} se encontra no vetor na posição {i}");
                }
            }
        }
        #endregion

    }
}
