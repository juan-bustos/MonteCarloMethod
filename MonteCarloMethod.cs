using System;

namespace MonteCarloMethod
{
    public class Program
    {
        public struct Coords // Still trying to understand how to use structs. Need to do more research and practice.  
        {
            public double xCoord, yCoord; // Creates public properties for struct named xCoord and yCoord.
            public Coords(double x, double y) //This is a 2-parameter constructor for a new set of coordinates. 
            {
                xCoord = x;
                yCoord = y;
            }
            public Coords(int r) //This constructor takes one parameter and allows me to use the Random class for getting random doubles. 
            {
                Random coord = new Random(); //This creates a new instance of the Random Class named coord. 
                this.xCoord = coord.NextDouble(); //This creates a floating point number that is >= 0.0 and < 1.0 for the xCoord.
                this.yCoord = coord.NextDouble(); //This creates a floating point number that is >= 0.0 and < 1.0 for the yCoord.
            }
            public double Hypotenuse() //This method just returns the hypotenuse of a triangle. 
            {
                double x = xCoord;
                double y = yCoord;
                double hypotenuse = Math.Sqrt(Math.Abs((x * x) + (y * y)));
                return hypotenuse;
            }
        }
        public static double CreateArray(int num) // This method creates a new array with the length that a user puts into the console. 
        {
            int length = num; // This is to help test several methods without having to input new integers every time. 
            // int length = int.Parse(Console.ReadLine()); // This takes the users input and converts it from a string to an int. 
            Coords[] newArray = new Coords[length]; // This creates a new array with the length of the integer received from the user. 
            double counter = 0; 
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new Coords(1);
                if (newArray[i].Hypotenuse() <= 1)
                {
                    counter++;
                }                               
            }
            double result = (counter / length) * 4;
            Console.WriteLine("result "+result);
            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer here: ");
            CreateArray(10);
            CreateArray(100);
            CreateArray(1000);
            CreateArray(10000);
        }

    }
}
