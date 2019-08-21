using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1. yes,no,no,no,yes,no,no,no
 2. a)6
    b)3
    c)3
    d)11
    e)error
 */



namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             3.
             int[] numbers = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
             for(int i = 0; i< 10; ++i)
             {
                 Console.WriteLine(numbers[i]);
                 Console.ReadKey();
             }
             */

            /* 
            4.
            int[] number = new int[5];

            for(int i=0; i < 5; ++i)
            {
                int.TryParse(Console.ReadLine(), out number[i]);
                
            }

            Array.Reverse(number);

            foreach(int value in number)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
            */

            /*
            5.
            int[] number = new int[10];

            for (int i = 0; i < 10; ++i)
            {
                int.TryParse(Console.ReadLine(), out number[i]);
                
            }

            Console.WriteLine(number.Max());
            Console.WriteLine(number.Min());

            Console.ReadLine();
            */

            /*
            6.
            int row, col;
            int[,] map = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (row = 0; row < 3; ++row)
            {   
                for (col = 0; col < 3; ++col)
                {
                    Console.Write(map[row, col]);
                }
                Console.WriteLine(); 
            }
            Console.ReadLine();
            */

            /*
            7.
            int[,] days = new int[6, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };
            int sum;

            for (int row = 0; row < 6; ++row)
            {
                sum = 0;
                for(int col = 0; col < 3; ++col)
                {
                    sum += days[row, col];
                    Console.Write($" {days[row, col]}");
                }
                Console.WriteLine($" Sum of the row {row} = {sum}");
               
            }

            for (int col = 0; col < 3; ++col)
            {
                sum = 0;
                for (int row = 0; row < 6; ++row)
                {
                    sum += days[row, col];
                    Console.Write($" {days[row, col]}");
                }
                Console.WriteLine($" Sum of the column {col} = {sum}");

            }

            Console.ReadLine();
            */

            /*
            8.
            int[] health = new int[5] { 100, 100, 100, 100, 100 };
            Console.WriteLine("Enter a number between 0 to 4");
            int target = 0;

            for (int i = 0; i < 5; ++i)
            {
                
                int.TryParse(Console.ReadLine(), out target);
                Random random = new Random();
                int monsterAttack = random.Next(1, 100);

                if(health[target] > 0)
                {
                    health[target] -= monsterAttack;
                }
                else
                {
                    Console.WriteLine("Cant Attack");
                }
               
            }

            foreach (int value in health)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
            */

            int[,] chart = new int[3, 7];
            Input eg = new Input();
            int food;

            for(int dgn = 0; dgn < 3; ++dgn)
            {
                for (int days = 0; days < 7; ++days)
                {
                    int.TryParse(eg.Ask($"How much did Dragon {dgn} eat on day {days}?"), out food);

                    chart[dgn, days] = food;
                } 
            }

            float sum = 0;
            float average;

            for(int dgn = 0; dgn < 3; ++dgn)
            {
                for(int days = 0; days < 7; ++days)
                {
                    sum += chart[dgn, days];    
                }
            }
            average = sum / 21.0f;
            Console.WriteLine($"The total amount of food eaten per day is {average}");
            Console.ReadLine();

            for (int dgn = 0; dgn < 3; ++dgn)
            {
                sum = 0;
                for (int days = 0; days < 7; ++days)
                {
                    sum += chart[dgn, days];
                }
                average = sum / 7.0f;
                Console.WriteLine($"Average for dragon {dgn} is {average}");
            }
            Console.ReadLine();

            int maxSoFar = 0;
            int dragon = -1;
            int day = -1;
         
            for (int dgn = 0; dgn < 3; ++dgn)
            { 
                for (int days = 0; days < 7; ++days)
                {
                    if (maxSoFar < chart[dgn, days])
                    {
                        maxSoFar = chart[dgn, days];
                        dragon = dgn;
                        day = days;
                    }
                }  
            }
            Console.WriteLine($"Dragon {dragon} ate the most today: {maxSoFar} on {day}");
            Console.ReadLine();

            int minSoFar = int.MaxValue;

            for (int dgn = 0; dgn < 3; ++dgn)
            {
                for (int days = 0; days < 7; ++days)
                {
                    if (minSoFar > chart[dgn, days])
                    {
                        minSoFar = chart[dgn, days];
                        dragon = dgn;
                        day = days;
                    }
                }
            }
            Console.WriteLine($"Dragon {dragon} ate the least today: {minSoFar} on {day}");
            Console.ReadLine();

        }
    }
}
