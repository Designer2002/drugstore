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

namespace drugstore
{
    /// <summary>
    /// Логика взаимодействия для PromoBanner.xaml
    /// </summary>
    public partial class PromoBanner : Window
    {
        public PromoBanner()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ok_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void ok_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void ok_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ok_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }

        private void ok_MouseLeave_1(object sender, MouseEventArgs e)
        {

        }
    }
}
