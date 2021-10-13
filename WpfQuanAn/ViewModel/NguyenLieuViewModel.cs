using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using WpfQuanAn.Model;

namespace WpfQuanAn.ViewModel
{
    public class NguyenLieuViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Restart { get; set; }
        public ICommand AddCommandLoai { get; set; }
        public ICommand EditCommandLoai { get; set; }
        public ICommand DeleteCommandLoai { get; set; }
        public ICommand TextChangedCommand { get; set; }

        //private ObservableCollection<NGUYENLIEU> _List;
        //public ObservableCollection<NGUYENLIEU> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<NGUYENLIEU> _ListNL;
        public ObservableCollection<NGUYENLIEU> ListNL { get => _ListNL; set { _ListNL = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAINL> _ListLoai;
        public ObservableCollection<LOAINL> ListLoai { get => _ListLoai; set { _ListLoai = value; OnPropertyChanged(); } }

        private ObservableCollection<NHACUNGCAP> _ListNCC;
        public ObservableCollection<NHACUNGCAP> ListNCC { get => _ListNCC; set { _ListNCC = value; OnPropertyChanged(); } }

        private List<loaddvt_Result> _ListDVT;
        public List<loaddvt_Result> ListDVT { get => _ListDVT; set { _ListDVT = value; OnPropertyChanged(); } }

        private int _idloai;
        public int idloai { get => _idloai; set { _idloai = value; OnPropertyChanged(); } }

        private int _idNCC;
        public int idNCC { get => _idNCC; set { _idNCC = value; OnPropertyChanged(); } }

        private string _tenNCC;
        public string tenNCC { get => _tenNCC; set { _tenNCC = value; OnPropertyChanged(); } }

        private string _tenloai;
        public string tenloai { get => _tenloai; set { _tenloai = value; OnPropertyChanged(); } }

        private int _idNL;
        public int idNL { get => _idNL; set { _idNL = value; OnPropertyChanged(); } }

        private string _tenNL;
        public string tenNL { get => _tenNL; set { _tenNL = value; OnPropertyChanged(); } }

        private string _dvt;
        public string dvt { get => _dvt; set { _dvt = value; OnPropertyChanged(); } }

        private int? _gia;
        public int? gia { get => _gia; set { _gia = value; OnPropertyChanged(); } }

        private int? _slton;
        public int? slton { get => _slton; set { _slton = value; OnPropertyChanged(); } }

        private string _Search;
        public string TxtSearch
        {
            get
            {
                return _Search;
            }
            set
            {
                _Search = value;
                OnPropertyChanged();

            }

        }

        private NGUYENLIEU _SelectedItem;
        public NGUYENLIEU SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    idloai = SelectedItem.idloainl;
                    idNCC = SelectedItem.idnhacc;
                    idNL = SelectedItem.idnl;
                    //SelectedItemLoai = SelectedItem.LOAINL;
                    tenloai = SelectedItem.LOAINL.tenloainl;
                    SelectedItemNCC = SelectedItem.NHACUNGCAP;
                    tenNL = SelectedItem.ten;
                    dvt = SelectedItem.DVT;
                    gia = (int)SelectedItem.gia;
                    slton = (int)SelectedItem.slton;
                }
            }
        }

        private LOAINL _SelectedItemLoai;
        public LOAINL SelectedItemLoai { get => _SelectedItemLoai;
            set
            {
                _SelectedItemLoai = value; OnPropertyChanged();
                if (_SelectedItemLoai != null)
                {
                    idloai = SelectedItemLoai.idloainl;
                    tenloai = SelectedItemLoai.tenloainl;
                    ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idloainl == SelectedItemLoai.idloainl));
                }
            }
        }

        private NHACUNGCAP _SelectedItemNCC;
        public NHACUNGCAP SelectedItemNCC { get => _SelectedItemNCC;
            set
            {
                _SelectedItemNCC = value; OnPropertyChanged();
                if (SelectedItemNCC != null)
                {
                    idNCC = SelectedItemNCC.idnhacc;
                    tenNCC = SelectedItemNCC.tennhacung;
                }
            }
        }

        private loaddvt_Result _SelectedItemdvt;
        public loaddvt_Result SelectedItemdvt { get => _SelectedItemdvt;
            set
            {
                _SelectedItemdvt = value; OnPropertyChanged();
                if (SelectedItemdvt != null)
                    dvt = SelectedItemdvt.DVT;
            }
        }

        public NguyenLieuViewModel()
        {
            //List = new ObservableCollection<loadNguyenLieu_Result>(DataProvider.Ins.DB.loadNguyenLieu());
            TxtSearch = null;
            ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx);
            ListLoai = new ObservableCollection<LOAINL>(DataProvider.Ins.DB.LOAINLs);
            ListNCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
            ListDVT = new List<loaddvt_Result>(DataProvider.Ins.DB.loaddvt());

            AddCommand = new RelayCommand<object>((p) =>
              {
                  if (tenNL == null || dvt == null || gia == null || SelectedItem != null)
                      return false;
                  return true;
              }, (p) => {
                  var nguyenlieu = new NGUYENLIEU() { idloainl = SelectedItemLoai.idloainl, idnhacc = SelectedItemNCC.idnhacc, ten = tenNL, DVT = SelectedItemdvt.DVT, gia = gia, slton = 0 };
                  DataProvider.Ins.DB.NGUYENLIEUx.Add(nguyenlieu);
                  DataProvider.Ins.DB.SaveChanges();
                  ListNL.Add(nguyenlieu);
                  resetNL();
                  ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idloainl == SelectedItemLoai.idloainl));
              });

            EditCommand = new RelayCommand<object>((p) => {
                if (SelectedItem == null)
                    return false;
                var nguyenlieu = DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idnl == idNL).SingleOrDefault();
                if (nguyenlieu == null)
                    return false;
                return true;
            }, (p) => {
                var nguyenlieu = DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idnl == idNL).SingleOrDefault();
                MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi nguyên liệu " + nguyenlieu.ten, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    nguyenlieu.idloainl = idloai;
                    nguyenlieu.idnhacc = idNCC;
                    nguyenlieu.ten = tenNL;
                    nguyenlieu.gia = gia;
                    nguyenlieu.DVT = dvt;
                    nguyenlieu.slton = slton;
                    DataProvider.Ins.DB.SaveChanges();
                    ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idloainl == SelectedItemLoai.idloainl));
                }
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                if (SelectedItem == null)
                    return false;
                var nguyenlieu = DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idnl == idNL).SingleOrDefault();
                if (nguyenlieu == null)
                    return false;
                return true;
            }, (p) => {
                var nguyenlieu = DataProvider.Ins.DB.NGUYENLIEUx.Where(x => x.idnl == idNL).SingleOrDefault();
                MessageBoxResult editRecord = MessageBox.Show("bạn muốn xóa nguyên liệu " + nguyenlieu.ten, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    DataProvider.Ins.DB.NGUYENLIEUx.Remove(nguyenlieu);
                    DataProvider.Ins.DB.SaveChanges();
                    ListNL.Remove(nguyenlieu);
                    resetNL();
                }
            });
            ////////////////////////////////////////////////////////////////
            AddCommandLoai = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemLoai != null || tenloai == null)
                      return false;
                  return true;
              }, (p) => {
                  LOAINL loai = new LOAINL() { tenloainl = tenloai };
                  DataProvider.Ins.DB.LOAINLs.Add(loai);
                  DataProvider.Ins.DB.SaveChanges();
                  ListLoai.Add(loai); reseetLoai();
              });

            EditCommandLoai = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemLoai == null)
                      return false;
                  //var loai = DataProvider.Ins.DB.LOAINLs.Where(x => x.idloainl == idloai).SingleOrDefault();
                  //if (loai == null)
                  //    return false;
                  return true;
              }, (p) => {
                  var loai = DataProvider.Ins.DB.LOAINLs.Where(x => x.idloainl == idloai).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi nguyên liệu " + loai.tenloainl, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      loai.tenloainl = tenloai;
                      DataProvider.Ins.DB.SaveChanges();
                      ListLoai = new ObservableCollection<LOAINL>(DataProvider.Ins.DB.LOAINLs); reseetLoai();
                  }
              });

            DeleteCommandLoai = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemLoai == null)
                      return false;
                  //var loai = DataProvider.Ins.DB.LOAINLs.Where(x => x.idloainl == idloai).SingleOrDefault();
                  //if (loai == null)
                  //    return false;
                  return true;
              }, (prop) => {
                  var loai = DataProvider.Ins.DB.LOAINLs.Where(x => x.idloainl == idloai).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn xóa nguyên liệu " + loai.tenloainl, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      DataProvider.Ins.DB.LOAINLs.Remove(loai);
                      DataProvider.Ins.DB.SaveChanges();
                      ListLoai.Remove(loai);
                      reseetLoai();
                  }
              });

            Restart = new RelayCommand<object>((p) =>
              { return true;
              }, (p) => {
                  reseetLoai(); resetNL();
                  ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx);
              });

            TextChangedCommand = new RelayCommand<object>((p) =>{ return true; },(p)=>{
                if(TxtSearch==null)
                    ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx);
                else
                {
                    ListNL = new ObservableCollection<NGUYENLIEU>(
                    from e in DataProvider.Ins.DB.NGUYENLIEUx
                    where e.ten.Contains(TxtSearch)
                    select e);
                }
                
            });
        }

       public void resetNL()
        {
            tenNL = null;
            gia = null;
            slton = null;
            SelectedItem = null;
            SelectedItemNCC = null;
        }

        public void reseetLoai()
        {
            tenloai = null;
            SelectedItemLoai = null;
        }

    }
}
