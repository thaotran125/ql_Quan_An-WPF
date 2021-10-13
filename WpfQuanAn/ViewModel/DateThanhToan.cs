using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuanAn.ViewModel
{
    public class DateThanhToan
    {
        public int idbill { get; set; }
        public int idfood { get; set; }
        public string tennv { get; set; }
        public int soban { get; set; }
        public System.DateTime checkin { get; set; }
        public System.DateTime checkout { get; set; }
        public string tenfood { get; set; }
        public string size { get; set; }
        public int slOrder { get; set; }
        public double chietKhau { get; set; }
        public double gia { get; set; }
        public int tienKhachTra { get; set; }
        public double total { get; set; }
    }
}
