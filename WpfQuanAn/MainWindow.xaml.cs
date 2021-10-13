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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfQuanAn.Model;
using WpfQuanAn.view;
using WpfQuanAn.ViewModel;

namespace WpfQuanAn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
        }
        private void ShowHideMenu(string storyboardhide, Button myButton, Button myButton2, StackPanel pnl)
        {
            Storyboard sb = Resources[storyboardhide] as Storyboard;
            sb.Begin(pnl);

            if (storyboardhide.Contains("Show"))
            {
                myButton.Visibility = System.Windows.Visibility.Visible;
                myButton2.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (storyboardhide.Contains("Hide"))
            {
                myButton.Visibility = System.Windows.Visibility.Hidden;
                myButton2.Visibility = System.Windows.Visibility.Visible;
            }


        }
        private void btBanHang_click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new BanAnUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void btThongKe_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new ReportUserControl();
            GridContentUC.Children.Add(uc);
        }


        private void BTQLnhanVien_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new NhanVienUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLaccount_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new AccountUserControl1();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLkhachHang_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new KhachHangUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLNCC_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new NhaCungCapUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLNuyenLieu_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new NguyenLieuUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new PhieuNhapUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLFOOD_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new MonAnUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLBan_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new QLBanUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BTQLKHUYENAMI_Click(object sender, RoutedEventArgs e)
        {
            GridContentUC.Children.Clear();
            var uc = new KhuyenMaiUserControl();
            GridContentUC.Children.Add(uc);
        }

        private void BtsignOut_Click(object sender, RoutedEventArgs e)
        {
            //GridContentUC.Children.Clear();
            MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn đăng xuất " , "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (deleteRecord == MessageBoxResult.Yes)
            {
                var wd = new MainWindow();
                this.Hide();

                wd.ShowDialog();
            }
                

        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            //GridContentUC.Children.Clear();
            //var uc = new KhachHangUserControl();
            //GridContentUC.Children.Add(uc);
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            BANAN banAn = btn.DataContext as BANAN;

            DungChung.soban = banAn.soban;
            BanHangUserControl uc = new BanHangUserControl();
            GridContentUC.Children.Clear();
            GridContentUC.Children.Add(uc);
        }
    }
}
