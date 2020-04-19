using System;
using System.Collections.Generic;

namespace F16Listas
{
    public class Listas
    {
        #region Ex1
        //Solicitar dez valores e armazená-los numa lista. No final deverão ser listados todos os elementos.
        public static void List()
        {
            const int LIMIT = 10;
            List<int> numbers = new List<int>();
            string num = "";
            int numero = 0;

            for (int i = 0; i < LIMIT; i++)
            {
                numero = ReadAndConvert();
                numbers.Add(numero);
                num = $"{numbers}";
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static int ReadAndConvert()
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        #endregion

        #region Ex2
        //Solicitar dez valores e armazená-los numa lista. No final deverão ser listados todos os elementos por ordem 
        //inversa.
        public static void Reverse()
        {
            const int LIMIT = 10;
            List<int> numbers = new List<int>();
            int numero = 0;

            for (var i = 0; i < LIMIT; i++)
            {
                numero = ReadAndConvert();
                numbers.Add(numero);
            }
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        #endregion

        #region Ex3
        //Solicitar dez números e armazená-los numa lista. Apresenta a soma de todos os elementos. 
        public static void ListSum()
        {
            const int LIMIT = 10;
            int sum = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < LIMIT; i++)
            {
                int num = ReadAndConvert();
                numbers.Add(num);
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                sum += numbers[j];
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region Ex4
        //Criar um algoritmo que apresente a contagem de todos os elementos repetidos numa lista. 
        public static void DuplicateNumber(List<int> numbers)
        {
            List<int> duplicateList = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count != 1)
                {
                    if (!duplicateList.Contains(numbers[i]))
                    {
                        duplicateList.Add(numbers[i]);
                        Console.WriteLine($"{numbers[i]}");
                    }
                }
            }
            Console.WriteLine($"Há {duplicateList.Count} números repetidos");
        }
        #endregion

        #region Ex5
        //Criar um algoritmo que apresente todos os elementos únicos numa lista.
        public static void UniqueNumbers(List<int> numbers)
        {
            List<int> uniquenum = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniquenum.Add(i);
                    Console.Write($"O número {numbers[i]} é único \n");
                }

            }
        }
        #endregion

        #region Ex6
        //Criar um algoritmo para encontrar o menor e o maior valor numa lista. 
        public static void MaxAndMinValue(List<int> numbers)
        {
            List<int> MaxNum = new List<int>();
            List<int> MinNum = new List<int>();
            int min = 0;
            int max = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    min = numbers[i];
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                    MinNum.Add(i);
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                    MaxNum.Add(i);
                }
            }
            Console.WriteLine($"O menor valor é {min} e o maior é {max}");
        }
        #endregion

        #region Ex7
        //Criar um algoritmo para separar os números ímpares dos pares numa lista.
        public static void OddsAndEvens(List<int> numbers)
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();

            string evenNum = "";
            string oddNum = "";

            for (int i = 0;  i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNum += $"{numbers[i]} ";
                    evens.Add(i);
                }
                else
                {
                    oddNum += $"{numbers[i]} ";
                    odds.Add(i);
                }
            }
            Console.Write($"Os números pares são: {evenNum} \n E os ímpares são: {oddNum}");
        }
        #endregion

        #region Ex8
        //Criar um algoritmo que verifique se um elemento se encontra numa lista. 
        public static void CheckElement(List<int> numbers, int elemento)
        {
            int position = -1;
            for(int i = 0; i < numbers.Count; i++)
            {
                if(elemento == numbers[i])
                {
                    position = i;
                    break;
                }
            }
            if (position != -1)
            {
                Console.WriteLine($"O {elemento} se encontra na lista na posição {position}");
            }
            else
            {
                Console.WriteLine($"{elemento} não faz parte da lista");
            }

        }
        #endregion

    }
}
