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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        Brush bao, fo, co, fi;
        public Cart()
        { 
            InitializeComponent();
            bao = ba.Background;
            fo = f.Background;
            co = c.Background;
            fi = find.Background;
            chasy_raboty.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            delete.Foreground = new SolidColorBrush(Colors.Pink);
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            delete.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //delete query
        }

        private void ba_MouseEnter(object sender, MouseEventArgs e)
        {
            
            ba.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void ba_MouseLeave(object sender, MouseEventArgs e)
        {
            ba.Background = bao;
        }

        private void ba_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserHead uh = new UserHead();
            uh.Show();
            this.Hide();
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.DarkKhaki);
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = co;
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void find_MouseEnter(object sender, MouseEventArgs e)
        {
            find.Background = new SolidColorBrush(Colors.SkyBlue);
        }

        private void find_MouseLeave(object sender, MouseEventArgs e)
        {
            find.Background = fi;
        }

        private void find_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(fili.SelectedIndex != -1 && !String.IsNullOrWhiteSpace(tel.Text))
            {
                CyberBox c = new CyberBox();
                c.Show("Заказ можно забрать послезавтра. вам позвонят!");
                //flush the cart!
                UserHead uh = new UserHead();
                uh.Show();
                this.Hide();
            }
            else
            {
                CyberBoxError er = new CyberBoxError();
                er.Show("Что-то пустует. так нельзя.");
            }
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void fili_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //chasy raboty!!!
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
