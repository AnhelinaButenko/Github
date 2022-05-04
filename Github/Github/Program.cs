using System;
using System.Text;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Создать массив на N элементов, где N указывается с консольной строки.\nЗаполнить его случайными числами от 1 до 26 включительно. ");

            Console.WriteLine();

            Console.Write("Please, enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Random rand = new Random();

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 26);
                Console.WriteLine($"Array: {array[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("2.Создать 2 массива, где в 1 массиве будут значение только четных значений, а во втором нечетных.");

            Console.WriteLine();

            char[] arrayEven = new char[0];
            char[] arrayOdd = new char[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Array.Resize(ref arrayEven, arrayEven.Length + 1);
                    arrayEven[arrayEven.Length - 1] = Convert.ToChar(array[i]);
                    Console.WriteLine($"Element even: {array[i]}");
                }
                else
                {
                    Array.Resize(ref arrayOdd, arrayOdd.Length + 1);
                    arrayOdd[arrayOdd.Length - 1] = Convert.ToChar(array[i]);
                    Console.WriteLine($"Element odd: {array[i]}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("3.Заменить числа в 1 и 2 массиве на буквы английского алфавита.Значения ячеек этих массивов равны порядковому номеру каждой буквы.\nЕсли же буква является одной из списка (a, e, i, d, h, j) то она должна быть в верхнем регистре.");

            Console.WriteLine();

            string lettersString = "abcdefghijklmnopqrstuvwxyz";

            string specialStrings = "aeidhj";

            for (int i = 0; i < arrayEven.Length; i++)
            {
                var currentElement = arrayEven[i];
                var character = lettersString[Convert.ToInt32(currentElement) - 1];

                if (specialStrings.Contains(character))
                {
                    arrayEven[i] = char.ToUpper(character);
                }
                else
                {
                    arrayEven[i] = character;
                }
            }

            for (int i = 0; i < arrayEven.Length; i++)
            {
                Console.WriteLine($"Letters for even: {arrayEven[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayOdd.Length; i++)
            {
                var currentElement = arrayOdd[i];
                var character = lettersString[Convert.ToInt32(currentElement) - 1];

                if (specialStrings.Contains(character))
                {
                    arrayOdd[i] = char.ToUpper(character);
                }
                else
                {
                    arrayOdd[i] = character;
                }
            }

            for (int i = 0; i < arrayOdd.Length; i++)
            {
                Console.WriteLine($"Letters for odd: {arrayOdd[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("4.Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре.");

            Console.WriteLine();

            int countEven = 0, countOdd = 0;

            for (int i = 0; i < arrayEven.Length; i++)
            {
                if (char.IsUpper(arrayEven[i]))
                {
                    countEven++;
                }
            }

            for (int i = 0; i < arrayOdd.Length; i++)
            {
                if (char.IsUpper(arrayOdd[i]))
                {
                    countOdd++;
                }
            }

            Console.WriteLine();

            if (countEven > countOdd)
            {
                for (int i = 0; i < arrayEven.Length; i++)
                {
                    Console.WriteLine($"More uppercase letters in 1 array {arrayEven[i]}");
                }
            }
            else
            {
                for (int i = 0; i < arrayOdd.Length; i++)
                {
                    Console.WriteLine($"More uppercase letters in 2 array {arrayOdd[i]}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("5.Вывести оба массива на экран.Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.");

            Console.WriteLine();

            StringBuilder newWord = new StringBuilder();

            for (int i = 0; i < arrayEven.Length; i++)
            {
                newWord.Append($"{arrayEven[i]} ");
            }

            Console.WriteLine($"1 array: {newWord.ToString()}");

            Console.WriteLine();

            StringBuilder newWords = new StringBuilder();

            for (int i = 0; i < arrayOdd.Length; i++)
            {
                newWords.Append($"{arrayOdd[i]} ");
            }

            Console.WriteLine($"2 array: {newWords.ToString()}");
        }
    }
}
