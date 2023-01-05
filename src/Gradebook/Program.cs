// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

if (args.Length > 0)
{
    Console.WriteLine($"Hello, {args[0]}!");
}
else 
{
    Console.WriteLine($"Hello, teacher!");
}

List<double> grades = new List<double>() { 12.3, 45.6, 78.9 };
grades.Add(98.7);

double result = 0;
foreach(double grade in grades)
{
    result += grade;
}
result /= grades.Count;
Console.WriteLine($"The average grade is {result}.");
