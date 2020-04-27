using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class CalculatorMadness
    {
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            //Console.WriteLine("Please enter the first number:");
            //numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number:");
            //numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addiction is: "+ result);
            return result;
        }

        public void RunCalculations()
        {
            //Console.WriteLine("Please enter the first number:");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number:");
            //int numberTwo = int.Parse(Console.ReadLine());
            int finalResult = AddTwoNumbers(AddTwoNumbers(8, 40), AddTwoNumbers(200,50));
            Console.WriteLine("The result is: " + finalResult);
        }
    }
}
