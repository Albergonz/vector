using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    internal class Vector
    {
        public double X {  get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
        public static  Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vector operator *(Vector v1, double a)
        {
            return new Vector(v1.X * a, v1.Y *a);
        }
        public static Vector operator *(double a, Vector v1)
        {
            return new Vector(v1.X * a, v1.Y * a);
        }
        public static Vector operator /(Vector v1, double a)
        {
            return new Vector(v1.X/a, v1.Y /a);
        }
        public override bool Equals(object left)
        {
            if (ReferenceEquals(null, left))
                return false;
            if (ReferenceEquals(this, left))
                return true;
            if (left.GetType() != this.GetType())
                return false;
            return Equals((Vector)left);
                
        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            return Equals(v1, v2) ;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !Equals(v1, v2);
        }

        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y);
        }
        public static Vector operator +(Vector v1)
        {
            return new Vector(+v1.X, +v1.Y);
        }

        public static Vector Parse(string v)
        {
            string[] parts = v.Split(',');
            return new Vector(double.Parse(parts[0]), double.Parse(parts[1]));

        }
        public override string ToString()
        {
            return string.Format("{0},{1}", X, Y);
        }
    }
}
