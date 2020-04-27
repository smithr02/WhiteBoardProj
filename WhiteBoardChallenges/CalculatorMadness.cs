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

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            Console.WriteLine("The result of this subtraction is: " +result);
            return result;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            Console.WriteLine("The result of this multiplication is: " + result);
            return result;
        }

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            Console.WriteLine("The result of this division is: " + result);
            return result;
        }



        public void RunCalculations()
        {
            //Console.WriteLine("Please enter the first number:");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number:");
            //int numberTwo = int.Parse(Console.ReadLine());
            int finalResult = SubtractTwoNumbers(AddTwoNumbers(6,5), AddTwoNumbers(MultiplyTwoNumbers(40, DivideTwoNumbers(35,4)), MultiplyTwoNumbers(2, 2)));
            //int finalResult2 = DivideTwoNumbers(MultiplyTwoNumbers(40,35), 4) + MultiplyTwoNumbers(2, 2);
            Console.WriteLine("The result is: " + finalResult);
        }
    }
}
