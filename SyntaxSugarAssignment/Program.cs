using System;

namespace SyntaxSugarAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            
            var response = (answer < 9) ? $"{answer} is less then nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
