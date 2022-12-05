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
    public class DanhMucRepository : IDanhMucRepository
    {
        FpolyDBContext context = new FpolyDBContext();
        public bool add(Danhmuc danhmuc)
        {
            throw new NotImplementedException();
        }

        public bool delete(Danhmuc danhmuc)
        {
            throw new NotImplementedException();
        }

        public List<Danhmuc> getAll()
        {
            return context.Danhmucs.ToList();
        }

        public bool update(Danhmuc danhmuc)
        {
            throw new NotImplementedException();
        }
    }
}
