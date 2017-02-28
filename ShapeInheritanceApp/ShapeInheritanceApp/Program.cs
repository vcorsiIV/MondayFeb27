using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApplication
{
    class Dimensions
    {
        protected double length, width, sideC;

        public void SetLength(double len)
        {
            length = len;
        }
        public void SetWidth(double wid)
        {
            width = wid;
        }
        public void SetSideC(double c)
        {
            sideC = c;
        }
    }

    class Rectangle:Dimensions
    {
        
        private void settingDims()
        {
            SetLength(4.5);
            SetWidth(5.5);
        }
        private double getArea()
        {
            settingDims();
            return length * width;
        }
        public void Display()
        {
            getArea();
            double sqrtArea = getArea();
            WriteLine("Rectangle\n");
            for(int i =0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            WriteLine("\nThe Length:\t\t{0}", length);
            WriteLine("The Width:\t\t{0}", width);
            WriteLine("The Area:\t\t{0}\n", getArea());
            WriteLine("Square Root of the Area (Rectangle):\t" + Math.Sqrt(sqrtArea) + "\n");
            ReadKey(true);
        }

    }

    class Square:Dimensions
    {
        //Member Variables
       
        private void settingDims()
        {
            SetLength(4.5);
            width = length;

        }
        private double getArea()
        {
            settingDims();
            return length * width;
        }
        public void Display()
        {
            getArea();
            double sqrtArea = getArea();
            WriteLine("Square:\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            WriteLine("\nThe Length:\t\t{0}", length);
            WriteLine("The Width:\t\t{0}", width);
            WriteLine("The Area:\t\t{0}\n", getArea());
            WriteLine("Square Root of the Area (Square):\t" + Math.Sqrt(sqrtArea) + "\n");
            ReadKey(true);
        }

    }

    class Triangle:Dimensions
    {
        private void settingDims()
        {
            SetLength(2.975);
            SetWidth(3.5);
            SetSideC(6.27);
        }
        private double getArea()
        {
            settingDims();
            double s = (length + width + sideC) / 2;
            return Math.Sqrt(s * (s - length) * (s - width) * (s - sideC));
        }
        public void Display()
        {
            getArea();
            double sqrtArea = getArea();
            WriteLine("Triangle:\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            WriteLine("\nThe first side:\t\t{0}", length);
            WriteLine("The second side:\t{0}", width);
            WriteLine("The third side:\t\t{0}", sideC);
            WriteLine("The Area:\t\t{0}\n", getArea());
            WriteLine("Square Root of the Area (Triangle):\t" + Math.Sqrt(sqrtArea) + "\n");
            ReadKey(true);
        }

    }

    class Octagon:Dimensions
    {
        
        private void SettingDims()
        {
            SetLength(5.0);
        }
        private double getArea()
        {
            SettingDims();
            return (2 * (1 + Math.Sqrt(2)) * Math.Pow(length, 2));
        }
        public void Display()
        {
            getArea();
            double sqrtArea = getArea();
            WriteLine("Octagon:\n");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if((j == 0 || j == 1 || j == 5 || j == 6) && (i == 0))
                    {
                        Console.Write("  ");
                    }
                    else if ((j == 0 || j == 6) && (i == 1))
                    {
                        Console.Write("  ");
                    }
                    else if ((j == 0 || j == 6) && (i == 5))
                    {
                        Console.Write("  ");
                    }
                    else if ((j == 0 || j == 1 || j == 5 || j == 6) && (i == 6))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            WriteLine("\nThe one of the eight sides:\t{0}", length);
            WriteLine("The Area:\t\t\t{0}\n", getArea());
            WriteLine("Square Root of the Area (Octagon):\t" + Math.Sqrt(sqrtArea) + "\n");
            ReadKey(true);
        }

    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            WriteLine("Hit any key to view the next shape results\n");
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();
            Square s = new Square();
            Octagon o = new Octagon();
            t.Display();
            s.Display();
            r.Display();
            o.Display();
        }
    }
}
