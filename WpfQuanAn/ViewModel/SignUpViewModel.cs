using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using WpfQuanAn.Model;
using System.Collections;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace WpfQuanAn.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {
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

        private string _userName;
        public string userName { get => _userName; set { _userName = value; OnPropertyChanged(); } }

        private string _pass;
        public string Pass { get => _pass; set { _pass = value; OnPropertyChanged(); } }

        private string _mess;
        public string mess { get => _mess; set { _mess = value; OnPropertyChanged(); } }

        private string _ComfrimPass;
        public string ComfirmPass { get => _ComfrimPass; set { _ComfrimPass = value; OnPropertyChanged(); } }

        private string _fullName;
        public string fullName { get => _fullName; set { _fullName = value; OnPropertyChanged(); } }

        private int? _role;
        public int? role { get => _role; set { _role = value; OnPropertyChanged(); } }

        private bool _IsSelected;
        public bool IsSelected { get => _IsSelected; set { _IsSelected = value; OnPropertyChanged(); } }

        public ICommand ICommandSingup { get; set; }
        public ICommand ICommandCancel { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand ComfirmPasswordChangedCommand { get; set; }

        public SignUpViewModel()
        {
            ListNV = new ObservableCollection<getNVCreateAcc_Result>(DataProvider.Ins.DB.getNVCreateAcc());
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Pass = p.Password; });
            ComfirmPasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { ComfirmPass = p.Password; });

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
                        DataProvider.Ins.DB.SaveChanges();
                        p.Close();

                    }
                    else
                    {
                        mess = "Nhập lại mật khẩu không khớp";
                    }
                });

            ICommandCancel = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) => {
                Pass = null;
                p.Close();
            });
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
