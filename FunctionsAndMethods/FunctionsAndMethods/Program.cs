using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringTask();
            //ArrayTask();
            /*
            int [] arr = RandomArray(5);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            */

            /*
            int[] arr = RandomArray(5, 100);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }

            Console.WriteLine();
            */

            int[] arr = RandomArray(5, 92, 100);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }

            Console.WriteLine();
        }

        static void StringTask()
        {
            string str;
            uint totalChars;

            Console.WriteLine("Введите символ");

            str = Console.ReadLine();

            Console.WriteLine("Введите количество символов");

            totalChars = uint.Parse(Console.ReadLine());

            PrintString(str, totalChars);
        }

        static void PrintString(string str, uint totalChars)
        {
            for (int i = 0; i < totalChars; i++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
        }

        static void ArrayTask()
        {
            int[] arr = { 3, 1, 5, 33, 21, 232 };
            int number;

            Console.WriteLine("Введите число, индекс которого Вы ищете");
            number = int.Parse(Console.ReadLine());


            int index = FindIndexInArray(arr, number);

            if (index == -1)
            {
                Console.WriteLine($"Указаного элемента({number}) не существует в массиве");
                return;
            }

            Console.WriteLine($"Индекс указаного элемента({number}) в массиве: {index}");

        }

        static int FindIndexInArray(int [] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        static int [] RandomArray(uint elementsCount)
        {
            int[] arr = new int[elementsCount];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }

            return arr;
        }

        static int[] RandomArray(uint elementsCount, int maxValue)
        {
            int[] arr = new int[elementsCount];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(maxValue);
            }

            return arr;
        }

        static int[] RandomArray(uint elementsCount, int minValue, int maxValue)
        {
            int[] arr = new int[elementsCount];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }

            return arr;
        }
    }
}
