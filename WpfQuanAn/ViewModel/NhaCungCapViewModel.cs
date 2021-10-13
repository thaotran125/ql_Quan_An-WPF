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
    public class NhaCungCapViewModel:BaseViewModel
    {
        private ObservableCollection<NHACUNGCAP> _List;
        public ObservableCollection<NHACUNGCAP> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private string _ten;
        public string ten { get => _ten; set { _ten = value; OnPropertyChanged(); } }

        private string _sdt;
        public string sdt { get => _sdt; set { _sdt = value; OnPropertyChanged(); } }

        private string _mail;
        public string mail { get => _mail; set { _mail = value; OnPropertyChanged(); } }

        private string _dc;
        public string dc { get => _dc; set { _dc = value; OnPropertyChanged(); } }

        private NHACUNGCAP _SelectedItem;
        public NHACUNGCAP SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    ten = SelectedItem.tennhacung;
                    sdt = SelectedItem.sdtncc;
                    mail = SelectedItem.mailncc;
                    dc = SelectedItem.dcncc;
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Restart { get; set; }

        public NhaCungCapViewModel()
        {
            List = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);

            AddCommand = new RelayCommand<object>((p) =>
              {
                  if (ten == null || sdt == null || mail == null || dc == null || SelectedItem!=null)
                      return false;
                  return true;
              },(p)=> {
                  var ncc = new NHACUNGCAP() {tennhacung=ten, sdtncc=sdt, mailncc=mail, dcncc=dc };
                  DataProvider.Ins.DB.NHACUNGCAPs.Add(ncc);
                  DataProvider.Ins.DB.SaveChanges();
                  List.Add(ncc);
                  reseet();
              });

            EditCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItem == null)
                      return false;
                  var ncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.idnhacc == SelectedItem.idnhacc).SingleOrDefault();
                  if (ncc == null)
                      return false;
                  return true;
              },(p)=> {
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      var ncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.idnhacc == SelectedItem.idnhacc).SingleOrDefault();
                      ncc.tennhacung = ten;
                      ncc.sdtncc = sdt;
                      ncc.mailncc = mail;
                      ncc.dcncc = dc;
                      DataProvider.Ins.DB.SaveChanges();
                      List = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
                      reseet();
                  }
              });

            DeleteCommand = new RelayCommand<object>((p) =>
             {
                 if (SelectedItem == null)
                     return false;
                 var ncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.idnhacc == SelectedItem.idnhacc).SingleOrDefault();
                 if (ncc == null)
                     return false;
                 return true;
             },(p)=> {
                 var ncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.idnhacc == SelectedItem.idnhacc).SingleOrDefault();
                 MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa nhân viên" + ncc.tennhacung.ToString(), "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                 if (deleteRecord == MessageBoxResult.Yes)
                 {
                    DataProvider.Ins.DB.NHACUNGCAPs.Remove(ncc);
                    DataProvider.Ins.DB.SaveChanges();
                    List.Remove(ncc);
                    reseet();
                 }
             });
            Restart = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null & ten == null && sdt == null && mail == null && dc == null)
                    return false;
                return true;
            }, (p) =>
            {
                reseet();
            });
            reseet();
        }

        public void reseet()
        {
            SelectedItem = null;
            ten = null;
            sdt = null;
            mail = null;
            dc = null;
        }
    }
}
