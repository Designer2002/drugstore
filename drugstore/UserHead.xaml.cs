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
    /// Логика взаимодействия для UserHead.xaml
    /// </summary>
    public partial class UserHead : Window
    {
        Brush find_color;
        Brush pro_color;

        async void FillTovars(TextBlock tn, TextBlock tp)
        {
            
            await Client.GetInstance().Send(App.Received.ToList(), Queries.GetTovarAndPrice());
            //field.Text = Encoding.UTF8.GetString(App.Received);
            var t = Queries.FindTovarPrice();
            tn.Text = t.Name;
            tp.Text = t.Price.ToString();
        }
        
        public UserHead()
        {
            
            InitializeComponent();
            countries.Items.Add("amogus");
            countries.Items.Add("amogus");
            countries.Items.Add("amogus");
            countries.Items.Add("amogus");
            countries.Items.Add("amogus");
            find_color = find.Background;
            pro_color = pro.Background;
            FillTovars(d1_name, d1_price);
            FillTovars(d2_name, d2_price);
            FillTovars(d3_name, d3_price);
            FillTovars(d4_name, d4_price);

        }

        private void grdHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Fold_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Fold_MouseEnter(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(204, 255, 182));
        }

        private void Fold_MouseLeave(object sender, MouseEventArgs e)
        {
            f.Background = new SolidColorBrush(Color.FromRgb(153, 255, 108));
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(211, 153, 105));
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = new SolidColorBrush(Color.FromRgb(255, 202, 108));
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void grdHeader_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void cart1_MouseEnter(object sender, MouseEventArgs e)
        {
            cart1.Width += 10;
        }

        private void cart1_MouseLeave(object sender, MouseEventArgs e)
        {
            cart1.Width -= 10;
        }

        private void cart1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartSuccess cs = new CartSuccess();
            cs.Show();
        }

        private void cart2_MouseEnter(object sender, MouseEventArgs e)
        {
            cart2.Width += 10;
        }

        private void cart2_MouseLeave(object sender, MouseEventArgs e)
        {
            cart2.Width -= 10;
        }

        private void cart2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartSuccess cs = new CartSuccess();
            cs.Show();
        }

        private void cart3_MouseEnter(object sender, MouseEventArgs e)
        {
            cart3.Width += 10;
        }

        private void cart3_MouseLeave(object sender, MouseEventArgs e)
        {
            cart3.Width -= 10;
        }

        private void cart3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartSuccess cs = new CartSuccess();
            cs.Show();
        }

        private void cart2_MouseEnter_1(object sender, MouseEventArgs e)
        {
            cart4.Width += 10;
        }

        private void cart2_MouseLeave_1(object sender, MouseEventArgs e)
        {
            cart4.Width -= 10;
        }

        private void cart2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            CartSuccess cs = new CartSuccess();
            cs.Show();
        }

        private void scroll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            chosenprice.Content = Convert.ToUInt32(scroll.Value).ToString();
        }

        private void countries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            exp.Header = countries.SelectedItem;
            exp.IsExpanded = false;
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

        private void pro_MouseEnter(object sender, MouseEventArgs e)
        {
            pro.Background = new SolidColorBrush(Colors.Black);
        }

        private void pro_MouseLeave(object sender, MouseEventArgs e)
        {
            pro.Background = pro_color;
        }

        private void pro_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserProfile p = new UserProfile();
            p.Show();
            this.Hide();

        }

        private void find_MouseEnter(object sender, MouseEventArgs e)
        {
            find.Background = new SolidColorBrush(Colors.DarkKhaki);
        }

        private void find_MouseLeave(object sender, MouseEventArgs e)
        {
            find.Background = find_color;
        }

        private void find_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Found f = new Found();
            f.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
