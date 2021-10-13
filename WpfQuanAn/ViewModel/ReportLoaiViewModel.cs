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
    public class ReportLoaiViewModel : BaseViewModel
    {
        public SeriesCollection senderChartLoai { get; set; }//data tung độ 

        private string[] _AxisListNameLoai;
        public string[] AxisListNameLoai
        {
            get { return _AxisListNameLoai; }
            set
            {
                _AxisListNameLoai = value;
                OnPropertyChanged();
            }
        }

        public ReportLoaiViewModel()
        {
            List<RP_soLuong_loai_Result> List_slLoai = new List<RP_soLuong_loai_Result>(DataProvider.Ins.DB.RP_soLuong_loai()).ToList();
            AxisListNameLoai = List_slLoai.Select(x => x.tenloaifood).ToArray();//data cho hoành độ
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

            senderChartLoai = new SeriesCollection();

            var columnSeries = new ColumnSeries() { Values = new ChartValues<int>(), DataLabels = true, Title = "Số lượng" };
            foreach (var item in List_slLoai)
            {
                columnSeries.Values.Add(int.Parse(item.soLuong.ToString()));
            }
            senderChartLoai.Add(columnSeries);
        }
    }
}
