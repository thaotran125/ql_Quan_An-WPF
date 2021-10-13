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
    public class MonAnViewModel:BaseViewModel
    {
        private ObservableCollection<FOOD> _List;
        public ObservableCollection<FOOD> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAIFOOD> _listLoaiFood;
        public ObservableCollection<LOAIFOOD> listLoaiFood { get => _listLoaiFood; set { _listLoaiFood = value; OnPropertyChanged(); } }

        private ObservableCollection<loadDvtfood_Result> _listDVT;
        public ObservableCollection<loadDvtfood_Result> listDVT { get => _listDVT; set { _listDVT = value; OnPropertyChanged(); } }

        private ObservableCollection<loadSizi_Result> _listSize;
        public ObservableCollection<loadSizi_Result> listSize { get => _listSize; set { _listSize = value; OnPropertyChanged(); } }

        private int _idloaifood;
        public int idloaifood { get => _idloaifood; set { _idloaifood = value; OnPropertyChanged(); } }

        private String _tenloaifood;
        public String tenloaifood { get => _tenloaifood; set { _tenloaifood = value; OnPropertyChanged(); } }


        private string _tenfood;
        public string tenfood { get => _tenfood; set { _tenfood = value; OnPropertyChanged(); } }

        private string _dvt;
        public string dvt { get => _dvt; set { _dvt = value; OnPropertyChanged(); } }

        private string _size;
        public string size { get => _size; set { _size = value; OnPropertyChanged(); } }

        private int? _gia;
        public int? gia { get => _gia; set { _gia = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandLoai { get; set; }
        public ICommand EditCommandLoai { get; set; }
        public ICommand DeleteCommandLoai { get; set; }
        public ICommand Restart { get; set; }

        private LOAIFOOD _SelectedLoaiFood;
        public LOAIFOOD SelectedLoaiFood
        {
            get => _SelectedLoaiFood;
            set
            {
                _SelectedLoaiFood = value; OnPropertyChanged();
                if (SelectedLoaiFood != null)
                {
                    idloaifood = (int)SelectedLoaiFood.idloaifood;
                    tenloaifood = SelectedLoaiFood.tenloaifood;
                    List = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood));
                }
            }
        }

        private FOOD _SelectedItem;
        public FOOD SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value; OnPropertyChanged();

                if (SelectedItem != null)
                {
                    tenfood = SelectedItem.tenfood;
                    size = SelectedItem.size;
                    gia = (int)SelectedItem.gia;
                    dvt = SelectedItem.DVT;
                }
            }
        }

        private loadDvtfood_Result _SelectedItemDVT;
        public loadDvtfood_Result SelectedItemDVT { get => _SelectedItemDVT;
            set
            {
                _SelectedItemDVT = value; OnPropertyChanged();
            }
        }

        private loadSizi_Result _SelectedItemSize;
        public loadSizi_Result SelectedItemSize { get=> _SelectedItemSize; 
            set {
                _SelectedItemSize = value; OnPropertyChanged();
            } }

        public MonAnViewModel()
        {
            List = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs);
            listLoaiFood = new ObservableCollection<LOAIFOOD>(DataProvider.Ins.DB.LOAIFOODs);
            listDVT = new ObservableCollection<loadDvtfood_Result>(DataProvider.Ins.DB.loadDvtfood());
            listSize = new ObservableCollection<loadSizi_Result>(DataProvider.Ins.DB.loadSizi());

            AddCommand = new RelayCommand<object>((p) =>
              {
                  if (tenfood == null || gia == null)
                      return false;
                  return true;
              },(p)=> {
                  var food = new FOOD() { idloaifood = idloaifood, tenfood = tenfood, size = size, gia = gia, DVT = dvt };
                  DataProvider.Ins.DB.FOODs.Add(food);
                  DataProvider.Ins.DB.SaveChanges(); resetFood();
                  listDVT = new ObservableCollection<loadDvtfood_Result>(DataProvider.Ins.DB.loadDvtfood());
                  List = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood));
              });

            EditCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItem == null)
                      return false;
                  var displayfood = DataProvider.Ins.DB.FOODs.Where(x => x.idfood == SelectedItem.idfood).SingleOrDefault();
                  if (displayfood == null)
                      return false;
                  return true;
              }, (p) => { 
                  var foodEdit = DataProvider.Ins.DB.FOODs.Where(x => x.idfood == SelectedItem.idfood).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi món ăn " + foodEdit.tenfood, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      foodEdit.tenfood = tenfood;
                  foodEdit.size = size;
                  foodEdit.gia = gia;
                  foodEdit.DVT = dvt;
                  DataProvider.Ins.DB.SaveChanges(); resetFood();
                  List = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood));
                  }
              });
            DeleteCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItem == null)
                      return false;
                  var displayfood = DataProvider.Ins.DB.FOODs.Where(x => x.idfood == SelectedItem.idfood).SingleOrDefault();
                  if (displayfood == null)
                      return false;
                  return true;
              },(p)=>
              {
                  var food = DataProvider.Ins.DB.FOODs.Where(x => x.idfood == SelectedItem.idfood).SingleOrDefault();
                  MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa món " + food.tenfood.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (deleteRecord == MessageBoxResult.Yes)
                  {
                      DataProvider.Ins.DB.FOODs.Remove(food);
                      DataProvider.Ins.DB.SaveChanges();
                      List.Remove(food); resetFood();
                  }
              });
            ///////////////////
            AddCommandLoai = new RelayCommand<object>((p) =>
            {
                if (tenloaifood == null || SelectedLoaiFood != null)
                    return false;
                return true;
            }, (p) =>
            {
                var loaifood = new LOAIFOOD() { tenloaifood = tenloaifood };
                DataProvider.Ins.DB.LOAIFOODs.Add(loaifood);
                DataProvider.Ins.DB.SaveChanges();
                listLoaiFood.Add(loaifood); resetLoai();
            });

            EditCommandLoai = new RelayCommand<object>((p) =>
            {
                if (SelectedLoaiFood == null)
                    return false;
                var displayList = DataProvider.Ins.DB.LOAIFOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood).SingleOrDefault();
               
                    if (displayList != null)
                    return true;
                return false;
            }, (p) => {
                var loaifood = DataProvider.Ins.DB.LOAIFOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood).Single();
                MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi loại món ăn " + loaifood.tenloaifood, "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    loaifood.tenloaifood = tenloaifood;
                    DataProvider.Ins.DB.SaveChanges(); resetLoai();
                    listLoaiFood = new ObservableCollection<LOAIFOOD>(DataProvider.Ins.DB.LOAIFOODs);
                }
            });

            DeleteCommandLoai = new RelayCommand<object>((p) =>
            {
                if (SelectedLoaiFood == null)
                    return false;
                var displayList = DataProvider.Ins.DB.LOAIFOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood);
                if (displayList != null && displayList.Count() > 0)
                    return true;
                return false;
            }, (p) => {
                LOAIFOOD loaifood = DataProvider.Ins.DB.LOAIFOODs.Where(x => x.idloaifood == SelectedLoaiFood.idloaifood).Single();
                MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa loại món ăn " + loaifood.tenloaifood.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (deleteRecord == MessageBoxResult.Yes)
                {
                    DataProvider.Ins.DB.LOAIFOODs.Remove(loaifood);
                    DataProvider.Ins.DB.SaveChanges();
                    listLoaiFood.Remove(loaifood); resetLoai();
                }
            });

            Restart = new RelayCommand<object>((p) =>
            {
                if (SelectedItem != null || SelectedLoaiFood != null)
                    return true;
                return false;
            }, (p) =>
            {
                resetFood();resetLoai();
                List = new ObservableCollection<FOOD>(DataProvider.Ins.DB.FOODs);
            });
        }

        public void resetFood()
        {
            tenfood = null;
            size = null;
            gia = null;
            dvt = null;
            SelectedItem = null;
        }

        public void resetLoai()
        {
            tenloaifood = null;
            SelectedLoaiFood = null;
        }
    }
}
