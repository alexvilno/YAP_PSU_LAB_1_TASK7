using LAB1_TASK7;

class LAB_1_7
{
    public static void Main(String[] args)
    {
        Point p1 = new Point(); //создаем объект p1 класса Point
        Point p2 = new Point(1, 2, 3);
        Point p3 = new Point(p2);
        p3.set_z(10);

        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle(new Point(2,-1,3), new Point(3,-2,1), new Point(2,4,-2));
        Triangle t3 = new Triangle(t2);
        
        Console.WriteLine("Координаты точки p1" +p1.ToString()); //вывод координат точки в консоль
        Console.WriteLine("Объем параллелепипеда, образованного радиус-вектором точки p1: " + p1.RV_Volume()); //выведем на экран объем параллелепипеда, образующегося радиус-вектором точки p1
        Console.WriteLine("Координаты точки p2" + p2.ToString()); 
        Console.WriteLine("Объем параллелепипеда, образованного радиус-вектором точки p2: " + p2.RV_Volume());
        Console.WriteLine("Координаты точки p3" + p3.ToString());
        Console.WriteLine("Объем параллелепипеда, образованного радиус-вектором точки p3: " + p3.RV_Volume());
        Console.WriteLine("Длина радиус-вектора точки p3: " + "{0:0.000}", p3.RV_Length());

        Console.WriteLine();
        Console.WriteLine("информация о t1");
        t1.ShowInfo();

        Console.WriteLine();
        Console.WriteLine("информация о t2");
        t2.ShowInfo();

        Console.WriteLine();
        Console.WriteLine("информация о t3");
        t3.ShowInfo();

        Console.WriteLine();
        Console.WriteLine("информация о t3 (вершина b изменена)");
        t3.Set_A(p2);
        t3.ShowInfo();



        Console.Read();
        
    }
}
