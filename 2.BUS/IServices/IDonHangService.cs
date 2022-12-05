
using _1.DAL.DomainClass;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2.BUS.IServices
{
    public interface IDonHangService
    {
        public string add(Donhang donhang);
        public string update(Donhang donhang);
        public string delete(Donhang donhang);
        List<Donhang> getAll();
        List<DonHangView> getallView();
    }
}
