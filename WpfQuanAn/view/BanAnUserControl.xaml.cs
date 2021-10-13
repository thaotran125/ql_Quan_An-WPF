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

using WpfQuanAn.Model;
using WpfQuanAn.ViewModel;

namespace WpfQuanAn.view
{
    /// <summary>
    /// Interaction logic for BanAnUserControl.xaml
    /// </summary>
    public partial class BanAnUserControl : UserControl
    {
        public BanAnUserControl()
        {
            InitializeComponent();
            //List<BANAN> listContent = DataProvider.Ins.DB.BANANs.ToList();
            //this.ic.Items.Clear();
            //foreach(BANAN bc in listContent)
            //{
            //    Button btn = new Button();
            //    btn.Click +=new RoutedEventHandler(Table_Click);
            //    btn.Content = bc.tenban;
            //    btn.Height = 50;
            //    btn.Width = 190;
            //    btn.Margin = new Thickness(10, 5, 0, 5);
            //    this.ic.Items.Add(btn);
            //}

        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            BANAN banAn = btn.DataContext as BANAN;

            DungChung.soban = banAn.soban;
            BanHangUserControl uc = new BanHangUserControl();
            gridParent.Children.Clear();
            gridParent.Children.Add(uc);
            
        }

        private void BackHome_Click(object sender, RoutedEventArgs e)
        {
            BanAnUserControl uc = new BanAnUserControl();
            gridParent.Children.Clear();
            gridParent.Children.Add(uc);
        }
    }
}
