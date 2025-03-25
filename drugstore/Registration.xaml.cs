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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace drugstore
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : System.Windows.Window
    {
        SolidColorBrush b; //button's old color
        bool im;
        bool fam;
        bool log;
        bool par;
        bool conf;
        bool collide;
        public Registration()
        {
            InitializeComponent();
            b = new SolidColorBrush(Color.FromRgb(204, 135, 180));
            send_b.Background = new SolidColorBrush(Colors.DarkGray);
            send_b.IsEnabled = false;
            send.IsEnabled = false;
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(255, 108, 155));
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
            f.Background = new SolidColorBrush(Color.FromRgb(199, 205, 255));
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(108, 157, 255));
        }

        private void send_b_MouseEnter(object sender, MouseEventArgs e)
        {
            if (send_b.IsEnabled) send_b.Background = new SolidColorBrush(Color.FromRgb(255, 199, 215));
            collide = true;
        }

        private void send_b_MouseLeave(object sender, MouseEventArgs e)
        {
            if (send_b.IsEnabled) send_b.Background = new SolidColorBrush(Color.FromRgb(204, 135, 180));
            collide = false;
        }

        private async void send_b_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (send_b.IsEnabled)
            {
                send_b.Background = new SolidColorBrush(Color.FromRgb(148, 19, 56));
                //UserHead uh = new UserHead();
                //CyberBox c = new CyberBox();
                ////c.Show("вы успешно зарегистрировались!");
                //uh.Show();
                
                await Client.GetInstance().Send(App.Received.ToList(), Queries.RegisterCommand(login.Text, password.Password, name.Text, surname.Text));
                
                
                //MessageBox.Show(Encoding.UTF8.GetString(App.Received));
                if (Encoding.UTF8.GetString(App.Received).Contains("успех"))
                {
                   
                    WindowLogin m = new WindowLogin();
                    m.Show();
                    CyberBox c = new CyberBox();
                    c.Show("вы успешно зарегистрировались!");
                    this.Hide();
                }
                else
                {
                    CyberBoxError cer = new CyberBoxError();
                    cer.Show(Encoding.UTF8.GetString(App.Received));
                }
               
            }
        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(name.Text))
            {
                send_b.IsEnabled = false;
                notall.Visibility = Visibility.Visible;
                send_b.Background = new SolidColorBrush(Colors.DarkGray);
                im = false;
            }
            else im = true;
        }

        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(surname.Text))
            {
                send_b.IsEnabled = false;
                notall.Visibility = Visibility.Visible;
                send_b.Background = new SolidColorBrush(Colors.DarkGray);
                fam = false;
            }
            else fam = true;
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(login.Text))
            {
                send_b.IsEnabled = false;
                notall.Visibility = Visibility.Visible;
                send_b.Background = new SolidColorBrush(Colors.DarkGray);
                log = false;
            }
            else log = true;
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(password.Password))
            {
                send_b.IsEnabled = false;
                notall.Visibility = Visibility.Visible;
                send_b.Background = new SolidColorBrush(Colors.DarkGray);
                par = false;
            }
            else par = true;
        }

        private void confirm_password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(confirm_password.Password) || password.Password != confirm_password.Password)
            {
                send_b.IsEnabled = false;
                notall.Visibility = Visibility.Visible;
                send_b.Background = new SolidColorBrush(Colors.DarkGray);
                conf = false;
            }
            else
            {
                conf = true;
            }
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (im && fam && log && par && conf)
            {
                send_b.IsEnabled = true;
                send_b.Background = b;
                notall.Visibility = Visibility.Hidden;
                if (collide)
                {
                    send_b.Background = new SolidColorBrush(Color.FromRgb(255, 199, 215));
                }
                else
                {
                    send_b.Background = new SolidColorBrush(Color.FromRgb(204, 135, 180));
                }
            }
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.MediumPurple);
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            ba.Background = new SolidColorBrush(Colors.MediumOrchid);
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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
