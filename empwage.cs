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

            int empStatus = new Random(0,3);
            if (empStatus = fullTime)
            {
                Console.WriteLine("Employee is present");
                workHours = 8;
            }
            else if(empStatus == partTime)
            {
                Console.WriteLine("Employee is partTime");
                workHours = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                workHours = 0;
            }

            totalEmpWage = workHours * wagePerHour;
            Console.WriteLine("Total Employee Wage is :"+totalEmpWage);
        }
    }
}
