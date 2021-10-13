using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuanAn.Model
{
    class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DataProvider();
                return _ins;
            }
            set { _ins = value; }
        }
        public QLQUAN_ANEntities DB { get; set; }
        //public QLQuanAnDataContext db { get; set; }
        public DataProvider()
        {
            DB = new QLQUAN_ANEntities();
            //db = new QLQuanAnDataContext();
        }
    }
}
