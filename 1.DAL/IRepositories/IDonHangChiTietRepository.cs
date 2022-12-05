using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDonHangChiTietRepository
    {
        bool add(DonhangChitiet donhangChitiet);
        bool remove(DonhangChitiet donhangChitiet);
        bool update(DonhangChitiet donhangChitiet);
        List<DonhangChitiet> GetAll();  
        
    }
}
