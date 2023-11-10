using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList();

            studentGrades.Add(85);
            studentGrades.Add(92);
            studentGrades.Add(78);
            studentGrades.Add(95);
            studentGrades.Add(88);

            Console.WriteLine("students Grades:");

            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            int sum = 0;
            foreach(int grade in studentGrades)
            {
                sum += grade;
            }
            Console.WriteLine("sum of all grades:"+ sum);
            Console.ReadKey();
        }
    }
}
