using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool add(Sanpham sanpham);
        bool update(Sanpham sanpham);
        bool delete(Sanpham sanpham);
        List<Sanpham> GetAll();
    }
}
