﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
class program
{
    static void Main(string[] args)
    {
        int ITS_PART_TIME = 1;

        int ITS_FULL_TIME = 2;

        int EMP_RATE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        //Computation;
        int empCheck = random.Next(0, 2);
        if (empCheck == ITS_PART_TIME)
        {
            empHrs = 4;
        }
        else if (empCheck == ITS_FULL_TIME)
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