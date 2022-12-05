using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICungCapRepository
    {
        bool add(Cungcap cungcap);
        bool update(Cungcap cungcap);
        bool delete(Cungcap cungcap);
        List<Cungcap> GetAll();
    }
}
