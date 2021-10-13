using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WpfQuanAn.Model;


namespace WpfQuanAn.ViewModel
{
    public class ReportSoLuong_SanPhamViewModel : BaseViewModel
    {
        public SeriesCollection senderChart { get; set; }//data tung độ 

        private string[] _AxisListName;
        public string[] AxisListName
        {
            get { return _AxisListName; }
            set
            {
                _AxisListName = value;
                OnPropertyChanged();
            }
        }

        public ReportSoLuong_SanPhamViewModel()
        {
            List<RP_soLuong_sanPham_Result> List = new List<RP_soLuong_sanPham_Result>(DataProvider.Ins.DB.RP_soLuong_sanPham()).ToList();
            AxisListName = List.Select(x => x.tenfood).ToArray();//data cho hoành độ
            var intMapperWithColors = new LiveCharts.Configurations.CartesianMapper<int>()
            .X((value, index) => index)
            .Y((value) => value)
            .Fill((v, i) =>
            {
                switch (i % 12)
                {
                    case 0: return Brushes.LightBlue;
                    case 1: return Brushes.LightCoral;
                    case 2: return Brushes.PaleGoldenrod;
                    case 3: return Brushes.OrangeRed;
                    case 4: return Brushes.BlueViolet;
                    case 5: return Brushes.Chocolate;
                    case 6: return Brushes.PaleVioletRed;
                    case 7: return Brushes.CornflowerBlue;
                    case 8: return Brushes.Orchid;
                    case 9: return Brushes.Thistle;
                    case 10: return Brushes.BlanchedAlmond;
                    case 11: return Brushes.YellowGreen;
                    default: return Brushes.Red;
                }
            });
            LiveCharts.Charting.For<int>(intMapperWithColors, SeriesOrientation.Horizontal);

            senderChart = new SeriesCollection();

            var columnSeries = new ColumnSeries() { Values = new ChartValues<int>(), DataLabels = true, Title = "Số lượng" };
            foreach (var item in List)
            {
                columnSeries.Values.Add(int.Parse(item.soLuong.ToString()));
            }
            senderChart.Add(columnSeries);
        }
    }
}
