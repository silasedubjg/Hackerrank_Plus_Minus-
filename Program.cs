
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void plusMinus(List<int> arr, int n)
    {
        int tamanho = n;
        List<int> aux = arr;
        int maior = 0, menor = 0, igual = 0;



        foreach (int element in arr)
        {
            if (element > 0)
            {
                maior++;

            }
            else if (element < 0)
            {
                menor++;
            }
            else
            {
                igual++;
            }
        }

        Console.WriteLine(maior);


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do vetor(maior que 0 e menor ou igual a 100)");
        int n = Convert.ToInt32(Console.ReadLine().Trim()), aux = 0;

        while (n <= 0 || n > 100)
        {
            aux++;
            if (aux > 0)
            {
                Console.WriteLine("valor fora dos parametros. Por favor digite um valor entre 1 e 100.");
            }
            n = Convert.ToInt32(Console.ReadLine().Trim());
        }


        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int tamanholista = arr.Count;

        while (tamanholista != n)
        {
            Console.WriteLine("Lista com tamanho diferente do tamanho indicado. A lista atual possui " + tamanholista + " elementos. Por favor crie uma lista com " + n + " elementos");
            
            arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            tamanholista = arr.Count;
        }
        Result.plusMinus(arr, n);
    }
}
