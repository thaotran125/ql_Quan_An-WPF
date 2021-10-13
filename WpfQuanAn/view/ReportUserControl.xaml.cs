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

namespace WpfQuanAn.view
{
    /// <summary>
    /// Interaction logic for ReportUserControl.xaml
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void RPThang_Click(object sender, RoutedEventArgs e)
        {
            ReportDoanhThuUserControl uc = new ReportDoanhThuUserControl();
            this.GridReport.Children.Clear();
            this.GridReport.Children.Add(uc);
        }

        private void RPNgay_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void RPLoai_Click(object sender, RoutedEventArgs e)
        {
            ReportLoaiUC uc = new ReportLoaiUC();
            this.GridReport.Children.Clear();
            this.GridReport.Children.Add(uc);
        }

        private void RPSanPham_Click(object sender, RoutedEventArgs e)
        {
            ReportSL_SanPhamUserControl uc = new ReportSL_SanPhamUserControl();
            this.GridReport.Children.Clear();
            this.GridReport.Children.Add(uc);
        }
    }
}
