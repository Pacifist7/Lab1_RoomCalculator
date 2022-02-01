/*Exercise 4
 
double num1 = double.Parse(Console.ReadLine());

double num2 = double.Parse(Console.ReadLine());

Console.WriteLine(num1 + num2);*/

using System;

namespace Monday_1._31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of this room?");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of this room?");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;

            double perimeter = 2 * (length + width);

            Console.WriteLine("The area of this room is " + area + " and the perimeter of this room is " + perimeter);

            if (area <= 250)
            {
                Console.WriteLine("This room is small.");
            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine("This room is medium.");
            }
            else if (area >= 650)
            {
                Console.WriteLine("This room is large.");
            }

            Console.WriteLine("What is the height of this room?");
            double height = double.Parse(Console.ReadLine());

            double volume = area * height; 
            Console.WriteLine("The volume of this room is " + volume); //the end

            double surfaceArea = 2*(width*length + height*length + height*width);
            Console.WriteLine("The surface area of this room is " + surfaceArea);


        }
    }
}
