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
using System.Windows.Shapes;

namespace Novelle
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Choose41 (object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Close();
        }
        private void Choose42(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
            this.Close();
        }
    }
}
