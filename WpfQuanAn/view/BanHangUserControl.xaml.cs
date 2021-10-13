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
    /// Interaction logic for BanHangUserControl.xaml
    /// </summary>
    public partial class BanHangUserControl : UserControl
    {
        public BanHangUserControl()
        {
            InitializeComponent();
        }

        private void BackHome_Click(object sender, RoutedEventArgs e)
        {
            BanAnUserControl uc = new BanAnUserControl();
            GridBHdParent.Children.Clear();
            GridBHdParent.Children.Add(uc);
        }
    }
}
