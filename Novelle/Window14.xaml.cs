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
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public Window14()
        {
            InitializeComponent();
        }
        private void Choose141(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window15 window15 = new Window15();
            window15.Show();
            this.Close();

        }
    }
}
