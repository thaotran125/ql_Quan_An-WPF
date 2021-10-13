using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using WpfQuanAn.Model;
using WpfQuanAn.view;

namespace WpfQuanAn.ViewModel
{
    public class KhachHangViewModel :BaseViewModel
    {
        private ObservableCollection<KHACHHANG> _List;
        public ObservableCollection<KHACHHANG> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private string _tenkh;
        public string tenkh { get => _tenkh; set { _tenkh = value; OnPropertyChanged(); } }

        private string _sdtkh;
        public string sdtkh { get => _sdtkh; set { _sdtkh = value; OnPropertyChanged(); } }

        private int? _diem;
        public int? diem { get => _diem; set { _diem = value; OnPropertyChanged(); } }

        private string _phai;
        public string phai { get => _phai; set { _phai = value; OnPropertyChanged(); } }

        private bool _radio1;
        public bool radio1 { get => _radio1; set { _radio1 = value; OnPropertyChanged(); } }

        private bool _radio2;
        public bool radio2 { get => _radio2; set { _radio2 = value; OnPropertyChanged(); } }

        private bool _isEnible;
        public bool isEnible
        {
            get => _isEnible;
            set
            {
                if (_isEnible == value)
                {
                    return;
                }
                _isEnible = value; OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Restart { get; set; }
        public ICommand isVisible { get; set; }

        private KHACHHANG _SelectedItem;
        public KHACHHANG SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (_SelectedItem != null)
                {
                    tenkh = SelectedItem.tenkh;
                    sdtkh = SelectedItem.sdtkh;
                    diem = (int)SelectedItem.diem;
                    if (SelectedItem.phai.Equals("nam"))
                    {
                        radio1 = true;
                        radio2 = false;
                    }
                    else
                    {
                        radio1 = false;
                        radio2 = true;
                    }
                }
            }
        }
        public KhachHangViewModel()
        {
            List = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs);


            AddCommand = new RelayCommand<object>((p) =>
            {
                if (tenkh == null || sdtkh == null || SelectedItem != null)
                    return false;
                return true;
            }, (p) =>
            {
                string gtinh = radio1 == true ? "nam" : "nữ";
                var khachHang = new KHACHHANG { tenkh = tenkh, sdtkh = sdtkh, diem = 0,phai=gtinh };
                DataProvider.Ins.DB.KHACHHANGs.Add(khachHang);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(khachHang);
                reset();
            }
           );

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.KHACHHANGs.Where(x => x.idkh == SelectedItem.idkh);
                if (displayList != null && displayList.Count() != 0)
                {
                    return true;
                }
                return false;
            }, (p) =>
            {
                var khachHang = DataProvider.Ins.DB.KHACHHANGs.Where(x => x.idkh == SelectedItem.idkh).SingleOrDefault();
                khachHang.tenkh = tenkh;
                khachHang.sdtkh = sdtkh;
                khachHang.diem = diem;
                khachHang.phai = radio1 == true ? "nam" : "nữ";
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.tenkh = tenkh;
                List = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs);
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.KHACHHANGs.Where(x => x.idkh == SelectedItem.idkh);
                if (displayList != null && displayList.Count() != 0)
                {
                    return true;
                }
                return false;
            }, (p) =>
            {
                MessageBoxResult mr = MessageBox.Show("ban muon xoa", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mr == MessageBoxResult.Yes)
                {
                    var khachHang = DataProvider.Ins.DB.KHACHHANGs.Where(x => x.idkh == SelectedItem.idkh).SingleOrDefault();
                    DataProvider.Ins.DB.KHACHHANGs.Remove(khachHang);
                    DataProvider.Ins.DB.SaveChanges();
                    List.Remove(khachHang);

                }
            });

            Restart = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null && tenkh == null && sdtkh == null)
                    return false;
                return true;
            }, (p) =>
            {
                reset();
            });

            reset();
        }

        public void reset()
        {
            tenkh = null;
            sdtkh = null;
            diem = null;
            SelectedItem = null;
        }
    }
}
