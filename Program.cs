using System;

namespace UC_5
{
    class Program
    {
          
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public const int EMP_RATE_PER_HOUR = 20;
            public const int NUM_OF_WORKING_DAYS = 2;
            static void Main(string[] args)
        { 

            // VARIABLES
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            // COMPUTATION
            Random random = new Random();

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 16;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage for Day " + (day + 1) + " : " + empWage);
            }

            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}