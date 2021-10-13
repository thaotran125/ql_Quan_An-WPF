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
    public class ReportViewModel : BaseViewModel
    {
        private string _thang;
        public string thang { get => _thang; set { _thang = value; OnPropertyChanged(); } }

        private int _SelectedItem;
        public int SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
            }
        }

        private string[] _Axisngay;
        public string[] Axisngay
        {
            get { return _Axisngay; }
            set
            {
                _Axisngay = value;
                OnPropertyChanged();
            }
        }

        private ChartValues<int> _columDoanhThu;
        public ChartValues<int> columDoanhThu
        {
            get => _columDoanhThu;
            set { _columDoanhThu = value; OnPropertyChanged(nameof(columDoanhThu)); }
        }
        /// <summary>
        /// //////////////////////////////////
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


        public ICommand SelectionChangedCommand { get; set; }
        public ICommand CommandReportLoai { get; set; }
        public ICommand CommandReportSanPham { get; set; }
        public ICommand CommandReportThang { get; set; }
        public ICommand CommandReportNgay { get; set; }
        public ICommand LoadedCommand { get; set; }
        public ICommand LoadedLoaiCommand { get; set; }

        private List<int> _val;
        public List<int> val { get => _val; set { _val = value; OnPropertyChanged(); } }

        private int? _TongLoai;
        public int? TongLoai { get => _TongLoai; set { _TongLoai = value; OnPropertyChanged(); } }

        //private double? _doanhThuNgay;
        //public double? doanhThuNgay { get => _doanhThuNgay; set { _doanhThuNgay = value; OnPropertyChanged(); } }

        private string _doanhThuNgay;
        public string doanhThuNgay { get => _doanhThuNgay; set { _doanhThuNgay = value; OnPropertyChanged(); } }

        private string _spBanChayo;
        public string spBanChay { get => _spBanChayo; set { _spBanChayo = value; OnPropertyChanged(); } }

        private int? _tongSP;
        public int? tongSP { get => _tongSP; set { _tongSP = value; OnPropertyChanged(); } }

        private string _slBan;
        public string slBan { get => _slBan; set { _slBan = value; OnPropertyChanged(); } }
        //List<RP_sanPham_banChay_Result> listSpHot { get; set; }
        public ReportViewModel()
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
            List<int> val = new List<int>();
            // ObservableCollection<Viewdoanh_thu> ListRP = new ObservableCollection<Viewdoanh_thu>(DataProvider.Ins.db.Viewdoanh_thus);
            SelectedItem = DateTime.Now.Month;
            ObservableCollection<prDoanhThu_Result> ListRP = new ObservableCollection<prDoanhThu_Result>(DataProvider.Ins.DB.prDoanhThu(DateTime.Now.Month));
            Axisngay = ListRP.Select(x => x.ngay.ToString()).ToArray();
            LoadedCommand = new RelayCommand<object>((p) => { return true; },(p)=>
            {
                TongLoai = DataProvider.Ins.DB.LOAIFOODs.Count();
                tongSP = DataProvider.Ins.DB.FOODs.Count();
                //listSpHot = new List<RP_sanPham_banChay_Result>(DataProvider.Ins.DB.RP_sanPham_banChay());
                var sp = DataProvider.Ins.DB.RP_sanPham_banChay().SingleOrDefault();
                spBanChay = sp.tenfood;
                slBan= " đã bán " + sp.daBan;
                var DT = DataProvider.Ins.DB.RP_doanhThuNgay().SingleOrDefault();
                double doanh_thu =(double)DT.doanhThu;
                doanhThuNgay = doanh_thu.ToString("0,0.0", CultureInfo.InvariantCulture);
                //////////////////
                
            });

            columDoanhThu = new ChartValues<int> { };
            foreach (var item in ListRP)
            {
                columDoanhThu.Add(int.Parse(item.doanhthu.ToString()));
                val.Add(int.Parse(item.doanhthu.ToString()));
                //string day = item.ngay.ToString() + "/" + item.thang.ToString();
            }
            SelectionChangedCommand = new RelayCommand<object>((p) => {
                return true;
            }, (p) => {
                ListRP = new ObservableCollection<prDoanhThu_Result>(DataProvider.Ins.DB.prDoanhThu(SelectedItem));
                Axisngay = ListRP.Select(x => x.ngay.ToString()).ToArray();
                columDoanhThu = new ChartValues<int> { };

                foreach (var item in ListRP)
                {
                    columDoanhThu.Add(int.Parse(item.doanhthu.ToString()));
                    val.Add(int.Parse(item.doanhthu.ToString()));
                    //string day = item.ngay.ToString() + "/" + item.thang.ToString();
                }
            });
        }
    }
}
