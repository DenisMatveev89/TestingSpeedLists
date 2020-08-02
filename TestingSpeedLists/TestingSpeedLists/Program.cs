using System;

namespace TestingSpeedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrayRes = new string[10, 25];
            Helpers hp = new Helpers();
            int[] arrayTest = new int[] { 1, 2, 3, 4, 56, 7, 8, 9, 5, 3, 2, 1, 4, 6, 7, 8 };
            int[] array1 = hp.GetArray(100, -10, 24);
            int[] array2 = hp.GetArray(100000, -10, 24);
            int[] array3 = hp.GetArray(1000000, -10, 24);
            Console.WriteLine("\n*************************************************************************************************************************************************");
            Console.WriteLine("Random lists creation - complete...");
            Console.WriteLine("\n*************************************************************************************************************************************************");
            #region Табличка
            arrayRes[0, 1] = "AddFirst";
            arrayRes[0, 2] = "AddFirst[]";
            arrayRes[0, 3] = "AddLast";
            arrayRes[0, 4] = "AddLast[]";
            arrayRes[0, 5] = "AddAt";
            arrayRes[0, 6] = "AddAt[]";
            arrayRes[0, 7] = "RemoveFirst";
            arrayRes[0, 8] = "RemoveLast";
            arrayRes[0, 9] = "RemoveAt";
            arrayRes[0, 10] = "RemoveAll";
            arrayRes[0, 11] = "Contains";
            arrayRes[0, 12] = "Get";
            arrayRes[0, 13] = "GetFirst";
            arrayRes[0, 14] = "GetLast";
            arrayRes[0, 15] = "GetSize";
            arrayRes[0, 16] = "IndexOf";
            arrayRes[0, 17] = "IndexOfMax";
            arrayRes[0, 18] = "IndexOfMin";
            arrayRes[0, 19] = "Max";
            arrayRes[0, 20] = "Min";
            arrayRes[0, 21] = "Set";
            arrayRes[0, 22] = "Reverse";
            arrayRes[0, 23] = "ToArray";
            arrayRes[0, 24] = "Sort";


            arrayRes[1, 0] = "ArrayList";
            arrayRes[2, 0] = "LinkedList";
            arrayRes[3, 0] = "DoubleList";
            arrayRes[4, 0] = "ArrayList";
            arrayRes[5, 0] = "LinkedList";
            arrayRes[6, 0] = "DoubleList";
            arrayRes[7, 0] = "ArrayList";
            arrayRes[8, 0] = "LinkedList";
            arrayRes[9, 0] = "DoubleList";
            arrayRes[0, 0] = "";
            #endregion
            TestingLists test = TestingLists.GetInstance();

            test.AddFirst(arrayRes, arrayTest, array1, array2, array3);
            test.AddLast(arrayRes, 100, array1, array2, array3);
            test.AddLast(arrayRes, arrayTest, array1, array2, array3);
            test.AddAt(arrayRes, 100, array1, array2, array3);
            test.AddAt(arrayRes, arrayTest, array1, array2, array3);
            test.RemoveFirst(arrayRes, array1, array2, array3);
            test.RemoveLast(arrayRes, array1, array2, array3);
            test.RemoveAt(arrayRes, array1, array2, array3);
            test.RemoveAll(arrayRes, 12, array1, array2, array3);
            test.Contains(arrayRes, 0, array1, array2, array3);
            test.Get(arrayRes, 12, array1, array2, array3);
            test.GetFirst(arrayRes, array1, array2, array3);
            test.GetLast(arrayRes, array1, array2, array3);
            test.GetSize(arrayRes, array1, array2, array3);
            test.IndexOf(arrayRes, 12, array1, array2, array3);
            test.IndexOfMax(arrayRes, array1, array2, array3);
            test.IndexOfMin(arrayRes, array1, array2, array3); ;
            test.Max(arrayRes, array1, array2, array3);
            test.Min(arrayRes, array1, array2, array3);
            test.Set(arrayRes, array1, array2, array3);
            test.Reverse(arrayRes, array1, array2, array3);
            test.ToArray(arrayRes, array1, array2, array3);
            test.Sort(arrayRes, array1, array2, array3);

            for (int i = 0; i < arrayRes.GetLength(1); i++)
            {
                for (int j = 0; j < arrayRes.GetLength(0); j++)
                {
                    if (arrayRes[j, i] == null)
                    {
                        arrayRes[j, i] = "";
                    }
                    Console.Write(arrayRes[j, i].PadRight(14));
                }
                Console.WriteLine();
            }

        }
    }
}
