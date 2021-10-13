using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using WpfQuanAn.Model;
using WpfQuanAn.view;

namespace WpfQuanAn.ViewModel
{
    public class BanHangViewModel : BaseViewModel
    {
        private ObservableCollection<BANAN> _ListBan;
        private ObservableCollection<LOAIFOOD> _listLoaiFood;
        private List<FOOD> _ListFood;
        private List<CTBILL> _listCtbill;
        private List<BANAN> _listBanTrong;
        private List<BANAN> _listBanCoNguoi;
        private List<KHACHHANG> _ListKH;
        private KHACHHANG _SelecteditemKH;
        private LOAIFOOD _SelectedItemLoaiFood;
        private FOOD _SelectedItemMonAn;
        private CTBILL _SelectedItemCTBill;
        private BANAN _selectedbanChuyen;
        private BANAN _selectedbanSeChuyen;
        private BANAN _selectedbanMuonGop;
        private BANAN _selectedbanDuocGop;
        private int _selectedTien;


        private string _tenban;
        private string _tenloaifood;
        private string _tenfood;
        private string _tenKH;

        private float _chietkhau;

        private int? _slOrder;
        private int? _slOrderAdd;

        private string _lbTieuDe;
        private string _TongTien;
        private string _tongChietKhau;
        private string _thanhTien;
        private double _tienKhachDua;
        private string _tienTraLai;
        private string _total;

        private string _discount;
        public string discount { get => _discount; set { _discount = value; OnPropertyChanged(); } }


        /// //////////////////////////////
        // public bool EnableListFood { get => _EnableListFood; set { _EnableListFood = value; OnPropertyChanged(); } }
        private string _mess;
        public string mess { get => _mess; set { _mess = value; OnPropertyChanged(); } }
        private string _pass;
        public string Pass { get => _pass; set { _pass = value; OnPropertyChanged(); } }


        public string tenban { get => _tenban; set { _tenban = value; OnPropertyChanged(); } }



        public string tenloaifood { get => _tenloaifood; set { _tenloaifood = value; OnPropertyChanged(); } }

        /// ////////////////////////////////////

        public string tenfood { get => _tenfood; set { _tenfood = value; OnPropertyChanged(); } }



        public string tenKH { get => _tenKH; set { _tenKH = value; OnPropertyChanged(); } }
        /// ////////////////////////////////////////////////////////////

        public float chietkhau { get => _chietkhau; set { _chietkhau = value; OnPropertyChanged(); } }
        /// ///////////////////////////////

        public int? slOrder { get => _slOrder; set { _slOrder = value; OnPropertyChanged("slOrder"); } }

        public int? slOrderAdd { get => _slOrderAdd; set { _slOrderAdd = value; OnPropertyChanged("slOrder"); } }


        public string lbTieuDe { get => _lbTieuDe; set { _lbTieuDe = value; OnPropertyChanged(); } }

        public string TongTien { get => _TongTien; set { _TongTien = value; OnPropertyChanged(); } }

        public string ThanhTien { get => _total; set { _total = value; OnPropertyChanged(); } }

        public int slChange;

        int idnv = 0;

        public string tongChietKhau { get => _tongChietKhau; set { _tongChietKhau = value; OnPropertyChanged(); } }
        public string thanhTien { get => _thanhTien; set { _thanhTien = value; OnPropertyChanged(); } }
        public double tienKhachDua { get => _tienKhachDua; set { _tienKhachDua = value; OnPropertyChanged(); } }
        public string tienTraLai { get => _tienTraLai; set { _tienTraLai = value; OnPropertyChanged(); } }


        //public ICommand TimBanTrong { get; set; }
        public ICommand LoadedCommand { get; set; }
        public ICommand LoadedWindowReportCommand { get; set; }

