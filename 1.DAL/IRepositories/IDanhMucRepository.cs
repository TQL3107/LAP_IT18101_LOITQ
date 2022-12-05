using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDanhMucRepository
    {
        bool add(Danhmuc danhmuc);
        bool delete(Danhmuc danhmuc);
        bool update(Danhmuc danhmuc);
        List<Danhmuc> getAll();
    }
}
