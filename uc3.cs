namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTS
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //VARIABLES
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //COMPUTATION
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 16;
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
