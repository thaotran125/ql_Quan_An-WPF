using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using WpfQuanAn.Model;
using WpfQuanAn.view;
using System.Collections;
using System.Security.Cryptography;
using System.Windows.Controls;

namespace WpfQuanAn.ViewModel
{
    public class AccountViewModel:BaseViewModel
    {
        private ObservableCollection<account> _List;
        public ObservableCollection<account> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<getNVCreateAcc_Result> _ListNV;
        public ObservableCollection<getNVCreateAcc_Result> ListNV { get => _ListNV; set { _ListNV = value; OnPropertyChanged(); } }

        private getNVCreateAcc_Result _SelectedItemNV;
        public getNVCreateAcc_Result SelectedItemNV
        {
            get => _SelectedItemNV; set
            {
                _SelectedItemNV = value;
                OnPropertyChanged();
            }
        }

        private account _SelectedItem;
        public account SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    userName = SelectedItem.userNanme;
                    tenNV = SelectedItem.NHANVIEN.tennv;
                    sdtnv = SelectedItem.NHANVIEN.sdtnv;
                    mail = SelectedItem.NHANVIEN.mail;
                    dcnv = SelectedItem.NHANVIEN.dcnv;
                    ngaysinh = SelectedItem.NHANVIEN.ngaysinh;
                    gioiTInh = SelectedItem.NHANVIEN.gioitinh;
                }
            }
        }

        private string _userName;
        public string userName { get => _userName; set { _userName = value; OnPropertyChanged(); } }

        private string _pass;
        public string Pass { get => _pass; set { _pass = value; OnPropertyChanged(); } }

        private string _ComfrimPass;
        public string ComfirmPass { get => _ComfrimPass; set { _ComfrimPass = value; OnPropertyChanged(); } }

        private string _fullName;
        public string fullName { get => _fullName; set { _fullName = value; OnPropertyChanged(); } }

        private int? _role;
        public int? role { get => _role; set { _role = value; OnPropertyChanged(); } }

        private bool _IsSelected;
        public bool IsSelected { get => _IsSelected; set { _IsSelected = value; OnPropertyChanged(); } }

        private string _mess;
        public string mess { get => _mess; set { _mess = value; OnPropertyChanged(); } }
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

        private DateTime? _ngaysinh;
        public DateTime? ngaysinh { get => _ngaysinh; set { _ngaysinh = value; OnPropertyChanged(); } }

        private string _gioiTInh;
        public string gioiTInh { get => _gioiTInh; set { _gioiTInh = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CofirmDeleteCommand { get; set; }
        public ICommand Restart { get; set; }
        public ICommand ICommandCancel { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand ICommandSingup { get; set; }
        public ICommand ComfirmPasswordChangedCommand { get; set; }

        public ICommand ICommandlogin { get; set; }

        public AccountViewModel()
        {
            //ListRole = new ObservableCollection<getIsAdmin_Result>(DataProvider.Ins.DB.getIsAdmin());
            //ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
            List = new ObservableCollection<account>(DataProvider.Ins.DB.accounts.Where(x => x.isAdmin == 0));
            ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Pass = p.Password; });
            ComfirmPasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { ComfirmPass = p.Password; });
            AddCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SignUpWindow wd = new SignUpWindow();
                wd.ShowDialog();
                ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
                List.Clear();
                List = new ObservableCollection<account>(DataProvider.Ins.DB.accounts.Where(x => x.isAdmin == 0));

            });

            ICommandSingup = new RelayCommand<Window>((p) => { return true; },
                (p) => {
                    string passEncode = MD5Hash(Base64Encode(Pass));
                    //string comfirmEncode = MD5Hash(Base64Encode(ComfirmPass));
                    if (Pass.Equals(ComfirmPass))
                    {
                        int isAdim = 0;
                        isAdim = IsSelected == true ? 1 : 0;
                        account acc = new account() { userNanme = userName, password = passEncode, idnv = SelectedItemNV.idnv, isAdmin = isAdim };
                        DataProvider.Ins.DB.accounts.Add(acc);
                        //List.Add(acc);
                        DataProvider.Ins.DB.SaveChanges();
                        p.Close();
                        List = new ObservableCollection<account>(DataProvider.Ins.DB.accounts.Where(x => x.isAdmin == 0));
                        ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());

                        reset();
                    }
                    else
                    {
                        Pass = null;
                        ComfirmPass = null;
                        mess = "Nhập lại mật khẩu không khớp";
                    }
                });

            EditCommand = new RelayCommand<object>((p) => {
                if (SelectedItemNV != null)
                    return true;
                return false;
            }, (p) => {
                account acc = DataProvider.Ins.DB.accounts.Where(x => x.userNanme == SelectedItem.userNanme).SingleOrDefault();
                MessageBoxResult editRecord = MessageBox.Show("bạn set password", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (editRecord == MessageBoxResult.Yes)
                {
                    acc.password = "6fd742a61bd034804c00c49b18045020";
                    DataProvider.Ins.DB.SaveChanges();
                    reset();
                }

            });
            DeleteCommand = new RelayCommand<Window>((p) =>
            {
                if (SelectedItem != null)
                    return true;
                return false;
            }, (p) => {
                ComfirmDelAccountWD wd = new ComfirmDelAccountWD();
                wd.ShowDialog();
                ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
            });

            CofirmDeleteCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) => {

                if (Pass.Equals("0000"))
                {
                    MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa Account", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (deleteRecord == MessageBoxResult.Yes)
                    {
                        account acc = DataProvider.Ins.DB.accounts.Where(x => x.userNanme == SelectedItem.userNanme).SingleOrDefault();
                        DataProvider.Ins.DB.accounts.Remove(acc);
                        DataProvider.Ins.DB.SaveChanges();
                        List.Remove(acc);
                        reset();
                        p.Close();
                        ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
                    }

                }
                else
                {
                    Pass = null;
                    mess = "PassWord không đúng";
                }
            });

            ICommandCancel = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) => {
                Pass = null;
                p.Close();
            });

            Restart = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                List = new ObservableCollection<account>(DataProvider.Ins.DB.accounts.Where(x => x.isAdmin == 0));
            });

        }

        public void reset()
        {
            userName = null;

            tenNV = null;
            sdtnv = null;
            mail = null;
            dcnv = null;
            gioiTInh = null;
            ngaysinh = null;
            SelectedItem = null;
            SelectedItemNV = null;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

    }
}
