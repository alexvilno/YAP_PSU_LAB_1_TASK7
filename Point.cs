using System;
namespace LAB1_TASK7
{
    class Point
    {
        private int x; //каждое поле -- соответствующие координаты в трехмерном ортонормированном базисе
        private int y;
        private int z;

        public Point() //конструктор по умолчанию. Создает точку в начале системы координат
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Point(int x, int y, int z) //конструктор от 3 целочисленных аргументов, координат соответственно
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(Point p) //конструктор копирования
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }

        public int RV_Volume() //объем параллелепипеда, образованного радиус вектором
        {
            return Math.Abs(x * y * z);
        }

        public double RV_Length() //длина радиус-вектора точки
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double Distance(Point p2)
        {
            return Math.Sqrt((p2.get_x() - x) * (p2.get_x() - x) + (p2.get_y() - y) * (p2.get_y() - y) + (p2.get_z() - z) * (p2.get_z() - z));
        }

        public void set_x(int x) //setter
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

        public int get_x() //getter
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
