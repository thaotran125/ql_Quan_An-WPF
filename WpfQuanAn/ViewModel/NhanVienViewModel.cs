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
    public class NhanVienViewModel : BaseViewModel
    {
        private ObservableCollection<NHANVIEN> _List;
        public ObservableCollection<NHANVIEN> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private NHANVIEN _SelectedItem;
        public NHANVIEN SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    tenNV = SelectedItem.tennv;
                    sdtnv = SelectedItem.sdtnv;
                    mail = SelectedItem.mail;
                    dcnv = SelectedItem.dcnv;
                    ngaysinh =DateTime.Parse(SelectedItem.ngaysinh.ToString());
                    if (SelectedItem.gioitinh.Equals("nam"))
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

        private string _tennv;
        public string tenNV { get => _tennv; set { _tennv = value; OnPropertyChanged(); } }

        private string _sdtnv;
        public string sdtnv { get => _sdtnv; set { _sdtnv = value; OnPropertyChanged(); } }

        private string _mail;
        public string mail { get => _mail; set { _mail = value; OnPropertyChanged(); } }

        private string _dcnv;
        public string dcnv { get => _dcnv; set { _dcnv = value; OnPropertyChanged(); } }

        private string _birth;
        public string birth { get => _birth; set { _birth = value; OnPropertyChanged(); } }

        private DateTime _ngaysinh;
        public DateTime ngaysinh { get => _ngaysinh; set { _ngaysinh = value; OnPropertyChanged(); } }

        private bool _radio1;
        public bool radio1 { get => _radio1; set { _radio1 = value; OnPropertyChanged(); } }

        private bool _radio2;
        public bool radio2 { get => _radio2; set { _radio2 = value; OnPropertyChanged(); } }



        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Restart { get; set; }
        public NhanVienViewModel()
        {
            List = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem != null || tenNV == null || sdtnv == null || mail == null || dcnv == null)
                    return false;
                return true;
            }, (p) =>
            {
                
                string gtinh = radio1 == true ? "nam" : "nữ";
                var nhanvien = new NHANVIEN() { tennv = tenNV, sdtnv = sdtnv, mail = mail, dcnv = dcnv, ngaysinh = ngaysinh, gioitinh = gtinh };
                DataProvider.Ins.DB.NHANVIENs.Add(nhanvien);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(nhanvien);
                reset();
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == SelectedItem.idnv);
                if (displayList != null && displayList.Count() != 0)
                {
                    return true;
                }
                return false;
            }, (p) =>
            {
                MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == SelectedItem.idnv).SingleOrDefault();
                    nhanvien.tennv = tenNV;
                    nhanvien.sdtnv = sdtnv;
                    nhanvien.mail = mail;
                    nhanvien.dcnv = dcnv;
                    nhanvien.ngaysinh = ngaysinh;
                   nhanvien.gioitinh=radio1 == true ? "nam" : "nữ";
                    DataProvider.Ins.DB.SaveChanges();

                    SelectedItem.tennv = tenNV;
                    List = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
                    reset();
                }
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == SelectedItem.idnv);
                if (displayList != null && displayList.Count() != 0)
                {
                    return true;
                }
                return false;
            }, (p) =>
            {
                var nhanvvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == SelectedItem.idnv).SingleOrDefault();

                MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa nhân viên" + nhanvvien.tennv.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (deleteRecord == MessageBoxResult.Yes)
                {
                    DataProvider.Ins.DB.NHANVIENs.Remove(nhanvvien);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Xóa thanah công nhân viên " + nhanvvien.tennv);
                    List.Remove(nhanvvien);
                    reset();
                }
            });

            Restart = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null && tenNV == null && sdtnv == null && mail == null && dcnv == null && radio1 == false && radio2 == false)
                    return false;
                return true;
            }, (p) =>
            {
                reset();
            });
        }
        public void reset()
        {
            tenNV = null;
            sdtnv = null;
            mail = null;
            dcnv = null;
            ngaysinh = DateTime.Now;
            radio1 = false;
            radio2 = false;
            SelectedItem = null;
        }
    }
}
