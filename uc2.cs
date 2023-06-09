﻿namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTS
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //VARIABLES
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //COMPUTATION
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
                
        }
    }
