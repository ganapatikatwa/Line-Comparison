class Program
{
    static void Main(string[] args)
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

        Console.WriteLine("First line length is : " + Length_of_first_Line);

        Console.WriteLine("Second line length is : " + Length_of_second_Line);

        Console.WriteLine("---------------------------------------------------");

        
        if (Length_of_first_Line.Equals(Length_of_second_Line))
        {
            Console.WriteLine("Both Lines Are Equal");
        }
        else
        {
            Console.WriteLine("Both Lines Are Not Equal");
        }

        Console.Read();
    }
}