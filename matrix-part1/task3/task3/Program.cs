using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[][] objectMatrix = new object[][]
            {
                new object[] {12,"hello",3.14},
                new object[] {true,'A',DateTime.Now }
            };
            foreach (object[] row in objectMatrix)
            {
                foreach(object item in row)
                {
                    Console.WriteLine($"Type: {item.GetType()}, value:{item}");
                }
                Console.ReadKey();
            }

        }
    }
}
