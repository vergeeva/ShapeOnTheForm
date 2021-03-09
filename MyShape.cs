 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГеометрическиеФигуры
{
    abstract class MyShape
    {
        protected int x; // x-координата базовой точки
        protected int y; // y-координата базовой точки
        protected int r; // размер фигуры
        protected static int _CurShape = 0; // номер текущей фигуры
        protected int _Type; // тип фигуры: 1-окружность, 2-квадрат, 3 - треугольник
        public int X // Свойство для работы с x-координатой 
        {
            get // Метод для чтения из поля x
            {
                return x;
            } // get
            set // Метод для записи в поле x
            {
                if (value >= 0)
                { // value - значение, записываемое в поле х
                    x = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть > 0");
                } // else
            }
        }

        public int Y // Свойство для работы с x-координатой 
        {
            get // Метод для чтения из поля x
            {
                return y;
            } // get
            set // Метод для записи в поле x
            {
                if (value >= 0)
                { // value - значение, записываемое в поле х
                    y = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть > 0");
                } // else
            } // set
        } // public int Y

        public int R // Свойство для работы с x-координатой 
        {
            get // Метод для чтения из поля x
            {
                return r;
            } // get
            set // Метод для записи в поле x
            {
                if (value > 0)
                { // value - значение, записываемое в поле х
                    r = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть > 0");
                } // else
            } // set
        } // public int R

        public static int CurShape
        { // Свойство для доступа к номеру тек. фиг.
            get
            {
                return _CurShape;
            } // get
            set
            {
                if (value >= 0 && value < Form1.Count)
                {
                    _CurShape = value;
                }
                else
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
        }
        public int Type
        { // Свойство для доступа к типу фигуры
            get
            {
                return _Type;
            } // get
        } // public int Type
        public MyShape(int _x, int _y, int _r) // Конструктор фигуры
        {
            x = _x;
            y = _y;
            r = _r;
        } // Конструктор
        public void Left() // Метод перемещения фигуры влево на 10 пикселей
        { // 
            if (Valid(x - 10, y, r)) x -= 10; // Если x можно уменьшить на 10, 
                                              // то уменьшаем
        } // Left
        public void Right() // … вправо …
        {
            if (Valid(x + 10, y, r)) x += 10; // Если x можно увеличить на 10,
                                              // то увеличим
        } // Right
        public void Up() // … влево … 
        {
            if (Valid(x, y - 10, r)) y -= 10; //Если y можно уменьшить на 10, то
                                              // уменьшим
        } // Up
        public void Down() // … вниз …
        {
            if (Valid(x, y + 10, r)) y += 10; // Если y можно увеличить на 10,
                                              // то увеличим
        } // Down

        abstract public bool Valid(int _x, int _y, int _r);
        abstract public void Draw(Graphics g, bool IsCur); // Метод рисования

    } // class MyShape

}

