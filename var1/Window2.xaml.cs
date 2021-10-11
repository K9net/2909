using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace var1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, x1, x2, d;

            a = Convert.ToInt32(textBox4.Text);
            b = Convert.ToInt32(textBox5.Text);
            c = Convert.ToInt32(textBox6.Text);

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                label2.Content = "Нет корней";
            }
            else
            {
                if (d == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                }
                //вывод корней уравнения
                label2.Content = ($"x1 = {x1: 0.00}; x2 = {x2: 0.00}");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            this.Close();
        }
    }
}
