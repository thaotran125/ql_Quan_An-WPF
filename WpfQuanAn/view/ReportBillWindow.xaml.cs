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
    /// Interaction logic for ReportBillWindow.xaml
    /// </summary>
    public partial class ReportBillWindow : Window
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument Report { get; set; }
        public ReportBillWindow()
        {
            InitializeComponent();
        }
    }
}
