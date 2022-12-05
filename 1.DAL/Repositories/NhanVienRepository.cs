using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        FpolyDBContext context = new FpolyDBContext();

        public bool add(Nhanvien nhanvien)
        {
            throw new NotImplementedException();
        }

        public bool delete(Nhanvien nhanvien)
        {
            throw new NotImplementedException();
        }

        public List<Nhanvien> getAll()
        {
            return context.Nhanviens.ToList();
        }

        public bool update(Nhanvien nhanvien)
        {
            throw new NotImplementedException();
        }
    }
}
