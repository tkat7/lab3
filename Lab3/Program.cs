using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean cont = false;
            do
            {
                Console.Write("Please enter the top value:  ");
                string inpt = Console.ReadLine();
                int num = int.Parse(inpt);
                int a = 1;
                Console.WriteLine("Number\tSquared\tCubed\t^4\t^5\t^5\t^6\t^7\t^8\t^9\t^10");
                Console.WriteLine("=======\t=======\t=======\t=======\t=======\t=======\t=======\t=======\t=======\t=======\t=======");
                while (a <= num)
                {
                    int b = a * a;
                    int c = b * a;
                    int d = c * a;
                    int e = d * a;
                    int f = e * a;
                    int g = f * a;
                    int h = g * a;
                    int i = h * a;
                    int j = i * a;
                    int k = j * a;

                    Console.WriteLine(a + "\t" + b + "\t" + c + "\t" + d + "\t" + e + "\t" + f + "\t" + g + "\t" + h + "\t" + i + "\t" + j + "\t" + k);

                    a++;
                }


                Console.WriteLine();
                Console.Write("Would you like to continue? (y/n)");
                string input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    cont = false;
                }

            } while (cont == true);
        }
    }
}
