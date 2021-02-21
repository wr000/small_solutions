using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsAscending()) Console.WriteLine("Да, последовательность монотонно возрастает");
            else Console.WriteLine("Нет, последовательность не относится к монотонно возрастающим");
            Console.WriteLine("Введите любой символ для выхода из программы");
            Console.ReadLine();
        }
        static bool IsAscending()
        {
            bool onlyOneNumber = false;
            string exitCall = "#";
            Console.WriteLine("Введите последовательность целых чисел, каждую цифру с новой строчки. " +
                "После последнего символа последовательности введите #");
            int prevNumber = int.MinValue;
            int currentNumber;
            string myLine;
            while ((myLine = Console.ReadLine()) != exitCall)
            {
                if (!int.TryParse(myLine, out currentNumber))
                {
                    Console.WriteLine("Вы ввели не целое число");
                    IsAscending();
                }
                if (prevNumber == int.MinValue)
                    onlyOneNumber = true;
                else onlyOneNumber = false;
                if (currentNumber > prevNumber)
                {
                    prevNumber = currentNumber;
                }
                else return false;
            }
            if (prevNumber == int.MinValue) //если введено #
            {
                Console.WriteLine("Последовательность не была введена");
                IsAscending();
            }
            if (onlyOneNumber) //если введена последовательность из одного символа
            {
                Console.WriteLine("Последовательность состоит из одного числа");
                IsAscending();
            }

            return true;
        }
        //можно было бы оптимизировать использование памяти - сейчас текущая строка хранится и в виде строки, и в виде числа
        
    }
}
