using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            float   point1X;
            float   point1Y;
            float   point2X;
            float   point2Y;
            float   deltaX;
            float   deltaY;
            float   distance;
            float   angle;

            //introduce program
            Console.WriteLine("\t\tHello, my dear friend!\n");
            Console.Write("This application will calculate the distance between\n");
            Console.Write("   two points and the angle between those points.\n");
            //enter new values for two points
            Console.WriteLine("\nPlease, enter a first point coordinates:");
            Console.Write("x = ");
            point1X = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a second point coordinates:");
            Console.Write("x = ");
            point2X = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            point2Y = float.Parse(Console.ReadLine());
            //calculate the delta between two points
            deltaX = point2X - point1X;
            deltaY = point2Y - point1Y;
            //calculate distance with Pythagorean Theorem
            distance = (float)System.Math.Sqrt((double)(deltaX * deltaX + deltaY * deltaY));
            //calculate the angle 
            angle = ((float)System.Math.Atan2((double)deltaX, (double)deltaY)) * (float)180 / (float)System.Math.PI;
            //print results
            Console.WriteLine("\nDistance between the two points = {0:0.000}", distance);
            Console.WriteLine("Angle between the two points = {0:0.000} degrees", angle);
            Console.WriteLine();
        }
    }
}
