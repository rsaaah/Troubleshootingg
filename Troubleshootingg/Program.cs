using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshootingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case 1");
            
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); // missing ;
            }
            else if (number < 3) // else if needs to be separate words

                Console.WriteLine("Talet är mindre än tre");

            Console.WriteLine("Case 2");

            for (int i = 1; i < 100; i++) // the condiion needs to be spaced out for = + <
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Case 3");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " "); // so J 1-5 counting up with a space in between
                }
                Console.WriteLine(); //every condition skip to next line
            }

            Console.WriteLine("Case 3");

            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write();
                }

                Console.WriteLine();
                i++;
            }
        }
    }
}
