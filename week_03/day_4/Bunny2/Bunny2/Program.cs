﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write down the number of bunnies!");
            int bunnies = 0;
            bunnies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BunnyEars(bunnies));
            Console.ReadLine();
            
        }

        public static int BunnyEars(int number)
        {
            if (number == 1)
            {
                return 2;
            }
            if (number % 2 ==0)
            {
                return 3 + BunnyEars(--number);
            }
            else
            {
                return 2 + BunnyEars(--number);
            }

        }
    }
}