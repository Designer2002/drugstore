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
    /// Логика взаимодействия для Found.xaml
    /// </summary>
    
    public partial class Found : Window
    {
        Brush bab, po, fo, clo;
        public Found()
        {
            InitializeComponent();
            bab = korz.Background;
            po = poisk.Background;
            fo = f.Background;
            clo = c.Background;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void nazn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.DarkKhaki);
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = clo;
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void poisk_MouseEnter(object sender, MouseEventArgs e)
        {
            poisk.Background = new SolidColorBrush(Colors.Blue);
        }

        private void korz_MouseEnter(object sender, MouseEventArgs e)
        {
            korz.Background = new SolidColorBrush(Colors.Pink);
        }

        private void poisk_MouseLeave(object sender, MouseEventArgs e)
        {
            poisk.Background = po;
        }

        private void poisk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //add to cart
            CartSuccess cs = new CartSuccess();
            cs.Show();

        }

        private void korz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserHead uh = new UserHead();
            uh.Show();
            this.Hide();
        }

        private void korz_MouseLeave(object sender, MouseEventArgs e)
        {
            korz.Background = bab;
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Colors.SkyBlue);
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = fo;
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
