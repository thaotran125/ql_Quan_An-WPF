using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using WpfQuanAn.Model;

namespace WpfQuanAn.ViewModel
{
   public class PhieuNhapViewModel:BaseViewModel
    {
        private ObservableCollection<PHIEUNHAP> _List;
        public ObservableCollection<PHIEUNHAP> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<CTPHIEUNHAP> _ListCTPN;
        public ObservableCollection<CTPHIEUNHAP> ListCTPN { get => _ListCTPN; set { _ListCTPN = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _ListNV;
        public ObservableCollection<NHANVIEN> ListNV { get => _ListNV; set { _ListNV = value; OnPropertyChanged(); } }

        private ObservableCollection<NGUYENLIEU> _ListNL;
        public ObservableCollection<NGUYENLIEU> ListNL { get => _ListNL; set { _ListNL = value; OnPropertyChanged(); } }

        private string _tenNV;
        public string tenNV { get => _tenNV; set { _tenNV = value; OnPropertyChanged(); } }

        private DateTime? _ngayNhap;
        public DateTime? ngayNhap { get => _ngayNhap; set  { _ngayNhap = value;  OnPropertyChanged();  } }

        private string _tenNL;
        public string tenNL { get => _tenNL; set { _tenNL = value; OnPropertyChanged(); } }

        private int? _slNhap;
        public int? slMhap { get => _slNhap; set { _slNhap = value; OnPropertyChanged(); } }

        private NHANVIEN _SelectedItemNV;
        public NHANVIEN SelectedItemNV { get => _SelectedItemNV; set { _SelectedItemNV = value; OnPropertyChanged(); } }

        private NGUYENLIEU _SelectedItemNL;
        public NGUYENLIEU SelectedItemNL { get => _SelectedItemNL; set { _SelectedItemNL = value; OnPropertyChanged(); } }

        private PHIEUNHAP _SelectItemPN;
        public PHIEUNHAP SelectedItemPN { get => _SelectItemPN; 
            set {
                _SelectItemPN = value; OnPropertyChanged();
                if (SelectedItemPN != null)
                {
                    tenNV = SelectedItemPN.NHANVIEN.tennv;
                    ngayNhap = SelectedItemPN.ngaynhap;
                    SelectedItemNV = SelectedItemPN.NHANVIEN;
                    ListCTPN = new ObservableCollection<CTPHIEUNHAP>(DataProvider.Ins.DB.CTPHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn));
                }
            } 
        }

        private CTPHIEUNHAP _SelectedItemCTPM;
        public CTPHIEUNHAP SelectedItemCTPM { get => _SelectedItemCTPM;
            set {
                _SelectedItemCTPM = value; OnPropertyChanged();
                if (SelectedItemCTPM != null)
                {
                    tenNL = SelectedItemCTPM.NGUYENLIEU.ten;
                    slMhap = SelectedItemCTPM.slnhap;
                    SelectedItemNL = _SelectedItemCTPM.NGUYENLIEU;
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandCTPM { get; set; }
        public ICommand EditCommandCTPM { get; set; }
        public ICommand DeleteCommandCTPM { get; set; }
        public ICommand Restart { get; set; }

        public PhieuNhapViewModel()
        {
            List = new ObservableCollection<PHIEUNHAP>(DataProvider.Ins.DB.PHIEUNHAPs);
            ListNV = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
            ListNL = new ObservableCollection<NGUYENLIEU>(DataProvider.Ins.DB.NGUYENLIEUx);

            AddCommand = new RelayCommand<object>((p) => {
                if (tenNV == null || SelectedItemPN != null)
                    return false;
                return true;
            },(p)=> {
                PHIEUNHAP pn = new PHIEUNHAP() { idnv = SelectedItemNV.idnv, ngaynhap = ngayNhap };
                DataProvider.Ins.DB.PHIEUNHAPs.Add(pn);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(pn); resetPM();
            });

            EditCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemPN == null)
                      return false;
                  return true;
              },(p)=> {
                  PHIEUNHAP editpn = DataProvider.Ins.DB.PHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi phieu nhap " + editpn.idpn, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      editpn.idnv = SelectedItemNV.idnv;
                      editpn.ngaynhap = ngayNhap;
                      DataProvider.Ins.DB.SaveChanges();
                      List = new ObservableCollection<PHIEUNHAP>(DataProvider.Ins.DB.PHIEUNHAPs);
                      resetPM();
                  }
              });

            DeleteCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemPN == null)
                      return false;
                  return true;
              },(p)=> {
                  PHIEUNHAP delpn = DataProvider.Ins.DB.PHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn).SingleOrDefault();
                  MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa phieu nhap " + delpn.idpn.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (deleteRecord == MessageBoxResult.Yes)
                  {
                      DataProvider.Ins.DB.PHIEUNHAPs.Remove(delpn);
                      DataProvider.Ins.DB.SaveChanges();
                      List.Remove(delpn); resetPM();
                  }
              });

            AddCommandCTPM = new RelayCommand<object>((p) =>
              {
                  if (tenNL == null || _slNhap == null || SelectedItemCTPM != null)
                      return false;
                  return true;
              },(p)=> {
                  CTPHIEUNHAP ctpn = new CTPHIEUNHAP() { idpn = SelectedItemPN.idpn, idnl = SelectedItemNL.idnl, slnhap = slMhap };
                  DataProvider.Ins.DB.CTPHIEUNHAPs.Add(ctpn);
                  DataProvider.Ins.DB.SaveChanges();
                  ListCTPN.Add(ctpn); resetCTPM();
              });

            EditCommandCTPM = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCTPM == null)
                    return false;
                return true;
            },(p)=> {
                CTPHIEUNHAP editCTPM = DataProvider.Ins.DB.CTPHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn && x.idnl == SelectedItemCTPM.idnl).SingleOrDefault();
                MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi CT phieu nhap " + editCTPM.idpn, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    editCTPM.idnl = SelectedItemNL.idnl;
                    editCTPM.slnhap = slMhap;
                    DataProvider.Ins.DB.SaveChanges();
                    ListCTPN = new ObservableCollection<CTPHIEUNHAP>(DataProvider.Ins.DB.CTPHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn));
                    resetCTPM();
                }
            });

            DeleteCommandCTPM = new RelayCommand<object>((p) =>
              {
                  if (_SelectedItemCTPM == null)
                      return false;
                  return true;
              },(p)=> {
                  CTPHIEUNHAP delCTPM = DataProvider.Ins.DB.CTPHIEUNHAPs.Where(x => x.idpn == SelectedItemPN.idpn && x.idnl == SelectedItemCTPM.idnl).SingleOrDefault();
                  DataProvider.Ins.DB.CTPHIEUNHAPs.Remove(delCTPM);
                  DataProvider.Ins.DB.SaveChanges();
                  ListCTPN.Remove(delCTPM); resetCTPM();
              });

            Restart = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPN == null || SelectedItemCTPM == null)
                    return false;
                return true;
            },(p)=> {
                resetPM(); resetCTPM();
            });
        }

        public void resetPM()
        {
            SelectedItemPN = null;
            SelectedItemNV = null;
            tenNL = null;
            ngayNhap = DateTime.Now;
        }

        public void resetCTPM()
        {
            SelectedItemCTPM = null;
            SelectedItemNL = null;
            tenNL = null;
            slMhap = null;
        }
    }
}
