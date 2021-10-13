using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;

using WpfQuanAn.Model;
using WpfQuanAn.view;
namespace WpfQuanAn.ViewModel
{
   public class BanAnViewModel:BaseViewModel
    {
        private ObservableCollection<BANAN> _ListBan;
        public ObservableCollection<BANAN> ListBan { get => _ListBan; set { _ListBan = value; OnPropertyChanged(); } }

        private string _tenBan;
        public string tenBan { get => _tenBan; set { _tenBan = value; OnPropertyChanged(); } }

        private int? _BanPhucVu;
        public int? BanPhucVu { get => _BanPhucVu; set { _BanPhucVu = value; OnPropertyChanged(); } }

        private int? _tongSoBanThem;
        public int? tongSoBanThem { get => _tongSoBanThem; set { _tongSoBanThem = value; OnPropertyChanged(); } }

        private string _TongSoBan;
        public string TongSoBan { get => _TongSoBan; set { _TongSoBan = value; OnPropertyChanged(); } }
        public ICommand LoadedCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Restart { get; set; }
        int sum ;
        public BanAnViewModel()
        {
            ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);
            sum = ListBan.Count();
            TongSoBan = "Tổng số bàn là " + sum;

            LoadedCommand = new RelayCommand<object>((p) => { return true; }, (p) => { 
                ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);
                BanPhucVu = DataProvider.Ins.DB.BANANs.Where(x => x.tinhtrang==1).Count();
                sum =ListBan.Count();
                TongSoBan = "Tổng số bàn là " + sum;
            });

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (tongSoBanThem != null)
                    return true;
                return false;
            },(p)=>
            {
                for(int i=0; i<tongSoBanThem; i++)
                {
                    sum++;
                    string ten = " Bàn " + sum;
                    BANAN table = new BANAN() { soban=sum,tenban=ten, tinhtrang=0};
                    DataProvider.Ins.DB.BANANs.Add(table);
                    DataProvider.Ins.DB.SaveChanges();
                }
                TongSoBan = "Tổng số bàn là " + sum;
            });

            DeleteCommand = new RelayCommand<object>((p) =>
              {
                  if (tongSoBanThem != null)
                      return true;
                  return false;
              },(p)=>
              {
                  for (int i = 0; i < tongSoBanThem; i++)
                  {
                     
                      BANAN table = DataProvider.Ins.DB.BANANs.Where(x => x.soban == sum).SingleOrDefault();
                      DataProvider.Ins.DB.BANANs.Remove(table);
                      DataProvider.Ins.DB.SaveChanges();
                      sum--;
                  }
                  TongSoBan = "Tổng số bàn là " + sum;
              });
        }
    }
}
