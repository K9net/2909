﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace var1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            window.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            window.Show();
        }
    }
}
