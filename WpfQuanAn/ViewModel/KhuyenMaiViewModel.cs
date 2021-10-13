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
    public class KhuyenMaiViewModel : BaseViewModel
    {
        private ObservableCollection<KHUYENMAI> _List;
        public ObservableCollection<KHUYENMAI> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAIFOOD> _ListLoai;
        public ObservableCollection<LOAIFOOD> ListLoai { get => _ListLoai; set { _ListLoai = value; OnPropertyChanged(); } }

        private ObservableCollection<FOOD> _ListFood;
        public ObservableCollection<FOOD> ListFood { get => _ListFood; set { _ListFood = value; OnPropertyChanged(); } }

        private ObservableCollection<FOOD> _ListFoodCb;
        public ObservableCollection<FOOD> ListFoodCb { get => _ListFoodCb; set { _ListFoodCb = value; OnPropertyChanged(); } }

        private int? _idkm;
        public int? idkm { get => _idkm; set { _idkm = value; OnPropertyChanged(); } }

        private string _tenkm;
        public string tenkm { get => _tenkm; set { _tenkm = value; OnPropertyChanged(); } }

        private DateTime? _ngayBD;
        public DateTime? ngayBD { get => _ngayBD; set { _ngayBD = value; OnPropertyChanged(); } }

        private DateTime? _ngayKT;
        public DateTime? ngayKT { get => _ngayKT; set { _ngayKT = value; OnPropertyChanged(); } }

        private string _ghiChu;
        public string ghiChu { get => _ghiChu; set { _ghiChu = value; OnPropertyChanged(); } }

        private string _tenFood;
        public string tenFood { get => _tenFood; set { _tenFood = value; OnPropertyChanged(); } }

        private float? _chietKhau;
        public float? chietKhau { get => _chietKhau; set { _chietKhau = value; OnPropertyChanged(); } }

        private KHUYENMAI _SelectedItem;
        public KHUYENMAI SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    idkm = SelectedItem.idkm;
                    tenkm = SelectedItem.tenkm;
                    ngayBD = SelectedItem.ngayBD;
                    ngayKT = SelectedItem.ngayKT;
                    ghiChu = SelectedItem.ghichu;
                    chietKhau = (float)SelectedItem.chietKhau*100;
                }
            }
        }
        /////////////////////////////

        private LOAIFOOD _SelectedItemLoai;
        public LOAIFOOD SelectedItemLoai
        {
            get => _SelectedItemLoai;
            set
            {
                _SelectedItemLoai = value; OnPropertyChanged();
                if (SelectedItemLoai != null)
                {
                    ListFood = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs.Where(x => x.idloaifood == SelectedItemLoai.idloaifood));
                }
            }
        }

        private FOOD _SelectedItemFood;
        public FOOD SelectedItemFood
        {
            get => _SelectedItemFood;
            set
            {
                _SelectedItemFood = value; OnPropertyChanged();
                if (SelectedItemFood != null)
                {
                    tenFood = SelectedItemFood.tenfood;
                }
            }
        }

       

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand Restart { get; set; }
        ////////////////////////////////
        public KhuyenMaiViewModel()
        {
            List = new ObservableCollection<KHUYENMAI>(DataProvider.Ins.DB.KHUYENMAIs);
            ListLoai = new ObservableCollection<LOAIFOOD>(DataProvider.Ins.DB.LOAIFOODs);
            ListFoodCb = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (tenkm == null || SelectedItem != null)
                    return false;
                return true;
            }, (p) =>
            {
                KHUYENMAI km = new KHUYENMAI() { tenkm = tenkm, ngayBD = ngayBD, ngayKT = ngayKT, ghichu = ghiChu, chietKhau=chietKhau/100 };
                DataProvider.Ins.DB.KHUYENMAIs.Add(km);
                DataProvider.Ins.DB.SaveChanges(); resetKM();
                List.Add(km);
                List<FOOD> listfood = new List<FOOD>(DataProvider.Ins.DB.FOODs).ToList();
                foreach(FOOD item in listfood)
                {
                    item.idkm = km.idkm;
                    DataProvider.Ins.DB.SaveChanges();
                }
            });

            EditCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItem == null)
                      return false;
                  var km = DataProvider.Ins.DB.KHUYENMAIs.Where(x => x.idkm == SelectedItem.idkm).SingleOrDefault();
                  if (km == null)
                      return false;
                  return true;
              }, (p) =>
              {
                  var editKM = DataProvider.Ins.DB.KHUYENMAIs.Where(x => x.idkm == SelectedItem.idkm).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi " + editKM.tenkm, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      editKM.tenkm = tenkm;
                      editKM.ngayBD = ngayBD;
                      editKM.ngayKT = ngayKT;
                      editKM.ghichu = ghiChu;
                      editKM.chietKhau = chietKhau/100;
                      DataProvider.Ins.DB.SaveChanges(); resetKM();
                      List = new ObservableCollection<KHUYENMAI>(DataProvider.Ins.DB.KHUYENMAIs);

                      List<FOOD> listfood = new List<FOOD>(DataProvider.Ins.DB.FOODs).ToList();
                      foreach (FOOD item in listfood)
                      {
                          item.idkm = editKM.idkm;
                          DataProvider.Ins.DB.SaveChanges();
                      }
                  }
              });

            DeleteCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItem == null)
                      return false;
                  var km = DataProvider.Ins.DB.KHUYENMAIs.Where(x => x.idkm == SelectedItem.idkm).SingleOrDefault();
                  if (km == null)
                      return false;
                  return true;
              }, (p) =>
              {
                  var delKM = DataProvider.Ins.DB.KHUYENMAIs.Where(x => x.idkm == SelectedItem.idkm).SingleOrDefault();
                  MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa món " + delKM.tenkm.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (deleteRecord == MessageBoxResult.Yes)
                  {
                      DataProvider.Ins.DB.KHUYENMAIs.Remove(delKM); resetKM();
                      List.Remove(delKM);
                  }
              });
           

            Restart = new RelayCommand<object>((p) =>
              {
                  if ( SelectedItem != null)
                      return true;
                  return false;
              }, (p) =>
              {
                  resetKM();
              });
        }

        public void resetKM()
        {
            idkm = null;
            SelectedItem = null;
            tenkm = null;
            ghiChu = null;
            chietKhau = null;
            ngayBD = DateTime.Now;
            ngayKT = DateTime.Now;
        }

      
    }
}
