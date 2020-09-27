using System;

namespace empwage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to employee wage computation program on master branch"):

            Random random = new Random();
            int fullTime = 1;
            int partTime = 2;
            int wagePerHour = 20;
            int workHours = 0;
            int totalEmpWage = 0;
            int workDaysPerMonth = 20;
            int totalMonthEmpWage = 0

            int empStatus = new Random(0,3);

            switch (empStatus) 
            {
                case 1:
                    workHours = 8;
                    break;
                case 2:
                    workHours = 4;
                    break;
                case 3:
                    workHours = 0;
                    break;
            }

           

            totalEmpWage = workHours * wagePerHour;
            Console.WriteLine("Total Employee Wage is :"+totalEmpWage);

            if (workDaysPerMonth == 20 ||workDaysPerMonth * workHours == 100 )
            {
                totalMonthEmpWage = totalEmpWage * workDaysPerMonth;
                Console.WriteLine("Total Month Employee Wage is :" + totalMonthEmpWage);
            }
        }
    }
}
