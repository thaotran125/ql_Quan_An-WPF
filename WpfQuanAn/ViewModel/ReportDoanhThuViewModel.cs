using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WpfQuanAn.Model;

namespace WpfQuanAn.ViewModel
{
    public class ReportDoanhThuViewModel : BaseViewModel
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

        public ICommand SelectionChangedCommand { get; set; }


        public ReportDoanhThuViewModel()
        {
            List<int> val = new List<int>();
            // ObservableCollection<Viewdoanh_thu> ListRP = new ObservableCollection<Viewdoanh_thu>(DataProvider.Ins.db.Viewdoanh_thus);
            SelectedItem = DateTime.Now.Month;
            ObservableCollection<prDoanhThu_Result> ListRP = new ObservableCollection<prDoanhThu_Result>(DataProvider.Ins.DB.prDoanhThu(DateTime.Now.Month));
            Axisngay = ListRP.Select(x => x.ngay.ToString()).ToArray();
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
