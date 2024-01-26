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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();
        }
        private void Choose101(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
            this.Close();

        }
        private void Choose102(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
            this.Close();

        }
    }
}
