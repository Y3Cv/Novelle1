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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }
        private void Choose71(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Close();
        }
        private void Choose72(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
            this.Close();
        }
    }
}
