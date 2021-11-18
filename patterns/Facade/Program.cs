using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Facade facade = new Facade();
            int perimeter = facade.calculatePerimeter(10, 15, 12);
            double area = facade.calculateArea(10, 15, 12);
            if(perimeter == -1)
            {
                Console.WriteLine("Не правильно введені параметри трикутника!");
            }
            else
            {
                Console.WriteLine("Периметр трикутника: " + perimeter);
                Console.WriteLine("Площа трикутника: " + area);
            }
        }
    }


    // "Subsystem ClassA" 
    class CheckingParties
    {
        public bool CheckOne(int side_1, int side_2, int side_3)
        {
            if (side_1 > 0 && side_2 > 0 && side_3 > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Введено від'ємну сторону!");
                return false;
            }
        }
        public bool CheckTwo(int side_1, int side_2, int side_3)
        {
            if (side_1 + side_2 <= side_3 || side_1 + side_3 <= side_2 || side_2 + side_3 <= side_1)
            {
                Console.WriteLine("Одна із сторін більша за суму двох інших!");
                return false;
            }
            else
            {
                return true;
            }
        } 
    }

        // Subsystem ClassB" 
        class Calculation
        {
            public int perimeter(int side_1, int side_2, int side_3)
            {
                return side_1 + side_2 + side_3;
            }
            public double area(int side_1, int side_2, int side_3)
            {
                double p = this.perimeter(side_1, side_2, side_3) / 2.0;
                return Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
            }
        }
        // "Facade" 
        class Facade
        {
            CheckingParties one;
            Calculation two;
            public Facade()
            {
                one = new CheckingParties();
                two = new Calculation();
            }

            public int calculatePerimeter(int side_1, int side_2, int side_3)
            {
                if (one.CheckOne(side_1, side_2, side_3))
                {
                    if (one.CheckTwo(side_1, side_2, side_3))
                    {
                        return two.perimeter(side_1, side_2, side_3);
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }

            }

            public double calculateArea(int side_1, int side_2, int side_3)
            {
                if (one.CheckOne(side_1, side_2, side_3))
                {
                    if (one.CheckTwo(side_1, side_2, side_3))
                    {
                        return two.area(side_1, side_2, side_3);
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }

            }
        }
    }

