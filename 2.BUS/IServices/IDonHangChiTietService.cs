using _1.DAL.DomainClass;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDonHangChiTietService
    {
        public string add(DonhangChitiet donhangChitiet);
        public string remove(DonhangChitiet donhangChitiet);
        public string update(DonhangChitiet donhangChitiet);
        List<DonhangChitiet> GetAll();
        List<DonHangChiTietView> GetViews();
    }
}
