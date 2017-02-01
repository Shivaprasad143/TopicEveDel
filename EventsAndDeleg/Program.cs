using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate string Check(int xCoordinates, int yCoordinates);
    class Canvas
    {
        public event Check clickevent;
        public Canvas()
        {
            clickevent = new Check(Checking);
        }
        public string Checking(int xCoordinates, int yCoordinates)
        {
            Console.WriteLine("Enter the start of the x coordinate of the Canvas!: ");
            int Point1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the end of the x coordinate of the Canvas!: ");
            int Point2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the start of the y coordinate of the Canvas!: ");
            int Point3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the end of the y coordinate of the Canvas!: ");
            int Point4 = Convert.ToInt16(Console.ReadLine());

            Point point = new Point(xCoordinates, yCoordinates);

            if ((point.Xcoordinate >= Point1 && point.Xcoordinate <= Point2) && (point.Ycoordinate >= Point3 && point.Ycoordinate <= Point4))
                return "true";
            else
                return "false";
        }

        public class Point
        {
            public int Xcoordinate;
            public int Ycoordinate;

            public Point(int Xcoordinate, int Ycoordinate)
            {
                this.Xcoordinate = Xcoordinate;
                this.Ycoordinate = Ycoordinate;
            }
            public static void Main()
            {
                string Solution;
                Canvas position = new Canvas();

                Console.WriteLine("Enter the x coordinate: ");
                int xCoordinates = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the y coordinates: ");
                int yCoordinates = Convert.ToInt16(Console.ReadLine());
                Solution = position.clickevent(xCoordinates, yCoordinates);
                if (Solution == "true")
                {
                    Console.WriteLine("x-coordinate={0} cms and y-coordinates={1} cms.:", xCoordinates, yCoordinates);
                }
                else
                    Console.WriteLine("Wrong Input!");
                Console.ReadLine();
            }
        }
    }
}




