using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppDesu
{

    class Program
    {
        static void Main(string[] args)
        {
            #region #0 Cоздать одномерный массив из 10-ти элементов, инициализировать случайными числами от 1 до 20 и показать через цикл foreach
            //int[] intArray = new int[10];
            //Random rd = new Random();

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = rd.Next(1, 20);
            //}
            //foreach (int item in intArray)
            //{
            //    Console.Write("{0,4}", item);
            //}

            //Console.WriteLine();
            #endregion
            #region #1 Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива
            //int even = 0; 
            //int odd = 0;
            //int unique = 0;
            //bool flag = false;
            //int[] array= new int[10];
            //Random rd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rd.Next(1, 20);
            //    if (array[i] % 2 == 0)
            //        even++;
            //    else odd++;

            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j] && i != j)
            //        {
            //            flag= true;
            //        }
            //    }

            //    if(flag == true) {
            //        flag= false;
            //    }
            //    else
            //        unique++;
            //}
            //foreach (int i in array)
            //{
            //    Console.Write(i + "  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Even - " + even);
            //Console.WriteLine("Odd - " + odd);
            //Console.WriteLine("Unique - " + unique);
            #endregion
            #region #2 Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем.Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры).
            //int[] array = new int[10];
            //int lower = 0;
            //Random rd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rd.Next(1, 20);
            //    Console.Write(array[i] + "  ");
            //}
            //Console.WriteLine("\n Enter an element:");
            //int element = Convert.ToInt32(Console.ReadLine());

            //foreach (int i in array)
            //{
            //    if(i < element)
            //    {
            //        lower++;
            //    }
            //}

            //Console.WriteLine("There are " + lower + " elements that lower than " + element + " in this array.");
            #endregion
            #region #3 Пользователь вводит с клавиатуры три числа. Необходимо подсчитать сколько раз последовательность из этих трёх чисел встречается в массиве.
            //int[] array= new int[] { 7, 6, 5, 3 ,4, 7 ,6 , 5, 8 ,7 ,6, 5 };
            //int[] sequencearray = new int[3];
            //int sequence = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + "  ");
            //}

            //for (int i = 0;i < sequencearray.Length; i++)
            //{
            //    Console.WriteLine("\n Enter an element #" + i+1 + ": ");
            //    sequencearray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == sequencearray[0] && array[i + 1] == sequencearray[1] && array[i + 2] == sequencearray[2]) {
            //        sequence++;
            //    }
            //}

            //Console.WriteLine("There are " + sequence + " sequences for " + sequencearray[0] + sequencearray[1] + sequencearray[2] + " combination in the array.");
            #endregion
            #region #4 Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие элементы первых двух массивов без повторений
            //const int M = 15;
            //const int N = 10;
            //int[] array = new int[M];
            //int[] array2 = new int[N];
            //int[] array3 = new int[M+N];
            //Random rd = new Random();

            //Console.Write("First array: \n");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rd.Next(1, 20);
            //    Console.Write(array[i] + "  ");
            //}
            //Console.WriteLine();
            //Console.Write("Second array: \n");
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = rd.Next(1, 20);
            //    Console.Write(array2[i] + "  ");
            //}
            //Console.WriteLine();

            //int repeat = 0;
            //int arrayindex3 = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array2.Length; j++)
            //    {
            //        if (array[i] == array2[j])
            //        {
            //            for (int k = 0; k < arrayindex3; k++)
            //            {
            //                if (array3[k] == array2[j])
            //                {
            //                    repeat++;
            //                }
            //            }
            //            if (repeat == 0)
            //            {
            //                array3[arrayindex3] = array2[j];
            //                arrayindex3++;
            //            }
            //            repeat = 0;
            //        }
            //    }
            //}

            //Console.Write("There are " + arrayindex3 + " identical and unique combinations in the arrays: \n");

            //for (int i = 0; i < arrayindex3; i++)
            //{
            //    Console.Write(array3[i] + "  ");
            //}
            //Console.WriteLine();
            #endregion
            #region #5 Разработайте приложение, которое будет находить миннимальное и максимальное значение в двумерном массиве
            //int[,] twoArray = new int[5, 5];
            //Random random= new Random();

            //Console.WriteLine("The array:");
            //for (int i = 0; i < twoArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoArray.GetLength(1); j++)
            //    {
            //        twoArray[i, j] = random.Next(10, 99);
            //        Console.Write("{0,4}", twoArray[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int min = twoArray[0, 0];
            //int max = twoArray[0, 0];

            //for (int i = 0; i < twoArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoArray.GetLength(1); j++)
            //    {
            //        if (twoArray[i,j] > max) max = twoArray[i, j];
            //        if (twoArray[i,j] < min) min = twoArray[i,j];
            //    }
            //}
            //Console.WriteLine("Max - " + max);
            //Console.WriteLine("Min - " + min);
            #endregion
            #region #6 Пользователь вводит предложение с клавиатуры. Вам необходимо подсчитать количество слов в нём.
            //String str = Console.ReadLine();
            //char[] arr = str.ToCharArray();
            //int words = 1;
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] == ' ' && arr[i + 1] != ' ')
            //    {
            //        words ++;
            //    }
            //}
            //Console.WriteLine("There are " + words + " words in your string.");
            #endregion
            #region #7 Пользователь вводит предложение с клавиатуры. Вам необходимо перевернуть каждое слово предложения и отобразить результат на экран.
            //            String str = Console.ReadLine();
            //            char[] arr = str.ToCharArray();
            //            char buffer = ' ';
            //            for (int i = 0; i < (arr.Length/2); i++)
            //            {
            //                buffer = arr[i];
            //                arr[i] = arr[arr.Length-i-1];
            //                arr[arr.Length - i-1] = buffer;
            //;            }
            //            Console.WriteLine(arr);
            #endregion
            #region #8 Пользователь вводит с клавиатуры предложение. Прилложение должно посчитать количество гласных букв в нём
            //String str = Console.ReadLine();
            //char[] arr = str.ToCharArray();
            //char[] wovels_array = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'Y', 'y', 'U','u','\0'};
            //int wovels = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < wovels_array.Length; j++)
            //    {
            //        if (arr[i] == wovels_array[j])
            //        {
            //            wovels++;
            //        }
            //    }
            //}

            //Console.WriteLine("The are " + wovels + " wovels in your string!");
            #endregion
            #region #9 Реализуйте приложение для подсчёта количество вхождений подстроки в строку. Пользователь вводит исходную строку и слово для поиска.Приложений отображает результат поиска.
            //String str = Console.ReadLine();
            //String word = Console.ReadLine();
            //char[] str_arr = str.ToCharArray();
            //char[] word_arr = word.ToCharArray();

            //int count = 0;
            //int j = 0;
            //for (int i = 0 ; i < str_arr.Length; i++)
            //{

            //    if (str_arr[i] == ' ')
            //    {
            //        j = 0;
            //    }
            //    else if (str_arr[i] == word_arr[j])
            //    {
            //        j++;
            //    }

            //    if (j == word_arr.Length)
            //    {
            //        count++;
            //        j = 0;
            //        continue;
            //    }
            //}

            //Console.WriteLine("There are " + count + " '" + word + "' in '" + str + "'!");
            #endregion
        }
    }
}
