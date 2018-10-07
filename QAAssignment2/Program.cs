using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            
        }

        private void Go()
        {
            int result = 0;
            do
            {
                Console.WriteLine("1.Enter triangle dimensions");
                Console.WriteLine("2.Exit");
                Console.Write("Enter your choice:");

                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result == 1)
                    {
                        int s1 = GetNumber("side 1");
                        int s2 = GetNumber("side 2");
                        int s3 = GetNumber("side 3");
                        string analyzeResult = TriangleResolver.Analyze(s1, s2, s3);
                        if (analyzeResult.Equals("invalid"))
                        {
                            Console.WriteLine("Invalid triangle");
                        }
                        else
                        {
                            Console.WriteLine("It's a {0} triangle", analyzeResult);
                        }
                    }
                }
            } while (result != 2);
        }

        private int GetNumber(string numberName)
        {
            int height = 0;
            bool validNumber = false;
            do
            {
                Console.Write("Enter " + numberName + ":");
                validNumber = int.TryParse(Console.ReadLine(), out height);
                if (validNumber)
                {
                    if (height <= 0)
                    {
                        Console.WriteLine(numberName + " should be larger than 0.");
                        validNumber = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            } while (!validNumber);
            return height;
        }

    }
}
