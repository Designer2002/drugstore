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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace drugstore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Close.Margin = new Thickness(Width / 3, 0, 0, 0);
            Start.Margin = new Thickness(Width / 3 * -1, 0, 0, 0);
            canvas.Margin = new Thickness(Width / 7.2f, -20, 0, 0);
            
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close.Foreground = new SolidColorBrush(Colors.Crimson);
            this.Close();
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            Close.FontSize += 2;
            Close.Foreground = new SolidColorBrush(Color.FromRgb(255, 201, 182));
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            Close.FontSize -= 2;
            Close.Foreground = new SolidColorBrush(Colors.Pink);
        }

        private void Start_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            WindowLogin login = new WindowLogin();
            login.Show();
            this.Hide();
        }

        private void Start_MouseEnter(object sender, MouseEventArgs e)
        {
            Start.FontSize += 2;
            Start.Foreground = new SolidColorBrush(Color.FromRgb(221, 255, 129));
        }

        private void Start_MouseLeave(object sender, MouseEventArgs e)
        {
            Start.FontSize -= 2;
            Start.Foreground = new SolidColorBrush(Color.FromRgb(129, 255, 186));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
