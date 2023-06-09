namespace UC6
{
    class Program
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOURS_IN_MONTH = 10;

        static void Main(string[] args)
        {

            // VARIABLES
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays= 0;

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
                totalEmpHrs  += empHrs;
                Console.WriteLine("Day#:" +totalWorkingDays + "Emp Hrs :" +empHrs );
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
