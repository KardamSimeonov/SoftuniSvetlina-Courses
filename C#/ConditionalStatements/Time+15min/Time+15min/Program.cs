﻿using System;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;

            if (min > 59) {
                hour += 1;
                min = min - 60;
            }

            if (hour > 23)
                hour = 0;
            if (min < 10)
             Console.WriteLine($"{hour}:0{min}");
            else
             Console.WriteLine($"{hour}:{min}");


        }
    }
}
