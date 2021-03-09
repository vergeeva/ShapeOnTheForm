using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГеометрическиеФигуры
{
    class MyCircle : MyShape
    {
        public MyCircle(int _x, int _y, int _r) : base(_x, _y, _r) // Конструктор
        { // окружности
            _Type = 1;
        } // Конструктор
        override public void Draw(Graphics g, bool IsCur) // Метод рисования окружн.
        {
            if (IsCur)
            { // Если фигура текущая
                Brush b = new SolidBrush(Color.Khaki); // Создаем кисть
                                                        // желтого цвета
                g.FillEllipse(b, x - r, y - r, 2 * r, 2 * r); // Закрашиваем фон
            } // if
            Pen p1 = new Pen(Color.DarkOrange, 3); //Создаем перо красного цвета,
                                            // толщина 3
            g.DrawEllipse(p1, x - r, y - r, 2 * r, 2 * r); // Рисуем окружность
        } // Draw

        public override bool Valid(int _x, int _y, int _r)
        {
            if (_x - _r < 0 || _y - _r < 25 || _x + _r > Form1.w - 10 || _y + _r > Form1.h - 40)
                return false;
            return true;


        }
    }
}
//class MyCircle
//{
//    private int x; // Координата x центра окружности
//    private int y; // Координата y центра окружности
//    private int r; // Радиус окружности
//    private static int _CurCircle = 0; // текущая окружность.
//    public static int CurCircle
//    {
//        get
//        {
//            return _CurCircle;
//        } // get
//        set
//        {
//            if (value >= 0 && value < Form1.Count)
//            {
//                _CurCircle = value;
//            }
//            else
//            {
//                MessageBox.Show("Недопустимое значение");
//            } // else
//        } // set
//    } // public static int CurCircle
//    public int X // Свойство для работы с x-координатой центра окружности
//    {
//        get // Метод для чтения из поля x
//        {
//            return x;
//        } // get
//        set // Метод для записи в поле x
//        {
//            if (value >= 0)
//            { // value - значение, записываемое в поле х
//                x = value;
//            }
//            else
//            {
//                MessageBox.Show("Значение не может быть отрицательным");
//            } // else
//        } // set
//    } // public int X
//    public int Y // Свойство для работы с y-координатой центра окружности
//    {
//        get // Метод для чтения из поля y
//        {
//            return y;
//        } // get
//        set // Метод для записи в поле y
//        {
//            if (value >= 0)
//            { // value - значение, записываемое в поле y
//                y = value;
//            }
//            else
//            {
//                MessageBox.Show("Значение не может быть отрицательным");
//            } // else
//        } // set
//    } // public int Y

//    public int R // Свойство для работы с y-координатой центра окружности
//    {
//        get // Метод для чтения из поля r
//        {
//            return r;
//        } // get
//        set // Метод для записи в поле r
//        {
//            if (value > 0)
//            { // value - значение, записываемое в поле r
//                r = value;
//            }
//            else
//            {
//                MessageBox.Show("Значение не может быть равным нулю");
//            } // else
//        } // set
//    } // public int R
//    public MyCircle(int _x, int _y, int _r) // Конструктор окружности
//    { // заполняет координаты центра и радиус окружности
//        x = _x;
//        y = _y;
//        r = _r;
//    }
//    ~MyCircle() // Конструктор окружности
//    { // заполняет координаты центра и радиус окружности

//    }
//    public void Draw(Graphics g) // Метод рисования окружности
//    {
//        Pen p1 = new Pen(Color.Khaki, 4); //Создаем перо цвета Khaki, толщина 4
//        g.DrawEllipse(p1, x - r, y - r, 2 * r, 2 * r); // Рисуем окружность
//    }
//    public void Draw(Graphics g, bool IsCur) // Перегрузка метода рисования окружности
//    {
//        if (IsCur)
//        { // Если окружность текущая
//            Brush b = new SolidBrush(Color.Turquoise);// Создаем кисть бирюзового цв.
//            g.FillEllipse(b, x - r, y - r, 2 * r, 2 * r); // Закрашиваем фон
//        } // if
//        Pen p1 = new Pen(Color.Khaki, 4); //Создаем перо цвета Khaki,
//                                          // толщина 4
//        g.DrawEllipse(p1, x - r, y - r, 2 * r, 2 * r); // Рисуем окружность
//    }
//    public void Left() // Метод перемещения окружности влево на 10
//    { // пикселей
//        if (Valid(x - 10, y, r)) x -= 10; // Если x можно уменьшить на 10,
//                                          // то уменьшаем
//    }
//    public void Right() // … вправо …
//    {
//        if (Valid(x + 10, y, r)) x += 10; // Если x можно увеличить на 10,
//                                          // то увеличим
//    }
//    public void Up() // … влево …
//    {
//        if (Valid(x, y - 10, r)) y -= 10; //Если y можно уменьшить на 10, то
//                                          // уменьшим
//    }
//    public void Down() // … вниз …
//    {
//        if (Valid(x, y + 10, r)) y += 10; // Если y можно увеличить на 10,
//                                          // то увеличим
//    }
//    public bool Valid(int _x, int _y, int _r) // Метод проверки размещения
//                                              // окружности в окне
//    {
//        FormCollection fc = Application.OpenForms; // Массив всех форм
//        Form f1 = fc[0]; // Первая форма
//        int w = f1.Width - 15; // Ширина формы
//        int h = f1.Height - 40; // Высота формы
//        if (_x - _r < 0 || _y - _r < 0 || _x + _r > w || _y + _r > h) return false;
//        // Окружность вышла за пределы, возвращаем ложь
//        return true; // иначе возвращаем истина
//    }
//}