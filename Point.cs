using System;
namespace LAB1_TASK7
{
    class Point
    {
        private int x;
        private int y;
        private int z;

        public Point()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }

        public int RV_Volume()
        {
            return Math.Abs(x * y * z);
        }

        public double RV_Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double Distance(Point p2)
        {
            return Math.Sqrt((p2.get_x() - x) * (p2.get_x() - x) + (p2.get_y() - y) * (p2.get_y() - y) + (p2.get_z() - z) * (p2.get_z() - z));
        }

        public void set_x(int x)
        {
            this.x = x;
        }

        public void set_y(int y)
        {
            this.y = y;
        }

        public void set_z(int z)
        {
            this.z = z;
        }

        public int get_x()
        {
            return x;
        }

        public int get_y()
        {
            return y;
        }

        public int get_z()
        {
            return z;
        }

        public override string ToString() //перегруженный ToString(), возвращает координатную тройку чисел (x,y,z)
        {
            return $"({x},{y},{z})";
        }   
    }
}
