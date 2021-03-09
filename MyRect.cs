using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГеометрическиеФигуры
{
    class MyRect : MyShape
    {
        public MyRect(int _x, int _y, int _r) : base(_x, _y, _r) // Конструктор
        { // квадрата
            _Type = 2;
        } // Конструктор
        override public void Draw(Graphics g, bool IsCur) // Метод рисования квадрата
        {
            if (IsCur)
            { // Если фигура текущая
                Brush b = new SolidBrush(Color.DarkKhaki); // Создаем кисть цвета темный Хаки
                g.FillRectangle(b, x, y, r, r); // Закрашиваем фон                                        
            }// if
            Pen p2 = new Pen(Color.Chocolate, 3); //Создаем перо шоколадного цвета
                                             // цвета, толщина 3
            g.DrawRectangle(p2, x, y, r, r); // Рисуем квадрат
        }

        override public bool Valid(int _x, int _y, int _r)
        {
            if (_x < 0 || _y < 25 || _x + _r > Form1.w - 10 || _y + _r > Form1.h - 40)
                return false;
            return true;
        } // Valid
    } 
}
