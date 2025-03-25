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
    /// Логика взаимодействия для CyberBox.xaml
    /// </summary>
    public partial class CyberBox : Window
    {
        Brush ok_clor;
        public CyberBox()
        {
            InitializeComponent();
            ok_clor = ok.Foreground;
        }
        public void Show(string _message)
        {
            
            message.Text = _message;
            this.Show();
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Colors.LawnGreen);
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(178, 255, 192));
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.Red);
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(255, 108, 108));
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ok_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

        private void ok_MouseEnter(object sender, MouseEventArgs e)
        {
            ok.Foreground = new SolidColorBrush(Colors.DarkGreen);
        }

        private void ok_MouseLeave(object sender, MouseEventArgs e)
        {
            ok.Foreground = ok_clor;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
