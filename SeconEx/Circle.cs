using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconEx
{
    class Circle : IComparable<Circle>
    {
        double x;
        double y;
        double radius;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle()
        {

        }

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public int CompareTo(Circle obj)
        {
           
            if (Ploshad()<obj.Ploshad())
            {
                return 1;
            }
            else
            {
                if (Ploshad() > obj.Ploshad())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private double Ploshad()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"({x},{y}-{radius})";
        }
    }
}
