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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Window
    {
        Brush bab, fo, clo;
        public EmployeePage()
        {
            InitializeComponent();
            bab = ba.Background;
            clo = c.Background;
            fo = f.Background;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ba_MouseEnter(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.SkyBlue);
        }

        private void ba_MouseLeave(object sender, MouseEventArgs e)
        {
            ba.Background = bab;
        }

        private void ba_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.Red);
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = clo;
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = fo;
        }

        private void uved_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void uved_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void uved_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void edit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void edit_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void edit_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void add_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void add_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void add_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void spic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void spic_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void spic_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void zak_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void zak_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void zak_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void find_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void find_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void find_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void notifications_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
