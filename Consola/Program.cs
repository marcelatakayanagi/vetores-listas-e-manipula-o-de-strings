
using F15Vetores;
using F16Listas;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetores.ShowArray();
            //Vetores.InvertOrder();
            //Vetores.SumNumbers();
            //int[] vv = { 1, 2, 3 };
            //Vetores.HowManyElements(vv);
            //int[] vet = { 1, 3, 3, 5, 6, 7, 3, 1, 6, 8, 4 };
            //Vetores.ShowRepeatedNumbers(vet);
            //Vetores.UniqueElements(vet);
            //int[] arr = { 45, 99, 3, 8, 54, 230, 1 };
            //Vetores.FindMaxANdMinNumber(arr);
            //Vetores.OddsOrEvens(arr);
            //Vetores.CheckElement(arr, 3);

            //Listas.List();
            //Listas.Reverse();
            //Listas.ListSum();
            //List<int> num = new List<int>(){1, 2, 3, 3, 3, 2, 2, 6};
            //Listas.DuplicateNumber(num);
            //Listas.UniqueNumbers(num);
            //Listas.MaxAndMinValue(num);
            List<int> num = new List<int>() {1, 2, 3, 4, 5, 6};
            //Listas.OddsAndEvens(num);
            Listas.CheckElement(num, 7);
        }
    }
}
