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

namespace WpfQuanAn.view
{
    /// <summary>
    /// Interaction logic for pageThongBao.xaml
    /// </summary>
    public partial class pageThongBao : Window
    {
        public pageThongBao()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            
            BanHangUserControl uc = new BanHangUserControl();
            uc.GridBHdParent.Children.Clear();
            BanAnUserControl banAnUC = new BanAnUserControl();
            uc.GridBHdParent.Children.Add(banAnUC);
            this.Close();
        }
    }
}
