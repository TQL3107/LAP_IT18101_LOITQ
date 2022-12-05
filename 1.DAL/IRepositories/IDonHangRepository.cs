using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositoris
{
    public interface IDonHangRepository
    {
        bool add(Donhang donhang);
        bool delete(Donhang donhang);   
        bool update(Donhang donhang);
        List<Donhang> GetAll();
    }
}
