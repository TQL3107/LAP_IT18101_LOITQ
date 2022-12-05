using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class DonHangView
    {
        public Donhang Donhang { get; set; }
        public Shipper shipper { get; set; }
        public Khachhang khachhang { get; set; }
        public Nhanvien nhanvien { get; set; }
    }
}
