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
    /// Логика взаимодействия для Window15.xaml
    /// </summary>
    public partial class Window15 : Window
    {
        public Window15()
        {
            InitializeComponent();
        }
        private void Perehod15(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window16 window16 = new Window16();
            window16.Show();
            this.Close();

        }
    }
}
