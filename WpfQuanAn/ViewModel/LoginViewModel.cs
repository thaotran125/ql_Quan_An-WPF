using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


using WpfQuanAn.Model;

namespace WpfQuanAn.ViewModel
{
    public class LoginViewModel:BaseViewModel
    {
        public bool IsLogin { get; set; }

        public int role { get; set; }

        private string _userName;
        public string userName { get => _userName; set { _userName = value; OnPropertyChanged(); } }

        private string _pass;
        public string Pass { get => _pass; set { _pass = value; OnPropertyChanged(); } }

        private string _mess;
        public string mess { get => _mess; set { _mess = value; OnPropertyChanged(); } }

        public ICommand ICommandlogin { get; set; }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand ICommandCancel { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public LoginViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                IsLogin = false;
                userName = "";
                Pass = "";
                mess = "";
                DungChung.idNV = 0;
                role = -1;
            });
            

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Pass = p.Password; });

            ICommandlogin = new RelayCommand<Window>((p) => { return true; },
                (p) => {
                    Login(p);
                    //if (p == null)
                    //    return;
                    //account acc = DataProvider.Ins.DB.accounts.Where(x => x.userNanme == userName && x.password == Pass).SingleOrDefault();
                    //if (acc != null)
                    //{
                    //    IsLogin = true;
                    //    DungChung.idNV = (int)acc.idnv;
                    //    DungChung.role = (int)acc.isAdmin;
                    //    p.Close();
                    //}
                    //else
                    //{
                    //    IsLogin = false;
                    //    Pass = null;
                    //    mess="Sai tài khoản hoặc mật khẩu!";
                    //}
                });

            ICommandCancel = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) => {
                Pass = null;
                p.Close();
            });
        }

        void Login(Window p)
        {
            if (p == null)
                return;
            string passEncode = MD5Hash(Base64Encode(Pass));

            var accCount = DataProvider.Ins.DB.accounts.Where(x => x.userNanme == userName && x.password == passEncode).SingleOrDefault();

            if (accCount != null)
            {
                IsLogin = true;
                DungChung.idNV = (int)accCount.idnv;
                DungChung.role = (int)accCount.isAdmin;
                p.Close();
            }
            else
            {
                IsLogin = false;
                Pass = null;
                mess="Sai tài khoản hoặc mật khẩu!";
            }
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
