using System;



namespace ConsoleApplication

{

    class Program

    {

        public static int BinarySearch(int[] array, int value)

        {
            //код поиска значения value в массиве array
            int first = 0;
            int last = array.Length-1;
            while (first < last)
            {
                int middle = (first + last) / 2;

                if (array[middle]<value)
                {
                    first = middle+1;
                }

                else
                {
                    last = middle;
                }
            }

            if (last < 0 || array[first] != value)
            {
                return -1;
            }
            else
            { 
                return first;
            }
        }



        static void Main(string[] args)

        {
            TestSearchElements();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatingElements();
            TestEmptyArray();
            TestBigArray();



            Console.ReadKey();

        }
        private static void TestSearchElements()
        {
            int[] justNumbers = new[] { 3, 5, 7, 9, 11 };
            if(BinarySearch(justNumbers,7)!=2)
            {
                Console.WriteLine("! Поиск не нашел число 7 среди чисел {3,5,7,9,11}");
            }
            else
            {
                Console.WriteLine("Поиск в массиве из 5 элементов работает норм");
            }
        }

        private static void TestNegativeNumbers()

        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()

        {
             //Тестирование поиска отсутствующего элемента
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");

        }
        private static void TestRepeatingElements()
        {
            //Поиск элемента, повторяющегося несколько раз
            int[] repeatNum = new[] { 3, 5, 7, 7, 9, 11 };
            if (BinarySearch(repeatNum, 7) != 2)
                Console.WriteLine("!Поиск не нашел 3 среди чисел { 3, 5, 7, 7, 9, 11 }");
            else 
                Console.WriteLine("Поиск повторяющегося элемента работает норм");
        }
        private static void TestEmptyArray()
        {
            //Поиск в пустом массиве 
            int[] Emptynumbers = new int[0];
            if (BinarySearch(Emptynumbers, 5) != -1)
                Console.WriteLine("!Поиск нашёл число 5 в пустом массиве");
            else
                Console.WriteLine("Поиск в пустом массиве работает норм");

        }
        private static void TestBigArray()
        {
            //Поиск в массиве из 100001 элементов
            int[] manyNum = new int[100001];
            for (int i = 0; i < manyNum.Length; i++)
                manyNum[i] = i;
                    if (BinarySearch(manyNum, 14488) != 14488)
                Console.WriteLine("!Поиск не нашел число 14488 в массиве из 100001 элемента");
            else
                Console.WriteLine("Все чётко");

        }
    }
}
