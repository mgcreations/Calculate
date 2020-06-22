using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char character;

            Console.Write("Choose a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter A (add), S (Subtract) or M (Multiply): ");
            character = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (character)
            {
                case 'A':
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;
                case 'S':
                    result = num2 - num1;
                    Console.WriteLine("{0} - {1} = {2}", num2, num1, result);
                    break;
                case 'M':
                    result = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                    break;
            }
        }
    }
}