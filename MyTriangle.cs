using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГеометрическиеФигуры
{
    class MyTriangle:MyShape
    {
        public MyTriangle(int _x, int _y, int _r) : base(_x, _y, _r) // Конструктор
        { // треугольника
            _Type = 3;
        } // Конструктор
        override public void Draw(Graphics g, bool IsCur) // Метод рисования квадрата
        {
            PointF[] points = new PointF[3]; //Массив точек вершин треугольника
            double TriangleH = (R * Math.Sqrt(3.0)) / 2;
            points[0] = new PointF(X, Y - R);
            points[1] = new PointF(X - (float)TriangleH, Y + (R / 2));
            points[2] = new PointF(X + (float)TriangleH, Y + (R / 2));
            if (IsCur)
            { // Если фигура текущая
                Brush b = new SolidBrush(Color.White); // Создаем кисть белого цвета
                g.FillPolygon(b, points); // Закрашиваем фон                                        
            }
            Pen p2 = new Pen(Color.DarkGoldenrod, 3); //Создаем перо DarkGoldenrod
                                                      // цвета, толщина 3
            g.DrawPolygon(p2, points); //Метод рисования треугольника
        }

        override public bool Valid(int _x, int _y, int _r)
        {
            if (_x - _r < 0 || _y - _r < 25 || _x + _r > Form1.w - 10 || _y + _r/2 > Form1.h - 40)
                return false;
            return true;
        } // Valid
    }
}
