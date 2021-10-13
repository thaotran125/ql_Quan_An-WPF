
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using WpfQuanAn.view;
using WpfQuanAn.Model;

namespace WpfQuanAn.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<BANAN> _ListBan;
        public ObservableCollection<BANAN> ListBan { get => _ListBan; set { _ListBan = value; OnPropertyChanged(); } }



        private string _tenBan;
        public string tenBan { get => _tenBan; set { _tenBan = value; OnPropertyChanged(); } }

        private int? _BanPhucVu;
        public int? BanPhucVu { get => _BanPhucVu; set { _BanPhucVu = value; OnPropertyChanged(); } }

        private int _SelectedItem;
        public int SelectedItem {  get  { return _SelectedItem; } set {  _SelectedItem = value;   OnPropertyChanged();}}

        private int _SelectedIndex;
        public int SelectedIndex { get => _SelectedIndex; set { _SelectedIndex = value; OnPropertyChanged(); } }

        public bool Isloaded = false;

        private string _tenNV;
        public string tenNV { get => _tenNV; set { _tenNV = value; OnPropertyChanged(); } }

        private bool _isVisible;
        public bool isVisible { get => _isVisible; set { _isVisible = value; OnPropertyChanged(); } }

        private bool _isVisibleKM;
        public bool isVisibleKM { get => _isVisibleKM; set { _isVisibleKM = value; OnPropertyChanged(); } }

        private bool _isVisibleacc;
        public bool isVisibleAcc { get => _isVisibleacc; set { _isVisibleacc = value; OnPropertyChanged(); } }

        private bool _isVisibleKD;
        public bool isVisibleNL { get => _isVisibleKD; set { _isVisibleKD = value; OnPropertyChanged(); } }

        private bool _isVisibleSetting;
        public bool isVisibleSetting { get => _isVisibleSetting; set { _isVisibleSetting = value; OnPropertyChanged(); } }

        public ICommand LoadedWindowCommand { get; set; }

        public ICommand CommandLogOut { get; set; }

        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<MainWindow>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin == true)
                {
                    p.Show();
                    ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);
                    BanPhucVu = DataProvider.Ins.DB.BANANs.Where(x => x.tinhtrang == 1).Count();
                    //int id = DungChung.idNV;
                    var nv = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == DungChung.idNV).SingleOrDefault();
                    tenNV = "Nhân Viên " + nv.tennv;
                    int role = DungChung.role;
                    //MessageBox.Show(role.ToString());
                    if (role == 0)
                    {
                        isVisible = false;
                        isVisibleKM = false;
                        isVisibleSetting = false;
                        isVisibleAcc = false;
                        isVisibleNL = false;
                    }
                    else if (role == 1)
                    {
                        isVisible = true;
                        isVisibleKM = true;
                        isVisibleSetting = true;
                        isVisibleAcc = true;
                        isVisibleNL = true;
                    }
                }
                else
                {
                    p.Close();
                }
            });

            CommandLogOut = new RelayCommand<MainWindow>((p) => { return true; },(p)=>{
                

                
                
            });
        }
    }
}
