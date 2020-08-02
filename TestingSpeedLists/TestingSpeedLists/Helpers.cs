using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace TestingSpeedLists
{
    public class Helpers
    {
       
        #region Допы

        // Рандом от и до.
        public int GetRnd(int minVal, int maxVal)
        {
            Random rnd = new Random();
            int result = rnd.Next(minVal, maxVal);
            return result;
        }
        #endregion

        #region Массивы
        // Реверс массива.
        public int[] ReverseArray(int[] array)
        {
            int tmp = 0;
            int l = array.Length;
            int[] revArray = new int[l];
            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[i] = tmp;
                revArray[i] = array[array.Length - i - 1];
            }
            return revArray;
        }
        // Одномерный массив.
        public int[] GetArray(int cols, int minVal = 0, int maxVal = 1)
        {

            Helpers rnd = new Helpers();
            int[] array = new int[cols];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rnd.GetRnd(minVal, maxVal);
            }
            return array;
        }
        // Вывод двухмерного массива в консоль.
        public void PrintTwoDArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[j, i] + "\t" + "|");
                }
                Console.WriteLine();
            }
            return;
        }
        public void PrintTwoDArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write("|");
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[j, i] + "\t" + "|");
                }
                Console.WriteLine();
            }
            return;
        }

        // Вывод одномерного массива в консоль.
        public void PrintArray(int[] array)
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write(array[i] + " ");
                }
           
           return;
        }

        // Запрос размера создаваемого массива.
        public int AskArraySize(string massage)
        {
            Console.WriteLine(massage);
            return Convert.ToInt32(Console.ReadLine());
        }
        #endregion

        

        
    }
}