        public ICommand XoaMonCommand { get; set; }
        public ICommand EditMonCommand { get; set; }
        public ICommand ChuyenBanCommand { get; set; }
        public ICommand GopBanCommand { get; set; }
        public ICommand ThanhToanCommand { get; set; }
        public ICommand InBillCommand { get; set; }
        public ICommand ComfirmChuyenBanCommand { get; set; }
        public ICommand ComfirmAddFoodCommand { get; set; }
        public ICommand ComfirmDelFoodCommand { get; set; }
        public ICommand ComfirmGopBanCommand { get; set; }
        public ICommand ComfirmThanhToanCommand { get; set; }
        public ICommand ICommandCancel { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand backHomeCommand { get; set; }
        public ICommand ICommandOk { get; set; }
        public ICommand TextChangedCommand { get; set; }
        public ICommand CommandCong { get; set; }
        public ICommand CommandTru { get; set; }
        public ICommand TextChangedSLCommand { get; set; }
        public ICommand LoadedAddOrderCommand { get; set; }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>
        public ObservableCollection<BANAN> ListBan { get => _ListBan; set { _ListBan = value; OnPropertyChanged(); } }

        public ObservableCollection<LOAIFOOD> listLoaiFood { get => _listLoaiFood; set { _listLoaiFood = value; OnPropertyChanged(); } }

        public List<FOOD> ListFood { get => _ListFood; set { _ListFood = value; OnPropertyChanged(); } }

        public List<CTBILL> listCtbill { get => _listCtbill; set { _listCtbill = value; OnPropertyChanged(); } }

        public List<BANAN> listBanTrong { get => _listBanTrong; set { _listBanTrong = value; OnPropertyChanged(); } }

        public List<BANAN> listBanCoNguoi { get => _listBanCoNguoi; set { _listBanCoNguoi = value; OnPropertyChanged(); } }

        public List<KHACHHANG> ListKH { get => _ListKH; set { _ListKH = value; OnPropertyChanged(); } }
        public CrystalDecisions.CrystalReports.Engine.ReportDocument Report { get; set; }

        private int idbill = 0;


        public LOAIFOOD SelectedItemLoaiFood
        {
            get => _SelectedItemLoaiFood;
            set
            {
                _SelectedItemLoaiFood = value; OnPropertyChanged();
                if (SelectedItemLoaiFood != null)
                {
                    tenloaifood = SelectedItemLoaiFood.tenloaifood;
                    ListFood = new List<FOOD>(DataProvider.Ins.DB.FOODs.Where(x => x.idloaifood == SelectedItemLoaiFood.idloaifood));
                }
            }
        }

        public FOOD SelectedItemMonAn
        {
            get => _SelectedItemMonAn;
            set
            {
                _SelectedItemMonAn = value;
                if (SelectedItemMonAn != null)
                {
                    int idCheck = getIdBill(soban);
                    bool check = false;
                    listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idCheck));
                    if (listCtbill !=null)
                    {
                        foreach(CTBILL item in listCtbill)
                        {
                            if (item.idfood == SelectedItemMonAn.idfood)
                            {
                                item.slOrder += 1;
                                DataProvider.Ins.DB.SaveChanges();
                                check = true;
                            }
                        }
                        if(check==true)
                            MessageBox.Show("them so luong thanh cong");
                        else
                        {
                            ComfirmAddOrderWindow wd = new ComfirmAddOrderWindow();
                            wd.ShowDialog();
                        }
                    }
                    else
                    {

                        ComfirmAddOrderWindow wd = new ComfirmAddOrderWindow();
                        wd.ShowDialog();
                    }
                    int idBillNew = getIdBill(soban);
                    listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idBillNew)).ToList();
                }
            }
        }

        public CTBILL SelectedItemCTBill
        {
            get => _SelectedItemCTBill;
            set
            {
                _SelectedItemCTBill = value; OnPropertyChanged();
                if (SelectedItemCTBill != null)
                {
                    slOrder = (int)SelectedItemCTBill.slOrder;
                }
            }
        }

        public BANAN selectedbanChuyen { get => _selectedbanChuyen; set { _selectedbanChuyen = value; OnPropertyChanged(); } }

        public BANAN selectedbanSeChuyen { get => _selectedbanSeChuyen; set { _selectedbanSeChuyen = value; OnPropertyChanged(); } }

        public BANAN selectedbanMuonGop { get => _selectedbanMuonGop; set { _selectedbanMuonGop = value; OnPropertyChanged(); } }

        public BANAN selectedbanDuocGop { get => _selectedbanDuocGop; set { _selectedbanDuocGop = value; OnPropertyChanged(); } }

        public int selectedTien { get => _selectedTien; set { _selectedTien = value; OnPropertyChanged(); } }

        public KHACHHANG SelectedItemKH
        {
            get => _SelecteditemKH; set
            {
                _SelecteditemKH = value; OnPropertyChanged();
                if (SelectedItemKH != null)
                    tenKH = SelectedItemKH.tenkh;
            }
        }

        //public CrystalDecisions.CrystalReports.Engine.ReportDocument Report { get; set; }
        public int soban;
        public double thanhTienTemp = 0;

        public BanHangViewModel()
        {

            listLoaiFood = new ObservableCollection<LOAIFOOD>(DataProvider.Ins.DB.LOAIFOODs);

            ListKH = new List<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs).ToList();
            var nv = DataProvider.Ins.DB.NHANVIENs.Where(x => x.idnv == DungChung.idNV).SingleOrDefault();
            idnv = nv.idnv;
            //listCtbill = new ObservableCollection<loadCTBillResult>(DataProvider.Ins.db.loadCTBill(idfood)).ToList();
            LoadedCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                soban = DungChung.soban;
                idbill = (int)getIdBill(soban);
                chietkhau = getKhuyenMai();
                if (chietkhau == 0)
                {
                    List<FOOD> listF = new List<FOOD>(DataProvider.Ins.DB.FOODs).ToList();
                    foreach (FOOD f in listF)
                    {
                        f.idkm = 1;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                discount = chietkhau.ToString("0,0.0", CultureInfo.InvariantCulture);
                SelectedItemMonAn = null;
                SelectedItemKH = null;

                //MessageBox.Show("id bill " + idbill.ToString()+" so ban "+soban.ToString());
                lbTieuDe = "Bill của bàn " + soban + " checkin " + DateTime.Now;

                if (idbill != -1)
                {
                    listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idbill));
                    if (listCtbill.Count > 0)
                        BindingTongTien(listCtbill);
                }
                else
                {
                    TongTien = null;
                    tongChietKhau = null;
                    listCtbill = null;
                    ListFood = null;
                    SelectedItemKH = null;
                }
            });

            ComfirmAddFoodCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                try
                {
                    int idBillNew = getIdBill(soban);
                    tenfood = SelectedItemMonAn.tenfood;
                    if (idBillNew != -1)  //bill  exists
                    {

                        CTBILL ctbill = new CTBILL() { idbill = idBillNew, idfood = SelectedItemMonAn.idfood, slOrder = slOrderAdd };
                        DataProvider.Ins.DB.CTBILLs.Add(ctbill);
                        DataProvider.Ins.DB.SaveChanges();
                        listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idBillNew)).ToList();
                        //listCtbill.Add(ctbill);
                        BindingTongTien(listCtbill);

                    }
                    else //bill not exists
                    {
                        BILL bill = new BILL();
                        if (SelectedItemKH == null)
                        {
                            bill = new BILL() { idnv = idnv, idkh = 1, soban = soban, checkin = DateTime.Now, checkout = DateTime.Now, tinhtrang = 0, chietkhau = 0 };
                        }
                        else
                        {
                            bill = new BILL() { idnv = idnv, idkh = SelectedItemKH.idkh, soban = soban, checkin = DateTime.Now, checkout = DateTime.Now, tinhtrang = 0, chietkhau = 0 };
                        }

                        DataProvider.Ins.DB.BILLs.Add(bill);
                        DataProvider.Ins.DB.SaveChanges();
                        var ban = DataProvider.Ins.DB.BANANs.Where(x => x.soban == soban).SingleOrDefault();
                        ban.tinhtrang = 1;
                        DataProvider.Ins.DB.SaveChanges();
                        //add bill detail
                        idBillNew = getIdBill(soban);

                        CTBILL ctbill = new CTBILL() { idbill = idBillNew, idfood = SelectedItemMonAn.idfood, slOrder = slOrderAdd };
                        DataProvider.Ins.DB.CTBILLs.Add(ctbill);
                        DataProvider.Ins.DB.SaveChanges();

                        listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idBillNew)).ToList();
                        BindingTongTien(listCtbill);

                        //ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                p.Close();
            });

            EditMonCommand = new RelayCommand<object>((p) =>
              {
                  if (SelectedItemCTBill != null)
                      return true;
                  return false;
              }, (p) =>
              {
                  //int idBillNew = getIdBill(soban);
                  CTBILL ctbill = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == SelectedItemCTBill.idbill && x.idfood == SelectedItemCTBill.idfood).SingleOrDefault();
                  MessageBoxResult editRecord = MessageBox.Show("bạn muốn lưu thay đổi", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                  if (editRecord == MessageBoxResult.Yes)
                  {
                      ctbill.slOrder = slOrder;
                      DataProvider.Ins.DB.SaveChanges();
                      listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == SelectedItemCTBill.idbill)).ToList();
                      BindingTongTien(listCtbill);
                      SelectedItemCTBill = null;
                  }

              });

            XoaMonCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCTBill == null)
                    return false;
                var displayListCtBill = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idbill && x.idfood == SelectedItemCTBill.idfood);
                if (displayListCtBill == null && displayListCtBill.Count() == 0)
                    return false;
                return true;
            }, (p) =>
            {
                ComfirmDelFoodWD wd = new ComfirmDelFoodWD();
                wd.ShowDialog();
                listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == SelectedItemCTBill.idbill)).ToList();
                SelectedItemCTBill = null;
            });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Pass = p.Password; });
            ComfirmDelFoodCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (Pass.Equals("0000"))
                {

                    MessageBoxResult deleteRecord = MessageBox.Show("bạn muốn xóa", "the question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (deleteRecord == MessageBoxResult.Yes)
                    {
                        CTBILL CtBill = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == SelectedItemCTBill.idbill && x.idfood == SelectedItemCTBill.idfood).SingleOrDefault();
                        DataProvider.Ins.DB.CTBILLs.Remove(CtBill);
                        DataProvider.Ins.DB.SaveChanges();
                        MessageBox.Show("xoa thanh cong");
                        listCtbill.Remove(CtBill);
                        if (listCtbill.Count == 0)
                        {
                            BILL bill = DataProvider.Ins.DB.BILLs.Where(x => x.idbill == SelectedItemCTBill.idbill).SingleOrDefault();
                            DataProvider.Ins.DB.BILLs.Remove(bill);
                            BANAN ban = DataProvider.Ins.DB.BANANs.Where(x => x.soban == soban).SingleOrDefault();
                            ban.tinhtrang = 0;
                            DataProvider.Ins.DB.SaveChanges();
                        }
                        else
                        {
                            BindingTongTien(listCtbill);
                        }

                        p.Close();
                    }

                }
                else
                {
                    Pass = null;
                    mess = "PassWord không đúng";
                }
            });

            ChuyenBanCommand = new RelayCommand<UserControl>((p) =>
            {
                if (listBanCoNguoi.Count() > 0)
                    return true;
                return false;
            }, (p) =>
            {
                listBanTrong = new List<BANAN>(DataProvider.Ins.DB.BANANs.Where(x => x.tinhtrang == 0)).ToList();
                listBanCoNguoi = new List<BANAN>(DataProvider.Ins.DB.BANANs.Where(x => x.tinhtrang == 1)).ToList();
                ChuyenBanWindow wd = new ChuyenBanWindow();
                wd.ShowDialog();
                TongTien = null;
                tongChietKhau = null;
                listCtbill = null;
                ListFood = null;
                SelectedItemKH = null;
            });
            ComfirmChuyenBanCommand = new RelayCommand<Window>((p) =>
            {
                if (selectedbanChuyen == null && selectedbanSeChuyen == null)
                    return false;
                return true;
            }, (p) =>
            {
                int idbillcanchuyen = getIdBill(selectedbanChuyen.soban);
                BILL bill = DataProvider.Ins.DB.BILLs.Where(x => x.idbill == idbillcanchuyen).SingleOrDefault();
                bill.soban = selectedbanSeChuyen.soban;
                DataProvider.Ins.DB.SaveChanges();

                BANAN ban = DataProvider.Ins.DB.BANANs.Where(x => x.soban == selectedbanChuyen.soban).SingleOrDefault();
                ban.tinhtrang = 0;
                DataProvider.Ins.DB.SaveChanges();

                BANAN banduocChuyen = DataProvider.Ins.DB.BANANs.Where(x => x.soban == selectedbanSeChuyen.soban).SingleOrDefault();
                banduocChuyen.tinhtrang = 1;
                DataProvider.Ins.DB.SaveChanges();
                ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);
                selectedbanChuyen = null; selectedbanSeChuyen = null;
                //pageThongBao wd = new pageThongBao();
                //wd.Show();
                p.Close();
            });
            GopBanCommand = new RelayCommand<object>((p) =>
            {
                if (listBanCoNguoi.Count() > 0)
                    return true;
                return false;
            }, (p) =>
            {
                listBanCoNguoi = new List<BANAN>(DataProvider.Ins.DB.BANANs.Where(x => x.tinhtrang == 1)).ToList();
                GopBanWindow wd = new GopBanWindow();

                wd.ShowDialog();
                TongTien = null;
                tongChietKhau = null;
                listCtbill = null;
                ListFood = null;
                SelectedItemKH = null;
            });
            ComfirmGopBanCommand = new RelayCommand<Window>((p) =>
            {
                if (selectedbanMuonGop == null && selectedbanDuocGop == null)
                    return false;
                return true;
            }, (p) =>
            {
                try
                {
                    int idbillgop = getIdBill(selectedbanMuonGop.soban);
                    int idbillBanDuocgop = getIdBill(selectedbanDuocGop.soban);

                    List<CTBILL> listgopban = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idbillgop).ToList();
                    List<CTBILL> listbanDuocGop = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idbillBanDuocgop).ToList();
                    foreach (var ctbillDuocGop in listbanDuocGop)
                    {
                        int sl = 0;
                        foreach (var mainCtbill in listgopban)
                        {
                            if (ctbillDuocGop.idfood == mainCtbill.idfood)
                            {
                                sl = (int)(mainCtbill.slOrder + ctbillDuocGop.slOrder);
                                //CTBILL editct = DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == mainCtbill.idfood && x.idfood == mainCtbill.idfood).SingleOrDefault();
                                mainCtbill.slOrder = sl;
                                DataProvider.Ins.DB.SaveChanges();
                            }
                        }
                        if (sl == 0)
                        {
                            var ctbilladd = new CTBILL() { idbill = idbillgop, idfood = ctbillDuocGop.idfood, slOrder = ctbillDuocGop.slOrder };
                            DataProvider.Ins.DB.CTBILLs.Add(ctbilladd);
                            DataProvider.Ins.DB.SaveChanges();
                        }
                    }

                    BANAN ban = DataProvider.Ins.DB.BANANs.Where(x => x.soban == selectedbanDuocGop.soban).SingleOrDefault();
                    ban.tinhtrang = 0;
                    DataProvider.Ins.DB.SaveChanges();
                    foreach (var ctbillDuocGop in listbanDuocGop)
                    {
                        DataProvider.Ins.DB.CTBILLs.Remove(ctbillDuocGop);
                        DataProvider.Ins.DB.SaveChanges();
                    }

                    BILL delBill = DataProvider.Ins.DB.BILLs.Where(x => x.idbill == idbillBanDuocgop).SingleOrDefault();
                    DataProvider.Ins.DB.BILLs.Remove(delBill);
                    DataProvider.Ins.DB.SaveChanges();

                    ListBan = new ObservableCollection<BANAN>(DataProvider.Ins.DB.BANANs);
                    selectedbanDuocGop = null; selectedbanMuonGop = null; listCtbill.Clear();
                    listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idbillgop)).ToList();
                    p.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            });
            ThanhToanCommand = new RelayCommand<BanAnUserControl>((p) =>
            {
                return true;
            }, (p) =>
            {
                int idNew = getIdBill(soban);
                listCtbill = new List<CTBILL>(DataProvider.Ins.DB.CTBILLs.Where(x => x.idbill == idNew)).ToList();
                BILL editbill = DataProvider.Ins.DB.BILLs.Where(x => x.idbill == idNew).SingleOrDefault();
                editbill.checkout = DateTime.Now;
                DataProvider.Ins.DB.SaveChanges();
                double TongTienTemp = 0; double tongChietKhauTemp = 0;
                foreach (CTBILL item in listCtbill)
                {
                    TongTienTemp += (double)(item.FOOD.gia * item.slOrder);
                    tongChietKhauTemp += ((double)item.FOOD.KHUYENMAI.chietKhau * (double)item.FOOD.gia);
                }
                thanhTienTemp = TongTienTemp - tongChietKhauTemp;
                thanhTien = thanhTienTemp.ToString("0,0.0", CultureInfo.InvariantCulture);
                TongTien = TongTienTemp.ToString("0,0.0", CultureInfo.InvariantCulture);
                tongChietKhau = tongChietKhauTemp.ToString("0,0.0", CultureInfo.InvariantCulture);
                ThanhToanWindow wd = new ThanhToanWindow();
                wd.ShowDialog();
                TongTien = null;
                tongChietKhau = null;
                listCtbill = null;
                ListFood = null;
                SelectedItemKH = null;


            });
            ComfirmThanhToanCommand = new RelayCommand<Window>((p) =>
            {
                if (tienKhachDua < thanhTienTemp)
                    return false;
                return true;
            }, (p) =>
            {
               int idNew = getIdBill(soban);
                BILL bill = DataProvider.Ins.DB.BILLs.Where(x => x.idbill == idNew).SingleOrDefault();
                bill.tinhtrang = 1;
                DataProvider.Ins.DB.SaveChanges();
                BANAN table = DataProvider.Ins.DB.BANANs.Where(x => x.soban == soban).SingleOrDefault();
                table.tinhtrang = 0;
                DataProvider.Ins.DB.SaveChanges();


                p.Close();
                Report = new RPTThanhToan();

                List<RPTinhTien_Result> listRP = DataProvider.Ins.DB.RPTinhTien(idNew, (int)tienKhachDua).ToList();
                List<DateThanhToan> listReport = new List<DateThanhToan>();
                foreach (var item in listRP)
                {
                    DateThanhToan re = new DateThanhToan();
                    re.idbill = item.idbill;
                    re.idfood = item.idfood;
                    re.tennv = item.tennv;
                    re.soban = (int)item.soban;
                    re.checkin = (DateTime)item.checkin;
                    re.checkout = (DateTime)item.checkout;
                    re.tenfood = item.tenfood;
                    re.size = item.size;
                    re.slOrder = (int)item.slOrder;
                    re.chietKhau = (float)item.chietKhau;
                    re.gia = (double)item.gia;
                    re.tienKhachTra = (int)item.tienKhachTra;
                    re.total = (double)item.total;
                    listReport.Add(re);
                }
                Report.SetDataSource(listReport);
                ReportBillWindow wd = new ReportBillWindow();
                wd.ShowDialog();
            });

            LoadedWindowReportCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
             {

             });

            TextChangedCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (tienKhachDua > thanhTienTemp)
                {
                    double tienthua = tienKhachDua - thanhTienTemp;
                    tienTraLai = tienthua.ToString("0,0.0", CultureInfo.InvariantCulture);
                }
                else
                    tienTraLai = null;

            });
            //slOrder = 1;

            LoadedAddOrderCommand = new RelayCommand<Window>((p) => { return true; },(p)=> {
                slOrderAdd = 1;
            });

            TextChangedSLCommand = new RelayCommand<TextBox>((p) => { return true; },(p)=> {
                //slOrderAdd = int.Parse(p.Text);
                slOrderAdd =int.Parse( p.Text);
            });

            CommandCong = new RelayCommand<object>((o) => { return true; }, (p) => {
                slOrderAdd++;
            });

            CommandTru = new RelayCommand<object>((p) => { 
                if(slOrderAdd>0)
                    return true;
                return false;
            }, (p) => {
                if (slOrderAdd <= 0)
                    slOrder = 0;
                else
                    slOrderAdd--;
            });

            backHomeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SelectedItemLoaiFood = null;
                soban = 0;
                idbill = -1;
                SelectedItemKH = null;
            });

            ICommandCancel = new RelayCommand<Window>((p) =>
           {
               return true;
           },
               (p) =>
               {
                   p.Close();
               });
        }

        public void reset()
        {
            idbill = -1;
            SelectedItemLoaiFood = null; SelectedItemMonAn = null; SelectedItemCTBill = null;
        }

        public int getIdBill(int soban)
        {
            BILL bill = new BILL();
            bill = (DataProvider.Ins.DB.BILLs.Where(x => x.soban == soban && x.tinhtrang == 0)).SingleOrDefault();

            if (bill == null)
                return -1;
            else
                return (int)bill.idbill;
        }

        public float getKhuyenMai()
        {

            var khuyenMai = DataProvider.Ins.DB.KHUYENMAIs.Where(x => x.ngayKT >= DateTime.Now).SingleOrDefault();
            if (khuyenMai == null)
                return 0;
            else
                return (float)khuyenMai.chietKhau;
        }

        public void BindingTongTien(List<CTBILL> ds)
        {
            double discount = 0;
            double total = 0;
            double temp = 0;
            foreach (var item in ds)
            {
                discount = discount + (double)(item.slOrder * (double)item.FOOD.gia * item.FOOD.KHUYENMAI.chietKhau);
                total = (double)(total + (item.slOrder * (double)item.FOOD.gia));
                temp = total - discount;
            }
            tongChietKhau = "Tổng giảm giá " + String.Format("{0:0.00}", discount);
            TongTien = "Tổng tiền bàn " + soban + " : " + String.Format("{0:0.00}", temp) + " VNĐ";
        }
    }
}
