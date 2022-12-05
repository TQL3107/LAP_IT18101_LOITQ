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
    public class CungCapRepository : ICungCapRepository
    {
        FpolyDBContext context = new FpolyDBContext();
        public bool add(Cungcap cungcap)
        {
            throw new NotImplementedException();
        }

        public bool delete(Cungcap cungcap)
        {
            throw new NotImplementedException();
        }

        public List<Cungcap> GetAll()
        {
            return context.Cungcaps.ToList();
        }

        public bool update(Cungcap cungcap)
        {
            throw new NotImplementedException();
        }
    }
}
