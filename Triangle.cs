using System;
namespace LAB1_TASK7
{
    class Triangle : Point
    {
        private Point a; //вершина A
        private Point b; //вершина B
        private Point c; //вершина C

        public Triangle() //конструктор по умолчанию
        {
            a = new Point(1, 0, 0);
            b = new Point(0, 1, 0);
            c = new Point(0, 0, 1);
        }

        public Triangle(Point a, Point b, Point c) //конструктор от трех точек(вершин)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle(Triangle prev) //конструктор копирования
        {
            this.a = prev.a;
            this.b = prev.b;
            this.c = prev.c;
        }

        public void ShowInfo() //выводит информацию о треугольнике в консоль
        {
            Console.WriteLine("Координаты вершин: А" + a.ToString() + " B" + b.ToString() + " C" + c.ToString());
            Console.WriteLine("Длина AB: " + AB_length() + ", длина BC: " + BC_length() + ", длина AC: " + AC_length());
            Console.WriteLine("Периметр треугольника: " + Perimeter() + ", полупериметр треугольника: " + SemiPerimeter());
            Console.WriteLine("Площадь треугольника: " + Square());
            Console.WriteLine("Угол между AB и BC: " + AB_BC_angle() + "deg");
            Console.WriteLine("Угол между BC и AC: " + BC_AC_angle() + "deg");
            Console.WriteLine("Угол между AB и AC: " + AB_AC_angle() + "deg");

        }

        public void Set_A(Point a) //сеттеры
        {
            this.a = a;
        }

        public void Set_B(Point b)
        {
            this.b = b;
        }

        public void Set_C(Point c)
        {
            this.c = c;
        }

        public Point Get_A() //геттеры
        {
            return a;
        }

        public Point Get_B()
        {
            return b;
        }

        public Point Get_C()
        {
            return c;
        }

        public double AB_length() //возвращает длину стороны AB
        {
            return a.Distance(b); 
        }

        public double BC_length() //BC
        {
            return b.Distance(c);
        }

        public double AC_length() //AC
        {
            return a.Distance(c);
        }

        public double Perimeter() //возвращает периметр треугольника
        {
            return AB_length() + BC_length() + AC_length();
        }

        public double SemiPerimeter() //возвращает полупериметр треугольника
        {
            return (AB_length() + BC_length() + AC_length()) / 2;
        }

        public double Square() //возвращает площадь треугольника
        {
            return Math.Sqrt(SemiPerimeter() * (SemiPerimeter() - AB_length()) * (SemiPerimeter() - BC_length()) * (SemiPerimeter() - AC_length()));
        }

        public double AB_AC_angle() //возвращает градусную меру угла между сторонами AB и АС
        {
            Point rp_a = new Point(b.get_x() - a.get_x(), b.get_y() - a.get_y(), b.get_z() - a.get_z());
            Point rp_b = new Point(c.get_x() - a.get_x(), c.get_y() - a.get_y(), c.get_z() - a.get_z());

            return Math.Acos(Math.Acos(Math.Cos( (rp_a.get_x() * rp_b.get_x() + rp_a.get_y() * rp_b.get_y() +
                rp_a.get_z() * rp_b.get_z() ) / (Math.Sqrt(rp_a.get_x() * rp_a.get_x() + rp_a.get_y() * rp_a.get_y() +
                rp_a.get_z() * rp_a.get_z()) * Math.Sqrt(rp_b.get_x() * rp_b.get_x() + rp_b.get_y() * rp_b.get_y() + rp_b.get_z() * rp_b.get_z()) )))) * 57.296;
        }

        public double AB_BC_angle() //возвращает градусную меру угла между сторонами AB и BC
        {
            Point rp_a = new Point(b.get_x() - a.get_x(), b.get_y() - a.get_y(), b.get_z() - a.get_z());
            Point rp_b = new Point(c.get_x() - b.get_x(), c.get_y() - b.get_y(), c.get_z() - b.get_z());

            return Math.Acos(Math.Acos(Math.Cos((rp_a.get_x() * rp_b.get_x() + rp_a.get_y() * rp_b.get_y() +
                rp_a.get_z() * rp_b.get_z()) / (Math.Sqrt(rp_a.get_x() * rp_a.get_x() + rp_a.get_y() * rp_a.get_y() +
                rp_a.get_z() * rp_a.get_z()) * Math.Sqrt(rp_b.get_x() * rp_b.get_x() + rp_b.get_y() * rp_b.get_y() + rp_b.get_z() * rp_b.get_z()))))) * 57.296;
        }

        public double BC_AC_angle() //возвращает градусную меру угла между сторонами BC и АС
        {
            Point rp_1 = new Point(c.get_x() - b.get_x(), c.get_y() - b.get_y(), c.get_z() - b.get_z());
            Point rp_2 = new Point(c.get_x() - a.get_x(), c.get_y() - a.get_y(), c.get_z() - a.get_z());

            return Math.Acos(Math.Acos(Math.Cos((rp_1.get_x() * rp_2.get_x() + rp_1.get_y() * rp_2.get_y() +
                rp_1.get_z() * rp_2.get_z()) / (Math.Sqrt(rp_1.get_x() * rp_1.get_x() + rp_1.get_y() * rp_1.get_y() +
                rp_1.get_z() * rp_1.get_z()) * Math.Sqrt(rp_2.get_x() * rp_2.get_x() + rp_2.get_y() * rp_2.get_y() + rp_2.get_z() * rp_2.get_z()))))) * 57.296;
        }
    }
}
