using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГеометрическиеФигуры
{
    public partial class Form1 : Form
    {
        MyShape c; // Описание экземпляра объекта класса MyCircle
        static ArrayList a;
        static int _w, _h; // Переменные для хранения ширины и высоты формы
        public static int w // Свойство для получения ширины формы
        {
            get { return _w; }
        } // w
        public static int h // Свойство для получения высоты формы
        {
            get { return _h; }
        } // h
        public static int Count
        {
            get
            {
                return a.Count;
            } // get 
        } // public static int Count
        public Form1()
        {
            InitializeComponent();
            a = new ArrayList();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < a.Count; i++) // Цикл по всем окружностям
            {
                if (i != MyShape.CurShape)
                { // Окружность не текущая
                    (a[i] as MyShape).Draw(g, false); // Рисуем старым методом
                }
                else
                {
                    (a[i] as MyShape).Draw(g, true); // Рисуем новым методом
                } // else
            } // for
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode; // Получение кода нажатой клавиши
            if (k == Keys.Left) (a[MyShape.CurShape] as MyShape).Left();  // Если клавиши «стрелка влево», то вызов метода Left.
            if (k == Keys.Right) (a[MyShape.CurShape] as MyShape).Right();  // … «стрелка влево» … Right
            if (k == Keys.Up) (a[MyShape.CurShape] as MyShape).Up(); // … «стрелка вверх» … Up
            if (k == Keys.Down) (a[MyShape.CurShape] as MyShape).Down(); // … «стрелка вниз» … Down
            if (k == Keys.F2)
            {
                if ((a[MyShape.CurShape] as MyShape).Valid((a[MyShape.CurShape] as MyShape).X, (a[MyShape.CurShape] as MyShape).Y, (a[MyShape.CurShape] as MyShape).R + 10)) (a[MyShape.CurShape] as MyShape).R += 10;
                // Если y можно увеличить на 10, то увеличим
            } //Fn + F2 на ноутбуке

            if (k == Keys.F3) (a[MyShape.CurShape] as MyShape).R -= 10; //Fn + F3 на ноутбуке
            if (k == Keys.Tab)
            {
                if (MyShape.CurShape + 1 < Count)
                {
                    MyShape.CurShape++; //Увеличиваем номер текущей окружности
                }
                else
                { // Вышли за пределы
                    MyShape.CurShape = 0; // Обнулим номер
                } // if
            } // if
            Invalidate(); // Вызов события Paint для перерисовки окна
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Count; i++)
            {
                MyShape c = a[i] as MyShape;
                if ((c.X - e.X) * (c.X - e.X) + (c.Y - e.Y) * (c.Y - e.Y) < c.R * c.R)
                {
                    MyShape.CurShape = i;
                    break;
                } // if
            } // for
            Invalidate();
        }

        private void ОкружностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(1); // Создаем вторую форму
            f2.ShowDialog(); // Открываем вторую форму
            if (f2.Rc)
            { // Если нажали «ОК»
                c = new MyCircle(f2.X, f2.Y, f2.R); // Создадим окружность
                if (c.Valid(f2.X, f2.Y, f2.R))
                {
                    a.Add(c); // Добавим окружность в массив
                }
                else MessageBox.Show("Окружность находится вне границ формы");
                Invalidate(); // Перерисуем окно
            } // if
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            _w = Width;
            _h = Height;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _w = Width;
            _h = Height;
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(3); // Создаем вторую форму
            f2.ShowDialog(); // Открываем вторую форму
            if (f2.Rc)
            { // Если нажали «ОК»
                c = new MyTriangle(f2.X, f2.Y, f2.R); // Создадим треугольник
                if (c.Valid(f2.X, f2.Y, f2.R))
                {
                    a.Add(c); // Добавим фигуру в массив
                }
                else MessageBox.Show("Треугольник находится вне границ формы");
                Invalidate(); // Перерисуем окно           
            }
        }
        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(2); // Создаем вторую форму
            f2.ShowDialog(); // Открываем вторую форму
            if (f2.Rc)
            { // Если нажали «ОК»
                c = new MyRect(f2.X, f2.Y, f2.R); // Создадим квадрат
                if (c.Valid(f2.X, f2.Y, f2.R))
                {
                    a.Add(c); // Добавим фигуру в массив
                }
                else MessageBox.Show("Квадрат находится вне границ формы");
                Invalidate(); // Перерисуем окно           
            }
        }
    }
}