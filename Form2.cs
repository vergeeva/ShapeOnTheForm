using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГеометрическиеФигуры
{
    public partial class Form2 : Form
    {
        private bool _Rc; // Признак того, что нажати «ОК» или «Отмена»
        public bool Rc { get { return _Rc; } }
        int TypeOfShape;
        public int X
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ValueX.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка при вводе Х-координаты");
                    return 10; // Значение по умолчанию, т.к. надо что-то возвращать
                } // try
            } // get 
            set
            {
                if (value >= 0)
                { // value - значение, записываемое в поле х
                    ValueX.Text = Convert.ToString(value);
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным");
                    ValueX.Text = "10";
                } // else
            } // set
        } // public int X

        public int Y
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ValueY.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка при вводе Y-координаты");
                    return 10; // Значение по умолчанию, т.к. надо что-то возвращать
                } // try
            } // get 
            set
            {
                if (value >= 0)
                { // value - значение, записываемое в поле y
                    ValueY.Text = Convert.ToString(value);
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным");
                    ValueY.Text = "10";
                } // else
            } // set
        } // public int Y

        public int R
        {
            get
            {
                bool temp = int.TryParse(ValueR.Text, out int result);
                if (temp && result > 0)
                { return Convert.ToInt32(ValueR.Text); } 
                else
                {
                    MessageBox.Show("Ошибка при вводе значения");
                    return 10; // Значение по умолчанию, т.к. надо что-то возвращать
                }

            } // get 
            set
            {
                if (value > 0)
                { // value - значение, записываемое в поле r
                    ValueR.Text = Convert.ToString(value);
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным");
                    ValueR.Text = "10";
                } // else
            } // set
        } // public int R


        public Form2()
        {
            InitializeComponent();
            _Rc = false;
        }

        public Form2(int Type_Of_Shape)
        {
            InitializeComponent();
            _Rc = false;
            TypeOfShape = Type_Of_Shape;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            _Rc = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _Rc = false;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (TypeOfShape)
            {
                case 1: //Окружность
                    {
                        label1.Text = "Х-координата центра:";
                        label2.Text = "У-ордината центра:";
                        label3.Text = "Радиус:";

                        break;
                    }
                case 2: //Квадрат
                    {
                        label1.Text = "Х-координата левого верхнего угла:";
                        label2.Text = "У-ордината левого верхнего угла:";
                        label3.Text = "Сторона квадрата:";
                        break;
                    }
                case 3:
                    {
                        label1.Text = "Х-координата центра треугольника:";
                        label2.Text = "У-ордината центра треугольника:";
                        label3.Text = "Радиус описанной окружности:";
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
