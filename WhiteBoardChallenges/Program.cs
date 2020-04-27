using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Hello World";
            //Console.WriteLine("Please input any number into the console.");
            //int userInput = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i);            
            }
            Console.ReadLine();
        }
    }
}
