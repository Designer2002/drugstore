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
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        
        public WindowLogin()
        {
            InitializeComponent();

            //pairs = DatabaseEngine.GetInstance().MakeLoginsAndPasswordsPair();
            
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(177, 237, 255));
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(108, 222, 255));
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(255, 177, 255));
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(255, 108, 255));
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void enter_MouseEnter(object sender, MouseEventArgs e)
        {
            en.Background = new SolidColorBrush(Color.FromRgb(255, 177, 255));
        }

        private void enter_MouseLeave(object sender, MouseEventArgs e)
        {
            en.Background = new SolidColorBrush(Color.FromRgb(255, 108, 255));
        }

        private void reg_MouseEnter(object sender, MouseEventArgs e)
        {
            r.Background = new SolidColorBrush(Color.FromRgb(177, 237, 255));
        }

        private void reg_MouseLeave(object sender, MouseEventArgs e)
        {
            r.Background = new SolidColorBrush(Color.FromRgb(108, 222, 255));
        }

        private void reg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private async void enter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //CyberBox c = new CyberBox();
            //UserHead uh = new UserHead();
            //uh.Show();
            //c.Show("вход получился!");
            //this.Hide();
            await Client.GetInstance().Send(App.Received.ToList(), Queries.GetLogPasRole(login.Text));
            //MessageBox.Show(Queries.FindLogPassRole().Login);
            //MessageBox.Show(Queries.FindLogPassRole().Password);
            //MessageBox.Show(Queries.FindLogPassRole().Role);
            //MessageBox.Show(Encoding.UTF8.GetString(App.Received));
            if (ValidAuthorize(login.Text, password.Password))
            {
                CyberBox c = new CyberBox();
                c.Show("вход получился!");
                switch(Queries.FindLogPassRole().Role)
                {
                    case "1": //admin
                        AdminPage a = new AdminPage();
                        a.Show();
                        break;
                    case "2": //sotr
                        EmployeePage emp = new EmployeePage();
                        emp.Show();
                        break;
                    case "3":
                        UserHead uh = new UserHead();
                        uh.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                CyberBoxError ce = new CyberBoxError();
                ce.Show("авторизация прошла неудачно");
            }
        }

        private bool ValidAuthorize(string login, string password)
        {
            //pairs = Queries..();
            //return pairs.Keys.Contains(login) && pairs.Values.Contains(password);
            return Queries.FindLogPassRole().Login == login && Queries.FindLogPassRole().Password == password;
        }

        private void ba_MouseEnter(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.MediumPurple);
        }

        private void ba_MouseLeave(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.MediumOrchid);
        }

        private void ba_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
