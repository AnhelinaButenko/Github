using System;
using System.Text;

namespace Github
{
    class Program
    {
        static int[] GetArrayWithRandomValues(int from, int to, int length)
        {
            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(from, to);
                Console.WriteLine($"Array: {array[i]}");
            }

            return array;
        }

        static void GetTwoArrays(int[] array, out char[] arrayEven, out char[] arrayOdd)
        {
            arrayEven = new char[0];
            arrayOdd = new char[0];

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
        }

        static void ReplaceNumbersToLettersAndUpperSpecialChar(char[] array)
        {
            string lettersString = "abcdefghijklmnopqrstuvwxyz";

            string specialStrings = "aeidhj";

            for (int i = 0; i < array.Length; i++)
            {
                var currentElement = array[i];
                var character = lettersString[Convert.ToInt32(currentElement) - 1];

                if (specialStrings.Contains(character))
                {
                    array[i] = char.ToUpper(character);
                }
                else
                {
                    array[i] = character;
                }
            }
        }

        static int СountUppercaseLatters(char[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    count++;
                }
            }

            return count;
        }

        static void DisplayWhichArrayMoreUppercaseLetters(char[] arrayEven, char[] arrayOdd, int countEven, int countOdd)
        {
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
        }

        static void DisplayArraysByASpase(char[] array)
        {
            StringBuilder newWord = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                newWord.Append($"{array[i]} ");
            }

            Console.WriteLine($"1 array: {newWord.ToString()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1.Create an array with N elements, where N is specified from the console line.\nFill it with random numbers from 1 to 26 inclusive. ");

            Console.WriteLine();

            Console.Write("Please, enter the length of the array: ");

            int length = int.Parse(Console.ReadLine());

            int[] array = GetArrayWithRandomValues(1, 26, length);

            Console.WriteLine();

            Console.WriteLine("2.Create 2 arrays, where in 1 array there will be only even values, and in the second - odd.");

            Console.WriteLine();

            GetTwoArrays(array, out var arrayEven, out var arrayOdd);

            Console.WriteLine();

            Console.WriteLine("3.Replace numbers in arrays 1 and 2 with letters of the English alphabet. The cell values of these arrays are equal to the serial number of each letter.\nIf the letter is one of the list (a, e, i, d, h, j), then it must be in uppercase .");

            Console.WriteLine();

            ReplaceNumbersToLettersAndUpperSpecialChar(arrayEven);

            for (int i = 0; i < arrayEven.Length; i++)
            {
                Console.WriteLine($"Letters for even: {arrayEven[i]}");
            }

            ReplaceNumbersToLettersAndUpperSpecialChar(arrayOdd);

            Console.WriteLine();

            for (int i = 0; i < arrayOdd.Length; i++)
            {
                Console.WriteLine($"Letters for even: {arrayOdd[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("4.Display the result of which array contains more uppercase letters.");

            Console.WriteLine();

            int countEven = 0, countOdd = 0;

            countEven = СountUppercaseLatters(arrayEven);

            countOdd = СountUppercaseLatters(arrayOdd);

            Console.WriteLine();

            DisplayWhichArrayMoreUppercaseLetters(arrayEven, arrayOdd, countEven, countOdd);

            Console.WriteLine();

            Console.WriteLine("5.Display both arrays on the screen. Each of the arrays must be displayed on 1 line, where its values are separated by a space.");

            Console.WriteLine();

            DisplayArraysByASpase(arrayEven);

            DisplayArraysByASpase(arrayOdd);
        }
    }
}