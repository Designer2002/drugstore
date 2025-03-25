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
    /// Логика взаимодействия для UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        string Password, Name, Surname;
        Brush bab, korz, clo, fold, sav, ext;
        public UserProfile()
        {
            InitializeComponent();
            bab = ba.Background;
            korz = pro.Background;
            clo = c.Background;
            fold = f.Background;
            sav = save.Background;
            ext = logout.Background;
            Password = "a";
            Name = "Даниил";
            Surname = "Огурцов";
            nam.Text = Name;
            sur.Text = Surname;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ba_MouseEnter(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.Orange);
        }

        private void ba_MouseLeave(object sender, MouseEventArgs e)
        {
            ba.Background = bab;
        }

        private void ba_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserHead uh = new UserHead();
            uh.Show();
            this.Hide();
        }

        private void nam_GotFocus(object sender, RoutedEventArgs e)
        {
            nam.Text = "";
            nam.GotFocus -= nam_GotFocus;
        }

        private void sur_GotFocus(object sender, RoutedEventArgs e)
        {
            sur.Text = "";
            sur.GotFocus -= sur_GotFocus;
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.OrangeRed);
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
            
            f.Background = new SolidColorBrush(Colors.Purple);
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = fold;
        }

        private void pro_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Cart up = new Cart();
            up.Show();
            this.Hide();
        }

        private void logout_MouseEnter(object sender, MouseEventArgs e)
        {
            logout.Background = new SolidColorBrush(Colors.DarkBlue);
        }

        private void logout_MouseLeave(object sender, MouseEventArgs e)
        {
            logout.Background = ext;
        }

        private void save_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(isValidPassword() && !String.IsNullOrWhiteSpace(nam.Text) && !String.IsNullOrWhiteSpace(sur.Text))
            {
                CyberBox c = new CyberBox();
                c.Show("изменения успешно сохранены");
                //alter table
                nam.GotFocus += nam_GotFocus;
                sur.GotFocus += sur_GotFocus;
            }
            else
            {
                CyberBoxError er = new CyberBoxError();
                er.Show("Ввод некорректен. Попробуйте ввести что-то другое");
            }
        }

        private void pro_MouseEnter(object sender, MouseEventArgs e)
        {
            pro.Background = new SolidColorBrush(Colors.DarkGray);
        }

        private void pro_MouseLeave(object sender, MouseEventArgs e)
        {
            pro.Background = korz;
        }

        private void find_MouseEnter(object sender, MouseEventArgs e)
        {
            save.Background = new SolidColorBrush(Colors.Crimson);
        }

        private void find_MouseLeave(object sender, MouseEventArgs e)
        {
            save.Background = sav;
        }

        private void logout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Hide();
        }
        bool isValidPassword()
        {
            return new_pas.Password == old_pas.Password && Password == old_pas.Password;
        }
    }
}
