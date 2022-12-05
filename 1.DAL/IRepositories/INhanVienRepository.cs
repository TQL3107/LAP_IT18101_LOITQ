using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool add(Nhanvien nhanvien);
        bool update(Nhanvien nhanvien);
        bool delete(Nhanvien nhanvien);
        List<Nhanvien> getAll();
    }
}
