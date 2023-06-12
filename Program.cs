namespace UC4
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
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
