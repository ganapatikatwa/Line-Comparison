using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineCmp
    {
        public void LineCompare()
        {
            Console.WriteLine("Enter the Co-ordinates of first line in the order of x1,y1,x2,y2 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second line in the order of a1,b1,a2,b2 ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());


            double Length_of_first_Line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            double Length_of_second_Line = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));

            Console.WriteLine("\nFirst line length is : " + Length_of_first_Line);

            Console.WriteLine("\nSecond line length is : " + Length_of_second_Line);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("\nFinding the equality of two lines");

            if (Length_of_first_Line.Equals(Length_of_second_Line))
            {
                Console.WriteLine("\nBoth Lines Are Equal");
            }
            else
            {
                Console.WriteLine("\nBoth Lines Are Not Equal");
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\nComparing of Two lines ");

            switch (Length_of_first_Line.CompareTo(Length_of_second_Line))
            {
                case 1:
                    Console.WriteLine("\nFirst Line Is Greater Than Second Line");
                    break;
                case -1:
                    Console.WriteLine("\nFirst Line Is Lesser Than Second Line");
                    break;
                default:
                    Console.WriteLine("\nBoth The Lines are Equal");
                    break;
            }
            Console.Read();
        }
    }
}
