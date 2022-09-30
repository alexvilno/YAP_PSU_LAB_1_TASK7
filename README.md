# Лабораторная работа №1 по ЯП ПГНИУ, задание 7
## Постановка задачи
Разработать класс с тремя целочисленными полями. Создать конструктор копирования. Разработать метод, вычисляющий произведение полей.
Перегрузить метод ToString() для формирования строки из полей класса.
Реализовать дочерний класс (его содержание предложить самостоятельно и описать в решении: какой содержательный смысл имеют поля; реализовать конструкторы; предложить и реализовать 2-3 метода). Протестировать все конструкторы и другие методы базового и дочернего классов.

## Коротко о структуре
В качестве базового класса был разработан класс **Point**, описывающий **точку** в *трехмерном евклидовом пространстве с прямоугольной декартовой системой координат.* Дочерним классом является класс **Triangle**, он описывает **треугольник**, состоящий из трех точек из родительского класса **Point**.

*UML диаграмма классов:*

![image](https://sun9-29.userapi.com/impg/MrebC1pf7OreHMiTSflViCwjgudBnRk3SXIiKQ/CEUMyOjI3P4.jpg?size=401x274&quality=96&sign=8d2c6c9f030ac474ed3079f828c12925&type=album)

## 
В качестве базового класса был разработан класс **Point**, описывающий точку в *трехмерном евклидовом пространстве с прямоугольной декартовой системой координат.* Класс содержит поля:
```c#
private int x; //координата по оси х
private int y; //координата по оси y
private int z; //координата по оси z
```
Конструктор **по умолчанию** инициализирует точку в начале системы координат:

```c#
public Point() //конструктор по умолчанию
{
  x = 0;
  y = 0;
  z = 0;
}
```

Конструктор **от трех целочисленных параметров** инициализирует точку с координатами (x,y,z) соответственно:

```c#
public Point(int x, int y, int z) //конструктор от трех целочисленных параметров
  {
  this.x = x;
  this.y = y;
  this.z = z;
}
```

Кроме того, реализован **конструктор копирования**:

```c#
public Point(Point p) //конструктор копирования
{
  x = p.x;
  y = p.y;
  z = p.z;
}
```

Ниже преставлены реализованные **методы** класса **Point**:

```c#
public int RV_Volume() {...}; //объем параллелепипеда, построенного на радиус-векторе точки
public double RV_Length() {...}; //длина радиус-вектора точки
public double Distance(Point p2) {...}; //расстояние между двумя точками, определяется по формуле (1)

public void set_x(int x) {...}; //сеттеры
public void set_y(int y) {...};
public void set_z(int z) {...};

public int get_x() {...}; //геттеры
public int get_y() {...};
public int get_z() {...};

public override string ToString() {...}; //перегруженный ToString(), возвращает координатную тройку чисел (x,y,z)
```
![image](https://latex2png.com/pngs/45184d87b41b5e73a64d1e48b4b4a581.png)

*Рассмотрим примеры:*
```c#

```
