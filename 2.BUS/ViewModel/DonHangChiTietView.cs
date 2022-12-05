using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class DonHangChiTietView
    {
        public Cungcap cungcap { get; set; }
        public Danhmuc danhmuc { get; set; }
        public DonhangChitiet donhangChitiet { get; set; }  
        public Khachhang khachhang { get; set; }
        public Donhang donhang { get; set; }

    }
}
