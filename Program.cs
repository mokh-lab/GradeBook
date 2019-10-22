using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("scott's Grade Book");
            book.addgrade(89.1);
            book.addgrade(90.5);
            book.addgrade(77.5);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            var highgarde = double.MinValue;
                   
            foreach (var  number in grades)
            {
                if (number > highgarde)
                {
                    highgarde = number;
                }
               
                result += number ;
                result /= grades.Count;
            }
            Console.WriteLine($"The avrage grade For is { result:n1}");
            Console.WriteLine($"The highest grade  is { highgarde}");


        }
    }
}
