using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestingSpeedLists
{
    public class TestingLists
    {
        private static TestingLists _instance;
        public static TestingLists GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TestingLists();
            }
            return _instance;
        }
        public void AddFirst(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddFirst start");
            sw.Start();
            aList1.AddFirst(val);
            sw.Stop();
            arrayRes[1, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddFirst(val);
            sw.Stop();
            arrayRes[3, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddFirst(val);
            sw.Stop();
            arrayRes[2, 1] = sw.Elapsed.TotalMilliseconds.ToString();

            sw.Start();
            lList2.AddFirst(val);
            sw.Stop();
            arrayRes[5, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddFirst(val);
            sw.Stop();
            arrayRes[4, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddFirst(val);
            sw.Stop();
            arrayRes[6, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddFirst(val);
            sw.Stop();
            arrayRes[7, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Reset();

            sw.Start();
            lList3.AddFirst(val);
            sw.Stop();

            arrayRes[8, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddFirst(val);
            sw.Stop();
            arrayRes[9, 1] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddFirst .............................\t done");

        }
        public void AddFirst(string[,] arrayRes, int[] array, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddFirst[] start");
            sw.Start();
            aList1.AddFirst(array);
            sw.Stop();
            arrayRes[1, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddFirst(array);
            sw.Stop();
            arrayRes[4, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddFirst(array);
            sw.Stop();
            arrayRes[7, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddFirst(array);
            sw.Stop();
            arrayRes[2, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.AddFirst(array);
            sw.Stop();
            arrayRes[5, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.AddFirst(array);
            sw.Stop();
            arrayRes[8, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddFirst(array);
            sw.Stop();
            arrayRes[3, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddFirst(array);
            sw.Stop();
            arrayRes[6, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddFirst(array);
            sw.Stop();
            arrayRes[9, 2] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddFirst[].............................\t done");

        }

        public void AddLast(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddLast start");
            sw.Start();
            aList1.AddLast(val);
            sw.Stop();
            arrayRes[1, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddLast(val);
            sw.Stop();
            arrayRes[4, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddLast(val);
            sw.Stop();
            arrayRes[7, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddLast(val);
            sw.Stop();
            arrayRes[2, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.AddLast(val);
            sw.Stop();
            arrayRes[5, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.AddLast(val);
            sw.Stop();
            arrayRes[8, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddLast(val);
            sw.Stop();
            arrayRes[3, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddLast(val);
            sw.Stop();
            arrayRes[6, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddLast(val);
            sw.Stop();
            arrayRes[9, 3] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddLast.............................\t done");
        }
        public void AddLast(string[,] arrayRes, int[] arrayTest, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddLast[] start");
            sw.Start();
            aList1.AddLast(arrayTest);
            sw.Stop();
            arrayRes[1, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddLast(arrayTest);
            sw.Stop();
            arrayRes[4, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddLast(arrayTest);
            sw.Stop();
            arrayRes[7, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddLast(arrayTest);
            sw.Stop();
            arrayRes[2, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.AddLast(arrayTest);
            sw.Stop();
            arrayRes[5, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.AddLast(arrayTest);
            sw.Stop();
            arrayRes[8, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddLast(arrayTest);
            sw.Stop();
            arrayRes[3, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddLast(arrayTest);
            sw.Stop();
            arrayRes[6, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddLast(arrayTest);
            sw.Stop();
            arrayRes[9, 4] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddLast[].............................\t done");
        }

        public void AddAt(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {

            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddAt start");
            sw.Start();
            aList1.AddAt(98, 10);
            sw.Stop();
            arrayRes[1, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddAt(99998, 10);
            sw.Stop();
            arrayRes[4, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddAt(999998, 10);
            sw.Stop();
            arrayRes[7, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddAt(98, 10);
            sw.Stop();
            arrayRes[2, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.AddAt(99998, 10);
            sw.Stop();
            arrayRes[5, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.AddAt(999998, 10);
            sw.Stop();
            arrayRes[8, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddAt(98, 10);
            sw.Stop();
            arrayRes[3, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddAt(99998, 10);
            sw.Stop();
            arrayRes[6, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddAt(999998, 10);
            sw.Stop();
            arrayRes[9, 5] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddAt.............................\t done");
        }
        public void AddAt(string[,] arrayRes, int[] arrayTest, int[] array1, int[] array2, int[] array3)
        {
            Helpers hp = new Helpers();
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("AddAt[] start...");
            sw.Start();
            aList1.AddAt(98, arrayTest);
            sw.Stop();
            arrayRes[1, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.AddAt(99998, arrayTest);
            sw.Stop();
            arrayRes[4, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.AddAt(999998, arrayTest);
            sw.Stop();
            arrayRes[7, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.AddAt(98, arrayTest);
            sw.Stop();
            arrayRes[2, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.AddAt(99998, arrayTest);
            sw.Stop();
            arrayRes[5, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.AddAt(999998, arrayTest);
            sw.Stop();
            arrayRes[8, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.AddAt(98, arrayTest);
            sw.Stop();
            arrayRes[3, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.AddAt(99998, arrayTest);
            sw.Stop();
            arrayRes[6, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.AddAt(999998, arrayTest);
            sw.Stop();
            arrayRes[9, 6] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("AddAt[].............................\t done");
        }
        public void RemoveFirst(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("RemoveFirst start...");
            sw.Start();
            aList1.RemoveFirst();
            sw.Stop();
            arrayRes[1, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.RemoveFirst();
            sw.Stop();
            arrayRes[4, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.RemoveFirst();
            sw.Stop();
            arrayRes[7, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.RemoveFirst();
            sw.Stop();
            arrayRes[2, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.RemoveFirst();
            sw.Stop();
            arrayRes[5, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.RemoveFirst();
            sw.Stop();
            arrayRes[8, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.RemoveFirst();
            sw.Stop();
            arrayRes[3, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.RemoveFirst();
            sw.Stop();
            arrayRes[6, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.RemoveFirst();
            sw.Stop();
            arrayRes[9, 7] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("RemoveFirst........................\t done");
        }
        public void RemoveLast(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("RemoveLast start...");
            sw.Start();
            aList1.RemoveLast();
            sw.Stop();
            arrayRes[1, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.RemoveLast();
            sw.Stop();
            arrayRes[4, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.RemoveLast();
            sw.Stop();
            arrayRes[7, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.RemoveLast();
            sw.Stop();
            arrayRes[2, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.RemoveLast();
            sw.Stop();
            arrayRes[5, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.RemoveLast();
            sw.Stop();
            arrayRes[8, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.RemoveLast();
            sw.Stop();
            arrayRes[3, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.RemoveLast();
            sw.Stop();
            arrayRes[6, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.RemoveLast();
            sw.Stop();
            arrayRes[9, 8] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("RemoveLast........................\t done");
        }
        public void RemoveAt(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("RemoveAt start...");
            sw.Start();
            aList1.RemoveAt(98);
            sw.Stop();
            arrayRes[1, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList2.RemoveAt(99998);
            sw.Stop();
            arrayRes[4, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            aList3.RemoveAt(999998);
            sw.Stop();
            arrayRes[7, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();


            sw.Start();
            lList1.RemoveAt(98);
            sw.Stop();
            arrayRes[2, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList2.RemoveAt(99998);
            sw.Stop();
            arrayRes[5, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList3.RemoveAt(999998);
            sw.Stop();
            arrayRes[8, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();




            sw.Start();
            dList1.RemoveAt(98);
            sw.Stop();
            arrayRes[3, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList2.RemoveAt(99998);
            sw.Stop();
            arrayRes[6, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList3.RemoveAt(999998);
            sw.Stop();
            arrayRes[9, 9] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("RemoveAt.............................\t done");
        }
        public void RemoveAll(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("ArrayList RemoveAll 100 start...");
            sw.Start();
            aList1.RemoveAll(val);
            sw.Stop();
            arrayRes[1, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("ArrayList RemoveAll 10 000 start...");
            sw.Start();
            aList2.RemoveAll(val);
            sw.Stop();
            arrayRes[4, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("ArrayList RemoveAll 1 000 000 start...");
            sw.Start();
            aList3.RemoveAll(val);
            sw.Stop();
            arrayRes[7, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");

            Console.WriteLine("LinkedList RemoveAll 100 start...");
            sw.Start();
            lList1.RemoveAll(val);
            sw.Stop();
            arrayRes[2, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("LinkedList RemoveAll 10 000 start...");
            sw.Start();
            lList2.RemoveAll(val);
            sw.Stop();
            arrayRes[5, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("LinkedList RemoveAll 1 000 000 start...");
            sw.Start();
            lList3.RemoveAll(val);
            sw.Stop();
            arrayRes[8, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("DoubleLinkedList RemoveAll 100 start...");
            sw.Start();
            dList1.RemoveAll(val);
            sw.Stop();
            arrayRes[3, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("DoubleLinkedList RemoveAll 10 000 start...");
            sw.Start();
            dList2.RemoveAll(val);
            sw.Stop();
            arrayRes[6, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("DoubleLinkedList RemoveAll 1 000 000 start...");
            sw.Start();
            dList3.RemoveAll(val);
            sw.Stop();
            arrayRes[9, 10] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("RemoveAll.............................\t done");
        }
        public void Contains(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Contains start...");
            sw.Start();
            aList1.Contains(val);
            sw.Stop();
            arrayRes[1, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Contains(val);
            sw.Stop();
            arrayRes[4, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Contains(val);
            sw.Stop();
            arrayRes[7, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.Contains(val);
            sw.Stop();
            arrayRes[2, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Contains(val);
            sw.Stop();
            arrayRes[5, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Contains(val);
            sw.Stop();
            arrayRes[8, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Contains(val);
            sw.Stop();
            arrayRes[3, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Contains(val);
            sw.Stop();
            arrayRes[6, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Contains(val);
            sw.Stop();
            arrayRes[9, 11] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Contains.............................\t done");
        }
        public void Get(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Get start...");
            sw.Start();
            aList1.Get(val);
            sw.Stop();
            arrayRes[1, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Get(val);
            sw.Stop();
            arrayRes[4, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Get(val);
            sw.Stop();
            arrayRes[7, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.Get(val);
            sw.Stop();
            arrayRes[2, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Get(val);
            sw.Stop();
            arrayRes[5, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Get(val);
            sw.Stop();
            arrayRes[8, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Get(val);
            sw.Stop();
            arrayRes[3, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Get(val);
            sw.Stop();
            arrayRes[6, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Get(val);
            sw.Stop();
            arrayRes[9, 12] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Get.............................\t done");
        }
        public void GetFirst(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("GetFirst start...");
            sw.Start();
            aList1.GetFirst();
            sw.Stop();
            arrayRes[1, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.GetFirst();
            sw.Stop();
            arrayRes[4, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.GetFirst();
            sw.Stop();
            arrayRes[7, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.GetFirst();
            sw.Stop();
            arrayRes[2, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.GetFirst();
            sw.Stop();
            arrayRes[5, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.GetFirst();
            sw.Stop();
            arrayRes[8, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.GetFirst();
            sw.Stop();
            arrayRes[3, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.GetFirst();
            sw.Stop();
            arrayRes[6, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.GetFirst();
            sw.Stop();
            arrayRes[9, 13] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("GetFirst.............................\t done");
        }
        public void GetLast(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("GetLast start...");
            sw.Start();
            aList1.GetLast();
            sw.Stop();
            arrayRes[1, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.GetLast();
            sw.Stop();
            arrayRes[4, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.GetLast();
            sw.Stop();
            arrayRes[7, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.GetLast();
            sw.Stop();
            arrayRes[2, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.GetLast();
            sw.Stop();
            arrayRes[5, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.GetLast();
            sw.Stop();
            arrayRes[8, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.GetLast();
            sw.Stop();
            arrayRes[3, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.GetLast();
            sw.Stop();
            arrayRes[6, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.GetLast();
            sw.Stop();
            arrayRes[9, 14] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("GetLast.............................\t done");
        }
        public void GetSize(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("GetSize start...");
            sw.Start();
            aList1.GetSize();
            sw.Stop();
            arrayRes[1, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.GetSize();
            sw.Stop();
            arrayRes[4, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.GetSize();
            sw.Stop();
            arrayRes[7, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.GetSize();
            sw.Stop();
            arrayRes[2, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.GetSize();
            sw.Stop();
            arrayRes[5, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.GetSize();
            sw.Stop();
            arrayRes[8, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.GetSize();
            sw.Stop();
            arrayRes[3, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.GetSize();
            sw.Stop();
            arrayRes[6, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.GetSize();
            sw.Stop();
            arrayRes[9, 15] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("GetSize.............................\t done");
        }
        public void IndexOf(string[,] arrayRes, int val, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("IndexOf start...");
            sw.Start();
            aList1.IndexOf(val);
            sw.Stop();
            arrayRes[1, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.IndexOf(val);
            sw.Stop();
            arrayRes[4, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.IndexOf(val);
            sw.Stop();
            arrayRes[7, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.IndexOf(val);
            sw.Stop();
            arrayRes[2, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.IndexOf(val);
            sw.Stop();
            arrayRes[5, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.IndexOf(val);
            sw.Stop();
            arrayRes[8, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.IndexOf(val);
            sw.Stop();
            arrayRes[3, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.IndexOf(val);
            sw.Stop();
            arrayRes[6, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.IndexOf(val);
            sw.Stop();
            arrayRes[9, 16] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("IndexOf.............................\t done");
        }
        public void IndexOfMax(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("IndexOfMax start...");
            sw.Start();
            aList1.IndexOfMax();
            sw.Stop();
            arrayRes[1, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.IndexOfMax();
            sw.Stop();
            arrayRes[4, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.IndexOfMax();
            sw.Stop();
            arrayRes[7, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.IndexOfMax();
            sw.Stop();
            arrayRes[2, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.IndexOfMax();
            sw.Stop();
            arrayRes[5, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.IndexOfMax();
            sw.Stop();
            arrayRes[8, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.IndexOfMax();
            sw.Stop();
            arrayRes[3, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.IndexOfMax();
            sw.Stop();
            arrayRes[6, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.IndexOfMax();
            sw.Stop();
            arrayRes[9, 17] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("IndexOfMax.............................\t done");
        }
        public void IndexOfMin(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("IndexOfMax start...");
            sw.Start();
            aList1.IndexOfMin();
            sw.Stop();
            arrayRes[1, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.IndexOfMin();
            sw.Stop();
            arrayRes[4, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.IndexOfMin();
            sw.Stop();
            arrayRes[7, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.IndexOfMin();
            sw.Stop();
            arrayRes[2, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.IndexOfMin();
            sw.Stop();
            arrayRes[5, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.IndexOfMin();
            sw.Stop();
            arrayRes[8, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.IndexOfMin();
            sw.Stop();
            arrayRes[3, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.IndexOfMin();
            sw.Stop();
            arrayRes[6, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.IndexOfMin();
            sw.Stop();
            arrayRes[9, 18] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("IndexOfMax.............................\t done");
        }
        public void Max(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Max start...");
            sw.Start();
            aList1.Max();
            sw.Stop();
            arrayRes[1, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Max();
            sw.Stop();
            arrayRes[4, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Max();
            sw.Stop();
            arrayRes[7, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.Max();
            sw.Stop();
            arrayRes[2, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Max();
            sw.Stop();
            arrayRes[5, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Max();
            sw.Stop();
            arrayRes[8, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Max();
            sw.Stop();
            arrayRes[3, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Max();
            sw.Stop();
            arrayRes[6, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Max();
            sw.Stop();
            arrayRes[9, 19] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Max.............................\t done");
        }
        public void Min(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Min start...");
            sw.Start();
            aList1.Min();
            sw.Stop();
            arrayRes[1, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Min();
            sw.Stop();
            arrayRes[4, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Min();
            sw.Stop();
            arrayRes[7, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList1.Min();
            sw.Stop();
            arrayRes[2, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Min();
            sw.Stop();
            arrayRes[5, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Min();
            sw.Stop();
            arrayRes[8, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Min();
            sw.Stop();
            arrayRes[3, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Min();
            sw.Stop();
            arrayRes[6, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Min();
            sw.Stop();
            arrayRes[9, 20] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Min.............................\t done");
        }
        public void Set(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Reverse start...");
            sw.Start();
            aList1.Set(98, 100);
            sw.Stop();
            arrayRes[1, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Set(99998, 100);
            sw.Stop();
            arrayRes[4, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Set(999998, 100);
            sw.Stop();
            arrayRes[7, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.Set(98, 100);
            sw.Stop();
            arrayRes[2, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Set(99998, 100);
            sw.Stop();
            arrayRes[5, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Set(999998, 100);
            sw.Stop();
            arrayRes[8, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Set(98, 100);
            sw.Stop();
            arrayRes[3, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Set(99998, 100);
            sw.Stop();
            arrayRes[6, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Set(999998, 100);
            sw.Stop();
            arrayRes[9, 21] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Reverse.............................\t done");
        }
        public void Reverse(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Reverse start...");
            sw.Start();
            aList1.Reverse();
            sw.Stop();
            arrayRes[1, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.Reverse();
            sw.Stop();
            arrayRes[4, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.Reverse();
            sw.Stop();
            arrayRes[7, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.Reverse();
            sw.Stop();
            arrayRes[2, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.Reverse();
            sw.Stop();
            arrayRes[5, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.Reverse();
            sw.Stop();
            arrayRes[8, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.Reverse();
            sw.Stop();
            arrayRes[3, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.Reverse();
            sw.Stop();
            arrayRes[6, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.Reverse();
            sw.Stop();
            arrayRes[9, 22] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("Reverse.............................\t done");
        }
        public void ToArray(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("ToArray start...");
            sw.Start();
            aList1.ToArray();
            sw.Stop();
            arrayRes[1, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList2.ToArray();
            sw.Stop();
            arrayRes[4, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            aList3.ToArray();
            sw.Stop();
            arrayRes[7, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            lList1.ToArray();
            sw.Stop();
            arrayRes[2, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList2.ToArray();
            sw.Stop();
            arrayRes[5, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            lList3.ToArray();
            sw.Stop();
            arrayRes[8, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();

            sw.Start();
            dList1.ToArray();
            sw.Stop();
            arrayRes[3, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList2.ToArray();
            sw.Stop();
            arrayRes[6, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            sw.Start();
            dList3.ToArray();
            sw.Stop();
            arrayRes[9, 23] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ToArray.............................\t done");
        }
        public void Sort(string[,] arrayRes, int[] array1, int[] array2, int[] array3)
        {
            ArrayList aList1 = new ArrayList(array1);
            ArrayList aList2 = new ArrayList(array2);
            ArrayList aList3 = new ArrayList(array3);
            LinkedList lList1 = new LinkedList(array1);
            LinkedList lList2 = new LinkedList(array2);
            LinkedList lList3 = new LinkedList(array3);
            DoubleLinkedList dList1 = new DoubleLinkedList(array1);
            DoubleLinkedList dList2 = new DoubleLinkedList(array2);
            DoubleLinkedList dList3 = new DoubleLinkedList(array3);
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("ArrayList sort 100 start...");
            sw.Start();
            aList1.Sort();
            sw.Stop();
            arrayRes[1, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("ArrayList sort 10 000 start...");
            sw.Start();
            aList2.Sort();
            sw.Stop();
            arrayRes[4, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("ArrayList sort 1 000 000 start...");
            sw.Start();
            aList3.Sort();
            sw.Stop();
            arrayRes[7, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            Console.WriteLine("ArrayList sort FINISH...");

            Console.WriteLine("DoubleLinkedList 100 sort start...");
            sw.Start();
            dList1.Head = dList1.Sort(dList1.Head);
            sw.Stop();
            arrayRes[3, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            //Console.WriteLine("DoubleLinkedList 10 000 sort start...");
            //sw.Start();
            //dList2.Head = dList2.Sort(dList2.Head);
            //sw.Stop();
            //arrayRes[6, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            //sw.Reset();
            //Console.WriteLine("ok...");
            //Console.WriteLine("DoubleLinkedList 1 000 000 sort start...");
            //sw.Start();
            //dList3.Head = dList3.Sort(dList3.Head);
            //sw.Stop();
            //arrayRes[9, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            //sw.Reset();
            //Console.WriteLine("ok...");
            //Console.WriteLine("DoubleLinkedList sort FINISH...");

            Console.WriteLine("LinkedList sort 100 start...");
            sw.Start();
            lList1.Head = lList1.Sort(lList1.Head);
            sw.Stop();
            arrayRes[2, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            sw.Reset();
            Console.WriteLine("ok...");
            //Console.WriteLine("LinkedList sort 10 000 start...");
            //sw.Start();
            //lList2.Head = lList2.Sort(lList2.Head);
            //sw.Stop();
            //arrayRes[5, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            //sw.Reset();
            //Console.WriteLine("ok...");
            //Console.WriteLine("LinkedList sort 10 000 ok...");
            //sw.Start();
            //lList3.Head = lList3.Sort(lList3.Head);
            //sw.Stop();
            //arrayRes[8, 24] = sw.Elapsed.TotalMilliseconds.ToString();
            //sw.Reset();
            //Console.WriteLine("ok...");
            //Console.WriteLine("LinkedList sort 1 000 000 ok...");
            //Console.WriteLine("LinkedList sort FINISH...");

            Console.WriteLine("Sort.............................\t done");
        }
    }
    
}
