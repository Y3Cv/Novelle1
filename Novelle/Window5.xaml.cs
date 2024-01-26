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

namespace Novelle
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        private void Choose51(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Close();
        }
        private void Choose52(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Close();
        }
    }
}
