using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число секунд");
            int seconds;
            if (!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.WriteLine("Вы ввели не целое число");
            }
            else
                Console.WriteLine(timeString(seconds));
            Console.WriteLine("Введите любой символ для выхода из программы");
            Console.ReadLine();
        }
        static string timeString(int seconds)
        {
            int secondsInDay; //переменная для наглядности
            int _hours;
            int _minutes;
            int _seconds;

            if (seconds > 86400)
            {
                secondsInDay = seconds % 86400;
            }
            else secondsInDay = seconds;

            _hours = (int)secondsInDay / 3600;
            int hoursInSeconds = _hours * 3600;
            _minutes = (int)((secondsInDay - hoursInSeconds) / 60);
            _seconds = secondsInDay - hoursInSeconds - _minutes * 60;

            string additionalZero1 = "";
            string additionalZero2 = "";
            string additionalZero3 = "";

            if (_hours < 10)
                additionalZero1 = "0";
            if (_minutes < 10)
                additionalZero2 = "0";
            if (_seconds < 10)
                additionalZero3 = "0";

            return ("Время на электронных часах " + additionalZero1 + _hours + ":" +
                additionalZero2 + _minutes + ":"
                + additionalZero3 + _seconds);
        }
    }
    /*
     * var myStopwatch = new System.Diagnostics.Stopwatch();
       myStopwatch.Start();
            //Метод
       myStopwatch.Stop();
       Console.WriteLine("Время = {0}", myStopwatch.Elapsed);
       //пробовала заменять деление умножением и сложением, но выигрыша по времени не было

       //пробовала форматирование DateTime объектами
       //пробовала поиск целой части через Math.Truncate, но остановилась на приведении типа
     * */
}
