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
            Computer comp = new Computer();
            Games game1 = new Games(2.0,"BatMan Returns", "Game", 2.0, 8.0);
            Games game2 = new Games(2.5, "Street Fighter", "Game", 2.1, 7.0);
            TextEditor Tex = new TextEditor("BatMan Returns", "TexEditor", 2.0, 8.0);
            // console write: what system has eg comp.gpu.effective memory
            comp.motherB.InstallApplication(game1);
            //conwrt: comp.hd.avalMem is ....
            comp.motherB.InstallApplication(game2);
            comp.motherB.InstallApplication(Tex);



            //string str = "Hello World";
            //Console.WriteLine("Please input any number into the console.");
            //int userInput = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < str.Length; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(str[i]);
            //    }           
            //}
            //Console.ReadLine();


            //while(userInput != 42)
            //{
            //    Console.WriteLine("Please enter the number 42");
            //    userInput = Convert.ToInt32(Console.ReadLine());
            //}

            //CalculatorMadness calc = new CalculatorMadness();
            //calc.RunCalculations();
            //Console.ReadLine();
        }
    }
}
